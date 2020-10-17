Public Class select_case_03
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Select Case (TextBox1.Text)
            Case "SI"
                Label2.Text = "Sistem Informasi"
                Label3.Text = "Strata - 1"
            Case "TI"
                Label2.Text = "Teknik Informatika"
                Label3.Text = "Strata - 1"
            Case "AK"
                Label2.Text = "Akuntansi"
                Label3.Text = "Strata - 1"
            Case Else
                Label2.Text = "Jurusan Belum Terdaftar"
                Label3.Text = "Not Found"
        End Select
    End Sub
End Class
