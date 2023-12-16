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
        Me.logo_side_menu = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.breadcump_label = New System.Windows.Forms.Label()
        Me.main_panel = New System.Windows.Forms.Panel()
        Me.burger_panel = New System.Windows.Forms.Panel()
        Me.all_menu_btn = New System.Windows.Forms.Button()
        Me.burger_btn = New System.Windows.Forms.Button()
        Me.pizza_btn = New System.Windows.Forms.Button()
        Me.HOTDOG_BTN = New System.Windows.Forms.Button()
        Me.drinks_btn = New System.Windows.Forms.Button()
        Me.pizza_panel = New System.Windows.Forms.Panel()
        Me.hotdog_panel = New System.Windows.Forms.Panel()
        Me.drink_panel = New System.Windows.Forms.Panel()
        Me.panel_menu.SuspendLayout()
        Me.MenuGroup.SuspendLayout()
        CType(Me.logo_side_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.main_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main_panel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.main_panel.Location = New System.Drawing.Point(208, 45)
        Me.main_panel.Name = "main_panel"
        Me.main_panel.Size = New System.Drawing.Size(917, 627)
        Me.main_panel.TabIndex = 1
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
        Me.burger_btn.Location = New System.Drawing.Point(3, 149)
        Me.burger_btn.Name = "burger_btn"
        Me.burger_btn.Size = New System.Drawing.Size(185, 125)
        Me.burger_btn.TabIndex = 1
        Me.burger_btn.Text = "BURGER"
        Me.burger_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.burger_btn.UseVisualStyleBackColor = False
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
        Me.Controls.Add(Me.drink_panel)
        Me.Controls.Add(Me.hotdog_panel)
        Me.Controls.Add(Me.pizza_panel)
        Me.Controls.Add(Me.burger_panel)
        Me.Controls.Add(Me.main_panel)
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
End Class
