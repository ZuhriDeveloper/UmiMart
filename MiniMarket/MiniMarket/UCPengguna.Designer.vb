<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPengguna
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCPengguna))
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtNmUser = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBOStatus = New System.Windows.Forms.ComboBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(33, 304)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(644, 175)
        Me.DGV.TabIndex = 224
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBatal.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral
        Me.BtnBatal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBatal.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BtnBatal.ForeColor = System.Drawing.Color.White
        Me.BtnBatal.Image = CType(resources.GetObject("BtnBatal.Image"), System.Drawing.Image)
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(156, 193)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(127, 39)
        Me.BtnBatal.TabIndex = 215
        Me.BtnBatal.Text = "       Batal"
        Me.BtnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnHapus.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BtnHapus.ForeColor = System.Drawing.Color.White
        Me.BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), System.Drawing.Image)
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(289, 193)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(127, 39)
        Me.BtnHapus.TabIndex = 217
        Me.BtnHapus.Text = "       hapus"
        Me.BtnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(29, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 21)
        Me.Label6.TabIndex = 222
        Me.Label6.Text = "Password :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(29, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 21)
        Me.Label5.TabIndex = 221
        Me.Label5.Text = "Nama Login :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(29, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 21)
        Me.Label1.TabIndex = 219
        Me.Label1.Text = "Kode User :"
        '
        'TxtCari
        '
        Me.TxtCari.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtCari.Location = New System.Drawing.Point(182, 258)
        Me.TxtCari.MaxLength = 25
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(225, 27)
        Me.TxtCari.TabIndex = 218
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(28, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 21)
        Me.Label2.TabIndex = 223
        Me.Label2.Text = "Cari Nama User :"
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtPassword.Location = New System.Drawing.Point(182, 111)
        Me.TxtPassword.MaxLength = 10
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(225, 27)
        Me.TxtPassword.TabIndex = 213
        '
        'TxtNmUser
        '
        Me.TxtNmUser.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtNmUser.Location = New System.Drawing.Point(182, 83)
        Me.TxtNmUser.MaxLength = 10
        Me.TxtNmUser.Name = "TxtNmUser"
        Me.TxtNmUser.Size = New System.Drawing.Size(225, 27)
        Me.TxtNmUser.TabIndex = 212
        '
        'TxtNama
        '
        Me.TxtNama.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtNama.Location = New System.Drawing.Point(182, 55)
        Me.TxtNama.MaxLength = 30
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(225, 27)
        Me.TxtNama.TabIndex = 211
        '
        'TxtKode
        '
        Me.TxtKode.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtKode.Location = New System.Drawing.Point(182, 28)
        Me.TxtKode.MaxLength = 25
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.Size = New System.Drawing.Size(225, 27)
        Me.TxtKode.TabIndex = 210
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSimpan.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BtnSimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(31, 193)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(122, 39)
        Me.BtnSimpan.TabIndex = 214
        Me.BtnSimpan.Text = "    Simpan"
        Me.BtnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(29, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 21)
        Me.Label4.TabIndex = 220
        Me.Label4.Text = "Nama User :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(29, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 21)
        Me.Label3.TabIndex = 225
        Me.Label3.Text = "Status :"
        '
        'CBOStatus
        '
        Me.CBOStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOStatus.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.CBOStatus.FormattingEnabled = True
        Me.CBOStatus.Location = New System.Drawing.Point(182, 139)
        Me.CBOStatus.Name = "CBOStatus"
        Me.CBOStatus.Size = New System.Drawing.Size(154, 29)
        Me.CBOStatus.TabIndex = 226
        '
        'UCPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CBOStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtNmUser)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.Label4)
        Me.Name = "UCPengguna"
        Me.Size = New System.Drawing.Size(848, 504)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Private WithEvents BtnBatal As System.Windows.Forms.Button
    Private WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents TxtNmUser As System.Windows.Forms.TextBox
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents TxtKode As System.Windows.Forms.TextBox
    Private WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBOStatus As System.Windows.Forms.ComboBox

End Class
