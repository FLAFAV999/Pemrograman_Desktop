<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLangganan
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
        lblNama = New Label()
        lblPlat = New Label()
        lblJenis = New Label()
        lblTarif = New Label()
        lblID = New Label()
        lblBerlaku = New Label()
        lblDaftar = New Label()
        txtNama = New TextBox()
        txtTarif = New TextBox()
        txtPlat = New TextBox()
        cmbJenis = New ComboBox()
        dtpExpired = New DateTimePicker()
        btnTambah = New Button()
        btnEdit = New Button()
        btnHapus = New Button()
        dgvLangganan = New DataGridView()
        btnTutup = New Button()
        CType(dgvLangganan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(43, 41)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(146, 25)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama Pelanggan"
        ' 
        ' lblPlat
        ' 
        lblPlat.AutoSize = True
        lblPlat.Location = New Point(43, 86)
        lblPlat.Name = "lblPlat"
        lblPlat.Size = New Size(103, 25)
        lblPlat.TabIndex = 1
        lblPlat.Text = "Nomor Plat"
        ' 
        ' lblJenis
        ' 
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(392, 89)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(49, 25)
        lblJenis.TabIndex = 2
        lblJenis.Text = "Jenis"
        ' 
        ' lblTarif
        ' 
        lblTarif.AutoSize = True
        lblTarif.Location = New Point(43, 135)
        lblTarif.Name = "lblTarif"
        lblTarif.Size = New Size(136, 25)
        lblTarif.TabIndex = 3
        lblTarif.Text = "Tarif Langganan"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(441, 41)
        lblID.Name = "lblID"
        lblID.Size = New Size(121, 25)
        lblID.TabIndex = 4
        lblID.Text = "ID Pelanggan:"
        ' 
        ' lblBerlaku
        ' 
        lblBerlaku.AutoSize = True
        lblBerlaku.Location = New Point(43, 182)
        lblBerlaku.Name = "lblBerlaku"
        lblBerlaku.Size = New Size(132, 25)
        lblBerlaku.TabIndex = 5
        lblBerlaku.Text = "Berlaku Hingga"
        ' 
        ' lblDaftar
        ' 
        lblDaftar.AutoSize = True
        lblDaftar.Location = New Point(43, 237)
        lblDaftar.Name = "lblDaftar"
        lblDaftar.Size = New Size(260, 25)
        lblDaftar.TabIndex = 6
        lblDaftar.Text = "Kendaraan terdaftar langganan:"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(194, 38)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(229, 31)
        txtNama.TabIndex = 7
        ' 
        ' txtTarif
        ' 
        txtTarif.Location = New Point(185, 129)
        txtTarif.Name = "txtTarif"
        txtTarif.Size = New Size(181, 31)
        txtTarif.TabIndex = 8
        ' 
        ' txtPlat
        ' 
        txtPlat.Location = New Point(185, 83)
        txtPlat.Name = "txtPlat"
        txtPlat.Size = New Size(181, 31)
        txtPlat.TabIndex = 9
        ' 
        ' cmbJenis
        ' 
        cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList
        cmbJenis.FormattingEnabled = True
        cmbJenis.Location = New Point(456, 86)
        cmbJenis.Name = "cmbJenis"
        cmbJenis.Size = New Size(131, 33)
        cmbJenis.TabIndex = 10
        ' 
        ' dtpExpired
        ' 
        dtpExpired.Format = DateTimePickerFormat.Short
        dtpExpired.Location = New Point(181, 182)
        dtpExpired.Name = "dtpExpired"
        dtpExpired.Size = New Size(137, 31)
        dtpExpired.TabIndex = 11
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(413, 182)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 12
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(528, 182)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(105, 34)
        btnEdit.TabIndex = 13
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(635, 182)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(101, 34)
        btnHapus.TabIndex = 14
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' dgvLangganan
        ' 
        dgvLangganan.AllowUserToAddRows = False
        dgvLangganan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLangganan.Location = New Point(43, 280)
        dgvLangganan.Name = "dgvLangganan"
        dgvLangganan.ReadOnly = True
        dgvLangganan.RowHeadersWidth = 62
        dgvLangganan.Size = New Size(693, 201)
        dgvLangganan.TabIndex = 15
        ' 
        ' btnTutup
        ' 
        btnTutup.Location = New Point(624, 489)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(112, 34)
        btnTutup.TabIndex = 16
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' FormLangganan
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(778, 550)
        Controls.Add(btnTutup)
        Controls.Add(dgvLangganan)
        Controls.Add(btnHapus)
        Controls.Add(btnEdit)
        Controls.Add(btnTambah)
        Controls.Add(dtpExpired)
        Controls.Add(cmbJenis)
        Controls.Add(txtPlat)
        Controls.Add(txtTarif)
        Controls.Add(txtNama)
        Controls.Add(lblDaftar)
        Controls.Add(lblBerlaku)
        Controls.Add(lblID)
        Controls.Add(lblTarif)
        Controls.Add(lblJenis)
        Controls.Add(lblPlat)
        Controls.Add(lblNama)
        Name = "FormLangganan"
        Text = "SIParkir - Langganan"
        CType(dgvLangganan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents lblPlat As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblTarif As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblBerlaku As Label
    Friend WithEvents lblDaftar As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtTarif As TextBox
    Friend WithEvents txtPlat As TextBox
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents dtpExpired As DateTimePicker
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents dgvLangganan As DataGridView
    Friend WithEvents btnTutup As Button
End Class
