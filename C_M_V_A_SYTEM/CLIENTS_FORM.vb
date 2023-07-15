
Public Class CLIENTS_FORM
    Dim EXITS As Boolean = False

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If EXITS = True Then
            EXITS = False
        Else
            EXITS = True
        End If
        If EXITS = True Then
            BTNTOLOGIN.Visible = True
            BTNTOMENU.Visible = True
        Else
            BTNTOLOGIN.Visible = False
            BTNTOMENU.Visible = False
        End If
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


    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Me.Close()
        MENU_FORM.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Me.Close()
        LOGIN.Show()
    End Sub
    Private Sub CLIENTS_FORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerFadeIn.Enabled = True
    End Sub
    Private Sub BTNTOMENU_Click(sender As Object, e As EventArgs) Handles BTNTOMENU.Click
        Dim RESULT As String
        RESULT = MsgBox("EXIT TO MENU?", vbYesNoCancel)
        If RESULT = vbYes Then
            TimerFadeOut.Enabled = True 'fade out to be enabled on exit
            MENU_FORM.Show()
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
        If Len(TXTNAME.Text) = 0 Then
            MsgBox("DATA MISSING IN NAME FIELD")
            TXTNAME.Focus()
            Exit Sub
        End If
        If Len(TXTIDNUM.Text) = 0 Then
            MsgBox("DATA MISSING IN ID NUMBER FIELD")
            TXTIDNUM.Focus()
            Exit Sub
        End If
        If Len(TXTPHYADDR.Text) = 0 Then
            MsgBox("DATA MISSING IN PHYSICAL ADDRESS FIELD")
            TXTPHYADDR.Focus()
            Exit Sub
        End If
        If Len(TXTEMADDR.Text) = 0 Then
            MsgBox("DATA MISSING IN EMAIL ADDRESS FIELD")
            TXTEMADDR.Focus()
            Exit Sub
        Else
            '     Dim strMandatoryChars As String = "@.com"
            '  For i = 0 To Len(TXTEMADDR.Text) - 1
            '  If InStr(1, strMandatoryChars, TXTEMADDR.Text(i)) = 0 Then
            '  MsgBox("PLEASE INCLUDE '@.COM' IN THE EMAIL ADDRESS  ")
            ' TXTEMADDR.Focus()
            '  Exit Sub
            'End If
            ' Next

        End If

        If DateTimePicker1.Value > Today Then
            MsgBox("PLEASE ENTER A VALID DATE ")
            Exit Sub
        End If
        If DateTimePicker2.Value > Today Then
            MsgBox("PLEASE ENTER A VALID DATE ")
            Exit Sub
        End If

        Dim strAllowedChars As String = "0123456789"
        If Len(TXTTELL.Text) = 0 Then
            MsgBox("DATA MISSING IN TELEPHONE NUMBER FIELD")
            Exit Sub
        Else
            For i = 0 To Len(TXTTELL.Text) - 1
                If InStr(1, strAllowedChars, TXTTELL.Text(i)) = 0 Then
                    MsgBox("Invalid telephone number.")
                    TXTTELL.Focus()
                    Exit Sub
                End If
            Next
        End If
        If Len(TXTCELL.Text) = 0 Then
            MsgBox("DATA MISSING IN CELL NUMBER FIELD")
            Exit Sub
        Else
            For i = 0 To Len(TXTCELL.Text) - 1
                If InStr(1, strAllowedChars, TXTCELL.Text(i)) = 0 Then
                    MsgBox("Invalid cell number.")
                    TXTCELL.Focus()
                    Exit Sub
                End If
            Next
        End If


        MsgBox("DATA HAS BEEN VALIDATAED", vbInformation)
        BTNSAVE.Visible = True

    End Sub
End Class