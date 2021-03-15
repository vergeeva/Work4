Public Class Form2
    Dim DiskName As String 'переменная для имени диска
    Private Sub DriveListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DriveListBox1.SelectedIndexChanged
        Try
            DiskName = DriveListBox1.Drive
            DirListBox1.Path = DiskName & "\"
            FileListBox1.Path = DirListBox1.Path
        Catch
            MessageBox.Show("Диск недоступен", "Сообщение")
        End Try

    End Sub

    Private Sub DirListBox1_Change(sender As Object, e As EventArgs) Handles DirListBox1.Change
        FileListBox1.Path = DirListBox1.Path
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class