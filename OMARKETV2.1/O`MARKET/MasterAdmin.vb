Imports System.Data.Odbc

Public Class MasterAdmin
    Private Sub MasterAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub

    Sub FieldAktif()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox5.Enabled = True
        TextBox1.Focus()
    End Sub

    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox5.Text = ""

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox5.Enabled = False

        TextBox1.MaxLength = 20

        Button1.Text = "INPUT"
        Button2.Text = "EDIT"
        Button3.Text = "HAPUS"
        Button4.Text = "TUTUP"

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True

        Koneksi()

        Dim Da As New OdbcDataAdapter("SELECT * FROM tbl_adm", Conn)
        Dim Ds As New DataSet
        Da.Fill(Ds, "tbl_adm")
        DataGridView1.DataSource = Ds.Tables("tbl_adm")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "INPUT" Then
            Button1.Text = "SIMPAN"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "BATAL"
            FieldAktif()
            TextBox1.Focus()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Then
                MsgBox("Pastikan semua field terisi")
            Else
                Koneksi()
                Dim InputData As String = "INSERT INTO tbl_adm VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox5.Text & "')"
                Dim Cmd As New OdbcCommand(InputData, Conn)
                Try
                    Cmd.ExecuteNonQuery()
                    MsgBox("Input data berhasil")
                    KondisiAwal()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "EDIT" Then
            Button2.Text = "UPDATE"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "BATAL"
            FieldAktif()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Then
                MsgBox("Pastikan semua field terisi")
            Else
                Koneksi()
                Dim EditData As String = "UPDATE tbl_adm SET passwordadmin='" & TextBox2.Text & "', kodeadmin='" & TextBox3.Text & "', leveladmin='" & TextBox5.Text & "' WHERE namaadmin='" & TextBox1.Text & "'"
                Dim Cmd As New OdbcCommand(EditData, Conn)
                Try
                    Cmd.ExecuteNonQuery()
                    MsgBox("Edit data berhasil")
                    KondisiAwal()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "HAPUS" Then
            Button3.Text = "DELETE"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "BATAL"
            FieldAktif()
        Else
            If TextBox1.Text = "" Then
                MsgBox("Pastikan data yang akan dihapus terisi")
            Else
                Koneksi()
                Dim HapusData As String = "DELETE FROM tbl_adm WHERE namaadmin ='" & TextBox1.Text & "'"
                Dim Cmd As New OdbcCommand(HapusData, Conn)
                Try
                    Cmd.ExecuteNonQuery()
                    MsgBox("Hapus data berhasil")
                    KondisiAwal()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "TUTUP" Then
            End
        Else
            KondisiAwal()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            Koneksi()
            Dim Cmd As New OdbcCommand("SELECT * FROM tbl_adm WHERE namaadmin='" & TextBox1.Text & "'", Conn)
            Dim Rd As OdbcDataReader
            Try
                Rd = Cmd.ExecuteReader
                If Rd.Read Then
                    TextBox2.Text = Rd.Item("passwordadmin").ToString()
                    TextBox3.Text = Rd.Item("kodeadmin").ToString()
                    TextBox5.Text = Rd.Item("leveladmin").ToString()
                Else
                    TextBox2.Text = ""
                    TextBox3.Text = ""
                    TextBox5.Text = ""
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        Else
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox5.Text = ""
        End If
    End Sub

    Sub Koneksi()
        Conn = New OdbcConnection("Driver={MySQL ODBC 5.3 ANSI Driver};Database=penjualan1;Server=localhost;uid=root")
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Dim Conn As OdbcConnection
End Class
