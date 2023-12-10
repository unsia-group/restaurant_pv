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
End Class
