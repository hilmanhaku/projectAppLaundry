<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Label1 = New Label()
        txtNamaUser = New TextBox()
        Label2 = New Label()
        txtUsername = New TextBox()
        Label3 = New Label()
        txtPassword = New TextBox()
        Label4 = New Label()
        cmbLevelUser = New ComboBox()
        btnSimpan = New MaterialSkin.Controls.MaterialButton()
        btnUbah = New MaterialSkin.Controls.MaterialButton()
        btnHapus = New MaterialSkin.Controls.MaterialButton()
        btnBatal = New MaterialSkin.Controls.MaterialButton()
        dgvUser = New DataGridView()
        txtCariUser = New MaterialSkin.Controls.MaterialTextBox2()
        CType(dgvUser, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(113, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama User"
        ' 
        ' txtNamaUser
        ' 
        txtNamaUser.Location = New Point(211, 76)
        txtNamaUser.Name = "txtNamaUser"
        txtNamaUser.Size = New Size(151, 27)
        txtNamaUser.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(113, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 0
        Label2.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(211, 132)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(151, 27)
        txtUsername.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(113, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 0
        Label3.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(211, 180)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(151, 27)
        txtPassword.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(113, 232)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 20)
        Label4.TabIndex = 0
        Label4.Text = "Level User"
        ' 
        ' cmbLevelUser
        ' 
        cmbLevelUser.FormattingEnabled = True
        cmbLevelUser.Items.AddRange(New Object() {"admin", "kasir"})
        cmbLevelUser.Location = New Point(211, 232)
        cmbLevelUser.Name = "cmbLevelUser"
        cmbLevelUser.Size = New Size(151, 28)
        cmbLevelUser.TabIndex = 2
        ' 
        ' btnSimpan
        ' 
        btnSimpan.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSimpan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnSimpan.Depth = 0
        btnSimpan.HighEmphasis = True
        btnSimpan.Icon = Nothing
        btnSimpan.Location = New Point(132, 305)
        btnSimpan.Margin = New Padding(4, 6, 4, 6)
        btnSimpan.MouseState = MaterialSkin.MouseState.HOVER
        btnSimpan.Name = "btnSimpan"
        btnSimpan.NoAccentTextColor = Color.Empty
        btnSimpan.Size = New Size(77, 36)
        btnSimpan.TabIndex = 3
        btnSimpan.Text = "Simpan"
        btnSimpan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnSimpan.UseAccentColor = False
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnUbah.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnUbah.Depth = 0
        btnUbah.HighEmphasis = True
        btnUbah.Icon = Nothing
        btnUbah.Location = New Point(274, 305)
        btnUbah.Margin = New Padding(4, 6, 4, 6)
        btnUbah.MouseState = MaterialSkin.MouseState.HOVER
        btnUbah.Name = "btnUbah"
        btnUbah.NoAccentTextColor = Color.Empty
        btnUbah.Size = New Size(64, 36)
        btnUbah.TabIndex = 3
        btnUbah.Text = "Ubah"
        btnUbah.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnUbah.UseAccentColor = False
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnHapus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnHapus.Depth = 0
        btnHapus.HighEmphasis = True
        btnHapus.Icon = Nothing
        btnHapus.Location = New Point(132, 369)
        btnHapus.Margin = New Padding(4, 6, 4, 6)
        btnHapus.MouseState = MaterialSkin.MouseState.HOVER
        btnHapus.Name = "btnHapus"
        btnHapus.NoAccentTextColor = Color.Empty
        btnHapus.Size = New Size(69, 36)
        btnHapus.TabIndex = 3
        btnHapus.Text = "Hapus"
        btnHapus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnHapus.UseAccentColor = False
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnBatal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnBatal.Depth = 0
        btnBatal.HighEmphasis = True
        btnBatal.Icon = Nothing
        btnBatal.Location = New Point(274, 369)
        btnBatal.Margin = New Padding(4, 6, 4, 6)
        btnBatal.MouseState = MaterialSkin.MouseState.HOVER
        btnBatal.Name = "btnBatal"
        btnBatal.NoAccentTextColor = Color.Empty
        btnBatal.Size = New Size(65, 36)
        btnBatal.TabIndex = 3
        btnBatal.Text = "Reset"
        btnBatal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnBatal.UseAccentColor = False
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' dgvUser
        ' 
        dgvUser.AllowUserToAddRows = False
        dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUser.Location = New Point(407, 124)
        dgvUser.Name = "dgvUser"
        dgvUser.ReadOnly = True
        dgvUser.RowHeadersWidth = 51
        dgvUser.Size = New Size(592, 314)
        dgvUser.TabIndex = 4
        ' 
        ' txtCariUser
        ' 
        txtCariUser.AnimateReadOnly = False
        txtCariUser.BackgroundImageLayout = ImageLayout.None
        txtCariUser.CharacterCasing = CharacterCasing.Normal
        txtCariUser.Depth = 0
        txtCariUser.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtCariUser.HideSelection = True
        txtCariUser.Hint = "Cari Pelanggan"
        txtCariUser.LeadingIcon = Nothing
        txtCariUser.Location = New Point(407, 71)
        txtCariUser.Margin = New Padding(2)
        txtCariUser.MaxLength = 32767
        txtCariUser.MouseState = MaterialSkin.MouseState.OUT
        txtCariUser.Name = "txtCariUser"
        txtCariUser.PasswordChar = ChrW(0)
        txtCariUser.PrefixSuffixText = Nothing
        txtCariUser.ReadOnly = False
        txtCariUser.RightToLeft = RightToLeft.No
        txtCariUser.SelectedText = ""
        txtCariUser.SelectionLength = 0
        txtCariUser.SelectionStart = 0
        txtCariUser.ShortcutsEnabled = True
        txtCariUser.Size = New Size(592, 48)
        txtCariUser.TabIndex = 5
        txtCariUser.TabStop = False
        txtCariUser.TextAlign = HorizontalAlignment.Left
        txtCariUser.TrailingIcon = Nothing
        txtCariUser.UseSystemPasswordChar = False
        ' 
        ' FormUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1083, 538)
        Controls.Add(txtCariUser)
        Controls.Add(dgvUser)
        Controls.Add(btnHapus)
        Controls.Add(btnBatal)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(cmbLevelUser)
        Controls.Add(Label4)
        Controls.Add(txtPassword)
        Controls.Add(Label3)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(txtNamaUser)
        Controls.Add(Label1)
        Name = "FormUser"
        Text = "FormUser"
        CType(dgvUser, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNamaUser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbLevelUser As ComboBox
    Friend WithEvents btnSimpan As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnUbah As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnHapus As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnBatal As MaterialSkin.Controls.MaterialButton
    Friend WithEvents dgvUser As DataGridView
    Friend WithEvents txtCariUser As MaterialSkin.Controls.MaterialTextBox2
End Class
