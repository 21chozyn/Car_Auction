<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPLASH_SCREEN
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TimerFadeIn = New System.Windows.Forms.Timer(Me.components)
        Me.TimerFadeOut = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureCar = New System.Windows.Forms.PictureBox()
        Me.TimerCarPosn = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.C_M_V_A_SYTEM.My.Resources.Resources.logo_2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 137)
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'TimerFadeIn
        '
        Me.TimerFadeIn.Interval = 1
        '
        'TimerFadeOut
        '
        Me.TimerFadeOut.Interval = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.C_M_V_A_SYTEM.My.Resources.Resources.MarriedMarvelousHawaiianmonkseal_small
        Me.PictureBox2.Location = New System.Drawing.Point(407, 128)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(115, 90)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 64
        Me.PictureBox2.TabStop = False
        '
        'PictureCar
        '
        Me.PictureCar.BackColor = System.Drawing.Color.Transparent
        Me.PictureCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureCar.Image = Global.C_M_V_A_SYTEM.My.Resources.Resources.f719d207aee6e1db9f15cac81c1bd59ca7856ccb
        Me.PictureCar.Location = New System.Drawing.Point(3, 257)
        Me.PictureCar.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureCar.Name = "PictureCar"
        Me.PictureCar.Size = New System.Drawing.Size(148, 55)
        Me.PictureCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureCar.TabIndex = 65
        Me.PictureCar.TabStop = False
        '
        'TimerCarPosn
        '
        Me.TimerCarPosn.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(103, 164)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 16)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "PLEASE WAIT WHILE SYSTEM LOADS ..."
        '
        'SPLASH_SCREEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.C_M_V_A_SYTEM.My.Resources.Resources.Auction1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(664, 355)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureCar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SPLASH_SCREEN"
        Me.Opacity = 0.01R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLIENTS_FORM"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TimerFadeIn As System.Windows.Forms.Timer
    Friend WithEvents TimerFadeOut As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureCar As System.Windows.Forms.PictureBox
    Friend WithEvents TimerCarPosn As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
