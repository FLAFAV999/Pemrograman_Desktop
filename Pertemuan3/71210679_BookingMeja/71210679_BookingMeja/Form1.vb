Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(163, 200, 229)
        Me.Text = "Reservasi Meja - Restoran"

        ' Inisialisasi kontrol
        cbMeja.Items.Clear()
        OpsiJmlTamu.Minimum = 1
        OpsiJmlTamu.Maximum = 8
        cbMeja.DropDownStyle = ComboBoxStyle.DropDownList

        ' Perbaiki rentang tanggal ke tanggal aktual (MaxDate harus di-set LEBIH DULU)
        dtpTanggal.MaxDate = Date.Today.AddYears(1)
        dtpTanggal.MinDate = Date.Today
        dtpTanggal.Value = Date.Today

        ' Tambah header judul secara programatik (mengisi ruang kosong di atas form)
        Dim lbJudul As New Label()
        lbJudul.Text = "FORM RESERVASI MEJA"
        lbJudul.Font = New Font("Nirmala UI", 13, FontStyle.Bold)
        lbJudul.ForeColor = Color.White
        lbJudul.BackColor = Color.FromArgb(41, 128, 185)
        lbJudul.AutoSize = False
        lbJudul.Width = Me.ClientSize.Width
        lbJudul.Height = 50
        lbJudul.Location = New Point(0, 0)
        lbJudul.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(lbJudul)
        lbJudul.BringToFront()

        ' Style tombol Next
        btNext.BackColor = Color.FromArgb(41, 128, 185)
        btNext.ForeColor = Color.White
        btNext.FlatStyle = FlatStyle.Flat
        btNext.FlatAppearance.BorderSize = 0
        btNext.Font = New Font(btNext.Font, FontStyle.Bold)
        btNext.Cursor = Cursors.Hand
    End Sub

    ' Update pilihan meja saat jumlah tamu diubah
    Private Sub OpsiJmlTamu_ValueChanged(sender As Object, e As EventArgs) Handles OpsiJmlTamu.ValueChanged
        cbMeja.Items.Clear()
        Dim jumlahTamu As Integer = CInt(OpsiJmlTamu.Value)

        Select Case jumlahTamu
            Case 1 To 2
                cbMeja.Items.Add("Meja 1 (2 Kursi)")
            Case 3 To 4
                cbMeja.Items.Add("Meja 2 (4 Kursi)")
            Case 5 To 6
                cbMeja.Items.Add("Meja 3 (6 Kursi)")
            Case 7 To 8
                cbMeja.Items.Add("Meja 4 (8 Kursi)")
        End Select

        If cbMeja.Items.Count > 0 Then
            cbMeja.SelectedIndex = 0
        End If
    End Sub

    ' Tombol Next untuk berpindah ke Form2
    Private Sub btNext_Click(sender As Object, e As EventArgs) Handles btNext.Click
        If String.IsNullOrWhiteSpace(tbNama.Text) Then
            MessageBox.Show("Nama tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbNama.Focus()
            Return
        End If

        If Not MtbWaktu.MaskCompleted Then
            MessageBox.Show("Silakan masukkan waktu reservasi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MtbWaktu.Focus()
            Return
        End If

        If cbMeja.SelectedItem Is Nothing Then
            MessageBox.Show("Silakan pilih jumlah tamu dan meja terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Teruskan data ke Form2
        Dim form2 As New Form2()
        form2.NamaPemesan = tbNama.Text
        form2.TanggalReservasi = dtpTanggal.Value
        form2.WaktuReservasi = MtbWaktu.Text
        form2.MejaReservasi = cbMeja.SelectedItem.ToString()
        form2.Show()
        Me.Hide()
    End Sub

End Class
