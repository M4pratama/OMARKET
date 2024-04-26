Public Class FormMenuUser

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
        informitems.TopLevel = False
        dashboard.TopLevel = False
        list_barang.TopLevel = False

        Panel1.Controls.Add(informitems)
        Panel1.Controls.Add(list_barang)
        Panel1.Controls.Add(dashboard)

        informitems.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        list_barang.Show()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs)
        FRMBeli_Barang.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' Set properti IsLoggedIn menjadi False
        IsLoggedIn = False

        ' Tampilkan FormLogin
        Dim loginForm As New FormLogin
        loginForm.Show()

        ' Tutup FormMenuUser
        Me.Close()
    End Sub

    Private Sub CabutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' Keluar dari aplikasi
        Application.Exit()
    End Sub

    Private Sub logbtn_Click(sender As Object, e As EventArgs) Handles logbtn.Click
        Me.Hide()
        FormLogin.Show()
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        FRMBeli_Barang.Show()

    End Sub

    Private Sub ShopBtn_Click(sender As Object, e As EventArgs) Handles ShopBtn.Click
        informitems.Hide()
        list_barang.Show()


    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        list_barang.Hide()
        dashboard.Show()

    End Sub
End Class