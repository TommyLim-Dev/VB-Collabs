Public Class Maskapai_Penerbangan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pesawat() As String = {"Garuda", "Lion", "Citilink", "Sriwijaya", "Batik", "Air Asia"}
        If Val(TextBox1.Text) > 0 AndAlso Val(TextBox1.Text) < 7 Then
            MsgBox("Pilihan Maskapai anda adalah : " & pesawat(Val(TextBox1.Text) - 1))
        End If

    End Sub
End Class