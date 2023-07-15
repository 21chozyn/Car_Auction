<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LBLPCNT = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BTNCLEAR = New System.Windows.Forms.Button()
        Me.BTNEXIT = New System.Windows.Forms.Button()
        Me.PBOXVIEW = New System.Windows.Forms.PictureBox()
        Me.PBOXHIDE = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BTNLOGIN = New System.Windows.Forms.Button()
        Me.TXTPASS = New System.Windows.Forms.TextBox()
        Me.TXTUSER = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimerFadeIn = New System.Windows.Forms.Timer(Me.components)
        Me.TimerFadeOut = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBOXVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBOXHIDE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(308, 23)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(241, 45)
        Me.Label21.TabIndex = 62
        Me.Label21.Text = "LOGIN FORM"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.C_M_V_A_SYTEM.My.Resources.Resources.logo_2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(872, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 159)
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'LBLPCNT
        '
        Me.LBLPCNT.AutoSize = True
        Me.LBLPCNT.BackColor = System.Drawing.Color.Transparent
        Me.LBLPCNT.Font = New System.Drawing.Font("Buxton Sketch", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPCNT.ForeColor = System.Drawing.Color.White
        Me.LBLPCNT.Location = New System.Drawing.Point(992, 540)
        Me.LBLPCNT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLPCNT.Name = "LBLPCNT"
        Me.LBLPCNT.Size = New System.Drawing.Size(57, 25)
        Me.LBLPCNT.TabIndex = 65
        Me.LBLPCNT.Text = "Label1"
        Me.LBLPCNT.UseWaitCursor = True
        Me.LBLPCNT.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.ProgressBar1.Location = New System.Drawing.Point(887, 494)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(175, 43)
        Me.ProgressBar1.TabIndex = 64
        Me.ProgressBar1.UseWaitCursor = True
        Me.ProgressBar1.Visible = False
        '
        'BTNCLEAR
        '
        Me.BTNCLEAR.BackColor = System.Drawing.Color.Black
        Me.BTNCLEAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCLEAR.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCLEAR.ForeColor = System.Drawing.Color.White
        Me.BTNCLEAR.Location = New System.Drawing.Point(660, 494)
        Me.BTNCLEAR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNCLEAR.Name = "BTNCLEAR"
        Me.BTNCLEAR.Size = New System.Drawing.Size(100, 68)
        Me.BTNCLEAR.TabIndex = 86
        Me.BTNCLEAR.Text = "CLEAR"
        Me.BTNCLEAR.UseVisualStyleBackColor = False
        '
        'BTNEXIT
        '
        Me.BTNEXIT.BackColor = System.Drawing.Color.Black
        Me.BTNEXIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNEXIT.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEXIT.ForeColor = System.Drawing.Color.White
        Me.BTNEXIT.Location = New System.Drawing.Point(375, 494)
        Me.BTNEXIT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNEXIT.Name = "BTNEXIT"
        Me.BTNEXIT.Size = New System.Drawing.Size(100, 68)
        Me.BTNEXIT.TabIndex = 85
        Me.BTNEXIT.Text = "EXIT"
        Me.BTNEXIT.UseVisualStyleBackColor = False
        '
        'PBOXVIEW
        '
        Me.PBOXVIEW.BackgroundImage = Global.C_M_V_A_SYTEM.My.Resources.Resources.Capture
        Me.PBOXVIEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBOXVIEW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBOXVIEW.Location = New System.Drawing.Point(83, 320)
        Me.PBOXVIEW.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PBOXVIEW.Name = "PBOXVIEW"
        Me.PBOXVIEW.Size = New System.Drawing.Size(77, 48)
        Me.PBOXVIEW.TabIndex = 83
        Me.PBOXVIEW.TabStop = False
        '
        'PBOXHIDE
        '
        Me.PBOXHIDE.BackgroundImage = Global.C_M_V_A_SYTEM.My.Resources.Resources.Capture1
        Me.PBOXHIDE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBOXHIDE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBOXHIDE.Location = New System.Drawing.Point(83, 320)
        Me.PBOXHIDE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PBOXHIDE.Name = "PBOXHIDE"
        Me.PBOXHIDE.Size = New System.Drawing.Size(67, 33)
        Me.PBOXHIDE.TabIndex = 81
        Me.PBOXHIDE.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.C_M_V_A_SYTEM.My.Resources.Resources.password_icon
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(16, 273)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(45, 40)
        Me.PictureBox3.TabIndex = 80
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.C_M_V_A_SYTEM.My.Resources.Resources.username_icon
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(16, 208)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 40)
        Me.PictureBox2.TabIndex = 79
        Me.PictureBox2.TabStop = False
        '
        'BTNLOGIN
        '
        Me.BTNLOGIN.BackColor = System.Drawing.Color.Black
        Me.BTNLOGIN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNLOGIN.Font = New System.Drawing.Font("Algerian", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLOGIN.ForeColor = System.Drawing.Color.White
        Me.BTNLOGIN.Location = New System.Drawing.Point(108, 494)
        Me.BTNLOGIN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNLOGIN.Name = "BTNLOGIN"
        Me.BTNLOGIN.Size = New System.Drawing.Size(100, 68)
        Me.BTNLOGIN.TabIndex = 77
        Me.BTNLOGIN.Text = "LOGIN"
        Me.BTNLOGIN.UseVisualStyleBackColor = False
        '
        'TXTPASS
        '
        Me.TXTPASS.BackColor = System.Drawing.Color.GhostWhite
        Me.TXTPASS.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPASS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXTPASS.Location = New System.Drawing.Point(285, 271)
        Me.TXTPASS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXTPASS.Name = "TXTPASS"
        Me.TXTPASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPASS.Size = New System.Drawing.Size(251, 39)
        Me.TXTPASS.TabIndex = 76
        '
        'TXTUSER
        '
        Me.TXTUSER.BackColor = System.Drawing.Color.GhostWhite
        Me.TXTUSER.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUSER.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TXTUSER.Location = New System.Drawing.Point(285, 208)
        Me.TXTUSER.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXTUSER.Name = "TXTUSER"
        Me.TXTUSER.Size = New System.Drawing.Size(251, 39)
        Me.TXTUSER.TabIndex = 75
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(83, 270)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 34)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(83, 208)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 34)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "USERNAME"
        '
        'TimerFadeIn
        '
        '
        'TimerFadeOut
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Algerian", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(929, 418)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 41)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "TIME"
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.C_M_V_A_SYTEM.My.Resources.Resources.cars1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1077, 583)
        Me.Controls.Add(Me.PBOXVIEW)
        Me.Controls.Add(Me.BTNCLEAR)
        Me.Controls.Add(Me.PBOXHIDE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.BTNEXIT)
        Me.Controls.Add(Me.TXTPASS)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LBLPCNT)
        Me.Controls.Add(Me.TXTUSER)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.BTNLOGIN)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "LOGIN"
        Me.Opacity = 0.01R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "+"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBOXVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBOXHIDE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LBLPCNT As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents PBOXVIEW As System.Windows.Forms.PictureBox
    Friend WithEvents PBOXHIDE As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BTNLOGIN As System.Windows.Forms.Button
    Friend WithEvents TXTPASS As System.Windows.Forms.TextBox
    Friend WithEvents TXTUSER As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TimerFadeIn As System.Windows.Forms.Timer
    Friend WithEvents TimerFadeOut As System.Windows.Forms.Timer
    Friend WithEvents BTNEXIT As System.Windows.Forms.Button
    Friend WithEvents BTNCLEAR As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
