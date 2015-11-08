Public Class frmReload
    Private Sub frmReload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLvl1.Close()
        frmLvl1.Show()
        Me.Close()
    End Sub
End Class