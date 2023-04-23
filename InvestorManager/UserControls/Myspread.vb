Imports System.Web.UI.WebControls

Public Class Myspread


    Sub New()


        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()


        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Dim fpSpread1 As New FarPoint.Win.Spread.FpSpread
        Dim fpDesign As New FarPoint.Win.Spread.Design.SpreadDesigner
        Dim shv As New FarPoint.Win.Spread.SheetView()

        'fpSpread1.Location = New Point(10, 10)
        fpSpread1.Height = 200
        fpSpread1.Width = 400
        fpSpread1.Sheets.Add(shv)
        fpSpread1.Sheets(0).ColumnHeaderRowCount = 3
        fpSpread1.Sheets(0).RowHeaderColumnCount = 2
        ' Span the header cells as needed.
        fpSpread1.Sheets(0).AddColumnHeaderSpanCell(1, 0, 1, 2)
        fpSpread1.Sheets(0).AddColumnHeaderSpanCell(1, 2, 1, 2)
        fpSpread1.Sheets(0).AddColumnHeaderSpanCell(1, 4, 1, 2)
        fpSpread1.Sheets(0).AddColumnHeaderSpanCell(1, 6, 1, 2)
        fpSpread1.Sheets(0).AddColumnHeaderSpanCell(0, 0, 1, 8)
        fpSpread1.Sheets(0).AddRowHeaderSpanCell(0, 0, 12, 1)
        ' Set the labels as needed -- using the Label property or
        ' the cell Text property.
        fpSpread1.Sheets(0).ColumnHeader.Columns(0).Label = "East"
        fpSpread1.Sheets(0).ColumnHeader.Columns(1).Label = "West"
        fpSpread1.Sheets(0).ColumnHeader.Columns(2).Label = "East"
        fpSpread1.Sheets(0).ColumnHeader.Columns(3).Label = "West"
        fpSpread1.Sheets(0).ColumnHeader.Columns(4).Label = "East"
        fpSpread1.Sheets(0).ColumnHeader.Columns(5).Label = "West"
        fpSpread1.Sheets(0).ColumnHeader.Columns(6).Label = "East"
        fpSpread1.Sheets(0).ColumnHeader.Columns(7).Label = "West"
        fpSpread1.Sheets(0).ColumnHeader.Cells(0, 0).Text = "Fiscal Year 2004"
        fpSpread1.Sheets(0).ColumnHeader.Cells(1, 0).Text = "1st Quarter"
        fpSpread1.Sheets(0).ColumnHeader.Cells(1, 2).Text = "2nd Quarter"
        fpSpread1.Sheets(0).ColumnHeader.Cells(1, 4).Text = "3rd Quarter"
        fpSpread1.Sheets(0).ColumnHeader.Cells(1, 6).Text = "4th Quarter"
        ' Set the row header so that the label displays.
        fpSpread1.Sheets(0).RowHeader.Columns(0).Width = 45
        fpSpread1.Sheets(0).RowHeader.Cells(0, 0).Text = "Branch #"
        Controls.Add(fpSpread1)
    End Sub

End Class
