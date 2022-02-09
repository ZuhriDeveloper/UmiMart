Public Class FrmHistoryPenjualan
    Private Sub FrmHistoryPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub

    Private Sub LoadForm()
        rbNomorFaktur.Checked = True
        txtFaktur.Enabled = True
        rbTanggalTransaksi.Checked = False
        dtpTransaksi.Enabled = False
        txtFaktur.Text = ""
        dtpTransaksi.Value = DateTime.Now
        txtFaktur.Select()
        CreateColumnDgv()
    End Sub

    Private Sub CreateColumnDgv()
        dgvResult.Columns.Add("KodeFaktur", "Kode Faktur")
        dgvResult.Columns(0).Width = 100
        dgvResult.Columns.Add("TglTransaksi", "Tanggal Transaksi")
        dgvResult.Columns(1).Width = 100
        dgvResult.Columns(1).DefaultCellStyle.Format = "dd-MM-yyyy"
        dgvResult.Columns.Add("NamaPelanggan", "Nama Pelanggan")
        dgvResult.Columns(2).Width = 150
        dgvResult.Columns.Add("NamaKasir", "Nama Kasir")
        dgvResult.Columns(3).Width = 150
        dgvResult.Columns.Add("TotalBayar", "Total Bayar")
        dgvResult.Columns(4).Width = 150
        dgvResult.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight



        Dim btn As New DataGridViewButtonColumn()
        dgvResult.Columns.Add(btn)
        btn.HeaderText = "Cetak"
        btn.Text = "Cetak"
        btn.Name = "btnCetak"
        btn.UseColumnTextForButtonValue = True

    End Sub

    Private Sub rbNomorFaktur_CheckedChanged(sender As Object, e As EventArgs) Handles rbNomorFaktur.CheckedChanged
        If rbNomorFaktur.Checked Then
            txtFaktur.Text = ""
            txtFaktur.Enabled = True
            dtpTransaksi.Enabled = False
            txtFaktur.Select()
        End If
    End Sub

    Private Sub rbTanggalTransaksi_CheckedChanged(sender As Object, e As EventArgs) Handles rbTanggalTransaksi.CheckedChanged
        If rbTanggalTransaksi.Checked Then
            dtpTransaksi.Value = DateTime.Now
            dtpTransaksi.Enabled = True
            txtFaktur.Enabled = False
            dtpTransaksi.Select()
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Try

            dgvResult.Rows.Clear()
            Dim listItem As List(Of FakturDto) = GetListItem()
            If listItem.Count > 0 Then
                FillDataGrid(listItem)
            Else
                MsgBox("Transaksi tidak ditemukan")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FillDataGrid(listItem As List(Of FakturDto))
        For Each item As FakturDto In listItem
            dgvResult.Rows.Add(item.NoFaktur, item.TglTransaksi, IIf(item.Pelanggan = "", "UMUM", item.Pelanggan), item.Kasir, item.TotalBayar.ToString("N0"))
        Next
    End Sub

    Private Sub dgvResult_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResult.CellClick
        If e.RowIndex = dgvResult.NewRowIndex Or e.RowIndex < 0 Then
            Exit Sub
        End If

        If e.ColumnIndex = dgvResult.Columns("btnCetak").Index Then
            Dim noFaktur As String = dgvResult.Rows(e.RowIndex).Cells(0).Value.ToString()
            If MessageBox.Show("Anda yakin ingin mencetak ulang struk nomor " + noFaktur + " ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                PrintFaktur(noFaktur)
            End If
        End If
    End Sub

    Private Function GetListItem() As List(Of FakturDto)
        Dim fakturRepo As New FakturRepository()
        Dim result As New List(Of FakturDto)
        If rbNomorFaktur.Checked Then
            If txtFaktur.Text.Trim.Length = 0 Then
                MsgBox("Harap input nomor faktur !")
            End If
            result = fakturRepo.GetListFakturByKodeFaktur(txtFaktur.Text)
        Else
            result = fakturRepo.GetListFakturByTanggal(dtpTransaksi.Value)
        End If

        Return result
    End Function

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
    End Sub
End Class