<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        txtUsername = New MaterialSkin.Controls.MaterialTextBox2()
        txtPassword = New MaterialSkin.Controls.MaterialTextBox2()
        btnLogin = New MaterialSkin.Controls.MaterialButton()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.AnimateReadOnly = False
        txtUsername.BackgroundImageLayout = ImageLayout.None
        txtUsername.CharacterCasing = CharacterCasing.Normal
        txtUsername.Depth = 0
        txtUsername.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtUsername.HideSelection = True
        txtUsername.Hint = "Masukan Username anda"
        txtUsername.LeadingIcon = Nothing
        txtUsername.Location = New Point(331, 332)
        txtUsername.Margin = New Padding(2)
        txtUsername.MaxLength = 32767
        txtUsername.MouseState = MaterialSkin.MouseState.OUT
        txtUsername.Name = "txtUsername"
        txtUsername.PasswordChar = ChrW(0)
        txtUsername.PrefixSuffixText = Nothing
        txtUsername.ReadOnly = False
        txtUsername.RightToLeft = RightToLeft.No
        txtUsername.SelectedText = ""
        txtUsername.SelectionLength = 0
        txtUsername.SelectionStart = 0
        txtUsername.ShortcutsEnabled = True
        txtUsername.Size = New Size(424, 48)
        txtUsername.TabIndex = 1
        txtUsername.TabStop = False
        txtUsername.TextAlign = HorizontalAlignment.Left
        txtUsername.TrailingIcon = Nothing
        txtUsername.UseSystemPasswordChar = False
        ' 
        ' txtPassword
        ' 
        txtPassword.AnimateReadOnly = False
        txtPassword.BackgroundImageLayout = ImageLayout.None
        txtPassword.CharacterCasing = CharacterCasing.Normal
        txtPassword.Depth = 0
        txtPassword.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtPassword.HideSelection = True
        txtPassword.Hint = "Masukan Password anda"
        txtPassword.LeadingIcon = Nothing
        txtPassword.Location = New Point(331, 409)
        txtPassword.Margin = New Padding(2)
        txtPassword.MaxLength = 12
        txtPassword.MouseState = MaterialSkin.MouseState.OUT
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PrefixSuffixText = Nothing
        txtPassword.ReadOnly = False
        txtPassword.RightToLeft = RightToLeft.No
        txtPassword.SelectedText = ""
        txtPassword.SelectionLength = 0
        txtPassword.SelectionStart = 0
        txtPassword.ShortcutsEnabled = True
        txtPassword.Size = New Size(424, 48)
        txtPassword.TabIndex = 2
        txtPassword.TabStop = False
        txtPassword.TextAlign = HorizontalAlignment.Left
        txtPassword.TrailingIcon = Nothing
        txtPassword.UseSystemPasswordChar = False
        ' 
        ' btnLogin
        ' 
        btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnLogin.Depth = 0
        btnLogin.HighEmphasis = True
        btnLogin.Icon = Nothing
        btnLogin.Location = New Point(503, 509)
        btnLogin.Margin = New Padding(3, 5, 3, 5)
        btnLogin.MouseState = MaterialSkin.MouseState.HOVER
        btnLogin.Name = "btnLogin"
        btnLogin.NoAccentTextColor = Color.Empty
        btnLogin.Size = New Size(64, 36)
        btnLogin.TabIndex = 3
        btnLogin.Text = "LOGIN"
        btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnLogin.UseAccentColor = False
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(331, 37)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(424, 269)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(1182, 673)
        Controls.Add(PictureBox1)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Margin = New Padding(2)
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SystemLogin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtPassword As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btnLogin As MaterialSkin.Controls.MaterialButton
    Friend WithEvents PictureBox1 As PictureBox

End Class
