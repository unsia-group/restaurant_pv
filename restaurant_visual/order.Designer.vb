<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class order
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(order))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logo_side_menu = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.changesInput = New System.Windows.Forms.TextBox()
        Me.paymentInput = New System.Windows.Forms.TextBox()
        Me.DiscountInput = New System.Windows.Forms.TextBox()
        Me.GrandTotalInput = New System.Windows.Forms.TextBox()
        Me.cashierNameInput = New System.Windows.Forms.TextBox()
        Me.ListMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.customerNameInput = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.logo_side_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.ListMenu.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.logo_side_menu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(217, 594)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(72, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 294)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "P" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'logo_side_menu
        '
        Me.logo_side_menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.logo_side_menu.Image = Global.restaurant_visual.My.Resources.Resources.Ellipse_2_small
        Me.logo_side_menu.Location = New System.Drawing.Point(0, 0)
        Me.logo_side_menu.Margin = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.logo_side_menu.Name = "logo_side_menu"
        Me.logo_side_menu.Size = New System.Drawing.Size(217, 190)
        Me.logo_side_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.logo_side_menu.TabIndex = 1
        Me.logo_side_menu.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.BackButton)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btn_order)
        Me.Panel2.Controls.Add(Me.changesInput)
        Me.Panel2.Controls.Add(Me.paymentInput)
        Me.Panel2.Controls.Add(Me.DiscountInput)
        Me.Panel2.Controls.Add(Me.GrandTotalInput)
        Me.Panel2.Controls.Add(Me.cashierNameInput)
        Me.Panel2.Controls.Add(Me.ListMenu)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.customerNameInput)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(217, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(876, 594)
        Me.Panel2.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(23, 456)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Changes (Rp. )"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(428, 386)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Payment Money (Rp. )"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(22, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Discount (%)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(23, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Grand Total (Rp. )"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(26, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 13)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Detail Order"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(428, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Cashier Name"
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Black
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackButton.Location = New System.Drawing.Point(219, 537)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(200, 40)
        Me.BackButton.TabIndex = 19
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(425, 537)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 40)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "PRINT INVOICE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_order
        '
        Me.btn_order.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_order.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_order.Location = New System.Drawing.Point(631, 537)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(200, 40)
        Me.btn_order.TabIndex = 17
        Me.btn_order.Text = "FINISHED"
        Me.btn_order.UseVisualStyleBackColor = False
        '
        'changesInput
        '
        Me.changesInput.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.changesInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.changesInput.Enabled = False
        Me.changesInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.changesInput.Location = New System.Drawing.Point(25, 479)
        Me.changesInput.MinimumSize = New System.Drawing.Size(0, 40)
        Me.changesInput.Multiline = True
        Me.changesInput.Name = "changesInput"
        Me.changesInput.Size = New System.Drawing.Size(806, 41)
        Me.changesInput.TabIndex = 15
        '
        'paymentInput
        '
        Me.paymentInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.paymentInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.paymentInput.Location = New System.Drawing.Point(431, 407)
        Me.paymentInput.MinimumSize = New System.Drawing.Size(0, 40)
        Me.paymentInput.Multiline = True
        Me.paymentInput.Name = "paymentInput"
        Me.paymentInput.Size = New System.Drawing.Size(400, 40)
        Me.paymentInput.TabIndex = 13
        '
        'DiscountInput
        '
        Me.DiscountInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DiscountInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.DiscountInput.Location = New System.Drawing.Point(25, 407)
        Me.DiscountInput.MinimumSize = New System.Drawing.Size(0, 40)
        Me.DiscountInput.Multiline = True
        Me.DiscountInput.Name = "DiscountInput"
        Me.DiscountInput.Size = New System.Drawing.Size(400, 40)
        Me.DiscountInput.TabIndex = 9
        '
        'GrandTotalInput
        '
        Me.GrandTotalInput.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GrandTotalInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrandTotalInput.Enabled = False
        Me.GrandTotalInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.GrandTotalInput.Location = New System.Drawing.Point(25, 339)
        Me.GrandTotalInput.MinimumSize = New System.Drawing.Size(0, 40)
        Me.GrandTotalInput.Multiline = True
        Me.GrandTotalInput.Name = "GrandTotalInput"
        Me.GrandTotalInput.Size = New System.Drawing.Size(806, 40)
        Me.GrandTotalInput.TabIndex = 8
        '
        'cashierNameInput
        '
        Me.cashierNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cashierNameInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.cashierNameInput.Location = New System.Drawing.Point(431, 35)
        Me.cashierNameInput.MinimumSize = New System.Drawing.Size(0, 40)
        Me.cashierNameInput.Multiline = True
        Me.cashierNameInput.Name = "cashierNameInput"
        Me.cashierNameInput.Size = New System.Drawing.Size(400, 40)
        Me.cashierNameInput.TabIndex = 7
        '
        'ListMenu
        '
        Me.ListMenu.AutoScroll = True
        Me.ListMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListMenu.Controls.Add(Me.Panel5)
        Me.ListMenu.Location = New System.Drawing.Point(25, 104)
        Me.ListMenu.Name = "ListMenu"
        Me.ListMenu.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ListMenu.Size = New System.Drawing.Size(806, 211)
        Me.ListMenu.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Location = New System.Drawing.Point(8, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(771, 73)
        Me.Panel5.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(623, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 24)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Rp. 150.000"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "X 5"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(19, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Special Burger"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(23, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer Name"
        '
        'customerNameInput
        '
        Me.customerNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.customerNameInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerNameInput.Location = New System.Drawing.Point(25, 35)
        Me.customerNameInput.MinimumSize = New System.Drawing.Size(0, 40)
        Me.customerNameInput.Multiline = True
        Me.customerNameInput.Name = "customerNameInput"
        Me.customerNameInput.Size = New System.Drawing.Size(400, 40)
        Me.customerNameInput.TabIndex = 0
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 594)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "order"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.logo_side_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ListMenu.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents logo_side_menu As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents customerNameInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListMenu As FlowLayoutPanel
    Friend WithEvents DiscountInput As TextBox
    Friend WithEvents GrandTotalInput As TextBox
    Friend WithEvents cashierNameInput As TextBox
    Friend WithEvents paymentInput As TextBox
    Friend WithEvents changesInput As TextBox
    Friend WithEvents BackButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_order As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
