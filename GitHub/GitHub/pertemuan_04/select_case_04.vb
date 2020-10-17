Public Class select_case_04
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case Val(TextBox1.Text)
            Case 81 To 100
                Label2.Text = "A"
                Label3.Text = "Memuaskan"
            Case 71 To 80
                Label2.Text = "B"
                Label3.Text = "Baik"
            Case 61 To 70
                Label2.Text = "C"
                Label3.Text = "Cukup"
            Case 51 To 60
                Label2.Text = "D"
                Label3.Text = "Kurang"
            Case 0 To 50
                Label2.Text = "F"
                Label3.Text = "Gagal"
            Case Else
                MsgBox("Nilai yang anda masukkan salah!")
        End Select
    End Sub
End Class
