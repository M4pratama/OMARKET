Imports System
Imports System.Data.Odbc
Imports System.Runtime.Remoting.Messaging
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FRMBeli_Barang
    Dim TglMySQL As String
    Sub KondisiAwal()
        LblTelepon.Text = ""
        LblTanggal.Text = Today
        LblAlamat.Text = ""
        LblKembali.Text = ""
        LblNama.Text = ""
        LblNamaBarang.Text = ""
        Label12.Text = ""
        Call Otomatis()
        Call Buatkolom()
        Label4.Text = "0"
        Button1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'tmer
        LblJam.Text = TimeOfDay
    End Sub
    Private Sub FRMBeli_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Nonaktifkan tombol Button1 saat form dimuat
        Call KondisiAwal()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Pastikan username dan password tidak kosong
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Nama User dan Password tidak boleh kosong", vbExclamation)
        Else
            ' Lakukan koneksi ke database
            Call Koneksi()

            ' Lakukan query ke database untuk mencocokkan username dan password
            Cmd = New OdbcCommand("SELECT * FROM tbl_user WHERE namauser='" & TextBox1.Text & "' AND passworduser = '" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader

            ' Jika data ditemukan, isi semua Label
            If Rd.HasRows Then
                Rd.Read()
                LblNama.Text = Rd("namauser").ToString()
                LblAlamat.Text = Rd("alamatuser").ToString()
                LblTelepon.Text = Rd("telpuser").ToString()

                ' Aktifkan tombol Button1 setelah memasukkan username dan password dengan benar
                Button1.Enabled = True
            Else
                ' Jika tidak ada data yang cocok dengan username dan password
                MsgBox("Username atau password salah", vbExclamation)
            End If

            ' Tutup koneksi setelah selesai menggunakan
            Conn.Close()
        End If
    End Sub

    'Button1(Simpan)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Kode yang akan dieksekusi ketika tombol Button1 diklik
        If LblKembali.Text = "" Or Label4.Text = "" Then
            MsgBox("Silahkan Melakukan Transaksi Terlebih Dahulu!")
        Else
            Try
                ' Buka koneksi ke database sebelum menjalankan pernyataan SQL
                Conn.Open()
                TglMySQL = Format(Today, "yyy-MM-dd")
                Dim SimpanJual As String = "Insert into jual values ('" & LblNoJual.Text & "', '" & TglMySQL & "', '" & LblJam.Text & "', '" & LblItem.Text & "', '" & Label4.Text & "', '" & TextBox4.Text & "', '" & LblKembali.Text & "', '" & LblNama.Text & "') "
                Cmd = New OdbcCommand(SimpanJual, Conn)
                Cmd.ExecuteNonQuery()

                For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                    Dim kodeBarang As String = DataGridView1.Rows(Baris).Cells(0).Value.ToString()
                    Dim jumlahBeli As Integer = Convert.ToInt32(DataGridView1.Rows(Baris).Cells(3).Value)
                    ' Ambil stok barang dari database
                    Dim queryStok As String = "SELECT stok FROM barang WHERE kode_barang = '" & kodeBarang & "'"
                    Cmd = New OdbcCommand(queryStok, Conn)
                    Dim stok As Integer = Convert.ToInt32(Cmd.ExecuteScalar())

                    ' Cetak nilai stok sebelum pengurangan
                    Console.WriteLine("Stok sebelum pengurangan untuk barang " & kodeBarang & ": " & stok)

                    ' Kurangi stok dengan jumlah barang yang dibeli
                    Dim stokBaru As Integer = stok - jumlahBeli

                    ' Cetak nilai stok setelah pengurangan
                    Console.WriteLine("Stok setelah pengurangan untuk barang " & kodeBarang & ": " & stokBaru)

                    ' Update stok barang di database
                    Dim updateStok As String = "UPDATE barang SET stok = " & stokBaru & " WHERE kode_barang = '" & kodeBarang & "'"
                    Cmd = New OdbcCommand(updateStok, Conn)
                    Cmd.ExecuteNonQuery()


                    ' Cetak nilai stok setelah pengurangan
                    Console.WriteLine("Stok setelah pengurangan untuk barang " & kodeBarang & ": " & stokBaru)
                Next
                ' Setelah menjalankan pernyataan SQL, pastikan untuk menutup koneksi
                Conn.Close()

                Call KondisiAwal()
                MsgBox("Transaksi Telah Berhasil")
            Catch ex As Exception
                ' Tangani kesalahan dan tampilkan pesan kesalahan
                MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Exclamation)
            Finally
                ' Pastikan koneksi ditutup, bahkan jika terjadi kesalahan
                If Conn.State = ConnectionState.Open Then
                    Conn.Close()
                End If
            End Try
        End If
    End Sub





    'Mengatur kode no faktur otomatis
    Sub Otomatis()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from jual where faktur_jual In (Select max(faktur_jual) from jual)", Conn)
        Dim Urutankode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            Urutankode = "J" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            Urutankode = "J" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LblNoJual.Text = Urutankode
    End Sub

    Sub Buatkolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode")
        DataGridView1.Columns.Add("Nama", "Nama Barang")
        DataGridView1.Columns.Add("harga", "Harga")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns.Add("SubTotal", "SubTotal")
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        ' Lakukan pencarian ketika tombol Enter ditekan
        If e.KeyChar = ChrW(Keys.Enter) Then
            ' Pastikan TextBox3 tidak kosong sebelum melakukan pencarian
            If TextBox3.Text <> "" Then
                ' Panggil fungsi koneksi
                Call Koneksi()

                ' Lakukan kueri SQL untuk mencari kode barang
                Cmd = New OdbcCommand("Select * FROM barang WHERE kode_barang='" & TextBox3.Text & "'", Conn)
                Rd = Cmd.ExecuteReader

                ' Jika kode barang ditemukan
                If Rd.Read() Then
                    ' Isi TextBox dan Label dengan nilai dari database
                    TextBox3.Text = Rd.Item("kode_barang").ToString()
                    LblNamaBarang.Text = Rd.Item("nama_barang").ToString()
                    Label12.Text = Rd.Item("harga_jual").ToString()
                Else
                    ' Jika kode barang tidak ditemukan, kosongkan Label
                    LblNamaBarang.Text = ""
                    Label12.Text = ""
                    ' Tampilkan pesan peringatan
                    MsgBox("Kode barang tidak ditemukan!", MsgBoxStyle.Exclamation)
                End If

                ' Tutup koneksi setelah selesai
                Conn.Close()
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Pastikan TextBox3 dan TextBox5 tidak kosong sebelum menambahkan baris
        If TextBox3.Text <> "" AndAlso TextBox5.Text <> "" Then
            ' Tambahkan baris ke DataGridView1
            DataGridView1.Rows.Add(New String() {TextBox3.Text, LblNamaBarang.Text, Label12.Text, TextBox5.Text, Val(Label12.Text) * Val(TextBox5.Text)})

            ' Hitung subtotal
            Call RumusSubotal()
            Call rumuscariitem()

            ' Kosongkan TextBox3, TextBox5, LblNamaBarang, dan Label12
            TextBox3.Text = ""
            TextBox5.Text = ""
            LblNamaBarang.Text = ""
            Label12.Text = ""
        Else
            MsgBox("Pastikan Kode Barang dan Jumlah Beli tidak kosong!", MsgBoxStyle.Exclamation)
        End If
    End Sub


    Sub RumusSubotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung += Convert.ToInt32(DataGridView1.Rows(i).Cells(4).Value)
        Next
        Label4.Text = hitung.ToString()
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox4.Text) < Val(Label4.Text) Then
                MsgBox("Pembayaran Kurang!")
            ElseIf Val(TextBox4.Text) = Val(Label4.Text) Then
                LblKembali.Text = 0
            ElseIf Val(TextBox4.Text) > Val(Label4.Text) Then
                LblKembali.Text = Val(TextBox4.Text) - Val(Label4.Text)
                Button1.Focus()
            End If
        End If
    End Sub

    Sub rumuscariitem()
        Dim HitungItem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            HitungItem = HitungItem + DataGridView1.Rows(i).Cells(3).Value
            LblItem.Text = HitungItem
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class