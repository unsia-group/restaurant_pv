Public Class order
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub


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
        For i As Integer = 1 To 8
            e.Graphics.DrawString("Burger XL", font, brush, leftMargin, yPos)
            e.Graphics.DrawString("Rp. 30.000", font, brush, leftMargin + 100, yPos)
            e.Graphics.DrawString("2", font, brush, leftMargin + 200, yPos)
            e.Graphics.DrawString("Rp. 60.000", font, brush, leftMargin + 250, yPos)
            yPos += 15
        Next

        ' Footer
        e.Graphics.DrawString("TOTAL", font, brush, leftMargin, yPos + 15)
        e.Graphics.DrawString("Rp. 160.000", font, brush, leftMargin + 250, yPos + 15)

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
End Class