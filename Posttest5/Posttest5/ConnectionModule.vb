Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient

Module Koneksi

    Public conn As MySqlConnection

    Public connStr As String = "Server=localhost;Port=3306;Database=db_bunga;UserID=root;Password=;"

    Public Sub BukaKoneksi()
        Try
            If conn Is Nothing Then
                conn = New MySqlConnection(connStr)
            End If

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

        Catch ex As Exception
            MessageBox.Show("Koneksi gagal: " & ex.Message)
        End Try
    End Sub

End Module