<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main_screen
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
        Me.panel_menu = New System.Windows.Forms.Panel()
        Me.MenuGroup = New System.Windows.Forms.Panel()
        Me.drinks_btn = New System.Windows.Forms.Button()
        Me.HOTDOG_BTN = New System.Windows.Forms.Button()
        Me.pizza_btn = New System.Windows.Forms.Button()
        Me.burger_btn = New System.Windows.Forms.Button()
        Me.all_menu_btn = New System.Windows.Forms.Button()
        Me.logo_side_menu = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.breadcump_label = New System.Windows.Forms.Label()
        Me.main_panel = New System.Windows.Forms.Panel()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.panel_price = New System.Windows.Forms.Panel()
        Me.Label_Count = New System.Windows.Forms.Label()
        Me.Label_price = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.burger1label = New System.Windows.Forms.Label()
        Me.burger_1 = New System.Windows.Forms.Button()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.burger_panel = New System.Windows.Forms.Panel()
        Me.pizza_panel = New System.Windows.Forms.Panel()
        Me.hotdog_panel = New System.Windows.Forms.Panel()
        Me.drink_panel = New System.Windows.Forms.Panel()
        Me.panel_menu.SuspendLayout()
        Me.MenuGroup.SuspendLayout()
        CType(Me.logo_side_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.main_panel.SuspendLayout()
        Me.panel_price.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_menu
        '
        Me.panel_menu.AutoScroll = True
        Me.panel_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.panel_menu.Controls.Add(Me.MenuGroup)
        Me.panel_menu.Controls.Add(Me.logo_side_menu)
        Me.panel_menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_menu.Location = New System.Drawing.Point(0, 0)
        Me.panel_menu.Name = "panel_menu"
        Me.panel_menu.Size = New System.Drawing.Size(208, 672)
        Me.panel_menu.TabIndex = 0
        '
        'MenuGroup
        '
        Me.MenuGroup.AutoScroll = True
        Me.MenuGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.MenuGroup.Controls.Add(Me.drinks_btn)
        Me.MenuGroup.Controls.Add(Me.HOTDOG_BTN)
        Me.MenuGroup.Controls.Add(Me.pizza_btn)
        Me.MenuGroup.Controls.Add(Me.burger_btn)
        Me.MenuGroup.Controls.Add(Me.all_menu_btn)
        Me.MenuGroup.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuGroup.Location = New System.Drawing.Point(0, 190)
        Me.MenuGroup.Name = "MenuGroup"
        Me.MenuGroup.Size = New System.Drawing.Size(208, 482)
        Me.MenuGroup.TabIndex = 1
        '
        'drinks_btn
        '
        Me.drinks_btn.BackColor = System.Drawing.Color.Transparent
        Me.drinks_btn.FlatAppearance.BorderSize = 0
        Me.drinks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.drinks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.drinks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.drinks_btn.ForeColor = System.Drawing.Color.Transparent
        Me.drinks_btn.Image = Global.restaurant_visual.My.Resources.Resources.drinks
        Me.drinks_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.drinks_btn.Location = New System.Drawing.Point(3, 546)
        Me.drinks_btn.Name = "drinks_btn"
        Me.drinks_btn.Size = New System.Drawing.Size(185, 125)
        Me.drinks_btn.TabIndex = 4
        Me.drinks_btn.Text = "DRINK"
        Me.drinks_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.drinks_btn.UseVisualStyleBackColor = False
        '
        'HOTDOG_BTN
        '
        Me.HOTDOG_BTN.BackColor = System.Drawing.Color.Transparent
        Me.HOTDOG_BTN.FlatAppearance.BorderSize = 0
        Me.HOTDOG_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.HOTDOG_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.HOTDOG_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HOTDOG_BTN.ForeColor = System.Drawing.Color.Transparent
        Me.HOTDOG_BTN.Image = Global.restaurant_visual.My.Resources.Resources.hotdog
        Me.HOTDOG_BTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.HOTDOG_BTN.Location = New System.Drawing.Point(3, 412)
        Me.HOTDOG_BTN.Name = "HOTDOG_BTN"
        Me.HOTDOG_BTN.Size = New System.Drawing.Size(185, 125)
        Me.HOTDOG_BTN.TabIndex = 3
        Me.HOTDOG_BTN.Text = "HOTDOG"
        Me.HOTDOG_BTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HOTDOG_BTN.UseVisualStyleBackColor = False
        '
        'pizza_btn
        '
        Me.pizza_btn.BackColor = System.Drawing.Color.Transparent
        Me.pizza_btn.FlatAppearance.BorderSize = 0
        Me.pizza_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.pizza_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.pizza_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pizza_btn.ForeColor = System.Drawing.Color.Transparent
        Me.pizza_btn.Image = Global.restaurant_visual.My.Resources.Resources.pizza
        Me.pizza_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.pizza_btn.Location = New System.Drawing.Point(3, 284)
        Me.pizza_btn.Name = "pizza_btn"
        Me.pizza_btn.Size = New System.Drawing.Size(185, 125)
        Me.pizza_btn.TabIndex = 2
        Me.pizza_btn.Text = "PIZZA"
        Me.pizza_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.pizza_btn.UseVisualStyleBackColor = False
        '
        'burger_btn
        '
        Me.burger_btn.BackColor = System.Drawing.Color.Transparent
        Me.burger_btn.FlatAppearance.BorderSize = 0
        Me.burger_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.burger_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.burger_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.burger_btn.ForeColor = System.Drawing.Color.Transparent
        Me.burger_btn.Image = Global.restaurant_visual.My.Resources.Resources.burgers
        Me.burger_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.burger_btn.Location = New System.Drawing.Point(3, 153)
        Me.burger_btn.Name = "burger_btn"
        Me.burger_btn.Size = New System.Drawing.Size(185, 125)
        Me.burger_btn.TabIndex = 1
        Me.burger_btn.Text = "BURGER"
        Me.burger_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.burger_btn.UseVisualStyleBackColor = False
        '
        'all_menu_btn
        '
        Me.all_menu_btn.BackColor = System.Drawing.Color.Transparent
        Me.all_menu_btn.FlatAppearance.BorderSize = 0
        Me.all_menu_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.all_menu_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.all_menu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.all_menu_btn.ForeColor = System.Drawing.Color.Transparent
        Me.all_menu_btn.Image = Global.restaurant_visual.My.Resources.Resources.all_menu
        Me.all_menu_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.all_menu_btn.Location = New System.Drawing.Point(3, 8)
        Me.all_menu_btn.Name = "all_menu_btn"
        Me.all_menu_btn.Size = New System.Drawing.Size(185, 125)
        Me.all_menu_btn.TabIndex = 0
        Me.all_menu_btn.Text = "ALL MENU"
        Me.all_menu_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.all_menu_btn.UseVisualStyleBackColor = False
        '
        'logo_side_menu
        '
        Me.logo_side_menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.logo_side_menu.Image = Global.restaurant_visual.My.Resources.Resources.Ellipse_2_small
        Me.logo_side_menu.Location = New System.Drawing.Point(0, 0)
        Me.logo_side_menu.Margin = New System.Windows.Forms.Padding(10)
        Me.logo_side_menu.Name = "logo_side_menu"
        Me.logo_side_menu.Size = New System.Drawing.Size(208, 190)
        Me.logo_side_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.logo_side_menu.TabIndex = 0
        Me.logo_side_menu.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.breadcump_label)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(208, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(917, 45)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.restaurant_visual.My.Resources.Resources.minimize_btn
        Me.PictureBox3.Location = New System.Drawing.Point(827, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(38, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.restaurant_visual.My.Resources.Resources.exit_button_fix
        Me.PictureBox2.Location = New System.Drawing.Point(869, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'breadcump_label
        '
        Me.breadcump_label.AutoSize = True
        Me.breadcump_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.breadcump_label.Location = New System.Drawing.Point(10, 9)
        Me.breadcump_label.Name = "breadcump_label"
        Me.breadcump_label.Size = New System.Drawing.Size(112, 24)
        Me.breadcump_label.TabIndex = 0
        Me.breadcump_label.Text = "ALL MENU"
        Me.breadcump_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'main_panel
        '
        Me.main_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.main_panel.Controls.Add(Me.btn_order)
        Me.main_panel.Controls.Add(Me.panel_price)
        Me.main_panel.Controls.Add(Me.FlowLayoutPanel1)
        Me.main_panel.Controls.Add(Me.clear_btn)
        Me.main_panel.Controls.Add(Me.PictureBox1)
        Me.main_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main_panel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.main_panel.Location = New System.Drawing.Point(208, 45)
        Me.main_panel.Name = "main_panel"
        Me.main_panel.Size = New System.Drawing.Size(917, 627)
        Me.main_panel.TabIndex = 1
        '
        'btn_order
        '
        Me.btn_order.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_order.Location = New System.Drawing.Point(707, 575)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(200, 40)
        Me.btn_order.TabIndex = 3
        Me.btn_order.Text = "ORDER NOW"
        Me.btn_order.UseVisualStyleBackColor = False
        '
        'panel_price
        '
        Me.panel_price.BackColor = System.Drawing.Color.White
        Me.panel_price.Controls.Add(Me.Label_Count)
        Me.panel_price.Controls.Add(Me.Label_price)
        Me.panel_price.Controls.Add(Me.Label2)
        Me.panel_price.Location = New System.Drawing.Point(232, 575)
        Me.panel_price.Name = "panel_price"
        Me.panel_price.Size = New System.Drawing.Size(458, 40)
        Me.panel_price.TabIndex = 2
        '
        'Label_Count
        '
        Me.Label_Count.AutoSize = True
        Me.Label_Count.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Count.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label_Count.Location = New System.Drawing.Point(208, 10)
        Me.Label_Count.Name = "Label_Count"
        Me.Label_Count.Size = New System.Drawing.Size(54, 20)
        Me.Label_Count.TabIndex = 2
        Me.Label_Count.Text = "0 Item"
        '
        'Label_price
        '
        Me.Label_price.AutoSize = True
        Me.Label_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_price.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label_price.Location = New System.Drawing.Point(344, 10)
        Me.Label_price.Name = "Label_price"
        Me.Label_price.Size = New System.Drawing.Size(47, 20)
        Me.Label_price.TabIndex = 1
        Me.Label_price.Text = "Rp. 0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(9, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "TOTAL ORDER"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(14, 212)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(892, 342)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.burger1label)
        Me.Panel1.Controls.Add(Me.burger_1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(105, 142)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(17, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rp. 50.000"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'burger1label
        '
        Me.burger1label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.burger1label.AutoSize = True
        Me.burger1label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.burger1label.ForeColor = System.Drawing.Color.Black
        Me.burger1label.Location = New System.Drawing.Point(17, 96)
        Me.burger1label.Name = "burger1label"
        Me.burger1label.Size = New System.Drawing.Size(75, 15)
        Me.burger1label.TabIndex = 1
        Me.burger1label.Text = "Big Burger"
        Me.burger1label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'burger_1
        '
        Me.burger_1.BackgroundImage = Global.restaurant_visual.My.Resources.Resources.burgers
        Me.burger_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.burger_1.Dock = System.Windows.Forms.DockStyle.Top
        Me.burger_1.FlatAppearance.BorderSize = 0
        Me.burger_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.burger_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.burger_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.burger_1.Location = New System.Drawing.Point(0, 0)
        Me.burger_1.Name = "burger_1"
        Me.burger_1.Size = New System.Drawing.Size(105, 93)
        Me.burger_1.TabIndex = 0
        Me.burger_1.UseVisualStyleBackColor = True
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.Color.Red
        Me.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear_btn.Location = New System.Drawing.Point(14, 575)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(200, 40)
        Me.clear_btn.TabIndex = 1
        Me.clear_btn.Text = "RESET"
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.restaurant_visual.My.Resources.Resources.image_1
        Me.PictureBox1.Location = New System.Drawing.Point(14, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(892, 187)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'burger_panel
        '
        Me.burger_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.burger_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.burger_panel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.burger_panel.Location = New System.Drawing.Point(208, 45)
        Me.burger_panel.Name = "burger_panel"
        Me.burger_panel.Size = New System.Drawing.Size(917, 627)
        Me.burger_panel.TabIndex = 2
        '
        'pizza_panel
        '
        Me.pizza_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pizza_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pizza_panel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.pizza_panel.Location = New System.Drawing.Point(208, 45)
        Me.pizza_panel.Name = "pizza_panel"
        Me.pizza_panel.Size = New System.Drawing.Size(917, 627)
        Me.pizza_panel.TabIndex = 3
        '
        'hotdog_panel
        '
        Me.hotdog_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.hotdog_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hotdog_panel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.hotdog_panel.Location = New System.Drawing.Point(208, 45)
        Me.hotdog_panel.Name = "hotdog_panel"
        Me.hotdog_panel.Size = New System.Drawing.Size(917, 627)
        Me.hotdog_panel.TabIndex = 4
        '
        'drink_panel
        '
        Me.drink_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.drink_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.drink_panel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.drink_panel.Location = New System.Drawing.Point(208, 45)
        Me.drink_panel.Name = "drink_panel"
        Me.drink_panel.Size = New System.Drawing.Size(917, 627)
        Me.drink_panel.TabIndex = 5
        '
        'main_screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1125, 672)
        Me.Controls.Add(Me.main_panel)
        Me.Controls.Add(Me.drink_panel)
        Me.Controls.Add(Me.hotdog_panel)
        Me.Controls.Add(Me.pizza_panel)
        Me.Controls.Add(Me.burger_panel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panel_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "main_screen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "main_screen"
        Me.panel_menu.ResumeLayout(False)
        Me.MenuGroup.ResumeLayout(False)
        CType(Me.logo_side_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.main_panel.ResumeLayout(False)
        Me.panel_price.ResumeLayout(False)
        Me.panel_price.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_menu As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents main_panel As Panel
    Friend WithEvents breadcump_label As Label
    Friend WithEvents logo_side_menu As PictureBox
    Friend WithEvents MenuGroup As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents burger_panel As Panel
    Friend WithEvents all_menu_btn As Button
    Friend WithEvents burger_btn As Button
    Friend WithEvents pizza_btn As Button
    Friend WithEvents HOTDOG_BTN As Button
    Friend WithEvents drinks_btn As Button
    Friend WithEvents pizza_panel As Panel
    Friend WithEvents hotdog_panel As Panel
    Friend WithEvents drink_panel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents burger_1 As Button
    Friend WithEvents burger1label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents clear_btn As Button
    Friend WithEvents panel_price As Panel
    Friend WithEvents Label_price As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_order As Button
    Friend WithEvents Label_Count As Label
End Class
