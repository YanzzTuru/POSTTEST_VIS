<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
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
        panelKartu = New Panel()
        lblID = New Label()
        lblHobby = New Label()
        lblKontak = New Label()
        lblKomunitas = New Label()
        lblNama = New Label()
        picKartu = New PictureBox()
        lblHeadeer = New Label()
        panelLine = New Panel()
        panelKartu.SuspendLayout()
        CType(picKartu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelKartu
        ' 
        panelKartu.BackColor = Color.White
        panelKartu.BorderStyle = BorderStyle.FixedSingle
        panelKartu.Controls.Add(lblID)
        panelKartu.Controls.Add(lblHobby)
        panelKartu.Controls.Add(lblKontak)
        panelKartu.Controls.Add(lblKomunitas)
        panelKartu.Controls.Add(lblNama)
        panelKartu.Location = New Point(120, 68)
        panelKartu.Name = "panelKartu"
        panelKartu.Size = New Size(379, 288)
        panelKartu.TabIndex = 0
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.BorderStyle = BorderStyle.FixedSingle
        lblID.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblID.Location = New Point(17, 56)
        lblID.Name = "lblID"
        lblID.Size = New Size(179, 34)
        lblID.TabIndex = 4
        lblID.Text = "ID Anggota : -"
        ' 
        ' lblHobby
        ' 
        lblHobby.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHobby.Location = New Point(17, 163)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(357, 123)
        lblHobby.TabIndex = 3
        lblHobby.Text = "Hobby : -"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKontak.Location = New Point(17, 131)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(126, 32)
        lblKontak.TabIndex = 2
        lblKontak.Text = "Kontak : -"
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKomunitas.Location = New Point(15, 90)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(168, 32)
        lblKomunitas.TabIndex = 1
        lblKomunitas.Text = "Komunitas : -"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.ForeColor = Color.Black
        lblNama.Location = New Point(13, 9)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(125, 37)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama : -"
        ' 
        ' picKartu
        ' 
        picKartu.BorderStyle = BorderStyle.FixedSingle
        picKartu.Location = New Point(12, 68)
        picKartu.Name = "picKartu"
        picKartu.Size = New Size(80, 80)
        picKartu.SizeMode = PictureBoxSizeMode.Zoom
        picKartu.TabIndex = 1
        picKartu.TabStop = False
        ' 
        ' lblHeadeer
        ' 
        lblHeadeer.AutoSize = True
        lblHeadeer.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeadeer.ForeColor = Color.White
        lblHeadeer.Location = New Point(157, 9)
        lblHeadeer.Name = "lblHeadeer"
        lblHeadeer.Size = New Size(273, 45)
        lblHeadeer.TabIndex = 2
        lblHeadeer.Text = "KARTU MEMBER"
        ' 
        ' panelLine
        ' 
        panelLine.BackColor = Color.Gray
        panelLine.Location = New Point(136, 52)
        panelLine.Name = "panelLine"
        panelLine.Size = New Size(300, 2)
        panelLine.TabIndex = 3
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        ClientSize = New Size(614, 402)
        Controls.Add(panelLine)
        Controls.Add(lblHeadeer)
        Controls.Add(picKartu)
        Controls.Add(panelKartu)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormKartu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kartu Komunitas"
        panelKartu.ResumeLayout(False)
        panelKartu.PerformLayout()
        CType(picKartu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents panelKartu As Panel
    Friend WithEvents lblNama As Label
    Friend WithEvents picKartu As PictureBox
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblHeadeer As Label
    Friend WithEvents panelLine As Panel
    Friend WithEvents lblID As Label
End Class
