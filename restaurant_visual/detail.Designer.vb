<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_Takeaway = New System.Windows.Forms.Button()
        Me.Button_DineIn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.logo_splash = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo_splash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button_Takeaway)
        Me.Panel1.Controls.Add(Me.Button_DineIn)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.logo_splash)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1481, 779)
        Me.Panel1.TabIndex = 0
        '
        'Button_Takeaway
        '
        Me.Button_Takeaway.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Takeaway.Image = Global.restaurant_visual.My.Resources.Resources.ri_takeaway_line
        Me.Button_Takeaway.Location = New System.Drawing.Point(799, 420)
        Me.Button_Takeaway.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_Takeaway.Name = "Button_Takeaway"
        Me.Button_Takeaway.Size = New System.Drawing.Size(357, 226)
        Me.Button_Takeaway.TabIndex = 8
        Me.Button_Takeaway.Text = "TAKE AWAY"
        Me.Button_Takeaway.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button_Takeaway.UseVisualStyleBackColor = True
        '
        'Button_DineIn
        '
        Me.Button_DineIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_DineIn.Image = Global.restaurant_visual.My.Resources.Resources.fluent_emoji_high_contrast_fork_and_knife_with_plate_png
        Me.Button_DineIn.Location = New System.Drawing.Point(367, 420)
        Me.Button_DineIn.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_DineIn.Name = "Button_DineIn"
        Me.Button_DineIn.Size = New System.Drawing.Size(357, 226)
        Me.Button_DineIn.TabIndex = 7
        Me.Button_DineIn.Text = "DINE IN"
        Me.Button_DineIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button_DineIn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.restaurant_visual.My.Resources.Resources.back
        Me.PictureBox1.Location = New System.Drawing.Point(97, 49)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'logo_splash
        '
        Me.logo_splash.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logo_splash.Image = Global.restaurant_visual.My.Resources.Resources.Ellipse_1
        Me.logo_splash.Location = New System.Drawing.Point(612, 49)
        Me.logo_splash.Margin = New System.Windows.Forms.Padding(4)
        Me.logo_splash.Name = "logo_splash"
        Me.logo_splash.Size = New System.Drawing.Size(267, 246)
        Me.logo_splash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo_splash.TabIndex = 5
        Me.logo_splash.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.restaurant_visual.My.Resources.Resources.exit_button_fix
        Me.PictureBox2.Location = New System.Drawing.Point(1323, 49)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.restaurant_visual.My.Resources.Resources.minimize_btn
        Me.PictureBox3.Location = New System.Drawing.Point(1264, 49)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(51, 39)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1479, 779)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "detail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "detail"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo_splash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents logo_splash As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button_DineIn As Button
    Friend WithEvents Button_Takeaway As Button
End Class
