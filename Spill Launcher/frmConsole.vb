Imports System.Diagnostics
Imports System.Management
Imports System.Threading

Public Class frmConsole

    Dim latestEntry As String
    Dim RecordText As String
    Dim c As Process = Process.GetCurrentProcess()
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
                    ListBox1.Items.Add("sorry, that command is to deep")
                    ListBox1.SelectedIndex = ListBox1.Items.Count - 1

                ElseIf TextBox1.Text = ("clear") Then
                    With ListBox1.Items
                        .Clear()
                        .Add("Console" & Application.ProductVersion & Application.StartupPath)
                        .Add(My.Computer.Info.OSFullName & (" ") & My.Computer.Info.OSPlatform & (" ") & My.Computer.Info.OSVersion)
                        .Add(My.Computer.Info.TotalPhysicalMemory & (" ") & My.Computer.Info.AvailablePhysicalMemory)
                        .Add(My.Computer.Info.TotalVirtualMemory & (" ") & My.Computer.Info.AvailableVirtualMemory)
                        .Add(My.Settings.ant_død & My.Settings.ant_fiender & My.Settings.ant_kaffe)
                        .Add("Username: " & My.Settings.username)
                        .Add(vbNewLine)
                        .Add(My.Application.Info.AssemblyName & My.Application.Info.CompanyName)
                        .Add(My.Application.Info.Copyright & My.Application.Info.Description)
                        .Add("Mem Usage (Working Set) :   " & c.WorkingSet / 1024 & " K")
                        .Add("VM Size (Private Bytes) " & c.PagedMemorySize / 1024 & " K")
                        .Add("GC TotalMemory " & GC.GetTotalMemory(True) & " bytes" & "Current Memory Usage")
                        .Add(vbNewLine)
                        .Add("Cleared console, tick set to pause")
                    End With
                    ListBox1.SelectedIndex = ListBox1.Items.Count - 1
                    tmr_console.Enabled = False

                ElseIf TextBox1.Text = ("iloveyou") Then
                    iloveyou()

                ElseIf textbox1.Text = ("resDebug")
                    tmr_console.Enabled = True

                ElseIf TextBox1.Text = ("lvl2") Then
                    Dim result As Integer = MessageBox.Show("Level 2 er ikke optimalisert! Massiv hakking vil forekomme! Fortsette?", "ADVARSEL", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                    If result = DialogResult.No Then
                        Me.Focus()
                    ElseIf result = DialogResult.Yes Then
                        frmLvl1.Close()
                        frmLvl2.Show()
                    End If



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

                latestEntry = TextBox1.Text
                'TextBox1.Text = latestEntry

                TextBox1.Clear()

            Case Keys.Up

                'RecordText = RecordText & Chr(e.KeyCode)

                'MessageBox.Show(RecordText & latestEntry)

                TextBox1.Text = latestEntry

        End Select
    End Sub

    Private Sub frmConsole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = ("Console " & Application.ProductName & (" ") & ProductVersion & AutoValidate)
        With ListBox1.Items
            .Add("Console" & Application.ProductVersion & Application.StartupPath)
            .Add(My.Computer.Info.OSFullName & (" ") & My.Computer.Info.OSPlatform & (" ") & My.Computer.Info.OSVersion)
            .Add(My.Computer.Info.TotalPhysicalMemory & (" ") & My.Computer.Info.AvailablePhysicalMemory)
            .Add(My.Computer.Info.TotalVirtualMemory & (" ") & My.Computer.Info.AvailableVirtualMemory)
            .Add(My.Settings.ant_død & My.Settings.ant_fiender & My.Settings.ant_kaffe)
            .Add("Username: " & My.Settings.username)
            .Add(vbNewLine)
            .Add(My.Application.Info.AssemblyName & My.Application.Info.CompanyName)
            .Add(My.Application.Info.Copyright & My.Application.Info.Description)
            .Add(vbNewLine)
            .Add("Mem Usage (Working Set) :   " & c.WorkingSet / 1024 & " K")
            .Add("VM Size (Private Bytes) " & c.PagedMemorySize / 1024 & " K")
            .Add("GC TotalMemory " & GC.GetTotalMemory(True) & " bytes" & "Current Memory Usage")
        End With
        tmr_console.Enabled = True

    End Sub

    Private Sub tmr_console_Tick(sender As Object, e As EventArgs) Handles tmr_console.Tick

        With ListBox1.Items
            .Add(My.Computer.Info.AvailableVirtualMemory & (" ") & My.Computer.Info.AvailablePhysicalMemory)
            .Add(My.Computer.Clock.TickCount)
            .Add(Environment.TickCount & (" ") & Environment.ProcessorCount & ("") & Environment.CommandLine)
            .Add(Environment.CurrentDirectory)
            .Add(Environment.CurrentManagedThreadId)
            .Add(Environment.StackTrace)
            .Add(Environment.WorkingSet)
            .Add("Looping? " & Application.MessageLoop)
            .Add(vbNewLine)
            .Add("Mem Usage (Working Set) :   " & c.WorkingSet / 1024 & " K")
            .Add("VM Size (Private Bytes) " & c.PagedMemorySize / 1024 & " K")
            .Add("GC TotalMemory " & GC.GetTotalMemory(True) & " bytes" & "Current Memory Usage")
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

    Private Sub tmr_tick_Tick(sender As Object, e As EventArgs)
        ListBox1.Items.Clear()
    End Sub
End Class

