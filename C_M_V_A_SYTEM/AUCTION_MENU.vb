Public Class AUCTION_MENU
    Dim time As Integer
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

    Private Sub MENU_FORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerFadeIn.Enabled = True
        TimerFadeOut.Enabled = False
        Timer1.Enabled = True
        Label1.Text = TimeOfDay
    End Sub
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        time = time + 1
        If time Mod 10 = 2 Then
            ADs.Image = My.Resources.AD1
        ElseIf time Mod 10 = 4 Then
            ADs.Image = My.Resources.AD2
        ElseIf time Mod 10 = 6 Then
            ADs.Image = My.Resources.AD3
        ElseIf time Mod 10 = 8 Then
            ADs.Image = My.Resources.AD4
        ElseIf time Mod 10 = 0 Then
            ADs.Image = My.Resources.AD5
        End If
    End Sub

    Private Sub CLIENTPAYMENTSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TimerFadeOut.Enabled = True
        CLIENT_PAYMENTS_FORM.Show()
    End Sub

    Private Sub CLIENTFORMToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TimerFadeOut.Enabled = True
        CLIENTS_FORM.Show()
    End Sub

    Private Sub CUSTOMERPAYMENTSFORMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUSTOMERPAYMENTSFORMToolStripMenuItem.Click
        TimerFadeOut.Enabled = True
        CUSTOMER_PAYMENTS_FORM.Show()
    End Sub

    Private Sub CUSTOMERSFORMToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TimerFadeOut.Enabled = True
        CUSTOMERS_FORM.Show()
    End Sub

    Private Sub BIDDETAILSFORMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BIDDETAILSFORMToolStripMenuItem.Click
        TimerFadeOut.Enabled = True
        BIDDETAILS.Show()
    End Sub

    Private Sub VEHICLESFORMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VEHICLESFORMToolStripMenuItem.Click
        TimerFadeOut.Enabled = True
        VEHICLES_FORM.Show()
    End Sub


    Private Sub EXITSYSTEMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITSYSTEMToolStripMenuItem.Click
        Dim RESULT As String
        RESULT = MsgBox("EXIT SYSTEM?", vbYesNoCancel)
        If RESULT = vbYes Then
            TimerFadeOut.Enabled = True 'fade out to be enabled on exit
        End If
    End Sub

    Private Sub AUCTIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AUCTIONToolStripMenuItem.Click
        TimerFadeOut.Enabled = True
        AUCTION_FORM.Show()
    End Sub
End Class