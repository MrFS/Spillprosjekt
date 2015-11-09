Public Class frmLvl1
    'deklarerer globale variabler som blir brukt i ulike funksjoner gjennom koden
    Dim direction As String = "stand"
    Dim nextDirection As String = "stand"
    Dim facing As String = "right"
    Dim srcBounds As Rectangle = New Rectangle(0, 0, 40, 48)
    Dim frameCount As Integer = 0
    Const delay As Integer = 2
    Dim speed As Integer = 0
    Const maxSpeed As Integer = 8
    Dim jumpcount As Integer = 0
    Dim startY As Integer = 0
    Dim pxPlat2DirectionX As String = "Venstre"
    Dim pxPlat3DirectionX As String = "Høyre"
    Dim pxPlat6DirectionX As String = "Venstre"
    Dim jumpAllowed As Boolean = True
    Dim Score As Integer = 0
    Dim coffeCount As Integer = 1


    Private Sub gameplay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gameplay.Tick
        'kjører en rekke funksjoner hver gang timeren ticker

        'funskjon for bevegelse av karakter
        KisMove()

        'funskjon for kollisjonsdeteksjon med platform
        plat()

        'funksjon for gravitasjon
        If Not (direction = "up" Or nextDirection = "up") Then
            gravitasjon()
        End If

        'funskjon for kollisjonsdeteksjon med vegger
        chkBounds()

        'funskjon for beregning av score
        chkScore()

        'funskjon for deteksjon død
        outofBounds()

        Me.Refresh()
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'setter den satte verdien i variabelen "Direction" & "nextDirection" slik at funksjonen kismove har noe å jobbe ut ifra.
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

                My.Computer.Audio.Play(My.Resources.jump, AudioPlayMode.Background) 'jump sound

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
        'pauser spillet
        gameplay.Enabled = False
        tmrPlatMove.Enabled = False
        pnlPause.Visible = True
    End Sub
    Private Sub Console()
        'åpner console der du kan skrive inn ulike commands
        frmConsole.Show()
        frmConsole.BringToFront()
    End Sub

    Private Sub frmMain_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        'Nullstiller variablen "direction" og "nextDirection" ved KeyUp slik at fyren ikke fortsetter
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

        'lag rektangel, dekke hele frmLvl1
        Dim rec As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)

        'lag gradient brush      
        Dim myBrush As Brush = New Drawing.Drawing2D.LinearGradientBrush(rec, Color.AliceBlue,
  Color.Aqua, Drawing.Drawing2D.LinearGradientMode.Vertical)

        'tegn BG brush
        e.Graphics.FillRectangle(myBrush, rec)

        'endre grafikken etter hvilken retning karakteren står i
        If (facing = "left") Then
            Dim srcBoundsLeft As Rectangle = New Rectangle(srcBounds.X + 39, srcBounds.Y, -40, 48)
            g.DrawImage(pxKis.Image, pxKis.Bounds, srcBoundsLeft, GraphicsUnit.Pixel)
        Else
            g.DrawImage(pxKis.Image, pxKis.Bounds, srcBounds, GraphicsUnit.Pixel)
        End If
    End Sub

    Private Sub KisMove()
        'Selve hovedfunksjonen for bevegelsen av karakteren. Handler ut ifra variablene "direction" og "nextDirection"
        'Funksjonen blar også gjennom spritebildet av karakteren for å finne det riktige bildet.
        If (frameCount Mod delay = 0) Then
            Select Case (direction)
                Case "stand"
                    If (frameCount / delay >= 4) Then
                        frameCount = 0
                    End If
                    srcBounds = New Rectangle(srcBounds.Width * (frameCount / delay), 0, 40, 48)
                    pxKis.Image = My.Resources.NYpxKis
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
                    pxKis.Image = My.Resources.NYpxKis
                    pxKis.Left += speed
                Case "left"
                    If (speed > -maxSpeed) Then
                        speed -= 1
                    End If
                    If (frameCount / delay >= 8) Then
                        frameCount = 0
                    End If
                    srcBounds = New Rectangle(srcBounds.Width * (frameCount / delay), pxKis.Height, 40, 48)
                    pxKis.Image = My.Resources.NYpxKis
                    pxKis.Left += speed
                Case "up"

                    If (jumpcount = 0) Then
                        startY = pxKis.Location.Y
                    End If

                    'Animasjon av hopping
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
        'sakter gradvis ned farten til karakteren og stopper så helt
        For k As Integer = 0 To i Step 1
            If (speed < 0) Then
                speed += 1
            ElseIf (speed > 0) Then
                speed -= 1
            End If
        Next
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'åpner startvinudet når spillet lukkes
        frmStart.Show()
    End Sub

    Private Sub plat()
        'lager en array som inneholder alle platformene i lvl1
        Dim plat As PictureBox() = {pxGround, pxPlat1, pxPlat2, pxPlat3, pxPlat4, pxPlat5, pxPlat6, pxPlat7}

        'sjekker om karakteren er i kontakt med noen av platformene
        For Each element In plat
            If pxKis.Bounds.IntersectsWith(element.Bounds) And Not pxKis.Location.Y > element.Location.Y Then
                'setter karakterens plassering lik platformhøyden
                pxKis.Location = New Point(pxKis.Location.X,
                                           element.Location.Y - pxKis.Height)
                direction = nextDirection
                jumpAllowed = True
            Else
                jumpAllowed = False
            End If
        Next
    End Sub

    Private Sub gravitasjon()
        'lager en array som inneholder alle platformene i lvl1
        Dim gravity As PictureBox() = {pxGround, pxPlat1, pxPlat2, pxPlat3, pxPlat4, pxPlat5, pxPlat6, pxPlat7}

        'karaketern faller 12 pixler per timertick
        pxKis.Top += 12

        'hvis karakteren står på et platform beveger han seg opp 12 pixler per timertick som motvekt mot gravitasjonen
        For Each element In gravity
            If pxKis.Bounds.IntersectsWith(element.Bounds) Then
                pxKis.Top -= 12
            End If
        Next

    End Sub

    Private Sub chkBounds()
        'sjekker om karakteren er i kontakt med kantene på skjermen og stopper han fra å gå videre
        If pxKis.Bounds.IntersectsWith(lBound.Bounds) Then
            pxKis.Left += lBound.Width + 5
        ElseIf pxKis.Bounds.IntersectsWith(rBound.Bounds) Then
            pxKis.Left -= rBound.Width + 5
        End If
    End Sub

    Private Sub chkScore()
        'lager arrays som inneholder kaffekoppene og kaffekoppikonene
        Dim coffe As PictureBox() = {pxCoffee1, pxCoffee2, pxCoffee3, pxCoffee4, pxCoffee5}
        Dim coffeCollect As PictureBox() = {pxCoffeCollect1, pxCoffeCollect2, pxCoffeCollect3, pxCoffeCollect4, pxCoffeCollect5}

        'sjekker om karakteren er i kontakt med noen av kaffekoppene
        For x = 0 To 4
            If pxKis.Bounds.IntersectsWith(coffe(x).Bounds) Then
                'gjør kaffekoppen usynlig etter at karakteren har samla den
                coffe(x).Visible = False
                coffeCollect(x).Visible = True
                coffe(x).Location = New Point(0, 0)
                'øker poengsummen
                Score += 5000
                coffeCount += 1
            End If
        Next x

        'hvis alle kaffekoppene har blitt samlet, vis snusboks og melding
        If coffeCount = 6 Then
            coffeCount += 1
            tmrPlatMove.Enabled = False
            pxVictory.Visible = True
            direction = "stand"
            MessageBox.Show("Congratz, you collected all the coffee! Here, have a Snus.", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'viser seiersmelding når karakteren berører snusboksen
        If pxKis.Bounds.IntersectsWith(pxVictory.Bounds) And pxVictory.Visible = True Then
            gameplay.Enabled = False
            Dim victory As Integer = MessageBox.Show("You beat level 1, go to level 2?" & vbNewLine & "Console command for level 2: 1337", "You beat the game!", MessageBoxButtons.YesNo)
            If victory = DialogResult.No Then
                'lukker lvl1 og åpner hovedmenyen
                Me.Close()
                frmStart.Show()
                frmAbout.Show()
            ElseIf victory = DialogResult.Yes Then
                'åpner lvl2
                Me.Close()
                frmLvl2.Show()
            End If
        End If

        'oppdaterer samlede kaffekopper og score
        Label7.Text = coffeCount
        Label6.Text = Score

        'reduserer score med 1 for hvert tick
        If Score > 0 Then
            Score -= 1
        End If
    End Sub

    Private Sub outofBounds()
        'skriver ut "du tapte"-melding hvis karakter detter utenfor skjermen og gir deg mulighet til å starte på nytt
        If pxKis.Location.Y > Me.Height Then
            gameplay.Enabled = False
            tmrPlatMove.Enabled = False
            Select Case MsgBox("You died..." & vbCrLf & "Try again?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Game over")
                Case MsgBoxResult.Yes
                    frmReload.Show()
                Case MsgBoxResult.No
                    frmStart.Show()
                    Me.Close()
            End Select

        End If
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
        'gjenopptar spillet
        gameplay.Enabled = True
        tmrPlatMove.Enabled = True
        pnlPause.Visible = False
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        'lukker spillet og åpner hovedmenyen
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
        'timerfunskjon som får platformene til å bevege seg

        If gameplay.Enabled = False Then
            gameplay.Enabled = True
        End If
        Select Case pxPlat2DirectionX
            Case "Høyre"
                pxPlat2.Left += 2
                pxCoffee2.Left += 2
                If pxPlat2.Location.X >= 760 Then pxPlat2DirectionX = "Venstre"
            Case "Venstre"
                pxPlat2.Left -= 2
                pxCoffee2.Left -= 2
                If pxPlat2.Location.X <= 420 Then pxPlat2DirectionX = "Høyre"
        End Select

        Select Case pxPlat3DirectionX
            Case "Høyre"
                pxPlat3.Left += 2
                pxCoffee3.Left += 2
                If pxPlat3.Location.X >= 760 Then pxPlat3DirectionX = "Venstre"
            Case "Venstre"
                pxPlat3.Left -= 2
                pxCoffee3.Left -= 2
                If pxPlat3.Location.X <= 380 Then pxPlat3DirectionX = "Høyre"
        End Select

        Select Case pxPlat6DirectionX
            Case "Høyre"
                pxPlat6.Left += 2
                pxCoffee5.Left += 2
                If pxPlat6.Location.X >= 760 Then pxPlat6DirectionX = "Venstre"
            Case "Venstre"
                pxPlat6.Left -= 2
                pxCoffee5.Left -= 2
                If pxPlat6.Location.X <= 380 Then pxPlat6DirectionX = "Høyre"
        End Select
    End Sub

    Private Sub frmLvl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'gjør kaffekoppikonene usynlige ved formload
        pxCoffeCollect1.Visible = False
        pxCoffeCollect2.Visible = False
        pxCoffeCollect3.Visible = False
        pxCoffeCollect4.Visible = False
        pxCoffeCollect5.Visible = False
        pxVictory.Visible = False

        My.Computer.Audio.Play(My.Resources.main_2dplatform, AudioPlayMode.Background)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        frmSettings.Show()
    End Sub
End Class

