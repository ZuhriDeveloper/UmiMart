Imports System.Data.OleDb
Imports System.Globalization
Imports Microsoft.PointOfService

Public Class FrmPenjualan
    Public Shared _currentMemberId As Integer = 0
    Public Shared _currentProductId As Integer = 0
    Private m_Drawer As CashDrawer = Nothing
    Sub SubTotal()
        Dim Diskon As Long
        'Dim harga As Decimal = TxtHarga.Text.ToDecWithoutCommaAndDot()
        Dim harga As Decimal = TxtHarga.Text.ToDecWithoutCommaAndDot()
        Diskon = 0
        Dim subtotal As Decimal = 0
        subtotal = harga * Val(TxtJml.Text)
        TxtSubTtl.Text = subtotal.ToString("N0", CultureInfo.CurrentCulture)
    End Sub

    'Nomor Faktur Ototmatis
    Sub FakturOtomatis()
        Call Koneksi()
        Tampil.Connection = Database
        Tampil.CommandType = CommandType.Text
        Tampil.CommandText = "Select * from TblPenjualan where No_Faktur in (select max(No_Faktur) from TblPenjualan) order by No_Faktur desc"
        Tampilkan = Tampil.ExecuteReader
        Tampilkan.Read()
        Dim urutan As String
        Dim hitung As Long

        If Not Tampilkan.HasRows Then
            urutan = Format(Now, "yyMMdd") + "0001"
        Else
            If Microsoft.VisualBasic.Left(Tampilkan.GetString(0), 6) <> Format(Now, "yyMMdd") Then
                urutan = Format(Now, "yyMMdd") + "0001"
            Else
                hitung = Tampilkan.GetString(0) + 1
                urutan = Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("0000" & hitung, 4)
            End If
        End If
        TxtFaktur.Text = urutan
    End Sub

    'Fungsi untuk membuat kolom pada DataGridView
    Sub BuatKolomBaru()
        DGV.Columns.Add("Kode", "Kode Barang")
        DGV.Columns.Add("Nama", "Nama Barang")
        DGV.Columns.Add("Harga", "Harga")
        'DGV.Columns.Add("Diskon Rp", "Diskon Rp")
        DGV.Columns.Add("Satuan", "Satuan")
        DGV.Columns.Add("Jumlah", "Jumlah")
        DGV.Columns.Add("Total", "SubTotal")
        DGV.Columns.Add("ProductId", "ProductId")

        Dim btn As New DataGridViewButtonColumn()
        DGV.Columns.Add(btn)
        btn.HeaderText = "Hapus"
        btn.Text = "Hapus"
        btn.Name = "btnHapus"
        btn.UseColumnTextForButtonValue = True

        Call AturLebarKolom()
    End Sub

    'Mengatur Lebar kolom grid
    Sub AturLebarKolom()
        DGV.Columns(0).Width = 180
        DGV.Columns(1).Width = 300
        DGV.Columns(2).Width = 150
        DGV.Columns(3).Width = 150
        DGV.Columns(4).Width = 150
        DGV.Columns(5).Width = 150
        'DGV.Columns(6).Width = 150
        DGV.Columns(6).Visible = False

        'Atur Aligmn
        DGV.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'DGV.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'kunci kolom grid
        DGV.Columns(1).ReadOnly = True
        DGV.Columns(2).ReadOnly = True
        DGV.Columns(3).ReadOnly = True
        DGV.Columns(4).ReadOnly = True

        'DGV.Columns(6).ReadOnly = True
    End Sub

    Sub Bersih()
        TotalLbl.Text = "0"
        TerbilangLbl.Text = "Nol"
        TxtKodeBarcode.Text = ""
        TxtKodeBrg.Text = ""
        TxtNmBrg.Text = ""
        TxtSatuan.Text = ""
        TxtHarga.Text = ""
        TxtJml.Text = ""
        'TxtDiskon.Text = ""
        TxtSubTtl.Text = ""

        _currentProductId = 0
        _currentMemberId = 0
        LblKdPel.Text = "0001"
        LblNmPel.Text = "Umum"
        LblHari.Text = Format(Now, "dddd, dd-MMMM-yyyy")

        DGV.Columns.Clear()
        Call FakturOtomatis()
        Call BuatKolomBaru()
        TxtKodeBarcode.Focus()
    End Sub

    Sub Bersih2()
        TxtKodeBarcode.Text = ""
        TxtKodeBrg.Text = ""
        TxtNmBrg.Text = ""
        TxtSatuan.Text = ""
        TxtHarga.Text = ""
        TxtJml.Text = ""
        'TxtDiskon.Text = ""
        TxtSubTtl.Text = ""
        TxtKodeBarcode.Focus()
    End Sub

    Private Sub hitung()
        Try

            TotalLbl.Text = "0"
            Dim dblTotal As Double = 0.0
            'Fungsi ini merupakan fungsi yang dapat menghitung kolom total harga pembelian berdasarkan nilai
            'penjumlahan yang ada pada kolom grid kelima dari tabel pembelian
            Dim i As Integer
            i = DGV.CurrentRow.Index
            For i = 0 To DGV.Rows.Count - 1
                dblTotal = CDbl(TotalLbl.Text) + CDbl(DGV.Item(5, i).Value)
                TotalLbl.Text = dblTotal 'Format(Val(Replace(TotalLbl.Text, ".", "")) + Val(DGV.Item(5, i).Value), "#,#")
            Next

            TerbilangLbl.Text = TerbilangIndo.TerbilangIndonesia(dblTotal.ToString()) & "*"
            TotalLbl.Text = dblTotal.ToString("N0", CultureInfo.InvariantCulture)
        Catch ex As Exception
            TotalLbl.Text = "0"
        End Try
    End Sub

    Private Sub FrmPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Bersih()
    End Sub

    Private Sub SetCashDrawer()
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

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        FrmMenuUtama.SidePanel.Height = FrmMenuUtama.BtnHome.Height
        FrmMenuUtama.SidePanel.Top = FrmMenuUtama.BtnHome.Top
        FrmMenuUtama.UcMenuUtama1.BringToFront()
        Me.Close()
    End Sub

    Private Sub TxtKodeBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtKodeBarcode.KeyDown
        Select Case e.KeyCode
            'Jika tombol F1 ditekan, maka cursor fokus ke text bayar
            Case Keys.F1
                If Val(Replace(TotalLbl.Text, ".", "")) = 0 Then
                    MsgBox("Transaksi Tidak Boleh Kosong", vbInformation, "Pesan") : Exit Sub
                End If
                FrmBayar.TotalLbl.Text = TotalLbl.Text
                FrmBayar.TerbilangLbl.Text = TerbilangLbl.Text
                FrmBayar.Show()
                FrmBayar.TxtBayar.Show()
            Case Keys.F2
                FrmDataBarang.ShowDialog()
                'Jika tombol F2 ditekan, maka tampil form data barang
            Case Keys.F3
                FrmDataPelanggan.ShowDialog()
            Case Keys.Escape
                DGV.Columns.Clear()
                Call Bersih()
        End Select
    End Sub

    Private Sub TxtKodeBarcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKodeBarcode.KeyPress
        If e.KeyChar = Chr(13) Then
            If TxtKodeBarcode.Text = "" Then FrmDataBarang.Show() : FrmDataBarang.TxtCari.Focus() : Exit Sub

            Call Koneksi()

            Tampil.Connection = Database
            Tampil.CommandType = CommandType.Text

            Tampil.CommandText = "select ProductId,Barcode,Name,[HargaJual] = CAST(SellPrice AS INT) from Products where Barcode = '" & TxtKodeBarcode.Text & "' AND IsActive=1 "
            Tampilkan = Tampil.ExecuteReader
            If Tampilkan.HasRows = True Then
                Tampilkan.Read()
                _currentProductId = Tampilkan("ProductId")
                TxtKodeBrg.Text = Tampilkan("Barcode")
                TxtKodeBarcode.Text = Tampilkan("Barcode")
                TxtNmBrg.Text = IIf(Tampilkan("Name").ToString().Length > 20, Strings.Left(Tampilkan("Name").ToString(), 20), Tampilkan("Name").ToString())
                TxtSatuan.Text = "pcs"
                TxtHarga.Text = CInt(Tampilkan("HargaJual"))
                TxtJml.Text = "1"
                TxtJml.Focus()
            Else
                MsgBox("Kode Barcode Tidak Ada", MsgBoxStyle.Information)
                _currentProductId = 0
                TxtKodeBarcode.Text = ""
                TxtKodeBarcode.Focus()
            End If
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub TxtJml_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtJml.KeyDown
        Select Case e.KeyCode
            'Jika tombol F1 ditekan, maka cursor fokus ke text bayar
            Case Keys.F1
                If Val(Replace(TotalLbl.Text, ".", "")) = 0 Then
                    MsgBox("Transaksi Tidak Boleh Kosong", vbInformation, "Pesan") : Exit Sub
                End If
                FrmBayar.TotalLbl.Text = TotalLbl.Text
                FrmBayar.TerbilangLbl.Text = TerbilangLbl.Text
                FrmBayar.Show()
                FrmBayar.TxtBayar.Show()
            Case Keys.F2
                FrmDataBarang.ShowDialog()
                'Jika tombol F2 ditekan, maka tampil form data barang
            Case Keys.F3
                FrmDataPelanggan.ShowDialog()
            Case Keys.Escape
                Call Bersih2()
        End Select
    End Sub

    Private Sub TxtJml_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtJml.KeyPress
        If e.KeyChar = Chr(13) Then
            If TxtJml.Text = "0" Or TxtJml.Text = "" Then
                MsgBox("Jumlah tidak boleh kosong")
                TxtJml.Text = ""
                TxtJml.Focus()
            Else
                Dim JmlDiskon As Long
                JmlDiskon = 0

                Call SubTotal()

                AddItemToGrid()


                Call hitung()
                Call Bersih2()
            End If
        End If
        'untuk input hanya angka saja
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub AddItemToGrid()
        For Each row As DataGridViewRow In DGV.Rows
            If row.Cells("ProductId").Value = _currentProductId Then
                row.Cells("Jumlah").Value = CInt(row.Cells("Jumlah").Value) + CInt(TxtJml.Text)
                row.Cells("Total").Value = (CInt(row.Cells("Total").Value) + CInt(TxtSubTtl.Text)).ToString("N0", CultureInfo.CurrentCulture)
                Exit Sub
            End If
        Next

        DGV.Rows.Add(TxtKodeBrg.Text, TxtNmBrg.Text, TxtHarga.Text, TxtSatuan.Text, TxtJml.Text, TxtSubTtl.Text, _currentProductId)
    End Sub

    Private Sub TxtJml_TextChanged(sender As Object, e As EventArgs) Handles TxtJml.TextChanged
        Call SubTotal()
    End Sub

    Private Sub LblKdPel_Click(sender As Object, e As EventArgs) Handles LblKdPel.Click

    End Sub

    Private Sub LblNmPel_Click(sender As Object, e As EventArgs) Handles LblNmPel.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblJam.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub TxtFaktur_Click(sender As Object, e As EventArgs) Handles TxtFaktur.Click

    End Sub

    Private Sub FrmPenjualan_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F2
                    FrmDataBarang.ShowDialog()
                'Jika tombol F2 ditekan, maka tampil form data barang
                Case Keys.F3
                    FrmDataPelanggan.ShowDialog()
                Case Keys.Escape
                    Call Bersih2()
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmPenjualan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Try
            'MessageBox.Show(e.KeyChar.ToString())
            'Select Case e.KeyChar
            '    Case Keys.F2
            '        FrmDataBarang.ShowDialog()
            '    'Jika tombol F2 ditekan, maka tampil form data barang
            '    Case Keys.F3
            '        FrmDataPelanggan.ShowDialog()
            '    Case Keys.Escape
            '        Call Bersih2()
            'End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        If e.RowIndex = DGV.NewRowIndex Or e.RowIndex < 0 Then
            Exit Sub
        End If

        If e.ColumnIndex = DGV.Columns("btnHapus").Index Then
            DGV.Rows.RemoveAt(e.RowIndex)
            Call hitung()
            Call Bersih2()
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim inputValue As String = ""
            inputValue = InputBox("Masukkan password laci !", "Konfirmasi")

            If inputValue <> "*" Then
                MessageBox.Show("Password salah")
            Else
                open_cashdrawer()
            End If

            '    Dim dr As DialogResult = MessageBox.Show("Apakah ingin membuka laci?.", "Konfirmasi", MessageBoxButtons.YesNoCancel,
            'MessageBoxIcon.Information)

            '    If dr = DialogResult.Yes Then

            '    End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub open_cashdrawer()
        Try
            SetCashDrawer()
            'Open the drawer by using the "OpenDrawer" method.
            m_Drawer.OpenDrawer()

            ' Wait during opend drawer.
            Do
                System.Threading.Thread.Sleep(100)

            Loop Until m_Drawer.DrawerOpened = True

            'When the drawer is not closed in ten seconds after opening, beep until it is closed.
            'If that method is executed, the value is not returned until the drawer is closed.
            m_Drawer.WaitForDrawerClose(10000, 2000, 100, 1000)



            System.Windows.Forms.Cursor.Current = Cursors.Default
            CloseCashDrawer()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CloseCashDrawer()
        m_Drawer.Release()
        m_Drawer.DeviceEnabled = False
        m_Drawer = Nothing
    End Sub
End Class