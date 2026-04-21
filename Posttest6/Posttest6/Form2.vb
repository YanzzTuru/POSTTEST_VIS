Public Class Form2

    Sub Kosong()
        txtKodeBunga.Clear()
        cbJenis.SelectedIndex = -1
        txtNamaBunga.Clear()
        txtHarga.Clear()
        txtStok.Clear()
        txtDeskripsi.Clear()
        ErrorProvider1.Clear()
    End Sub

    Sub TampilData()
        dgvBunga.DataSource = DataModule.GetAllBunga()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbJenis.DataSource = DataModule.GetAllJenis()
        cbJenis.DisplayMember = "jenis"
        cbJenis.ValueMember = "kodeJenis"

        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If Not ValidationModule.ValidasiDataBunga(ErrorProvider1,
                                                  txtKodeBunga,
                                                  txtNamaBunga,
                                                  cbJenis,
                                                  txtHarga,
                                                  txtStok) Then Exit Sub

        If DataModule.KodeBungaSudahAda(txtKodeBunga.Text) Then
            MessageBox.Show("Kode bunga sudah ada!")
            Exit Sub
        End If

        DataModule.SimpanBunga(
            txtKodeBunga.Text,
            cbJenis.SelectedValue.ToString(),
            txtNamaBunga.Text,
            CInt(txtHarga.Text),
            CInt(txtStok.Text),
            txtDeskripsi.Text)

        MessageBox.Show("Data berhasil disimpan")
        TampilData()
        Kosong()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click

        DataModule.UbahBunga(
            txtKodeBunga.Text,
            cbJenis.SelectedValue.ToString(),
            txtNamaBunga.Text,
            CInt(txtHarga.Text),
            CInt(txtStok.Text),
            txtDeskripsi.Text)

        MessageBox.Show("Data berhasil diubah")
        TampilData()
        Kosong()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If MessageBox.Show("Yakin ingin menghapus data?", "Konfirmasi",
                           MessageBoxButtons.YesNo) = DialogResult.Yes Then

            DataModule.HapusBunga(txtKodeBunga.Text)

            MessageBox.Show("Data berhasil dihapus")
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    Private Sub dgvBunga_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBunga.CellClick
        If e.RowIndex >= 0 Then
            txtKodeBunga.Text = dgvBunga.Rows(e.RowIndex).Cells(0).Value.ToString()
            cbJenis.Text = dgvBunga.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtNamaBunga.Text = dgvBunga.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtHarga.Text = dgvBunga.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtStok.Text = dgvBunga.Rows(e.RowIndex).Cells(4).Value.ToString()
            txtDeskripsi.Text = dgvBunga.Rows(e.RowIndex).Cells(5).Value.ToString()
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text = "" Then
            TampilData()
        Else
            dgvBunga.DataSource = DataModule.SearchBunga(txtCari.Text)
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub

    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub

End Class