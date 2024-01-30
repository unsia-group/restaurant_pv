Public Class splash_screen
    Private Sub splash_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 3000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        main_screen.Show()
        Me.Hide()
    End Sub

    Private Sub logo_splash_Click(sender As Object, e As EventArgs) Handles logo_splash.Click

    End Sub
End Class
