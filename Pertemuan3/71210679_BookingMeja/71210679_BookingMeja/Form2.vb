Public Class Form2

    ' Data dari Form1
    Public NamaPemesan As String = ""
    Public TanggalReservasi As Date
    Public WaktuReservasi As String = ""
    Public MejaReservasi As String = ""

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(163, 200, 229)
        Me.Text = "Pilih Menu - Restoran"

        ' Style panel agar konsisten
        Panel1.BackColor = Color.FromArgb(240, 248, 255)
        Panel2.BackColor = Color.FromArgb(240, 248, 255)
        Panel3.BackColor = Color.FromArgb(240, 248, 255)
        Panel4.BackColor = Color.FromArgb(240, 248, 255)

        ' Style tombol Save (hijau)
        btSave.BackColor = Color.FromArgb(39, 174, 96)
        btSave.ForeColor = Color.White
        btSave.FlatStyle = FlatStyle.Flat
        btSave.FlatAppearance.BorderSize = 0
        btSave.Font = New Font(btSave.Font, FontStyle.Bold)
        btSave.Cursor = Cursors.Hand

        ' Style tombol Back (abu-abu)
        btBack.BackColor = Color.FromArgb(127, 140, 141)
        btBack.ForeColor = Color.White
        btBack.FlatStyle = FlatStyle.Flat
        btBack.FlatAppearance.BorderSize = 0
        btBack.Cursor = Cursors.Hand
    End Sub

    Private Function HitungTotalHarga() As Integer
        ' Variabel lokal — selalu dimulai dari 0 setiap kali dihitung
        Dim hargaMenuFavorit As Integer = 0
        Dim hargaPaketHemat As Integer = 0
        Dim hargaMenuPilihan As Integer = 0

        ' Menu Favorit — pilih salah satu
        If cbNasgorSpesial.Checked Then
            hargaMenuFavorit = 35000
        ElseIf cbAyamGeprek.Checked Then
            hargaMenuFavorit = 25000
        ElseIf cbSotoBetawi.Checked Then
            hargaMenuFavorit = 40000
        End If

        ' Paket Hemat — pilih salah satu
        If CheckBox4.Checked Then
            hargaPaketHemat = 70000 * CInt(OpsiJmlTamu.Value)
        ElseIf CheckBox5.Checked Then
            hargaPaketHemat = 85000 * CInt(NumericUpDown1.Value)
        End If

        ' Menu Pilihan — bisa lebih dari satu
        If cbNasgorAyam.Checked Then hargaMenuPilihan += 30000 * CInt(NumericUpDown3.Value)
        If cbAyamKremes.Checked Then hargaMenuPilihan += 25000 * CInt(NumericUpDown4.Value)
        If cbEsJeruk.Checked Then hargaMenuPilihan += 10000 * CInt(NumericUpDown5.Value)
        If cbSotoAyam.Checked Then hargaMenuPilihan += 25000 * CInt(NumericUpDown6.Value)

        Return hargaMenuFavorit + hargaPaketHemat + hargaMenuPilihan
    End Function

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Dim total As Integer = HitungTotalHarga()

        ' Tampilkan ringkasan pesanan lengkap sebelum konfirmasi
        Dim info As String =
            "===== RINGKASAN PESANAN =====" & Environment.NewLine &
            $"Nama    : {NamaPemesan}" & Environment.NewLine &
            $"Tanggal : {TanggalReservasi:dd/MM/yyyy}" & Environment.NewLine &
            $"Waktu   : {WaktuReservasi}" & Environment.NewLine &
            $"Meja    : {MejaReservasi}" & Environment.NewLine &
            "==============================" & Environment.NewLine &
            $"Total   : Rp {total:N0}" & Environment.NewLine &
            Environment.NewLine &
            "Silakan bayar ke kasir."

        Dim result As DialogResult = MessageBox.Show(info, "Konfirmasi Pembayaran", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        If result = DialogResult.OK Then
            MessageBox.Show("Terima kasih atas pesanan Anda!" & Environment.NewLine &
                            "Pesanan sedang diproses.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btBack_Click(sender As Object, e As EventArgs) Handles btBack.Click
        ' Cari Form1 yang tersembunyi dan tampilkan kembali
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is Form1 Then
                frm.Show()
                Me.Close()
                Return
            End If
        Next

        ' Fallback: jika Form1 tidak ditemukan, buat baru
        Dim form1 As New Form1()
        form1.Show()
        Me.Close()
    End Sub

End Class
