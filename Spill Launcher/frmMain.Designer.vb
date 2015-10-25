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
        Me.pxCoffee = New System.Windows.Forms.PictureBox()
        Me.pxKis = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlPause = New System.Windows.Forms.Panel()
        Me.btnResume = New System.Windows.Forms.Button()
        CType(Me.pxCoffee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxKis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPause.SuspendLayout()
        Me.SuspendLayout()
        '
        'gameplay
        '
        Me.gameplay.Enabled = True
        Me.gameplay.Interval = 10
        '
        'pxCoffee
        '
        Me.pxCoffee.BackColor = System.Drawing.Color.Transparent
        Me.pxCoffee.Image = Global.Spill.My.Resources.Resources.coffee
        Me.pxCoffee.Location = New System.Drawing.Point(885, 494)
        Me.pxCoffee.Name = "pxCoffee"
        Me.pxCoffee.Size = New System.Drawing.Size(159, 200)
        Me.pxCoffee.TabIndex = 2
        Me.pxCoffee.TabStop = False
        '
        'pxKis
        '
        Me.pxKis.BackColor = System.Drawing.Color.Transparent
        Me.pxKis.Image = Global.Spill.My.Resources.Resources.lucas
        Me.pxKis.Location = New System.Drawing.Point(13, 635)
        Me.pxKis.Margin = New System.Windows.Forms.Padding(4)
        Me.pxKis.Name = "pxKis"
        Me.pxKis.Size = New System.Drawing.Size(53, 59)
        Me.pxKis.TabIndex = 0
        Me.pxKis.TabStop = False
        Me.pxKis.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Spill.My.Resources.Resources.platform
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 691)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1068, 32)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'pnlPause
        '
        Me.pnlPause.BackColor = System.Drawing.SystemColors.HotTrack
        Me.pnlPause.Controls.Add(Me.btnResume)
        Me.pnlPause.Location = New System.Drawing.Point(344, 153)
        Me.pnlPause.Name = "pnlPause"
        Me.pnlPause.Size = New System.Drawing.Size(242, 234)
        Me.pnlPause.TabIndex = 3
        Me.pnlPause.Visible = False
        '
        'btnResume
        '
        Me.btnResume.Location = New System.Drawing.Point(48, 24)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(75, 23)
        Me.btnResume.TabIndex = 0
        Me.btnResume.Text = "Resume"
        Me.btnResume.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1067, 738)
        Me.Controls.Add(Me.pnlPause)
        Me.Controls.Add(Me.pxCoffee)
        Me.Controls.Add(Me.pxKis)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2D Platformer Team Trøtt"
        CType(Me.pxCoffee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxKis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPause.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pxKis As System.Windows.Forms.PictureBox
    Friend WithEvents gameplay As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pxCoffee As PictureBox
    Friend WithEvents pnlPause As Panel
    Friend WithEvents btnResume As Button
End Class
