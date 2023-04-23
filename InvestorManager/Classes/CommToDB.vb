Imports Oracle.ManagedDataAccess.Client

Public Class CommToDB
    Private WithEvents customer As CustomerManager
    Private WithEvents login As Login
    Private WithEvents product As Product
    Private WithEvents user As UserManager
    Private WithEvents checkData As CheckData
    Private WithEvents connector As ConnectToDB

    Public Sub New(Optional customerControl As CustomerManager = Nothing, Optional loginControl As Login = Nothing, Optional productControl As Product = Nothing, Optional userControl As UserManager = Nothing)

        If customerControl IsNot Nothing Then

            customer = customerControl

        End If

        If loginControl IsNot Nothing Then

            login = loginControl

        End If

        If userControl IsNot Nothing Then

            user = userControl

        End If

        If productControl IsNot Nothing Then

            product = productControl

        End If

    End Sub

    Public WriteOnly Property AsignCheckData() As CheckData

        Set(value As CheckData)

            If value IsNot Nothing Then

                checkData = value

            End If

        End Set

    End Property

    Public WriteOnly Property AsignConnector() As ConnectToDB

        Set(value As ConnectToDB)

            If value IsNot Nothing Then

                connector = value

            End If

        End Set

    End Property

    Public Function GetProductFromDB(query As String) As DataTable

        If product Is Nothing OrElse String.IsNullOrEmpty(query) Then

            Return Nothing

        End If

        Dim dataTable As DataTable = Nothing

        dataTable = connector.GetDataTable(query)

        Return dataTable

    End Function

End Class
