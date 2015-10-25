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
        Me.pxLucas = New System.Windows.Forms.PictureBox()
        Me.gameplay = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pxLucas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pxLucas
        '
        Me.pxLucas.BackColor = System.Drawing.Color.Transparent
        Me.pxLucas.Image = Global.Platform_tutorial.My.Resources.Resources.lucas
        Me.pxLucas.Location = New System.Drawing.Point(113, 412)
        Me.pxLucas.Margin = New System.Windows.Forms.Padding(4)
        Me.pxLucas.Name = "pxLucas"
        Me.pxLucas.Size = New System.Drawing.Size(53, 59)
        Me.pxLucas.TabIndex = 0
        Me.pxLucas.TabStop = False
        Me.pxLucas.Visible = False
        '
        'gameplay
        '
        Me.gameplay.Enabled = True
        Me.gameplay.Interval = 10
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Platform_tutorial.My.Resources.Resources.stage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1067, 738)
        Me.Controls.Add(Me.pxLucas)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2D Platformer Team Trøtt"
        CType(Me.pxLucas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pxLucas As System.Windows.Forms.PictureBox
    Friend WithEvents gameplay As System.Windows.Forms.Timer

End Class
