<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCMenuUtama
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCMenuUtama))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.BtnGantiPassword = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BtnKunci = New System.Windows.Forms.Button()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PictureBox5)
        Me.Panel5.Controls.Add(Me.BtnGantiPassword)
        Me.Panel5.Location = New System.Drawing.Point(442, 149)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(153, 206)
        Me.Panel5.TabIndex = 13
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(17, 16)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(121, 122)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'BtnGantiPassword
        '
        Me.BtnGantiPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnGantiPassword.FlatAppearance.BorderSize = 0
        Me.BtnGantiPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGantiPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGantiPassword.ForeColor = System.Drawing.Color.Transparent
        Me.BtnGantiPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGantiPassword.Location = New System.Drawing.Point(17, 154)
        Me.BtnGantiPassword.Name = "BtnGantiPassword"
        Me.BtnGantiPassword.Size = New System.Drawing.Size(121, 39)
        Me.BtnGantiPassword.TabIndex = 9
        Me.BtnGantiPassword.Text = "Ganti Password"
        Me.BtnGantiPassword.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Controls.Add(Me.BtnKunci)
        Me.Panel4.Location = New System.Drawing.Point(254, 149)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(153, 206)
        Me.Panel4.TabIndex = 14
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(17, 16)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(121, 122)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'BtnKunci
        '
        Me.BtnKunci.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnKunci.FlatAppearance.BorderSize = 0
        Me.BtnKunci.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKunci.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKunci.ForeColor = System.Drawing.Color.Transparent
        Me.BtnKunci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKunci.Location = New System.Drawing.Point(17, 154)
        Me.BtnKunci.Name = "BtnKunci"
        Me.BtnKunci.Size = New System.Drawing.Size(121, 39)
        Me.BtnKunci.TabIndex = 9
        Me.BtnKunci.Text = "Log Out"
        Me.BtnKunci.UseVisualStyleBackColor = False
        '
        'UCMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "UCMenuUtama"
        Me.Size = New System.Drawing.Size(848, 504)
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Private WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnGantiPassword As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnKunci As System.Windows.Forms.Button

End Class
