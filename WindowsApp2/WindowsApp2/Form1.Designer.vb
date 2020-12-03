<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bullet = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.alien2 = New System.Windows.Forms.PictureBox()
        Me.alien5 = New System.Windows.Forms.PictureBox()
        Me.alien6 = New System.Windows.Forms.PictureBox()
        Me.alien7 = New System.Windows.Forms.PictureBox()
        CType(Me.bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bullet
        '
        Me.bullet.BackColor = System.Drawing.Color.Transparent
        Me.bullet.Image = Global.WindowsApp2.My.Resources.Resources.my_game_bullet__2_
        Me.bullet.Location = New System.Drawing.Point(474, 447)
        Me.bullet.Name = "bullet"
        Me.bullet.Size = New System.Drawing.Size(47, 48)
        Me.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bullet.TabIndex = 8
        Me.bullet.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApp2.My.Resources.Resources.starter_ship__1_
        Me.PictureBox1.Location = New System.Drawing.Point(318, 339)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Timer2
        '
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.WindowsApp2.My.Resources.Resources.nruhhhhhhhhhhhhhhhhh
        Me.PictureBox4.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 10)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'alien2
        '
        Me.alien2.BackColor = System.Drawing.Color.Transparent
        Me.alien2.Image = Global.WindowsApp2.My.Resources.Resources.my_game_3
        Me.alien2.Location = New System.Drawing.Point(234, 47)
        Me.alien2.Name = "alien2"
        Me.alien2.Size = New System.Drawing.Size(71, 59)
        Me.alien2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien2.TabIndex = 13
        Me.alien2.TabStop = False
        '
        'alien5
        '
        Me.alien5.BackColor = System.Drawing.Color.Transparent
        Me.alien5.Image = Global.WindowsApp2.My.Resources.Resources.my_game_3
        Me.alien5.Location = New System.Drawing.Point(429, 94)
        Me.alien5.Name = "alien5"
        Me.alien5.Size = New System.Drawing.Size(70, 60)
        Me.alien5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien5.TabIndex = 14
        Me.alien5.TabStop = False
        '
        'alien6
        '
        Me.alien6.BackColor = System.Drawing.Color.Transparent
        Me.alien6.Image = Global.WindowsApp2.My.Resources.Resources.my_game_3
        Me.alien6.Location = New System.Drawing.Point(78, 221)
        Me.alien6.Name = "alien6"
        Me.alien6.Size = New System.Drawing.Size(71, 59)
        Me.alien6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien6.TabIndex = 15
        Me.alien6.TabStop = False
        '
        'alien7
        '
        Me.alien7.BackColor = System.Drawing.Color.Transparent
        Me.alien7.Image = Global.WindowsApp2.My.Resources.Resources.my_game_3
        Me.alien7.Location = New System.Drawing.Point(642, 169)
        Me.alien7.Name = "alien7"
        Me.alien7.Size = New System.Drawing.Size(71, 59)
        Me.alien7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien7.TabIndex = 16
        Me.alien7.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.WindowsApp2.My.Resources.Resources.klmjhufgbjk_hm
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.alien7)
        Me.Controls.Add(Me.alien6)
        Me.Controls.Add(Me.alien5)
        Me.Controls.Add(Me.alien2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bullet)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "d"
        CType(Me.bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents bullet As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents alien2 As PictureBox
    Friend WithEvents alien5 As PictureBox
    Friend WithEvents alien6 As PictureBox
    Friend WithEvents alien7 As PictureBox
End Class
