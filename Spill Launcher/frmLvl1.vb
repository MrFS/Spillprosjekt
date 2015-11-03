Public Class frmLvl1
    Dim direction As String = "stand"
    Dim nextDirection As String = "stand"
    Dim facing As String = "right"
    Dim srcBounds As Rectangle = New Rectangle(0, 0, 40, 48)
    Dim frameCount As Integer = 0
    Const delay As Integer = 2
    Dim speed As Integer = 0
    Const maxSpeed As Integer = 12
    Dim jumpcount As Integer = 0
    Dim startY As Integer = 0
    Dim pxPlatDirectionX As String = "Høyre"
    Dim pxPlatDirectionY As String = "Ned"

    'Dim kis As kismove = New kismove()

    Dim grav As PictureBox() = {pxGround, pxPlat1, pxPlat2, pxPlat3, pxPlat4, pxPLat5, pxPlat6, pxPlat7}


    Private Sub gameplay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gameplay.Tick
        'kis.Move(pxKis)
        KisMove()

        plat()

        If Not (direction = "up" Or nextDirection = "up") Then
            gravitasjon()
        End If

        chkBounds()

        chkScore()

        Me.Refresh()
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'Dim left As Integer = Keys.A
        'Dim right As Integer = Keys.D
        'Dim up As Integer = Keys.W

        'kis.KeyDown(sender, e, left, right, up)



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
        frmConsole.BringToFront()
    End Sub

    Private Sub frmMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        'Dim left As Integer = Keys.A
        'Dim right As Integer = Keys.D
        'Dim up As Integer = Keys.W

        'kis.KeyUp(sender, e, left, right, up)



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
                'tGrav.Enabled = True
            ElseIf (e.KeyCode = Keys.A) Then 'Left
                nextDirection = "stand"
                facing = "left"
                'tGrav.Enabled = True
            End If
        End If
    End Sub

    Private Sub frmMain_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim g As Graphics
        g = e.Graphics()

        'kis.Paint(g, pxKis)

        'Tegne kisn i frmLvl1 (Y)

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

    Private Sub plat()
        Dim plat As PictureBox() = {pxPlatBounds1, pxPlatBounds2, pxPlatBounds3, pxPlatBounds4, pxPlatBounds5, pxPlatBounds6, pxPlatBounds7}
        For x = 0 To 6
            If pxKis.Bounds.IntersectsWith(plat(x).Bounds) Then

                'pxKis.Location = New Point(pxKis.Location.X,
                'pxKis.Location.Y)
                pxKis.Location = New Point(plat(x).Location.X,
                                           plat(x).Location.Y - pxKis.Height)

                direction = nextDirection

            End If
        Next x
    End Sub

    Private Sub gravitasjon()
        Dim gravity2 As PictureBox() = {pxGround, pxPlatBounds1, pxPlatBounds2, pxPlatBounds3, pxPlatBounds4, pxPlatBounds5, pxPlatBounds6, pxPlatBounds7}


        pxKis.Top += 6

        For x = 0 To 7

            If pxKis.Bounds.IntersectsWith(gravity2(x).Bounds) Then

                pxKis.Top -= 6

                'direction = nextDirection

            End If

        Next x
    End Sub

    Private Sub chkBounds()

        If pxKis.Bounds.IntersectsWith(lBound.Bounds) Then
            pxKis.Left += lBound.Width + 5
        ElseIf pxKis.Bounds.IntersectsWith(rBound.Bounds) Then
            pxKis.Left -= rBound.Width + 5
        End If
    End Sub

    Private Sub chkScore()

        Dim coffe As PictureBox() = {pxCoffee1, pxCoffee2, pxCoffee3, pxCoffee4, pxCoffee5}

        For x = 0 To 4
            If pxKis.Bounds.IntersectsWith(coffe(x).Bounds) Then

                coffe(x).Visible = False ' Gjør kaffen usynlig etter at fyren har samla dem (Y)

            End If
        Next x

    End Sub

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Label1.ForeColor = Color.HotPink
    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        Label2.ForeColor = Color.HotPink
    End Sub

    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseHover
        Label3.ForeColor = Color.HotPink
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        gameplay.Enabled = True
        pnlPause.Visible = False
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
        frmStart.Show()
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.Black
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.Black
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.Black
    End Sub

    Private Sub tmrPlatMove_Tick(sender As Object, e As EventArgs) Handles tmrPlatMove.Tick

        Select Case pxPlatDirectionX
            Case "Høyre"
                pxPlat2.Left += 2
                pxPlatBounds2.Left += 2
                pxCoffee2.Left += 2

                If pxPlat2.Location.X >= 760 Then pxPlatDirectionX = "Venstre"
            Case "Venstre"
                pxPlat2.Left -= 2
                pxPlatBounds2.Left -= 2
                pxCoffee2.Left -= 2

                If pxPlat2.Location.X <= 380 Then pxPlatDirectionX = "Høyre"

        End Select

        Select Case pxPlatDirectionY
            Case "Ned"
                pxPlat4.Top -= 2
                pxPlatBounds4.Top -= 2


                If pxPlat2.Location.Y >= 500 Then pxPlatDirectionY = "Opp"
            Case "Opp"
                pxPlat4.Top += 2
                pxPlatBounds4.Top += 2


                If pxPlat2.Location.Y >= 150 Then pxPlatDirectionY = "Ned"

        End Select

        'If pxPlat2.Location.X = 485 Then
        '    pxPlatDirection = "Høyre"
        'End If
        'If pxPlat2.Location.X = 760 Then
        '    pxPlatDirection = "Venstre"
        'End If
    End Sub
End Class

