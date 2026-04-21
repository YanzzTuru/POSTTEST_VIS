<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        txtKodeBunga = New TextBox()
        Label2 = New Label()
        cbJenis = New ComboBox()
        Label3 = New Label()
        txtNamaBunga = New TextBox()
        Label4 = New Label()
        txtHarga = New TextBox()
        Label5 = New Label()
        txtStok = New TextBox()
        Label6 = New Label()
        txtDeskripsi = New TextBox()
        Label7 = New Label()
        txtCari = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvBunga = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvBunga, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        Label1.Location = New Point(16, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 35)
        Label1.TabIndex = 0
        Label1.Text = "Kode Bunga"

        txtKodeBunga.Location = New Point(152, 79)
        txtKodeBunga.Name = "txtKodeBunga"
        txtKodeBunga.Size = New Size(200, 39)
        txtKodeBunga.TabIndex = 1

        Label2.Location = New Point(16, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 35)
        Label2.TabIndex = 2
        Label2.Text = "Jenis Bunga"

        cbJenis.DropDownStyle = ComboBoxStyle.DropDownList
        cbJenis.Location = New Point(152, 119)
        cbJenis.Name = "cbJenis"
        cbJenis.Size = New Size(200, 40)
        cbJenis.TabIndex = 3

        Label3.Location = New Point(16, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 37)
        Label3.TabIndex = 4
        Label3.Text = "Nama Bunga"

        txtNamaBunga.Location = New Point(152, 159)
        txtNamaBunga.Name = "txtNamaBunga"
        txtNamaBunga.Size = New Size(200, 39)
        txtNamaBunga.TabIndex = 5

        Label4.Location = New Point(16, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 33)
        Label4.TabIndex = 6
        Label4.Text = "Harga"

        txtHarga.Location = New Point(152, 199)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(200, 39)
        txtHarga.TabIndex = 7

        Label5.Location = New Point(16, 242)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 36)
        Label5.TabIndex = 8
        Label5.Text = "Stok"

        txtStok.Location = New Point(152, 239)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(200, 39)
        txtStok.TabIndex = 9

        Label6.Location = New Point(16, 294)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 34)
        Label6.TabIndex = 10
        Label6.Text = "Deskripsi"

        txtDeskripsi.Location = New Point(152, 279)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.Size = New Size(200, 60)
        txtDeskripsi.TabIndex = 11

        Label7.Location = New Point(420, 32)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 39)
        Label7.TabIndex = 12
        Label7.Text = "Cari"

        txtCari.Location = New Point(524, 32)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(300, 39)
        txtCari.TabIndex = 13

        btnSimpan.Location = New Point(16, 382)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(103, 37)
        btnSimpan.TabIndex = 14
        btnSimpan.Text = "Simpan"

        btnUbah.Location = New Point(116, 382)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(103, 37)
        btnUbah.TabIndex = 15
        btnUbah.Text = "Ubah"

        btnHapus.Location = New Point(216, 382)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(103, 37)
        btnHapus.TabIndex = 16
        btnHapus.Text = "Hapus"

        btnBatal.Location = New Point(316, 382)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(103, 37)
        btnBatal.TabIndex = 17
        btnBatal.Text = "Batal"

        dgvBunga.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBunga.ColumnHeadersHeight = 46
        dgvBunga.Location = New Point(380, 77)
        dgvBunga.Name = "dgvBunga"
        dgvBunga.RowHeadersWidth = 82
        dgvBunga.Size = New Size(500, 299)
        dgvBunga.TabIndex = 18

        ErrorProvider1.ContainerControl = Me

        ClientSize = New Size(917, 515)
        Controls.Add(Label1)
        Controls.Add(txtKodeBunga)
        Controls.Add(Label2)
        Controls.Add(cbJenis)
        Controls.Add(Label3)
        Controls.Add(txtNamaBunga)
        Controls.Add(Label4)
        Controls.Add(txtHarga)
        Controls.Add(Label5)
        Controls.Add(txtStok)
        Controls.Add(Label6)
        Controls.Add(txtDeskripsi)
        Controls.Add(Label7)
        Controls.Add(txtCari)
        Controls.Add(btnSimpan)
        Controls.Add(btnUbah)
        Controls.Add(btnHapus)
        Controls.Add(btnBatal)
        Controls.Add(dgvBunga)
        Name = "Form2"
        Text = "Sistem Toko Bunga"
        CType(dgvBunga, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtKodeBunga As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNamaBunga As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStok As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvBunga As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class