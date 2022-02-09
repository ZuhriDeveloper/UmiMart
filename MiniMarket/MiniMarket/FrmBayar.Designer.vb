<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBayar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBayar))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TerbilangLbl = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TotalLbl = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtBayar = New System.Windows.Forms.TextBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.TxtKembali = New System.Windows.Forms.Label()
        Me.grpDiskonMember = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalDiskon = New System.Windows.Forms.TextBox()
        Me.txtDiskonRate = New System.Windows.Forms.TextBox()
        Me.txtDiskonFlat = New System.Windows.Forms.TextBox()
        Me.chkDiskonMember = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rbTunai = New System.Windows.Forms.RadioButton()
        Me.rbBca = New System.Windows.Forms.RadioButton()
        Me.rbMandiri = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtVoucherCode = New System.Windows.Forms.TextBox()
        Me.btnAddVoucher = New System.Windows.Forms.Button()
        Me.dgvVoucher = New System.Windows.Forms.DataGridView()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.grpDiskonMember.SuspendLayout()
        CType(Me.dgvVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 1060)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1946, 46)
        Me.Panel5.TabIndex = 165
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label15.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label15.Location = New System.Drawing.Point(216, 8)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(177, 29)
        Me.Label15.TabIndex = 166
        Me.Label15.Text = "[ Enter ] - Bayar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Aquamarine
        Me.Label14.Location = New System.Drawing.Point(16, 8)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(153, 29)
        Me.Label14.TabIndex = 165
        Me.Label14.Text = "[ Esc ] - Batal"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(1830, 154)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 43)
        Me.Label11.TabIndex = 1008
        Me.Label11.Text = "Rupiah"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TerbilangLbl
        '
        Me.TerbilangLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TerbilangLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TerbilangLbl.ForeColor = System.Drawing.Color.White
        Me.TerbilangLbl.Location = New System.Drawing.Point(746, 154)
        Me.TerbilangLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TerbilangLbl.Name = "TerbilangLbl"
        Me.TerbilangLbl.Size = New System.Drawing.Size(1089, 43)
        Me.TerbilangLbl.TabIndex = 1007
        Me.TerbilangLbl.Text = "Nol*"
        Me.TerbilangLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Aqua
        Me.Label10.Location = New System.Drawing.Point(1032, 14)
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
        Me.TotalLbl.Location = New System.Drawing.Point(760, 14)
        Me.TotalLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalLbl.Name = "TotalLbl"
        Me.TotalLbl.Size = New System.Drawing.Size(1198, 108)
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
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TerbilangLbl)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TotalLbl)
        Me.Panel2.Controls.Add(Me.BtnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1946, 197)
        Me.Panel2.TabIndex = 164
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(74, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(656, 108)
        Me.Label1.TabIndex = 1007
        Me.Label1.Text = "Total Bayar"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DimGray
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Aqua
        Me.Label5.Location = New System.Drawing.Point(280, 451)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(566, 108)
        Me.Label5.TabIndex = 1011
        Me.Label5.Text = "Bayar :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DimGray
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Aqua
        Me.Label6.Location = New System.Drawing.Point(280, 841)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(566, 108)
        Me.Label6.TabIndex = 1012
        Me.Label6.Text = "Kembali :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtBayar
        '
        Me.TxtBayar.BackColor = System.Drawing.Color.DimGray
        Me.TxtBayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold)
        Me.TxtBayar.ForeColor = System.Drawing.Color.Aquamarine
        Me.TxtBayar.Location = New System.Drawing.Point(921, 451)
        Me.TxtBayar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBayar.Name = "TxtBayar"
        Me.TxtBayar.Size = New System.Drawing.Size(719, 116)
        Me.TxtBayar.TabIndex = 1
        Me.TxtBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSimpan.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(921, 969)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(183, 60)
        Me.BtnSimpan.TabIndex = 1013
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
        Me.BtnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatal.ForeColor = System.Drawing.Color.White
        Me.BtnBatal.Image = CType(resources.GetObject("BtnBatal.Image"), System.Drawing.Image)
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(1108, 969)
        Me.BtnBatal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(190, 60)
        Me.BtnBatal.TabIndex = 1014
        Me.BtnBatal.Text = "       Batal"
        Me.BtnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'TxtKembali
        '
        Me.TxtKembali.BackColor = System.Drawing.Color.DimGray
        Me.TxtKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKembali.ForeColor = System.Drawing.Color.Aqua
        Me.TxtKembali.Location = New System.Drawing.Point(920, 841)
        Me.TxtKembali.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtKembali.Name = "TxtKembali"
        Me.TxtKembali.Size = New System.Drawing.Size(748, 108)
        Me.TxtKembali.TabIndex = 1015
        Me.TxtKembali.Text = "0"
        Me.TxtKembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpDiskonMember
        '
        Me.grpDiskonMember.Controls.Add(Me.Label7)
        Me.grpDiskonMember.Controls.Add(Me.Label4)
        Me.grpDiskonMember.Controls.Add(Me.Label3)
        Me.grpDiskonMember.Controls.Add(Me.Label2)
        Me.grpDiskonMember.Controls.Add(Me.txtTotalDiskon)
        Me.grpDiskonMember.Controls.Add(Me.txtDiskonRate)
        Me.grpDiskonMember.Controls.Add(Me.txtDiskonFlat)
        Me.grpDiskonMember.Location = New System.Drawing.Point(921, 575)
        Me.grpDiskonMember.Name = "grpDiskonMember"
        Me.grpDiskonMember.Size = New System.Drawing.Size(719, 229)
        Me.grpDiskonMember.TabIndex = 1018
        Me.grpDiskonMember.TabStop = False
        Me.grpDiskonMember.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DimGray
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Aqua
        Me.Label7.Location = New System.Drawing.Point(7, 151)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(338, 60)
        Me.Label7.TabIndex = 1015
        Me.Label7.Text = "Total Diskon :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DimGray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Aqua
        Me.Label4.Location = New System.Drawing.Point(656, 83)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 60)
        Me.Label4.TabIndex = 1014
        Me.Label4.Text = "%"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Aqua
        Me.Label3.Location = New System.Drawing.Point(7, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(301, 60)
        Me.Label3.TabIndex = 1013
        Me.Label3.Text = "Diskon % :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Aqua
        Me.Label2.Location = New System.Drawing.Point(7, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(317, 60)
        Me.Label2.TabIndex = 1012
        Me.Label2.Text = "Diskon Flat :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalDiskon
        '
        Me.txtTotalDiskon.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDiskon.ForeColor = System.Drawing.Color.Aquamarine
        Me.txtTotalDiskon.Location = New System.Drawing.Point(373, 151)
        Me.txtTotalDiskon.Name = "txtTotalDiskon"
        Me.txtTotalDiskon.Size = New System.Drawing.Size(340, 62)
        Me.txtTotalDiskon.TabIndex = 2
        '
        'txtDiskonRate
        '
        Me.txtDiskonRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiskonRate.ForeColor = System.Drawing.Color.Aquamarine
        Me.txtDiskonRate.Location = New System.Drawing.Point(373, 83)
        Me.txtDiskonRate.Name = "txtDiskonRate"
        Me.txtDiskonRate.Size = New System.Drawing.Size(276, 62)
        Me.txtDiskonRate.TabIndex = 1
        '
        'txtDiskonFlat
        '
        Me.txtDiskonFlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiskonFlat.ForeColor = System.Drawing.Color.Aquamarine
        Me.txtDiskonFlat.Location = New System.Drawing.Point(373, 16)
        Me.txtDiskonFlat.Name = "txtDiskonFlat"
        Me.txtDiskonFlat.Size = New System.Drawing.Size(340, 62)
        Me.txtDiskonFlat.TabIndex = 0
        '
        'chkDiskonMember
        '
        Me.chkDiskonMember.AutoSize = True
        Me.chkDiskonMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiskonMember.ForeColor = System.Drawing.Color.Aquamarine
        Me.chkDiskonMember.Location = New System.Drawing.Point(298, 637)
        Me.chkDiskonMember.Name = "chkDiskonMember"
        Me.chkDiskonMember.Size = New System.Drawing.Size(400, 59)
        Me.chkDiskonMember.TabIndex = 1019
        Me.chkDiskonMember.Text = "Diskon Member"
        Me.chkDiskonMember.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DimGray
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Aqua
        Me.Label8.Location = New System.Drawing.Point(94, 216)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(387, 108)
        Me.Label8.TabIndex = 1020
        Me.Label8.Text = "Metode Bayar :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rbTunai
        '
        Me.rbTunai.AutoSize = True
        Me.rbTunai.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTunai.ForeColor = System.Drawing.Color.Aqua
        Me.rbTunai.Location = New System.Drawing.Point(505, 236)
        Me.rbTunai.Name = "rbTunai"
        Me.rbTunai.Size = New System.Drawing.Size(128, 41)
        Me.rbTunai.TabIndex = 1021
        Me.rbTunai.TabStop = True
        Me.rbTunai.Text = "Tunai"
        Me.rbTunai.UseVisualStyleBackColor = True
        '
        'rbBca
        '
        Me.rbBca.AutoSize = True
        Me.rbBca.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBca.ForeColor = System.Drawing.Color.Aqua
        Me.rbBca.Location = New System.Drawing.Point(505, 283)
        Me.rbBca.Name = "rbBca"
        Me.rbBca.Size = New System.Drawing.Size(249, 41)
        Me.rbBca.TabIndex = 1022
        Me.rbBca.TabStop = True
        Me.rbBca.Text = "Transfer BCA"
        Me.rbBca.UseVisualStyleBackColor = True
        '
        'rbMandiri
        '
        Me.rbMandiri.AutoSize = True
        Me.rbMandiri.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMandiri.ForeColor = System.Drawing.Color.Aqua
        Me.rbMandiri.Location = New System.Drawing.Point(505, 324)
        Me.rbMandiri.Name = "rbMandiri"
        Me.rbMandiri.Size = New System.Drawing.Size(292, 41)
        Me.rbMandiri.TabIndex = 1023
        Me.rbMandiri.TabStop = True
        Me.rbMandiri.Text = "Transfer Mandiri"
        Me.rbMandiri.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.DimGray
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Aqua
        Me.Label9.Location = New System.Drawing.Point(929, 197)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(246, 108)
        Me.Label9.TabIndex = 1024
        Me.Label9.Text = "Voucher :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVoucherCode
        '
        Me.txtVoucherCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucherCode.ForeColor = System.Drawing.Color.Aquamarine
        Me.txtVoucherCode.Location = New System.Drawing.Point(1182, 220)
        Me.txtVoucherCode.Name = "txtVoucherCode"
        Me.txtVoucherCode.Size = New System.Drawing.Size(259, 62)
        Me.txtVoucherCode.TabIndex = 1025
        '
        'btnAddVoucher
        '
        Me.btnAddVoucher.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddVoucher.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral
        Me.btnAddVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddVoucher.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddVoucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddVoucher.Location = New System.Drawing.Point(1457, 222)
        Me.btnAddVoucher.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddVoucher.Name = "btnAddVoucher"
        Me.btnAddVoucher.Size = New System.Drawing.Size(94, 60)
        Me.btnAddVoucher.TabIndex = 1026
        Me.btnAddVoucher.Text = "Add"
        Me.btnAddVoucher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddVoucher.UseVisualStyleBackColor = False
        '
        'dgvVoucher
        '
        Me.dgvVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVoucher.Location = New System.Drawing.Point(939, 293)
        Me.dgvVoucher.Name = "dgvVoucher"
        Me.dgvVoucher.RowHeadersWidth = 62
        Me.dgvVoucher.RowTemplate.Height = 28
        Me.dgvVoucher.Size = New System.Drawing.Size(612, 150)
        Me.dgvVoucher.TabIndex = 1027
        '
        'FrmBayar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1946, 1106)
        Me.Controls.Add(Me.dgvVoucher)
        Me.Controls.Add(Me.btnAddVoucher)
        Me.Controls.Add(Me.txtVoucherCode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rbMandiri)
        Me.Controls.Add(Me.rbBca)
        Me.Controls.Add(Me.rbTunai)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.chkDiskonMember)
        Me.Controls.Add(Me.grpDiskonMember)
        Me.Controls.Add(Me.TxtKembali)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.TxtBayar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmBayar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBayar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.grpDiskonMember.ResumeLayout(False)
        Me.grpDiskonMember.PerformLayout()
        CType(Me.dgvVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TerbilangLbl As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TotalLbl As System.Windows.Forms.Label
    Private WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtBayar As System.Windows.Forms.TextBox
    Private WithEvents BtnSimpan As System.Windows.Forms.Button
    Private WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents TxtKembali As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents grpDiskonMember As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotalDiskon As TextBox
    Friend WithEvents txtDiskonRate As TextBox
    Friend WithEvents txtDiskonFlat As TextBox
    Friend WithEvents chkDiskonMember As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents rbTunai As RadioButton
    Friend WithEvents rbBca As RadioButton
    Friend WithEvents rbMandiri As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents txtVoucherCode As TextBox
    Private WithEvents btnAddVoucher As Button
    Friend WithEvents dgvVoucher As DataGridView
End Class
