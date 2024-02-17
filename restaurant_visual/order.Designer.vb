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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.burger_1 = New System.Windows.Forms.Button()
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
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.logo_side_menu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(289, 731)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(96, 294)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 378)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "P" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'logo_side_menu
        '
        Me.logo_side_menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.logo_side_menu.Image = Global.restaurant_visual.My.Resources.Resources.Ellipse_2_small
        Me.logo_side_menu.Location = New System.Drawing.Point(0, 0)
        Me.logo_side_menu.Margin = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.logo_side_menu.Name = "logo_side_menu"
        Me.logo_side_menu.Size = New System.Drawing.Size(289, 234)
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
        Me.Panel2.Location = New System.Drawing.Point(289, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1168, 731)
        Me.Panel2.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(31, 561)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 17)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Changes (Rp. )"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(571, 475)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 17)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Payment Money (Rp. )"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(29, 475)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Discount (%)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(31, 391)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Grand Total (Rp. )"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(35, 103)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 17)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Detail Order"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(571, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Cashier Name"
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Black
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackButton.Location = New System.Drawing.Point(292, 661)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(267, 49)
        Me.BackButton.TabIndex = 19
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(567, 661)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(267, 49)
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
        Me.btn_order.Location = New System.Drawing.Point(841, 661)
        Me.btn_order.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(267, 49)
        Me.btn_order.TabIndex = 17
        Me.btn_order.Text = "FINISHED"
        Me.btn_order.UseVisualStyleBackColor = False
        '
        'changesInput
        '
        Me.changesInput.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.changesInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.changesInput.Enabled = False
        Me.changesInput.Location = New System.Drawing.Point(33, 590)
        Me.changesInput.Margin = New System.Windows.Forms.Padding(4)
        Me.changesInput.MinimumSize = New System.Drawing.Size(0, 49)
        Me.changesInput.Multiline = True
        Me.changesInput.Name = "changesInput"
        Me.changesInput.Size = New System.Drawing.Size(1075, 50)
        Me.changesInput.TabIndex = 15
        '
        'paymentInput
        '
        Me.paymentInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.paymentInput.Location = New System.Drawing.Point(575, 501)
        Me.paymentInput.Margin = New System.Windows.Forms.Padding(4)
        Me.paymentInput.MinimumSize = New System.Drawing.Size(0, 49)
        Me.paymentInput.Multiline = True
        Me.paymentInput.Name = "paymentInput"
        Me.paymentInput.Size = New System.Drawing.Size(533, 49)
        Me.paymentInput.TabIndex = 13
        '
        'DiscountInput
        '
        Me.DiscountInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DiscountInput.Location = New System.Drawing.Point(33, 501)
        Me.DiscountInput.Margin = New System.Windows.Forms.Padding(4)
        Me.DiscountInput.MinimumSize = New System.Drawing.Size(0, 49)
        Me.DiscountInput.Multiline = True
        Me.DiscountInput.Name = "DiscountInput"
        Me.DiscountInput.Size = New System.Drawing.Size(533, 49)
        Me.DiscountInput.TabIndex = 9
        '
        'GrandTotalInput
        '
        Me.GrandTotalInput.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GrandTotalInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrandTotalInput.Enabled = False
        Me.GrandTotalInput.Location = New System.Drawing.Point(33, 417)
        Me.GrandTotalInput.Margin = New System.Windows.Forms.Padding(4)
        Me.GrandTotalInput.MinimumSize = New System.Drawing.Size(0, 49)
        Me.GrandTotalInput.Multiline = True
        Me.GrandTotalInput.Name = "GrandTotalInput"
        Me.GrandTotalInput.Size = New System.Drawing.Size(1075, 49)
        Me.GrandTotalInput.TabIndex = 8
        '
        'cashierNameInput
        '
        Me.cashierNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cashierNameInput.Location = New System.Drawing.Point(575, 43)
        Me.cashierNameInput.Margin = New System.Windows.Forms.Padding(4)
        Me.cashierNameInput.MinimumSize = New System.Drawing.Size(0, 49)
        Me.cashierNameInput.Multiline = True
        Me.cashierNameInput.Name = "cashierNameInput"
        Me.cashierNameInput.Size = New System.Drawing.Size(533, 49)
        Me.cashierNameInput.TabIndex = 7
        '
        'ListMenu
        '
        Me.ListMenu.AutoScroll = True
        Me.ListMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListMenu.Controls.Add(Me.Panel5)
        Me.ListMenu.Controls.Add(Me.Panel3)
        Me.ListMenu.Controls.Add(Me.Panel4)
        Me.ListMenu.Location = New System.Drawing.Point(33, 128)
        Me.ListMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.ListMenu.Name = "ListMenu"
        Me.ListMenu.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ListMenu.Size = New System.Drawing.Size(1074, 259)
        Me.ListMenu.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.Button4)
        Me.Panel5.Location = New System.Drawing.Point(11, 10)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1028, 90)
        Me.Panel5.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(852, 36)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(151, 29)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Rp. 150.000"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(165, 49)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 17)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "X 5"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(165, 30)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 17)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Special Burger"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.restaurant_visual.My.Resources.Resources.burgers
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(0, 0)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 90)
        Me.Button4.TabIndex = 1
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Location = New System.Drawing.Point(11, 108)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1028, 90)
        Me.Panel3.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(852, 36)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(151, 29)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Rp. 150.000"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(165, 49)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 17)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "X 5"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(165, 30)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Special Burger"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.restaurant_visual.My.Resources.Resources.burgers
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(0, 0)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 90)
        Me.Button3.TabIndex = 1
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.burger_1)
        Me.Panel4.Location = New System.Drawing.Point(11, 206)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1028, 90)
        Me.Panel4.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(852, 36)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 29)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Rp. 150.000"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(165, 49)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "X 5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(165, 30)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Special Burger"
        '
        'burger_1
        '
        Me.burger_1.BackgroundImage = Global.restaurant_visual.My.Resources.Resources.burgers
        Me.burger_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.burger_1.Dock = System.Windows.Forms.DockStyle.Left
        Me.burger_1.FlatAppearance.BorderSize = 0
        Me.burger_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.burger_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.burger_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.burger_1.Location = New System.Drawing.Point(0, 0)
        Me.burger_1.Margin = New System.Windows.Forms.Padding(4)
        Me.burger_1.Name = "burger_1"
        Me.burger_1.Size = New System.Drawing.Size(140, 90)
        Me.burger_1.TabIndex = 1
        Me.burger_1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(31, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer Name"
        '
        'customerNameInput
        '
        Me.customerNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.customerNameInput.Location = New System.Drawing.Point(33, 43)
        Me.customerNameInput.Margin = New System.Windows.Forms.Padding(4)
        Me.customerNameInput.MinimumSize = New System.Drawing.Size(0, 49)
        Me.customerNameInput.Multiline = True
        Me.customerNameInput.Name = "customerNameInput"
        Me.customerNameInput.Size = New System.Drawing.Size(533, 49)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1457, 731)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
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
    Friend WithEvents Panel4 As Panel
    Friend WithEvents burger_1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button3 As Button
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
