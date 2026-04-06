Public Class FormInput

    Private Sub FormInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbKomunitas.Items.Add("Informatika")
        cbKomunitas.Items.Add("Sistem Informasi")
        cbKomunitas.Items.Add("Ilmu Komputer")
    End Sub

    Private Function Validasi() As Boolean

        ErrorProvider1.Clear()

        If txtNama.Text = "" Then
            ErrorProvider1.SetError(txtNama, "Tidak boleh kosong")
            Return False
        End If

        If txtID.Text = "" Then
            ErrorProvider1.SetError(txtID, "Tidak boleh kosong")
            Return False
        End If

        If Not mtbHP.MaskCompleted Then
            ErrorProvider1.SetError(mtbHP, "Nomor tidak lengkap")
            Return False
        End If

        If cbKomunitas.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cbKomunitas, "Pilih komunitas")
            Return False
        End If

        If Not (rbLaki.Checked Or rbPerempuan.Checked) Then
            MessageBox.Show("Pilih jenis kelamin")
            Return False
        End If

        If Not (chk1.Checked Or chk2.Checked Or chk3.Checked Or chk4.Checked Or chk5.Checked Or chk6.Checked Or chk7.Checked Or chk8.Checked) Then
            MessageBox.Show("Pilih minimal 1 hobby")
            Return False
        End If

        Return True

    End Function

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image|*.jpg;*.png"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            picFoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If Validasi() = False Then Exit Sub

        If MessageBox.Show("Simpan & cetak?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub

        Dim hobi As String = ""

        If chk1.Checked Then hobi &= "Coding, "
        If chk2.Checked Then hobi &= "Gaming, "
        If chk3.Checked Then hobi &= "Design, "
        If chk4.Checked Then hobi &= "Musik, "
        If chk5.Checked Then hobi &= "Olahraga, "
        If chk6.Checked Then hobi &= "Editing, "
        If chk7.Checked Then hobi &= "Menulis, "
        If chk8.Checked Then hobi &= "Traveling, "

        SaveFileDialog1.Filter = "Text File|*.txt"

        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim data As String =
                txtNama.Text & vbCrLf &
                txtID.Text & vbCrLf &
                cbKomunitas.Text & vbCrLf &
                mtbHP.Text & vbCrLf &
                hobi

            IO.File.WriteAllText(SaveFileDialog1.FileName, data)
        End If

        FormUtama.gNama = txtNama.Text
        FormUtama.gID = txtID.Text
        FormUtama.gKomunitas = cbKomunitas.Text
        FormUtama.gKontak = mtbHP.Text
        FormUtama.gHobby = hobi
        FormUtama.gFoto = picFoto.Image

        Dim f As New FormKartu
        f.nama = FormUtama.gNama
        f.idAnggota = FormUtama.gID
        f.komunitas = FormUtama.gKomunitas
        f.kontak = FormUtama.gKontak
        f.hobby = FormUtama.gHobby
        f.foto = FormUtama.gFoto

        f.Show()

    End Sub

End Class