Public Class Kota_Tujuan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Kota() As String = {"Jakarta", "Batam", "Bandung"}
        If Val(TextBox1.Text) > 0 AndAlso Val(TextBox1.Text) < 4 Then
            MsgBox("Kota tujuan anda : " & Kota(Val(TextBox1.Text) - 1))
        End If
    End Sub
End Class