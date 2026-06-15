<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUtama))
        Panel1 = New Panel()
        btnLogOut = New Button()
        btnTransaksi = New Button()
        btnPelanggan = New Button()
        btnDasboard = New Button()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        txtUserLogin = New Button()
        Label1 = New Label()
        PanelContainer = New Panel()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Highlight
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(btnLogOut)
        Panel1.Controls.Add(btnTransaksi)
        Panel1.Controls.Add(btnPelanggan)
        Panel1.Controls.Add(btnDasboard)
        Panel1.Controls.Add(Panel3)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(212, 478)
        Panel1.TabIndex = 0
        ' 
        ' btnLogOut
        ' 
        btnLogOut.FlatAppearance.BorderSize = 0
        btnLogOut.FlatStyle = FlatStyle.Flat
        btnLogOut.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogOut.Image = CType(resources.GetObject("btnLogOut.Image"), Image)
        btnLogOut.ImageAlign = ContentAlignment.MiddleLeft
        btnLogOut.Location = New Point(30, 294)
        btnLogOut.Margin = New Padding(2)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.RightToLeft = RightToLeft.No
        btnLogOut.Size = New Size(148, 54)
        btnLogOut.TabIndex = 6
        btnLogOut.Text = "LogOut"
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' btnTransaksi
        ' 
        btnTransaksi.FlatAppearance.BorderSize = 0
        btnTransaksi.FlatStyle = FlatStyle.Flat
        btnTransaksi.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTransaksi.Image = CType(resources.GetObject("btnTransaksi.Image"), Image)
        btnTransaksi.ImageAlign = ContentAlignment.MiddleLeft
        btnTransaksi.Location = New Point(30, 236)
        btnTransaksi.Margin = New Padding(2)
        btnTransaksi.Name = "btnTransaksi"
        btnTransaksi.Size = New Size(148, 54)
        btnTransaksi.TabIndex = 5
        btnTransaksi.Text = "Transaksi"
        btnTransaksi.UseVisualStyleBackColor = True
        ' 
        ' btnPelanggan
        ' 
        btnPelanggan.FlatAppearance.BorderSize = 0
        btnPelanggan.FlatStyle = FlatStyle.Flat
        btnPelanggan.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPelanggan.Image = CType(resources.GetObject("btnPelanggan.Image"), Image)
        btnPelanggan.ImageAlign = ContentAlignment.MiddleLeft
        btnPelanggan.Location = New Point(30, 178)
        btnPelanggan.Margin = New Padding(2)
        btnPelanggan.Name = "btnPelanggan"
        btnPelanggan.Size = New Size(148, 54)
        btnPelanggan.TabIndex = 4
        btnPelanggan.Text = "Pelanggan"
        btnPelanggan.UseVisualStyleBackColor = True
        ' 
        ' btnDasboard
        ' 
        btnDasboard.FlatAppearance.BorderSize = 0
        btnDasboard.FlatStyle = FlatStyle.Flat
        btnDasboard.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDasboard.Image = CType(resources.GetObject("btnDasboard.Image"), Image)
        btnDasboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDasboard.Location = New Point(30, 130)
        btnDasboard.Margin = New Padding(2)
        btnDasboard.Name = "btnDasboard"
        btnDasboard.Size = New Size(148, 34)
        btnDasboard.TabIndex = 3
        btnDasboard.Text = "Dasboard"
        btnDasboard.TextImageRelation = TextImageRelation.ImageAboveText
        btnDasboard.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(PictureBox1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Margin = New Padding(2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(212, 80)
        Panel3.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Image = My.Resources.Resources.LOUNDRY_HAKU
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(212, 80)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.MenuHighlight
        Panel2.Controls.Add(txtUserLogin)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(212, 0)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(549, 80)
        Panel2.TabIndex = 1
        ' 
        ' txtUserLogin
        ' 
        txtUserLogin.FlatAppearance.BorderSize = 0
        txtUserLogin.FlatStyle = FlatStyle.Flat
        txtUserLogin.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUserLogin.Image = CType(resources.GetObject("txtUserLogin.Image"), Image)
        txtUserLogin.ImageAlign = ContentAlignment.MiddleLeft
        txtUserLogin.Location = New Point(398, 11)
        txtUserLogin.Margin = New Padding(2)
        txtUserLogin.Name = "txtUserLogin"
        txtUserLogin.RightToLeft = RightToLeft.No
        txtUserLogin.Size = New Size(148, 54)
        txtUserLogin.TabIndex = 6
        txtUserLogin.Text = "Usename"
        txtUserLogin.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(39, 24)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 41)
        Label1.TabIndex = 0
        Label1.Text = "LAUNDRY HAKU"
        ' 
        ' PanelContainer
        ' 
        PanelContainer.Dock = DockStyle.Fill
        PanelContainer.ForeColor = SystemColors.Desktop
        PanelContainer.Location = New Point(212, 80)
        PanelContainer.Margin = New Padding(2)
        PanelContainer.Name = "PanelContainer"
        PanelContainer.Size = New Size(549, 398)
        PanelContainer.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(61, 369)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 7
        Button1.Text = "User"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(761, 478)
        Controls.Add(PanelContainer)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(2)
        Name = "FormUtama"
        Text = " "
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents btnDasboard As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPelanggan As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnTransaksi As Button
    Friend WithEvents txtUserLogin As Button
    Friend WithEvents Button1 As Button
End Class
