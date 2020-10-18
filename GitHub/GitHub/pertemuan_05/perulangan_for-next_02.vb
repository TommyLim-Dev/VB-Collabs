Public Class for_next_2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        ListBox1.Items.Clear()
        For i = 10 To 1 Step -1
            ListBox1.Items.Add(i)
        Next
    End Sub
End Class
