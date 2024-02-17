Imports Newtonsoft.Json.Linq

Public Class order
    Public selectedItem As New List(Of ItemObject)()
    Public isTakeaway As Boolean

    Private Sub order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListMenu.Controls.Clear()
        loadList()
    End Sub

    Private Function loadList()
        For Each item As ItemObject In selectedItem
            Dim itemPanel = loadListItem(item)

            ListMenu.Controls.Add(itemPanel)
        Next
    End Function

    Private Function loadListItem(item As ItemObject) As Panel
        Dim itemPanel As New Panel
        itemPanel.Size = New Size(1028, 90) ' Sesuaikan ukuran sesuai kebutuhan

        ' Membuat label untuk nama item
        Dim nameLabel As New Label()
        nameLabel = SetupNameLabel(item)

        Dim priceLabel As New Label()
        priceLabel = SetupPriceLabel(item)

        Dim countLabel As New Label()
        countLabel = SetupCountLabel(item)

        itemPanel.Controls.Add(nameLabel)
        itemPanel.Controls.Add(priceLabel)
        itemPanel.Controls.Add(countLabel)

        Return itemPanel
    End Function

    Private Function SetupNameLabel(item As ItemObject) As Label
        Dim nameLabel As New Label()
        nameLabel.Text = item.Name
        nameLabel.AutoSize = True
        nameLabel.Location = New Point(165, 30) ' Posisi label di atas gambar
        nameLabel.ForeColor = Color.Black
        nameLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Left

        Return nameLabel
    End Function

    Private Function SetupPriceLabel(item As ItemObject) As Label
        Dim priceLabel As New Label()
        priceLabel.Text = "Rp. " + (item.Value.ToString)
        priceLabel.AutoSize = True
        priceLabel.Location = New Point(23, 142) ' Posisi label di atas gambar
        priceLabel.ForeColor = Color.Black
        priceLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Left

        Return priceLabel
    End Function
    Private Function SetupCountLabel(item As ItemObject) As Label
        Dim countLabel As New Label()
        countLabel.Text = item.Count.ToString
        countLabel.AutoSize = True
        countLabel.Location = New Point(852, 36) ' Posisi label di atas gambar
        countLabel.ForeColor = Color.Black
        countLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Left

        Return countLabel
    End Function


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Set up fonts and brushes.
        Dim font As New Font("Arial", 10)
        Dim fontBold As New Font("Arial", 16, FontStyle.Bold)
        Dim brush As New SolidBrush(Color.Black)

        ' Set the margins.
        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim topMargin As Integer = e.MarginBounds.Top

        ' Set up the receipt layout.
        e.Graphics.DrawString("BURGERKILL", fontBold, brush, leftMargin, topMargin)
        e.Graphics.DrawString("Jln Raya Medan sentosa no.46", font, brush, leftMargin, topMargin + 20)
        e.Graphics.DrawString("Kota Bandung 9433", font, brush, leftMargin, topMargin + 40)

        ' Detail header.
        e.Graphics.DrawString("Receipt Date", font, brush, leftMargin, topMargin + 60)
        e.Graphics.DrawString("12-12-2023 08:00", font, brush, leftMargin + 100, topMargin + 60)
        e.Graphics.DrawString("By", font, brush, leftMargin, topMargin + 80)
        e.Graphics.DrawString("David Setiawan", font, brush, leftMargin + 100, topMargin + 80)

        ' Items list.
        Dim yPos As Integer = topMargin + 120
        For Each item As ItemObject In selectedItem
            e.Graphics.DrawString(item.Name, font, brush, leftMargin, yPos)
            e.Graphics.DrawString("Rp. " + (item.Value).ToString, font, brush, leftMargin + 100, yPos)
            e.Graphics.DrawString(item.Count, font, brush, leftMargin + 200, yPos)
            e.Graphics.DrawString("Rp. " + (item.Value * item.Count).ToString, font, brush, leftMargin + 250, yPos)
            yPos += 15
        Next

        Dim totalValue As Integer = selectedItem.Sum(Function(i) i.Value * i.Count)

        ' Footer
        e.Graphics.DrawString("TOTAL", font, brush, leftMargin, yPos + 15)
        e.Graphics.DrawString("Rp. " + totalValue.ToString(), font, brush, leftMargin + 250, yPos + 15)

        ' ... Add the DISC, GRAND TOTAL, and CHANGES the same way

        ' Disclaimer text at the bottom
        e.Graphics.DrawString("Food that has been purchased cannot be exchanged / returned for any reason", New Font("Arial", 8), brush, leftMargin, yPos + 60)

        ' Indicate that there are no more pages to print
        e.HasMorePages = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Jika Anda ingin menampilkan dialog cetak sebelumnya, gunakan PrintDialog
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        detail.Show()
        Me.Hide()
    End Sub
End Class