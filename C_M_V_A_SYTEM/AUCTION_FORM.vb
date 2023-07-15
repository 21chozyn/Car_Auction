Public Class AUCTION_FORM
    Dim EXITS As Boolean = False
    Dim ADD As Boolean = True
    Dim SOLDBID As Integer
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
    Private Sub BID_DETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerFadeIn.Enabled = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CHKVEHICLEINFO.CheckedChanged
        If CHKVEHICLEINFO.Checked = True Then
            PNLVEHICLEINFO.Visible = True
            Panel2.Visible = False
            Panel3.Visible = False
        Else
            PNLVEHICLEINFO.Visible = False
            Panel2.Visible = True
            Panel3.Visible = True
        End If
    End Sub
    Private Sub BTNTOMENU_Click(sender As Object, e As EventArgs) Handles BTNTOMENU.Click
        Dim RESULT As String
        RESULT = MsgBox("EXIT TO MENU?", vbYesNoCancel)
        If RESULT = vbYes Then
            TimerFadeOut.Enabled = True 'fade out to be enabled on exit
            AUCTION_MENU.Show()
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BTNAUCTION.Click
        MsgBox("ADD EACH PARTICIPATING CUSTOMERS NUMBER TO THE LISTBOX ")
        Dim N As Integer
        Dim RESULT As String
        N = InputBox("ENTER NUMBER OF PARTICIPANTS ")
        Dim NUMBERS(N) As Integer
        Dim BIDPRICES(N) As Integer
        For INDEX = 1 To N
            NUMBERS(INDEX) = InputBox("ENTER PARTICIPATING CUSTOMER NUMBER " & INDEX)
        Next
        Dim RESULTS As String
        RESULTS = MsgBox("PUT INTO PARTICIPATING CUSTOMER'S LISTBOX?", vbYesNoCancel)
        If RESULTS = vbYes Then
            For INDEX = 1 To N
                ListBox1.Items.Add(NUMBERS(INDEX))
            Next
            MsgBox("ITEMS ADDED")
        End If
        For INDEX = 1 To N
            RESULT = InputBox("ENTER BIDPRICE OF PARTICIPANT NUMBER" & NUMBERS(INDEX))
            If RESULT = "" Then
                MsgBox("THE HIGHEST BIDDER HAS A BID OFFER OF " & BIDPRICES(INDEX - 1))
                MsgBox("THE HIGHEST BIDDER IS CUSTOMER NUMBER " & NUMBERS(INDEX - 1))
                SOLDBID = BIDPRICES(INDEX - 1)
                Exit For
            ElseIf RESULT = " " Then
                BIDPRICES(INDEX) = 0
            Else
                BIDPRICES(INDEX) = RESULT
            End If

            If INDEX = N Then
                INDEX = 1
            End If
        Next
    End Sub
End Class