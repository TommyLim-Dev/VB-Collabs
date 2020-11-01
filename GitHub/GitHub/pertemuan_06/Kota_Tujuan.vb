Public Class Kota_Tujuan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim harga As Integer
        Dim Kota() As String = {"Jakarta", "Batam", "Bandung"}
        If Val(TextBox1.Text) > 0 AndAlso Val(TextBox1.Text) < 4 Then
            If TextBox1.Text = 1 Then
                harga = 500000
            ElseIf TextBox1.Text = 2 Then
                harga = 450000
            ElseIf TextBox1.Text = 3 Then
                harga = 600000
            End If
            MsgBox("Kota tujuan anda : " & Kota(Val(TextBox1.Text) - 1) & vbNewLine & "Seharga = " & (harga * TextBox2.Text).ToString("N"))
        End If
    End Sub
End Class