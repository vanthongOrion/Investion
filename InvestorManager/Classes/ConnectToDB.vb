Imports System.Data.SqlClient
Imports System.Linq.Expressions
Imports System.Net.Configuration
Imports System.Reflection.Context
Imports System.Runtime.Remoting.Messaging
Imports Oracle.ManagedDataAccess.Client

Public Class ConnectToDB
    Private WithEvents conn As OracleConnection
    Private WithEvents adapter As OracleDataAdapter
    Private WithEvents cmd As OracleCommand
    Private WithEvents reader As OracleDataReader
    Private currentState As ConnectionState
    Private strCon As String = "Data Source=192.168.184.134:1521/orclpdb;User ID=Test;Password=Pass123"

    Friend ProdTableName As String = "PRODUCT"
    Friend StringList As New List(Of String)(New String() {"PRODNAME", "PRODDESC", "PRODCAT"})

    Public Sub New()

        currentState = ConnectionState.Closed
        connect()

    End Sub

    Private Sub connect()

        If conn Is Nothing Then

            conn = New OracleConnection(strCon)

        End If

        If Not currentState.Equals(ConnectionState.Open) Then

            Try
                Debug.WriteLine("connecting")
                conn.Open()

            Catch ex As Exception

                MessageBox.Show(ex.Message)
                conn.Close()

            End Try


        End If

        currentState = conn.State
        Debug.WriteLine(currentState.ToString)

    End Sub

    Private Function TryConnect(times As Integer) As Boolean
        Dim count As Integer = 0

        Try

            Do
                connect()
                count += 1

                If count = times Then

                    MessageBox.Show("cann't connect to DataBase")
                    Return False

                End If

            Loop Until currentState.Equals(ConnectionState.Open)

            Return True

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        disconnect()
        Return False

    End Function

    Private Sub disconnect()

        If conn IsNot Nothing AndAlso currentState.Equals(ConnectionState.Open) Then

            conn.Close()
            currentState = conn.State
            Debug.WriteLine("Disconnected")

        End If

    End Sub

    Public Function SendNonQuery(query As String) As Boolean

        If Not currentState.Equals(ConnectionState.Open) Then

            Try

                If TryConnect(3) Then

                    SendNonQuery(query)

                End If

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

        Else

            Try

                Using cmd As New OracleCommand(query, conn)

                    cmd.CommandType = CommandType.Text
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Successfully Insert")
                    disconnect()
                    Return True

                End Using

            Catch ex As Exception

                MessageBox.Show("Not successfully insert")
                MessageBox.Show(ex.Message)
                disconnect()

            End Try

        End If

        Return False

    End Function


    Public ReadOnly Property GetDataTable(query As String) As DataTable
        Get

            Try

                If conn Is Nothing AndAlso Not currentState.Equals(ConnectionState.Open) Then

                    If TryConnect(3) Then

                        Using dataTable As DataTable = GetDataTable(query)

                            Return dataTable

                        End Using

                    End If

                Else

                    If String.IsNullOrEmpty(query) Then

                        Throw New Exception("Query is Null")

                    Else

                        Dim dataTable As New DataTable
                        Using adapter = New OracleDataAdapter(query, conn)

                            Using builder As New OracleCommandBuilder(adapter)
                                Dim dataSet As New DataSet

                                adapter.Fill(dataSet)
                                dataTable = dataSet.Tables(0)
                                disconnect()
                                Return dataTable

                            End Using

                        End Using

                    End If

                End If

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

            disconnect()
            Return Nothing

        End Get
    End Property

    Friend ReadOnly Property GetReader(query As String) As OracleDataReader

        Get

            Try

                If conn Is Nothing OrElse Not currentState.Equals(ConnectionState.Open) Then

                    If TryConnect(3) Then

                        Dim reader As OracleDataReader
                        reader = GetReader(query)
                        Return reader
                    Else


                    End If

                Else

                    If String.IsNullOrEmpty(query) Then

                        Throw New Exception("Query Is Null")

                    Else

                        Using cmd As New OracleCommand(query, conn)
                            cmd.CommandType = CommandType.Text

                            Dim reader As OracleDataReader = cmd.ExecuteReader
                            Return reader

                        End Using

                    End If

                End If

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

            disconnect()
            Return Nothing

        End Get
    End Property

    Public Function IsDataExist(tableName As String, colName As String, item As String) As Boolean

        If String.IsNullOrEmpty(tableName) OrElse String.IsNullOrEmpty(colName) OrElse String.IsNullOrEmpty(item) Then

            Return False

        End If

        Dim IsExist As Boolean = False

        Try

            Dim Query As String = "SELECT * FROM " & tableName & " WHERE " & colName & " = " & item

            Using reader As OracleDataReader = GetReader(Query)

                If reader Is Nothing Then

                    Exit Try

                End If

                If reader.HasRows Then

                    IsExist = True

                End If

            End Using

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        disconnect()
        Return IsExist

    End Function


    Public ReadOnly Property GetState()

        Get

            Return currentState

        End Get

    End Property


    Public Function BindQuote(val As String) As String

        If String.IsNullOrEmpty(val) Then

            Return vbNullString

        End If

        Return "'" & val & "'"

    End Function

    Public Function BindEqualKey(col As String, item As String) As String

        If String.IsNullOrEmpty(col) OrElse String.IsNullOrEmpty(item) Then

            Return vbNullString

        End If

        Return col.ToUpper & " = " & item

    End Function

    Public Function BindLikeKey(col As String, item As String, pattern As Char) As String

        If String.IsNullOrEmpty(col) OrElse String.IsNullOrEmpty(item) Then

            Return vbNullString

        End If

        Dim result As String = vbNullString
        Select Case pattern
            Case "F"
                Return col.ToUpper & " LIKE '" & item & "%'"

            Case "L"
                Return col.ToUpper & " LIKE '%" & item & "'"
        End Select

        Return result
    End Function

End Class
