Imports System.Drawing.Printing
Imports System.IO
Imports System.Net.Http
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports System.Xml
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class main_screen
    Public selectedItem As New List(Of ItemObject)()

    Private Sub main_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        main_panel.Show()
        burger_panel.Hide()
        pizza_panel.Hide()
        hotdog_panel.Hide()
        drink_panel.Hide()

        FlowLayoutPanel1.Controls.Clear()
        LoadListBurger()
        LoadListPizza()
        LoadListHotdog()
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
        Dim detailShow As New detail()
        detailShow.selectedItem = selectedItem
        detailShow.Show()

        Me.Hide()
    End Sub
    Async Sub LoadListBurger()
        Dim filePath As String = "Resources/json/list_burger.json"

        If File.Exists(filePath) Then
            Dim jsonString As String = File.ReadAllText(filePath)
            Dim jsonObject As Object = JsonConvert.DeserializeObject(jsonString)
            Dim listBurger As JArray = jsonObject("list_burger")

            For Each burger As JObject In listBurger
                Dim itemPanel As New Panel
                itemPanel.Size = New Size(140, 175) ' Sesuaikan ukuran sesuai kebutuhan

                ' Membuat label untuk nama item
                Dim nameLabel As New Label()
                nameLabel = SetupNameLabel(burger)

                Dim priceLabel As New Label()
                priceLabel = SetupPriceLabel(burger)

                ' Membuat PictureBox untuk gambar
                Dim pictureBox As New PictureBox()
                pictureBox = Await SetupPictureBoxLabel(burger)

                itemPanel.Controls.Add(pictureBox)
                itemPanel.Controls.Add(nameLabel)
                itemPanel.Controls.Add(priceLabel)

                itemPanel.Tag = burger("price").ToObject(Of Integer)()
                AddHandler itemPanel.Click, AddressOf ItemPanel_Click
                AddHandler nameLabel.Click, AddressOf ItemPanel_Click
                AddHandler pictureBox.Click, AddressOf ItemPanel_Click

                FlowLayoutPanel1.Controls.Add(itemPanel)
            Next
        Else
            Console.WriteLine("File burger list does not exist.")
        End If
    End Sub

    Async Sub LoadListPizza()
        Dim filePath As String = "Resources/json/list_pizza.json"

        If File.Exists(filePath) Then
            Dim jsonString As String = File.ReadAllText(filePath)
            Dim jsonObject As Object = JsonConvert.DeserializeObject(jsonString)
            Dim listPizza As JArray = jsonObject("list_pizza")

            For Each pizza As JObject In listPizza
                Dim itemPanel As New Panel
                itemPanel.Size = New Size(140, 175) ' Sesuaikan ukuran sesuai kebutuhan

                ' Membuat label untuk nama item
                Dim nameLabel As New Label()
                nameLabel = SetupNameLabel(pizza)

                Dim priceLabel As New Label()
                priceLabel = SetupPriceLabel(pizza)

                ' Membuat PictureBox untuk gambar
                Dim pictureBox As New PictureBox()
                pictureBox = Await SetupPictureBoxLabel(pizza)

                itemPanel.Controls.Add(pictureBox)
                itemPanel.Controls.Add(nameLabel)
                itemPanel.Controls.Add(priceLabel)

                itemPanel.Tag = pizza("price").ToObject(Of Integer)()
                AddHandler itemPanel.Click, AddressOf ItemPanel_Click
                AddHandler nameLabel.Click, AddressOf ItemPanel_Click
                AddHandler pictureBox.Click, AddressOf ItemPanel_Click

                FlowLayoutPanel1.Controls.Add(itemPanel)
            Next
        Else
            Console.WriteLine("File pizza list does not exist.")
        End If
    End Sub

    Async Sub LoadListHotdog()
        Dim filePath As String = "Resources/json/list_hotdog.json"

        If File.Exists(filePath) Then
            Dim jsonString As String = File.ReadAllText(filePath)
            Dim jsonObject As Object = JsonConvert.DeserializeObject(jsonString)
            Dim listHotdog As JArray = jsonObject("list_hotdog")

            For Each hotdog As JObject In listHotdog
                Dim itemPanel As New Panel
                itemPanel.Size = New Size(140, 175) ' Sesuaikan ukuran sesuai kebutuhan

                ' Membuat label untuk nama item
                Dim nameLabel As New Label()
                nameLabel = SetupNameLabel(hotdog)

                Dim priceLabel As New Label()
                priceLabel = SetupPriceLabel(hotdog)

                ' Membuat PictureBox untuk gambar
                Dim pictureBox As New PictureBox()
                pictureBox = Await SetupPictureBoxLabel(hotdog)

                itemPanel.Controls.Add(pictureBox)
                itemPanel.Controls.Add(nameLabel)
                itemPanel.Controls.Add(priceLabel)

                itemPanel.Tag = hotdog("price").ToObject(Of Integer)()
                AddHandler itemPanel.Click, AddressOf ItemPanel_Click
                AddHandler nameLabel.Click, AddressOf ItemPanel_Click
                AddHandler pictureBox.Click, AddressOf ItemPanel_Click

                FlowLayoutPanel1.Controls.Add(itemPanel)
            Next
        Else
            Console.WriteLine("File hotdog list does not exist.")
        End If
    End Sub

    Async Sub LoadListDrink()
        Dim filePath As String = "Resources/json/list_drink.json"

        If File.Exists(filePath) Then
            Dim jsonString As String = File.ReadAllText(filePath)
            Dim jsonObject As Object = JsonConvert.DeserializeObject(jsonString)
            Dim listDrink As JArray = jsonObject("list_drink")

            For Each drink As JObject In listDrink
                Dim itemPanel As New Panel
                itemPanel.Size = New Size(140, 175) ' Sesuaikan ukuran sesuai kebutuhan

                ' Membuat label untuk nama item
                Dim nameLabel As New Label()
                nameLabel = SetupNameLabel(drink)

                Dim priceLabel As New Label()
                priceLabel = SetupPriceLabel(drink)

                ' Membuat PictureBox untuk gambar
                Dim pictureBox As New PictureBox()
                pictureBox = Await SetupPictureBoxLabel(drink)

                itemPanel.Controls.Add(pictureBox)
                itemPanel.Controls.Add(nameLabel)
                itemPanel.Controls.Add(priceLabel)

                itemPanel.Tag = drink("price").ToObject(Of Integer)()
                AddHandler itemPanel.Click, AddressOf ItemPanel_Click
                AddHandler nameLabel.Click, AddressOf ItemPanel_Click
                AddHandler pictureBox.Click, AddressOf ItemPanel_Click

                FlowLayoutPanel1.Controls.Add(itemPanel)
            Next
        Else
            Console.WriteLine("File drink list does not exist.")
        End If
    End Sub

    Private Async Function LoadImageFromUrlAsync(url As String) As Task(Of Image)
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync(url)
            If response.IsSuccessStatusCode Then
                Dim imageStream As Stream = Await response.Content.ReadAsStreamAsync()
                Return Image.FromStream(imageStream)
            Else
                Return Nothing
            End If
        End Using
    End Function

    Private Function SetupNameLabel(item) As Label
        Dim nameLabel As New Label()
        nameLabel.Text = item("name").ToString()
        nameLabel.AutoSize = True
        nameLabel.Location = New Point(23, 118) ' Posisi label di atas gambar
        nameLabel.ForeColor = Color.Black
        nameLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right

        Return nameLabel
    End Function

    Private Function SetupPriceLabel(item) As Label
        Dim priceLabel As New Label()
        priceLabel.Text = "Rp. " + item("price").ToString()
        priceLabel.AutoSize = True
        priceLabel.Location = New Point(23, 142) ' Posisi label di atas gambar
        priceLabel.ForeColor = Color.Black
        priceLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right

        Return priceLabel
    End Function

    Private Async Function SetupPictureBoxLabel(item) As Task(Of PictureBox)
        ' Membuat PictureBox untuk gambar
        Dim pictureBox As New PictureBox()
        pictureBox.Location = New Point(0, 0) ' Posisi gambar di bawah label
        pictureBox.Size = New Size(100, 100)
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left

        ' Memuat gambar dari Unsplash atau path lokal
        Dim imagePath As String = item("image").ToString()
        If imagePath.StartsWith("http") Then
            ' Memuat gambar dari URL
            pictureBox.Image = Await LoadImageFromUrlAsync(imagePath)
        End If

        Return pictureBox
    End Function

    Private Sub ItemPanel_Click(sender As Object, e As EventArgs)
        Dim clickedControl As Control = CType(sender, Control)
        Dim item As New ItemObject

        ' Cek apakah sender adalah panel atau kontrol di dalam panel
        If TypeOf clickedControl Is Panel Then
            item.Value = CInt(clickedControl.Tag)
            item.Name = clickedControl.Controls.OfType(Of Label)().FirstOrDefault()?.Text
        Else
            ' Untuk kontrol di dalam panel, dapatkan panel parent dan informasi item
            item.Value = CInt(clickedControl.Parent.Tag)
            item.Name = clickedControl.Parent.Controls.OfType(Of Label)().FirstOrDefault()?.Text
        End If

        ' Validation: Check if the item already exists in selectedItem list
        Dim existingItem = selectedItem.FirstOrDefault(Function(i) i.Value = item.Value AndAlso i.Name = item.Name)
        If existingItem Is Nothing Then
            ' Jika item belum ada, tambahkan dengan count 1
            item.Count = 1
            selectedItem.Add(item)
        Else
            ' Jika item sudah ada, tingkatkan count
            existingItem.Count += 1
        End If

        ' Opsi: Lakukan kalkulasi atau update UI berdasarkan list clickedItems
        Dim totalValue As Integer = selectedItem.Sum(Function(i) i.Value * i.Count)
        Dim totalItem As Integer = selectedItem.Sum(Function(i) i.Count)

        ' Update label untuk harga total dan jumlah item
        Label_price.Text = "Rp. " + totalValue.ToString()
        Label_Count.Text = totalItem.ToString() + " Item"
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        Label_price.Text = "Rp. 0"
        Label_Count.Text = "0 Item"

        selectedItem.Clear()
    End Sub

    Private Sub logo_side_menu_Click(sender As Object, e As EventArgs) Handles logo_side_menu.Click

    End Sub
End Class
Public Class ItemObject
    Public Property Name As String
    Public Property Value As Integer
    Public Property Count As Integer
End Class