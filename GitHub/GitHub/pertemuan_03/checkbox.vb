Public Class checkbox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pilihan As String
        pilihan = "Anda Memilih "
        If CheckBox1.Checked = True Then
            pilihan = pilihan & "Sate "
        End If
        If CheckBox2.Checked = True Then
            pilihan = pilihan & "Soto "
        End If
        If CheckBox3.Checked = True Then
            pilihan = pilihan & "Kare "
        End If
        MsgBox(pilihan & ", Pesanan anda akan segera diantar")
    End Sub
End Class
