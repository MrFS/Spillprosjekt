<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.gameplay = New System.Windows.Forms.Timer(Me.components)
        Me.pnlPause = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pxPlat1 = New System.Windows.Forms.PictureBox()
        Me.pxCoffee1 = New System.Windows.Forms.PictureBox()
        Me.pxKis = New System.Windows.Forms.PictureBox()
        Me.pxGround = New System.Windows.Forms.PictureBox()
        Me.pxPlat2 = New System.Windows.Forms.PictureBox()
        Me.pxPlat3 = New System.Windows.Forms.PictureBox()
        Me.pxPlatBounds1 = New System.Windows.Forms.PictureBox()
        Me.pxPlatBounds2 = New System.Windows.Forms.PictureBox()
        Me.pxPlatBounds3 = New System.Windows.Forms.PictureBox()
        Me.rBound = New System.Windows.Forms.PictureBox()
        Me.lBound = New System.Windows.Forms.PictureBox()
        Me.pxPlatBounds4 = New System.Windows.Forms.PictureBox()
        Me.pxPlatBounds5 = New System.Windows.Forms.PictureBox()
        Me.pxPlat4 = New System.Windows.Forms.PictureBox()
        Me.pxPLat5 = New System.Windows.Forms.PictureBox()
        Me.pxPlat6 = New System.Windows.Forms.PictureBox()
        Me.pxPlat7 = New System.Windows.Forms.PictureBox()
        Me.pxPlatBounds6 = New System.Windows.Forms.PictureBox()
        Me.pxPlatBounds7 = New System.Windows.Forms.PictureBox()
        Me.pxCoffee5 = New System.Windows.Forms.PictureBox()
        Me.pxCoffee4 = New System.Windows.Forms.PictureBox()
        Me.pxCoffee3 = New System.Windows.Forms.PictureBox()
        Me.pxCoffee2 = New System.Windows.Forms.PictureBox()
        Me.pxVictory = New System.Windows.Forms.PictureBox()
        Me.pnlPause.SuspendLayout()
        CType(Me.pxPlat1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxCoffee1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxKis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPlat2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPlat3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPlatBounds1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPlatBounds2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPlatBounds3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rBound, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lBound, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPlatBounds4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPlatBounds5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPlat4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPLat5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPlat6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPlat7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPlatBounds6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPlatBounds7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxCoffee5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxCoffee4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxCoffee3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxCoffee2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxVictory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gameplay
        '
        Me.gameplay.Enabled = True
        Me.gameplay.Interval = 1
        '
        'pnlPause
        '
        Me.pnlPause.BackColor = System.Drawing.Color.Transparent
        Me.pnlPause.BackgroundImage = Global.Spill.My.Resources.Resources.pausebg
        Me.pnlPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlPause.Controls.Add(Me.Label3)
        Me.pnlPause.Controls.Add(Me.Label2)
        Me.pnlPause.Controls.Add(Me.Label1)
        Me.pnlPause.Location = New System.Drawing.Point(418, 272)
        Me.pnlPause.Name = "pnlPause"
        Me.pnlPause.Size = New System.Drawing.Size(381, 337)
        Me.pnlPause.TabIndex = 3
        Me.pnlPause.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Exit To Menu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sett&ings"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Resume Game"
        '
        'pxPlat1
        '
        Me.pxPlat1.BackColor = System.Drawing.Color.DarkRed
        Me.pxPlat1.BackgroundImage = Global.Spill.My.Resources.Resources.platform
        Me.pxPlat1.Location = New System.Drawing.Point(280, 737)
        Me.pxPlat1.Name = "pxPlat1"
        Me.pxPlat1.Size = New System.Drawing.Size(112, 22)
        Me.pxPlat1.TabIndex = 4
        Me.pxPlat1.TabStop = False
        '
        'pxCoffee1
        '
        Me.pxCoffee1.BackColor = System.Drawing.Color.Transparent
        Me.pxCoffee1.BackgroundImage = Global.Spill.My.Resources.Resources.coffee
        Me.pxCoffee1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pxCoffee1.Location = New System.Drawing.Point(326, 689)
        Me.pxCoffee1.Name = "pxCoffee1"
        Me.pxCoffee1.Size = New System.Drawing.Size(36, 40)
        Me.pxCoffee1.TabIndex = 2
        Me.pxCoffee1.TabStop = False
        '
        'pxKis
        '
        Me.pxKis.BackColor = System.Drawing.Color.Transparent
        Me.pxKis.Image = Global.Spill.My.Resources.Resources.pxKis
        Me.pxKis.Location = New System.Drawing.Point(39, 780)
        Me.pxKis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pxKis.Name = "pxKis"
        Me.pxKis.Size = New System.Drawing.Size(60, 74)
        Me.pxKis.TabIndex = 0
        Me.pxKis.TabStop = False
        Me.pxKis.Visible = False
        '
        'pxGround
        '
        Me.pxGround.BackColor = System.Drawing.Color.Transparent
        Me.pxGround.BackgroundImage = Global.Spill.My.Resources.Resources.platform
        Me.pxGround.Location = New System.Drawing.Point(-2, 880)
        Me.pxGround.Name = "pxGround"
        Me.pxGround.Size = New System.Drawing.Size(1202, 43)
        Me.pxGround.TabIndex = 1
        Me.pxGround.TabStop = False
        '
        'pxPlat2
        '
        Me.pxPlat2.BackColor = System.Drawing.Color.DarkRed
        Me.pxPlat2.BackgroundImage = Global.Spill.My.Resources.Resources.platform
        Me.pxPlat2.Location = New System.Drawing.Point(546, 737)
        Me.pxPlat2.Name = "pxPlat2"
        Me.pxPlat2.Size = New System.Drawing.Size(112, 28)
        Me.pxPlat2.TabIndex = 5
        Me.pxPlat2.TabStop = False
        '
        'pxPlat3
        '
        Me.pxPlat3.BackColor = System.Drawing.Color.DarkRed
        Me.pxPlat3.BackgroundImage = Global.Spill.My.Resources.Resources.platform
        Me.pxPlat3.Location = New System.Drawing.Point(855, 689)
        Me.pxPlat3.Name = "pxPlat3"
        Me.pxPlat3.Size = New System.Drawing.Size(112, 23)
        Me.pxPlat3.TabIndex = 6
        Me.pxPlat3.TabStop = False
        '
        'pxPlatBounds1
        '
        Me.pxPlatBounds1.Location = New System.Drawing.Point(296, 734)
        Me.pxPlatBounds1.Name = "pxPlatBounds1"
        Me.pxPlatBounds1.Size = New System.Drawing.Size(84, 6)
        Me.pxPlatBounds1.TabIndex = 9
        Me.pxPlatBounds1.TabStop = False
        '
        'pxPlatBounds2
        '
        Me.pxPlatBounds2.Location = New System.Drawing.Point(562, 737)
        Me.pxPlatBounds2.Name = "pxPlatBounds2"
        Me.pxPlatBounds2.Size = New System.Drawing.Size(84, 6)
        Me.pxPlatBounds2.TabIndex = 10
        Me.pxPlatBounds2.TabStop = False
        '
        'pxPlatBounds3
        '
        Me.pxPlatBounds3.Location = New System.Drawing.Point(872, 689)
        Me.pxPlatBounds3.Name = "pxPlatBounds3"
        Me.pxPlatBounds3.Size = New System.Drawing.Size(84, 6)
        Me.pxPlatBounds3.TabIndex = 11
        Me.pxPlatBounds3.TabStop = False
        '
        'rBound
        '
        Me.rBound.BackColor = System.Drawing.Color.Transparent
        Me.rBound.Location = New System.Drawing.Point(1194, 0)
        Me.rBound.Name = "rBound"
        Me.rBound.Size = New System.Drawing.Size(6, 865)
        Me.rBound.TabIndex = 12
        Me.rBound.TabStop = False
        '
        'lBound
        '
        Me.lBound.BackColor = System.Drawing.Color.Transparent
        Me.lBound.Location = New System.Drawing.Point(0, 0)
        Me.lBound.Name = "lBound"
        Me.lBound.Size = New System.Drawing.Size(6, 865)
        Me.lBound.TabIndex = 13
        Me.lBound.TabStop = False
        '
        'pxPlatBounds4
        '
        Me.pxPlatBounds4.Location = New System.Drawing.Point(1113, 558)
        Me.pxPlatBounds4.Name = "pxPlatBounds4"
        Me.pxPlatBounds4.Size = New System.Drawing.Size(78, 12)
        Me.pxPlatBounds4.TabIndex = 14
        Me.pxPlatBounds4.TabStop = False
        '
        'pxPlatBounds5
        '
        Me.pxPlatBounds5.Location = New System.Drawing.Point(795, 431)
        Me.pxPlatBounds5.Name = "pxPlatBounds5"
        Me.pxPlatBounds5.Size = New System.Drawing.Size(76, 6)
        Me.pxPlatBounds5.TabIndex = 15
        Me.pxPlatBounds5.TabStop = False
        '
        'pxPlat4
        '
        Me.pxPlat4.BackColor = System.Drawing.Color.DarkRed
        Me.pxPlat4.BackgroundImage = Global.Spill.My.Resources.Resources.platform
        Me.pxPlat4.Location = New System.Drawing.Point(1088, 563)
        Me.pxPlat4.Name = "pxPlat4"
        Me.pxPlat4.Size = New System.Drawing.Size(112, 23)
        Me.pxPlat4.TabIndex = 16
        Me.pxPlat4.TabStop = False
        '
        'pxPLat5
        '
        Me.pxPLat5.BackColor = System.Drawing.Color.DarkRed
        Me.pxPLat5.BackgroundImage = Global.Spill.My.Resources.Resources.platform
        Me.pxPLat5.Location = New System.Drawing.Point(776, 435)
        Me.pxPLat5.Name = "pxPLat5"
        Me.pxPLat5.Size = New System.Drawing.Size(112, 23)
        Me.pxPLat5.TabIndex = 17
        Me.pxPLat5.TabStop = False
        '
        'pxPlat6
        '
        Me.pxPlat6.BackColor = System.Drawing.Color.DarkRed
        Me.pxPlat6.BackgroundImage = Global.Spill.My.Resources.Resources.platform
        Me.pxPlat6.Location = New System.Drawing.Point(434, 435)
        Me.pxPlat6.Name = "pxPlat6"
        Me.pxPlat6.Size = New System.Drawing.Size(112, 23)
        Me.pxPlat6.TabIndex = 18
        Me.pxPlat6.TabStop = False
        '
        'pxPlat7
        '
        Me.pxPlat7.BackColor = System.Drawing.Color.DarkRed
        Me.pxPlat7.BackgroundImage = Global.Spill.My.Resources.Resources.platform
        Me.pxPlat7.Location = New System.Drawing.Point(132, 277)
        Me.pxPlat7.Name = "pxPlat7"
        Me.pxPlat7.Size = New System.Drawing.Size(112, 23)
        Me.pxPlat7.TabIndex = 19
        Me.pxPlat7.TabStop = False
        '
        'pxPlatBounds6
        '
        Me.pxPlatBounds6.Location = New System.Drawing.Point(454, 431)
        Me.pxPlatBounds6.Name = "pxPlatBounds6"
        Me.pxPlatBounds6.Size = New System.Drawing.Size(68, 6)
        Me.pxPlatBounds6.TabIndex = 20
        Me.pxPlatBounds6.TabStop = False
        '
        'pxPlatBounds7
        '
        Me.pxPlatBounds7.Location = New System.Drawing.Point(158, 272)
        Me.pxPlatBounds7.Name = "pxPlatBounds7"
        Me.pxPlatBounds7.Size = New System.Drawing.Size(57, 6)
        Me.pxPlatBounds7.TabIndex = 21
        Me.pxPlatBounds7.TabStop = False
        '
        'pxCoffee5
        '
        Me.pxCoffee5.BackColor = System.Drawing.Color.Transparent
        Me.pxCoffee5.BackgroundImage = Global.Spill.My.Resources.Resources.coffee
        Me.pxCoffee5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pxCoffee5.Location = New System.Drawing.Point(472, 388)
        Me.pxCoffee5.Name = "pxCoffee5"
        Me.pxCoffee5.Size = New System.Drawing.Size(36, 40)
        Me.pxCoffee5.TabIndex = 22
        Me.pxCoffee5.TabStop = False
        '
        'pxCoffee4
        '
        Me.pxCoffee4.BackColor = System.Drawing.Color.Transparent
        Me.pxCoffee4.BackgroundImage = Global.Spill.My.Resources.Resources.coffee
        Me.pxCoffee4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pxCoffee4.Location = New System.Drawing.Point(807, 383)
        Me.pxCoffee4.Name = "pxCoffee4"
        Me.pxCoffee4.Size = New System.Drawing.Size(36, 40)
        Me.pxCoffee4.TabIndex = 23
        Me.pxCoffee4.TabStop = False
        '
        'pxCoffee3
        '
        Me.pxCoffee3.BackColor = System.Drawing.Color.Transparent
        Me.pxCoffee3.BackgroundImage = Global.Spill.My.Resources.Resources.coffee
        Me.pxCoffee3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pxCoffee3.Location = New System.Drawing.Point(886, 642)
        Me.pxCoffee3.Name = "pxCoffee3"
        Me.pxCoffee3.Size = New System.Drawing.Size(36, 40)
        Me.pxCoffee3.TabIndex = 24
        Me.pxCoffee3.TabStop = False
        '
        'pxCoffee2
        '
        Me.pxCoffee2.BackColor = System.Drawing.Color.Transparent
        Me.pxCoffee2.BackgroundImage = Global.Spill.My.Resources.Resources.coffee
        Me.pxCoffee2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pxCoffee2.Location = New System.Drawing.Point(582, 689)
        Me.pxCoffee2.Name = "pxCoffee2"
        Me.pxCoffee2.Size = New System.Drawing.Size(36, 40)
        Me.pxCoffee2.TabIndex = 25
        Me.pxCoffee2.TabStop = False
        '
        'pxVictory
        '
        Me.pxVictory.BackColor = System.Drawing.Color.Transparent
        Me.pxVictory.BackgroundImage = Global.Spill.My.Resources.Resources._07
        Me.pxVictory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pxVictory.Location = New System.Drawing.Point(153, 203)
        Me.pxVictory.Name = "pxVictory"
        Me.pxVictory.Size = New System.Drawing.Size(66, 66)
        Me.pxVictory.TabIndex = 26
        Me.pxVictory.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Spill.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1200, 923)
        Me.Controls.Add(Me.pnlPause)
        Me.Controls.Add(Me.pxVictory)
        Me.Controls.Add(Me.pxCoffee2)
        Me.Controls.Add(Me.pxCoffee3)
        Me.Controls.Add(Me.pxCoffee4)
        Me.Controls.Add(Me.pxCoffee5)
        Me.Controls.Add(Me.pxPlatBounds7)
        Me.Controls.Add(Me.pxPlatBounds6)
        Me.Controls.Add(Me.pxPlat7)
        Me.Controls.Add(Me.pxPlat6)
        Me.Controls.Add(Me.pxPLat5)
        Me.Controls.Add(Me.pxPlat4)
        Me.Controls.Add(Me.pxPlatBounds5)
        Me.Controls.Add(Me.pxPlatBounds4)
        Me.Controls.Add(Me.lBound)
        Me.Controls.Add(Me.rBound)
        Me.Controls.Add(Me.pxPlatBounds3)
        Me.Controls.Add(Me.pxPlatBounds2)
        Me.Controls.Add(Me.pxPlatBounds1)
        Me.Controls.Add(Me.pxPlat3)
        Me.Controls.Add(Me.pxPlat2)
        Me.Controls.Add(Me.pxPlat1)
        Me.Controls.Add(Me.pxCoffee1)
        Me.Controls.Add(Me.pxKis)
        Me.Controls.Add(Me.pxGround)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2D Platformer Team Trøtt"
        Me.pnlPause.ResumeLayout(False)
        Me.pnlPause.PerformLayout()
        CType(Me.pxPlat1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxCoffee1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxKis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPlat2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPlat3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPlatBounds1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPlatBounds2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPlatBounds3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rBound, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lBound, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPlatBounds4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPlatBounds5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPlat4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPLat5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPlat6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPlat7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPlatBounds6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPlatBounds7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxCoffee5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxCoffee4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxCoffee3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxCoffee2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxVictory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pxKis As System.Windows.Forms.PictureBox
    Friend WithEvents gameplay As System.Windows.Forms.Timer
    Friend WithEvents pxGround As PictureBox
    Friend WithEvents pxCoffee1 As PictureBox
    Friend WithEvents pnlPause As Panel
    Friend WithEvents pxPlat1 As PictureBox
    Friend WithEvents pxPlat2 As PictureBox
    Friend WithEvents pxPlat3 As PictureBox
    Friend WithEvents pxPlatBounds1 As PictureBox
    Friend WithEvents pxPlatBounds2 As PictureBox
    Friend WithEvents pxPlatBounds3 As PictureBox
    Friend WithEvents rBound As PictureBox
    Friend WithEvents lBound As PictureBox
    Friend WithEvents pxPlatBounds4 As PictureBox
    Friend WithEvents pxPlatBounds5 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pxPlat4 As PictureBox
    Friend WithEvents pxPLat5 As PictureBox
    Friend WithEvents pxPlat6 As PictureBox
    Friend WithEvents pxPlat7 As PictureBox
    Friend WithEvents pxPlatBounds6 As PictureBox
    Friend WithEvents pxPlatBounds7 As PictureBox
    Friend WithEvents pxCoffee5 As PictureBox
    Friend WithEvents pxCoffee4 As PictureBox
    Friend WithEvents pxCoffee3 As PictureBox
    Friend WithEvents pxCoffee2 As PictureBox
    Friend WithEvents pxVictory As PictureBox
End Class
