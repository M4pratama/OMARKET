<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnregister = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Button1 = New Guna.UI.WinForms.GunaImageButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnregister)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Location = New System.Drawing.Point(648, 159)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(491, 407)
        Me.Panel1.TabIndex = 18
        '
        'btnregister
        '
        Me.btnregister.AnimationHoverSpeed = 0.07!
        Me.btnregister.AnimationSpeed = 0.03!
        Me.btnregister.BaseColor = System.Drawing.Color.Transparent
        Me.btnregister.BorderColor = System.Drawing.Color.Black
        Me.btnregister.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnregister.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnregister.CheckedForeColor = System.Drawing.Color.White
        Me.btnregister.CheckedImage = CType(resources.GetObject("btnregister.CheckedImage"), System.Drawing.Image)
        Me.btnregister.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnregister.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnregister.FocusedColor = System.Drawing.Color.Empty
        Me.btnregister.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregister.ForeColor = System.Drawing.Color.Black
        Me.btnregister.Image = CType(resources.GetObject("btnregister.Image"), System.Drawing.Image)
        Me.btnregister.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnregister.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnregister.Location = New System.Drawing.Point(91, 359)
        Me.btnregister.Margin = New System.Windows.Forms.Padding(4)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnregister.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnregister.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnregister.OnHoverImage = Nothing
        Me.btnregister.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.btnregister.OnPressedColor = System.Drawing.Color.Black
        Me.btnregister.Size = New System.Drawing.Size(364, 33)
        Me.btnregister.TabIndex = 20
        Me.btnregister.Text = "don't have an account? register here"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageSize = New System.Drawing.Size(64, 64)
        Me.Button1.Location = New System.Drawing.Point(204, 288)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.OnHoverImage = Nothing
        Me.Button1.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.Button1.Size = New System.Drawing.Size(84, 63)
        Me.Button1.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 198)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 122)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Username"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(119, 165)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(264, 29)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(119, 237)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(264, 32)
        Me.TextBox2.TabIndex = 9
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(654, 582)
        Me.GunaPictureBox1.TabIndex = 19
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BackgroundImage = CType(resources.GetObject("GunaPictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.GunaPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPictureBox2.Location = New System.Drawing.Point(654, 0)
        Me.GunaPictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(488, 256)
        Me.GunaPictureBox2.TabIndex = 20
        Me.GunaPictureBox2.TabStop = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1142, 582)
        Me.Controls.Add(Me.GunaPictureBox2)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents btnregister As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
End Class
