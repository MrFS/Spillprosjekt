Public Class frmMain
    Dim direction As String = "stand"
    Dim nextDirection As String = "stand"
    Dim facing As String = "right"
    Dim srcBounds As Rectangle = New Rectangle(0, 0, 40, 48)
    Dim frameCount As Integer = 0
    Const delay As Integer = 4
    Dim speed As Integer = 0
    Const maxSpeed As Integer = 12
    Dim jumpcount As Integer = 0
    Dim startY As Integer = 0

    Private Sub gameplay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gameplay.Tick
        KisMove()

        Me.Refresh()
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If (Not direction = "up") Then
            If (e.KeyCode = Keys.D) Then 'Right
                facing = "right"
                direction = "right"
            ElseIf (e.KeyCode = Keys.A) Then 'Left
                facing = "left"
                direction = "left"
            ElseIf (e.KeyCode = Keys.W) Then
                nextDirection = direction
                direction = "up"
                jumpcount = 0
            End If
        Else
            If (e.KeyCode = Keys.D) Then 'Right
                If (speed < maxSpeed) Then speed += 1
                facing = "right"
                nextDirection = "right"
            ElseIf (e.KeyCode = Keys.A) Then 'Left
                If (speed > -maxSpeed) Then speed -= 1
                facing = "left"
                nextDirection = "left"
            End If
        End If

        If (e.KeyCode = Keys.C) Then
            Console()
        End If
        If (e.KeyCode = Keys.P) Or (e.KeyCode = Keys.Escape) Then
            pause()
        End If
    End Sub
    Private Sub pause()
        gameplay.Enabled = False
        pnlPause.Visible = True
    End Sub
    Private Sub Console()
        frmConsole.Show()
    End Sub

    Private Sub frmMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If (e.KeyCode = Keys.D And direction = "right") Then 'Right
            direction = "stand"
            facing = "right"
            frameCount = 0
        ElseIf (e.KeyCode = Keys.A And direction = "left") Then 'Left
            direction = "stand"
            facing = "left"
            frameCount = 0
        End If

        If (direction = "up") Then
            If (e.KeyCode = Keys.D) Then 'Right
                nextDirection = "stand"
                facing = "right"
            ElseIf (e.KeyCode = Keys.A) Then 'Left
                nextDirection = "stand"
                facing = "left"
            End If
        End If
    End Sub

    Private Sub frmMain_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim g As Graphics
        g = e.Graphics()

        'Draws the main character's sprite
        If (facing = "left") Then
            Dim srcBoundsLeft As Rectangle = New Rectangle(srcBounds.X + 39, srcBounds.Y, -40, 48)
            g.DrawImage(pxKis.Image, pxKis.Bounds, srcBoundsLeft, GraphicsUnit.Pixel)
        Else
            g.DrawImage(pxKis.Image, pxKis.Bounds, srcBounds, GraphicsUnit.Pixel)
        End If
    End Sub

    Private Sub KisMove()
        If (frameCount Mod delay = 0) Then
            Select Case (direction)
                Case "stand"
                    If (frameCount / delay >= 4) Then
                        frameCount = 0
                    End If
                    srcBounds = New Rectangle(srcBounds.Width * (frameCount / delay), 0, 40, 48)
                    pxKis.Image = My.Resources.pxKis
                    Equalize(2)
                    pxKis.Left += speed
                Case "right"
                    If (speed < maxSpeed) Then
                        speed += 1
                    End If
                    If (frameCount / delay >= 8) Then
                        frameCount = 0
                    End If
                    srcBounds = New Rectangle(srcBounds.Width * (frameCount / delay), pxKis.Height, 40, 48)
                    pxKis.Image = My.Resources.pxKis
                    pxKis.Left += speed
                Case "left"
                    If (speed > -maxSpeed) Then
                        speed -= 1
                    End If
                    If (frameCount / delay >= 8) Then
                        frameCount = 0
                    End If
                    srcBounds = New Rectangle(srcBounds.Width * (frameCount / delay), pxKis.Height, 40, 48)
                    pxKis.Image = My.Resources.pxKis
                    pxKis.Left += speed
                Case "up"
                    If (jumpcount = 0) Then
                        startY = pxKis.Location.Y
                    End If

                    'Animations
                    If (speed > -4 And speed < 4) Then
                        srcBounds.Y = 96
                    Else
                        srcBounds.Y = 48
                    End If
                    If (srcBounds.Y = 0 Or srcBounds.Y = 96) Then
                        If (frameCount / delay >= 9) Then
                            frameCount = 0
                        End If
                        If (jumpcount <= 10 And frameCount / delay > 3) Then
                            frameCount = delay * 2
                        ElseIf (jumpcount <= 18 And frameCount / delay > 5) Then
                            frameCount = delay * 4
                        End If
                        srcBounds = New Rectangle(srcBounds.Width * (frameCount / delay), 96, 40, 48)
                    ElseIf (srcBounds.Y = 48) Then
                        If (frameCount / delay >= 8) Then
                            frameCount = 0
                        End If
                        If (jumpcount <= 10 And jumpcount Mod 2 = 0 And frameCount / delay > 0) Then
                            frameCount -= delay
                        End If
                        srcBounds = New Rectangle(srcBounds.Width * (frameCount / delay), pxKis.Height, 40, 48)
                    End If


                    pxKis.Location = New Point(pxKis.Location.X + speed, (jumpcount - 10) * (jumpcount - 10) - 100 + startY)
                    If (pxKis.Location.Y > startY) Then
                        pxKis.Location = New Point(pxKis.Location.X, startY)
                        direction = nextDirection
                    End If
                    jumpcount += 1
            End Select
        End If
        frameCount += 1

        If collision(pxKis, pxCoffee) Then
            pxKis.Location = New Point(0, 0)
        End If
    End Sub
    Private Sub Equalize(ByVal i As Integer)
        For k As Integer = 0 To i Step 1
            If (speed < 0) Then
                speed += 1
            ElseIf (speed > 0) Then
                speed -= 1
            End If
        Next
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmStart.Show()
    End Sub

    Private Function collision(ByVal Object1 As Object, ByVal Object2 As Object) As Boolean
        Dim Collided As Boolean = False

        If Object1.top + Object1.height >= Object2.top And
           Object2.top + Object2.height >= Object1.top And
           Object1.left + Object1.width >= Object2.left And
           Object2.left + Object2.width >= Object1.left Then
            Collided = True
        End If
        Return Collided
    End Function

    Private Sub btnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click
        pnlPause.Visible = False
        gameplay.Enabled = True
    End Sub

    Private Sub btnExitMMnu_click(sender As Object, e As EventArgs) Handles btnExitMMnu.Click
        '////////////////////////////////////////
        '/////Kode for lagring av plass//////////
        '////////////////////////////////////////

        Me.Close()
        frmStart.Show()
    End Sub
End Class
