<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPenjualan
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPenjualan))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TerbilangLbl = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TotalLbl = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LblJam = New System.Windows.Forms.Label()
        Me.LblHari = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblKasir = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblKdPel = New System.Windows.Forms.Label()
        Me.LblNmPel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtKodeBrg = New System.Windows.Forms.TextBox()
        Me.TxtKodeBarcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtJml = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtFaktur = New System.Windows.Forms.Label()
        Me.TxtNmBrg = New System.Windows.Forms.Label()
        Me.TxtHarga = New System.Windows.Forms.Label()
        Me.TxtSatuan = New System.Windows.Forms.Label()
        Me.TxtSubTtl = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TerbilangLbl)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TotalLbl)
        Me.Panel2.Controls.Add(Me.BtnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1800, 197)
        Me.Panel2.TabIndex = 135
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(608, 94)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(314, 58)
        Me.Label20.TabIndex = 1012
        Me.Label20.Text = "- Penjualan -"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(56, 140)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 27)
        Me.Label4.TabIndex = 1009
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(56, 103)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 27)
        Me.Label18.TabIndex = 1010
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(36, 34)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(256, 67)
        Me.Label19.TabIndex = 1011
        Me.Label19.Text = "UMI Mart"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(1686, 154)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 43)
        Me.Label11.TabIndex = 1008
        Me.Label11.Text = "Rupiah"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TerbilangLbl
        '
        Me.TerbilangLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TerbilangLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TerbilangLbl.ForeColor = System.Drawing.Color.White
        Me.TerbilangLbl.Location = New System.Drawing.Point(692, 154)
        Me.TerbilangLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TerbilangLbl.Name = "TerbilangLbl"
        Me.TerbilangLbl.Size = New System.Drawing.Size(966, 43)
        Me.TerbilangLbl.TabIndex = 1007
        Me.TerbilangLbl.Text = "Nol*"
        Me.TerbilangLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Aqua
        Me.Label10.Location = New System.Drawing.Point(889, 14)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(267, 108)
        Me.Label10.TabIndex = 1006
        Me.Label10.Text = "Rp"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalLbl
        '
        Me.TotalLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TotalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLbl.ForeColor = System.Drawing.Color.Aqua
        Me.TotalLbl.Location = New System.Drawing.Point(655, 14)
        Me.TotalLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalLbl.Name = "TotalLbl"
        Me.TotalLbl.Size = New System.Drawing.Size(1143, 108)
        Me.TotalLbl.TabIndex = 1005
        Me.TotalLbl.Text = "0"
        Me.TotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(1966, 6)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(57, 48)
        Me.BtnClose.TabIndex = 15
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.LblJam)
        Me.Panel5.Controls.Add(Me.LblHari)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.LblKasir)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 1058)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1800, 48)
        Me.Panel5.TabIndex = 136
        '
        'LblJam
        '
        Me.LblJam.AutoSize = True
        Me.LblJam.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LblJam.ForeColor = System.Drawing.Color.White
        Me.LblJam.Location = New System.Drawing.Point(1353, 6)
        Me.LblJam.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblJam.Name = "LblJam"
        Me.LblJam.Size = New System.Drawing.Size(119, 30)
        Me.LblJam.TabIndex = 178
        Me.LblJam.Text = "UMI Mart"
        '
        'LblHari
        '
        Me.LblHari.AutoSize = True
        Me.LblHari.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LblHari.ForeColor = System.Drawing.Color.White
        Me.LblHari.Location = New System.Drawing.Point(1059, 6)
        Me.LblHari.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblHari.Name = "LblHari"
        Me.LblHari.Size = New System.Drawing.Size(146, 30)
        Me.LblHari.TabIndex = 177
        Me.LblHari.Text = "Minimarket"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(495, 6)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(300, 30)
        Me.Label17.TabIndex = 166
        Me.Label17.Text = "[ F3 ] - Daftar Pelanggan"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(206, 6)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(254, 30)
        Me.Label16.TabIndex = 165
        Me.Label16.Text = "[ F2 ] - Daftar Barang"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(18, 6)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(156, 30)
        Me.Label15.TabIndex = 164
        Me.Label15.Text = "[ F1 ] - Bayar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(814, 6)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(164, 30)
        Me.Label14.TabIndex = 163
        Me.Label14.Text = "[ Esc ] - Batal"
        '
        'LblKasir
        '
        Me.LblKasir.AutoSize = True
        Me.LblKasir.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LblKasir.ForeColor = System.Drawing.Color.White
        Me.LblKasir.Location = New System.Drawing.Point(1610, 5)
        Me.LblKasir.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblKasir.Name = "LblKasir"
        Me.LblKasir.Size = New System.Drawing.Size(75, 30)
        Me.LblKasir.TabIndex = 169
        Me.LblKasir.Text = "Kode"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(1526, 5)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 30)
        Me.Label12.TabIndex = 165
        Me.Label12.Text = "User :"
        '
        'LblKdPel
        '
        Me.LblKdPel.AutoSize = True
        Me.LblKdPel.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LblKdPel.ForeColor = System.Drawing.Color.White
        Me.LblKdPel.Location = New System.Drawing.Point(545, 202)
        Me.LblKdPel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblKdPel.Name = "LblKdPel"
        Me.LblKdPel.Size = New System.Drawing.Size(75, 30)
        Me.LblKdPel.TabIndex = 167
        Me.LblKdPel.Text = "Kode"
        '
        'LblNmPel
        '
        Me.LblNmPel.AutoSize = True
        Me.LblNmPel.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LblNmPel.ForeColor = System.Drawing.Color.White
        Me.LblNmPel.Location = New System.Drawing.Point(858, 201)
        Me.LblNmPel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNmPel.Name = "LblNmPel"
        Me.LblNmPel.Size = New System.Drawing.Size(217, 30)
        Me.LblNmPel.TabIndex = 168
        Me.LblNmPel.Text = "NamaPelanggan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(366, 202)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(157, 30)
        Me.Label13.TabIndex = 140
        Me.Label13.Text = "Pelanggan :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label5.Location = New System.Drawing.Point(320, 231)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 30)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(25, 201)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 30)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Faktur :"
        '
        'TxtKodeBrg
        '
        Me.TxtKodeBrg.BackColor = System.Drawing.Color.DimGray
        Me.TxtKodeBrg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtKodeBrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtKodeBrg.ForeColor = System.Drawing.Color.DimGray
        Me.TxtKodeBrg.Location = New System.Drawing.Point(70, 317)
        Me.TxtKodeBrg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtKodeBrg.MaxLength = 20
        Me.TxtKodeBrg.Name = "TxtKodeBrg"
        Me.TxtKodeBrg.Size = New System.Drawing.Size(274, 28)
        Me.TxtKodeBrg.TabIndex = 145
        Me.TxtKodeBrg.Visible = False
        '
        'TxtKodeBarcode
        '
        Me.TxtKodeBarcode.BackColor = System.Drawing.Color.DimGray
        Me.TxtKodeBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtKodeBarcode.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtKodeBarcode.ForeColor = System.Drawing.SystemColors.Info
        Me.TxtKodeBarcode.Location = New System.Drawing.Point(18, 268)
        Me.TxtKodeBarcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtKodeBarcode.MaxLength = 25
        Me.TxtKodeBarcode.Name = "TxtKodeBarcode"
        Me.TxtKodeBarcode.Size = New System.Drawing.Size(274, 37)
        Me.TxtKodeBarcode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label2.Location = New System.Drawing.Point(760, 231)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 30)
        Me.Label2.TabIndex = 149
        Me.Label2.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label3.Location = New System.Drawing.Point(1086, 231)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 30)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Satuan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label6.Location = New System.Drawing.Point(1364, 226)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 30)
        Me.Label6.TabIndex = 151
        Me.Label6.Text = "Jumlah"
        '
        'TxtJml
        '
        Me.TxtJml.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtJml.BackColor = System.Drawing.Color.DimGray
        Me.TxtJml.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtJml.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtJml.ForeColor = System.Drawing.SystemColors.Info
        Me.TxtJml.Location = New System.Drawing.Point(1195, 262)
        Me.TxtJml.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtJml.MaxLength = 20
        Me.TxtJml.Name = "TxtJml"
        Me.TxtJml.Size = New System.Drawing.Size(168, 37)
        Me.TxtJml.TabIndex = 153
        Me.TxtJml.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label8.Location = New System.Drawing.Point(1667, 231)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 30)
        Me.Label8.TabIndex = 155
        Me.Label8.Text = "Sub Total"
        '
        'DGV
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV.Location = New System.Drawing.Point(0, 315)
        Me.DGV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RowHeadersWidth = 62
        Me.DGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGV.Size = New System.Drawing.Size(1800, 743)
        Me.DGV.TabIndex = 160
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label9.Location = New System.Drawing.Point(18, 231)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(194, 30)
        Me.Label9.TabIndex = 162
        Me.Label9.Text = "Scan Barcode :"
        '
        'TxtFaktur
        '
        Me.TxtFaktur.AutoSize = True
        Me.TxtFaktur.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtFaktur.ForeColor = System.Drawing.Color.White
        Me.TxtFaktur.Location = New System.Drawing.Point(169, 202)
        Me.TxtFaktur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtFaktur.Name = "TxtFaktur"
        Me.TxtFaktur.Size = New System.Drawing.Size(97, 30)
        Me.TxtFaktur.TabIndex = 171
        Me.TxtFaktur.Text = "Faktur :"
        '
        'TxtNmBrg
        '
        Me.TxtNmBrg.AutoSize = True
        Me.TxtNmBrg.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtNmBrg.ForeColor = System.Drawing.Color.Aquamarine
        Me.TxtNmBrg.Location = New System.Drawing.Point(320, 275)
        Me.TxtNmBrg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtNmBrg.Name = "TxtNmBrg"
        Me.TxtNmBrg.Size = New System.Drawing.Size(178, 30)
        Me.TxtNmBrg.TabIndex = 172
        Me.TxtNmBrg.Text = "Nama Barang"
        '
        'TxtHarga
        '
        Me.TxtHarga.AutoSize = True
        Me.TxtHarga.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtHarga.ForeColor = System.Drawing.Color.Aquamarine
        Me.TxtHarga.Location = New System.Drawing.Point(760, 271)
        Me.TxtHarga.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(84, 30)
        Me.TxtHarga.TabIndex = 173
        Me.TxtHarga.Text = "Harga"
        '
        'TxtSatuan
        '
        Me.TxtSatuan.AutoSize = True
        Me.TxtSatuan.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtSatuan.ForeColor = System.Drawing.Color.Aquamarine
        Me.TxtSatuan.Location = New System.Drawing.Point(1086, 271)
        Me.TxtSatuan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtSatuan.Name = "TxtSatuan"
        Me.TxtSatuan.Size = New System.Drawing.Size(95, 30)
        Me.TxtSatuan.TabIndex = 175
        Me.TxtSatuan.Text = "Satuan"
        '
        'TxtSubTtl
        '
        Me.TxtSubTtl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSubTtl.AutoSize = True
        Me.TxtSubTtl.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.TxtSubTtl.ForeColor = System.Drawing.Color.Aquamarine
        Me.TxtSubTtl.Location = New System.Drawing.Point(1667, 271)
        Me.TxtSubTtl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtSubTtl.Name = "TxtSubTtl"
        Me.TxtSubTtl.Size = New System.Drawing.Size(120, 30)
        Me.TxtSubTtl.TabIndex = 176
        Me.TxtSubTtl.Text = "Sub Total"
        Me.TxtSubTtl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1701, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 36)
        Me.Button1.TabIndex = 179
        Me.Button1.Text = "Buka Laci"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1800, 1106)
        Me.Controls.Add(Me.TxtSubTtl)
        Me.Controls.Add(Me.TxtSatuan)
        Me.Controls.Add(Me.TxtFaktur)
        Me.Controls.Add(Me.LblKdPel)
        Me.Controls.Add(Me.TxtHarga)
        Me.Controls.Add(Me.LblNmPel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtNmBrg)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtJml)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtKodeBrg)
        Me.Controls.Add(Me.TxtKodeBarcode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPenjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtKodeBrg As System.Windows.Forms.TextBox
    Friend WithEvents TxtKodeBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtJml As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TotalLbl As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TerbilangLbl As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LblKdPel As System.Windows.Forms.Label
    Friend WithEvents LblNmPel As System.Windows.Forms.Label
    Friend WithEvents LblKasir As System.Windows.Forms.Label
    Friend WithEvents TxtFaktur As System.Windows.Forms.Label
    Friend WithEvents TxtNmBrg As System.Windows.Forms.Label
    Friend WithEvents TxtHarga As System.Windows.Forms.Label
    Friend WithEvents TxtSatuan As System.Windows.Forms.Label
    Friend WithEvents TxtSubTtl As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents LblJam As System.Windows.Forms.Label
    Friend WithEvents LblHari As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
End Class
