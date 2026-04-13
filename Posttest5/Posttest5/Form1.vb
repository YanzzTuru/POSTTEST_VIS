Public Class Form1

    Sub TampilData()
        dgvBunga.DataSource = GetAllJenis()
    End Sub

    Sub Kosong()
        txtKode.Clear()
        txtJenis.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        If Not ValidasiKosong(ErrorProvider1, txtKode, "Kode wajib diisi") Then Exit Sub
        If Not ValidasiKosong(ErrorProvider1, txtJenis, "Jenis wajib diisi") Then Exit Sub

        If KodeSudahAda(txtKode.Text) Then
            MessageBox.Show("Kode sudah ada!")
            Exit Sub
        End If

        If SimpanJenis(txtKode.Text, txtJenis.Text) Then
            MessageBox.Show("Data berhasil disimpan")
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtKode.Text = "" Then
            MessageBox.Show("Pilih data dulu!")
            Exit Sub
        End If

        If UbahJenis(txtKode.Text, txtJenis.Text) Then
            MessageBox.Show("Data berhasil diubah")
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKode.Text = "" Then
            MessageBox.Show("Pilih data dulu!")
            Exit Sub
        End If

        If HapusJenis(txtKode.Text) Then
            MessageBox.Show("Data berhasil dihapus")
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dgvBunga.DataSource = SearchJenis(txtSearch.Text)
    End Sub

    Private Sub dgvBunga_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBunga.CellClick
        If e.RowIndex >= 0 Then
            txtKode.Text = dgvBunga.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtJenis.Text = dgvBunga.Rows(e.RowIndex).Cells(1).Value.ToString()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

End Class