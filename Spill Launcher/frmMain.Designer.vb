<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.gameplay = New System.Windows.Forms.Timer(Me.components)
        Me.pnlPause = New System.Windows.Forms.Panel()
        Me.btnExitMMnu = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnResume = New System.Windows.Forms.Button()
        Me.pxSnus = New System.Windows.Forms.PictureBox()
        Me.pxCoffee = New System.Windows.Forms.PictureBox()
        Me.pxKis = New System.Windows.Forms.PictureBox()
        Me.pxGround = New System.Windows.Forms.PictureBox()
        Me.pnlPause.SuspendLayout()
        CType(Me.pxSnus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxCoffee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxKis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxGround, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlPause.Size = New System.Drawing.Size(242, 182)
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
        'pxSnus
        '
        Me.pxSnus.BackColor = System.Drawing.Color.DarkRed
        Me.pxSnus.BackgroundImage = Global.Spill.My.Resources.Resources.platform
        Me.pxSnus.Location = New System.Drawing.Point(511, 635)
        Me.pxSnus.Name = "pxSnus"
        Me.pxSnus.Size = New System.Drawing.Size(100, 32)
        Me.pxSnus.TabIndex = 4
        Me.pxSnus.TabStop = False
        '
        'pxCoffee
        '
        Me.pxCoffee.BackColor = System.Drawing.Color.Transparent
        Me.pxCoffee.BackgroundImage = Global.Spill.My.Resources.Resources.coffee
        Me.pxCoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pxCoffee.Location = New System.Drawing.Point(551, 597)
        Me.pxCoffee.Name = "pxCoffee"
        Me.pxCoffee.Size = New System.Drawing.Size(32, 32)
        Me.pxCoffee.TabIndex = 2
        Me.pxCoffee.TabStop = False
        '
        'pxKis
        '
        Me.pxKis.BackColor = System.Drawing.Color.Transparent
        Me.pxKis.Image = Global.Spill.My.Resources.Resources.lucas
        Me.pxKis.Location = New System.Drawing.Point(13, 645)
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
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Spill.My.Resources.Resources.bg_lvl1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1067, 738)
        Me.Controls.Add(Me.pxSnus)
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
        CType(Me.pxSnus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxCoffee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxKis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxGround, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pxSnus As PictureBox
End Class
