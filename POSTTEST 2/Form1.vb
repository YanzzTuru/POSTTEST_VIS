Public Class Form1

    Sub TampilBuku()

        lstBuku.Items.Clear()

        For i As Integer = 0 To jumlahBuku - 1
            lstBuku.Items.Add(daftarBuku(i))
        Next

    End Sub


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        TambahBuku(txtJudul.Text, txtGenre.Text)

        TampilBuku()

        txtJudul.Clear()
        txtGenre.Clear()

    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim index As Integer = CariBuku(txtHapus.Text)

        If index <> -1 Then

            For i As Integer = index To jumlahBuku - 2
                daftarBuku(i) = daftarBuku(i + 1)
            Next

            jumlahBuku -= 1

            TampilBuku()

        End If

    End Sub

End Class