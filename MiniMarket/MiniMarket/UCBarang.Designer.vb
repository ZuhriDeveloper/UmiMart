<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCBarang))
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDiskon = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbSatuan = New System.Windows.Forms.ComboBox()
        Me.CmbKelompok = New System.Windows.Forms.ComboBox()
        Me.TxtKeterangan = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.TxtHrgJual = New System.Windows.Forms.TextBox()
        Me.TxtHrgBeli = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtKodeBar = New System.Windows.Forms.TextBox()
        Me.TxtKodeBrg = New System.Windows.Forms.TextBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(22, 293)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(738, 197)
        Me.DGV.TabIndex = 211
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(625, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 21)
        Me.Label7.TabIndex = 239
        Me.Label7.Text = "%"
        '
        'TxtDiskon
        '
        Me.TxtDiskon.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtDiskon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TxtDiskon.Location = New System.Drawing.Point(535, 86)
        Me.TxtDiskon.MaxLength = 2
        Me.TxtDiskon.Name = "TxtDiskon"
        Me.TxtDiskon.Size = New System.Drawing.Size(84, 27)
        Me.TxtDiskon.TabIndex = 220
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(420, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 21)
        Me.Label3.TabIndex = 238
        Me.Label3.Text = "Diskon Jual :"
        '
        'TxtCari
        '
        Me.TxtCari.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtCari.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TxtCari.Location = New System.Drawing.Point(182, 261)
        Me.TxtCari.MaxLength = 25
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(225, 27)
        Me.TxtCari.TabIndex = 227
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(29, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 21)
        Me.Label2.TabIndex = 237
        Me.Label2.Text = "Cari Nama Barang :"
        '
        'CmbSatuan
        '
        Me.CmbSatuan.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.CmbSatuan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CmbSatuan.FormattingEnabled = True
        Me.CmbSatuan.Location = New System.Drawing.Point(155, 146)
        Me.CmbSatuan.Name = "CmbSatuan"
        Me.CmbSatuan.Size = New System.Drawing.Size(139, 29)
        Me.CmbSatuan.TabIndex = 217
        '
        'CmbKelompok
        '
        Me.CmbKelompok.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.CmbKelompok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CmbKelompok.FormattingEnabled = True
        Me.CmbKelompok.Location = New System.Drawing.Point(155, 115)
        Me.CmbKelompok.Name = "CmbKelompok"
        Me.CmbKelompok.Size = New System.Drawing.Size(139, 29)
        Me.CmbKelompok.TabIndex = 216
        '
        'TxtKeterangan
        '
        Me.TxtKeterangan.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtKeterangan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TxtKeterangan.Location = New System.Drawing.Point(535, 145)
        Me.TxtKeterangan.MaxLength = 50
        Me.TxtKeterangan.Name = "TxtKeterangan"
        Me.TxtKeterangan.Size = New System.Drawing.Size(225, 27)
        Me.TxtKeterangan.TabIndex = 222
        '
        'TxtStock
        '
        Me.TxtStock.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TxtStock.Location = New System.Drawing.Point(535, 115)
        Me.TxtStock.MaxLength = 18
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(225, 27)
        Me.TxtStock.TabIndex = 221
        '
        'TxtHrgJual
        '
        Me.TxtHrgJual.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtHrgJual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TxtHrgJual.Location = New System.Drawing.Point(535, 58)
        Me.TxtHrgJual.MaxLength = 18
        Me.TxtHrgJual.Name = "TxtHrgJual"
        Me.TxtHrgJual.Size = New System.Drawing.Size(225, 27)
        Me.TxtHrgJual.TabIndex = 219
        '
        'TxtHrgBeli
        '
        Me.TxtHrgBeli.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtHrgBeli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TxtHrgBeli.Location = New System.Drawing.Point(535, 28)
        Me.TxtHrgBeli.MaxLength = 18
        Me.TxtHrgBeli.Name = "TxtHrgBeli"
        Me.TxtHrgBeli.Size = New System.Drawing.Size(225, 27)
        Me.TxtHrgBeli.TabIndex = 218
        '
        'TxtNama
        '
        Me.TxtNama.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtNama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TxtNama.Location = New System.Drawing.Point(155, 85)
        Me.TxtNama.MaxLength = 50
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(225, 27)
        Me.TxtNama.TabIndex = 215
        '
        'TxtKodeBar
        '
        Me.TxtKodeBar.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtKodeBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TxtKodeBar.Location = New System.Drawing.Point(155, 56)
        Me.TxtKodeBar.MaxLength = 20
        Me.TxtKodeBar.Name = "TxtKodeBar"
        Me.TxtKodeBar.Size = New System.Drawing.Size(225, 27)
        Me.TxtKodeBar.TabIndex = 213
        '
        'TxtKodeBrg
        '
        Me.TxtKodeBrg.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtKodeBrg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TxtKodeBrg.Location = New System.Drawing.Point(155, 28)
        Me.TxtKodeBrg.MaxLength = 25
        Me.TxtKodeBrg.Name = "TxtKodeBrg"
        Me.TxtKodeBrg.Size = New System.Drawing.Size(225, 27)
        Me.TxtKodeBrg.TabIndex = 214
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSimpan.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BtnSimpan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(249, 196)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(122, 39)
        Me.BtnSimpan.TabIndex = 223
        Me.BtnSimpan.Text = "    Simpan"
        Me.BtnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBatal.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral
        Me.BtnBatal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBatal.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BtnBatal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnBatal.Image = CType(resources.GetObject("BtnBatal.Image"), System.Drawing.Image)
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(374, 196)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(127, 39)
        Me.BtnBatal.TabIndex = 224
        Me.BtnBatal.Text = "       Batal"
        Me.BtnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'BtnUbah
        '
        Me.BtnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnUbah.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral
        Me.BtnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUbah.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BtnUbah.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnUbah.Image = CType(resources.GetObject("BtnUbah.Image"), System.Drawing.Image)
        Me.BtnUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUbah.Location = New System.Drawing.Point(504, 196)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(127, 39)
        Me.BtnUbah.TabIndex = 225
        Me.BtnUbah.Text = "       Ubah"
        Me.BtnUbah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnUbah.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnHapus.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BtnHapus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), System.Drawing.Image)
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(633, 196)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(127, 39)
        Me.BtnHapus.TabIndex = 226
        Me.BtnHapus.Text = "       hapus"
        Me.BtnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(29, 150)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 21)
        Me.Label12.TabIndex = 236
        Me.Label12.Text = "Satuan :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(29, 121)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 21)
        Me.Label13.TabIndex = 235
        Me.Label13.Text = "Kelompok :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(420, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 21)
        Me.Label8.TabIndex = 234
        Me.Label8.Text = "Keterangan :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(420, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 21)
        Me.Label9.TabIndex = 233
        Me.Label9.Text = "Stock :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(420, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 21)
        Me.Label10.TabIndex = 232
        Me.Label10.Text = "Harga Jual :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(420, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 21)
        Me.Label6.TabIndex = 231
        Me.Label6.Text = "Harga Beli :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(29, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 21)
        Me.Label5.TabIndex = 230
        Me.Label5.Text = "Nama Barang :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(29, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 21)
        Me.Label4.TabIndex = 229
        Me.Label4.Text = "Kode Barcode :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(29, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 21)
        Me.Label1.TabIndex = 228
        Me.Label1.Text = "Kode Barang :"
        '
        'UCBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtDiskon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtCari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbSatuan)
        Me.Controls.Add(Me.CmbKelompok)
        Me.Controls.Add(Me.TxtKeterangan)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.TxtHrgJual)
        Me.Controls.Add(Me.TxtHrgBeli)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtKodeBar)
        Me.Controls.Add(Me.TxtKodeBrg)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV)
        Me.Name = "UCBarang"
        Me.Size = New System.Drawing.Size(848, 504)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtDiskon As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbSatuan As System.Windows.Forms.ComboBox
    Friend WithEvents CmbKelompok As System.Windows.Forms.ComboBox
    Friend WithEvents TxtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents TxtStock As System.Windows.Forms.TextBox
    Friend WithEvents TxtHrgJual As System.Windows.Forms.TextBox
    Friend WithEvents TxtHrgBeli As System.Windows.Forms.TextBox
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents TxtKodeBar As System.Windows.Forms.TextBox
    Friend WithEvents TxtKodeBrg As System.Windows.Forms.TextBox
    Private WithEvents BtnSimpan As System.Windows.Forms.Button
    Private WithEvents BtnBatal As System.Windows.Forms.Button
    Private WithEvents BtnUbah As System.Windows.Forms.Button
    Private WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
