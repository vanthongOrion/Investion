Imports System.Linq.Expressions
Imports System.Web.UI.WebControls
Imports FarPoint.Win.Spread
Imports FarPoint.Win.Design
Public Class Product

    Friend WithEvents connector As ConnectToDB
    Friend WithEvents commToDb As CommToDB
    Friend WithEvents checkData As CheckData
    Friend WithEvents commToGui As CommToGui
    Friend WithEvents form1 As Form1
    Friend WithEvents spread As Myspread


    Friend Enum Cate
        Mobile
        Sport
        Medical
    End Enum
    Public Sub New(Optional form As Form1 = Nothing)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        If form IsNot Nothing Then

            form1 = form
            connector = form1.connector

        End If

        commToDb = New CommToDB(,, Me,)
        commToGui = New CommToGui(,, Me,)
        checkData = New CheckData(,, Me,)

        With commToDb
            .AsignCheckData = checkData
            .AsignConnector = connector
        End With

        With commToGui
            .AsignCheckData = checkData
        End With

        With checkData
            .AsignConnector = connector
            .AsignCommToDB = commToDb
            .AsignCommToGui = commToGui
        End With

        spread = New Myspread

        AddValToComboBox()
        AddHandler SearchBtn.Click, AddressOf SearchProcess
        AddHandler RecordBtn.Click, AddressOf RecordProcess

    End Sub

    Public Sub InitSpread()
        Dim fpSpread1 As New FarPoint.Win.Spread.FpSpread
        Dim fpDesign As New FarPoint.Win.Spread.Design.SpreadDesigner
        Dim shv As New FarPoint.Win.Spread.SheetView()

        'fpSpread1.Location = New Point(10, 10)
        fpSpread1.Height = 200
        fpSpread1.Width = 400
        Panel3.Controls.Add(fpSpread1)
        fpSpread1.Sheets.Add(shv)
        fpSpread1.StartCellEditing(Nothing, False)
        'fpDesign.a
        'FarPoint.Win.Spread.Design.ExternalDialogs.CellTypeEditor(fpSpread1)
        'Dim fileName As String
        'fileName = "..\bin\Book1.xls"
        'Try
        '    fpSpread1.OpenExcel(fileName, wList)
        'Catch ex As Exception
        '    ListBox1.Items.Add(ex.ToString())
        'End Try

    End Sub

    Private Sub AddValToComboBox()

        If Not checkData.IsCategoryItemEmpy Then

            commToGui.ClearCategoryItem()

        End If

        With commToGui
            .AddValToCategory = Cate.Mobile.ToString
            .AddValToCategory = Cate.Sport.ToString
            .AddValToCategory = Cate.Medical.ToString
        End With

    End Sub
    Private Sub RecordProcess()

        If Not checkData.IsInputMainKeyProductEmpty Then

            If checkData.IsProdIdExist Then

                If checkData.IsProductDataChanged Then

                    Dim message As String = "Override Save ?"
                    Dim title As String = "Warning"

                    Dim result As DialogResult = MessageBox.Show(message,
                                             title,
                                             MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Exclamation,
                                             MessageBoxDefaultButton.Button2)

                    If result = DialogResult.Yes Then

                        connector.SendNonQuery(BuildInsertQuery)

                    End If

                End If

            Else

                connector.SendNonQuery(BuildInsertQuery)

            End If

        End If


    End Sub

    Private Sub SearchProcess()

        If checkData.IsProductControlEmpty Then

            MessageBox.Show("To Search, Please Input some thing")

        Else

            Dim key As Char = vbNullChar
            If checkData.IsCompleteMatchChecked Then

                key = "C"

            ElseIf checkData.IsFrontMatchChecked Then

                key = "F"

            ElseIf checkData.IsLastMatchChecked Then

                key = "L"

            End If

            If key <> vbNullChar Then

                Try

                    Dim query = BuildSelectQuery(key)

                    Dim dataTable As DataTable = connector.GetDataTable(query)

                    Dim e As Exception = Nothing

                    e = checkData.CheckDataTable(dataTable)

                    If e IsNot Nothing Then

                        Throw e

                    Else

                        spread.Dock = DockStyle.Fill
                        Panel3.Controls.Add(spread)
                        spread.FpSpread1_Sheet1.DataSource = dataTable


                    End If

                Catch ex As Exception

                    MessageBox.Show(ex.Message)

                End Try
            End If

        End If

    End Sub

    Private Function BuildInsertQuery() As String

        Dim Query As String = ""
        Dim dataTable As New DataTable
        Dim e As Exception = Nothing

        Try

            e = checkData.CheckDataTable(commToGui.GetDTFromProduct)

            If e IsNot Nothing Then

                Throw e

            Else

                Query += "INSERT INTO " & connector.ProdTableName & "("
                dataTable = commToGui.GetDTFromProduct
                Dim countCols As Integer = dataTable.Columns.Count
                Dim items As DataRow = dataTable.Rows.Item(0)
                Dim cols As String = ""
                Dim vals As String = ""

                For Each Col As DataColumn In dataTable.Columns
                    Dim colName As String = Col.ColumnName
                    Dim item As String = items(colName).ToString

                    If connector.StringList.Contains(colName) AndAlso Not String.IsNullOrEmpty(item) Then

                        item = connector.BindQuote(item)

                    End If

                    If Not String.IsNullOrEmpty(colName) AndAlso Not String.IsNullOrEmpty(item) Then

                        cols += colName.Trim.ToUpper
                        vals += item

                        If Not countCols = 1 AndAlso String.Compare(colName, dataTable.Columns(countCols - 1).ToString) <> 0 Then

                            cols += ","
                            vals += ","

                        End If


                    End If


                Next

                Query += cols & ") VALUES(" & vals & ")"

            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        Debug.WriteLine(Query)

        Return Query

    End Function

    Friend Function BuildSelectQuery(pattern As Char) As String

        Dim Query As String = ""
        Dim dataTable As New DataTable
        Dim e As Exception = Nothing

        Try

            e = checkData.CheckDataTable(commToGui.GetDTFromProduct)

            If e IsNot Nothing Then

                Throw e

            Else

                dataTable = commToGui.GetDTFromProduct
                Dim countCols As Integer = dataTable.Columns.Count
                Dim items As DataRow = dataTable.Rows.Item(0)
                Dim cols As String = ""
                Dim vals As String = ""

                Select Case pattern
                    Case "A"
                        Query = "SELECT * FROM " & connector.ProdTableName

                    Case "C", "F", "L", "I"

                        Query = "SELECT * FROM " & connector.ProdTableName & " WHERE "

                        For Each Col As DataColumn In dataTable.Columns
                            Dim colName As String = Col.ColumnName
                            Dim item As String = items(colName).ToString

                            If pattern = "I" AndAlso colName.ToUpper.Equals("PRODID") Then

                                If Not String.IsNullOrEmpty(item) Then

                                    item = connector.BindQuote(item)

                                End If

                                Query += connector.BindEqualKey(colName, item)
                                Return Query

                            End If

                            If pattern = "C" Then

                                If connector.StringList.Contains(colName) AndAlso Not String.IsNullOrEmpty(item) Then

                                    item = connector.BindQuote(item)

                                End If

                                Query += connector.BindEqualKey(colName, item)

                            End If

                            If pattern = "F" Then

                                Query += connector.BindLikeKey(colName, item, "F")

                            End If

                            If pattern = "L" Then

                                Query += connector.BindLikeKey(colName, item, "L")

                            End If

                            If countCols > 1 AndAlso String.Compare(colName, dataTable.Columns(countCols - 1).ToString) <> 0 Then

                                Query += " AND "

                            End If

                        Next

                End Select

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        Debug.WriteLine(Query)

        Return Query

    End Function

End Class