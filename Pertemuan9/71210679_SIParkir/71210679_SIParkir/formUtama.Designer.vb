<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUtama
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
        MenuStrip1 = New MenuStrip()
        SistemToolStripMenuItem = New ToolStripMenuItem()
        ProfilToolStripMenuItem1 = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        LanggananToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem1 = New ToolStripMenuItem()
        TentangToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        labelPlat = New Label()
        lblInputPlat = New Label()
        txtNoPlat = New TextBox()
        lblHarga = New Label()
        lblJmlKendaraan = New Label()
        lblTanggal = New Label()
        lblInformasi = New Label()
        Label4 = New Label()
        dgvKendaraanParkir = New DataGridView()
        ColPlat = New DataGridViewTextBoxColumn()
        ColMasuk = New DataGridViewTextBoxColumn()
        ColKeluar = New DataGridViewTextBoxColumn()
        ColHarga = New DataGridViewTextBoxColumn()
        ColJenis = New DataGridViewTextBoxColumn()
        ColId = New DataGridViewTextBoxColumn()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        DeleteToolStripMenuItem = New ToolStripMenuItem()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Label1 = New Label()
        lblInfoJenis = New Label()
        lblJenis = New Label()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvKendaraanParkir, ComponentModel.ISupportInitialize).BeginInit()
        ContextMenuStrip1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SistemToolStripMenuItem, AdminToolStripMenuItem, BantuanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(952, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SistemToolStripMenuItem
        ' 
        SistemToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProfilToolStripMenuItem1, LogoutToolStripMenuItem})
        SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        SistemToolStripMenuItem.Size = New Size(67, 24)
        SistemToolStripMenuItem.Text = "Sistem"
        ' 
        ' ProfilToolStripMenuItem1
        ' 
        ProfilToolStripMenuItem1.Name = "ProfilToolStripMenuItem1"
        ProfilToolStripMenuItem1.Size = New Size(159, 26)
        ProfilToolStripMenuItem1.Text = "Atur Profil"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(159, 26)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LanggananToolStripMenuItem, LaporanToolStripMenuItem})
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        AdminToolStripMenuItem.Size = New Size(67, 24)
        AdminToolStripMenuItem.Text = "Admin"
        ' 
        ' LanggananToolStripMenuItem
        ' 
        LanggananToolStripMenuItem.Name = "LanggananToolStripMenuItem"
        LanggananToolStripMenuItem.Size = New Size(224, 26)
        LanggananToolStripMenuItem.Text = "Langganan"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(224, 26)
        LaporanToolStripMenuItem.Text = "Laporan"
        ' 
        ' BantuanToolStripMenuItem
        ' 
        BantuanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BantuanToolStripMenuItem1, TentangToolStripMenuItem})
        BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        BantuanToolStripMenuItem.Size = New Size(77, 24)
        BantuanToolStripMenuItem.Text = "Bantuan"
        ' 
        ' BantuanToolStripMenuItem1
        ' 
        BantuanToolStripMenuItem1.Name = "BantuanToolStripMenuItem1"
        BantuanToolStripMenuItem1.Size = New Size(146, 26)
        BantuanToolStripMenuItem1.Text = "Bantuan"
        ' 
        ' TentangToolStripMenuItem
        ' 
        TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        TentangToolStripMenuItem.Size = New Size(146, 26)
        TentangToolStripMenuItem.Text = "Tentang"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(labelPlat)
        Panel1.Location = New Point(12, 39)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(928, 139)
        Panel1.TabIndex = 1
        ' 
        ' labelPlat
        ' 
        labelPlat.AutoSize = True
        labelPlat.Font = New Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelPlat.Location = New Point(263, 21)
        labelPlat.Name = "labelPlat"
        labelPlat.Size = New Size(431, 91)
        labelPlat.TabIndex = 2
        labelPlat.Text = "R 6872 ZH"
        ' 
        ' lblInputPlat
        ' 
        lblInputPlat.AutoSize = True
        lblInputPlat.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblInputPlat.Location = New Point(3, 19)
        lblInputPlat.Name = "lblInputPlat"
        lblInputPlat.Size = New Size(84, 20)
        lblInputPlat.TabIndex = 11
        lblInputPlat.Text = "Input Plat:"
        ' 
        ' txtNoPlat
        ' 
        txtNoPlat.Location = New Point(93, 16)
        txtNoPlat.Margin = New Padding(3, 4, 3, 4)
        txtNoPlat.Name = "txtNoPlat"
        txtNoPlat.Size = New Size(143, 27)
        txtNoPlat.TabIndex = 13
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHarga.Location = New Point(8, 12)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(83, 36)
        lblHarga.TabIndex = 35
        lblHarga.Text = "Rp 5"
        ' 
        ' lblJmlKendaraan
        ' 
        lblJmlKendaraan.AutoSize = True
        lblJmlKendaraan.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJmlKendaraan.Location = New Point(13, 536)
        lblJmlKendaraan.Name = "lblJmlKendaraan"
        lblJmlKendaraan.Size = New Size(322, 18)
        lblJmlKendaraan.TabIndex = 31
        lblJmlKendaraan.Text = "0 Motor, 0 Mobil, 0 Taksi, 0 Sepeda, 0 Bus/Truk"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTanggal.Location = New Point(13, 506)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(68, 18)
        lblTanggal.TabIndex = 30
        lblTanggal.Text = "Tanggal: "
        ' 
        ' lblInformasi
        ' 
        lblInformasi.AutoSize = True
        lblInformasi.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInformasi.Location = New Point(13, 475)
        lblInformasi.Name = "lblInformasi"
        lblInformasi.Size = New Size(89, 18)
        lblInformasi.TabIndex = 29
        lblInformasi.Text = "Informasi -"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(393, 205)
        Label4.Name = "Label4"
        Label4.Size = New Size(200, 20)
        Label4.TabIndex = 33
        Label4.Text = "Kendaraan sedang parkir:"
        ' 
        ' dgvKendaraanParkir
        ' 
        dgvKendaraanParkir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKendaraanParkir.Columns.AddRange(New DataGridViewColumn() {ColPlat, ColMasuk, ColKeluar, ColHarga, ColJenis, ColId})
        dgvKendaraanParkir.ContextMenuStrip = ContextMenuStrip1
        dgvKendaraanParkir.Location = New Point(397, 250)
        dgvKendaraanParkir.Margin = New Padding(3, 4, 3, 4)
        dgvKendaraanParkir.Name = "dgvKendaraanParkir"
        dgvKendaraanParkir.RowHeadersWidth = 51
        dgvKendaraanParkir.RowTemplate.Height = 24
        dgvKendaraanParkir.Size = New Size(543, 309)
        dgvKendaraanParkir.TabIndex = 34
        ' 
        ' ColPlat
        ' 
        ColPlat.HeaderText = "No Plat"
        ColPlat.MinimumWidth = 6
        ColPlat.Name = "ColPlat"
        ColPlat.Width = 125
        ' 
        ' ColMasuk
        ' 
        ColMasuk.HeaderText = "Masuk"
        ColMasuk.MinimumWidth = 6
        ColMasuk.Name = "ColMasuk"
        ColMasuk.Width = 125
        ' 
        ' ColKeluar
        ' 
        ColKeluar.HeaderText = "Keluar"
        ColKeluar.MinimumWidth = 6
        ColKeluar.Name = "ColKeluar"
        ColKeluar.Width = 125
        ' 
        ' ColHarga
        ' 
        ColHarga.HeaderText = "Harga"
        ColHarga.MinimumWidth = 6
        ColHarga.Name = "ColHarga"
        ColHarga.Width = 125
        ' 
        ' ColJenis
        ' 
        ColJenis.HeaderText = "Jenis"
        ColJenis.MinimumWidth = 6
        ColJenis.Name = "ColJenis"
        ColJenis.Width = 125
        ' 
        ' ColId
        ' 
        ColId.HeaderText = "id"
        ColId.MinimumWidth = 6
        ColId.Name = "ColId"
        ColId.ReadOnly = True
        ColId.Width = 125
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {DeleteToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(121, 28)
        ' 
        ' DeleteToolStripMenuItem
        ' 
        DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        DeleteToolStripMenuItem.Size = New Size(120, 24)
        DeleteToolStripMenuItem.Text = "delete"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(lblHarga)
        Panel2.Location = New Point(12, 205)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(363, 72)
        Panel2.TabIndex = 36
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(lblInfoJenis)
        Panel3.Controls.Add(lblJenis)
        Panel3.Controls.Add(lblInputPlat)
        Panel3.Controls.Add(txtNoPlat)
        Panel3.Location = New Point(12, 296)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(363, 150)
        Panel3.TabIndex = 37
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(4, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(227, 20)
        Label1.TabIndex = 40
        Label1.Text = "Tekan Enter untuk Masuk / Keluar"
        ' 
        ' lblInfoJenis
        ' 
        lblInfoJenis.AutoSize = True
        lblInfoJenis.Location = New Point(243, 16)
        lblInfoJenis.Name = "lblInfoJenis"
        lblInfoJenis.Size = New Size(0, 20)
        lblInfoJenis.TabIndex = 39
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(3, 66)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(387, 20)
        lblJenis.TabIndex = 38
        lblJenis.Text = "F1 - Motor, F2 - Mobil, F3 -Taksi, F4 - Sepeda, F5 -Bis/Truk" & vbCrLf
        ' 
        ' formUtama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(952, 605)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(dgvKendaraanParkir)
        Controls.Add(Label4)
        Controls.Add(lblJmlKendaraan)
        Controls.Add(lblTanggal)
        Controls.Add(lblInformasi)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        KeyPreview = True
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "formUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Parkir System v.1.0"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvKendaraanParkir, ComponentModel.ISupportInitialize).EndInit()
        ContextMenuStrip1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfilToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LanggananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblInputPlat As Label
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents lblJmlKendaraan As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblInformasi As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvKendaraanParkir As DataGridView
    Friend WithEvents labelPlat As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblJenis As Label
    Friend WithEvents ColPlat As DataGridViewTextBoxColumn
    Friend WithEvents ColMasuk As DataGridViewTextBoxColumn
    Friend WithEvents ColKeluar As DataGridViewTextBoxColumn
    Friend WithEvents ColHarga As DataGridViewTextBoxColumn
    Friend WithEvents ColJenis As DataGridViewTextBoxColumn
    Friend WithEvents ColId As DataGridViewTextBoxColumn
    Friend WithEvents lblInfoJenis As Label
    Friend WithEvents Label1 As Label
End Class
