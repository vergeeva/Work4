Public Class Form1
    Private Sub ОткрытьВторуюФормуToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ОткрытьВторуюФормуToolStripMenuItem1.Click
        Dim Frm As Form = New Form2
        Frm.ShowDialog()
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыходToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ОткрытьВторуюФормуToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОткрытьВторуюФормуToolStripMenuItem.Click
        Dim Frm As Form = New Form2
        Frm.ShowDialog()
    End Sub

    Private Sub ЗакрытьToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗакрытьToolStripMenuItem.Click
        Close()
    End Sub
End Class
