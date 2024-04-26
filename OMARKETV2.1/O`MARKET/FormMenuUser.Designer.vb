<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenuUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUser))
        Me.Panel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.logbtn = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.HomeBtn = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.ShopBtn = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.OMARKET = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.picMaximize = New System.Windows.Forms.PictureBox()
        Me.picMinimize = New System.Windows.Forms.PictureBox()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaLinePanel1.SuspendLayout()
        CType(Me.picMaximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BaseColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(209, 66)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.ShadowColor = System.Drawing.Color.Black
        Me.Panel1.Size = New System.Drawing.Size(1006, 601)
        Me.Panel1.TabIndex = 8
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.GunaAdvenceButton1)
        Me.GunaPanel1.Controls.Add(Me.logbtn)
        Me.GunaPanel1.Controls.Add(Me.HomeBtn)
        Me.GunaPanel1.Controls.Add(Me.ShopBtn)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(209, 667)
        Me.GunaPanel1.TabIndex = 7
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.SystemColors.Menu
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(-4, 187)
        Me.GunaAdvenceButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(213, 69)
        Me.GunaAdvenceButton1.TabIndex = 4
        Me.GunaAdvenceButton1.Text = "Belanja Sekarang"
        '
        'logbtn
        '
        Me.logbtn.AnimationHoverSpeed = 0.07!
        Me.logbtn.AnimationSpeed = 0.03!
        Me.logbtn.BaseColor = System.Drawing.Color.Transparent
        Me.logbtn.BorderColor = System.Drawing.Color.Black
        Me.logbtn.CheckedBaseColor = System.Drawing.Color.Gray
        Me.logbtn.CheckedBorderColor = System.Drawing.Color.Black
        Me.logbtn.CheckedForeColor = System.Drawing.Color.White
        Me.logbtn.CheckedImage = CType(resources.GetObject("logbtn.CheckedImage"), System.Drawing.Image)
        Me.logbtn.CheckedLineColor = System.Drawing.Color.DimGray
        Me.logbtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.logbtn.FocusedColor = System.Drawing.Color.Empty
        Me.logbtn.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.logbtn.ForeColor = System.Drawing.Color.White
        Me.logbtn.Image = CType(resources.GetObject("logbtn.Image"), System.Drawing.Image)
        Me.logbtn.ImageSize = New System.Drawing.Size(52, 52)
        Me.logbtn.LineColor = System.Drawing.Color.Transparent
        Me.logbtn.Location = New System.Drawing.Point(123, 577)
        Me.logbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.logbtn.Name = "logbtn"
        Me.logbtn.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.logbtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.logbtn.OnHoverForeColor = System.Drawing.Color.White
        Me.logbtn.OnHoverImage = Nothing
        Me.logbtn.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.logbtn.OnPressedColor = System.Drawing.Color.Black
        Me.logbtn.Size = New System.Drawing.Size(83, 75)
        Me.logbtn.TabIndex = 3
        '
        'HomeBtn
        '
        Me.HomeBtn.AnimationHoverSpeed = 0.07!
        Me.HomeBtn.AnimationSpeed = 0.03!
        Me.HomeBtn.BaseColor = System.Drawing.Color.Transparent
        Me.HomeBtn.BorderColor = System.Drawing.Color.Black
        Me.HomeBtn.CheckedBaseColor = System.Drawing.Color.Gray
        Me.HomeBtn.CheckedBorderColor = System.Drawing.Color.Black
        Me.HomeBtn.CheckedForeColor = System.Drawing.Color.White
        Me.HomeBtn.CheckedImage = CType(resources.GetObject("HomeBtn.CheckedImage"), System.Drawing.Image)
        Me.HomeBtn.CheckedLineColor = System.Drawing.Color.DimGray
        Me.HomeBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.HomeBtn.FocusedColor = System.Drawing.Color.Empty
        Me.HomeBtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeBtn.ForeColor = System.Drawing.Color.White
        Me.HomeBtn.Image = CType(resources.GetObject("HomeBtn.Image"), System.Drawing.Image)
        Me.HomeBtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.HomeBtn.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.HomeBtn.Location = New System.Drawing.Point(16, 596)
        Me.HomeBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HomeBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.HomeBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.HomeBtn.OnHoverImage = Nothing
        Me.HomeBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.HomeBtn.OnPressedColor = System.Drawing.Color.Black
        Me.HomeBtn.Size = New System.Drawing.Size(60, 57)
        Me.HomeBtn.TabIndex = 1
        '
        'ShopBtn
        '
        Me.ShopBtn.AnimationHoverSpeed = 0.07!
        Me.ShopBtn.AnimationSpeed = 0.03!
        Me.ShopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ShopBtn.BaseColor = System.Drawing.SystemColors.Menu
        Me.ShopBtn.BorderColor = System.Drawing.Color.Black
        Me.ShopBtn.CheckedBaseColor = System.Drawing.Color.Gray
        Me.ShopBtn.CheckedBorderColor = System.Drawing.Color.Black
        Me.ShopBtn.CheckedForeColor = System.Drawing.Color.White
        Me.ShopBtn.CheckedImage = CType(resources.GetObject("ShopBtn.CheckedImage"), System.Drawing.Image)
        Me.ShopBtn.CheckedLineColor = System.Drawing.Color.DimGray
        Me.ShopBtn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ShopBtn.FocusedColor = System.Drawing.Color.Empty
        Me.ShopBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ShopBtn.ForeColor = System.Drawing.Color.Black
        Me.ShopBtn.Image = CType(resources.GetObject("ShopBtn.Image"), System.Drawing.Image)
        Me.ShopBtn.ImageSize = New System.Drawing.Size(20, 20)
        Me.ShopBtn.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ShopBtn.Location = New System.Drawing.Point(-4, 110)
        Me.ShopBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ShopBtn.Name = "ShopBtn"
        Me.ShopBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShopBtn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.ShopBtn.OnHoverForeColor = System.Drawing.Color.White
        Me.ShopBtn.OnHoverImage = Nothing
        Me.ShopBtn.OnHoverLineColor = System.Drawing.Color.Black
        Me.ShopBtn.OnPressedColor = System.Drawing.Color.Black
        Me.ShopBtn.Size = New System.Drawing.Size(213, 69)
        Me.ShopBtn.TabIndex = 0
        Me.ShopBtn.Text = "Lihat Barang"
        '
        'OMARKET
        '
        Me.OMARKET.AutoSize = True
        Me.OMARKET.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OMARKET.Location = New System.Drawing.Point(16, 11)
        Me.OMARKET.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OMARKET.Name = "OMARKET"
        Me.OMARKET.Size = New System.Drawing.Size(262, 52)
        Me.OMARKET.TabIndex = 0
        Me.OMARKET.Text = "O`MARKET"
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GunaLinePanel1.Controls.Add(Me.picMaximize)
        Me.GunaLinePanel1.Controls.Add(Me.picMinimize)
        Me.GunaLinePanel1.Controls.Add(Me.picClose)
        Me.GunaLinePanel1.Controls.Add(Me.OMARKET)
        Me.GunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaLinePanel1.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(209, 0)
        Me.GunaLinePanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(1006, 66)
        Me.GunaLinePanel1.TabIndex = 6
        '
        'picMaximize
        '
        Me.picMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMaximize.Location = New System.Drawing.Point(1093, 23)
        Me.picMaximize.Margin = New System.Windows.Forms.Padding(4)
        Me.picMaximize.Name = "picMaximize"
        Me.picMaximize.Size = New System.Drawing.Size(24, 22)
        Me.picMaximize.TabIndex = 15
        Me.picMaximize.TabStop = False
        '
        'picMinimize
        '
        Me.picMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMinimize.Location = New System.Drawing.Point(1061, 23)
        Me.picMinimize.Margin = New System.Windows.Forms.Padding(4)
        Me.picMinimize.Name = "picMinimize"
        Me.picMinimize.Size = New System.Drawing.Size(24, 22)
        Me.picMinimize.TabIndex = 14
        Me.picMinimize.TabStop = False
        '
        'picClose
        '
        Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picClose.Location = New System.Drawing.Point(1029, 23)
        Me.picClose.Margin = New System.Windows.Forms.Padding(4)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(24, 22)
        Me.picClose.TabIndex = 13
        Me.picClose.TabStop = False
        '
        'FormMenuUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1215, 667)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaLinePanel1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormMenuUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMenuUser"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        CType(Me.picMaximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents ShopBtn As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents HomeBtn As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents logbtn As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents OMARKET As Guna.UI.WinForms.GunaLabel
    Friend WithEvents picClose As PictureBox
    Friend WithEvents picMinimize As PictureBox
    Friend WithEvents picMaximize As PictureBox
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
End Class
