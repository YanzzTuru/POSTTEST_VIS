<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
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
        lblJudul = New Label()
        picLogo = New PictureBox()
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.BackColor = Color.LightSlateGray
        lblJudul.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(39, 300)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(708, 65)
        lblJudul.TabIndex = 0
        lblJudul.Text = "APLIKASI KARTU KOMUNITAS"
        lblJudul.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picLogo
        ' 
        picLogo.Location = New Point(300, 100)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(200, 150)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 1
        picLogo.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(32, 32)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(774, 42)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(146, 38)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(148, 38)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(170, 38)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(139, 38)
        BukaDataToolStripMenuItem.Text = "Buka data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(101, 38)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(774, 429)
        Controls.Add(picLogo)
        Controls.Add(lblJudul)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "FormUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu Utama"
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem

End Class
