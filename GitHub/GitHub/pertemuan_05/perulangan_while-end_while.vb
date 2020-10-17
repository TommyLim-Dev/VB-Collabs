Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        ListBox1.Items.Clear()
        i = 1
        While i <= 10
            ListBox1.Items.Add(i)
            i += 1
        End While
    End Sub
End Class
