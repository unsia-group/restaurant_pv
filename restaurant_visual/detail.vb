Public Class detail
    Public selectedItem As New List(Of ItemObject)()
    Public isTakeaway As Boolean

    Private Sub Button_DineIn_Click(sender As Object, e As EventArgs) Handles Button_DineIn.Click
        isTakeaway = False
        order.Show()
        Me.Hide()
    End Sub
    Private Sub Button_Takeaway_Click(sender As Object, e As EventArgs) Handles Button_Takeaway.Click
        isTakeaway = True
        order.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        main_screen.Show()
        Me.Hide()
    End Sub

    Private Sub logo_splash_Click(sender As Object, e As EventArgs) Handles logo_splash.Click

    End Sub
End Class