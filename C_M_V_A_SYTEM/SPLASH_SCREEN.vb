Public Class SPLASH_SCREEN
    Dim TIME As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerFadeIn.Tick
        Me.Opacity = Me.Opacity + 0.1
        If Me.Opacity >= 1 Then
            TimerFadeIn.Enabled = False
            Me.Opacity = 1
        End If
    End Sub

    Private Sub SPLASH_SCREEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerFadeIn.Enabled = True
        TimerCarPosn.Enabled = True
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles TimerFadeOut.Tick
        Me.Opacity = Me.Opacity - 0.1
        If Me.Opacity < 0.1 Then
            TimerFadeOut.Enabled = False
        End If
    End Sub

    Private Sub TimerCarPosn_Tick(sender As Object, e As EventArgs) Handles TimerCarPosn.Tick
        PictureCar.Location = New Point(PictureCar.Location.X + 5, PictureCar.Location.Y)
        TIME = TIME + 1
        If TIME = 80 Then
            LOGIN.Show()
            TimerFadeOut.Enabled = True
        End If
        If TIME = 100 Then
            Me.Close()
        End If
    End Sub

End Class