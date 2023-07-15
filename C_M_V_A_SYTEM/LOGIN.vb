
Public Class LOGIN
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(7)
        ProgressBar1.Minimum = (0)
        ProgressBar1.Maximum = (100)
        LBLPCNT.Text = ProgressBar1.Value & " %"
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            ProgressBar1.Visible = False
            LBLPCNT.Visible = False
            TXTPASS.Clear()
            TXTUSER.Clear()
            If My.Settings.ADMIN = True Then
                MsgBox(" YOU ARE WELCOME ,ADMINISTRATOR ", vbInformation)
                MENU_FORM.Show()
            ElseIf My.Settings.ADMIN = False Then
                MsgBox(" YOU ARE WELCOME ,AUCTIONEER ", vbInformation)
                AUCTION_MENU.Show()
            End If
            Me.Hide()
        End If
    End Sub
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        ProgressBar1.Value = 0.0
        ProgressBar1.Maximum = 100
        Timer1.Interval = 40
        Timer1.Enabled = True
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PBOXHIDE.MouseLeave
        TXTPASS.PasswordChar = "*"
        PBOXHIDE.Visible = False
        PBOXVIEW.Visible = True
    End Sub

    Private Sub PBOXVIEW_MouseHover(sender As Object, e As EventArgs) Handles PBOXVIEW.MouseHover
        PBOXHIDE.Visible = True
        PBOXVIEW.Visible = False
        TXTPASS.PasswordChar = ""
    End Sub
    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerFadeIn.Enabled = True 'fade in to be enabled on load
        Label1.Text = TimeOfDay
    End Sub

    Private Sub TimerFadeIn_Tick(sender As Object, e As EventArgs) Handles TimerFadeIn.Tick
        Me.Opacity = Me.Opacity + 0.1

        If Me.Opacity >= 1 Then
            TimerFadeIn.Enabled = False
            Me.Opacity = 1
        End If
    End Sub

    Private Sub TimerFadeOut_Tick(sender As Object, e As EventArgs) Handles TimerFadeOut.Tick
        Me.Opacity = Me.Opacity - 0.1
        If Me.Opacity < 0.1 Then
            TimerFadeOut.Enabled = False
            Me.Close()
        End If
    End Sub


    Private Sub BTNLOGIN_Click(sender As Object, e As EventArgs) Handles BTNLOGIN.Click
        Me.Cursor = Cursors.WaitCursor
        MsgBox("VERIFYING CREDENTIALS", MsgBoxStyle.Information)
        If (TXTUSER.Text = My.Settings.USERNAME) And TXTPASS.Text = My.Settings.PASSWORD Then
            Timer1.Start()
            ProgressBar1.Visible = True
            LBLPCNT.Visible = True
            ProgressBar1.Enabled = True
            My.Settings.ADMIN = True
        ElseIf (TXTUSER.Text = My.Settings.AUCTIONER_USERNAME) And TXTPASS.Text = My.Settings.AUCTIONEER_PASSWORD Then
            Timer1.Start()
            ProgressBar1.Visible = True
            LBLPCNT.Visible = True
            ProgressBar1.Enabled = True
            My.Settings.ADMIN = False
        Else
            MsgBox("WRONG LOGIN CREDENTIALS , TRY AGAIN", MsgBoxStyle.Critical)
            TXTPASS.Clear()
            TXTUSER.Clear()

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BTNEXIT.Click
        Dim RESULT As String
        RESULT = MsgBox("EXIT SYSTEM?", vbYesNoCancel)
        If RESULT = vbYes Then
            TimerFadeOut.Enabled = True 'fade out to be enabled on exit
        End If
    End Sub

    Private Sub BTNCLEAR_Click_1(sender As Object, e As EventArgs) Handles BTNCLEAR.Click
        TXTPASS.Clear()
        TXTUSER.Clear()
    End Sub


End Class

