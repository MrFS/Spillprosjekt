<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLvl1
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
        Me.tmrPlatMove = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pxCoffeCollect1 = New System.Windows.Forms.PictureBox()
        Me.pxCoffeCollect2 = New System.Windows.Forms.PictureBox()
        Me.pxCoffeCollect3 = New System.Windows.Forms.PictureBox()
        Me.pxCoffeCollect4 = New System.Windows.Forms.PictureBox()
        Me.pxCoffeCollect5 = New System.Windows.Forms.PictureBox()
        Me.pnlPause = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pxVictory = New System.Windows.Forms.PictureBox()
        Me.pxCoffee2 = New System.Windows.Forms.PictureBox()
        Me.pxCoffee3 = New System.Windows.Forms.PictureBox()
        Me.pxCoffee4 = New System.Windows.Forms.PictureBox()
        Me.pxCoffee5 = New System.Windows.Forms.PictureBox()
        Me.pxPlat7 = New System.Windows.Forms.PictureBox()
        Me.pxPlat6 = New System.Windows.Forms.PictureBox()
        Me.pxPlat5 = New System.Windows.Forms.PictureBox()
        Me.pxPlat4 = New System.Windows.Forms.PictureBox()
        Me.lBound = New System.Windows.Forms.PictureBox()
        Me.rBound = New System.Windows.Forms.PictureBox()
        Me.pxPlat3 = New System.Windows.Forms.PictureBox()
        Me.pxPlat2 = New System.Windows.Forms.PictureBox()
        Me.pxPlat1 = New System.Windows.Forms.PictureBox()
        Me.pxCoffee1 = New System.Windows.Forms.PictureBox()
        Me.pxKis = New System.Windows.Forms.PictureBox()
        Me.pxGround = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pxCoffeCollect1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxCoffeCollect2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxCoffeCollect3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxCoffeCollect4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxCoffeCollect5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPause.SuspendLayout()
        CType(Me.pxVictory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxCoffee2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxCoffee3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxCoffee4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxCoffee5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPlat7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPlat6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPlat5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPlat4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lBound, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rBound, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPlat3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPlat2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxPlat1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxCoffee1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxKis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gameplay
        '
        Me.gameplay.Enabled = True
        Me.gameplay.Interval = 10
        '
        'tmrPlatMove
        '
        Me.tmrPlatMove.Enabled = True
        Me.tmrPlatMove.Interval = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 23)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Collected:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 23)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Score:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(103, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 23)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "&&_"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(288, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 23)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "CoffeCount"
        '
        'pxCoffeCollect1
        '
        Me.pxCoffeCollect1.BackColor = System.Drawing.Color.Transparent
        Me.pxCoffeCollect1.BackgroundImage = Global.Spill.My.Resources.Resources.coffee
        Me.pxCoffeCollect1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pxCoffeCollect1.Location = New System.Drawing.Point(144, 3)
        Me.pxCoffeCollect1.Margin = New System.Windows.Forms.Padding(2)
        Me.pxCoffeCollect1.Name = "pxCoffeCollect1"
        Me.pxCoffeCollect1.Size = New System.Drawing.Size(24, 26)
        Me.pxCoffeCollect1.TabIndex = 29
        Me.pxCoffeCollect1.TabStop = False
        '
        'pxCoffeCollect2
        '
        Me.pxCoffeCollect2.BackColor = System.Drawing.Color.Transparent
        Me.pxCoffeCollect2.BackgroundImage = Global.Spill.My.Resources.Resources.coffee
        Me.pxCoffeCollect2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pxCoffeCollect2.Location = New System.Drawing.Point(172, 3)
        Me.pxCoffeCollect2.Margin = New System.Windows.Forms.Padding(2)
        Me.pxCoffeCollect2.Name = "pxCoffeCollect2"
        Me.pxCoffeCollect2.Size = New System.Drawing.Size(24, 26)
        Me.pxCoffeCollect2.TabIndex = 30
        Me.pxCoffeCollect2.TabStop = False
        '
        'pxCoffeCollect3
        '
        Me.pxCoffeCollect3.BackColor = System.Drawing.Color.Transparent
        Me.pxCoffeCollect3.BackgroundImage = Global.Spill.My.Resources.Resources.coffee
        Me.pxCoffeCollect3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pxCoffeCollect3.Location = New System.Drawing.Point(200, 3)
        Me.pxCoffeCollect3.Margin = New System.Windows.Forms.Padding(2)
        Me.pxCoffeCollect3.Name = "pxCoffeCollect3"
        Me.pxCoffeCollect3.Size = New System.Drawing.Size(24, 26)
        Me.pxCoffeCollect3.TabIndex = 33
        Me.pxCoffeCollect3.TabStop = False
        '
        'pxCoffeCollect4
        '
        Me.pxCoffeCollect4.BackColor = System.Drawing.Color.Transparent
        Me.pxCoffeCollect4.BackgroundImage = Global.Spill.My.Resources.Resources.coffee
        Me.pxCoffeCollect4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pxCoffeCollect4.Location = New System.Drawing.Point(229, 3)
        Me.pxCoffeCollect4.Margin = New System.Windows.Forms.Padding(2)
        Me.pxCoffeCollect4.Name = "pxCoffeCollect4"
        Me.pxCoffeCollect4.Size = New System.Drawing.Size(24, 26)
        Me.pxCoffeCollect4.TabIndex = 32
        Me.pxCoffeCollect4.TabStop = False
        '
        'pxCoffeCollect5
        '
        Me.pxCoffeCollect5.BackColor = System.Drawing.Color.Transparent
        Me.pxCoffeCollect5.BackgroundImage = Global.Spill.My.Resources.Resources.coffee
        Me.pxCoffeCollect5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pxCoffeCollect5.Location = New System.Drawing.Point(259, 3)
        Me.pxCoffeCollect5.Margin = New System.Windows.Forms.Padding(2)
        Me.pxCoffeCollect5.Name = "pxCoffeCollect5"
        Me.pxCoffeCollect5.Size = New System.Drawing.Size(24, 26)
        Me.pxCoffeCollect5.TabIndex = 31
        Me.pxCoffeCollect5.TabStop = False
        '
        'pnlPause
        '
        Me.pnlPause.BackColor = System.Drawing.Color.Transparent
        Me.pnlPause.BackgroundImage = Global.Spill.My.Resources.Resources.pausebg
        Me.pnlPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlPause.Controls.Add(Me.Label3)
        Me.pnlPause.Controls.Add(Me.Label2)
        Me.pnlPause.Controls.Add(Me.Label1)
        Me.pnlPause.Location = New System.Drawing.Point(334, 173)
        Me.pnlPause.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlPause.Name = "pnlPause"
        Me.pnlPause.Size = New System.Drawing.Size(254, 219)
        Me.pnlPause.TabIndex = 3
        Me.pnlPause.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 160)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Exit To Menu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sett&ings"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Resume Game"
        '
        'pxVictory
        '
        Me.pxVictory.BackColor = System.Drawing.Color.Transparent
        Me.pxVictory.BackgroundImage = Global.Spill.My.Resources.Resources.vitory_snus
        Me.pxVictory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pxVictory.Location = New System.Drawing.Point(73, 252)
        Me.pxVictory.Margin = New System.Windows.Forms.Padding(2)
        Me.pxVictory.Name = "pxVictory"
        Me.pxVictory.Size = New System.Drawing.Size(44, 43)
        Me.pxVictory.TabIndex = 26
        Me.pxVictory.TabStop = False
        '
        'pxCoffee2
        '
        Me.pxCoffee2.BackColor = System.Drawing.Color.Transparent
        Me.pxCoffee2.BackgroundImage = Global.Spill.My.Resources.Resources.coffee
        Me.pxCoffee2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pxCoffee2.Location = New System.Drawing.Point(682, 456)
        Me.pxCoffee2.Margin = New System.Windows.Forms.Padding(2)
        Me.pxCoffee2.Name = "pxCoffee2"
        Me.pxCoffee2.Size = New System.Drawing.Size(24, 26)
        Me.pxCoffee2.TabIndex = 25
        Me.pxCoffee2.TabStop = False
        '
        'pxCoffee3
        '
        Me.pxCoffee3.BackColor = System.Drawing.Color.Transparent
        Me.pxCoffee3.BackgroundImage = Global.Spill.My.Resources.Resources.coffee
        Me.pxCoffee3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pxCoffee3.Location = New System.Drawing.Point(632, 292)
        Me.pxCoffee3.Margin = New System.Windows.Forms.Padding(2)
        Me.pxCoffee3.Name = "pxCoffee3"
        Me.pxCoffee3.Size = New System.Drawing.Size(24, 26)
        Me.pxCoffee3.TabIndex = 24
        Me.pxCoffee3.TabStop = False
        '
        'pxCoffee4
        '
        Me.pxCoffee4.BackColor = System.Drawing.Color.Transparent
        Me.pxCoffee4.BackgroundImage = Global.Spill.My.Resources.Resources.coffee
        Me.pxCoffee4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pxCoffee4.Location = New System.Drawing.Point(273, 191)
        Me.pxCoffee4.Margin = New System.Windows.Forms.Padding(2)
        Me.pxCoffee4.Name = "pxCoffee4"
        Me.pxCoffee4.Size = New System.Drawing.Size(24, 26)
        Me.pxCoffee4.TabIndex = 23
        Me.pxCoffee4.TabStop = False
        '
        'pxCoffee5
        '
        Me.pxCoffee5.BackColor = System.Drawing.Color.Transparent
        Me.pxCoffee5.BackgroundImage = Global.Spill.My.Resources.Resources.coffee
        Me.pxCoffee5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pxCoffee5.Location = New System.Drawing.Point(534, 113)
        Me.pxCoffee5.Margin = New System.Windows.Forms.Padding(2)
        Me.pxCoffee5.Name = "pxCoffee5"
        Me.pxCoffee5.Size = New System.Drawing.Size(24, 26)
        Me.pxCoffee5.TabIndex = 22
        Me.pxCoffee5.TabStop = False
        '
        'pxPlat7
        '
        Me.pxPlat7.BackColor = System.Drawing.Color.DarkRed
        Me.pxPlat7.BackgroundImage = Global.Spill.My.Resources.Resources.pxGroundPlatBG
        Me.pxPlat7.Location = New System.Drawing.Point(31, 298)
        Me.pxPlat7.Margin = New System.Windows.Forms.Padding(2)
        Me.pxPlat7.Name = "pxPlat7"
        Me.pxPlat7.Size = New System.Drawing.Size(126, 15)
        Me.pxPlat7.TabIndex = 19
        Me.pxPlat7.TabStop = False
        '
        'pxPlat6
        '
        Me.pxPlat6.BackColor = System.Drawing.Color.DarkRed
        Me.pxPlat6.BackgroundImage = Global.Spill.My.Resources.Resources.pxGroundPlatBG
        Me.pxPlat6.Location = New System.Drawing.Point(482, 142)
        Me.pxPlat6.Margin = New System.Windows.Forms.Padding(2)
        Me.pxPlat6.Name = "pxPlat6"
        Me.pxPlat6.Size = New System.Drawing.Size(131, 17)
        Me.pxPlat6.TabIndex = 18
        Me.pxPlat6.TabStop = False
        '
        'pxPlat5
        '
        Me.pxPlat5.BackColor = System.Drawing.Color.DarkRed
        Me.pxPlat5.BackgroundImage = Global.Spill.My.Resources.Resources.pxGroundPlatBG
        Me.pxPlat5.Location = New System.Drawing.Point(200, 230)
        Me.pxPlat5.Margin = New System.Windows.Forms.Padding(2)
        Me.pxPlat5.Name = "pxPlat5"
        Me.pxPlat5.Size = New System.Drawing.Size(156, 15)
        Me.pxPlat5.TabIndex = 17
        Me.pxPlat5.TabStop = False
        '
        'pxPlat4
        '
        Me.pxPlat4.BackColor = System.Drawing.Color.DarkRed
        Me.pxPlat4.BackgroundImage = Global.Spill.My.Resources.Resources.pxGroundPlatBG
        Me.pxPlat4.Location = New System.Drawing.Point(802, 376)
        Me.pxPlat4.Margin = New System.Windows.Forms.Padding(2)
        Me.pxPlat4.Name = "pxPlat4"
        Me.pxPlat4.Size = New System.Drawing.Size(145, 16)
        Me.pxPlat4.TabIndex = 16
        Me.pxPlat4.TabStop = False
        '
        'lBound
        '
        Me.lBound.BackColor = System.Drawing.Color.Transparent
        Me.lBound.Location = New System.Drawing.Point(0, 0)
        Me.lBound.Margin = New System.Windows.Forms.Padding(2)
        Me.lBound.Name = "lBound"
        Me.lBound.Size = New System.Drawing.Size(4, 504)
        Me.lBound.TabIndex = 13
        Me.lBound.TabStop = False
        '
        'rBound
        '
        Me.rBound.BackColor = System.Drawing.Color.Transparent
        Me.rBound.Location = New System.Drawing.Point(943, 0)
        Me.rBound.Margin = New System.Windows.Forms.Padding(2)
        Me.rBound.Name = "rBound"
        Me.rBound.Size = New System.Drawing.Size(4, 504)
        Me.rBound.TabIndex = 12
        Me.rBound.TabStop = False
        '
        'pxPlat3
        '
        Me.pxPlat3.BackColor = System.Drawing.Color.DarkRed
        Me.pxPlat3.BackgroundImage = Global.Spill.My.Resources.Resources.pxGroundPlatBG
        Me.pxPlat3.Location = New System.Drawing.Point(564, 323)
        Me.pxPlat3.Margin = New System.Windows.Forms.Padding(2)
        Me.pxPlat3.Name = "pxPlat3"
        Me.pxPlat3.Size = New System.Drawing.Size(142, 15)
        Me.pxPlat3.TabIndex = 6
        Me.pxPlat3.TabStop = False
        '
        'pxPlat2
        '
        Me.pxPlat2.BackColor = System.Drawing.Color.DarkRed
        Me.pxPlat2.BackgroundImage = Global.Spill.My.Resources.Resources.pxGroundPlatBG
        Me.pxPlat2.Location = New System.Drawing.Point(623, 489)
        Me.pxPlat2.Margin = New System.Windows.Forms.Padding(2)
        Me.pxPlat2.Name = "pxPlat2"
        Me.pxPlat2.Size = New System.Drawing.Size(136, 15)
        Me.pxPlat2.TabIndex = 5
        Me.pxPlat2.TabStop = False
        '
        'pxPlat1
        '
        Me.pxPlat1.BackColor = System.Drawing.Color.DarkRed
        Me.pxPlat1.BackgroundImage = Global.Spill.My.Resources.Resources.pxGroundPlatBG
        Me.pxPlat1.Location = New System.Drawing.Point(200, 467)
        Me.pxPlat1.Margin = New System.Windows.Forms.Padding(2)
        Me.pxPlat1.Name = "pxPlat1"
        Me.pxPlat1.Size = New System.Drawing.Size(187, 15)
        Me.pxPlat1.TabIndex = 4
        Me.pxPlat1.TabStop = False
        '
        'pxCoffee1
        '
        Me.pxCoffee1.BackColor = System.Drawing.Color.Transparent
        Me.pxCoffee1.BackgroundImage = Global.Spill.My.Resources.Resources.coffee
        Me.pxCoffee1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pxCoffee1.Location = New System.Drawing.Point(273, 426)
        Me.pxCoffee1.Margin = New System.Windows.Forms.Padding(2)
        Me.pxCoffee1.Name = "pxCoffee1"
        Me.pxCoffee1.Size = New System.Drawing.Size(24, 26)
        Me.pxCoffee1.TabIndex = 2
        Me.pxCoffee1.TabStop = False
        '
        'pxKis
        '
        Me.pxKis.BackColor = System.Drawing.Color.Transparent
        Me.pxKis.Image = Global.Spill.My.Resources.Resources.pxKis
        Me.pxKis.Location = New System.Drawing.Point(56, 467)
        Me.pxKis.Name = "pxKis"
        Me.pxKis.Size = New System.Drawing.Size(48, 48)
        Me.pxKis.TabIndex = 0
        Me.pxKis.TabStop = False
        Me.pxKis.Visible = False
        '
        'pxGround
        '
        Me.pxGround.BackColor = System.Drawing.Color.Transparent
        Me.pxGround.BackgroundImage = Global.Spill.My.Resources.Resources.pxGroundPlatBG
        Me.pxGround.Location = New System.Drawing.Point(0, 520)
        Me.pxGround.Margin = New System.Windows.Forms.Padding(2)
        Me.pxGround.Name = "pxGround"
        Me.pxGround.Size = New System.Drawing.Size(146, 32)
        Me.pxGround.TabIndex = 1
        Me.pxGround.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Spill.My.Resources.Resources.sky2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(946, 108)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'frmLvl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(946, 547)
        Me.Controls.Add(Me.pxCoffeCollect1)
        Me.Controls.Add(Me.pxCoffeCollect2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pxCoffeCollect3)
        Me.Controls.Add(Me.pxCoffeCollect4)
        Me.Controls.Add(Me.pxCoffeCollect5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pnlPause)
        Me.Controls.Add(Me.pxVictory)
        Me.Controls.Add(Me.pxCoffee2)
        Me.Controls.Add(Me.pxCoffee3)
        Me.Controls.Add(Me.pxCoffee4)
        Me.Controls.Add(Me.pxCoffee5)
        Me.Controls.Add(Me.pxPlat7)
        Me.Controls.Add(Me.pxPlat6)
        Me.Controls.Add(Me.pxPlat5)
        Me.Controls.Add(Me.pxPlat4)
        Me.Controls.Add(Me.lBound)
        Me.Controls.Add(Me.rBound)
        Me.Controls.Add(Me.pxPlat3)
        Me.Controls.Add(Me.pxPlat2)
        Me.Controls.Add(Me.pxPlat1)
        Me.Controls.Add(Me.pxCoffee1)
        Me.Controls.Add(Me.pxKis)
        Me.Controls.Add(Me.pxGround)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "frmLvl1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "x"
        CType(Me.pxCoffeCollect1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxCoffeCollect2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxCoffeCollect3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxCoffeCollect4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxCoffeCollect5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPause.ResumeLayout(False)
        Me.pnlPause.PerformLayout()
        CType(Me.pxVictory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxCoffee2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxCoffee3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxCoffee4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxCoffee5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPlat7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPlat6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPlat5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPlat4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lBound, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rBound, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPlat3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPlat2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxPlat1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxCoffee1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxKis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pxKis As System.Windows.Forms.PictureBox
    Friend WithEvents gameplay As System.Windows.Forms.Timer
    Friend WithEvents pxGround As PictureBox
    Friend WithEvents pxCoffee1 As PictureBox
    Friend WithEvents pnlPause As Panel
    Friend WithEvents pxPlat1 As PictureBox
    Friend WithEvents pxPlat2 As PictureBox
    Friend WithEvents pxPlat3 As PictureBox
    Friend WithEvents rBound As PictureBox
    Friend WithEvents lBound As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pxPlat4 As PictureBox
    Friend WithEvents pxPlat5 As PictureBox
    Friend WithEvents pxPlat6 As PictureBox
    Friend WithEvents pxPlat7 As PictureBox
    Friend WithEvents pxCoffee5 As PictureBox
    Friend WithEvents pxCoffee4 As PictureBox
    Friend WithEvents pxCoffee3 As PictureBox
    Friend WithEvents pxCoffee2 As PictureBox
    Friend WithEvents pxVictory As PictureBox
    Friend WithEvents tmrPlatMove As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents pxCoffeCollect1 As PictureBox
    Friend WithEvents pxCoffeCollect2 As PictureBox
    Friend WithEvents pxCoffeCollect5 As PictureBox
    Friend WithEvents pxCoffeCollect4 As PictureBox
    Friend WithEvents pxCoffeCollect3 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
