

Public Class Form1

    Friend WithEvents connector As ConnectToDB
    Friend WithEvents commToDb As CommToDB
    Friend WithEvents checkData As CheckData
    Friend WithEvents commoToGui As CommToGui
    Friend WithEvents productControl As Product

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connector = New ConnectToDB
        productControl = New Product(Me)
        productControl.Show()

    End Sub
End Class
