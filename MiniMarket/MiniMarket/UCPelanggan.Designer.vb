<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPelanggan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCPelanggan))
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNo = New System.Windows.Forms.TextBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCari
        '
        Me.TxtCari.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtCari.Location = New System.Drawing.Point(242, 222)
        Me.TxtCari.MaxLength = 25
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(225, 27)
        Me.TxtCari.TabIndex = 185
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(30, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 21)
        Me.Label2.TabIndex = 191
        Me.Label2.Text = "Cari Nama Pelanggan : "
        '
        'TxtNo
        '
        Me.TxtNo.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TxtNo.Location = New System.Drawing.Point(178, 113)
        Me.TxtNo.MaxLength = 18
        Me.TxtNo.Name = "TxtNo"
        Me.TxtNo.Size = New System.Drawing.Size(225, 27)
        Me.TxtNo.TabIndex = 180
        '
        'TxtAlamat
        '
        Me.TxtAlamat.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtAlamat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TxtAlamat.Location = New System.Drawing.Point(178, 84)
        Me.TxtAlamat.MaxLength = 50
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.Size = New System.Drawing.Size(225, 27)
        Me.TxtAlamat.TabIndex = 179
        '
        'TxtNama
        '
        Me.TxtNama.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtNama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TxtNama.Location = New System.Drawing.Point(178, 56)
        Me.TxtNama.MaxLength = 20
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(225, 27)
        Me.TxtNama.TabIndex = 178
        '
        'TxtKode
        '
        Me.TxtKode.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtKode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TxtKode.Location = New System.Drawing.Point(178, 28)
        Me.TxtKode.MaxLength = 25
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.Size = New System.Drawing.Size(225, 27)
        Me.TxtKode.TabIndex = 177
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
        Me.BtnSimpan.Location = New System.Drawing.Point(31, 149)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(122, 39)
        Me.BtnSimpan.TabIndex = 181
        Me.BtnSimpan.Text = "    Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = False
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
        Me.BtnBatal.Location = New System.Drawing.Point(156, 149)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(127, 39)
        Me.BtnBatal.TabIndex = 182
        Me.BtnBatal.Text = "       Batal"
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'BtnUbah
        '
        Me.BtnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnUbah.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral
        Me.BtnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUbah.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BtnUbah.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnUbah.Image = CType(resources.GetObject("BtnUbah.Image"), System.Drawing.Image)
        Me.BtnUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUbah.Location = New System.Drawing.Point(285, 149)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(127, 39)
        Me.BtnUbah.TabIndex = 183
        Me.BtnUbah.Text = "       Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = False
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
        Me.BtnHapus.Location = New System.Drawing.Point(415, 149)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(127, 39)
        Me.BtnHapus.TabIndex = 184
        Me.BtnHapus.Text = "       hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(28, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 21)
        Me.Label6.TabIndex = 190
        Me.Label6.Text = "No. Telphon :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(29, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 21)
        Me.Label5.TabIndex = 189
        Me.Label5.Text = "Alamat :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(29, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 21)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "Nama :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(29, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 21)
        Me.Label1.TabIndex = 187
        Me.Label1.Text = "Kode Pelanggan :"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(37, 266)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(670, 216)
        Me.DGV.TabIndex = 192
        '
        'UCPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.TxtCari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNo)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UCPelanggan"
        Me.Size = New System.Drawing.Size(848, 504)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents TxtKode As System.Windows.Forms.TextBox
    Private WithEvents BtnSimpan As System.Windows.Forms.Button
    Private WithEvents BtnBatal As System.Windows.Forms.Button
    Private WithEvents BtnUbah As System.Windows.Forms.Button
    Private WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView

End Class
