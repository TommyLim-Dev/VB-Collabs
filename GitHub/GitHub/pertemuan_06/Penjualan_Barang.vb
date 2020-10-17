Public Class Penjualan_Barang
    Private Structure PenjualanBarang
        Dim nama As String
        Dim Harga As Double
        Dim Jumlah As Double
        Dim Diskon As Double
        Dim total As Double
    End Structure
    Dim indeks As Integer
    Dim data() As PenjualanBarang
    Sub DaftarPenjualan()
        data(indeks).nama = TextBox2.Text
        data(indeks).Harga = TextBox3.Text
        data(indeks).Jumlah = TextBox4.Text
        data(indeks).Diskon = TextBox5.Text
        data(indeks).Total = TextBox6.Text
    End Sub
    Sub HapusDaftar()
        TextBox2.Text = ""
        TextBox3.Text = "0"
        TextBox4.Text = "0"
        TextBox5.Text = "0"
        TextBox6.Text = "0"
        TextBox2.Focus()
    End Sub

    Sub tampilanData()
        MsgBox("Informasi Penjualan Barang ke- " & indeks & Chr(10) &
               "Nama Barang   : " & data(indeks).nama & Chr(10) &
               "Harga Barang  : " & data(indeks).Harga & Chr(10) &
               "Jumlah Barang : " & data(indeks).Jumlah & Chr(10) &
               "Diskon : " & data(indeks).Diskon & Chr(10) &
               "Total Bayar   : " & data(indeks).total, , "Penjualan Barang")
    End Sub
    Sub tampilanform()
        TextBox2.Text = CStr(data(indeks).nama)
        TextBox3.Text = CStr(data(indeks).Harga)
        TextBox4.Text = CStr(data(indeks).Jumlah)
        TextBox5.Text = CStr(data(indeks).Diskon)
        TextBox6.Text = CStr(data(indeks).total)
    End Sub


    Private Sub Penjualan_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        indeks = 1
        ReDim data(indeks)
        TextBox1.Text = indeks
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HapusDaftar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DaftarPenjualan()
        tampilanData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If indeks = 1 Then
        ElseIf indeks > LBound(data) Then
            DaftarPenjualan()
            indeks = indeks - 1
            tampilanform()
        End If
        If indeks = 0 Then indeks = 1
        TextBox1.Text = indeks
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If indeks = UBound(data) Then
            ReDim Preserve data(indeks + 1)
        End If
        TextBox1.Text = indeks
        DaftarPenjualan()
        indeks = indeks + 1
        TextBox1.Text = indeks
        tampilanform()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim total As String
        Dim diskon As String
        If TextBox3.Text = "" Then
            TextBox3.Text = "0"
        ElseIf TextBox4.Text = "" Then
            TextBox4.Text = "0"
        ElseIf TextBox5.Text = "" Then
            TextBox5.Text = "0"
        ElseIf TextBox6.Text = "" Then
            TextBox6.Text = "0"
        End If
        total = (Val(TextBox3.Text * TextBox4.Text * TextBox5.Text))
        diskon = total / 100
        TextBox6.Text = total - diskon
        TextBox6.Text = (Val(TextBox3.Text) * Val(TextBox4.Text) * Val(TextBox5.Text) / 100)
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim total As Double
        Dim diskon As Double
        If TextBox3.Text = "" Then
            TextBox3.Text = "0"
        ElseIf TextBox4.Text = "" Then
            TextBox4.Text = "0"
        ElseIf TextBox5.Text = "" Then
            TextBox5.Text = "0"
        ElseIf TextBox6.Text = "" Then
            TextBox6.Text = "0"
        End If

        total = (Val(TextBox3.Text * TextBox4.Text * TextBox5.Text))
        diskon = total / 100
        TextBox6.Text = total - diskon
        TextBox6.Text = (Val(TextBox3.Text) * Val(TextBox4.Text) * Val(TextBox5.Text) / 100)
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Dim total As Double
        Dim diskon As Double
        If TextBox3.Text = "" Then
            TextBox3.Text = "0"
        ElseIf TextBox4.Text = "" Then
            TextBox4.Text = "0"
        ElseIf TextBox5.Text = "" Then
            TextBox5.Text = "0"
        ElseIf TextBox6.Text = "" Then
            TextBox6.Text = "0"
        End If

        total = (Val(TextBox3.Text * TextBox4.Text))
        diskon = total * (Val(TextBox5.Text) / 100)
        TextBox6.Text = total - diskon
    End Sub
End Class