<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistoryPenjualan
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.dtpTransaksi = New System.Windows.Forms.DateTimePicker()
        Me.txtFaktur = New System.Windows.Forms.TextBox()
        Me.rbTanggalTransaksi = New System.Windows.Forms.RadioButton()
        Me.rbNomorFaktur = New System.Windows.Forms.RadioButton()
        Me.dgvResult = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCari)
        Me.GroupBox1.Controls.Add(Me.dtpTransaksi)
        Me.GroupBox1.Controls.Add(Me.txtFaktur)
        Me.GroupBox1.Controls.Add(Me.rbTanggalTransaksi)
        Me.GroupBox1.Controls.Add(Me.rbNomorFaktur)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 203)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pencarian"
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(259, 140)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(150, 41)
        Me.btnCari.TabIndex = 4
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'dtpTransaksi
        '
        Me.dtpTransaksi.Location = New System.Drawing.Point(259, 88)
        Me.dtpTransaksi.Name = "dtpTransaksi"
        Me.dtpTransaksi.Size = New System.Drawing.Size(299, 35)
        Me.dtpTransaksi.TabIndex = 3
        '
        'txtFaktur
        '
        Me.txtFaktur.Location = New System.Drawing.Point(259, 47)
        Me.txtFaktur.Name = "txtFaktur"
        Me.txtFaktur.Size = New System.Drawing.Size(299, 35)
        Me.txtFaktur.TabIndex = 2
        '
        'rbTanggalTransaksi
        '
        Me.rbTanggalTransaksi.AutoSize = True
        Me.rbTanggalTransaksi.Location = New System.Drawing.Point(27, 88)
        Me.rbTanggalTransaksi.Name = "rbTanggalTransaksi"
        Me.rbTanggalTransaksi.Size = New System.Drawing.Size(210, 33)
        Me.rbTanggalTransaksi.TabIndex = 1
        Me.rbTanggalTransaksi.TabStop = True
        Me.rbTanggalTransaksi.Text = "Tanggal Transaksi"
        Me.rbTanggalTransaksi.UseVisualStyleBackColor = True
        '
        'rbNomorFaktur
        '
        Me.rbNomorFaktur.AutoSize = True
        Me.rbNomorFaktur.Location = New System.Drawing.Point(27, 49)
        Me.rbNomorFaktur.Name = "rbNomorFaktur"
        Me.rbNomorFaktur.Size = New System.Drawing.Size(158, 33)
        Me.rbNomorFaktur.TabIndex = 0
        Me.rbNomorFaktur.TabStop = True
        Me.rbNomorFaktur.Text = "Nomor Struk"
        Me.rbNomorFaktur.UseVisualStyleBackColor = True
        '
        'dgvResult
        '
        Me.dgvResult.AllowUserToAddRows = False
        Me.dgvResult.AllowUserToDeleteRows = False
        Me.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResult.Location = New System.Drawing.Point(23, 248)
        Me.dgvResult.Name = "dgvResult"
        Me.dgvResult.ReadOnly = True
        Me.dgvResult.RowHeadersWidth = 62
        Me.dgvResult.RowTemplate.Height = 28
        Me.dgvResult.Size = New System.Drawing.Size(1246, 265)
        Me.dgvResult.TabIndex = 1
        '
        'FrmHistoryPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1281, 610)
        Me.Controls.Add(Me.dgvResult)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmHistoryPenjualan"
        Me.Text = "History Penjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCari As Button
    Friend WithEvents dtpTransaksi As DateTimePicker
    Friend WithEvents txtFaktur As TextBox
    Friend WithEvents rbTanggalTransaksi As RadioButton
    Friend WithEvents rbNomorFaktur As RadioButton
    Friend WithEvents dgvResult As DataGridView
End Class
