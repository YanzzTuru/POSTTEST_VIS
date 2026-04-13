<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose
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

    'Required designer variable
    Private components As System.ComponentModel.IContainer

    'NOTE: Required method
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtKode = New TextBox()
        txtJenis = New TextBox()
        txtHarga = New TextBox()
        txtStok = New TextBox()
        txtSearch = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvBunga = New DataGridView()
        ErrorProvider2 = New ErrorProvider(components)
        CType(dgvBunga, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 32)
        Label1.TabIndex = 0
        Label1.Text = "Kode Bunga"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(30, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 32)
        Label2.TabIndex = 1
        Label2.Text = "Nama Bunga"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(30, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 32)
        Label3.TabIndex = 2
        Label3.Text = "Harga"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 32)
        Label4.TabIndex = 3
        Label4.Text = "Stok"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(400, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 32)
        Label5.TabIndex = 4
        Label5.Text = "Cari Data"
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(188, 30)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(200, 39)
        txtKode.TabIndex = 5
        ' 
        ' txtJenis
        ' 
        txtJenis.Location = New Point(188, 70)
        txtJenis.Name = "txtJenis"
        txtJenis.Size = New Size(200, 39)
        txtJenis.TabIndex = 6
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(188, 110)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(200, 39)
        txtHarga.TabIndex = 7
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(188, 150)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(200, 39)
        txtStok.TabIndex = 8
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(517, 27)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(250, 39)
        txtSearch.TabIndex = 9
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(30, 200)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(108, 45)
        btnSimpan.TabIndex = 10
        btnSimpan.Text = "Simpan"
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(144, 200)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(108, 45)
        btnUbah.TabIndex = 11
        btnUbah.Text = "Ubah"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(258, 200)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(108, 45)
        btnHapus.TabIndex = 12
        btnHapus.Text = "Hapus"
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(372, 200)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(108, 45)
        btnBatal.TabIndex = 13
        btnBatal.Text = "Batal"
        ' 
        ' dgvBunga
        ' 
        dgvBunga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBunga.Location = New Point(42, 251)
        dgvBunga.Name = "dgvBunga"
        dgvBunga.RowHeadersWidth = 82
        dgvBunga.Size = New Size(688, 237)
        dgvBunga.TabIndex = 14
        ' 
        ' ErrorProvider2
        ' 
        ErrorProvider2.ContainerControl = Me
        ' 
        ' Form1
        ' 
        ClientSize = New Size(800, 500)
        Controls.Add(dgvBunga)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(txtKode)
        Controls.Add(txtJenis)
        Controls.Add(txtHarga)
        Controls.Add(txtStok)
        Controls.Add(txtSearch)
        Controls.Add(btnSimpan)
        Controls.Add(btnUbah)
        Controls.Add(btnHapus)
        Controls.Add(btnBatal)
        Name = "Form1"
        Text = "Sistem Manajemen Toko Bunga"
        CType(dgvBunga, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtJenis As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtSearch As TextBox

    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents dgvBunga As DataGridView
    Friend WithEvents ErrorProvider2 As ErrorProvider

End Class