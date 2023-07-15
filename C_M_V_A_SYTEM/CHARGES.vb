Public Class CHARGES
    Dim EXITS As Boolean = False
    Dim ENTRYDATE As Date
    Dim TIMEINGARAGE, GRGECHARGEPD As Integer
    Dim MAINTANANCEFEE, GRGECHARGE, TTLCHARGE, OTHERFEE As Decimal

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

    Private Sub CUSTOMER_PAYMENTS_FORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerFadeIn.Enabled = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If EXITS = True Then
            EXITS = False
        Else
            EXITS = True
        End If
        If EXITS = True Then
            BTNTOMENU.Visible = True
            BTNTOLOGIN.Visible = True
        Else
            BTNTOLOGIN.Visible = False
            BTNTOMENU.Visible = False
        End If
    End Sub

    Private Sub BTNTOMENU_Click(sender As Object, e As EventArgs) Handles BTNTOMENU.Click
        Dim RESULT As String
        RESULT = MsgBox("EXIT TO MENU?", vbYesNoCancel)
        If RESULT = vbYes Then
            TimerFadeOut.Enabled = True 'fade out to be enabled on exit
            If My.Settings.ADMIN = True Then
                MENU_FORM.Show()
            ElseIf My.Settings.ADMIN = False Then
                AUCTION_MENU.Show()
            End If
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        ENTRYDATE = DateTimePicker1.Value
        TIMEINGARAGE = Val(DateTime.Today) - Val(ENTRYDATE)
        TXTDAYSINGRGE.Text = TIMEINGARAGE
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value = 1 Then
            GRGECHARGEPD = 10
        ElseIf NumericUpDown1.Value = 2 Then
            GRGECHARGEPD = 15
        Else
            GRGECHARGEPD = 20
        End If
        TextBox6.Text = GRGECHARGEPD
        GRGECHARGE = TIMEINGARAGE * GRGECHARGEPD
        TextBox7.Text = GRGECHARGE
        TTLCHARGE = (GRGECHARGE + MAINTANANCEFEE + OTHERFEE)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        MAINTANANCEFEE = TextBox3.Text
    End Sub

    Private Sub BTNTOLOGIN_Click(sender As Object, e As EventArgs) Handles BTNTOLOGIN.Click
        Dim RESULT As String
        RESULT = MsgBox("EXIT SYSTEM?", vbYesNoCancel)
        If RESULT = vbYes Then
            TimerFadeOut.Enabled = True 'fade out to be enabled on exit
            LOGIN.Show()
        End If
    End Sub

    Private Sub DateTimePicker1_MouseLeave(sender As Object, e As EventArgs) Handles DateTimePicker1.MouseLeave

    End Sub
End Class