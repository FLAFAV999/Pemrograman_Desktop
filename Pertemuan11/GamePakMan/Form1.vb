Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    Dim map = {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0},
        {0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0},
        {0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0},
        {0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}}

    Dim tsz = 40
    Dim pacx = 1
    Dim pacy = 1

    Dim enmx = 9
    Dim enmy = 7
    Dim enmx1 = 2
    Dim enmy1 = 3
    Dim enmx2 = 3
    Dim enmy2 = 5

    Dim goalx = 1
    Dim goaly = 7
    Dim bmp As Bitmap
    Dim oldpacx = 0
    Dim oldpacy = 0

    Dim wall As Image = My.Resources.bata
    Dim way As Image = My.Resources.rumput

    Dim arahPakman As String
    Dim pac As Image = My.Resources.pakman
    Dim pacbawah As Image = My.Resources.pakman2
    Dim packiri As Image = My.Resources.pakman3
    Dim pacatas As Image = My.Resources.pakman4

    Dim enm As Image = My.Resources.hantu1
    Dim enm1 As Image = My.Resources.hantu2
    Dim enm2 As Image = My.Resources.hantu3

    Dim nyawa = 3
    Dim hati As Image = My.Resources.nyawa

    Dim goal As Image = My.Resources.omah

    Private Sub resetDefault()
        tsz = 40

        pacx = 1
        pacy = 1

        enmx = 9
        enmy = 7

        enmx1 = 2
        enmy1 = 3

        enmx2 = 3
        enmy2 = 5

        goalx = 1
        goaly = 7

        oldpacx = 0
        oldpacy = 0
        Redraw()
        Timer1.Enabled = True
    End Sub

    Private Sub Redraw()
        Dim g As Graphics = Graphics.FromImage(PictureBox1.Image)

        For y = 0 To (map.GetUpperBound(0))
            For x = 0 To map.GetUpperBound(1)
                If map(y, x) = 0 Then
                    g.DrawImage(wall, x * tsz, y * tsz, tsz, tsz)
                Else
                    g.DrawImage(way, x * tsz, y * tsz, tsz, tsz)
                End If
            Next
        Next

        For i As Integer = 0 To nyawa - 1
            g.DrawImage(hati, i * tsz, PictureBox1.Height - tsz, tsz, tsz)
        Next

        g.DrawImage(pac, pacx * tsz, pacy * tsz, tsz, tsz)
        Select Case arahPakman
            Case "atas"
                g.DrawImage(pacatas, pacx * tsz, pacy * tsz, tsz, tsz)
            Case "bawah"
                g.DrawImage(pacbawah, pacx * tsz, pacy * tsz, tsz, tsz)
            Case "kiri"
                g.DrawImage(packiri, pacx * tsz, pacy * tsz, tsz, tsz)
            Case "kanan"
                g.DrawImage(pac, pacx * tsz, pacy * tsz, tsz, tsz)
        End Select

        g.DrawImage(enm, enmx * tsz, enmy * tsz, tsz, tsz)
        g.DrawImage(enm1, enmx1 * tsz, enmy1 * tsz, tsz, tsz)
        g.DrawImage(enm2, enmx2 * tsz, enmy2 * tsz, tsz, tsz)

        g.DrawImage(goal, goalx * tsz, (map.GetUpperBound(0) - 1) * tsz, tsz, tsz)

        PictureBox1.Refresh()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                If map(pacy - 1, pacx) = 1 Then
                    pacy = pacy - 1
                End If
                arahPakman = "atas"
            Case Keys.Down
                If map(pacy + 1, pacx) = 1 Then
                    pacy = pacy + 1
                End If
                arahPakman = "bawah"
            Case Keys.Right
                If map(pacy, pacx + 1) = 1 Then
                    pacx = pacx + 1
                End If
                arahPakman = "kanan"
            Case Keys.Left
                If map(pacy, pacx - 1) = 1 Then
                    pacx = pacx - 1
                End If
                arahPakman = "kiri"
        End Select
        Redraw()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sesuaikan dulu ukuran picturebox dan form
        PictureBox1.Width = map.GetLength(1) * tsz
        PictureBox1.Height = map.GetLength(0) * tsz
        Me.Width = PictureBox1.Width + tsz
        Me.Height = PictureBox1.Height + tsz + tsz
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = bmp
        Redraw()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim jarakx, jaraky As Integer
        Dim arah As Integer

        jarakx = Math.Abs(pacx - enmx)
        jaraky = Math.Abs(pacy - enmy)
        If jarakx > jaraky Then
            If (pacx - enmx > 0) Then
                arah = 1
            Else
                arah = 3
            End If
        End If

        If jarakx < jaraky Then
            If (pacy - enmy > 0) Then
                arah = 2
            Else
                arah = 0
            End If
        End If

        If (oldpacx = pacx) And (oldpacy = pacy) Then
            arah = Math.Floor(Rnd() * 4)
        End If

        Select Case arah
            Case 0
                If map(enmy - 1, enmx) = 1 Then
                    enmy = enmy - 1
                End If
            Case 2
                If map(enmy + 1, enmx) = 1 Then
                    enmy = enmy + 1
                End If
            Case 1
                If map(enmy, enmx + 1) = 1 Then
                    enmx = enmx + 1
                End If
            Case 3
                If map(enmy, enmx - 1) = 1 Then
                    enmx = enmx - 1
                End If
        End Select

        Dim arah2 As Integer = Math.Floor(Rnd() * 4)
        Select Case arah2
            Case 0
                If map(enmy1 - 1, enmx1) = 1 Then
                    enmy1 = enmy1 - 1
                End If
            Case 2
                If map(enmy1 + 1, enmx1) = 1 Then
                    enmy1 = enmy1 + 1
                End If
            Case 1
                If map(enmy1, enmx1 + 1) = 1 Then
                    enmx1 = enmx1 + 1
                End If
            Case 3
                If map(enmy1, enmx1 - 1) = 1 Then
                    enmx1 = enmx1 - 1
                End If
        End Select

        Dim arah3 As Integer = Math.Floor(Rnd() * 4)
        Select Case arah3
            Case 0
                If map(enmy2 - 1, enmx2) = 1 Then
                    enmy2 = enmy2 - 1
                End If
            Case 2
                If map(enmy2 + 1, enmx2) = 1 Then
                    enmy2 = enmy2 + 1
                End If
            Case 1
                If map(enmy2, enmx2 + 1) = 1 Then
                    enmx2 = enmx2 + 1
                End If
            Case 3
                If map(enmy2, enmx2 - 1) = 1 Then
                    enmx2 = enmx2 - 1
                End If
        End Select

        oldpacx = pacx
        oldpacy = pacy
        Redraw()

        If (pacx = enmx) And (pacy = enmy) Then
            Timer1.Enabled = False
            nyawa -= 1
            resetDefault()
        ElseIf (pacx = enmx1) And (pacy = enmy1) Then
            Timer1.Enabled = False
            nyawa -= 1
            resetDefault()
        ElseIf (pacx = enmx2) And (pacy = enmy2) Then
            Timer1.Enabled = False
            nyawa -= 1
            resetDefault()
        End If

        If nyawa = 0 Then
            Timer1.Enabled = False
            MsgBox("Nyawa habis! Game Over!")
        End If

        If (pacx = goalx) And (pacy = (map.GetUpperBound(0) - 1)) Then
            Timer1.Enabled = False
            MsgBox("Pakman safe at Home!")
        End If
    End Sub
End Class
