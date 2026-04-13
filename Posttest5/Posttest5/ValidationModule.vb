Module Validasi

    Function ValidasiKosong(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text = "" Then
            ep.SetError(txt, pesan)
            txt.Focus()
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Function ValidasiAngka(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If Not IsNumeric(txt.Text) Then
            ep.SetError(txt, pesan)
            txt.Focus()
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

End Module