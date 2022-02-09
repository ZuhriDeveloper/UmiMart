<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuUtama))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnLaporan = New System.Windows.Forms.Button()
        Me.BtnPenjualan = New System.Windows.Forms.Button()
        Me.BtnPembelian = New System.Windows.Forms.Button()
        Me.BtnBarang = New System.Windows.Forms.Button()
        Me.BtnSatuan = New System.Windows.Forms.Button()
        Me.BtnKelompok = New System.Windows.Forms.Button()
        Me.BtnPemasok = New System.Windows.Forms.Button()
        Me.BtnPelanggan = New System.Windows.Forms.Button()
        Me.BtnUser = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LblNamaUser = New System.Windows.Forms.Label()
        Me.LblKodeUser = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblJam = New System.Windows.Forms.Label()
        Me.LblHari = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.UcMenuUtama1 = New MiniMarket.UCMenuUtama()
        Me.UcPelanggan1 = New MiniMarket.UCPelanggan()
        Me.UcPemasok1 = New MiniMarket.UCPemasok()
        Me.UcKelompok1 = New MiniMarket.UCKelompok()
        Me.UcBarang1 = New MiniMarket.UCBarang()
        Me.UcPengguna1 = New MiniMarket.UCPengguna()
        Me.UcGantiPass1 = New MiniMarket.UCGantiPass()
        Me.UcLogin1 = New MiniMarket.UCLogin()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.panel3.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.SidePanel)
        Me.Panel1.Controls.Add(Me.BtnHome)
        Me.Panel1.Controls.Add(Me.panel3)
        Me.Panel1.Controls.Add(Me.BtnLaporan)
        Me.Panel1.Controls.Add(Me.BtnPenjualan)
        Me.Panel1.Controls.Add(Me.BtnPembelian)
        Me.Panel1.Controls.Add(Me.BtnBarang)
        Me.Panel1.Controls.Add(Me.BtnSatuan)
        Me.Panel1.Controls.Add(Me.BtnKelompok)
        Me.Panel1.Controls.Add(Me.BtnPemasok)
        Me.Panel1.Controls.Add(Me.BtnPelanggan)
        Me.Panel1.Controls.Add(Me.BtnUser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 1031)
        Me.Panel1.TabIndex = 0
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SidePanel.Location = New System.Drawing.Point(2, 198)
        Me.SidePanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(15, 69)
        Me.SidePanel.TabIndex = 5
        '
        'BtnHome
        '
        Me.BtnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnHome.FlatAppearance.BorderSize = 0
        Me.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHome.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.ForeColor = System.Drawing.Color.Transparent
        Me.BtnHome.Image = CType(resources.GetObject("BtnHome.Image"), System.Drawing.Image)
        Me.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHome.Location = New System.Drawing.Point(21, 198)
        Me.BtnHome.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(231, 69)
        Me.BtnHome.TabIndex = 6
        Me.BtnHome.Text = "           Home"
        Me.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHome.UseVisualStyleBackColor = False
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.panel3.Controls.Add(Me.pictureBox1)
        Me.panel3.Location = New System.Drawing.Point(40, 9)
        Me.panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(208, 151)
        Me.panel3.TabIndex = 7
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(34, 12)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(144, 126)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 4
        Me.pictureBox1.TabStop = False
        '
        'BtnLaporan
        '
        Me.BtnLaporan.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnLaporan.FlatAppearance.BorderSize = 0
        Me.BtnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLaporan.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLaporan.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLaporan.Image = CType(resources.GetObject("BtnLaporan.Image"), System.Drawing.Image)
        Me.BtnLaporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLaporan.Location = New System.Drawing.Point(21, 905)
        Me.BtnLaporan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnLaporan.Name = "BtnLaporan"
        Me.BtnLaporan.Size = New System.Drawing.Size(231, 69)
        Me.BtnLaporan.TabIndex = 15
        Me.BtnLaporan.Text = "   Laporan"
        Me.BtnLaporan.UseVisualStyleBackColor = False
        Me.BtnLaporan.Visible = False
        '
        'BtnPenjualan
        '
        Me.BtnPenjualan.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnPenjualan.FlatAppearance.BorderSize = 0
        Me.BtnPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPenjualan.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPenjualan.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPenjualan.Image = CType(resources.GetObject("BtnPenjualan.Image"), System.Drawing.Image)
        Me.BtnPenjualan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPenjualan.Location = New System.Drawing.Point(25, 262)
        Me.BtnPenjualan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnPenjualan.Name = "BtnPenjualan"
        Me.BtnPenjualan.Size = New System.Drawing.Size(231, 69)
        Me.BtnPenjualan.TabIndex = 14
        Me.BtnPenjualan.Text = "       Penjualan"
        Me.BtnPenjualan.UseVisualStyleBackColor = False
        '
        'BtnPembelian
        '
        Me.BtnPembelian.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnPembelian.FlatAppearance.BorderSize = 0
        Me.BtnPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPembelian.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPembelian.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPembelian.Image = CType(resources.GetObject("BtnPembelian.Image"), System.Drawing.Image)
        Me.BtnPembelian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPembelian.Location = New System.Drawing.Point(21, 789)
        Me.BtnPembelian.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnPembelian.Name = "BtnPembelian"
        Me.BtnPembelian.Size = New System.Drawing.Size(231, 69)
        Me.BtnPembelian.TabIndex = 13
        Me.BtnPembelian.Text = "       Pembelian"
        Me.BtnPembelian.UseVisualStyleBackColor = False
        Me.BtnPembelian.Visible = False
        '
        'BtnBarang
        '
        Me.BtnBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnBarang.FlatAppearance.BorderSize = 0
        Me.BtnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBarang.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBarang.ForeColor = System.Drawing.Color.Transparent
        Me.BtnBarang.Image = CType(resources.GetObject("BtnBarang.Image"), System.Drawing.Image)
        Me.BtnBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBarang.Location = New System.Drawing.Point(21, 710)
        Me.BtnBarang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBarang.Name = "BtnBarang"
        Me.BtnBarang.Size = New System.Drawing.Size(231, 69)
        Me.BtnBarang.TabIndex = 12
        Me.BtnBarang.Text = "  Barang"
        Me.BtnBarang.UseVisualStyleBackColor = False
        Me.BtnBarang.Visible = False
        '
        'BtnSatuan
        '
        Me.BtnSatuan.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnSatuan.FlatAppearance.BorderSize = 0
        Me.BtnSatuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSatuan.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSatuan.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSatuan.Image = CType(resources.GetObject("BtnSatuan.Image"), System.Drawing.Image)
        Me.BtnSatuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSatuan.Location = New System.Drawing.Point(21, 632)
        Me.BtnSatuan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSatuan.Name = "BtnSatuan"
        Me.BtnSatuan.Size = New System.Drawing.Size(231, 69)
        Me.BtnSatuan.TabIndex = 11
        Me.BtnSatuan.Text = "  Satuan"
        Me.BtnSatuan.UseVisualStyleBackColor = False
        Me.BtnSatuan.Visible = False
        '
        'BtnKelompok
        '
        Me.BtnKelompok.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnKelompok.FlatAppearance.BorderSize = 0
        Me.BtnKelompok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKelompok.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKelompok.ForeColor = System.Drawing.Color.Transparent
        Me.BtnKelompok.Image = CType(resources.GetObject("BtnKelompok.Image"), System.Drawing.Image)
        Me.BtnKelompok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKelompok.Location = New System.Drawing.Point(21, 553)
        Me.BtnKelompok.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnKelompok.Name = "BtnKelompok"
        Me.BtnKelompok.Size = New System.Drawing.Size(231, 69)
        Me.BtnKelompok.TabIndex = 10
        Me.BtnKelompok.Text = "      Kelompok"
        Me.BtnKelompok.UseVisualStyleBackColor = False
        Me.BtnKelompok.Visible = False
        '
        'BtnPemasok
        '
        Me.BtnPemasok.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnPemasok.FlatAppearance.BorderSize = 0
        Me.BtnPemasok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPemasok.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPemasok.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPemasok.Image = CType(resources.GetObject("BtnPemasok.Image"), System.Drawing.Image)
        Me.BtnPemasok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPemasok.Location = New System.Drawing.Point(21, 475)
        Me.BtnPemasok.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnPemasok.Name = "BtnPemasok"
        Me.BtnPemasok.Size = New System.Drawing.Size(231, 69)
        Me.BtnPemasok.TabIndex = 9
        Me.BtnPemasok.Text = "     Pemasok"
        Me.BtnPemasok.UseVisualStyleBackColor = False
        Me.BtnPemasok.Visible = False
        '
        'BtnPelanggan
        '
        Me.BtnPelanggan.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnPelanggan.FlatAppearance.BorderSize = 0
        Me.BtnPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPelanggan.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPelanggan.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPelanggan.Image = CType(resources.GetObject("BtnPelanggan.Image"), System.Drawing.Image)
        Me.BtnPelanggan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPelanggan.Location = New System.Drawing.Point(21, 396)
        Me.BtnPelanggan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnPelanggan.Name = "BtnPelanggan"
        Me.BtnPelanggan.Size = New System.Drawing.Size(231, 69)
        Me.BtnPelanggan.TabIndex = 8
        Me.BtnPelanggan.Text = "         Pelanggan"
        Me.BtnPelanggan.UseVisualStyleBackColor = False
        Me.BtnPelanggan.Visible = False
        '
        'BtnUser
        '
        Me.BtnUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnUser.FlatAppearance.BorderSize = 0
        Me.BtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUser.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUser.ForeColor = System.Drawing.Color.Transparent
        Me.BtnUser.Image = CType(resources.GetObject("BtnUser.Image"), System.Drawing.Image)
        Me.BtnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUser.Location = New System.Drawing.Point(21, 748)
        Me.BtnUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnUser.Name = "BtnUser"
        Me.BtnUser.Size = New System.Drawing.Size(231, 69)
        Me.BtnUser.TabIndex = 7
        Me.BtnUser.Text = "           User"
        Me.BtnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUser.UseVisualStyleBackColor = False
        Me.BtnUser.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BtnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(270, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1275, 52)
        Me.Panel2.TabIndex = 1
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(1215, 0)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(57, 48)
        Me.BtnClose.TabIndex = 16
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(928, 100)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 58)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "- Program POS -"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Controls.Add(Me.LblNamaUser)
        Me.Panel4.Controls.Add(Me.LblKodeUser)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.LblJam)
        Me.Panel4.Controls.Add(Me.LblHari)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(270, 993)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1275, 38)
        Me.Panel4.TabIndex = 35
        '
        'LblNamaUser
        '
        Me.LblNamaUser.AutoSize = True
        Me.LblNamaUser.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LblNamaUser.ForeColor = System.Drawing.Color.White
        Me.LblNamaUser.Location = New System.Drawing.Point(942, 5)
        Me.LblNamaUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNamaUser.Name = "LblNamaUser"
        Me.LblNamaUser.Size = New System.Drawing.Size(87, 30)
        Me.LblNamaUser.TabIndex = 42
        Me.LblNamaUser.Text = "Nama"
        '
        'LblKodeUser
        '
        Me.LblKodeUser.AutoSize = True
        Me.LblKodeUser.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LblKodeUser.ForeColor = System.Drawing.Color.White
        Me.LblKodeUser.Location = New System.Drawing.Point(834, 5)
        Me.LblKodeUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblKodeUser.Name = "LblKodeUser"
        Me.LblKodeUser.Size = New System.Drawing.Size(87, 30)
        Me.LblKodeUser.TabIndex = 39
        Me.LblKodeUser.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(804, 5)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 30)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(735, 5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 30)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "User"
        '
        'LblJam
        '
        Me.LblJam.AutoSize = True
        Me.LblJam.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LblJam.ForeColor = System.Drawing.Color.White
        Me.LblJam.Location = New System.Drawing.Point(340, 5)
        Me.LblJam.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblJam.Name = "LblJam"
        Me.LblJam.Size = New System.Drawing.Size(119, 30)
        Me.LblJam.TabIndex = 36
        Me.LblJam.Text = "UMI Mart"
        '
        'LblHari
        '
        Me.LblHari.AutoSize = True
        Me.LblHari.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.LblHari.ForeColor = System.Drawing.Color.White
        Me.LblHari.Location = New System.Drawing.Point(26, 5)
        Me.LblHari.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblHari.Name = "LblHari"
        Me.LblHari.Size = New System.Drawing.Size(146, 30)
        Me.LblHari.TabIndex = 35
        Me.LblHari.Text = "Minimarket"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(288, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 67)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "UMI Mart"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(308, 123)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 27)
        Me.Label9.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(308, 154)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 27)
        Me.Label10.TabIndex = 17
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(288, 188)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1245, 6)
        Me.Panel5.TabIndex = 36
        '

        '
        'UcMenuUtama1
        '
        Me.UcMenuUtama1.Location = New System.Drawing.Point(270, 198)
        Me.UcMenuUtama1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcMenuUtama1.Name = "UcMenuUtama1"
        Me.UcMenuUtama1.Size = New System.Drawing.Size(1272, 775)
        Me.UcMenuUtama1.TabIndex = 26
        '
        '
        'UcPelanggan1
        '
        Me.UcPelanggan1.Location = New System.Drawing.Point(270, 198)
        Me.UcPelanggan1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcPelanggan1.Name = "UcPelanggan1"
        Me.UcPelanggan1.Size = New System.Drawing.Size(1272, 775)
        Me.UcPelanggan1.TabIndex = 28
        '
        'UcPemasok1
        '
        Me.UcPemasok1.Location = New System.Drawing.Point(270, 198)
        Me.UcPemasok1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcPemasok1.Name = "UcPemasok1"
        Me.UcPemasok1.Size = New System.Drawing.Size(1272, 775)
        Me.UcPemasok1.TabIndex = 37
        '
        'UcKelompok1
        '
        Me.UcKelompok1.Location = New System.Drawing.Point(270, 198)
        Me.UcKelompok1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcKelompok1.Name = "UcKelompok1"
        Me.UcKelompok1.Size = New System.Drawing.Size(1272, 775)
        Me.UcKelompok1.TabIndex = 38
        '

        '
        'UcBarang1
        '
        Me.UcBarang1.Location = New System.Drawing.Point(270, 198)
        Me.UcBarang1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcBarang1.Name = "UcBarang1"
        Me.UcBarang1.Size = New System.Drawing.Size(1275, 785)
        Me.UcBarang1.TabIndex = 42
        '
        '
        'UcPengguna1
        '
        Me.UcPengguna1.Location = New System.Drawing.Point(272, 198)
        Me.UcPengguna1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcPengguna1.Name = "UcPengguna1"
        Me.UcPengguna1.Size = New System.Drawing.Size(1272, 775)
        Me.UcPengguna1.TabIndex = 50
        '
        'UcGantiPass1
        '
        Me.UcGantiPass1.Location = New System.Drawing.Point(272, 198)
        Me.UcGantiPass1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcGantiPass1.Name = "UcGantiPass1"
        Me.UcGantiPass1.Size = New System.Drawing.Size(1272, 775)
        Me.UcGantiPass1.TabIndex = 51
        '
        'UcLogin1
        '
        Me.UcLogin1.Location = New System.Drawing.Point(272, 198)
        Me.UcLogin1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UcLogin1.Name = "UcLogin1"
        Me.UcLogin1.Size = New System.Drawing.Size(1272, 775)
        Me.UcLogin1.TabIndex = 52
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(17, 327)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 69)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "    History Penjualan"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1545, 1031)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UcMenuUtama1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UcPelanggan1)
        Me.Controls.Add(Me.UcPemasok1)
        Me.Controls.Add(Me.UcKelompok1)
        Me.Controls.Add(Me.UcBarang1)
        Me.Controls.Add(Me.UcPengguna1)
        Me.Controls.Add(Me.UcGantiPass1)
        Me.Controls.Add(Me.UcLogin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnUser As System.Windows.Forms.Button
    Friend WithEvents BtnPembelian As System.Windows.Forms.Button
    Friend WithEvents BtnBarang As System.Windows.Forms.Button
    Friend WithEvents BtnSatuan As System.Windows.Forms.Button
    Friend WithEvents BtnKelompok As System.Windows.Forms.Button
    Friend WithEvents BtnPemasok As System.Windows.Forms.Button
    Friend WithEvents BtnPelanggan As System.Windows.Forms.Button
    Friend WithEvents BtnPenjualan As System.Windows.Forms.Button
    Friend WithEvents BtnLaporan As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents BtnClose As System.Windows.Forms.Button
    Private WithEvents panel3 As System.Windows.Forms.Panel
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BtnHome As System.Windows.Forms.Button
    Friend WithEvents UcMenuUtama1 As MiniMarket.UCMenuUtama
    Friend WithEvents UcPelanggan1 As MiniMarket.UCPelanggan
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LblNamaUser As System.Windows.Forms.Label
    Friend WithEvents LblKodeUser As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblJam As System.Windows.Forms.Label
    Friend WithEvents LblHari As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents UcPemasok1 As MiniMarket.UCPemasok
    Friend WithEvents UcKelompok1 As MiniMarket.UCKelompok
    Friend WithEvents UcBarang1 As MiniMarket.UCBarang
    Public WithEvents SidePanel As System.Windows.Forms.Panel
    Friend WithEvents UcPengguna1 As MiniMarket.UCPengguna
    Friend WithEvents UcGantiPass1 As MiniMarket.UCGantiPass
    Friend WithEvents UcLogin1 As MiniMarket.UCLogin
    Friend WithEvents Button1 As Button
End Class
