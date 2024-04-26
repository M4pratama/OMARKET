<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.lbl_time = New Guna.UI.WinForms.GunaLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaGradient2Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.lbl_totalusers = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGradient2Panel2 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.lbl_totalProduct = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGradient2Panel3 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaGradient2Panel1.SuspendLayout()
        Me.GunaGradient2Panel2.SuspendLayout()
        Me.GunaGradient2Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.Location = New System.Drawing.Point(648, 567)
        Me.lbl_time.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(64, 42)
        Me.lbl_time.TabIndex = 6
        Me.lbl_time.Text = "00"
        '
        'Timer1
        '
        '
        'GunaGradient2Panel1
        '
        Me.GunaGradient2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GunaGradient2Panel1.Controls.Add(Me.lbl_totalusers)
        Me.GunaGradient2Panel1.Controls.Add(Me.GunaLabel1)
        Me.GunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GunaGradient2Panel1.Location = New System.Drawing.Point(96, 98)
        Me.GunaGradient2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaGradient2Panel1.Name = "GunaGradient2Panel1"
        Me.GunaGradient2Panel1.Size = New System.Drawing.Size(161, 123)
        Me.GunaGradient2Panel1.TabIndex = 7
        '
        'lbl_totalusers
        '
        Me.lbl_totalusers.AutoSize = True
        Me.lbl_totalusers.BackColor = System.Drawing.Color.Transparent
        Me.lbl_totalusers.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalusers.ForeColor = System.Drawing.Color.White
        Me.lbl_totalusers.Location = New System.Drawing.Point(31, 55)
        Me.lbl_totalusers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_totalusers.Name = "lbl_totalusers"
        Me.lbl_totalusers.Size = New System.Drawing.Size(98, 69)
        Me.lbl_totalusers.TabIndex = 1
        Me.lbl_totalusers.Text = "00"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(1, 18)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(148, 25)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "TOTAL USER"
        '
        'GunaGradient2Panel2
        '
        Me.GunaGradient2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GunaGradient2Panel2.Controls.Add(Me.lbl_totalProduct)
        Me.GunaGradient2Panel2.Controls.Add(Me.GunaLabel)
        Me.GunaGradient2Panel2.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GunaGradient2Panel2.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GunaGradient2Panel2.Location = New System.Drawing.Point(300, 98)
        Me.GunaGradient2Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaGradient2Panel2.Name = "GunaGradient2Panel2"
        Me.GunaGradient2Panel2.Size = New System.Drawing.Size(171, 123)
        Me.GunaGradient2Panel2.TabIndex = 10
        '
        'lbl_totalProduct
        '
        Me.lbl_totalProduct.AutoSize = True
        Me.lbl_totalProduct.BackColor = System.Drawing.Color.Transparent
        Me.lbl_totalProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalProduct.ForeColor = System.Drawing.Color.White
        Me.lbl_totalProduct.Location = New System.Drawing.Point(31, 55)
        Me.lbl_totalProduct.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_totalProduct.Name = "lbl_totalProduct"
        Me.lbl_totalProduct.Size = New System.Drawing.Size(98, 69)
        Me.lbl_totalProduct.TabIndex = 1
        Me.lbl_totalProduct.Text = "00"
        '
        'GunaLabel
        '
        Me.GunaLabel.AutoSize = True
        Me.GunaLabel.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel.ForeColor = System.Drawing.Color.White
        Me.GunaLabel.Location = New System.Drawing.Point(1, 18)
        Me.GunaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel.Name = "GunaLabel"
        Me.GunaLabel.Size = New System.Drawing.Size(168, 24)
        Me.GunaLabel.TabIndex = 0
        Me.GunaLabel.Text = "TOTAL BARANG"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(29, 15)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(418, 69)
        Me.GunaLabel2.TabIndex = 8
        Me.GunaLabel2.Text = "DASHBOARD"
        '
        'GunaGradient2Panel3
        '
        Me.GunaGradient2Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GunaGradient2Panel3.Controls.Add(Me.GunaLabel5)
        Me.GunaGradient2Panel3.Controls.Add(Me.GunaLabel6)
        Me.GunaGradient2Panel3.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.GunaGradient2Panel3.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.GunaGradient2Panel3.Location = New System.Drawing.Point(498, 98)
        Me.GunaGradient2Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaGradient2Panel3.Name = "GunaGradient2Panel3"
        Me.GunaGradient2Panel3.Size = New System.Drawing.Size(161, 123)
        Me.GunaGradient2Panel3.TabIndex = 9
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.White
        Me.GunaLabel5.Location = New System.Drawing.Point(31, 55)
        Me.GunaLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(98, 69)
        Me.GunaLabel5.TabIndex = 1
        Me.GunaLabel5.Text = "00"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.White
        Me.GunaLabel6.Location = New System.Drawing.Point(1, 18)
        Me.GunaLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(148, 25)
        Me.GunaLabel6.TabIndex = 0
        Me.GunaLabel6.Text = "TOTAL USER"
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 704)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.GunaGradient2Panel1)
        Me.Controls.Add(Me.GunaGradient2Panel2)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaGradient2Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S"
        Me.GunaGradient2Panel1.ResumeLayout(False)
        Me.GunaGradient2Panel1.PerformLayout()
        Me.GunaGradient2Panel2.ResumeLayout(False)
        Me.GunaGradient2Panel2.PerformLayout()
        Me.GunaGradient2Panel3.ResumeLayout(False)
        Me.GunaGradient2Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_time As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GunaGradient2Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents lbl_totalusers As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGradient2Panel2 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents lbl_totalProduct As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaGradient2Panel3 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
End Class
