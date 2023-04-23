Imports System.Speech.Synthesis
Imports Guna.UI2.WinForms

Public Class CheckData

#Region "Property"

    Private WithEvents customer As CustomerManager
    Private WithEvents login As Login
    Private WithEvents product As Product
    Private WithEvents user As UserManager
    Private WithEvents commToGui As CommToGui
    Private WithEvents commToDB As CommToDB
    Private WithEvents connector As ConnectToDB

#End Region

#Region "Constructe"
    Public Sub New(Optional customerControl As CustomerManager = Nothing, Optional loginControl As Login = Nothing, Optional productControl As Product = Nothing, Optional userControl As UserManager = Nothing)

        customer = customerControl
        login = loginControl
        user = userControl
        product = productControl

    End Sub

#End Region

#Region "Asign Init Value"
    Public WriteOnly Property AsignCommToDB As CommToDB

        Set(value As CommToDB)

            If value IsNot Nothing Then

                commToDB = value

            End If

        End Set

    End Property

    Public WriteOnly Property AsignCommToGui As CommToGui

        Set(value As CommToGui)

            If value IsNot Nothing Then

                commToGui = value

            End If

        End Set

    End Property
    Public WriteOnly Property AsignConnector As ConnectToDB

        Set(value As ConnectToDB)

            If value IsNot Nothing Then

                connector = value

            End If

        End Set

    End Property

#End Region

#Region "For Product"
    Public ReadOnly Property IsProdIdExist() As Boolean

        Get

            If product Is Nothing Then

                Return False

            End If

            Dim text As String = commToGui.GetTextFromProdId

            Return IsDataExist("PRODUCT", "PRODID", commToGui.GetTextFromProdId)


        End Get

    End Property

    Public ReadOnly Property IsProductDataChanged() As Boolean

        Get

            If product Is Nothing OrElse IsProdIdEmpty Then

                Return False

            End If

            Dim e1 As Exception = Nothing
            Dim e2 As Exception = Nothing

            Try

                e1 = CheckDataTable(commToGui.GetDTFromProduct)
                e2 = CheckDataTable(commToDB.GetProductFromDB(product.BuildSelectQuery("I")))

                If e1 IsNot Nothing Then

                    Throw e1

                ElseIf e2 IsNot Nothing Then

                    Throw e2

                Else

                    Dim dtGui = commToGui.GetDTFromProduct
                    Dim dtDB = commToDB.GetProductFromDB(product.BuildSelectQuery("I"))

                    Dim rowsGui As DataRow = dtGui.Rows.Item(0)
                    Dim rowsDB As DataRow = dtDB.Rows.Item(0)

                    For Each cols As DataColumn In dtGui.Columns
                        Dim colGui As String = cols.ColumnName
                        Dim rowGui As String = rowsGui.Item(colGui).ToString

                        Dim itemGui As String = rowsGui.Item(colGui)
                        Dim itemDB As String = rowsDB.Item(colGui)

                        If String.Compare(itemGui, itemDB) <> 0 Then

                            Return True

                        End If

                    Next

                End If

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

            Return False

        End Get

    End Property

    Public ReadOnly Property IsInputMainKeyProductEmpty() As Boolean

        Get

            If product Is Nothing Then

                Return True

            End If

            Dim IsEmpty = False
            Dim EmptyItem As String = ""

            If IsProdIdEmpty Then

                IsEmpty = True
                EmptyItem += " Product ID "

            End If

            If IsProDNameEmpty Then

                IsEmpty = True
                EmptyItem += " Product Name "

            End If

            If IsQuantityEmpty Then

                IsEmpty = True
                EmptyItem += " Quantity "

            End If

            If IsPriceEmpty Then

                IsEmpty = True
                EmptyItem += " Price "

            End If

            If IsEmpty Then

                MessageBox.Show("Not input Yet : " & EmptyItem)

            End If

            Return IsEmpty

        End Get

    End Property


    Public ReadOnly Property IsProductControlEmpty
        Get

            If product Is Nothing Then

                Return True

            End If

            If Not IsProdIdEmpty Then

                Return False

            End If

            If Not IsProDNameEmpty Then

                Return False

            End If

            If Not IsPriceEmpty Then

                Return False

            End If

            If Not IsQuantityEmpty Then

                Return False

            End If

            If Not IsNothingSelectedCategory Then

                Return False

            End If

            Return True

        End Get

    End Property

#End Region

#Region "For Login"
    Public ReadOnly Property IsLoginEmpty()
        Get
            If Not IsUserNameEmpty Then

                Return False

            End If

            If Not IsPassWordEmpty Then

                Return False

            End If

            Return True

        End Get

    End Property


#End Region

#Region "For UserControl"
    Public ReadOnly Property IsUserControlEmpty()
        Get

            If Not IsUserIdEmpty Then

                Return False

            End If

            If Not IsUserNameEmpty Then

                Return False

            End If

            If Not IsPassWordEmpty Then

                Return False

            End If

            If Not IsUserPhoneEmpty Then

                Return False

            End If

            Return True

        End Get
    End Property
    Public ReadOnly Property IsUserPhoneEmpty()
        Get

            If user Is Nothing Then

                Return True

            End If

            Dim box = user.PhoneBox
            Return IsTextBoxEmpty(box)

        End Get
    End Property
    Public ReadOnly Property IsUserIdEmpty()
        Get

            If user Is Nothing Then

                Return True

            End If

            Dim box = user.UserIdbox
            Return IsTextBoxEmpty(box)

        End Get
    End Property


#End Region

#Region "For Customer"
    Public ReadOnly Property IsCustomerControlEmpty()
        Get

            If Not IsCustomerIdEmpty Then

                Return False

            End If

            If Not IsCustomerNameEmpty Then

                Return False

            End If

            If Not IsCustomerPhoneEmpty Then

                Return False

            End If

            Return True

        End Get
    End Property

    Public ReadOnly Property IsCustomerPhoneEmpty
        Get

            If customer Is Nothing Then

                Return True

            End If

            Dim box = customer.CustomerPhoneBox
            Return IsTextBoxEmpty(box)

        End Get
    End Property
    Public ReadOnly Property IsCustomerNameEmpty
        Get

            If customer Is Nothing Then

                Return True

            End If

            Dim box = customer.CustomerNameBox
            Return IsTextBoxEmpty(box)

        End Get
    End Property
    Public ReadOnly Property IsCustomerIdEmpty
        Get

            If customer Is Nothing Then

                Return True

            End If

            Dim box = customer.CustomerIdBox
            Return IsTextBoxEmpty(box)

        End Get
    End Property


#End Region

#Region "For Product"

    Public ReadOnly Property IsCompleteMatchChecked()

        Get
            If product Is Nothing Then

                Return False

            End If

            Dim btn = product.CompMatchBtn
            Return IsRadioBtnChecked(btn)

        End Get
    End Property
    Public ReadOnly Property IsFrontMatchChecked()

        Get
            If product Is Nothing Then

                Return False

            End If

            Dim btn = product.FrontMatchBtn
            Return IsRadioBtnChecked(btn)

        End Get
    End Property
    Public ReadOnly Property IsLastMatchChecked()

        Get
            If product Is Nothing Then

                Return False

            End If

            Dim btn = product.LastMatchBtn
            Return IsRadioBtnChecked(btn)

        End Get
    End Property
    Public ReadOnly Property IsCategoryItemEmpy()
        Get

            If product Is Nothing Then

                Return True

            End If

            Dim box = product.CategoryBox
            Return CheckComboboxIsNothing(box)

        End Get

    End Property

    Public ReadOnly Property IsNothingSelectedCategory()
        Get

            If product Is Nothing Then

                Return False

            End If

            Dim box = product.CategoryBox
            Return IsNothingSelectedInComboBox(box)

        End Get
    End Property

    Public ReadOnly Property isDescEmpty()
        Get

            If product Is Nothing Then

                Return False

            End If

            Dim box = product.DescBox
            Return IsTextBoxEmpty(box)

        End Get
    End Property

    Public ReadOnly Property IsPriceEmpty()
        Get

            If product Is Nothing Then

                Return False

            End If

            Dim box = product.PriceBox
            Return IsTextBoxEmpty(box)

        End Get
    End Property

    Public ReadOnly Property IsQuantityEmpty()
        Get

            If product Is Nothing Then

                Return False

            End If

            Dim box = product.QuantityBox
            Return IsTextBoxEmpty(box)

        End Get
    End Property

    Public ReadOnly Property IsProDNameEmpty()
        Get

            If product Is Nothing Then

                Return False

            End If

            Dim box = product.ProdNameBox
            Return IsTextBoxEmpty(box)

        End Get
    End Property

    Public ReadOnly Property IsProdIdEmpty()
        Get

            If product Is Nothing Then

                Return False

            End If

            Dim box = product.ProdIdBox
            Return IsTextBoxEmpty(box)

        End Get
    End Property


#End Region

#Region "Commom Function"
    Public ReadOnly Property IsUserNameEmpty()
        Get
            Dim IsEmpty As Boolean = True

            If login IsNot Nothing Then

                Dim box = login.userBox
                IsEmpty = IsTextBoxEmpty(box)

            End If

            If user IsNot Nothing Then

                Dim box = user.UserNameBox
                IsEmpty = IsTextBoxEmpty(box)

            End If

            Return IsEmpty

        End Get
    End Property


    Public ReadOnly Property IsPassWordEmpty()
        Get
            Dim IsEmpty As Boolean = True

            If login IsNot Nothing Then

                Dim box = login.PasswordBox
                IsEmpty = IsTextBoxEmpty(box)

            End If

            If user IsNot Nothing Then

                Dim box = user.PasswordBox
                IsEmpty = IsTextBoxEmpty(box)

            End If

            Return IsEmpty

        End Get
    End Property


    Private Function IsTextBoxEmpty(box As Guna2TextBox) As Boolean

        If box Is Nothing OrElse String.IsNullOrEmpty(box.Text) Then

            Return True

        End If

        Return False

    End Function

    Private Function IsNothingSelectedInComboBox(box As Guna2ComboBox) As Boolean

        If box Is Nothing OrElse box.SelectedIndex = -1 Then

            Return True

        End If

        Return False


    End Function

    Private Function CheckComboboxIsNothing(box As Guna2ComboBox) As Boolean

        If box Is Nothing OrElse box.Items.Count = 0 Then

            Return True

        End If

        Return False

    End Function

    Private Function IsDataExist(tableName As String, colName As String, item As String) As Boolean

        If String.IsNullOrEmpty(tableName) OrElse String.IsNullOrEmpty(colName) OrElse String.IsNullOrEmpty(item) Then

            Return False

        End If

        Return connector.IsDataExist(tableName, colName, item)

    End Function

    Private Function IsRadioBtnChecked(button As RadioButton)

        If button Is Nothing Then

            Return False

        End If

        If button.Checked = True Then

            Return True

        End If

        Return False

    End Function

    Public Function CheckDataTable(dataTable As DataTable) As Exception

        Dim e As Exception = Nothing

        Try

            If IsDBNull(dataTable) Then

                Throw New Exception("This Is Null DataTable")

            Else

                Dim countCols As Integer = dataTable.Columns.Count
                Dim countRows As Integer = dataTable.Rows.Count

                If countCols = 0 Then

                    Throw New Exception("There is no any columns in the data table")

                ElseIf countRows = 0 Then

                    Throw New Exception("There is no any rows in the data table")

                End If

            End If

        Catch ex As Exception

            e = ex
            Debug.WriteLine(e.Message)

        End Try

        Return e

    End Function

#End Region
End Class
