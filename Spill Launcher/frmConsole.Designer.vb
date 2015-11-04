<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsole
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.tmr_console = New System.Windows.Forms.Timer(Me.components)
        Me.drunk = New System.Windows.Forms.PictureBox()
        Me.tmrDrunk = New System.Windows.Forms.Timer(Me.components)
        CType(Me.drunk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox1.Location = New System.Drawing.Point(0, 454)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(985, 22)
        Me.TextBox1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(985, 454)
        Me.ListBox1.TabIndex = 1
        '
        'tmr_console
        '
        Me.tmr_console.Interval = 500
        '
        'drunk
        '
        Me.drunk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.drunk.Location = New System.Drawing.Point(74, 22)
        Me.drunk.Name = "drunk"
        Me.drunk.Size = New System.Drawing.Size(839, 397)
        Me.drunk.TabIndex = 2
        Me.drunk.TabStop = False
        Me.drunk.Visible = False
        '
        'tmrDrunk
        '
        Me.tmrDrunk.Interval = 5000
        '
        'frmConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 476)
        Me.Controls.Add(Me.drunk)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmConsole"
        Me.Text = "frmConsole"
        CType(Me.drunk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents tmr_console As Timer
    Friend WithEvents drunk As PictureBox
    Friend WithEvents tmrDrunk As Timer
End Class
