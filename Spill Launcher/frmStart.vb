Imports System
Imports System.IO
Imports System.Text
Imports System.Drawing
Imports System.Windows


Public Class frmStart

    Dim IsDraggingForm As Boolean = False
    Private MousePos As New System.Drawing.Point(0, 0)

    Private Sub frmStart_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            IsDraggingForm = True
            MousePos = e.Location
        End If
    End Sub

    Private Sub frmStart_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then IsDraggingForm = False
    End Sub

    Private Sub frmStart_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        If IsDraggingForm Then
            Dim temp As Point = New Point(Me.Location + (e.Location - MousePos))
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckBox2.Enabled = False

        'Se om alt er OK før brukeren starter selve spillet.
        'plass for å lagre info om spillbruker og data fra selve spill
        If (Not System.IO.Directory.Exists("gamedata")) Then
            System.IO.Directory.CreateDirectory("gamedata/character")
        End If

        'Last info fra nett (dll, DAT, div) - Enklere?
        'Skriv koden her for å hente filene fra nett. Minke størrelse på innstalleringsfil.
        '-------------------------

        If System.IO.Directory.Exists("gamedata") Then

            System.IO.File.Create("gamedata/character/username.cfg") 'fil for lafring av brukernabn

            Dim gameFile As String = "gamedata/game_main.blob"
            Dim fs As FileStream = File.Create(gameFile)
            Dim utf8 As UTF8Encoding = New UTF8Encoding()
            Dim bw As BinaryWriter = New BinaryWriter(fs, utf8)
            bw.Seek(15000000, SeekOrigin.Begin) '15 MB For sikker lagring (Plass til alt av spill info)
            bw.Write(255)
            fs.Close()

            Dim ramFile As String = "gamedata/gameRAM.DAT"
            Dim RAMfs As FileStream = File.Create(ramFile)
            Dim bw1 As BinaryWriter = New BinaryWriter(RAMfs, utf8)
            bw1.Seek(30000000, SeekOrigin.Begin) 'Så vi har nok plass dedikert til grafikkbilder og andre kalkulasjoner
            bw1.Write(255)
            RAMfs.Close()

            Dim characterFile As String = "gamedata/character/main.DAT"
            Dim cc As FileStream = File.Create(characterFile)
            Dim bw2 As BinaryWriter = New BinaryWriter(cc, utf8)
            bw2.Seek(5000000, SeekOrigin.Begin) 'hovedlagringsfilen for spillkarakteren
            bw2.Write(255)
            cc.Close()

            ' Spillfiler .dll & DAT

            Dim corelib As String = "gamedata/corelib.dll"
            Dim cl As FileStream = File.Create(corelib)
            Dim bw3 As BinaryWriter = New BinaryWriter(cl, utf8)
            bw3.Seek(6752290, SeekOrigin.Begin) 'CoreLibrary
            bw3.Write(255)
            cl.Close()

            Dim gfx As String = "gamedata/gfx.dll"
            Dim gfx_fs As FileStream = File.Create(gfx)
            Dim bw4 As BinaryWriter = New BinaryWriter(gfx_fs, utf8)
            bw4.Seek(45365859, SeekOrigin.Begin) 'Graphics library
            bw4.Write(255)
            gfx_fs.Close()

            Dim render As String = "gamedata/render.dll"
            Dim render_fs As FileStream = File.Create(render)
            Dim bw5 As BinaryWriter = New BinaryWriter(render_fs, utf8)
            bw5.Seek((258103 * 2), SeekOrigin.Begin) 'Render library
            bw5.Write(255)
            render_fs.Close()

            Dim ui As String = "gamedata/ui.DAT"
            Dim ui_fs As FileStream = File.Create(ui)
            Dim bw6 As BinaryWriter = New BinaryWriter(ui_fs, utf8)
            bw6.Seek((19500 * 9), SeekOrigin.Begin) 'UI
            bw6.Write(255)
            ui_fs.Close()

            Dim connect As String = "gamedata/connect.dll"
            Dim connect_fs As FileStream = File.Create(connect)
            Dim bw7 As BinaryWriter = New BinaryWriter(connect_fs, utf8)
            bw7.Seek((1500 * 9), SeekOrigin.Begin) 'connect
            bw7.Write(255)
            connect_fs.Close()

        Else
            MsgBox("Failed to create main files!", MsgBoxStyle.Critical, MsgBoxStyle.OkOnly)
        End If

        'Kalkuler score

        Label12.Text = ((50 * 25) / 2)


        'les brukernavn fra fil
        'kode for cfg fil

        TextBox1.Text = My.Settings.username
        Label8.Text = My.Settings.ant_fiender
        Label9.Text = My.Settings.ant_mynt
        Label10.Text = My.Settings.ant_død

    End Sub

    Private Sub console()
        frmConsole.Show()
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmAbout.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Advarsel, dette vil slette alt i 'gamedata' mappen med unntak av 'character' mappen, samt avslutte programmet. Er du sikker på at du vil forsette?", MsgBoxStyle.YesNoCancel And MsgBoxStyle.Critical, "Advarsel!")
        If MsgBoxResult.Yes Then
            'Delete GameDatafolder
            Dim s As String
            For Each s In System.IO.Directory.GetFiles("gamedata")
                System.IO.File.Delete(s)
            Next s
            Application.Exit()
        Else
            'Ingenting
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        My.Settings.username = TextBox1.Text

        If CheckBox2.Checked = True Then

        End If

        If CheckBox3.Checked = True Then
            My.Settings.dev_console = True
        End If

        My.Settings.Save()

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        CheckBox1.Checked = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmLvl1.Show()
        Me.Hide()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        If My.Settings.dev_console = True Then
            CheckBox3.Checked = True
        End If
    End Sub

    Private Sub frmStart_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.C) Then
            console()
        End If
    End Sub
End Class