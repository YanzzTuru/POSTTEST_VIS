Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Sub TampilData()
        dgvBunga.DataSource = DataModule.GetAllBunga()
    End Sub

    Sub Kosong()
        txtKode.Clear()
        txtJenis.Clear()
        txtHarga.Clear()
        txtStok.Clear()
        txtKode.Focus()
        ErrorProvider1.Clear()
    End Sub

    Function Validasi() As Boolean
        ErrorProvider1.Clear()

        If txtKode.Text = "" Then
            ErrorProvider1.SetError(txtKode, "Kode bunga wajib diisi")
            Return False
        End If

        If txtJenis.Text = "" Then
            ErrorProvider1.SetError(txtJenis, "Nama bunga wajib diisi")
            Return False
        End If

        If txtHarga.Text = "" Then
            ErrorProvider1.SetError(txtHarga, "Harga wajib diisi")
            Return False
        End If

        If txtStok.Text = "" Then
            ErrorProvider1.SetError(txtStok, "Stok wajib diisi")
            Return False
        End If

        Return True
    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If Not Validasi() Then Exit Sub

        If DataModule.KodeBungaSudahAda(txtKode.Text) Then
            MessageBox.Show("Kode bunga sudah ada!")
            Exit Sub
        End If

        Dim kodeJenis As String = "J01"

        DataModule.SimpanBunga(
            txtKode.Text,
            kodeJenis,
            txtJenis.Text,
            CInt(txtHarga.Text),
            CInt(txtStok.Text),
            "-"
        )

        MessageBox.Show("Data berhasil disimpan")
        TampilData()
        Kosong()
    End Sub

    Private Sub dgvBunga_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBunga.CellClick
        If e.RowIndex >= 0 Then
            txtKode.Text = dgvBunga.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtJenis.Text = dgvBunga.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtHarga.Text = dgvBunga.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtStok.Text = dgvBunga.Rows(e.RowIndex).Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click

        Dim kodeJenis As String = "J01"

        DataModule.UbahBunga(
            txtKode.Text,
            kodeJenis,
            txtJenis.Text,
            CInt(txtHarga.Text),
            CInt(txtStok.Text),
            "-"
        )

        MessageBox.Show("Data berhasil diubah")
        TampilData()
        Kosong()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvBunga.CurrentRow IsNot Nothing Then
            DataModule.HapusBunga(txtKode.Text)

            MessageBox.Show("Data berhasil dihapus")
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            TampilData()
        Else
            dgvBunga.DataSource = DataModule.SearchBunga(txtSearch.Text)
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBuku_Click(sender As Object, e As EventArgs) Handles btnBunga.Click
        Dim f As New Form2
        f.ShowDialog()

        TampilData()
    End Sub

End Class