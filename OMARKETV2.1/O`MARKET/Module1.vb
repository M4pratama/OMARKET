Imports System.Data.Odbc


Module Module1
    Public Conn As OdbcConnection
    Public Cmd As OdbcCommand
    Public Ds As DataSet
    Public Da As OdbcDataAdapter
    Public Rd As OdbcDataReader

    Public MyDB As String
    Public Sub Koneksi()
        MyDB = "Driver={MySQL ODBC 5.3 ANSI Driver};Database=penjualan1;Server=localhost;uid=root"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

End Module
