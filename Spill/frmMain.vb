Imports System.IO
Imports System.Text
Imports System.Drawing
Imports System.Windows
Imports System.ComponentModel
Imports System.Net
Imports System.Web

Public Class frmMain
    Dim move_left As Boolean
    Dim move_right As Boolean
    Dim move_duck As Boolean
    Dim blnJump As Boolean = True 'skal kanskje/kanskje ikke være med 
    Dim G As Graphics



    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown


        Select Case e.KeyCode ' koden for bevegelse, skal finjusteres litt. mulig det ikke blir brukt timere for bevegelse av hovedkarakter.
            Case Keys.Left
                timer_left.Enabled = True
                timer_right.Enabled = False
                left_img_change.Enabled = True
            Case Keys.Right
                timer_left.Enabled = False
                timer_right.Enabled = True
                right_img_change.Enabled = True
            Case Keys.Space Or Keys.Up
                If blnJump = True Then
                    timerJump.Enabled = True
                    blnJump = False
                End If
            Case Keys.P
                'sett pausemeny
            Case Keys.C
                frmConsole.Show()
        End Select
    End Sub

    Private Sub frmMain_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode ' Koden for å nullstille timerene når bruekeren slipper tasten
            Case Keys.Left
                timer_left.Enabled = False
                left_img_change.Enabled = False
            Case Keys.Right
                timer_right.Enabled = False
                right_img_change.Enabled = False
        End Select
    End Sub

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmStart.Visible = True
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Parent = PictureBox1 ' for å få transparent bg i character pb må man sette parent pb fra vb.net 2015

        If My.Settings.show_fps = True Then
            tmr_fps.Enabled = True
        Else

        End If

        ' Se req. filer

        If System.IO.File.Exists("gamedata/corelib.dll") And
               System.IO.File.Exists("gamedata/gfx.dll") And
               System.IO.File.Exists("gamedata/render.dll") And
               System.IO.File.Exists("gamedata/ui.DAT") And
               System.IO.File.Exists("gamedata/connect.dll") Then
            MsgBox("Core files initilaized.")
        Else
            MsgBox("Missing core files.")
        End If

        If System.IO.File.Exists("gamedata/multicore.DAT") Then 'Bruk flere kjerner i CPU
            multiCore.RunWorkerAsync()
        Else
            'Ingenting
        End If

        tmr_platform_move.Enabled = True
    End Sub

    Private Sub timer_right_Tick(sender As Object, e As EventArgs) Handles timer_right.Tick
        PictureBox2.Left = PictureBox2.Left + 3
    End Sub

    Private Sub timer_left_Tick(sender As Object, e As EventArgs) Handles timer_left.Tick
        PictureBox2.Left = PictureBox2.Left - 9000000000
    End Sub

    Private Sub right_img_change_Tick(sender As Object, e As EventArgs) Handles right_img_change.Tick
        If move_right = False Then
            PictureBox2.BackgroundImage = My.Resources.walk_11
            move_right = True
        Else
            PictureBox2.BackgroundImage = My.Resources.walk_21
            move_right = False
        End If
    End Sub

    Private Sub left_img_change_Tick(sender As Object, e As EventArgs) Handles left_img_change.Tick
        If move_left = False Then
            PictureBox2.BackgroundImage = My.Resources.walk_11
            move_left = True
        Else
            PictureBox2.BackgroundImage = My.Resources.walk_21
            move_left = False
        End If
    End Sub

    Private Sub tmr_fps_Tick(sender As Object, e As EventArgs) Handles tmr_fps.Tick

    End Sub

    Private Sub tmr_platform_move_Tick(sender As Object, e As EventArgs) Handles tmr_platform_move.Tick
        PictureBox3.Left = PictureBox3.Left - 3
    End Sub
End Class
