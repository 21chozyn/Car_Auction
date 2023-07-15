Public Class CHANGE_AUCTIONEER_LOGIN
    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PBOXHIDE.MouseLeave
        TXTPASS.PasswordChar = "*"
        TXTPASS1.PasswordChar = "*"
        PBOXHIDE.Visible = False
        PBOXVIEW.Visible = True
    End Sub

    Private Sub PBOXVIEW_MouseHover(sender As Object, e As EventArgs) Handles PBOXVIEW.MouseHover
        PBOXHIDE.Visible = True
        PBOXVIEW.Visible = False
        TXTPASS.PasswordChar = ""
        TXTPASS1.PasswordChar = ""
    End Sub
    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerFadeIn.Enabled = True 'fade in to be enabled on load
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
            MENU_FORM.Show()
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BTNEXIT.Click
        Dim RESULT As String
        RESULT = MsgBox("CANCEL AND EXIT TO MAIN MENU?", vbYesNoCancel)
        If RESULT = vbYes Then
            TimerFadeOut.Enabled = True 'fade out to be enabled on exit
            MENU_FORM.Show()
        End If
    End Sub

    Private Sub BTNCLEAR_Click_1(sender As Object, e As EventArgs) Handles BTNCLEAR.Click
        TXTPASS.Clear()
        TXTUSER.Clear()
    End Sub
    Private Sub BTNLOGIN_Click(sender As Object, e As EventArgs) Handles BTNLOGIN.Click
        Dim n As Integer
        If Len(TXTPASS.Text) = 0 Then
            Exit Sub
        ElseIf Len(TXTPASS.Text) < 6 Then
            MsgBox("Invalid password ,Enter Password with characters greater than 6 ")
            TXTPASS.Clear()
            TXTPASS.Focus()
            TXTPASS1.Clear()
            Exit Sub
        Else
            For i = 0 To Len(TXTPASS.Text) - 1
                n = Asc(TXTPASS.Text(i))
                If (n < 48) Or ((n > 57) And (n < 65)) Or ((n > 90) And (n < 97)) Or (n > 122) Then
                    MsgBox("Invalid password")
                    TXTPASS.Clear()
                    TXTPASS.Focus()
                    TXTPASS1.Clear()
                    Exit Sub
                End If
            Next
        End If
        If TXTPASS1.Text <> TXTPASS.Text Then
            MsgBox("PLEASE INSERT MATCHING PASSWORDS", vbCritical)
            TXTPASS1.Clear()
            TXTPASS.Clear()
        End If
        If TXTUSER.Text <> TXTUSER1.Text Then
            MsgBox("PLEASE INSERT MATCHING USERNAMES", vbCritical)
            TXTUSER.Clear()
            TXTUSER1.Clear()
        End If
        If (Len(TXTPASS.Text) > 0) And (Len(TXTPASS1.Text) > 0) And (Len(TXTUSER.Text) > 0) And (Len(TXTUSER1.Text) > 0) Then
            Dim RESULT As String
            RESULT = MsgBox("SAVE CHANGES AND EXIT TO MENU?", vbYesNoCancel)
            If RESULT = vbYes Then
                My.Settings.AUCTIONER_USERNAME = TXTUSER.Text
                My.Settings.AUCTIONEER_PASSWORD = TXTPASS.Text
                MsgBox("AUCTIONEER USERNAME CHANGED", vbInformation)
                TimerFadeOut.Enabled = True
            End If
        End If
    End Sub
End Class