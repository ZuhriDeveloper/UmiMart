Imports System.Globalization
Imports Microsoft.PointOfService
Imports System.ComponentModel

Public Class FrmBayar

    Private m_Drawer As CashDrawer = Nothing
    Private listVoucher As List(Of VoucherDto)
    Private Sub hitung()
        Try

            TxtKembali.Text = "0"
            Dim bayar As Double = ConvertTextToDouble(TxtBayar.Text)
            Dim totalDiskon As Double = ConvertTextToDouble(txtTotalDiskon.Text)
            Dim totalBayar As Double = ConvertTextToDouble(TotalLbl.Text)

            Dim kembali As Double = bayar - (totalBayar - totalDiskon)

            'Fungsi ini merupakan fungsi yang dapat menghitung kolom total harga pembelian berdasarkan nilai
            'penjumlahan yang ada pada kolom grid kelima dari tabel pembelian
            Dim dblKembali As Double = CDbl(TxtBayar.Text) - CDbl(Replace(Replace(TotalLbl.Text, ",", ""), ".", ""))
            TxtKembali.Text = dblKembali.ToString("N0", CultureInfo.InvariantCulture)
            'TxtKembali.Text = Format(Val(TxtBayar.Text) - Val(Replace(TotalLbl.Text, ".", "")), "#,#")

        Catch ex As Exception
            TxtKembali.Text = "0"
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnClose_Click_1(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub SetDiscountVisibility(ByVal value As Boolean)
        chkDiskonMember.Visible = value
        'grpDiskonMember.Visible = value
    End Sub

    Private Sub FrmBayar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetCashDrawer()
        ClearVoucher()
        rbTunai.Checked = True
        BtnSimpan.Enabled = False
        If FrmPenjualan._currentMemberId = 0 Then
            SetDiscountVisibility(False)
            rbTunai.Enabled = False
            rbBca.Enabled = False
            rbMandiri.Enabled = False
        Else
            SetDiscountVisibility(True)
            rbTunai.Enabled = True
            rbBca.Enabled = True
            rbMandiri.Enabled = True
        End If
    End Sub

    Private Sub SetCashDrawer()
        '<<<step1>>>--Start
        'Use a Logical Device Name which has been set on the SetupPOS.
        Dim strLogicalName As String
        Dim deviceInfo As DeviceInfo
        Dim posExplorer As PosExplorer

        strLogicalName = "CashDrawer"

        'Create PosExplorer
        posExplorer = New PosExplorer

        m_Drawer = Nothing

        Try

            deviceInfo = posExplorer.GetDevice(DeviceType.CashDrawer, strLogicalName)

            m_Drawer = posExplorer.CreateInstance(deviceInfo)

        Catch ex As Exception
            Return
        End Try

        Try

            'Open the device
            m_Drawer.Open()

            'Get the exclusive control right for the opened device.
            'Then the device is disable from other application.
            m_Drawer.Claim(1000)

            'Enable the device.
            m_Drawer.DeviceEnabled = True

        Catch ex As PosControlException

        End Try
    End Sub

    Private Sub TxtKembali_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtBayar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBayar.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub TxtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If ConvertTextToDouble(TxtBayar.Text) < (ConvertTextToDouble(TotalLbl.Text) - ConvertTextToDouble(txtTotalDiskon.Text)) Then
                MsgBox("Pembayaran Kurang", vbInformation, "Pesan") : Exit Sub
            Else
                Call HitungAll()

                Dim a As Long
                a = Val(TxtBayar.Text)
                TxtBayar.Text = a.ToString("N0", CultureInfo.InvariantCulture)
                BtnSimpan.Enabled = True
                BtnSimpan.Focus()
            End If
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TxtBayar_TextChanged(sender As Object, e As EventArgs) Handles TxtBayar.TextChanged

    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Me.Close()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Call Koneksi()
        Dim metodeBayar As String = "TUNAI"
        If rbBca.Checked Then
            metodeBayar = "TRANSFER BCA"
        End If

        If rbMandiri.Checked Then
            metodeBayar = "TRANSFER MANDIRI"
        End If

        Dim totalNominalVoucher As Decimal = GetTotalNominalVoucher()

        DMLSql = New OleDb.OleDbCommand
        DMLSql.Connection = Database
        DMLSql.CommandType = CommandType.Text

        DMLSql.CommandText = "Insert into TblPenjualan values('" & FrmPenjualan.TxtFaktur.Text & "','" & Format(Now, "yyyy/MM/dd") & "','" &
            Val(Replace(Replace(TotalLbl.Text, ".", ""), ",", "")) & "','" & Val(Replace(Replace(TxtBayar.Text, ".", ""), ",", "")) & "','" &
           Val(Replace(Replace(TxtKembali.Text, ".", ""), ",", "")) & "','" & FrmPenjualan._currentMemberId & "','" & FrmMenuUtama.LblKodeUser.Text & "','" &
           Val(Replace(Replace(txtTotalDiskon.Text, ".", ""), ",", "")) & "','" & metodeBayar & "'," & CInt(totalNominalVoucher) & ")"
        DMLSql.ExecuteNonQuery()

        For baris As Integer = 0 To FrmPenjualan.DGV.Rows.Count - 2
            'simpan ke tabel detail
            Call Koneksi()
            DMLSql = New OleDb.OleDbCommand
            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text
            'DMLSql.CommandText = "Insert into TblPenjualan_Rinci values ('" & FrmPenjualan.TxtFaktur.Text &
            '    "','" & FrmPenjualan.DGV.Rows(baris).Cells(0).Value & "','" & FrmPenjualan.DGV.Rows(baris).Cells(2).Value &
            '    "','0','" & FrmPenjualan.DGV.Rows(baris).Cells(4).Value &
            '    "','" & FrmPenjualan.DGV.Rows(baris).Cells(5).Value & "')"
            'DMLSql.ExecuteNonQuery()

            DMLSql.CommandText = "INSERT INTO TblPenjualan_Rinci VALUES (?,?,?,?,?,?)"
            DMLSql.Parameters.AddWithValue("No_Faktur", FrmPenjualan.TxtFaktur.Text)
            DMLSql.Parameters.AddWithValue("Kode_Barang", FrmPenjualan.DGV.Rows(baris).Cells(6).Value)
            DMLSql.Parameters.AddWithValue("Hrg_Jual", ConvertTextToDecimal(FrmPenjualan.DGV.Rows(baris).Cells(2).Value))
            DMLSql.Parameters.AddWithValue("Diskon", 0)
            DMLSql.Parameters.AddWithValue("Jml_Jual", ConvertTextToDecimal(FrmPenjualan.DGV.Rows(baris).Cells(4).Value))
            DMLSql.Parameters.AddWithValue("Sub_Total", ConvertTextToDecimal(FrmPenjualan.DGV.Rows(baris).Cells(5).Value))

            DMLSql.ExecuteNonQuery()
            DMLSql.Dispose()

            ''kurangi stok barang
            'Call Koneksi()
            'Tampil.Connection = Database
            'Tampil.CommandType = CommandType.Text

            'Tampil.CommandText = "select * from TblBarang where Kode_Barang = '" & FrmPenjualan.DGV.Rows(baris).Cells(0).Value & "' "
            'Tampilkan = Tampil.ExecuteReader
            'Tampilkan.Read()
            'If Tampilkan.HasRows = True Then
            '    'Call Koneksi()
            '    Tampil2.Connection = Database
            '    Tampil2.CommandType = CommandType.Text
            '    Tampil2.CommandText = "Update TblBarang set stock= '" & Val(Tampilkan.Item(8) - FrmPenjualan.DGV.Rows(baris).Cells(5).Value) & "' where kode_barang='" & FrmPenjualan.DGV.Rows(baris).Cells(0).Value & "'"
            '    Tampil2.ExecuteNonQuery()
            'End If
        Next baris

        Dim voucherRepo As New VoucherRepository
        voucherRepo.UpdateVoucherStatus(listVoucher, FrmPenjualan.TxtFaktur.Text)

        PrintFaktur(FrmPenjualan.TxtFaktur.Text)
        'TryOpenCashDrawer()
        'CashDrawer.OpenDrawer("OneNote (Desktop)")

        FrmPenjualan.Bersih()
        Me.Close()
        'If MessageBox.Show("Cetak Struk..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
        '    Dim boconnectioninfo As New ConnectionInfo
        '    boconnectioninfo.ServerName = "10.10.10.174\SQLEXPRESS"
        '    boconnectioninfo.DatabaseName = "UMDB"
        '    boconnectioninfo.UserID = "UmiApp"
        '    boconnectioninfo.Password = "y4djk3ch"


        '    CrLapStrukJual.CrystalReportViewer1.ReportSource = "CrLapPenjualanStruk.rpt"
        '    CrLapStrukJual.CrystalReportViewer1.SelectionFormula = "{TblPenjualan.No_Faktur} ='" & FrmPenjualan.TxtFaktur.Text & "' "
        '    Dim a As TableLogOnInfos = CrLapStrukJual.CrystalReportViewer1.LogOnInfo
        '    ' Iterate through the list.
        '    For Each logInfo As TableLogOnInfo In a
        '        logInfo.ConnectionInfo = boconnectioninfo
        '    Next
        '    CrLapStrukJual.CrystalReportViewer1.RefreshReport()
        '    'CrLapStrukJual.CrystalReportViewer1.PrintReport()
        '    CrLapStrukJual.Show()
        '    CrLapStrukJual.BringToFront()
        '    Me.Close()
        '    FrmPenjualan.Bersih()

        'Else
        '    Me.Close()
        '    FrmPenjualan.Bersih()
        'End If
    End Sub


    Private Sub PrintFaktur(KodeFaktur As String)
        Dim fakturRepo As New FakturRepository
        Dim fakturDto As FakturDto = fakturRepo.GetFaktur(KodeFaktur)

        Dim NamaToko As String = "Umi Mart"
        Dim Alamat As String = "Jl. Danau Kelapa Dua Raya N Kav 5D No.3"
        Dim Kota As String = "Kelapa Dua tangerang"

        Dim Trans As String = fakturDto.NoFaktur
        Dim Tgl As String = Format(fakturDto.TglTransaksi, "yyyy-MM-dd HH:mm:ss")

        Dim arrWidth() As Integer
        Dim arrFormat() As StringFormat

        Dim Header1() As Integer
        Dim Header2() As StringFormat

        Dim Footer1() As Integer
        Dim Footer2() As StringFormat

        Dim c As New PrintingFormat

        Dim SubTotal As Double = 0


        Printer.NewPrint()
        Printer.Print(" ")

        Header1 = {250, 0} : Header2 = {c.MidCenter}

        Printer.SetFont("Courier New", 11, FontStyle.Bold)
        Printer.Print(NamaToko, Header1, Header2)

        Printer.SetFont("Courier New", 8, FontStyle.Regular)
        Printer.Print(Alamat, {250}, 0)

        Printer.SetFont("Courier New", 8, FontStyle.Regular)
        Printer.Print(Kota, {250}, 0)

        Printer.Print("-----------------------------------")
        Printer.Print("Transaksi : " & Trans)
        Printer.Print("Tgl       : " & Tgl)
        Printer.Print("Kasir     : " & fakturDto.Kasir)
        If fakturDto.PelangganId <> 0 Then
            Printer.Print("Pelanggan : " & fakturDto.Pelanggan)
        End If

        Printer.Print("-----------------------------------")

        Printer.SetFont("Courier New", 8, FontStyle.Bold)
        arrWidth = {90, 80, 75}
        arrFormat = {c.MidLeft, c.MidRight, c.MidRight}

        'nama kolom dipisah dengan ;
        Printer.Print("Item Barang#Qty#Sub Total", arrWidth, arrFormat)
        Printer.SetFont("Courier New", 8, FontStyle.Regular)
        arrWidth = {135, 32, 70}
        arrFormat = {c.MidLeft, c.MidRight, c.MidRight}

        Printer.Print("-----------------------------------")

        For Each item As FakturDetailDto In fakturDto.ListDetail
            Dim namaBarang As String = item.NamaBarang
            If namaBarang.Contains("MITRA") Then
                namaBarang = namaBarang.Replace("MITRA", "")
            End If

            If namaBarang.Contains("UMI MART") Then
                namaBarang = namaBarang.Replace("UMI MART", "")
            End If

            namaBarang = namaBarang.Trim()

            Printer.Print(Strings.Left(namaBarang, 40) & "#" & item.JmlJual & "#" &
                         (FormatNumber(item.SubTotal, 0)), arrWidth, arrFormat)
        Next

        'loop item penjualan
        'For Each xrow As DataGridViewRow In Me.DataGridView1.Rows
        '    Printer.Print(Strings.Left(xrow.Cells(0).Value, 15) & "#" & xrow.Cells(1).Value & "#" &
        '                 (FormatNumber(xrow.Cells(1).Value * xrow.Cells(2).Value, 0)), arrWidth, arrFormat)
        '    SubTotal += (xrow.Cells(1).Value * xrow.Cells(2).Value)
        'Next

        Printer.Print("-----------------------------------")
        arrWidth = {130, 110}
        arrFormat = {c.MidLeft, c.MidRight}

        Printer.Print("Total Bayar #" & FormatNumber(fakturDto.TotalBayar, 0), arrWidth, arrFormat)
        Printer.Print("Bayar #" & FormatNumber(fakturDto.Bayar, 0), arrWidth, arrFormat)
        If fakturDto.Diskon > 0 Then
            Printer.Print("Diskon # " & FormatNumber(fakturDto.Diskon, 0), arrWidth, arrFormat)
        End If

        If fakturDto.Voucher > 0 Then
            Printer.Print("Voucher # " & FormatNumber(fakturDto.Voucher, 0), arrWidth, arrFormat)
        End If

        Printer.Print("Kembalian #" & FormatNumber(fakturDto.Kembali, 0), arrWidth, arrFormat)
        Printer.Print("-----------------------------------")

        Footer1 = {250, 0} : Footer2 = {c.MidCenter}
        Printer.SetFont("Courier New", 8, FontStyle.Regular)
        Printer.Print("Terima Kasih", Header1, Header2)
        Printer.Print("Atas Kunjungan Anda", Header1, Header2)

        Printer.DoPrint()
        open_cashdrawer()
        'ReleaseCashDrawer()
    End Sub

    Private Sub chkDiskonMember_CheckedChanged(sender As Object, e As EventArgs) Handles chkDiskonMember.CheckedChanged
        Try
            If chkDiskonMember.Checked Then
                grpDiskonMember.Visible = True
                Dim memberRepo As New MemberRepository()
                Dim member As MemberDto = memberRepo.GetMemberById(FrmPenjualan._currentMemberId)
                txtDiskonFlat.Text = member.DiscountFlat.ToString("N0", CultureInfo.InvariantCulture)
                txtDiskonRate.Text = member.DiscountRate
                HitungAll()
            Else
                grpDiskonMember.Visible = False
                txtDiskonFlat.Text = 0
                txtDiskonRate.Text = 0
                txtTotalDiskon.Text = 0
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub HitungAll()
        Try
            Dim totalBayar As Decimal = ConvertTextToDecimal(TotalLbl.Text)
            Dim diskonFlat As Decimal = ConvertTextToDecimal(txtDiskonFlat.Text)
            Dim diskonRate As Double = ConvertTextToDouble(txtDiskonRate.Text)
            Dim diskonRateNominal As Decimal = IIf(diskonRate > 0, totalBayar * (diskonRate / 100), 0)
            Dim totalDiskon As Decimal = diskonFlat + diskonRateNominal
            txtTotalDiskon.Text = totalDiskon.ToString("N0", CultureInfo.InvariantCulture)

            Dim bayar As Double = ConvertTextToDouble(TxtBayar.Text)

            Dim yangHarusDibayarCustomer As Decimal = totalBayar - totalDiskon

            'Dim kembali As Double = bayar - (totalBayar - totalDiskon)
            Dim kembali As Double = 0
            Dim totalNominalVoucher As Decimal = GetTotalNominalVoucher()

            If totalNominalVoucher >= yangHarusDibayarCustomer Then
                yangHarusDibayarCustomer = 0
            Else
                yangHarusDibayarCustomer = yangHarusDibayarCustomer - totalNominalVoucher
            End If

            kembali = bayar - yangHarusDibayarCustomer

            TxtKembali.Text = kembali.ToString("N0", CultureInfo.InvariantCulture)

            If kembali >= 0 Then
                BtnSimpan.Enabled = True
            Else
                BtnSimpan.Enabled = False
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Function ConvertTextToDecimal(ByVal val As String) As Decimal
        Try
            Return CDec(Replace(Replace(val, ".", ""), ",", ""))
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Function ConvertTextToDouble(ByVal val As String) As Double
        Try
            Return CDbl(Replace(Replace(val, ".", ""), ",", ""))
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub txtDiskonFlat_TextChanged(sender As Object, e As EventArgs) Handles txtDiskonFlat.TextChanged, txtDiskonRate.TextChanged, TxtBayar.TextChanged
        HitungAll()
    End Sub

    Private Sub TryOpenCashDrawer()

        Try
            Dim cashDrawerCmd() As Byte = {27, 112, 0, 25, 250}

            ' sets up comPort as SerialPort and opens the port
            Using comPort As System.IO.Ports.SerialPort = My.Computer.Ports.OpenSerialPort("COM1")

                ' setup the com port with the required parameters. (Set these to suit)
                comPort.BaudRate = 9600
                comPort.DataBits = 8
                comPort.Parity = System.IO.Ports.Parity.None
                comPort.StopBits = System.IO.Ports.StopBits.One
                comPort.Handshake = System.IO.Ports.Handshake.RequestToSend

                ' writes the whole of the byte array containg the open drawer command codes to the port
                comPort.Write(cashDrawerCmd, 0, cashDrawerCmd.Length)

            End Using
        Catch ex As Exception

        End Try
        ' create an array to hold the command code bytes


    End Sub

    Public Sub open_cashdrawer()
        Try
            m_Drawer.OpenDrawer()
            CloseCashDrawer()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FrmBayar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        CloseCashDrawer()
    End Sub

    Private Sub CloseCashDrawer()
        Try
            If m_Drawer Is Nothing Then
                Return
            End If
            m_Drawer.Release()
            m_Drawer.DeviceEnabled = False
            m_Drawer = Nothing
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ClearVoucher()
        listVoucher = New List(Of VoucherDto)
        dgvVoucher.DataSource = Nothing
        dgvVoucher.Rows.Clear()
        dgvVoucher.Refresh()

        dgvVoucher.Columns.Add("VoucherCode", "Kode Voucher")
        dgvVoucher.Columns.Add("Nominal", "Nominal")
        dgvVoucher.Columns.Add("VoucherId", "VoucherId")


        Dim btn As New DataGridViewButtonColumn()
        dgvVoucher.Columns.Add(btn)
        btn.HeaderText = "Hapus"
        btn.Text = "Hapus"
        btn.Name = "btnHapus"
        btn.UseColumnTextForButtonValue = True

        dgvVoucher.Columns(0).DataPropertyName = "VoucherCode"
        dgvVoucher.Columns(1).DataPropertyName = "Nominal"
        dgvVoucher.Columns(2).DataPropertyName = "VoucherId"
        dgvVoucher.Columns(2).Visible = False

    End Sub
    Private Sub btnAddVoucher_Click(sender As Object, e As EventArgs) Handles btnAddVoucher.Click
        Try
            If String.IsNullOrEmpty(txtVoucherCode.Text.Trim()) Then
                MessageBox.Show("Harap input kode voucher")
                Exit Sub
            End If

            Dim errMessage As String = ""
            Dim voucherRepo As New VoucherRepository()
            Dim voucher As VoucherDto = voucherRepo.GetVoucherByCode(txtVoucherCode.Text.Trim())

            If Not IsVoucherValid(voucher, errMessage) Then
                MessageBox.Show(errMessage)
                Exit Sub
            End If

            listVoucher.Add(voucher)

            RefreshGridVoucher()

            HitungAll()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RefreshGridVoucher()
        dgvVoucher.Rows.Clear()

        For Each voucher As VoucherDto In listVoucher
            dgvVoucher.Rows.Add(voucher.VoucherCode, voucher.Nominal.ToString("N0", CultureInfo.InvariantCulture), voucher.VoucherId)
        Next
    End Sub

    Private Function IsVoucherValid(ByVal voucher As VoucherDto, ByRef errMessage As String) As Boolean
        Try

            If voucher.VoucherId = 0 Then
                errMessage = "Kode voucher tidak ditemukan"
                Return False
            End If

            If voucher.Status <> "AKTIF" Then
                errMessage = "Voucher tidak aktif / sudah terpakai"
                Return False
            End If

            If voucher.ValidFrom.Date > Now.Date Then
                errMessage = "Voucher belum aktif"
                Return False
            End If

            If Not voucher.ValidTo Is Nothing Then
                If voucher.ValidTo < Now.Date Then
                    errMessage = "Voucher tidak aktif"
                    Return False
                End If
            End If

            Dim existingVoucher As VoucherDto = listVoucher.Where(Function(x) x.VoucherCode = voucher.VoucherCode).FirstOrDefault()
            If Not existingVoucher Is Nothing Then
                errMessage = "Voucher sudah diinput"
                Return False
            End If

            Dim totalNominalVoucher As Decimal = GetTotalNominalVoucher()
            Dim totalBayar As Decimal = ConvertTextToDecimal(TotalLbl.Text)
            If totalNominalVoucher >= totalBayar Then
                errMessage = "Voucher yang diinput sudah melebihi pembayaran"
                Return False
            End If

        Catch ex As Exception
            errMessage = ex.Message
            Return False
        End Try
        Return True
    End Function

    Private Function GetTotalNominalVoucher() As Decimal
        Dim totalNominalVoucher As Decimal = 0
        For Each voucher As VoucherDto In listVoucher
            totalNominalVoucher += voucher.Nominal
        Next
        Return totalNominalVoucher
    End Function

    Private Sub dgvVoucher_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVoucher.CellClick
        If e.RowIndex = dgvVoucher.NewRowIndex Or e.RowIndex < 0 Then
            Exit Sub
        End If

        If e.ColumnIndex = dgvVoucher.Columns("btnHapus").Index Then
            Dim row As DataGridViewRow = dgvVoucher.Rows(e.RowIndex)
            Dim voucherId As Integer = CInt(row.Cells(2).Value)

            Dim voucher As VoucherDto = listVoucher.Where(Function(x) x.VoucherId = voucherId).FirstOrDefault()
            listVoucher.Remove(voucher)
            RefreshGridVoucher()
            HitungAll()

        End If
    End Sub
End Class