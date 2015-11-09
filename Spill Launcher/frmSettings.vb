Public Class frmSettings
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

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ("Username: " & My.Settings.username)
        If My.Settings.screensize = False Then
            Label2.Text = ("Screen resolution: 1280 x 720")
        Else
            Label2.Text = ("Screen resolution: 1440 x 1080")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case MsgBox("Save settings?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Save Settings?")
            Case MsgBoxResult.Yes
                My.Settings.Save()
                Me.Close()
            Case MsgBoxResult.No
                Me.Close()
                frmLvl1.BringToFront() 'Focus funke også
        End Select
    End Sub
End Class