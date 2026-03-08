Module Module1

    Public daftarBuku(100) As String
    Public jumlahBuku As Integer = 0

    Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)

        If judul = "" Then
            MessageBox.Show("Judul buku tidak boleh kosong!")
            Exit Sub
        End If

        If genre = "" Then
            MessageBox.Show("Genre buku tidak boleh kosong!")
            Exit Sub
        End If

        If jumlahBuku >= daftarBuku.Length Then
            MessageBox.Show("Daftar buku sudah penuh!")
            Exit Sub
        End If

        Dim buku As String
        buku = judul & " (" & genre & ")"

        daftarBuku(jumlahBuku) = buku
        jumlahBuku += 1

    End Sub


    Public Function CariBuku(ByVal judul As String) As Integer

        If judul = "" Then
            MessageBox.Show("Masukkan judul buku yang ingin dihapus!")
            Return -1
        End If

        Dim i As Integer

        For i = 0 To jumlahBuku - 1
            If daftarBuku(i).ToLower.Contains(judul.ToLower) Then
                Return i
            End If
        Next

        MessageBox.Show("Buku tidak ditemukan!")
        Return -1

    End Function


End Module