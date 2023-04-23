Public Class Myspread


    Sub New()


        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        Dim direc As FarPoint.Win.Spread.FillDirection = FarPoint.Win.Spread.FillDirection.Right

        FpSpread1_Sheet1.FillRange(0, 0, 1, 4, 4, direc)

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

End Class
