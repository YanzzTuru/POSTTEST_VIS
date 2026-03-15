Public Class Form1

    Public Sub HanyaAngka(sender As Object, e As KeyPressEventArgs)

        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


    Public Sub HanyaHuruf(sender As Object, e As KeyPressEventArgs)

        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(sender, e)
    End Sub


    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        HanyaAngka(sender, e)
    End Sub

    Private Sub txtTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelp.KeyPress
        HanyaAngka(sender, e)
    End Sub


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        openFileDialog.Title = "Pilih Gambar"

        If openFileDialog.ShowDialog() = DialogResult.OK Then

            picFoto.Image = Image.FromFile(openFileDialog.FileName)
            picFoto.SizeMode = PictureBoxSizeMode.Zoom

        End If

    End Sub


    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If txtNama.Text = "" Or txtUmur.Text = "" Or txtTelp.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If


        If rbLaki.Checked = False And rbPerempuan.Checked = False Then
            MessageBox.Show("Pilih Jenis Kelamin")
            Exit Sub
        End If


        Dim hobby As String = ""

        If cbGaming.Checked Then
            hobby = hobby & "Gaming, "
        End If

        If cbCoding.Checked Then
            hobby = hobby & "Coding, "
        End If

        If cbTraveling.Checked Then
            hobby = hobby & "Traveling, "
        End If

        If cbMenggambar.Checked Then
            hobby = hobby & "Menggambar, "
        End If

        If cbMenulis.Checked Then
            hobby = hobby & "Menulis, "
        End If

        If cbMemancing.Checked Then
            hobby = hobby & "Memancing, "
        End If

        If cbMembaca.Checked Then
            hobby = hobby & "Membaca, "
        End If

        If cbOlahraga.Checked Then
            hobby = hobby & "Olahraga, "
        End If

        If cbMenyanyi.Checked Then
            hobby = hobby & "Menyanyi, "
        End If

        If cbMenari.Checked Then
            hobby = hobby & "Menari, "
        End If


        If hobby = "" Then
            MessageBox.Show("Pilih minimal satu hobby")
            Exit Sub
        End If

        Dim hasil As New Form2

        hasil.lblNama.Text = "Nama : " & txtNama.Text
        hasil.lblUmur.Text = "Umur : " & txtUmur.Text
        hasil.lblTanggal.Text = "Tanggal Lahir : " & dtpTanggal.Text
        hasil.lblTelp.Text = "No Telepon : " & txtTelp.Text
        hasil.lblAlamat.Text = "Alamat : " & txtAlamat.Text
        hasil.lblHobby.Text = "Hobby : " & hobby


        If rbLaki.Checked Then
            hasil.lblJK.Text = "Jenis Kelamin : Laki-Laki"
        Else
            hasil.lblJK.Text = "Jenis Kelamin : Perempuan"
        End If


        hasil.picHasil.Image = picFoto.Image


        hasil.Show()

    End Sub

End Class