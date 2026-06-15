<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formpelanggan
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
        lblPelanggan = New Label()
        GroupBox1 = New GroupBox()
        dgvPelanggan = New DataGridView()
        btnReset = New MaterialSkin.Controls.MaterialButton()
        btnHapus = New MaterialSkin.Controls.MaterialButton()
        btnUbah = New MaterialSkin.Controls.MaterialButton()
        btnSimpan = New MaterialSkin.Controls.MaterialButton()
        txtAlamat = New MaterialSkin.Controls.MaterialMultiLineTextBox2()
        txtNoHP = New MaterialSkin.Controls.MaterialTextBox2()
        txtCariPelanggan = New MaterialSkin.Controls.MaterialTextBox2()
        txtNama = New MaterialSkin.Controls.MaterialTextBox2()
        GroupBox1.SuspendLayout()
        CType(dgvPelanggan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblPelanggan
        ' 
        lblPelanggan.AutoSize = True
        lblPelanggan.FlatStyle = FlatStyle.Flat
        lblPelanggan.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPelanggan.Location = New Point(26, 27)
        lblPelanggan.Margin = New Padding(2, 0, 2, 0)
        lblPelanggan.Name = "lblPelanggan"
        lblPelanggan.Size = New Size(215, 20)
        lblPelanggan.TabIndex = 1
        lblPelanggan.Text = "Data Pelanggan Laundry"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvPelanggan)
        GroupBox1.Controls.Add(btnReset)
        GroupBox1.Controls.Add(btnHapus)
        GroupBox1.Controls.Add(btnUbah)
        GroupBox1.Controls.Add(btnSimpan)
        GroupBox1.Controls.Add(txtAlamat)
        GroupBox1.Controls.Add(txtNoHP)
        GroupBox1.Controls.Add(txtCariPelanggan)
        GroupBox1.Controls.Add(txtNama)
        GroupBox1.Location = New Point(59, 61)
        GroupBox1.Margin = New Padding(2, 2, 2, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2, 2, 2, 2)
        GroupBox1.Size = New Size(838, 360)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = " "
        ' 
        ' dgvPelanggan
        ' 
        dgvPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPelanggan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPelanggan.Location = New Point(353, 91)
        dgvPelanggan.Margin = New Padding(2, 2, 2, 2)
        dgvPelanggan.MultiSelect = False
        dgvPelanggan.Name = "dgvPelanggan"
        dgvPelanggan.ReadOnly = True
        dgvPelanggan.RowHeadersWidth = 62
        dgvPelanggan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPelanggan.Size = New Size(437, 180)
        dgvPelanggan.TabIndex = 3
        ' 
        ' btnReset
        ' 
        btnReset.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnReset.Depth = 0
        btnReset.HighEmphasis = True
        btnReset.Icon = Nothing
        btnReset.Location = New Point(275, 242)
        btnReset.Margin = New Padding(3, 5, 3, 5)
        btnReset.MouseState = MaterialSkin.MouseState.HOVER
        btnReset.Name = "btnReset"
        btnReset.NoAccentTextColor = Color.Empty
        btnReset.Size = New Size(65, 36)
        btnReset.TabIndex = 2
        btnReset.Text = "RESET"
        btnReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnReset.UseAccentColor = False
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnHapus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnHapus.Depth = 0
        btnHapus.HighEmphasis = True
        btnHapus.Icon = Nothing
        btnHapus.Location = New Point(189, 242)
        btnHapus.Margin = New Padding(3, 5, 3, 5)
        btnHapus.MouseState = MaterialSkin.MouseState.HOVER
        btnHapus.Name = "btnHapus"
        btnHapus.NoAccentTextColor = Color.Empty
        btnHapus.Size = New Size(69, 36)
        btnHapus.TabIndex = 2
        btnHapus.Text = "HAPUS"
        btnHapus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnHapus.UseAccentColor = False
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnUbah.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnUbah.Depth = 0
        btnUbah.HighEmphasis = True
        btnUbah.Icon = Nothing
        btnUbah.Location = New Point(108, 242)
        btnUbah.Margin = New Padding(3, 5, 3, 5)
        btnUbah.MouseState = MaterialSkin.MouseState.HOVER
        btnUbah.Name = "btnUbah"
        btnUbah.NoAccentTextColor = Color.Empty
        btnUbah.Size = New Size(64, 36)
        btnUbah.TabIndex = 2
        btnUbah.Text = "UBAH"
        btnUbah.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnUbah.UseAccentColor = False
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSimpan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnSimpan.Depth = 0
        btnSimpan.HighEmphasis = True
        btnSimpan.Icon = Nothing
        btnSimpan.Location = New Point(27, 242)
        btnSimpan.Margin = New Padding(3, 5, 3, 5)
        btnSimpan.MouseState = MaterialSkin.MouseState.HOVER
        btnSimpan.Name = "btnSimpan"
        btnSimpan.NoAccentTextColor = Color.Empty
        btnSimpan.Size = New Size(77, 36)
        btnSimpan.TabIndex = 2
        btnSimpan.Text = "SIMPAN"
        btnSimpan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnSimpan.UseAccentColor = False
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' txtAlamat
        ' 
        txtAlamat.AnimateReadOnly = False
        txtAlamat.BackgroundImageLayout = ImageLayout.None
        txtAlamat.CharacterCasing = CharacterCasing.Normal
        txtAlamat.Depth = 0
        txtAlamat.HideSelection = True
        txtAlamat.Hint = " Alamat"
        txtAlamat.Location = New Point(27, 157)
        txtAlamat.Margin = New Padding(2, 2, 2, 2)
        txtAlamat.MaxLength = 32767
        txtAlamat.MouseState = MaterialSkin.MouseState.OUT
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PasswordChar = ChrW(0)
        txtAlamat.ReadOnly = False
        txtAlamat.ScrollBars = ScrollBars.None
        txtAlamat.SelectedText = ""
        txtAlamat.SelectionLength = 0
        txtAlamat.SelectionStart = 0
        txtAlamat.ShortcutsEnabled = True
        txtAlamat.Size = New Size(300, 64)
        txtAlamat.TabIndex = 1
        txtAlamat.TabStop = False
        txtAlamat.TextAlign = HorizontalAlignment.Left
        txtAlamat.UseSystemPasswordChar = False
        ' 
        ' txtNoHP
        ' 
        txtNoHP.AnimateReadOnly = False
        txtNoHP.BackgroundImageLayout = ImageLayout.None
        txtNoHP.CharacterCasing = CharacterCasing.Normal
        txtNoHP.Depth = 0
        txtNoHP.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtNoHP.HideSelection = True
        txtNoHP.Hint = "No HP"
        txtNoHP.LeadingIcon = Nothing
        txtNoHP.Location = New Point(27, 93)
        txtNoHP.Margin = New Padding(2, 2, 2, 2)
        txtNoHP.MaxLength = 32767
        txtNoHP.MouseState = MaterialSkin.MouseState.OUT
        txtNoHP.Name = "txtNoHP"
        txtNoHP.PasswordChar = ChrW(0)
        txtNoHP.PrefixSuffixText = Nothing
        txtNoHP.ReadOnly = False
        txtNoHP.RightToLeft = RightToLeft.No
        txtNoHP.SelectedText = ""
        txtNoHP.SelectionLength = 0
        txtNoHP.SelectionStart = 0
        txtNoHP.ShortcutsEnabled = True
        txtNoHP.Size = New Size(300, 48)
        txtNoHP.TabIndex = 0
        txtNoHP.TabStop = False
        txtNoHP.TextAlign = HorizontalAlignment.Left
        txtNoHP.TrailingIcon = Nothing
        txtNoHP.UseSystemPasswordChar = False
        ' 
        ' txtCariPelanggan
        ' 
        txtCariPelanggan.AnimateReadOnly = False
        txtCariPelanggan.BackgroundImageLayout = ImageLayout.None
        txtCariPelanggan.CharacterCasing = CharacterCasing.Normal
        txtCariPelanggan.Depth = 0
        txtCariPelanggan.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtCariPelanggan.HideSelection = True
        txtCariPelanggan.Hint = "Cari Pelanggan"
        txtCariPelanggan.LeadingIcon = Nothing
        txtCariPelanggan.Location = New Point(353, 24)
        txtCariPelanggan.Margin = New Padding(2, 2, 2, 2)
        txtCariPelanggan.MaxLength = 32767
        txtCariPelanggan.MouseState = MaterialSkin.MouseState.OUT
        txtCariPelanggan.Name = "txtCariPelanggan"
        txtCariPelanggan.PasswordChar = ChrW(0)
        txtCariPelanggan.PrefixSuffixText = Nothing
        txtCariPelanggan.ReadOnly = False
        txtCariPelanggan.RightToLeft = RightToLeft.No
        txtCariPelanggan.SelectedText = ""
        txtCariPelanggan.SelectionLength = 0
        txtCariPelanggan.SelectionStart = 0
        txtCariPelanggan.ShortcutsEnabled = True
        txtCariPelanggan.Size = New Size(437, 48)
        txtCariPelanggan.TabIndex = 0
        txtCariPelanggan.TabStop = False
        txtCariPelanggan.TextAlign = HorizontalAlignment.Left
        txtCariPelanggan.TrailingIcon = Nothing
        txtCariPelanggan.UseSystemPasswordChar = False
        ' 
        ' txtNama
        ' 
        txtNama.AnimateReadOnly = False
        txtNama.BackgroundImageLayout = ImageLayout.None
        txtNama.CharacterCasing = CharacterCasing.Normal
        txtNama.Depth = 0
        txtNama.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtNama.HideSelection = True
        txtNama.Hint = "Nama Pelanggan"
        txtNama.LeadingIcon = Nothing
        txtNama.Location = New Point(27, 24)
        txtNama.Margin = New Padding(2, 2, 2, 2)
        txtNama.MaxLength = 32767
        txtNama.MouseState = MaterialSkin.MouseState.OUT
        txtNama.Name = "txtNama"
        txtNama.PasswordChar = ChrW(0)
        txtNama.PrefixSuffixText = Nothing
        txtNama.ReadOnly = False
        txtNama.RightToLeft = RightToLeft.No
        txtNama.SelectedText = ""
        txtNama.SelectionLength = 0
        txtNama.SelectionStart = 0
        txtNama.ShortcutsEnabled = True
        txtNama.Size = New Size(300, 48)
        txtNama.TabIndex = 0
        txtNama.TabStop = False
        txtNama.TextAlign = HorizontalAlignment.Left
        txtNama.TrailingIcon = Nothing
        txtNama.UseSystemPasswordChar = False
        ' 
        ' Formpelanggan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(946, 459)
        Controls.Add(GroupBox1)
        Controls.Add(lblPelanggan)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Formpelanggan"
        StartPosition = FormStartPosition.Manual
        Text = "Formpelanggan"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvPelanggan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPelanggan As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNoHP As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtNama As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btnReset As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnHapus As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnUbah As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSimpan As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtAlamat As MaterialSkin.Controls.MaterialMultiLineTextBox2
    Friend WithEvents dgvPelanggan As DataGridView
    Friend WithEvents txtCariPelanggan As MaterialSkin.Controls.MaterialTextBox2
End Class
