Imports Newtonsoft.Json.Linq

Public Class order
    Public selectedItem As New List(Of ItemObject)()
    Public isTakeaway As Boolean
    Public customerName As String
    Public cashierName As String
    Public discount As Double
    Public payment As Double
    Public grandTotalPrice As Double

    Private Sub order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customerName = ""
        cashierName = ""
        payment = 0

        ListMenu.Controls.Clear()
        loadList()
    End Sub

    Private Function loadList()
        For Each item As ItemObject In selectedItem
            Dim itemPanel = loadListItem(item)

            ListMenu.Controls.Add(itemPanel)
        Next

        Dim totalValue As Integer = selectedItem.Sum(Function(i) i.Value * i.Count)

        GrandTotalInput.Text = totalValue

        Return True
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
        nameLabel.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)

        Return nameLabel
    End Function

    Private Function SetupCountLabel(item As ItemObject) As Label
        Dim countLabel As New Label()
        countLabel.Text = item.Count.ToString
        countLabel.AutoSize = True
        countLabel.Location = New Point(165, 49) ' Posisi label di atas gambar
        countLabel.ForeColor = Color.Black
        countLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        countLabel.Font = New Font("Microsoft Sans Serif", 8.25)

        Return countLabel
    End Function

    Private Function SetupPriceLabel(item As ItemObject) As Label
        Dim priceLabel As New Label()
        priceLabel.Text = "Rp. " + (item.Value.ToString)
        priceLabel.AutoSize = True
        priceLabel.Location = New Point(852, 29) ' Posisi label di atas gambar
        priceLabel.ForeColor = Color.Black
        priceLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        priceLabel.Font = New Font("Microsoft Sans Serif", 14.25, FontStyle.Bold)

        Return priceLabel
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
        e.Graphics.DrawString(DateTime.Now.ToString("dd/MM/yyyy"), font, brush, leftMargin + 100, topMargin + 60)
        e.Graphics.DrawString("By", font, brush, leftMargin, topMargin + 80)
        e.Graphics.DrawString(cashierName, font, brush, leftMargin + 100, topMargin + 80)

        ' Items list.
        Dim yPos As Integer = topMargin + 120
        For Each item As ItemObject In selectedItem
            e.Graphics.DrawString(item.Name, font, brush, leftMargin, yPos)
            e.Graphics.DrawString("Rp. " + (item.Value).ToString, font, brush, leftMargin + 100, yPos)
            e.Graphics.DrawString(item.Count, font, brush, leftMargin + 200, yPos)
            e.Graphics.DrawString("Rp. " + (item.Value * item.Count).ToString, font, brush, leftMargin + 250, yPos)
            yPos += 15
        Next

        ' Footer
        e.Graphics.DrawString("TOTAL", font, brush, leftMargin, yPos + 15)
        e.Graphics.DrawString("Rp. " + grandTotalPrice.ToString(), font, brush, leftMargin + 250, yPos + 15)

        ' ... Add the DISC, GRAND TOTAL, and CHANGES the same way

        ' Disclaimer text at the bottom
        e.Graphics.DrawString("Food that has been purchased cannot be exchanged / returned for any reason", New Font("Arial", 8), brush, leftMargin, yPos + 60)

        ' Indicate that there are no more pages to print
        e.HasMorePages = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If selectedItem.Count = 0 Then
            MessageBox.Show("No item selected")
            Return
        End If

        If customerName = "" Or cashierName = "" Or payment = 0 Then
            MessageBox.Show("Please fill all the required fields")
            Return
        End If

        If payment < grandTotalPrice Then
            MessageBox.Show("Payment is not enough")
            Return
        End If

        ' Jika Anda ingin menampilkan dialog cetak sebelumnya, gunakan PrintDialog
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim detailShow As New detail
        detailShow.selectedItem = selectedItem
        detailShow.isTakeaway = isTakeaway

        detailShow.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles customerNameInput.TextChanged
        customerName = customerNameInput.Text
    End Sub

    Private Sub cashierNameInput_TextChanged(sender As Object, e As EventArgs) Handles cashierNameInput.TextChanged
        cashierName = cashierNameInput.Text
    End Sub

    Private Sub DiscountInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DiscountInput.KeyPress
        ' Allowing only digits, decimal point, and negative sign
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not e.KeyChar = "-" AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub paymentInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles paymentInput.KeyPress
        ' Allowing only digits, decimal point, and negative sign
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not e.KeyChar = "-" AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DiscountInput_TextChanged(sender As Object, e As EventArgs) Handles DiscountInput.TextChanged
        If DiscountInput.Text = "" Then
            discount = 0
            calcChanges()
            Return
        End If

        Dim discountText = CInt(Int(DiscountInput.Text))

        If discountText > 100 Then
            DiscountInput.Text = 100
        ElseIf discountText < 0 Then
            DiscountInput.Text = 0
        End If

        discount = discountText

        calcChanges()
    End Sub

    Private Sub paymentInput_TextChanged(sender As Object, e As EventArgs) Handles paymentInput.TextChanged
        If paymentInput.Text = "" Then
            payment = 0
            calcChanges()
            Return
        End If

        payment = CInt(Int(paymentInput.Text))

        calcChanges()
    End Sub

    Private Function calcChanges()
        Dim totalValue As Integer = selectedItem.Sum(Function(i) i.Value * i.Count)
        Dim grandTotal = totalValue - (totalValue * (discount / 100))

        GrandTotalInput.Text = grandTotal
        grandTotalPrice = grandTotal

        Dim changes = payment - grandTotal

        changesInput.Text = changes

        Return True
    End Function
End Class