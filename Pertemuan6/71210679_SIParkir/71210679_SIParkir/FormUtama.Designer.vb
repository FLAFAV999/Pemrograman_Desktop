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
        MenuStrip1 = New MenuStrip()
        mnuSistem = New ToolStripMenuItem()
        mnuAturProfil = New ToolStripMenuItem()
        mnuLogout = New ToolStripMenuItem()
        mnuAdmin = New ToolStripMenuItem()
        mnuLangganan = New ToolStripMenuItem()
        mnuLaporan = New ToolStripMenuItem()
        mnuBantuan = New ToolStripMenuItem()
        mnuBantuanMenu = New ToolStripMenuItem()
        mnuTentang = New ToolStripMenuItem()
        lblNomorPlat = New Label()
        lblJenis = New Label()
        lblInformasi = New Label()
        lblBiayaTitle = New Label()
        txtPlat = New TextBox()
        cmbJenis = New ComboBox()
        btnMasuk = New Button()
        btnKeluar = New Button()
        panelLine = New Panel()
        lblTanggal = New Label()
        lblJam = New Label()
        lblKeteranganJenis = New Label()
        lblParkir = New Label()
        dgvParkir = New DataGridView()
        txtDisplayPlat = New TextBox()
        txtBiayaParkir = New TextBox()
        MenuStrip1.SuspendLayout()
        CType(dgvParkir, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuSistem, mnuAdmin, mnuBantuan})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuSistem
        ' 
        mnuSistem.DropDownItems.AddRange(New ToolStripItem() {mnuAturProfil, mnuLogout})
        mnuSistem.Name = "mnuSistem"
        mnuSistem.Size = New Size(81, 29)
        mnuSistem.Text = "Sistem"
        ' 
        ' mnuAturProfil
        ' 
        mnuAturProfil.Name = "mnuAturProfil"
        mnuAturProfil.Size = New Size(270, 34)
        mnuAturProfil.Text = "Atur Profil"
        ' 
        ' mnuLogout
        ' 
        mnuLogout.Name = "mnuLogout"
        mnuLogout.Size = New Size(194, 34)
        mnuLogout.Text = "Logout"
        ' 
        ' mnuAdmin
        ' 
        mnuAdmin.DropDownItems.AddRange(New ToolStripItem() {mnuLangganan, mnuLaporan})
        mnuAdmin.Name = "mnuAdmin"
        mnuAdmin.Size = New Size(81, 29)
        mnuAdmin.Text = "Admin"
        ' 
        ' mnuLangganan
        ' 
        mnuLangganan.Name = "mnuLangganan"
        mnuLangganan.Size = New Size(201, 34)
        mnuLangganan.Text = "Langganan"
        ' 
        ' mnuLaporan
        ' 
        mnuLaporan.Name = "mnuLaporan"
        mnuLaporan.Size = New Size(201, 34)
        mnuLaporan.Text = "Laporan"
        ' 
        ' mnuBantuan
        ' 
        mnuBantuan.DropDownItems.AddRange(New ToolStripItem() {mnuBantuanMenu, mnuTentang})
        mnuBantuan.Name = "mnuBantuan"
        mnuBantuan.Size = New Size(92, 29)
        mnuBantuan.Text = "Bantuan"
        ' 
        ' mnuBantuanMenu
        ' 
        mnuBantuanMenu.Name = "mnuBantuanMenu"
        mnuBantuanMenu.Size = New Size(178, 34)
        mnuBantuanMenu.Text = "Bantuan"
        ' 
        ' mnuTentang
        ' 
        mnuTentang.Name = "mnuTentang"
        mnuTentang.Size = New Size(178, 34)
        mnuTentang.Text = "Tentang"
        ' 
        ' lblNomorPlat
        ' 
        lblNomorPlat.AutoSize = True
        lblNomorPlat.Location = New Point(49, 158)
        lblNomorPlat.Name = "lblNomorPlat"
        lblNomorPlat.Size = New Size(103, 25)
        lblNomorPlat.TabIndex = 0
        lblNomorPlat.Text = "Nomor Plat"
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(49, 199)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(49, 25)
        lblJenis.TabIndex = 2
        lblJenis.Text = "Jenis"
        ' 
        ' lblInformasi
        ' 
        lblInformasi.AutoSize = True
        lblInformasi.Location = New Point(49, 390)
        lblInformasi.Name = "lblInformasi"
        lblInformasi.Size = New Size(87, 25)
        lblInformasi.TabIndex = 3
        lblInformasi.Text = "Informasi"
        ' 
        ' lblBiayaTitle
        ' 
        lblBiayaTitle.AutoSize = True
        lblBiayaTitle.Location = New Point(49, 308)
        lblBiayaTitle.Name = "lblBiayaTitle"
        lblBiayaTitle.Size = New Size(101, 25)
        lblBiayaTitle.TabIndex = 4
        lblBiayaTitle.Text = "Biaya Parkir"
        ' 
        ' txtPlat
        ' 
        txtPlat.Location = New Point(158, 155)
        txtPlat.Name = "txtPlat"
        txtPlat.Size = New Size(292, 31)
        txtPlat.TabIndex = 5
        ' 
        ' cmbJenis
        ' 
        cmbJenis.FormattingEnabled = True
        cmbJenis.Items.AddRange(New Object() {"Motor", "Mobil", "Taksi", "Sepeda", "Bus/Truk"})
        cmbJenis.Location = New Point(158, 199)
        cmbJenis.Name = "cmbJenis"
        cmbJenis.Size = New Size(98, 33)
        cmbJenis.TabIndex = 6
        cmbJenis.Text = "option 1"
        ' 
        ' btnMasuk
        ' 
        btnMasuk.Location = New Point(158, 246)
        btnMasuk.Name = "btnMasuk"
        btnMasuk.Size = New Size(98, 34)
        btnMasuk.TabIndex = 7
        btnMasuk.Text = "Masuk"
        btnMasuk.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(262, 246)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(98, 34)
        btnKeluar.TabIndex = 8
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' panelLine
        ' 
        panelLine.BackColor = SystemColors.ControlDarkDark
        panelLine.Location = New Point(49, 366)
        panelLine.Name = "panelLine"
        panelLine.Size = New Size(310, 5)
        panelLine.TabIndex = 0
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(49, 434)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(176, 25)
        lblTanggal.TabIndex = 9
        lblTanggal.Text = "Tanggal: 12-34-5678"
        ' 
        ' lblJam
        ' 
        lblJam.AutoSize = True
        lblJam.Location = New Point(262, 434)
        lblJam.Name = "lblJam"
        lblJam.Size = New Size(120, 25)
        lblJam.TabIndex = 10
        lblJam.Text = "Jam: 00:00:00"
        ' 
        ' lblKeteranganJenis
        ' 
        lblKeteranganJenis.AutoSize = True
        lblKeteranganJenis.Location = New Point(49, 477)
        lblKeteranganJenis.Name = "lblKeteranganJenis"
        lblKeteranganJenis.Size = New Size(354, 25)
        lblKeteranganJenis.TabIndex = 11
        lblKeteranganJenis.Text = "o Motor, o Mobil, o Taksi, o Spd, o Bis/Truk"
        ' 
        ' lblParkir
        ' 
        lblParkir.AutoSize = True
        lblParkir.Location = New Point(481, 158)
        lblParkir.Name = "lblParkir"
        lblParkir.Size = New Size(212, 25)
        lblParkir.TabIndex = 12
        lblParkir.Text = "Kendaraan sedang parkir:"
        ' 
        ' dgvParkir
        ' 
        dgvParkir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvParkir.Location = New Point(481, 186)
        dgvParkir.Name = "dgvParkir"
        dgvParkir.RowHeadersWidth = 62
        dgvParkir.Size = New Size(289, 273)
        dgvParkir.TabIndex = 13
        ' 
        ' txtDisplayPlat
        ' 
        txtDisplayPlat.Font = New Font("Segoe UI", 25F)
        txtDisplayPlat.Location = New Point(49, 53)
        txtDisplayPlat.Multiline = True
        txtDisplayPlat.Name = "txtDisplayPlat"
        txtDisplayPlat.ReadOnly = True
        txtDisplayPlat.Size = New Size(721, 73)
        txtDisplayPlat.TabIndex = 14
        txtDisplayPlat.Text = "R 6872 ZH"
        txtDisplayPlat.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtBiayaParkir
        ' 
        txtBiayaParkir.Font = New Font("Segoe UI", 10F)
        txtBiayaParkir.Location = New Point(156, 305)
        txtBiayaParkir.Multiline = True
        txtBiayaParkir.Name = "txtBiayaParkir"
        txtBiayaParkir.ReadOnly = True
        txtBiayaParkir.Size = New Size(200, 40)
        txtBiayaParkir.TabIndex = 15
        txtBiayaParkir.Text = "Rp 50.000"
        txtBiayaParkir.TextAlign = HorizontalAlignment.Center
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 544)
        Controls.Add(txtBiayaParkir)
        Controls.Add(txtDisplayPlat)
        Controls.Add(dgvParkir)
        Controls.Add(lblParkir)
        Controls.Add(lblKeteranganJenis)
        Controls.Add(lblJam)
        Controls.Add(lblTanggal)
        Controls.Add(panelLine)
        Controls.Add(btnKeluar)
        Controls.Add(btnMasuk)
        Controls.Add(cmbJenis)
        Controls.Add(txtPlat)
        Controls.Add(lblBiayaTitle)
        Controls.Add(lblInformasi)
        Controls.Add(lblJenis)
        Controls.Add(lblNomorPlat)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FormUtama"
        Text = "SIParkir - Form Utama"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(dgvParkir, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuSistem As ToolStripMenuItem
    Friend WithEvents mnuAturProfil As ToolStripMenuItem
    Friend WithEvents mnuLogout As ToolStripMenuItem
    Friend WithEvents mnuAdmin As ToolStripMenuItem
    Friend WithEvents mnuLangganan As ToolStripMenuItem
    Friend WithEvents mnuLaporan As ToolStripMenuItem
    Friend WithEvents mnuBantuan As ToolStripMenuItem
    Friend WithEvents mnuBantuanMenu As ToolStripMenuItem
    Friend WithEvents mnuTentang As ToolStripMenuItem
    Friend WithEvents lblNomorPlat As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblInformasi As Label
    Friend WithEvents lblBiayaTitle As Label
    Friend WithEvents txtPlat As TextBox
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents btnMasuk As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents panelLine As Panel
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblJam As Label
    Friend WithEvents lblKeteranganJenis As Label
    Friend WithEvents lblParkir As Label
    Friend WithEvents dgvParkir As DataGridView
    Friend WithEvents txtDisplayPlat As TextBox
    Friend WithEvents txtBiayaParkir As TextBox
End Class
