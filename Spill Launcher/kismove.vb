Public Class kismove
    Dim direction As String = "stand"
    Dim nextDirection As String = "stand"
    Dim facing As String = "right"
    Dim srcBounds As Rectangle = New Rectangle(0, 0, 40, 48)
    Dim frameCount As Integer = 0
    Const delay As Integer = 3
    Dim speed As Integer = 0
    Const maxSpeed As Integer = 12
    Dim startY As Integer = 0
    Dim jumpCount As Integer = 0

    Public Sub KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs,
                       ByVal left As Integer, ByVal right As Integer, ByVal up As Integer)
        If (Not direction = "up") Then
            If (e.KeyCode = Keys.D) Then 'Right
                facing = "right"
                direction = "right"
            ElseIf (e.KeyCode = Keys.A) Then 'Left
                facing = "left"
                direction = "left"
            ElseIf (e.KeyCode = Keys.W Or e.KeyCode = Keys.Space) Then
                nextDirection = direction
                direction = "up"
                jumpCount = 0

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
    End Sub

    Public Sub KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs,
                       ByVal left As Integer, ByVal right As Integer, ByVal up As Integer)
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

    Public Sub Paint(ByVal g As Graphics, ByVal pxKis As PictureBox)
        'Draws the main character's sprite
        If (facing = "left") Then
            Dim srcBoundsLeft As Rectangle = New Rectangle(srcBounds.X + 39, srcBounds.Y, -40, 48)
            g.DrawImage(pxKis.Image, pxKis.Bounds, srcBoundsLeft, GraphicsUnit.Pixel)
        Else
            g.DrawImage(pxKis.Image, pxKis.Bounds, srcBounds, GraphicsUnit.Pixel)
        End If
    End Sub

    Public Sub Move(ByVal pxKis As PictureBox)
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

                    If (jumpCount = 0) Then
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
                        If (jumpCount <= 10 And frameCount / delay > 3) Then
                            frameCount = delay * 2
                        ElseIf (jumpCount <= 18 And frameCount / delay > 5) Then
                            frameCount = delay * 4
                        End If
                        srcBounds = New Rectangle(srcBounds.Width * (frameCount / delay), 96, 40, 48)
                    ElseIf (srcBounds.Y = 48) Then
                        If (frameCount / delay >= 8) Then
                            frameCount = 0
                        End If
                        If (jumpCount <= 10 And jumpCount Mod 2 = 0 And frameCount / delay > 0) Then
                            frameCount -= delay
                        End If
                        srcBounds = New Rectangle(srcBounds.Width * (frameCount / delay), pxKis.Height, 40, 48)
                    End If


                    pxKis.Location = New Point(pxKis.Location.X + speed, (jumpCount - 10) * (jumpCount - 10) - 100 + startY)
                    If (pxKis.Location.Y > startY) Then
                        pxKis.Location = New Point(pxKis.Location.X, startY)
                        direction = nextDirection
                    End If
                    jumpCount += 1

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
End Class



