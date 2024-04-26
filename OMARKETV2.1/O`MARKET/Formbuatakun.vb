Imports System.Data.Odbc

Public Class formbuatakun

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox1.MaxLength = 20

        Button1.Text = "BUAT"
        Button2.Text = "BATAL"

        Button1.Enabled = True
        Button2.Enabled = True

        Call Koneksi()

        Da = New OdbcDataAdapter("SELECT * FROM tbl_user", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_user")
    End Sub

    Sub FieldAktif()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "BUAT" Then
            Button1.Text = "SIMPAN"
            Button2.Enabled = True

            ' Panggil fungsi FieldAktif untuk mengaktifkan TextBox1 dan TextBox2
            Call FieldAktif()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
                MsgBox("Pastikan Semuanya Telah di Isi Dengan Benar", vbExclamation)
            Else
                Call Koneksi()
                Dim InputData As String = "INSERT INTO tbl_user VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
                Cmd = New OdbcCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Buat Akun Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "BATAL" Then
            Me.Close()

        Else
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub
End Class