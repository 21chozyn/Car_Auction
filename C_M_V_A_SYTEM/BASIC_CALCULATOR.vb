Public Class BASIC_CALCULATOR

    Dim firstnumber As Decimal
    Dim secondnumber As Decimal
    Dim operations As Integer
    Dim operator_selector As Boolean = False

    Dim LIGHT As Boolean = True


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If LIGHT = True Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text += "1"
            Else
                TextBox1.Text = "1"
            End If
        Else

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If LIGHT = True Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text += "2"
            Else
                TextBox1.Text = "2"
            End If
        Else
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If LIGHT = True Then

            If TextBox1.Text <> "0" Then
                TextBox1.Text += "3"
            Else
                TextBox1.Text = "3"
            End If
        Else
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If LIGHT = True Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text += "4"
            Else
                TextBox1.Text = "4"
            End If
        Else
        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If LIGHT = True Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text += "5"
            Else
                TextBox1.Text = "5"
            End If
        Else
        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If LIGHT = True Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text += "6"
            Else
                TextBox1.Text = "6"
            End If
        Else
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If LIGHT = True Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text += "7"
            Else
                TextBox1.Text = "7"
            End If
        Else
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If LIGHT = True Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text += "8"
            Else
                TextBox1.Text = "8"
            End If
        Else
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If LIGHT = True Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text += "9"
            Else
                TextBox1.Text = "9"
            End If
        Else
        End If

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If LIGHT = True Then
            If TextBox1.Text <> "0" Then
                TextBox1.Text += "0"
            End If
        Else
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If LIGHT = True Then
            TextBox1.Text = "0"
        Else
        End If

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If LIGHT = True Then
            If Not (TextBox1.Text.Contains(".")) Then
                TextBox1.Text += "."
            End If
        Else
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If LIGHT = True Then
            firstnumber = TextBox1.Text
            TextBox1.Text = "0"
            operator_selector = True
            operations = 1 ' = +
        Else
        End If

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If LIGHT = True Then
            firstnumber = TextBox1.Text
            TextBox1.Text = "0"
            operator_selector = True
            operations = 2 ' = -
        Else
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If LIGHT = True Then
            firstnumber = TextBox1.Text
            TextBox1.Text = "0"
            operator_selector = True
            operations = 3 ' = *
        Else
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If LIGHT = True Then
            firstnumber = TextBox1.Text
            TextBox1.Text = "0"
            operator_selector = True
            operations = 4 ' = /
        Else
        End If
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If LIGHT = True Then
            If operator_selector = True Then
                secondnumber = TextBox1.Text
                If operations = 1 Then
                    TextBox1.Text = firstnumber + secondnumber
                ElseIf operations = 2 Then
                    TextBox1.Text = firstnumber - secondnumber
                ElseIf operations = 3 Then
                    TextBox1.Text = firstnumber * secondnumber
                Else
                    If secondnumber = 0 Then
                        TextBox1.Text = "ERROR!"
                    Else
                        TextBox1.Text = firstnumber / secondnumber
                    End If
                End If
                operator_selector = False
            End If
        Else
        End If
    End Sub

  
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Dim result As String
        result = MsgBox("ARE YOU SURE YOU WANT TO EXIT?", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            TimerFadeOut.Enabled = True
        End If
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If LIGHT = True Then
            LIGHT = False
        Else
            LIGHT = True
        End If
        If LIGHT = False Then
            TextBox1.Text = "SCREEN OFF!"
        Else
            TextBox1.Text = "0"
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
            MENU_FORM.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BASIC_CALCULATOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerFadeIn.Enabled = True 'fade in to be enabled on load
    End Sub
End Class