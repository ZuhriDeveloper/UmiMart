<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCKelompok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCKelompok))
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.BtnHapus = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BtnSimpan.Location = New System.Drawing.Point(32, 83)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(128, 39)
        Me.BtnSimpan.TabIndex = 126
        Me.BtnSimpan.Text = "    Simpan"
        Me.BtnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'TxtNama
        '
        Me.TxtNama.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtNama.Location = New System.Drawing.Point(189, 28)
        Me.TxtNama.MaxLength = 25
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(225, 27)
        Me.TxtNama.TabIndex = 125
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
        Me.BtnBatal.Location = New System.Drawing.Point(166, 83)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(127, 39)
        Me.BtnBatal.TabIndex = 127
        Me.BtnBatal.Text = "       Batal"
        Me.BtnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(29, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 21)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "Nama Kelompok"
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
        Me.BtnUbah.Location = New System.Drawing.Point(299, 83)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(127, 39)
        Me.BtnUbah.TabIndex = 128
        Me.BtnUbah.Text = "       Ubah"
        Me.BtnUbah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnUbah.UseVisualStyleBackColor = False
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(32, 144)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(527, 216)
        Me.DGV.TabIndex = 210
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnHapus.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.ForeColor = System.Drawing.Color.White
        Me.BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), System.Drawing.Image)
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(432, 84)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(127, 39)
        Me.BtnHapus.TabIndex = 211
        Me.BtnHapus.Text = "       hapus"
        Me.BtnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'UCKelompok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnUbah)
        Me.Name = "UCKelompok"
        Me.Size = New System.Drawing.Size(848, 504)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Private WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Private WithEvents BtnHapus As System.Windows.Forms.Button

End Class
