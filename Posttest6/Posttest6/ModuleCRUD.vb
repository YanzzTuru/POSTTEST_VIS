Imports MySqlConnector

Module DataModule

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection("Server=localhost;Port=3306;Database=db_bunga;User ID=root;Password=;")
    End Function

    Public Function GetAllJenis() As DataTable
        Dim dt As New DataTable()
        Using conn = GetConnection()
            Dim da As New MySqlDataAdapter("SELECT * FROM tbjenis", conn)
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function GetAllBunga() As DataTable
        Dim dt As New DataTable()

        Dim query As String =
            "SELECT tbbunga.kodeBunga,
                    tbjenis.jenis,
                    tbbunga.namaBunga,
                    tbbunga.harga,
                    tbbunga.stok,
                    tbbunga.deskripsi
             FROM tbbunga
             INNER JOIN tbjenis ON tbbunga.kodeJenis = tbjenis.kodeJenis
             ORDER BY tbbunga.kodeBunga ASC"

        Using conn = GetConnection()
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(dt)
        End Using

        Return dt
    End Function

    Public Function SearchBunga(keyword As String) As DataTable
        Dim dt As New DataTable()

        Dim query As String =
            "SELECT tbbunga.kodeBunga,
                    tbjenis.jenis,
                    tbbunga.namaBunga,
                    tbbunga.harga,
                    tbbunga.stok,
                    tbbunga.deskripsi
             FROM tbbunga
             INNER JOIN tbjenis ON tbbunga.kodeJenis = tbjenis.kodeJenis
             WHERE tbbunga.namaBunga LIKE @key
                OR tbjenis.jenis LIKE @key
                OR tbbunga.deskripsi LIKE @key"

        Using conn = GetConnection()
            Dim da As New MySqlDataAdapter(query, conn)
            da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
            da.Fill(dt)
        End Using

        Return dt
    End Function

    Public Function GetBungaByKode(kode As String) As DataTable
        Dim dt As New DataTable()

        Using conn = GetConnection()
            Dim da As New MySqlDataAdapter("SELECT * FROM tbbunga WHERE kodeBunga=@k", conn)
            da.SelectCommand.Parameters.AddWithValue("@k", kode)
            da.Fill(dt)
        End Using

        Return dt
    End Function

    Public Function KodeBungaSudahAda(kode As String) As Boolean
        Using conn = GetConnection()
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM tbbunga WHERE kodeBunga=@k", conn)
            cmd.Parameters.AddWithValue("@k", kode)

            Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
        End Using
    End Function

    Public Function SimpanBunga(kode As String,
                               kodeJenis As String,
                               nama As String,
                               harga As Integer,
                               stok As Integer,
                               deskripsi As String) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()

                Dim cmd As New MySqlCommand(
                    "INSERT INTO tbbunga 
                     (kodeBunga, kodeJenis, namaBunga, harga, stok, deskripsi)
                     VALUES (@k,@j,@n,@h,@s,@d)", conn)

                cmd.Parameters.AddWithValue("@k", kode)
                cmd.Parameters.AddWithValue("@j", kodeJenis)
                cmd.Parameters.AddWithValue("@n", nama)
                cmd.Parameters.AddWithValue("@h", harga)
                cmd.Parameters.AddWithValue("@s", stok)
                cmd.Parameters.AddWithValue("@d", deskripsi)

                cmd.ExecuteNonQuery()
            End Using

            Return True

        Catch ex As Exception
            MessageBox.Show("Gagal simpan: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahBunga(kode As String,
                             kodeJenis As String,
                             nama As String,
                             harga As Integer,
                             stok As Integer,
                             deskripsi As String) As Boolean
        Using conn = GetConnection()
            conn.Open()

            Dim cmd As New MySqlCommand(
                "UPDATE tbbunga SET 
                    kodeJenis=@j,
                    namaBunga=@n,
                    harga=@h,
                    stok=@s,
                    deskripsi=@d
                 WHERE kodeBunga=@k", conn)

            cmd.Parameters.AddWithValue("@k", kode)
            cmd.Parameters.AddWithValue("@j", kodeJenis)
            cmd.Parameters.AddWithValue("@n", nama)
            cmd.Parameters.AddWithValue("@h", harga)
            cmd.Parameters.AddWithValue("@s", stok)
            cmd.Parameters.AddWithValue("@d", deskripsi)

            Return cmd.ExecuteNonQuery() > 0
        End Using
    End Function

    Public Function HapusBunga(kode As String) As Boolean
        Using conn = GetConnection()
            conn.Open()

            Dim cmd As New MySqlCommand("DELETE FROM tbbunga WHERE kodeBunga=@k", conn)
            cmd.Parameters.AddWithValue("@k", kode)

            Return cmd.ExecuteNonQuery() > 0
        End Using
    End Function

End Module