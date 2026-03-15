<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        picHasil = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblTanggal = New Label()
        lblJK = New Label()
        lblTelp = New Label()
        lblHobby = New Label()
        lblAlamat = New Label()
        CType(picHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picHasil
        ' 
        picHasil.BorderStyle = BorderStyle.FixedSingle
        picHasil.Location = New Point(12, 30)
        picHasil.Name = "picHasil"
        picHasil.Size = New Size(202, 268)
        picHasil.SizeMode = PictureBoxSizeMode.Zoom
        picHasil.TabIndex = 0
        picHasil.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(229, 30)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(65, 23)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama :"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUmur.Location = New Point(229, 66)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(62, 23)
        lblUmur.TabIndex = 2
        lblUmur.Text = "Umur :"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTanggal.Location = New Point(229, 101)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(120, 23)
        lblTanggal.TabIndex = 3
        lblTanggal.Text = "Tanggal Lahir :"
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJK.Location = New Point(229, 136)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(121, 23)
        lblJK.TabIndex = 4
        lblJK.Text = "Jenis Kelamin :"
        ' 
        ' lblTelp
        ' 
        lblTelp.AutoSize = True
        lblTelp.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTelp.Location = New Point(229, 173)
        lblTelp.Name = "lblTelp"
        lblTelp.Size = New Size(97, 23)
        lblTelp.TabIndex = 5
        lblTelp.Text = "No Telpon :"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHobby.Location = New Point(229, 208)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(69, 23)
        lblHobby.TabIndex = 6
        lblHobby.Text = "Hobby :"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAlamat.Location = New Point(229, 245)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(73, 23)
        lblAlamat.TabIndex = 7
        lblAlamat.Text = "Alamat :"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(642, 335)
        Controls.Add(lblAlamat)
        Controls.Add(lblHobby)
        Controls.Add(lblTelp)
        Controls.Add(lblJK)
        Controls.Add(lblTanggal)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(picHasil)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hasil Kartu"
        CType(picHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picHasil As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents lblTelp As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblAlamat As Label
End Class
