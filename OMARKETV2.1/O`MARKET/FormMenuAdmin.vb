Public Class FormMenuAdmin
    ' Properti untuk menandai apakah pengguna telah login atau tidak
    Public Property IsLoggedIn As Boolean = False
    Public Property Username As String

    ' Kode lainnya di sini
    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsLoggedIn Then
            ' Jika pengguna belum login, tampilkan FormLogin
            Dim loginForm As New FormLogin
            loginForm.ShowDialog()
        End If
        ' Kode lainnya di sini
        LblNama.Text = Username
        dashboard.TopLevel = False
        MasterAdmin.TopLevel = False
        Panel1.Controls.Add(dashboard)
        Panel1.Controls.Add(MasterAdmin)
        dashboard.Show()
    End Sub

    Sub KondisiAwal()
        ' Set label nama menjadi kosong
        LblNama.Text = ""
    End Sub

    ' ... kode lainnya

    Private Sub LblNama_TextChanged(sender As Object, e As EventArgs)
        ' Saat teks di LabelNama berubah, periksa apakah sama dengan yang di inginkan
        If LblNama.Text = "Ryann" Then
            ' Jika sama, izinkan akses ke ToolStripMenuItems
            GunaAdvenceButton3.Enabled = True
        Else
            ' Jika tidak, nonaktifkan akses ke ToolStripMenuItems
            GunaAdvenceButton3.Enabled = False
        End If
    End Sub



    Private Sub ListBarangToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormBarang.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' Set properti IsLoggedIn menjadi False
        IsLoggedIn = False

        ' Tampilkan FormLogin
        Dim loginForm As New FormLogin
        loginForm.Show()

        ' Tutup FormMenuUser
        Me.Close()
    End Sub


    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click

        FormBarang.Show()
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        FormBarang.Hide()
        dashboard.Show()
    End Sub

    Private Sub logbtn_Click(sender As Object, e As EventArgs) Handles logbtn.Click
        Me.Hide()
        FormLogin.Show()
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        dashboard.Hide()
        MasterAdmin.Show()


    End Sub
End Class
