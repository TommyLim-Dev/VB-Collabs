﻿Imports System.Data
Imports System.Data.OleDb

Public Class formawal
    Sub BERSIH()
        txtNIP.Text = ""
        txtNama.Text = ""
        txtAlamat.Text = ""
        cmbBgn.Text = ""
        cmbPend.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BSave_Click(sender As Object, e As EventArgs) Handles BSave.Click
        Dim kawin As String

        If txtNIP.Text = "" Or txtNama.Text = "" Then
            MsgBox("Isi data dengan benar", MsgBoxStyle.Exclamation, "Kesalahan")
            Exit Sub
        End If

        If RBlmKwn.Checked = True Then
            kawin = "Belum Kawin"
        Else
            kawin = "Kawin"
        End If

        If Module11.CNN.State <> ConnectionState.Closed Then Module11.CNN.Close()
        Module11.CNN.Open()
        Module11.OLECMD = New OleDbCommand("insert into Pegawai (NIP,NamaPgw,Bagian,TglLhr,Alamat,Pendidikan,Status) Values ('" &
                                  txtNIP.Text & "','" & txtNama.Text & "', '" & cmbBgn.Text & "', '" & DTglLhr.Value & "', 
                                 '" & txtAlamat.Text & "', '" & cmbPend.Text & "', '" & kawin & "')", Module11.CNN)

        Module11.X = Module11.OLECMD.ExecuteNonQuery
        If Module11.X = True Then
            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")
            Call BERSIH()
            txtNIP.Focus()
        Else
            MsgBox("Gagal menyimpan data", MsgBoxStyle.Information, "Kesalahan")
        End If

    End Sub

    Private Sub BCancel_Click(sender As Object, e As EventArgs) Handles BCancel.Click
        Call BERSIH()
        BSave.Enabled = True
        BEdit.Enabled = False
        BDelete.Enabled = False
        txtNIP.Enabled = True
        txtNIP.Focus()

    End Sub

    Private Sub txtNIP_TextChanged(sender As Object, e As EventArgs) Handles txtNIP.TextChanged

    End Sub

    Private Sub BExit_Click(sender As Object, e As EventArgs) Handles BExit.Click
        Me.Dispose()
    End Sub

    Private Sub BCari_Click(sender As Object, e As EventArgs) Handles BCari.Click
        Dim popppegawai As New poppeg2
        popppegawai.ShowDialog()


    End Sub

    Private Sub BEdit_Click(sender As Object, e As EventArgs) Handles BEdit.Click
        Dim kawin As String
        If txtNIP.Text = "" Or txtNama.Text = "" Then
            MsgBox("Isi data dengan benar", MsgBoxStyle.Exclamation, "Kesalahan")
            Exit Sub
        End If
        If RBlmKwn.Checked = True Then
            kawin = "belum kawin"
        Else
            kawin = "Kawin"
        End If
        If Module11.CNN.State <> ConnectionState.Closed Then Module11.CNN.Close()
        Module11.CNN.Open()
        Module11.OLECMD = New OleDbCommand("Update Pegawai Set NamaPgw='" & txtNama.Text &
        "',Bagian='" & cmbBgn.Text &
        "',TglLhr='" & DTglLhr.Value &
        "',Alamat='" & txtAlamat.Text &
        "',Pendidikan='" & cmbPend.Text &
        "',Status='" & kawin & "' where NIP ='" & txtNIP.Text & "'", Module11.CNN)

        Module11.X = Module11.OLECMD.ExecuteNonQuery
        If Module11.X = True Then
            MsgBox("Data berhaisil diedit", MsgBoxStyle.Information, "Informasi")
            Call BERSIH()
            txtNIP.Focus()
        Else
            MsgBox("Gagal mengedit data", MsgBoxStyle.Exclamation, "Kesalahan")
        End If
    End Sub

    Private Sub BDelete_Click(sender As Object, e As EventArgs) Handles BDelete.Click
        If MsgBox("Ingin menghapus data?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            If Module11.CNN.State <> ConnectionState.Closed Then Module11.CNN.Close()
            Module11.CNN.Open()
            Module11.OLECMD = New OleDbCommand("delete from Pegawai where NIP='" & txtNIP.Text & "'", Module11.CNN)
            Module11.X = Module11.OLECMD.ExecuteNonQuery
            If Module11.X = True Then
                Call BERSIH()
                BSave.Enabled = True
                BEdit.Enabled = False
                BDelete.Enabled = False
                txtNIP.Focus()
            Else
                MsgBox("Gagal menghapus data", MsgBoxStyle.Exclamation, "kesalahan")
            End If
        End If
    End Sub

    Private Sub cmbBgn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBgn.SelectedIndexChanged

    End Sub

    Private Sub txtNIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIP.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNama.Focus()
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmbBgn.Focus()
        End If
    End Sub

    Private Sub cmbPend_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPend.SelectedIndexChanged

    End Sub

    Private Sub cmbBgn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbBgn.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmbPend.Focus()
        End If
    End Sub

    Private Sub txtAlamat_TextChanged(sender As Object, e As EventArgs) Handles txtAlamat.TextChanged

    End Sub
End Class




