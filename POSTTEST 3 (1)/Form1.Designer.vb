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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        picFoto = New PictureBox()
        btnBrowse = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtTelp = New TextBox()
        txtAlamat = New TextBox()
        dtpTanggal = New DateTimePicker()
        grpJk = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        grpHobby = New GroupBox()
        cbMenari = New CheckBox()
        cbMenyanyi = New CheckBox()
        cbOlahraga = New CheckBox()
        cbMembaca = New CheckBox()
        cbMemancing = New CheckBox()
        cbMenulis = New CheckBox()
        cbMenggambar = New CheckBox()
        cbTraveling = New CheckBox()
        cbCoding = New CheckBox()
        cbGaming = New CheckBox()
        btnCetak = New Button()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        grpJk.SuspendLayout()
        grpHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' picFoto
        ' 
        picFoto.BackColor = Color.Snow
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(24, 29)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(200, 362)
        picFoto.SizeMode = PictureBoxSizeMode.Zoom
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = SystemColors.ScrollBar
        btnBrowse.Location = New Point(29, 408)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(184, 29)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(230, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 23)
        Label1.TabIndex = 2
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(233, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 23)
        Label2.TabIndex = 3
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(230, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 23)
        Label3.TabIndex = 4
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(230, 142)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 23)
        Label4.TabIndex = 5
        Label4.Text = "Nomor Telp"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(233, 189)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 23)
        Label5.TabIndex = 6
        Label5.Text = "Alamat"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(233, 239)
        Label6.Name = "Label6"
        Label6.Size = New Size(112, 23)
        Label6.TabIndex = 7
        Label6.Text = "Jenis Kelamin"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(505, 239)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 23)
        Label7.TabIndex = 8
        Label7.Text = "Hobby"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = SystemColors.Info
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.Location = New Point(292, 11)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(241, 27)
        txtNama.TabIndex = 9
        ' 
        ' txtUmur
        ' 
        txtUmur.BackColor = SystemColors.Info
        txtUmur.BorderStyle = BorderStyle.FixedSingle
        txtUmur.Location = New Point(292, 53)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(241, 27)
        txtUmur.TabIndex = 10
        ' 
        ' txtTelp
        ' 
        txtTelp.BackColor = SystemColors.Info
        txtTelp.BorderStyle = BorderStyle.FixedSingle
        txtTelp.Location = New Point(335, 138)
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(198, 27)
        txtTelp.TabIndex = 11
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = SystemColors.Info
        txtAlamat.BorderStyle = BorderStyle.FixedSingle
        txtAlamat.Location = New Point(303, 185)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(230, 27)
        txtAlamat.TabIndex = 12
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.CalendarMonthBackground = SystemColors.Info
        dtpTanggal.Format = DateTimePickerFormat.Short
        dtpTanggal.Location = New Point(347, 95)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(186, 27)
        dtpTanggal.TabIndex = 13
        ' 
        ' grpJk
        ' 
        grpJk.Controls.Add(rbPerempuan)
        grpJk.Controls.Add(rbLaki)
        grpJk.Location = New Point(230, 236)
        grpJk.Name = "grpJk"
        grpJk.Size = New Size(178, 175)
        grpJk.TabIndex = 14
        grpJk.TabStop = False
        grpJk.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(6, 59)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(6, 29)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(86, 24)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' grpHobby
        ' 
        grpHobby.Controls.Add(cbMenari)
        grpHobby.Controls.Add(cbMenyanyi)
        grpHobby.Controls.Add(cbOlahraga)
        grpHobby.Controls.Add(cbMembaca)
        grpHobby.Controls.Add(cbMemancing)
        grpHobby.Controls.Add(cbMenulis)
        grpHobby.Controls.Add(cbMenggambar)
        grpHobby.Controls.Add(cbTraveling)
        grpHobby.Controls.Add(cbCoding)
        grpHobby.Controls.Add(cbGaming)
        grpHobby.Location = New Point(414, 239)
        grpHobby.Name = "grpHobby"
        grpHobby.Size = New Size(267, 172)
        grpHobby.TabIndex = 15
        grpHobby.TabStop = False
        grpHobby.Text = "Hobby"
        ' 
        ' cbMenari
        ' 
        cbMenari.AutoSize = True
        cbMenari.Location = New Point(142, 143)
        cbMenari.Name = "cbMenari"
        cbMenari.Size = New Size(77, 24)
        cbMenari.TabIndex = 9
        cbMenari.Text = "Menari"
        cbMenari.UseVisualStyleBackColor = True
        ' 
        ' cbMenyanyi
        ' 
        cbMenyanyi.AutoSize = True
        cbMenyanyi.Location = New Point(142, 113)
        cbMenyanyi.Name = "cbMenyanyi"
        cbMenyanyi.Size = New Size(94, 24)
        cbMenyanyi.TabIndex = 8
        cbMenyanyi.Text = "Menyanyi"
        cbMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Location = New Point(142, 83)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(92, 24)
        cbOlahraga.TabIndex = 7
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(142, 54)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(97, 24)
        cbMembaca.TabIndex = 6
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' cbMemancing
        ' 
        cbMemancing.AutoSize = True
        cbMemancing.Location = New Point(142, 27)
        cbMemancing.Name = "cbMemancing"
        cbMemancing.Size = New Size(109, 24)
        cbMemancing.TabIndex = 5
        cbMemancing.Text = "Memancing"
        cbMemancing.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Location = New Point(7, 143)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(82, 24)
        cbMenulis.TabIndex = 4
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbMenggambar
        ' 
        cbMenggambar.AutoSize = True
        cbMenggambar.Location = New Point(6, 113)
        cbMenggambar.Name = "cbMenggambar"
        cbMenggambar.Size = New Size(121, 24)
        cbMenggambar.TabIndex = 3
        cbMenggambar.Text = "Menggambar"
        cbMenggambar.UseVisualStyleBackColor = True
        ' 
        ' cbTraveling
        ' 
        cbTraveling.AutoSize = True
        cbTraveling.Location = New Point(6, 83)
        cbTraveling.Name = "cbTraveling"
        cbTraveling.Size = New Size(91, 24)
        cbTraveling.TabIndex = 2
        cbTraveling.Text = "Traveling"
        cbTraveling.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Location = New Point(7, 53)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(79, 24)
        cbCoding.TabIndex = 1
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(6, 26)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(83, 24)
        cbGaming.TabIndex = 0
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = SystemColors.ScrollBar
        btnCetak.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCetak.Location = New Point(230, 417)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(451, 29)
        btnCetak.TabIndex = 16
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(693, 457)
        Controls.Add(btnCetak)
        Controls.Add(grpHobby)
        Controls.Add(grpJk)
        Controls.Add(dtpTanggal)
        Controls.Add(txtAlamat)
        Controls.Add(txtTelp)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBrowse)
        Controls.Add(picFoto)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Cetak KArtu"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        grpJk.ResumeLayout(False)
        grpJk.PerformLayout()
        grpHobby.ResumeLayout(False)
        grpHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents grpJk As GroupBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents grpHobby As GroupBox
    Friend WithEvents cbMenggambar As CheckBox
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbMenari As CheckBox
    Friend WithEvents cbMenyanyi As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbMemancing As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents btnCetak As Button

End Class
