Public Class percabangan_if
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim absen, tugas, uts, uas, total As Integer
        absen = CInt(TextBox1.Text) * 0.1
        tugas = CInt(TextBox2.Text) * 0.2
        uts = CInt(TextBox3.Text) * 0.3
        uas = CInt(TextBox4.Text) * 0.4
        total = absen + tugas + uts + uas

        TextBox5.Text = absen
        TextBox6.Text = tugas
        TextBox7.Text = uts
        TextBox8.Text = uas
        TextBox9.Text = total

        If total >= 81 Then
            TextBox10.Text = "A"
            TextBox11.Text = "LULUS"
        ElseIf total >= 71 Then
            TextBox10.Text = "B"
            TextBox11.Text = "LULUS"
        ElseIf total >= 61 Then
            TextBox10.Text = "C"
            TextBox11.Text = "LULUS"
        ElseIf total >= 51 Then
            TextBox10.Text = "D"
            TextBox11.Text = "GAGAL"
        Else
            TextBox10.Text = "F"
            TextBox11.Text = "GAGAL"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
