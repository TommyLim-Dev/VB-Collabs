Public Class radiobuttons
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pilihan As String
        pilihan = "Anda memilih "
        If RadioButton1.Checked = True Then
            pilihan = pilihan & "Sate"
        End If
        If RadioButton2.Checked = True Then
            pilihan = pilihan & "Soto"
        End If
        If RadioButton3.Checked = True Then
            pilihan = pilihan & "Kare"
        End If
        MsgBox(pilihan & ", Pesanan anda akan segera diantar")
    End Sub
End Class
