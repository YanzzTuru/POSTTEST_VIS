Public Class FormUtama

    Public Shared gNama As String = ""
    Public Shared gID As String = ""
    Public Shared gKomunitas As String = ""
    Public Shared gKontak As String = ""
    Public Shared gHobby As String = ""
    Public Shared gFoto As Image = Nothing

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        FormInput.Show()
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click

        If gNama = "" Then
            MessageBox.Show("Belum ada data!")
            Exit Sub
        End If

        Dim f As New FormKartu
        f.nama = gNama
        f.idAnggota = gID
        f.komunitas = gKomunitas
        f.kontak = gKontak
        f.hobby = gHobby
        f.foto = gFoto

        f.Show()

    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        MessageBox.Show("Gunakan tombol simpan di Form Input")
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click

        Dim ofd As New OpenFileDialog
        ofd.Filter = "Text File|*.txt"

        If ofd.ShowDialog = DialogResult.OK Then
            Try
                Dim isi As String = IO.File.ReadAllText(ofd.FileName)
                Dim data() As String = isi.Split({vbCrLf}, StringSplitOptions.None)

                If data.Length < 5 Then
                    MessageBox.Show("Format file salah!")
                    Exit Sub
                End If

                gNama = data(0)
                gID = data(1)
                gKomunitas = data(2)
                gKontak = data(3)
                gHobby = data(4)

                Dim f As New FormKartu
                f.nama = gNama
                f.idAnggota = gID
                f.komunitas = gKomunitas
                f.kontak = gKontak
                f.hobby = gHobby

                f.Show()

            Catch ex As Exception
                MessageBox.Show("Gagal membuka file!")
            End Try
        End If

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Yakin keluar?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class