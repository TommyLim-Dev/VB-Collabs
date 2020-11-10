Imports System.Data
Imports System.Data.OleDb

Public Class Formawal1
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
        CNN = New OleDbConnection(KONEKSI)
        If CNN.State <> ConnectionState.Closed Then CNN.Close()
        CNN.Open()
        OLECMD = New OleDbCommand("insert into Pegawai (NIP,NamaPgw,Bagian,TglLhr,Alamat,Pendidikan,Status) Values ('" &
                                  txtNIP.Text & "','" & txtNama.Text & "', '" & cmbBgn.Text & "', '" & DTglLhr.Value & "', 
                                 '" & txtAlamat.Text & "', '" & cmbPend.Text & "', '" & kawin & "')", CNN)

        X = OLECMD.ExecuteNonQuery
        If X = True Then
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
        Dim popppegawai As New poppegs
        popppegawai.ShowDialog()
        If popppegawai.colNama <> "" Then
            txtNIP.Text = popppegawai.colNIP
            txtNama.Text = popppegawai.colNama
            cmbBgn.Text = popppegawai.colbgn
            DTglLhr.Value = popppegawai.coltgllhr
            txtAlamat.Text = popppegawai.colAlamat
            cmbPend.Text = popppegawai.colPend
            If popppegawai.colstatus = "Kawin" Then
                RKwn.Checked = True
            Else
                RKwn.Checked = False
            End If
            txtNIP.Enabled = False
            txtNama.Focus()
        End If
        BEdit.Enabled = True
        BDelete.Enabled = True

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
        CNN = New OleDbConnection(KONEKSI)
        If CNN.State <> ConnectionState.Closed Then CNN.Close()
        CNN.Open()
        OLECMD = New OleDbCommand("Update Pegawai Set NamaPgw='" & txtNama.Text &
        "',Bagian='" & cmbBgn.Text &
        "',TglLhr='" & DTglLhr.Value &
        "',Alamat='" & txtAlamat.Text &
        "',Pendidikan='" & cmbPend.Text &
        "',Status='" & kawin & "' where NIP ='" & txtNIP.Text & "'", CNN)

        X = OLECMD.ExecuteNonQuery
        If X = True Then
            MsgBox("Data berhaisil diedit", MsgBoxStyle.Information, "Informasi")
            Call BERSIH()
            txtNIP.Focus()
        Else
            MsgBox("Gagal mengedit data", MsgBoxStyle.Exclamation, "Kesalahan")
        End If
    End Sub

    Private Sub BDelete_Click(sender As Object, e As EventArgs) Handles BDelete.Click
        If MsgBox("Ingin menghapus data?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            CNN = New OleDbConnection(KONEKSI)
            If CNN.State <> ConnectionState.Closed Then CNN.Close()
            CNN.Open()
            OLECMD = New OleDbCommand("delete from Pegawai where NIP='" & txtNIP.Text & "'", CNN)
            X = OLECMD.ExecuteNonQuery
            If X = True Then
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




