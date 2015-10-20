Public Class frmMain
    Dim direction As String = "stand"
    Dim facing As String = "right"
    Dim srcBounds As Rectangle = New Rectangle(0, 0, 40, 48)
    Dim frameCount As Integer = 0
    Const delay As Integer = 5
    Dim speed As Integer = 0
    Const maxSpeed As Integer = 12

    Private Sub gameplay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gameplay.Tick
        KisMove()

        Me.Refresh()
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.D) Then 'Right
            direction = "right"
        ElseIf (e.KeyCode = Keys.A) Then 'Left
            direction = "left"
        ElseIf (e.KeyCode = Keys.W) Then
            direction = "up"
        End If
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
    End Sub

    Private Sub frmMain_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim g As Graphics
        g = e.Graphics()

        'Draws the main character's sprite
        g.DrawImage(pxKis.Image, pxKis.Bounds, srcBounds, GraphicsUnit.Pixel)
    End Sub

    Private Sub KisMove()
        If (frameCount Mod delay = 0) Then
            Select Case (direction)
                Case "stand"
                    If (facing = "right") Then
                        If (frameCount / delay >= 4) Then
                            frameCount = 0
                        End If
                        srcBounds = New Rectangle(srcBounds.Width * (frameCount / delay), 0, 40, 48)
                        pxKis.Image = My.Resources.lucas
                    Else
                        If (frameCount / delay >= 4) Then
                            frameCount = 0
                        End If
                        srcBounds = New Rectangle(srcBounds.Width * ((pxKis.Image.Width / 40 - 1) - (frameCount / delay)), 0, 40, 48)
                        pxKis.Image = My.Resources.lucas
                        pxKis.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                    End If
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
                    pxKis.Image = My.Resources.lucas
                    pxKis.Left += speed
                Case "left"
                    If (speed > -maxSpeed) Then
                        speed -= 1
                    End If
                    If (frameCount / delay >= 8) Then
                        frameCount = 0
                    End If
                    srcBounds = New Rectangle(srcBounds.Width * ((pxKis.Image.Width / 40 - 1) - (frameCount / delay)), pxKis.Height, 40, 48)
                    pxKis.Image = My.Resources.lucas
                    pxKis.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                    pxKis.Left += speed
                Case "up"
                    'Hoppe litt
            End Select
        End If
        frameCount += 1
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

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
