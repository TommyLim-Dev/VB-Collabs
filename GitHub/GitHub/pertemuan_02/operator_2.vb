Public Class operator_2
    Dim nilai1, nilai2 As Double
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error GoTo salah
        nilai1 = text1.Text
        nilai2 = text2.Text

        If RadioButton1.Checked = True Then
            hasil.Text = nilai1 / nilai2
        End If
        If RadioButton2.Checked = True Then
            hasil.Text = nilai1 Mod nilai2
        End If
        If RadioButton3.Checked = True Then
            hasil.Text = nilai1 ^ nilai2
        End If
        If RadioButton4.Checked = True Then
            hasil.Text = nilai1 & nilai2
        End If
        Exit Sub
salah:  MsgBox("Data yang anda masukkan kurang lengkap")
    End Sub
End Class
