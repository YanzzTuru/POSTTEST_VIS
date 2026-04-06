<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInput
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        TabControl1 = New TabControl()
        tabData = New TabPage()
        cbKomunitas = New ComboBox()
        lblKomunitas = New Label()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        lblIJK = New Label()
        dtpLahir = New DateTimePicker()
        lblTanggal = New Label()
        txtID = New TextBox()
        lblID = New Label()
        lblNama = New Label()
        txtNama = New TextBox()
        lblData = New Label()
        tabKotak = New TabPage()
        panelKotak = New Panel()
        txtAlamat = New TextBox()
        lblAlamat = New Label()
        txtEmail = New TextBox()
        lblEmail = New Label()
        mtbHP = New MaskedTextBox()
        lblHP = New Label()
        tabProfil = New TabPage()
        lblHobby = New Label()
        btnSimpan = New Button()
        chk8 = New CheckBox()
        chk7 = New CheckBox()
        chk6 = New CheckBox()
        chk5 = New CheckBox()
        chk4 = New CheckBox()
        chk3 = New CheckBox()
        chk2 = New CheckBox()
        chk1 = New CheckBox()
        grpPeran = New GroupBox()
        rbAnggota = New RadioButton()
        rbKetua = New RadioButton()
        rbAdmin = New RadioButton()
        btnBrowse = New Button()
        picFoto = New PictureBox()
        ErrorProvider1 = New ErrorProvider(components)
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        TabControl1.SuspendLayout()
        tabData.SuspendLayout()
        tabKotak.SuspendLayout()
        panelKotak.SuspendLayout()
        tabProfil.SuspendLayout()
        grpPeran.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabData)
        TabControl1.Controls.Add(tabKotak)
        TabControl1.Controls.Add(tabProfil)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Font = New Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(969, 529)
        TabControl1.TabIndex = 0
        ' 
        ' tabData
        ' 
        tabData.BackColor = Color.White
        tabData.Controls.Add(cbKomunitas)
        tabData.Controls.Add(lblKomunitas)
        tabData.Controls.Add(rbPerempuan)
        tabData.Controls.Add(rbLaki)
        tabData.Controls.Add(lblIJK)
        tabData.Controls.Add(dtpLahir)
        tabData.Controls.Add(lblTanggal)
        tabData.Controls.Add(txtID)
        tabData.Controls.Add(lblID)
        tabData.Controls.Add(lblNama)
        tabData.Controls.Add(txtNama)
        tabData.Controls.Add(lblData)
        tabData.Location = New Point(8, 51)
        tabData.Name = "tabData"
        tabData.Padding = New Padding(3)
        tabData.Size = New Size(953, 470)
        tabData.TabIndex = 0
        tabData.Text = "Data Utama"
        ' 
        ' cbKomunitas
        ' 
        cbKomunitas.DropDownStyle = ComboBoxStyle.DropDownList
        cbKomunitas.FormattingEnabled = True
        cbKomunitas.Items.AddRange(New Object() {"Informatika", "Sistem Informasi", "Ilmu Komputer"})
        cbKomunitas.Location = New Point(250, 275)
        cbKomunitas.Name = "cbKomunitas"
        cbKomunitas.Size = New Size(242, 45)
        cbKomunitas.TabIndex = 11
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.Location = New Point(100, 280)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(142, 37)
        lblKomunitas.TabIndex = 10
        lblKomunitas.Text = "Komunitas"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(416, 230)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(182, 41)
        rbPerempuan.TabIndex = 9
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(268, 230)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(153, 41)
        rbLaki.TabIndex = 8
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' lblIJK
        ' 
        lblIJK.AutoSize = True
        lblIJK.Location = New Point(100, 230)
        lblIJK.Name = "lblIJK"
        lblIJK.Size = New Size(177, 37)
        lblIJK.TabIndex = 7
        lblIJK.Text = "Jenis Kelamin"
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Format = DateTimePickerFormat.Short
        dtpLahir.Location = New Point(268, 175)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(200, 43)
        dtpLahir.TabIndex = 6
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(100, 180)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(175, 37)
        lblTanggal.TabIndex = 5
        lblTanggal.Text = "Tanggal Lahir"
        ' 
        ' txtID
        ' 
        txtID.BorderStyle = BorderStyle.FixedSingle
        txtID.Location = New Point(250, 125)
        txtID.MaxLength = 10
        txtID.Name = "txtID"
        txtID.Size = New Size(250, 43)
        txtID.TabIndex = 4
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(100, 130)
        lblID.Name = "lblID"
        lblID.Size = New Size(153, 37)
        lblID.TabIndex = 3
        lblID.Text = "ID Anggota"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(100, 80)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(88, 37)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.Location = New Point(250, 75)
        txtNama.MaxLength = 50
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(250, 43)
        txtNama.TabIndex = 1
        ' 
        ' lblData
        ' 
        lblData.AutoSize = True
        lblData.Font = New Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblData.ForeColor = Color.DarkBlue
        lblData.Location = New Point(300, 20)
        lblData.Name = "lblData"
        lblData.Size = New Size(259, 50)
        lblData.TabIndex = 0
        lblData.Text = "DATA UTAMA"
        ' 
        ' tabKotak
        ' 
        tabKotak.BackColor = Color.FromArgb(CByte(249), CByte(250), CByte(251))
        tabKotak.Controls.Add(panelKotak)
        tabKotak.Location = New Point(8, 51)
        tabKotak.Name = "tabKotak"
        tabKotak.Padding = New Padding(3)
        tabKotak.Size = New Size(953, 470)
        tabKotak.TabIndex = 1
        tabKotak.Text = "Kotal & Info"
        ' 
        ' panelKotak
        ' 
        panelKotak.BackColor = Color.White
        panelKotak.BorderStyle = BorderStyle.FixedSingle
        panelKotak.Controls.Add(txtAlamat)
        panelKotak.Controls.Add(lblAlamat)
        panelKotak.Controls.Add(txtEmail)
        panelKotak.Controls.Add(lblEmail)
        panelKotak.Controls.Add(mtbHP)
        panelKotak.Controls.Add(lblHP)
        panelKotak.Location = New Point(150, 80)
        panelKotak.Name = "panelKotak"
        panelKotak.Size = New Size(500, 250)
        panelKotak.TabIndex = 0
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(150, 125)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.ScrollBars = ScrollBars.Vertical
        txtAlamat.Size = New Size(250, 70)
        txtAlamat.TabIndex = 6
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(30, 130)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(101, 37)
        lblAlamat.TabIndex = 5
        lblAlamat.Text = "Alamat"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(150, 75)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(250, 43)
        txtEmail.TabIndex = 3
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(30, 80)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(82, 37)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' mtbHP
        ' 
        mtbHP.BorderStyle = BorderStyle.FixedSingle
        mtbHP.Location = New Point(179, 28)
        mtbHP.Mask = "0000-0000-0000"
        mtbHP.Name = "mtbHP"
        mtbHP.Size = New Size(250, 43)
        mtbHP.TabIndex = 1
        ' 
        ' lblHP
        ' 
        lblHP.AutoSize = True
        lblHP.Location = New Point(30, 30)
        lblHP.Name = "lblHP"
        lblHP.Size = New Size(143, 37)
        lblHP.TabIndex = 0
        lblHP.Text = "Nomor Hp"
        ' 
        ' tabProfil
        ' 
        tabProfil.BackColor = Color.White
        tabProfil.Controls.Add(lblHobby)
        tabProfil.Controls.Add(btnSimpan)
        tabProfil.Controls.Add(chk8)
        tabProfil.Controls.Add(chk7)
        tabProfil.Controls.Add(chk6)
        tabProfil.Controls.Add(chk5)
        tabProfil.Controls.Add(chk4)
        tabProfil.Controls.Add(chk3)
        tabProfil.Controls.Add(chk2)
        tabProfil.Controls.Add(chk1)
        tabProfil.Controls.Add(grpPeran)
        tabProfil.Controls.Add(btnBrowse)
        tabProfil.Controls.Add(picFoto)
        tabProfil.Location = New Point(8, 51)
        tabProfil.Name = "tabProfil"
        tabProfil.Padding = New Padding(3)
        tabProfil.Size = New Size(953, 470)
        tabProfil.TabIndex = 2
        tabProfil.Text = "Profil & Aktivitas"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHobby.Location = New Point(300, 173)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(265, 37)
        lblHobby.TabIndex = 13
        lblHobby.Text = "Hobby / Aktivitas:  "
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.DodgerBlue
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(353, 378)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(318, 40)
        btnSimpan.TabIndex = 11
        btnSimpan.Text = "SIMPAN & CETAK"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' chk8
        ' 
        chk8.AutoSize = True
        chk8.Location = New Point(451, 309)
        chk8.Name = "chk8"
        chk8.Size = New Size(156, 41)
        chk8.TabIndex = 10
        chk8.Text = "Traveling"
        chk8.UseVisualStyleBackColor = True
        ' 
        ' chk7
        ' 
        chk7.AutoSize = True
        chk7.Location = New Point(300, 309)
        chk7.Name = "chk7"
        chk7.Size = New Size(142, 41)
        chk7.TabIndex = 9
        chk7.Text = "Menulis"
        chk7.UseVisualStyleBackColor = True
        ' 
        ' chk6
        ' 
        chk6.AutoSize = True
        chk6.Location = New Point(615, 267)
        chk6.Name = "chk6"
        chk6.Size = New Size(142, 41)
        chk6.TabIndex = 8
        chk6.Text = "Editting"
        chk6.UseVisualStyleBackColor = True
        ' 
        ' chk5
        ' 
        chk5.AutoSize = True
        chk5.Location = New Point(451, 262)
        chk5.Name = "chk5"
        chk5.Size = New Size(158, 41)
        chk5.TabIndex = 7
        chk5.Text = "Olahraga"
        chk5.UseVisualStyleBackColor = True
        ' 
        ' chk4
        ' 
        chk4.AutoSize = True
        chk4.Location = New Point(300, 262)
        chk4.Name = "chk4"
        chk4.Size = New Size(119, 41)
        chk4.TabIndex = 6
        chk4.Text = "Musik"
        chk4.UseVisualStyleBackColor = True
        ' 
        ' chk3
        ' 
        chk3.AutoSize = True
        chk3.Location = New Point(615, 220)
        chk3.Name = "chk3"
        chk3.Size = New Size(131, 41)
        chk3.TabIndex = 5
        chk3.Text = "Design"
        chk3.UseVisualStyleBackColor = True
        ' 
        ' chk2
        ' 
        chk2.AutoSize = True
        chk2.Location = New Point(451, 220)
        chk2.Name = "chk2"
        chk2.Size = New Size(143, 41)
        chk2.TabIndex = 4
        chk2.Text = "Gaming"
        chk2.UseVisualStyleBackColor = True
        ' 
        ' chk1
        ' 
        chk1.AutoSize = True
        chk1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chk1.Location = New Point(300, 220)
        chk1.Name = "chk1"
        chk1.Size = New Size(123, 36)
        chk1.TabIndex = 3
        chk1.Text = "Coding"
        chk1.UseVisualStyleBackColor = True
        ' 
        ' grpPeran
        ' 
        grpPeran.Controls.Add(rbAnggota)
        grpPeran.Controls.Add(rbKetua)
        grpPeran.Controls.Add(rbAdmin)
        grpPeran.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpPeran.Location = New Point(300, 50)
        grpPeran.Name = "grpPeran"
        grpPeran.Size = New Size(440, 120)
        grpPeran.TabIndex = 2
        grpPeran.TabStop = False
        grpPeran.Text = "Pilih Peran"
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbAnggota.Location = New Point(274, 42)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(160, 41)
        rbAnggota.TabIndex = 5
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(17, 42)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(123, 41)
        rbKetua.TabIndex = 3
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(139, 42)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(133, 41)
        rbAdmin.TabIndex = 4
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.DodgerBlue
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.ForeColor = Color.White
        btnBrowse.Location = New Point(100, 180)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(120, 46)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' picFoto
        ' 
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(100, 50)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(120, 120)
        picFoto.SizeMode = PictureBoxSizeMode.Zoom
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "Image|*.jpg;*.png"
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.Filter = "Text File|*.txt"
        ' 
        ' FormInput
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(249))
        ClientSize = New Size(969, 529)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FormInput"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Input Data"
        TabControl1.ResumeLayout(False)
        tabData.ResumeLayout(False)
        tabData.PerformLayout()
        tabKotak.ResumeLayout(False)
        panelKotak.ResumeLayout(False)
        panelKotak.PerformLayout()
        tabProfil.ResumeLayout(False)
        tabProfil.PerformLayout()
        grpPeran.ResumeLayout(False)
        grpPeran.PerformLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabData As TabPage
    Friend WithEvents lblData As Label
    Friend WithEvents tabKotak As TabPage
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblIJK As Label
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents lblTanggal As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents cbKomunitas As ComboBox
    Friend WithEvents panelKotak As Panel
    Friend WithEvents lblEmail As Label
    Friend WithEvents mtbHP As MaskedTextBox
    Friend WithEvents lblHP As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents tabProfil As TabPage
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents grpPeran As GroupBox
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents chk8 As CheckBox
    Friend WithEvents chk7 As CheckBox
    Friend WithEvents chk6 As CheckBox
    Friend WithEvents chk5 As CheckBox
    Friend WithEvents chk4 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents lblHobby As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
