Imports System.Data.Odbc

Imports System.Drawing.Drawing2D

Public Class FormLogin


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ' Menampilkan pesan konfirmasi sebelum keluar
        Dim result As MsgBoxResult
        result = MsgBox("Apakah Anda yakin ingin keluar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi Keluar")

        ' Jika pengguna menekan tombol Yes, maka aplikasi akan keluar
        If result = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub


    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub


    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Nama User dan Password tidak boleh kosong", vbExclamation)
        Else
            Call Koneksi()

            ' Cek apakah login sebagai user
            Cmd = New OdbcCommand("SELECT * FROM tbl_user WHERE namauser='" & TextBox1.Text & "' AND passworduser = '" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Rd.HasRows Then
                ' Mengatur properti IsLoggedIn pada FormMenuUser menjadi True
                FormMenuUser.IsLoggedIn = True
                FormMenuUser.Username = TextBox1.Text
                Me.Hide() ' Menyembunyikan Form Login
                FormMenuUser.Show() ' Menampilkan Form Menu User
            Else
                ' Cek apakah login sebagai admin
                Cmd = New OdbcCommand("SELECT * FROM tbl_adm WHERE namaadmin='" & TextBox1.Text & "' AND passwordadmin = '" & TextBox2.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()

                If Rd.HasRows Then
                    ' Mengatur properti IsLoggedIn pada FormMenuAdmin menjadi True
                    FormMenuAdmin.IsLoggedIn = True
                    FormMenuAdmin.Username = TextBox1.Text ' Set Username di FormMenuAdmin
                    Me.Hide() ' Menyembunyikan Form Login
                    FormMenuAdmin.Show() ' Menampilkan Form Menu Admin
                Else

                    ' Jika tidak ada data yang cocok dengan username dan password

                    TextBox1.Text = "" ' Menghapus isi TextBox1
                    TextBox2.Text = "" ' Menghapus isi TextBox2
                End If
            End If
        End If
    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Dim formBuatAkun As New formbuatakun()
        formBuatAkun.ShowDialog()
    End Sub
End Class