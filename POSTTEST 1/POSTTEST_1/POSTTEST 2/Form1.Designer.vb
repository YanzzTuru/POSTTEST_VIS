<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lbJudul = New Label()
        lblGenre = New Label()
        txtJudul = New TextBox()
        txtHapus = New TextBox()
        btnTambah = New Button()
        btnHapus = New Button()
        lblHapus = New Label()
        txtGenre = New TextBox()
        lstBuku = New ListBox()
        gbTambah = New GroupBox()
        gbHapus = New GroupBox()
        gbTambah.SuspendLayout()
        gbHapus.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbJudul
        ' 
        lbJudul.AutoSize = True
        lbJudul.Location = New Point(6, 29)
        lbJudul.Name = "lbJudul"
        lbJudul.Size = New Size(79, 20)
        lbJudul.TabIndex = 0
        lbJudul.Text = "Judul Buku"
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Location = New Point(15, 89)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(48, 20)
        lblGenre.TabIndex = 1
        lblGenre.Text = "Genre"
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(97, 26)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(125, 27)
        txtJudul.TabIndex = 2
        ' 
        ' txtHapus
        ' 
        txtHapus.Location = New Point(112, 30)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(125, 27)
        txtHapus.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(187, 130)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(231, 118)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 5
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' lblHapus
        ' 
        lblHapus.AutoSize = True
        lblHapus.Location = New Point(14, 33)
        lblHapus.Name = "lblHapus"
        lblHapus.Size = New Size(79, 20)
        lblHapus.TabIndex = 6
        lblHapus.Text = "Judul Buku"
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(97, 86)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(125, 27)
        txtGenre.TabIndex = 7
        ' 
        ' lstBuku
        ' 
        lstBuku.FormattingEnabled = True
        lstBuku.Location = New Point(242, 202)
        lstBuku.Name = "lstBuku"
        lstBuku.Size = New Size(328, 244)
        lstBuku.TabIndex = 8
        ' 
        ' gbTambah
        ' 
        gbTambah.Controls.Add(lbJudul)
        gbTambah.Controls.Add(txtJudul)
        gbTambah.Controls.Add(lblGenre)
        gbTambah.Controls.Add(txtGenre)
        gbTambah.Controls.Add(btnTambah)
        gbTambah.Location = New Point(55, 31)
        gbTambah.Name = "gbTambah"
        gbTambah.Size = New Size(287, 165)
        gbTambah.TabIndex = 9
        gbTambah.TabStop = False
        gbTambah.Text = "Tambah Buku"
        ' 
        ' gbHapus
        ' 
        gbHapus.Controls.Add(lblHapus)
        gbHapus.Controls.Add(txtHapus)
        gbHapus.Controls.Add(btnHapus)
        gbHapus.Location = New Point(389, 31)
        gbHapus.Name = "gbHapus"
        gbHapus.Size = New Size(343, 165)
        gbHapus.TabIndex = 10
        gbHapus.TabStop = False
        gbHapus.Text = "Hapus buku"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(gbHapus)
        Controls.Add(gbTambah)
        Controls.Add(lstBuku)
        Name = "Form1"
        Text = "Form1"
        gbTambah.ResumeLayout(False)
        gbTambah.PerformLayout()
        gbHapus.ResumeLayout(False)
        gbHapus.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lbJudul As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents lblHapus As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents lstBuku As ListBox
    Friend WithEvents gbTambah As GroupBox
    Friend WithEvents gbHapus As GroupBox

End Class
