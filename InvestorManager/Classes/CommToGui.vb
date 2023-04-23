Imports Guna.UI2.WinForms

Public Class CommToGui

#Region "Property Value"

    Private WithEvents customer As CustomerManager
    Private WithEvents login As Login
    Private WithEvents product As Product
    Private WithEvents user As UserManager
    Private WithEvents checkData As CheckData

#End Region

#Region "Construture"
    Public Sub New(Optional customerControl As CustomerManager = Nothing, Optional loginControl As Login = Nothing, Optional productControl As Product = Nothing, Optional userControl As UserManager = Nothing)

        customer = customerControl
        login = loginControl
        user = userControl
        product = productControl

    End Sub

#End Region

#Region "AsignInitValue"
    Public WriteOnly Property AsignCheckData() As CheckData

        Set(value As CheckData)

            If value IsNot Nothing Then

                checkData = value

            End If

        End Set

    End Property

    Public WriteOnly Property AddValToCategory()
        Set(value)

            If product Is Nothing OrElse String.IsNullOrEmpty(value) Then

                Exit Property

            End If

            Dim box = product.CategoryBox
            SetValueToComboBox(value, box)

        End Set
    End Property


#End Region


#Region "For Product Clas"
    Public Sub ClearCategoryItem()

        If product Is Nothing OrElse product.CategoryBox Is Nothing Then

            Exit Sub

        End If

        Dim box = product.CategoryBox
        ClearValueOfComboBox(box)

    End Sub

    Public ReadOnly Property GetTextFromCustomerPhone()
        Get

            If customer Is Nothing Then

                Return vbNullString

            End If

            Dim box = customer.CustomerPhoneBox
            Return GetTextFromTextBox(box)

        End Get

    End Property

    Public ReadOnly Property GetTextFromCustomerName()
        Get

            If customer Is Nothing Then

                Return vbNullString

            End If

            Dim box = customer.CustomerNameBox
            Return GetTextFromTextBox(box)

        End Get

    End Property

    Public ReadOnly Property GetTextFromCustomerId()
        Get

            If customer Is Nothing Then

                Return vbNullString

            End If

            Dim box = customer.CustomerIdBox
            Return GetTextFromTextBox(box)

        End Get

    End Property

    Public ReadOnly Property GetTextFromCategory()

        Get

            If product Is Nothing Then

                Return vbNullString

            End If

            Dim box = product.CategoryBox
            Return GetSelectedItemFromCombobox(box)

        End Get

    End Property
    Public ReadOnly Property GetTextFromDesc()

        Get

            If product Is Nothing Then

                Return vbNullString

            End If

            Dim box = product.DescBox
            Return GetTextFromTextBox(box)

        End Get

    End Property

    Public ReadOnly Property GetTextFromPrice()

        Get

            If product Is Nothing Then

                Return vbNullString

            End If

            Dim box = product.PriceBox
            Return GetTextFromTextBox(box)

        End Get

    End Property

    Public ReadOnly Property GetTextFromProdQuantity()

        Get

            If product Is Nothing Then

                Return vbNullString

            End If

            Dim box = product.QuantityBox
            Return GetTextFromTextBox(box)

        End Get

    End Property
    Public ReadOnly Property GetTextFromProdName()

        Get

            If product Is Nothing Then

                Return vbNullString

            End If

            Dim box = product.ProdNameBox
            Return GetTextFromTextBox(box)

        End Get

    End Property
    Public ReadOnly Property GetTextFromProdId()

        Get

            If product Is Nothing Then

                Return vbNullString

            End If

            Dim box = product.ProdIdBox
            Return GetTextFromTextBox(box)

        End Get

    End Property
    Public ReadOnly Property GetTextFromUserPhone()

        Get

            If user Is Nothing Then

                Return vbNullString

            End If

            Dim box = user.PhoneBox
            Return GetTextFromTextBox(box)

        End Get

    End Property
    Public ReadOnly Property GetTextFromUserId()

        Get

            If user Is Nothing Then

                Return vbNullString

            End If

            Dim box = user.UserIdbox
            Return GetTextFromTextBox(box)

        End Get

    End Property
    Public ReadOnly Property GetTextFromUserName()

        Get

            If user Is Nothing Then

                Return vbNullString

            End If

            Dim box = user.UserNameBox
            Return GetTextFromTextBox(box)

        End Get

    End Property

    Public ReadOnly Property GetTextFromLPassword()

        Get

            If login Is Nothing Then

                Return vbNullString

            End If

            Dim box = login.PasswordBox
            Return GetTextFromTextBox(box)

        End Get

    End Property

    Public ReadOnly Property GetTextFromLUserId()

        Get

            If login Is Nothing Then

                Return vbNullString

            End If

            Dim box = login.userBox
            Return GetTextFromTextBox(box)

        End Get

    End Property


    Public ReadOnly Property GetDTFromProduct()

        Get

            If product Is Nothing Then

                Return Nothing

            End If

            Dim dataTable As New DataTable
            Dim row As DataRow = dataTable.NewRow
            Dim isRowEmpty = True

            If Not checkData.IsProdIdEmpty Then

                Dim ProdIdColumn As New DataColumn("PRODID")
                dataTable.Columns.Add(ProdIdColumn)
                row(ProdIdColumn) = GetTextFromProdId
                isRowEmpty = False

            End If

            If Not checkData.IsProDNameEmpty Then

                Dim ProdNameColumn As New DataColumn("PRODNAME")
                dataTable.Columns.Add(ProdNameColumn)
                row(ProdNameColumn) = GetTextFromProdName
                isRowEmpty = False

            End If

            If Not checkData.IsQuantityEmpty Then

                Dim QuantityColumn As New DataColumn("PRODQTY")
                dataTable.Columns.Add(QuantityColumn)
                row(QuantityColumn) = GetTextFromProdQuantity
                isRowEmpty = False

            End If

            If Not checkData.IsPriceEmpty Then

                Dim PriceColumn As New DataColumn("PRODPRICE")
                dataTable.Columns.Add(PriceColumn)
                row(PriceColumn) = GetTextFromPrice
                isRowEmpty = False

            End If

            If Not checkData.isDescEmpty Then

                Dim DescColumn As New DataColumn("PRODDESC")
                dataTable.Columns.Add(DescColumn)
                row(DescColumn) = GetTextFromDesc
                isRowEmpty = False

            End If

            If Not checkData.IsNothingSelectedCategory Then

                Dim CateColumn As New DataColumn("PRODCAT")
                dataTable.Columns.Add(CateColumn)
                row(CateColumn) = GetTextFromCategory
                isRowEmpty = False

            End If

            Try

                If isRowEmpty Then

                    Return vbNull

                End If

                dataTable.Rows.Add(row)

            Catch ex As Exception

            End Try

            Return dataTable

        End Get

    End Property


#End Region

#Region "Common Function"

    Private Sub SetValueToComboBox(val As String, target As Guna2ComboBox)

        If target Is Nothing OrElse String.IsNullOrEmpty(val) Then

            Exit Sub

        End If

        target.Items.Add(val)

    End Sub

    Private Sub ClearValueOfComboBox(target As Guna2ComboBox)

        If target Is Nothing Then

            Exit Sub

        End If

        target.Items.Clear()

    End Sub

    Private Function GetTextFromTextBox(box As Guna2TextBox) As String

        If box Is Nothing OrElse String.IsNullOrEmpty(box.Text) Then

            Return vbNullString

        End If

        Dim text = box.Text
        Return text

    End Function

    Private Function GetSelectedItemFromCombobox(box As Guna2ComboBox) As String

        If box Is Nothing OrElse box.SelectedIndex = -1 Then

            Return vbNullString

        End If

        Dim text As String = box.SelectedItem
        Return text

    End Function

#End Region

End Class
