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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_all = New System.Windows.Forms.Panel()
        Me.all_menu_btn = New System.Windows.Forms.Panel()
        Me.menu_label_1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.logo_side_menu = New System.Windows.Forms.PictureBox()
        Me.panel_menu.SuspendLayout()
        Me.MenuGroup.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.all_menu_btn.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo_side_menu, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MenuGroup.Controls.Add(Me.all_menu_btn)
        Me.MenuGroup.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuGroup.Location = New System.Drawing.Point(0, 190)
        Me.MenuGroup.Name = "MenuGroup"
        Me.MenuGroup.Size = New System.Drawing.Size(208, 482)
        Me.MenuGroup.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(208, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(917, 45)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ALL MENU"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panel_all
        '
        Me.panel_all.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.panel_all.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_all.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.panel_all.Location = New System.Drawing.Point(208, 45)
        Me.panel_all.Name = "panel_all"
        Me.panel_all.Size = New System.Drawing.Size(917, 627)
        Me.panel_all.TabIndex = 1
        '
        'all_menu_btn
        '
        Me.all_menu_btn.Controls.Add(Me.menu_label_1)
        Me.all_menu_btn.Controls.Add(Me.PictureBox1)
        Me.all_menu_btn.Location = New System.Drawing.Point(43, 39)
        Me.all_menu_btn.Name = "all_menu_btn"
        Me.all_menu_btn.Size = New System.Drawing.Size(114, 146)
        Me.all_menu_btn.TabIndex = 0
        '
        'menu_label_1
        '
        Me.menu_label_1.AutoSize = True
        Me.menu_label_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu_label_1.ForeColor = System.Drawing.SystemColors.Control
        Me.menu_label_1.Location = New System.Drawing.Point(12, 114)
        Me.menu_label_1.Name = "menu_label_1"
        Me.menu_label_1.Size = New System.Drawing.Size(89, 20)
        Me.menu_label_1.TabIndex = 1
        Me.menu_label_1.Text = "ALL MENU"
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.restaurant_visual.My.Resources.Resources.all_menu
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(107, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        'main_screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1125, 672)
        Me.Controls.Add(Me.panel_all)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panel_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "main_screen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "main_screen"
        Me.panel_menu.ResumeLayout(False)
        Me.MenuGroup.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.all_menu_btn.ResumeLayout(False)
        Me.all_menu_btn.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo_side_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_menu As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents panel_all As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents logo_side_menu As PictureBox
    Friend WithEvents MenuGroup As Panel
    Friend WithEvents all_menu_btn As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents menu_label_1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
