Imports System.Data.OleDb
Module Module13
    Public conn As OleDbConnection
    Public Da As OleDbDataAdapter
    Public Ds As DataSet
    Public Cmd As OleDbCommand
    Public Rd As OleDbDataReader
    Dim lokasiDB As String

    Public Sub Koneksi13()
        lokasiDB = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\FormLoginDBAccesss.accdb;"
        conn = New OleDbConnection(lokasiDB)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
End Module
