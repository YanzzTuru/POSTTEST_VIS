Public Class FormKartu

    Public nama As String
    Public idAnggota As String
    Public komunitas As String
    Public kontak As String
    Public hobby As String
    Public foto As Image

    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblNama.Text = "Nama : " & nama
        lblID.Text = "ID : " & idAnggota
        lblKomunitas.Text = "Komunitas : " & komunitas
        lblKontak.Text = "Kontak : " & kontak
        lblHobby.Text = "Hobby : " & hobby

        If foto IsNot Nothing Then
            picKartu.Image = foto
        End If

    End Sub

End Class