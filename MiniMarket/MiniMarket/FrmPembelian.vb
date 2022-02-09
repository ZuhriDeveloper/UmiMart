Imports System.Data.OleDb
Public Class FrmPembelian

    'Nomor Faktur Ototmatis
    Sub FakturOtomatis()
        Call Koneksi()
        Tampil.Connection = Database
        Tampil.CommandType = CommandType.Text
        Tampil.CommandText = "Select * from TblPembelian where No_Transaksi in (select max(No_Transaksi) from TblPembelian) order by No_Transaksi desc"
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

    'Mengatur Lebar kolom grid
    Sub AturLebarKolom()
        DGV.Columns(0).Width = 200
        DGV.Columns(1).Width = 400
        DGV.Columns(2).Width = 150
        DGV.Columns(3).Width = 150
        DGV.Columns(4).Width = 150
        DGV.Columns(5).Width = 150

        'Atur Aligmn
        DGV.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DGV.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'kunci kolom grid
        DGV.Columns(0).ReadOnly = True
        DGV.Columns(1).ReadOnly = True
        DGV.Columns(2).ReadOnly = True
        DGV.Columns(3).ReadOnly = True
        DGV.Columns(4).ReadOnly = True
        DGV.Columns(5).ReadOnly = True
    End Sub

    'Fungsi untuk membuat kolom pada DataGridView
    Sub BuatKolomBaru()
        DGV.Columns.Add("Kode", "Kode Barang")
        DGV.Columns.Add("Nama", "Nama Barang")
        DGV.Columns.Add("Satuan", "Satuan")
        DGV.Columns.Add("Harga Beli", "Harga Beli")
        DGV.Columns.Add("Jumlah", "Jumlah")
        DGV.Columns.Add("Total", "SubTotal")
        Call AturLebarKolom()
    End Sub

    Sub SubTotal()
        Dim SubTTL As Long
        SubTTL = Val(TxtHarga.Text) * Val(TxtJml.Text)
        TxtSubTtl.Text = SubTTL
    End Sub

    Private Sub hitung()
        Try

            TotalLbl.Text = "0"

            'Fungsi ini merupakan fungsi yang dapat menghitung kolom total harga pembelian berdasarkan nilai
            'penjumlahan yang ada pada kolom grid kelima dari tabel pembelian
            Dim i As Integer
            i = DGV.CurrentRow.Index
            For i = 0 To DGV.Rows.Count - 1
                TotalLbl.Text = Format(Val(Replace(TotalLbl.Text, ".", "")) + Val(DGV.Item(5, i).Value), "#,#")
            Next

            TerbilangLbl.Text = TerbilangIndo.TerbilangIndonesia(Replace(TotalLbl.Text, ".", "")) & "*"

        Catch ex As Exception
            TotalLbl.Text = "0"
        End Try
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
        TxtSubTtl.Text = ""

        LblKdPel.Text = ""
        LblNmPel.Text = ""
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
        TxtSubTtl.Text = ""
        TxtKodeBarcode.Focus()
    End Sub

    Private Sub FrmPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Bersih()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        FrmMenuUtama.SidePanel.Height = FrmMenuUtama.BtnHome.Height
        FrmMenuUtama.SidePanel.Top = FrmMenuUtama.BtnHome.Top
        FrmMenuUtama.UcMenuUtama1.BringToFront()
        Me.Close()
    End Sub

    Private Sub TxtKodeBarcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKodeBarcode.KeyPress
        If e.KeyChar = Chr(13) Then
            If TxtKodeBarcode.Text = "" Then FrmDataBarang2.ShowDialog(): FrmDataBarang2.TxtCari.Focus() : Exit Sub

            Call Koneksi()

            Tampil.Connection = Database
            Tampil.CommandType = CommandType.Text

            Tampil.CommandText = "select * from TblBarang where Kode_Barcode = '" & TxtKodeBarcode.Text & "' "
            Tampilkan = Tampil.ExecuteReader
            If Tampilkan.HasRows = True Then
                Tampilkan.Read()
                TxtKodeBrg.Text = Tampilkan("Kode_Barang")
                TxtKodeBarcode.Text = Tampilkan("Kode_Barcode")
                TxtNmBrg.Text = Tampilkan("Nama_Barang")
                TxtSatuan.Text = Tampilkan("satuan")
                TxtHarga.Text = Tampilkan("Harga_Beli")
                TxtJml.Text = "0"
                TxtHarga.Focus()
            Else
                MsgBox("Kode Barcode Tidak Ada", MsgBoxStyle.Information)
                TxtKodeBarcode.Text = ""
                TxtKodeBarcode.Focus()
            End If
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TxtKodeBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtKodeBarcode.KeyDown
        Select Case e.KeyCode
            'Jika tombol F1 ditekan, maka cursor fokus ke text bayar
            Case Keys.F1
                If Val(Replace(TotalLbl.Text, ".", "")) = 0 Then
                    MsgBox("Transaksi Tidak Boleh Kosong", vbInformation, "Pesan") : Exit Sub
                ElseIf LblKdPel.Text = "" Then
                    MsgBox("Pemasok Masih Kosong", vbInformation, "Pesan") : FrmDataPemasok.ShowDialog() : Exit Sub
                End If

                'Proses Simpan
                Call Koneksi()
                DMLSql.Connection = Database
                DMLSql.CommandType = CommandType.Text

                DMLSql.CommandText = "Insert into TblPembelian values('" & TxtFaktur.Text & "','" & Format(Now, "yyyy/MM/dd") & "','" & _
                    Val(Replace(TotalLbl.Text, ".", "")) & "','" & LblKdPel.Text & "','" & FrmMenuUtama.LblKodeUser.Text & "')"
                DMLSql.ExecuteNonQuery()

                For baris As Integer = 0 To DGV.Rows.Count - 2
                    'simpan ke tabel detail
                    Call Koneksi()
                    DMLSql.Connection = Database
                    DMLSql.CommandType = CommandType.Text
                    DMLSql.CommandText = "Insert into TblPembelian_Rinci values ('" & TxtFaktur.Text & _
                        "','" & DGV.Rows(baris).Cells(0).Value & "','" & DGV.Rows(baris).Cells(3).Value & _
                        "','" & DGV.Rows(baris).Cells(4).Value & "','" & DGV.Rows(baris).Cells(5).Value & "')"
                    DMLSql.ExecuteNonQuery()

                    'Tambah stok barang
                    Call Koneksi()
                    Tampil.Connection = Database
                    Tampil.CommandType = CommandType.Text

                    Tampil.CommandText = "select * from TblBarang where Kode_Barang = '" & DGV.Rows(baris).Cells(0).Value & "' "
                    Tampilkan = Tampil.ExecuteReader
                    Tampilkan.Read()
                    If Tampilkan.HasRows = True Then
                        'Call Koneksi()
                        Tampil2.Connection = Database
                        Tampil2.CommandType = CommandType.Text
                        Tampil2.CommandText = "Update TblBarang set Harga_Beli='" & DGV.Rows(baris).Cells(3).Value & _
                            "',stock= '" & Val(Tampilkan.Item(8) + DGV.Rows(baris).Cells(4).Value) & "' where kode_barang='" & _
                            DGV.Rows(baris).Cells(0).Value & "'"
                        Tampil2.ExecuteNonQuery()
                    End If
                Next baris
                Call Bersih()
            Case Keys.F2
                FrmDataBarang2.ShowDialog()
                'Jika tombol F2 ditekan, maka tampil form data barang
            Case Keys.F3
                FrmDataPemasok.ShowDialog()
            Case Keys.Escape
                Call Bersih()
        End Select
    End Sub

    Private Sub TxtJml_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtJml.KeyDown
        Select Case e.KeyCode
            'Jika tombol F1 ditekan, maka cursor fokus ke text bayar
            Case Keys.F1
                If Val(Replace(TotalLbl.Text, ".", "")) = 0 Then
                    MsgBox("Transaksi Tidak Boleh Kosong", vbInformation, "Pesan") : Exit Sub
                ElseIf LblKdPel.Text = "" Then
                    MsgBox("Pemasok Masih Kosong", vbInformation, "Pesan") : Exit Sub
                End If

                'Proses Simpan
                Call Koneksi()
                DMLSql.Connection = Database
                DMLSql.CommandType = CommandType.Text

                DMLSql.CommandText = "Insert into TblPembelian values('" & TxtFaktur.Text & "','" & Format(Now, "yyyy/MM/dd") & "','" & _
                    Val(Replace(TotalLbl.Text, ".", "")) & "','" & LblKdPel.Text & "','" & FrmMenuUtama.LblKodeUser.Text & "')"
                DMLSql.ExecuteNonQuery()

                For baris As Integer = 0 To DGV.Rows.Count - 2
                    'simpan ke tabel detail
                    Call Koneksi()
                    DMLSql.Connection = Database
                    DMLSql.CommandType = CommandType.Text
                    DMLSql.CommandText = "Insert into TblPembelian_Rinci values ('" & TxtFaktur.Text & _
                        "','" & DGV.Rows(baris).Cells(0).Value & "','" & DGV.Rows(baris).Cells(3).Value & _
                        "','" & DGV.Rows(baris).Cells(4).Value & "','" & DGV.Rows(baris).Cells(5).Value & "')"
                    DMLSql.ExecuteNonQuery()

                    'kurangi stok barang
                    Call Koneksi()
                    Tampil.Connection = Database
                    Tampil.CommandType = CommandType.Text

                    Tampil.CommandText = "select * from TblBarang where Kode_Barang = '" & DGV.Rows(baris).Cells(0).Value & "' "
                    Tampilkan = Tampil.ExecuteReader
                    Tampilkan.Read()
                    If Tampilkan.HasRows = True Then
                        'Call Koneksi()
                        Tampil2.Connection = Database
                        Tampil2.CommandType = CommandType.Text
                        Tampil2.CommandText = "Update TblBarang set Harga_Beli='" & DGV.Rows(baris).Cells(3).Value & _
                            "',stock= '" & Val(Tampilkan.Item(8) + DGV.Rows(baris).Cells(4).Value) & "' where kode_barang='" & _
                            DGV.Rows(baris).Cells(0).Value & "'"
                        Tampil2.ExecuteNonQuery()
                    End If
                Next baris
                Call Bersih()
            Case Keys.F2
                FrmDataBarang2.ShowDialog()
                'Jika tombol F2 ditekan, maka tampil form data barang
            Case Keys.F3
                FrmDataPemasok.ShowDialog()
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
            ElseIf TxtHarga.Text = "0" Or TxtHarga.Text = "" Then
                MsgBox("Harga Beli tidak boleh kosong")
                TxtHarga.Text = ""
                TxtHarga.Focus()
            Else

                Call SubTotal()

                DGV.Rows.Add(TxtKodeBrg.Text, TxtNmBrg.Text, TxtSatuan.Text, TxtHarga.Text, TxtJml.Text, TxtSubTtl.Text)
                Call hitung()
                Call Bersih2()
            End If
        End If
        'untuk input hanya angka saja
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TxtJml_TextChanged(sender As Object, e As EventArgs) Handles TxtJml.TextChanged
        Call SubTotal()
    End Sub

    Private Sub TxtHarga_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtHarga.KeyDown
        Select Case e.KeyCode
            'Jika tombol F1 ditekan, maka cursor fokus ke text bayar
            Case Keys.F1
                If Val(Replace(TotalLbl.Text, ".", "")) = 0 Then
                    MsgBox("Transaksi Tidak Boleh Kosong", vbInformation, "Pesan") : Exit Sub
                ElseIf LblKdPel.Text = "" Then
                    MsgBox("Pemasok Masih Kosong", vbInformation, "Pesan") : Exit Sub
                End If

                'Proses Simpan
                Call Koneksi()
                DMLSql.Connection = Database
                DMLSql.CommandType = CommandType.Text

                DMLSql.CommandText = "Insert into TblPembelian values('" & TxtFaktur.Text & "','" & Format(Now, "yyyy/MM/dd") & "','" & _
                    Val(Replace(TotalLbl.Text, ".", "")) & "','" & LblKdPel.Text & "','" & FrmMenuUtama.LblKodeUser.Text & "')"
                DMLSql.ExecuteNonQuery()

                For baris As Integer = 0 To DGV.Rows.Count - 2
                    'simpan ke tabel detail
                    Call Koneksi()
                    DMLSql.Connection = Database
                    DMLSql.CommandType = CommandType.Text
                    DMLSql.CommandText = "Insert into TblPembelian_Rinci values ('" & TxtFaktur.Text & _
                        "','" & DGV.Rows(baris).Cells(0).Value & "','" & DGV.Rows(baris).Cells(3).Value & _
                        "','" & DGV.Rows(baris).Cells(4).Value & "','" & DGV.Rows(baris).Cells(5).Value & "')"
                    DMLSql.ExecuteNonQuery()

                    'kurangi stok barang
                    Call Koneksi()
                    Tampil.Connection = Database
                    Tampil.CommandType = CommandType.Text

                    Tampil.CommandText = "select * from TblBarang where Kode_Barang = '" & DGV.Rows(baris).Cells(0).Value & "' "
                    Tampilkan = Tampil.ExecuteReader
                    Tampilkan.Read()
                    If Tampilkan.HasRows = True Then
                        'Call Koneksi()
                        Tampil2.Connection = Database
                        Tampil2.CommandType = CommandType.Text
                        Tampil2.CommandText = "Update TblBarang set Harga_Beli='" & DGV.Rows(baris).Cells(3).Value & _
                            "',stock= '" & Val(Tampilkan.Item(8) + DGV.Rows(baris).Cells(4).Value) & "' where kode_barang='" & _
                            DGV.Rows(baris).Cells(0).Value & "'"
                        Tampil2.ExecuteNonQuery()
                    End If
                Next baris
                Call Bersih()
            Case Keys.F2
                FrmDataBarang2.ShowDialog()
                'Jika tombol F2 ditekan, maka tampil form data barang
            Case Keys.F3
                FrmDataPemasok.ShowDialog()
            Case Keys.Escape
                Call Bersih2()
        End Select
    End Sub

    Private Sub TxtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHarga.KeyPress
        If e.KeyChar = Chr(13) Then
            If TxtHarga.Text = "0" Or TxtHarga.Text = "" Then
                MsgBox("Harga Beli tidak boleh kosong")
                TxtHarga.Text = ""
                TxtHarga.Focus()
            ElseIf TxtJml.Text = "0" Or TxtJml.Text = "" Then
                TxtJml.Text = ""
                TxtJml.Focus()
            Else

                Call SubTotal()

                DGV.Rows.Add(TxtKodeBrg.Text, TxtNmBrg.Text, TxtSatuan.Text, TxtHarga.Text, TxtJml.Text, TxtSubTtl.Text)
                Call hitung()
                Call Bersih2()
            End If
        End If
        'untuk input hanya angka saja
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TxtHarga_TextChanged(sender As Object, e As EventArgs) Handles TxtHarga.TextChanged
        Call SubTotal()
    End Sub

    Private Sub TxtKodeBarcode_TextChanged(sender As Object, e As EventArgs) Handles TxtKodeBarcode.TextChanged

    End Sub

    Private Sub TxtKodeBrg_TextChanged(sender As Object, e As EventArgs) Handles TxtKodeBrg.TextChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblJam.Text = Format(Now, "hh:mm:ss")
    End Sub
End Class