Public Class VEHICLES_FORM
    Dim EXITS As Boolean = False

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
    Private Sub VEHICLES_FORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub BTNTOLOGIN_Click(sender As Object, e As EventArgs) Handles BTNTOLOGIN.Click
        Dim RESULT As String
        RESULT = MsgBox("EXIT SYSTEM?", vbYesNoCancel)
        If RESULT = vbYes Then
            TimerFadeOut.Enabled = True 'fade out to be enabled on exit
            LOGIN.Show()
        End If
    End Sub

    Private Sub BTNVALIDATE_Click(sender As Object, e As EventArgs) Handles BTNVALIDATE.Click
        If Len(TXTMAKE.Text) = 0 Then
            MsgBox("DATA MISSING IN NAME FIELD")
            TXTMAKE.Focus()
            Exit Sub
        End If
        If Len(TXTMODEL.Text) = 0 Then
            MsgBox("DATA MISSING IN ID NUMBER FIELD")
            TXTMODEL.Focus()
            Exit Sub
        End If
        If Len(TXTVEHCOL.Text) = 0 Then
            MsgBox("DATA MISSING IN PHYSICAL ADDRESS FIELD")
            TXTVEHCOL.Focus()
            Exit Sub
        End If
        If Len(TXTMILEAGE.Text) = 0 Then
            MsgBox("DATA MISSING IN EMAIL ADDRESS FIELD")
            TXTMILEAGE.Focus()
            Exit Sub
        End If
        If Len(TXTVEHREG.Text) = 0 Then
            MsgBox("DATA MISSING IN EMAIL ADDRESS FIELD")
            TXTVEHREG.Focus()
            Exit Sub
        End If
        If Len(TXTVEHNUM.Text) = 0 Then
            MsgBox("DATA MISSING IN EMAIL ADDRESS FIELD")
            TXTVEHNUM.Focus()
            Exit Sub
        End If
        If Len(TXTCLIENTNUM.Text) = 0 Then
            MsgBox("DATA MISSING IN EMAIL ADDRESS FIELD")
            TXTCLIENTNUM.Focus()
            Exit Sub
        End If
        If Len(TXTBUYNOW.Text) = 0 Then
            MsgBox("DATA MISSING IN EMAIL ADDRESS FIELD")
            TXTBUYNOW.Focus()
            Exit Sub
        End If

    End Sub
End Class