Public Class main_screen
    Private Sub main_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        main_panel.Show()
        burger_panel.Hide()
        pizza_panel.Hide()
        hotdog_panel.Hide()
        drink_panel.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub all_menu_btn_Click(sender As Object, e As EventArgs) Handles all_menu_btn.Click
        breadcump_label.Text = "All Menu"
        burger_panel.Hide()
        pizza_panel.Hide()
        hotdog_panel.Hide()
        drink_panel.Hide()

        main_panel.Show()
    End Sub

    Private Sub burger_btn_Click(sender As Object, e As EventArgs) Handles burger_btn.Click
        breadcump_label.Text = "Burger"
        main_panel.Hide()
        pizza_panel.Hide()
        hotdog_panel.Hide()
        drink_panel.Hide()

        burger_panel.Show()
    End Sub

    Private Sub HOTDOG_BTN_Click(sender As Object, e As EventArgs) Handles HOTDOG_BTN.Click
        breadcump_label.Text = "Hotdog"
        main_panel.Hide()
        pizza_panel.Hide()
        drink_panel.Hide()
        burger_panel.Hide()

        hotdog_panel.Show()
    End Sub

    Private Sub drinks_btn_Click(sender As Object, e As EventArgs) Handles drinks_btn.Click
        breadcump_label.Text = "Drink"
        main_panel.Hide()
        pizza_panel.Hide()
        hotdog_panel.Hide()
        burger_panel.Hide()

        drink_panel.Show()
    End Sub

    Private Sub pizza_btn_Click(sender As Object, e As EventArgs) Handles pizza_btn.Click
        breadcump_label.Text = "Pizza"
        main_panel.Hide()
        hotdog_panel.Hide()
        burger_panel.Hide()
        drink_panel.Hide()

        pizza_panel.Show()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        detail.Show()
        Me.Hide()
    End Sub
End Class