Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormBarang

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        IsiComboBox()
    End Sub

    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        ComboBox1.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False

        TextBox1.MaxLength = 20

        Button1.Text = "INPUT"
        Button2.Text = "EDIT"
        Button3.Text = "HAPUS"
        Button4.Text = "TUTUP"

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True

        Call Koneksi()

        Da = New OdbcDataAdapter("SELECT * FROM barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "barang")
        DataGridView1.DataSource = Ds.Tables("barang")
    End Sub

    Sub FieldAktif()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox1.Focus()
    End Sub







    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            ' Lakukan koneksi ke database
            Call Koneksi()
            Cmd = New OdbcCommand("SELECT * FROM barang WHERE kode_barang='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                ' Jika kode barang ditemukan, isi textbox lainnya dengan nilai dari database
                TextBox1.Text = Rd.Item("kode_barang")
                TextBox2.Text = Rd.Item("nama_barang")
                TextBox3.Text = Rd.Item("jenis_barang")
                ComboBox1.Text = Rd.Item("satuan_barang")
                TextBox5.Text = Rd.Item("harga_beli")
                TextBox6.Text = Rd.Item("harga_jual")
                TextBox7.Text = Rd.Item("stok")
            Else
                ' Jika kode barang tidak ditemukan, kosongkan nilai textbox lainnya
                TextBox2.Text = ""
                TextBox3.Text = ""
                ComboBox1.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
            End If
        Else
            ' Jika kode barang kosong, kosongkan nilai textbox lainnya
            TextBox2.Text = ""
            TextBox3.Text = ""
            ComboBox1.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
        End If
    End Sub





    Private Sub IsiComboBox()
        ' Membersihkan item yang ada sebelumnya, jika ada
        ComboBox1.Items.Clear()

        ' Tambahkan item-item ke ComboBox
        ComboBox1.Items.Add("Pieces (Pcs)")
        ComboBox1.Items.Add("Kilogram (Kg)")
        ComboBox1.Items.Add("Gram (g)")
        ComboBox1.Items.Add("Liter (L)")
        ComboBox1.Items.Add("Meter (m)")
        ComboBox1.Items.Add("Centimeter (cm)")
        ComboBox1.Items.Add("Dozen (Dz)")
        ComboBox1.Items.Add("Pack")
        ComboBox1.Items.Add("Roll")
        ComboBox1.Items.Add("Box (Bx)")

        ' Pilih item pertama sebagai default
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Sub Otomatis()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from barang where kode_barang in (select max(kode_barang) from barang)", Conn)
        Dim Urutankode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            Urutankode = "BRG" + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            Urutankode = "BRG" + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        TextBox1.Text = Urutankode
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "INPUT" Then
            Button1.Text = "SIMPAN"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "BATAL"
            Call FieldAktif()
            Call Otomatis()
            TextBox1.Enabled = False
            TextBox2.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
                MsgBox("Pastikan semua field terisi")
            Else
                Call Koneksi()
                Dim InputData As String = "INSERT INTO barang VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')"
                Cmd = New OdbcCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input data berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "EDIT" Then
            Button2.Text = "UPDATE"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "BATAL"
            Call FieldAktif()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
                MsgBox("Pastikan semua field terisi")
            Else
                Call Koneksi()
                Dim EditData As String = "UPDATE barang SET kode_barang='" & TextBox1.Text & "', nama_barang='" & TextBox2.Text & "', jenis_barang='" & TextBox3.Text & "', satuan_barang='" & ComboBox1.Text & "', harga_beli='" & TextBox5.Text & "', harga_jual='" & TextBox6.Text & "', stok='" & TextBox7.Text & "' WHERE kode_barang='" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(EditData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Edit data berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "HAPUS" Then
            Button3.Text = "DELETE"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "BATAL"
            Call FieldAktif()
        Else
            If TextBox1.Text = "" Then
                MsgBox("Pastikan data yang akan dihapus terisi")
            Else
                Call Koneksi()
                Dim HapusData As String = "DELETE FROM barang WHERE kode_barang='" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Hapus data berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "TUTUP" Then
            End
        Else
            Call KondisiAwal()
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Dispose()
    End Sub


End Class
