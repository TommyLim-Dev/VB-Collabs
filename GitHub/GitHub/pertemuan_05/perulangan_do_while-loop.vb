Public Class do_while_loop
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        ListBox1.Items.Clear()
        i = 1
        Do While i <= 10
            ListBox1.Items.Add(i)
            i += 1
        Loop
    End Sub
End Class
