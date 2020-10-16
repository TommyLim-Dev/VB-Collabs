Public Class operator_relasi
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim var1, var2 As Integer
        var1 = TextBox1.Text
        var2 = TextBox2.Text
        If RadioButton1.Checked = True Then
            TextBox3.Text = var1 > var2
        End If
        If RadioButton2.Checked = True Then
            TextBox3.Text = var1 < var2
        End If
        If RadioButton3.Checked = True Then
            TextBox3.Text = var1 >= var2
        End If
        If RadioButton4.Checked = True Then
            TextBox3.Text = var1 <= var2
        End If
        If RadioButton5.Checked = True Then
            TextBox3.Text = var1 = var2
        End If
        If RadioButton6.Checked = True Then
            TextBox3.Text = var1 <> var2
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim keluar As String
        keluar = MsgBox("Anda ingin keluar")
        If keluar = vbOK Then
            End
        End If
    End Sub
End Class
