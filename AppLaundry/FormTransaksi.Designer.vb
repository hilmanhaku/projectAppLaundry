<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransaksi))
        txtKode = New MaterialSkin.Controls.MaterialTextBox2()
        Label1 = New Label()
        txtHargaPer = New MaterialSkin.Controls.MaterialTextBox2()
        txtTotalBayar = New MaterialSkin.Controls.MaterialTextBox2()
        txtBeratCucian = New MaterialSkin.Controls.MaterialTextBox2()
        txtCari = New MaterialSkin.Controls.MaterialTextBox2()
        dtTanggal = New DateTimePicker()
        lblTanggalTransaksi = New Label()
        dgvTransaksi = New DataGridView()
        cbPelanggan = New MaterialSkin.Controls.MaterialComboBox()
        cbStatus = New MaterialSkin.Controls.MaterialComboBox()
        btnSimpan = New MaterialSkin.Controls.MaterialButton()
        btnReset = New MaterialSkin.Controls.MaterialButton()
        GroupBox1 = New GroupBox()
        lblTotalPendapatan = New Label()
        btnCetak = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        CType(dgvTransaksi, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtKode
        ' 
        txtKode.AnimateReadOnly = False
        txtKode.BackgroundImageLayout = ImageLayout.None
        txtKode.CharacterCasing = CharacterCasing.Normal
        txtKode.Depth = 0
        txtKode.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtKode.HideSelection = True
        txtKode.Hint = "Kode Transaksi"
        txtKode.LeadingIcon = Nothing
        txtKode.Location = New Point(612, 92)
        txtKode.Margin = New Padding(2)
        txtKode.MaxLength = 32767
        txtKode.MouseState = MaterialSkin.MouseState.OUT
        txtKode.Name = "txtKode"
        txtKode.PasswordChar = ChrW(0)
        txtKode.PrefixSuffixText = Nothing
        txtKode.ReadOnly = True
        txtKode.RightToLeft = RightToLeft.No
        txtKode.SelectedText = ""
        txtKode.SelectionLength = 0
        txtKode.SelectionStart = 0
        txtKode.ShortcutsEnabled = True
        txtKode.Size = New Size(118, 48)
        txtKode.TabIndex = 0
        txtKode.TabStop = False
        txtKode.TextAlign = HorizontalAlignment.Left
        txtKode.TrailingIcon = Nothing
        txtKode.UseSystemPasswordChar = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(26, 27)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 24)
        Label1.TabIndex = 1
        Label1.Text = "Transaksi"
        ' 
        ' txtHargaPer
        ' 
        txtHargaPer.AnimateReadOnly = False
        txtHargaPer.BackgroundImageLayout = ImageLayout.None
        txtHargaPer.CharacterCasing = CharacterCasing.Normal
        txtHargaPer.Depth = 0
        txtHargaPer.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtHargaPer.HideSelection = True
        txtHargaPer.Hint = "Harga per Kg"
        txtHargaPer.LeadingIcon = Nothing
        txtHargaPer.Location = New Point(26, 153)
        txtHargaPer.Margin = New Padding(2)
        txtHargaPer.MaxLength = 32767
        txtHargaPer.MouseState = MaterialSkin.MouseState.OUT
        txtHargaPer.Name = "txtHargaPer"
        txtHargaPer.PasswordChar = ChrW(0)
        txtHargaPer.PrefixSuffixText = Nothing
        txtHargaPer.ReadOnly = False
        txtHargaPer.RightToLeft = RightToLeft.No
        txtHargaPer.SelectedText = ""
        txtHargaPer.SelectionLength = 0
        txtHargaPer.SelectionStart = 0
        txtHargaPer.ShortcutsEnabled = True
        txtHargaPer.Size = New Size(151, 48)
        txtHargaPer.TabIndex = 0
        txtHargaPer.TabStop = False
        txtHargaPer.TextAlign = HorizontalAlignment.Left
        txtHargaPer.TrailingIcon = Nothing
        txtHargaPer.UseSystemPasswordChar = False
        ' 
        ' txtTotalBayar
        ' 
        txtTotalBayar.AnimateReadOnly = False
        txtTotalBayar.BackgroundImageLayout = ImageLayout.None
        txtTotalBayar.CharacterCasing = CharacterCasing.Normal
        txtTotalBayar.Depth = 0
        txtTotalBayar.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtTotalBayar.HideSelection = True
        txtTotalBayar.Hint = "Total Bayar"
        txtTotalBayar.LeadingIcon = Nothing
        txtTotalBayar.Location = New Point(26, 268)
        txtTotalBayar.Margin = New Padding(2)
        txtTotalBayar.MaxLength = 32767
        txtTotalBayar.MouseState = MaterialSkin.MouseState.OUT
        txtTotalBayar.Name = "txtTotalBayar"
        txtTotalBayar.PasswordChar = ChrW(0)
        txtTotalBayar.PrefixSuffixText = Nothing
        txtTotalBayar.ReadOnly = True
        txtTotalBayar.RightToLeft = RightToLeft.No
        txtTotalBayar.SelectedText = ""
        txtTotalBayar.SelectionLength = 0
        txtTotalBayar.SelectionStart = 0
        txtTotalBayar.ShortcutsEnabled = True
        txtTotalBayar.Size = New Size(151, 48)
        txtTotalBayar.TabIndex = 0
        txtTotalBayar.TabStop = False
        txtTotalBayar.TextAlign = HorizontalAlignment.Left
        txtTotalBayar.TrailingIcon = Nothing
        txtTotalBayar.UseSystemPasswordChar = False
        ' 
        ' txtBeratCucian
        ' 
        txtBeratCucian.AnimateReadOnly = False
        txtBeratCucian.BackgroundImageLayout = ImageLayout.None
        txtBeratCucian.CharacterCasing = CharacterCasing.Normal
        txtBeratCucian.Depth = 0
        txtBeratCucian.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtBeratCucian.HideSelection = True
        txtBeratCucian.Hint = "Berat Cucian"
        txtBeratCucian.LeadingIcon = Nothing
        txtBeratCucian.Location = New Point(26, 213)
        txtBeratCucian.Margin = New Padding(2)
        txtBeratCucian.MaxLength = 32767
        txtBeratCucian.MouseState = MaterialSkin.MouseState.OUT
        txtBeratCucian.Name = "txtBeratCucian"
        txtBeratCucian.PasswordChar = ChrW(0)
        txtBeratCucian.PrefixSuffixText = Nothing
        txtBeratCucian.ReadOnly = False
        txtBeratCucian.RightToLeft = RightToLeft.No
        txtBeratCucian.SelectedText = ""
        txtBeratCucian.SelectionLength = 0
        txtBeratCucian.SelectionStart = 0
        txtBeratCucian.ShortcutsEnabled = True
        txtBeratCucian.Size = New Size(151, 48)
        txtBeratCucian.TabIndex = 0
        txtBeratCucian.TabStop = False
        txtBeratCucian.TextAlign = HorizontalAlignment.Left
        txtBeratCucian.TrailingIcon = Nothing
        txtBeratCucian.UseSystemPasswordChar = False
        ' 
        ' txtCari
        ' 
        txtCari.AnimateReadOnly = False
        txtCari.BackgroundImageLayout = ImageLayout.None
        txtCari.CharacterCasing = CharacterCasing.Normal
        txtCari.Depth = 0
        txtCari.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtCari.HideSelection = True
        txtCari.Hint = "Cari Transaksi"
        txtCari.LeadingIcon = Nothing
        txtCari.Location = New Point(216, 92)
        txtCari.Margin = New Padding(2)
        txtCari.MaxLength = 32767
        txtCari.MouseState = MaterialSkin.MouseState.OUT
        txtCari.Name = "txtCari"
        txtCari.PasswordChar = ChrW(0)
        txtCari.PrefixSuffixText = Nothing
        txtCari.ReadOnly = False
        txtCari.RightToLeft = RightToLeft.No
        txtCari.SelectedText = ""
        txtCari.SelectionLength = 0
        txtCari.SelectionStart = 0
        txtCari.ShortcutsEnabled = True
        txtCari.Size = New Size(300, 48)
        txtCari.TabIndex = 0
        txtCari.TabStop = False
        txtCari.TextAlign = HorizontalAlignment.Left
        txtCari.TrailingIcon = Nothing
        txtCari.UseSystemPasswordChar = False
        ' 
        ' dtTanggal
        ' 
        dtTanggal.Location = New Point(775, 53)
        dtTanggal.Margin = New Padding(2)
        dtTanggal.Name = "dtTanggal"
        dtTanggal.Size = New Size(241, 27)
        dtTanggal.TabIndex = 2
        ' 
        ' lblTanggalTransaksi
        ' 
        lblTanggalTransaksi.AutoSize = True
        lblTanggalTransaksi.Location = New Point(775, 27)
        lblTanggalTransaksi.Margin = New Padding(2, 0, 2, 0)
        lblTanggalTransaksi.Name = "lblTanggalTransaksi"
        lblTanggalTransaksi.Size = New Size(124, 20)
        lblTanggalTransaksi.TabIndex = 3
        lblTanggalTransaksi.Text = "Tanggal Transaksi"
        ' 
        ' dgvTransaksi
        ' 
        dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransaksi.Location = New Point(216, 153)
        dgvTransaksi.Margin = New Padding(2)
        dgvTransaksi.Name = "dgvTransaksi"
        dgvTransaksi.ReadOnly = True
        dgvTransaksi.RowHeadersWidth = 62
        dgvTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTransaksi.Size = New Size(514, 266)
        dgvTransaksi.TabIndex = 4
        ' 
        ' cbPelanggan
        ' 
        cbPelanggan.AutoResize = False
        cbPelanggan.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        cbPelanggan.Depth = 0
        cbPelanggan.DrawMode = DrawMode.OwnerDrawVariable
        cbPelanggan.DropDownHeight = 174
        cbPelanggan.DropDownStyle = ComboBoxStyle.DropDownList
        cbPelanggan.DropDownWidth = 121
        cbPelanggan.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        cbPelanggan.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        cbPelanggan.FormattingEnabled = True
        cbPelanggan.Hint = "Pilih Pelanggan"
        cbPelanggan.IntegralHeight = False
        cbPelanggan.ItemHeight = 43
        cbPelanggan.Location = New Point(26, 92)
        cbPelanggan.Margin = New Padding(2)
        cbPelanggan.MaxDropDownItems = 4
        cbPelanggan.MouseState = MaterialSkin.MouseState.OUT
        cbPelanggan.Name = "cbPelanggan"
        cbPelanggan.Size = New Size(152, 49)
        cbPelanggan.StartIndex = 0
        cbPelanggan.TabIndex = 5
        ' 
        ' cbStatus
        ' 
        cbStatus.AutoResize = False
        cbStatus.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        cbStatus.Depth = 0
        cbStatus.DrawMode = DrawMode.OwnerDrawVariable
        cbStatus.DropDownHeight = 174
        cbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbStatus.DropDownWidth = 121
        cbStatus.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        cbStatus.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        cbStatus.FormattingEnabled = True
        cbStatus.Hint = "Status"
        cbStatus.IntegralHeight = False
        cbStatus.ItemHeight = 43
        cbStatus.Location = New Point(26, 330)
        cbStatus.Margin = New Padding(2)
        cbStatus.MaxDropDownItems = 4
        cbStatus.MouseState = MaterialSkin.MouseState.OUT
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(152, 49)
        cbStatus.StartIndex = 0
        cbStatus.TabIndex = 5
        ' 
        ' btnSimpan
        ' 
        btnSimpan.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnSimpan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnSimpan.Depth = 0
        btnSimpan.HighEmphasis = True
        btnSimpan.Icon = Nothing
        btnSimpan.Location = New Point(26, 390)
        btnSimpan.Margin = New Padding(3, 5, 3, 5)
        btnSimpan.MouseState = MaterialSkin.MouseState.HOVER
        btnSimpan.Name = "btnSimpan"
        btnSimpan.NoAccentTextColor = Color.Empty
        btnSimpan.Size = New Size(77, 36)
        btnSimpan.TabIndex = 6
        btnSimpan.Text = "SIMPAN"
        btnSimpan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnSimpan.UseAccentColor = False
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnReset.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btnReset.Depth = 0
        btnReset.HighEmphasis = True
        btnReset.Icon = Nothing
        btnReset.Location = New Point(115, 390)
        btnReset.Margin = New Padding(3, 5, 3, 5)
        btnReset.MouseState = MaterialSkin.MouseState.HOVER
        btnReset.Name = "btnReset"
        btnReset.NoAccentTextColor = Color.Empty
        btnReset.Size = New Size(65, 36)
        btnReset.TabIndex = 6
        btnReset.Text = "RESET"
        btnReset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btnReset.UseAccentColor = False
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblTotalPendapatan)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(775, 153)
        GroupBox1.Margin = New Padding(2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2)
        GroupBox1.Size = New Size(240, 266)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Total Pendapatan :"
        ' 
        ' lblTotalPendapatan
        ' 
        lblTotalPendapatan.AutoSize = True
        lblTotalPendapatan.Location = New Point(15, 50)
        lblTotalPendapatan.Margin = New Padding(2, 0, 2, 0)
        lblTotalPendapatan.Name = "lblTotalPendapatan"
        lblTotalPendapatan.Size = New Size(45, 20)
        lblTotalPendapatan.TabIndex = 0
        lblTotalPendapatan.Text = "$$$$"
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(318, 434)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(331, 61)
        btnCetak.TabIndex = 8
        btnCetak.Text = "CETAK NOTA"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' FormTransaksi
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1025, 579)
        Controls.Add(btnCetak)
        Controls.Add(GroupBox1)
        Controls.Add(btnReset)
        Controls.Add(btnSimpan)
        Controls.Add(cbStatus)
        Controls.Add(cbPelanggan)
        Controls.Add(dgvTransaksi)
        Controls.Add(lblTanggalTransaksi)
        Controls.Add(dtTanggal)
        Controls.Add(Label1)
        Controls.Add(txtCari)
        Controls.Add(txtBeratCucian)
        Controls.Add(txtTotalBayar)
        Controls.Add(txtHargaPer)
        Controls.Add(txtKode)
        Margin = New Padding(2)
        Name = "FormTransaksi"
        RightToLeft = RightToLeft.No
        Text = "FormTransaksi"
        CType(dgvTransaksi, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtKode As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHargaPer As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtTotalBayar As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtBeratCucian As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtCari As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents lblTanggalTransaksi As Label
    Friend WithEvents dgvTransaksi As DataGridView
    Friend WithEvents cbPelanggan As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cbStatus As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents btnSimpan As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnReset As MaterialSkin.Controls.MaterialButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTotalPendapatan As Label
    Friend WithEvents btnCetak As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
