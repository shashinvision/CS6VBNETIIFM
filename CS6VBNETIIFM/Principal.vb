Public Class Principal



    Private Sub MantenciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenciónToolStripMenuItem.Click
        Dim mantencionFR As New MantencionFR
        mantencionFR.MdiParent = Me
        mantencionFR.Show()
    End Sub

    Private Sub NavegaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NavegaciónToolStripMenuItem.Click
        Dim navegacionFR As New NavegacionFR
        navegacionFR.MdiParent = Me
        navegacionFR.Show()

    End Sub
End Class
