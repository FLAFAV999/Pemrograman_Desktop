<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProfil
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
        lblUsername = New Label()
        lblPassBaru = New Label()
        lblKetikUlang = New Label()
        txtUsername = New TextBox()
        txtPassBaru = New TextBox()
        txtKetikUlang = New TextBox()
        btnSimpan = New Button()
        btnTutup = New Button()
        SuspendLayout()
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(81, 47)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(96, 25)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username "
        ' 
        ' lblPassBaru
        ' 
        lblPassBaru.AutoSize = True
        lblPassBaru.Location = New Point(81, 106)
        lblPassBaru.Name = "lblPassBaru"
        lblPassBaru.Size = New Size(132, 25)
        lblPassBaru.TabIndex = 1
        lblPassBaru.Text = "Password Baru "
        ' 
        ' lblKetikUlang
        ' 
        lblKetikUlang.AutoSize = True
        lblKetikUlang.Location = New Point(81, 162)
        lblKetikUlang.Name = "lblKetikUlang"
        lblKetikUlang.Size = New Size(101, 25)
        lblKetikUlang.TabIndex = 2
        lblKetikUlang.Text = "Ketik Ulang"
        ' 
        ' txtUsername
        ' 
        txtUsername.Enabled = False
        txtUsername.Location = New Point(231, 47)
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(278, 31)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassBaru
        ' 
        txtPassBaru.Location = New Point(231, 103)
        txtPassBaru.Name = "txtPassBaru"
        txtPassBaru.Size = New Size(278, 31)
        txtPassBaru.TabIndex = 4
        txtPassBaru.UseSystemPasswordChar = True
        ' 
        ' txtKetikUlang
        ' 
        txtKetikUlang.Location = New Point(231, 159)
        txtKetikUlang.Name = "txtKetikUlang"
        txtKetikUlang.Size = New Size(278, 31)
        txtKetikUlang.TabIndex = 5
        txtKetikUlang.UseSystemPasswordChar = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(132, 238)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 34)
        btnSimpan.TabIndex = 6
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnTutup
        ' 
        btnTutup.Location = New Point(366, 238)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(112, 34)
        btnTutup.TabIndex = 7
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = True
        ' 
        ' FormProfil
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(629, 334)
        Controls.Add(btnTutup)
        Controls.Add(btnSimpan)
        Controls.Add(txtKetikUlang)
        Controls.Add(txtPassBaru)
        Controls.Add(txtUsername)
        Controls.Add(lblKetikUlang)
        Controls.Add(lblPassBaru)
        Controls.Add(lblUsername)
        Name = "FormProfil"
        Text = "SIParkir - Ubah Profil"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassBaru As Label
    Friend WithEvents lblKetikUlang As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassBaru As TextBox
    Friend WithEvents txtKetikUlang As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnTutup As Button
End Class
