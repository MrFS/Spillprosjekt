Imports System.Diagnostics
Imports System.Management

Public Class frmConsole

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                TextBox1.CharacterCasing = CharacterCasing.Lower
                If TextBox1.Text = "exit" Then
                    ListBox1.Items.Add(TextBox1.Text)
                    Application.Exit()
                ElseIf TextBox1.Text = "draw_fps 1" Then

                    ListBox1.Items.Add("FPS Counter is enabled")
                    My.Settings.show_fps = True
                    ListBox1.SelectedIndex = ListBox1.Items.Count - 1

                ElseIf TextBox1.Text = "draw_fps 0" Then
                    ListBox1.Items.Add("FPS Counter is disabled")
                    My.Settings.show_fps = False
                    ListBox1.SelectedIndex = ListBox1.Items.Count - 1

                ElseIf TextBox1.Text = "cena_mode 1" Then
                    ListBox1.Items.Add("'Tropic Thunder' is one of my favorite movies of all time!")
                    ListBox1.SelectedIndex = ListBox1.Items.Count - 1

                ElseIf TextBox1.Text = "vac" Then
                    ListBox1.Items.Add("/kick trond")
                    ListBox1.SelectedIndex = ListBox1.Items.Count - 1

                ElseIf TextBox1.Text = ("pause") Then
                    tmr_console.Enabled = False

                ElseIf TextBox1.Text = "reset" Then
                    My.Settings.Reset()
                    Application.Restart()

                ElseIf TextBox1.Text = ("penis") Then
                    ListBox1.Items.Add("command not long enough")
                    ListBox1.SelectedIndex = ListBox1.Items.Count - 1

                ElseIf TextBox1.Text = ("vagina") Then
                    ListBox1.Items.Add("sorry, taht command is to deep")
                    ListBox1.SelectedIndex = ListBox1.Items.Count - 1

                ElseIf TextBox1.Text = ("clear") Then
                    With ListBox1.Items
                        .Clear()
                        .Add("Console" & Application.ProductVersion & Application.StartupPath)
                        .Add(My.Computer.Info.OSFullName & (" ") & My.Computer.Info.OSPlatform & (" ") & My.Computer.Info.OSVersion)
                        .Add(My.Computer.Info.TotalPhysicalMemory & (" ") & My.Computer.Info.AvailablePhysicalMemory)
                        .Add(My.Computer.Info.TotalVirtualMemory & (" ") & My.Computer.Info.AvailableVirtualMemory)
                        .Add(My.Settings.ant_død & My.Settings.ant_fiender & My.Settings.ant_mynt)
                        .Add("Username: " & My.Settings.username)
                        .Add(vbNewLine)
                        .Add(My.Application.Info.AssemblyName & My.Application.Info.CompanyName)
                        .Add(My.Application.Info.Copyright & My.Application.Info.Description)
                        .Add(vbNewLine)
                        .Add("Cleared console, tick set to pause")
                    End With
                    ListBox1.SelectedIndex = ListBox1.Items.Count - 1
                    tmr_console.Enabled = False

                ElseIf TextBox1.Text = ("iloveyou") Then
                    iloveyou()

                ElseIf TextBox1.Text = ("fulle trøtte jævla") Then
                    tmrDrunk.Enabled = True
                    drunk.BackgroundImage = My.Resources.drunk
                    drunk.BackgroundImageLayout = ImageLayout.Stretch
                    drunk.Visible = True
                    drunk.Dock = DockStyle.Fill
                    ListBox1.SelectedIndex = ListBox1.Items.Count - 1
                ElseIf TextBox1.Text = ("reload") Then
                    frmLvl1.Close()
                    frmLvl1.Show()
                    ListBox1.SelectedIndex = ListBox1.Items.Count - 1
                End If
                TextBox1.Clear()
        End Select
    End Sub

    Private Sub frmConsole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = ("Console " & Application.ProductName & (" ") & ProductVersion & AutoValidate)
        With ListBox1.Items
            .Add("Console" & Application.ProductVersion & Application.StartupPath)
            .Add(My.Computer.Info.OSFullName & (" ") & My.Computer.Info.OSPlatform & (" ") & My.Computer.Info.OSVersion)
            .Add(My.Computer.Info.TotalPhysicalMemory & (" ") & My.Computer.Info.AvailablePhysicalMemory)
            .Add(My.Computer.Info.TotalVirtualMemory & (" ") & My.Computer.Info.AvailableVirtualMemory)
            .Add(My.Settings.ant_død & My.Settings.ant_fiender & My.Settings.ant_mynt)
            .Add("Username: " & My.Settings.username)
            .Add(vbNewLine)
            .Add(My.Application.Info.AssemblyName & My.Application.Info.CompanyName)
            .Add(My.Application.Info.Copyright & My.Application.Info.Description)
            .Add(vbNewLine)
        End With
        tmr_console.Enabled = True

    End Sub

    Private Sub tmr_console_Tick(sender As Object, e As EventArgs) Handles tmr_console.Tick

        With ListBox1.Items
            .Add(My.Computer.Info.AvailableVirtualMemory & (" ") & My.Computer.Info.AvailablePhysicalMemory)
            .Add(My.Computer.Clock.TickCount)
            .Add(Environment.TickCount & (" ") & Environment.ProcessorCount)
        End With

        ListBox1.BackColor = Color.White

        ListBox1.SelectedIndex = ListBox1.Items.Count - 1
    End Sub

    Private Sub tmrDrunk_Tick(sender As Object, e As EventArgs) Handles tmrDrunk.Tick
        If drunk.Visible = True Then
            drunk.Visible = False
        End If
    End Sub

    Private Sub iloveyou()
        My.Computer.Audio.Play(My.Resources.iloveyou_console, AudioPlayMode.Background)
    End Sub
End Class

