Module ValidationModule

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cb As ComboBox, pesan As String) As Boolean
        If cb.SelectedIndex = -1 Then
            ep.SetError(cb, pesan)
            Return False
        Else
            ep.SetError(cb, "")
            Return True
        End If
    End Function

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = Chr(13)
    End Function

    Public Function ValidasiDataBunga(ep As ErrorProvider,
                                      txtKode As TextBox,
                                      txtNamaBunga As TextBox,
                                      cbJenis As ComboBox,
                                      txtHarga As TextBox,
                                      txtStok As TextBox) As Boolean

        Dim a As Boolean = ValidasiTextBox(ep, txtKode, "Kode bunga wajib diisi")
        Dim b As Boolean = ValidasiTextBox(ep, txtNamaBunga, "Nama bunga wajib diisi")
        Dim c As Boolean = ValidasiComboBox(ep, cbJenis, "Pilih jenis bunga")
        Dim d As Boolean = ValidasiTextBox(ep, txtHarga, "Harga wajib diisi")
        Dim e1 As Boolean = ValidasiTextBox(ep, txtStok, "Stok wajib diisi")

        Return a And b And c And d And e1
    End Function

End Module