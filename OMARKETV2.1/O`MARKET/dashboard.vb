Imports System.Data.Odbc

Public Class dashboard


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_time.Text = Date.Now.ToString("hh:mm:ss:tt")
    End Sub


    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub


End Class