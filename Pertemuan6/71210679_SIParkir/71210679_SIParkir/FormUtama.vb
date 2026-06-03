Public Class FormUtama
    Private Sub mnuAturProfil_Click(sender As Object, e As EventArgs) Handles mnuAturProfil.Click
        FormProfil.ShowDialog()
    End Sub
    Private Sub mnuLangganan_Click(sender As Object, e As EventArgs) Handles mnuLangganan.Click
        FormLangganan.ShowDialog()
    End Sub

    Private Sub mnuLaporan_Click(sender As Object, e As EventArgs) Handles mnuLaporan.Click
        FormLaporan.ShowDialog()
    End Sub
    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click

        FormLogin.Show()
        Me.Hide()

    End Sub
End Class