Imports System.Data.OleDb
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Blogin_Click(sender As Object, e As EventArgs) Handles Blogin.Click

        If CNN1.State <> ConnectionState.Closed Then CNN1.Close()
        CNN1.Open()
        Dim OLECMD As OleDbCommand = New OleDbCommand("Select * FROM login WHERE username = '" & TextBox1.Text & "' and Password = '" & TextBox2.Text & "' ", CNN)
        Dim OLERDR As OleDbDataReader = OLECMD.ExecuteReader
        If (OLERDR.Read()) Then

            MsgBox("sukses")
            Form2.ShowDialog()
        Else
            MsgBox("Maaf Username dan Password tidak ditemukan....!", MsgBoxStyle.OkOnly, "Login Gagal")
            TxtUser.Text = ""
            TxtPassword.Text = ""
            TxtUser.Focus()
        End If
    End Sub

    Private Sub Bexit_Click(sender As Object, e As EventArgs) Handles Bexit.Click
        End
    End Sub
End Class