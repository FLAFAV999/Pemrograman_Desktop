<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
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
        lblPeriode = New Label()
        lblLaporan = New Label()
        cmbBulan = New ComboBox()
        txtTahun = New TextBox()
        btnTampilkan = New Button()
        panelLaporan = New Panel()
        btnTutup = New Button()
        SuspendLayout()
        ' 
        ' lblPeriode
        ' 
        lblPeriode.AutoSize = True
        lblPeriode.Location = New Point(56, 43)
        lblPeriode.Name = "lblPeriode"
        lblPeriode.Size = New Size(71, 25)
        lblPeriode.TabIndex = 0
        lblPeriode.Text = "Periode"
        ' 
        ' lblLaporan
        ' 
        lblLaporan.AutoSize = True
        lblLaporan.Location = New Point(56, 92)
        lblLaporan.Name = "lblLaporan"
        lblLaporan.Size = New Size(85, 25)
        lblLaporan.TabIndex = 1
        lblLaporan.Text = "Laporan :"
        ' 
        ' cmbBulan
        ' 
        cmbBulan.DropDownStyle = ComboBoxStyle.DropDownList
        cmbBulan.FormattingEnabled = True
        cmbBulan.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        cmbBulan.Location = New Point(133, 40)
        cmbBulan.Name = "cmbBulan"
        cmbBulan.Size = New Size(178, 33)
        cmbBulan.TabIndex = 3
        ' 
        ' txtTahun
        ' 
        txtTahun.Location = New Point(320, 42)
        txtTahun.Name = "txtTahun"
        txtTahun.Size = New Size(96, 31)
        txtTahun.TabIndex = 4
        txtTahun.Text = "Tahun"
        txtTahun.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(435, 40)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(112, 34)
        btnTampilkan.TabIndex = 5
        btnTampilkan.Text = "Tampilkan!"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' panelLaporan
        ' 
        panelLaporan.BorderStyle = BorderStyle.FixedSingle
        panelLaporan.Location = New Point(56, 127)
        panelLaporan.Name = "panelLaporan"
        panelLaporan.Size = New Size(491, 271)
        panelLaporan.TabIndex = 6
        ' 
        ' btnTutup
        ' 
        btnTutup.Location = New Point(435, 404)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(112, 34)
        btnTutup.TabIndex = 0
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' FormLaporan
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(595, 450)
        Controls.Add(btnTutup)
        Controls.Add(panelLaporan)
        Controls.Add(btnTampilkan)
        Controls.Add(txtTahun)
        Controls.Add(cmbBulan)
        Controls.Add(lblLaporan)
        Controls.Add(lblPeriode)
        Name = "FormLaporan"
        Text = "SIParkir - Laporan Pendapatan Parkir"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblPeriode As Label
    Friend WithEvents lblLaporan As Label
    Friend WithEvents cmbBulan As ComboBox
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents panelLaporan As Panel
    Friend WithEvents btnTutup As Button
End Class
