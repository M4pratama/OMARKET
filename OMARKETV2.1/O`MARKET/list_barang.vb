Imports System.Data.Odbc

Public Class list_barang

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub list_barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        RefreshData()
        DataGridView1.ReadOnly = True ' Mengatur DataGridView menjadi hanya baca
    End Sub

    Private Sub RefreshData()
        ' Lakukan koneksi dan tampilkan data
        Da = New OdbcDataAdapter("SELECT * FROM barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "barang")
        DataGridView1.DataSource = Ds.Tables("barang")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Lakukan pencarian berdasarkan teks yang dimasukkan ke TextBox
        Dim keyword As String = TextBox1.Text.Trim()

        If Not String.IsNullOrEmpty(keyword) Then
            Call Koneksi()
            Dim query As String = "SELECT * FROM barang WHERE nama_barang LIKE '%" & keyword & "%' OR jenis_barang LIKE '%" & keyword & "%'"
            Da = New OdbcDataAdapter(query, Conn)
            Ds = New DataSet
            Da.Fill(Ds, "barang")
            DataGridView1.DataSource = Ds.Tables("barang")
        Else
            ' Jika TextBox kosong, tampilkan semua data
            RefreshData()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Panggil pencarian setiap kali teks dalam TextBox berubah
        Button1_Click(Nothing, Nothing)
    End Sub
End Class

