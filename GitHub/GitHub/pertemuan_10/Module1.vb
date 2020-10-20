Imports System.Data.OleDb
Module Module1

    Public Da As OleDbDataAdapter
    Public Ds As DataSet
    Dim LokasiDB As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=DBAplikasi.accdb"
    Public CNN As OleDbConnection = New OleDbConnection(LokasiDB)


End Module
