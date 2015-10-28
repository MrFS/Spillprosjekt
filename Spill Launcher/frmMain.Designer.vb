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
        Me.btnExitMMnu = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnResume = New System.Windows.Forms.Button()
        Me.pxPlat1 = New System.Windows.Forms.PictureBox()
        Me.pxCoffee = New System.Windows.Forms.PictureBox()
        Me.pxKis = New System.Windows.Forms.PictureBox()
        Me.pxGround = New System.Windows.Forms.PictureBox()
        Me.pxPlat2 = New System.Windows.Forms.PictureBox()
        Me.pxPlat3 = New System.Windows.Forms.PictureBox()
        Me.pxPlatBounds1 = New System.Windows.Forms.PictureBox()
        Me.pxPlatBounds2 = New System.Windows.Forms.PictureBox()
        Me.pxPlatBounds3 = New System.Windows.Forms.PictureBox()
        Me.tGrav = New System.Windows.Forms.Timer(Me.components)
        Me.rBound = New System.Windows.Forms.PictureBox()
        Me.lBound = New System.Windows.Forms.PictureBox()
        Me.pxPlatBounds4 = New System.Windows.Forms.PictureBox()
        Me.pxPlatBounds5 = New System.Windows.Forms.PictureBox()
        Me.pnlPause.SuspendLayout()
        CType(Me.pxPlat1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxCoffee, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuspendLayout()
        '
        'gameplay
        '
        Me.gameplay.Enabled = True
        Me.gameplay.Interval = 10
        '
        'pnlPause
        '
        Me.pnlPause.BackColor = System.Drawing.SystemColors.HotTrack
        Me.pnlPause.Controls.Add(Me.btnExitMMnu)
        Me.pnlPause.Controls.Add(Me.btnSettings)
        Me.pnlPause.Controls.Add(Me.Button1)
        Me.pnlPause.Controls.Add(Me.btnResume)
        Me.pnlPause.Location = New System.Drawing.Point(344, 153)
        Me.pnlPause.Name = "pnlPause"
        Me.pnlPause.Size = New System.Drawing.Size(339, 270)
        Me.pnlPause.TabIndex = 3
        Me.pnlPause.Visible = False
        '
        'btnExitMMnu
        '
        Me.btnExitMMnu.FlatAppearance.BorderSize = 0
        Me.btnExitMMnu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExitMMnu.Location = New System.Drawing.Point(3, 138)
        Me.btnExitMMnu.Name = "btnExitMMnu"
        Me.btnExitMMnu.Size = New System.Drawing.Size(236, 39)
        Me.btnExitMMnu.TabIndex = 3
        Me.btnExitMMnu.Text = "Exit to main menu"
        Me.btnExitMMnu.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSettings.Location = New System.Drawing.Point(3, 93)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(236, 39)
        Me.btnSettings.TabIndex = 2
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(3, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(236, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = " "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnResume
        '
        Me.btnResume.FlatAppearance.BorderSize = 0
        Me.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnResume.Location = New System.Drawing.Point(3, 3)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(236, 39)
        Me.btnResume.TabIndex = 0
        Me.btnResume.Text = "Resume game"
        Me.btnResume.UseVisualStyleBackColor = True
        '
        'pxPlat1
        '
        Me.pxPlat1.BackColor = System.Drawing.Color.DarkRed
        Me.pxPlat1.BackgroundImage = Global.Spill.My.Resources.Resources.platform
        Me.pxPlat1.Location = New System.Drawing.Point(249, 589)
        Me.pxPlat1.Name = "pxPlat1"
        Me.pxPlat1.Size = New System.Drawing.Size(100, 17)
        Me.pxPlat1.TabIndex = 4
        Me.pxPlat1.TabStop = False
        '
        'pxCoffee
        '
        Me.pxCoffee.BackColor = System.Drawing.Color.Transparent
        Me.pxCoffee.BackgroundImage = Global.Spill.My.Resources.Resources.coffee
        Me.pxCoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pxCoffee.Location = New System.Drawing.Point(289, 551)
        Me.pxCoffee.Name = "pxCoffee"
        Me.pxCoffee.Size = New System.Drawing.Size(32, 32)
        Me.pxCoffee.TabIndex = 2
        Me.pxCoffee.TabStop = False
        '
        'pxKis
        '
        Me.pxKis.BackColor = System.Drawing.Color.Transparent
        Me.pxKis.Image = Global.Spill.My.Resources.Resources.pxKis
        Me.pxKis.Location = New System.Drawing.Point(34, 624)
        Me.pxKis.Margin = New System.Windows.Forms.Padding(4)
        Me.pxKis.Name = "pxKis"
        Me.pxKis.Size = New System.Drawing.Size(53, 59)
        Me.pxKis.TabIndex = 0
        Me.pxKis.TabStop = False
        Me.pxKis.Visible = False
        '
        'pxGround
        '
        Me.pxGround.BackColor = System.Drawing.Color.Transparent
        Me.pxGround.BackgroundImage = Global.Spill.My.Resources.Resources.platform
        Me.pxGround.Location = New System.Drawing.Point(-1, 704)
        Me.pxGround.Name = "pxGround"
        Me.pxGround.Size = New System.Drawing.Size(1068, 35)
        Me.pxGround.TabIndex = 1
        Me.pxGround.TabStop = False
        '
        'pxPlat2
        '
        Me.pxPlat2.BackColor = System.Drawing.Color.DarkRed
        Me.pxPlat2.BackgroundImage = Global.Spill.My.Resources.Resources.platform
        Me.pxPlat2.Location = New System.Drawing.Point(486, 589)
        Me.pxPlat2.Name = "pxPlat2"
        Me.pxPlat2.Size = New System.Drawing.Size(100, 22)
        Me.pxPlat2.TabIndex = 5
        Me.pxPlat2.TabStop = False
        '
        'pxPlat3
        '
        Me.pxPlat3.BackColor = System.Drawing.Color.DarkRed
        Me.pxPlat3.BackgroundImage = Global.Spill.My.Resources.Resources.platform
        Me.pxPlat3.Location = New System.Drawing.Point(760, 551)
        Me.pxPlat3.Name = "pxPlat3"
        Me.pxPlat3.Size = New System.Drawing.Size(100, 18)
        Me.pxPlat3.TabIndex = 6
        Me.pxPlat3.TabStop = False
        '
        'pxPlatBounds1
        '
        Me.pxPlatBounds1.Location = New System.Drawing.Point(263, 587)
        Me.pxPlatBounds1.Name = "pxPlatBounds1"
        Me.pxPlatBounds1.Size = New System.Drawing.Size(75, 5)
        Me.pxPlatBounds1.TabIndex = 9
        Me.pxPlatBounds1.TabStop = False
        '
        'pxPlatBounds2
        '
        Me.pxPlatBounds2.Location = New System.Drawing.Point(500, 589)
        Me.pxPlatBounds2.Name = "pxPlatBounds2"
        Me.pxPlatBounds2.Size = New System.Drawing.Size(75, 5)
        Me.pxPlatBounds2.TabIndex = 10
        Me.pxPlatBounds2.TabStop = False
        '
        'pxPlatBounds3
        '
        Me.pxPlatBounds3.Location = New System.Drawing.Point(775, 551)
        Me.pxPlatBounds3.Name = "pxPlatBounds3"
        Me.pxPlatBounds3.Size = New System.Drawing.Size(75, 5)
        Me.pxPlatBounds3.TabIndex = 11
        Me.pxPlatBounds3.TabStop = False
        '
        'tGrav
        '
        Me.tGrav.Enabled = True
        Me.tGrav.Interval = 10
        '
        'rBound
        '
        Me.rBound.BackColor = System.Drawing.Color.Transparent
        Me.rBound.Location = New System.Drawing.Point(1062, 0)
        Me.rBound.Name = "rBound"
        Me.rBound.Size = New System.Drawing.Size(5, 692)
        Me.rBound.TabIndex = 12
        Me.rBound.TabStop = False
        '
        'lBound
        '
        Me.lBound.BackColor = System.Drawing.Color.Transparent
        Me.lBound.Location = New System.Drawing.Point(0, 0)
        Me.lBound.Name = "lBound"
        Me.lBound.Size = New System.Drawing.Size(5, 692)
        Me.lBound.TabIndex = 13
        Me.lBound.TabStop = False
        '
        'pxPlatBounds4
        '
        Me.pxPlatBounds4.Location = New System.Drawing.Point(955, 447)
        Me.pxPlatBounds4.Name = "pxPlatBounds4"
        Me.pxPlatBounds4.Size = New System.Drawing.Size(100, 10)
        Me.pxPlatBounds4.TabIndex = 14
        Me.pxPlatBounds4.TabStop = False
        '
        'pxPlatBounds5
        '
        Me.pxPlatBounds5.Location = New System.Drawing.Point(689, 336)
        Me.pxPlatBounds5.Name = "pxPlatBounds5"
        Me.pxPlatBounds5.Size = New System.Drawing.Size(100, 10)
        Me.pxPlatBounds5.TabIndex = 15
        Me.pxPlatBounds5.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Spill.My.Resources.Resources.bg_lvl1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1067, 738)
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
        Me.Controls.Add(Me.pnlPause)
        Me.Controls.Add(Me.pxCoffee)
        Me.Controls.Add(Me.pxKis)
        Me.Controls.Add(Me.pxGround)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2D Platformer Team Trøtt"
        Me.pnlPause.ResumeLayout(False)
        CType(Me.pxPlat1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxCoffee, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pxKis As System.Windows.Forms.PictureBox
    Friend WithEvents gameplay As System.Windows.Forms.Timer
    Friend WithEvents pxGround As PictureBox
    Friend WithEvents pxCoffee As PictureBox
    Friend WithEvents pnlPause As Panel
    Friend WithEvents btnResume As Button
    Friend WithEvents btnExitMMnu As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pxPlat1 As PictureBox
    Friend WithEvents pxPlat2 As PictureBox
    Friend WithEvents pxPlat3 As PictureBox
    Friend WithEvents pxPlatBounds1 As PictureBox
    Friend WithEvents pxPlatBounds2 As PictureBox
    Friend WithEvents pxPlatBounds3 As PictureBox
    Friend WithEvents tGrav As Timer
    Friend WithEvents rBound As PictureBox
    Friend WithEvents lBound As PictureBox
    Friend WithEvents pxPlatBounds4 As PictureBox
    Friend WithEvents pxPlatBounds5 As PictureBox
End Class
