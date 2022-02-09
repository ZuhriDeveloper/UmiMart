Imports System.Data.OleDb

Public Class FakturRepository


    Public Function GetListFakturByTanggal(ByVal tglTransaksi As DateTime)
        Dim result As New List(Of FakturDto)
        ' Dim tglParam As New Date(tglTransaksi.Year, tglTransaksi.Month, tglTransaksi.Day, 0, 0, 0, 0)
        result = JustGetListFakturByTanggal(tglTransaksi)
        Return result
    End Function

    Private Function JustGetListFakturByTanggal(tglTransaksi As Date) As List(Of FakturDto)
        Try
            Dim result As New List(Of FakturDto)
            Call Koneksi()
            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text

            DMLSql.CommandText = " SELECT j.*,p.FullName as Nama_Pelanggan,pg.Nama_Pengguna from TblPenjualan  j
                                    LEFT JOIN Members p ON p.MemberId = j.Kode_Pelanggan
                                    LEFT JOIN TblPengguna pg ON pg.Kode_Pengguna = j.Kode_Pengguna
                                    where Convert(VARCHAR(10),j.Tgl_Transaksi,101)  = Convert(Varchar(10),?,101)"
            DMLSql.Parameters.AddWithValue("Tgl_Transaksi", tglTransaksi)
            Dim reader = DMLSql.ExecuteReader()
            While reader.Read()
                Dim item As New FakturDto
                item.NoFaktur = reader("No_Faktur")
                item.TglTransaksi = reader("Tgl_Transaksi")
                item.TotalBayar = reader("Total_Bayar")
                item.Bayar = reader("Bayar")
                item.Kembali = reader("Kembali")
                item.Pelanggan = reader("Nama_Pelanggan").ToString()
                item.Kasir = reader("Nama_Pengguna")
                item.PelangganId = reader("Kode_Pelanggan")
                item.Diskon = IIf(IsDBNull(reader("Diskon")), 0, reader("Diskon"))
                item.Voucher = IIf(IsDBNull(reader("Voucher")), 0, reader("Voucher"))
                result.Add(item)
            End While

            Return result
        Catch ex As Exception
            Return New List(Of FakturDto)
        Finally
            DMLSql.Dispose()
        End Try
    End Function

    Public Function GetListFakturByKodeFaktur(ByVal KodeFaktur As String) As List(Of FakturDto)
        Dim result As New List(Of FakturDto)
        result = JustGetListFakturByKodeFaktur(KodeFaktur)
        Return result
    End Function

    Private Function JustGetListFakturByKodeFaktur(kodeFaktur As String) As List(Of FakturDto)
        Try
            Dim result As New List(Of FakturDto)
            Call Koneksi()
            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text

            DMLSql.CommandText = " SELECT j.*,p.FullName as Nama_Pelanggan,pg.Nama_Pengguna from TblPenjualan  j
                                    LEFT JOIN Members p ON p.MemberId = j.Kode_Pelanggan
                                    LEFT JOIN TblPengguna pg ON pg.Kode_Pengguna = j.Kode_Pengguna
                                    where j.No_Faktur LIKE '%" + kodeFaktur + "%'"
            DMLSql.Parameters.AddWithValue("No_Faktur", kodeFaktur)
            Dim reader = DMLSql.ExecuteReader()
            While reader.Read()
                Dim item As New FakturDto
                item.NoFaktur = reader("No_Faktur")
                item.TglTransaksi = reader("Tgl_Transaksi")
                item.TotalBayar = reader("Total_Bayar")
                item.Bayar = reader("Bayar")
                item.Kembali = reader("Kembali")
                item.Pelanggan = reader("Nama_Pelanggan").ToString()
                item.Kasir = reader("Nama_Pengguna")
                item.PelangganId = reader("Kode_Pelanggan")
                item.Diskon = IIf(IsDBNull(reader("Diskon")), 0, reader("Diskon"))
                item.Voucher = IIf(IsDBNull(reader("Voucher")), 0, reader("Voucher"))
                result.Add(item)
            End While

            Return result
        Catch ex As Exception
            Return New List(Of FakturDto)
        Finally
            DMLSql.Dispose()
        End Try
    End Function

    Public Function GetFaktur(ByVal KodeFaktur As String) As FakturDto
        Dim result As New FakturDto
        result = JustGetFakturHeader(KodeFaktur)
        result.ListDetail = JustGetFakturDetail(KodeFaktur)
        Return result
    End Function

    Private Function JustGetFakturDetail(kodeFaktur As String) As List(Of FakturDetailDto)
        Dim result As New List(Of FakturDetailDto)
        Try
            Call Koneksi()
            DMLSql = New OleDb.OleDbCommand
            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text

            DMLSql.CommandText = " SELECT pr.*,p.Name FROM TblPenjualan_Rinci pr
                                    LEFT JOIN Products p ON pr.Kode_Barang = p.ProductId
                                    WHERE No_Faktur = '" & kodeFaktur & "'"


            Dim reader = DMLSql.ExecuteReader()
            While reader.Read()
                Dim item As New FakturDetailDto
                item.NamaBarang = reader("Name")
                item.HargaJual = reader("Hrg_Jual")
                item.JmlJual = reader("Jml_Jual")
                item.SubTotal = reader("Sub_Total")
                result.Add(item)
            End While

        Catch ex As Exception
        Finally

            DMLSql.Dispose()
        End Try
        Return result
    End Function

    Private Function JustGetFakturHeader(kodeFaktur As String) As FakturDto
        Try
            Dim result As New FakturDto
            Call Koneksi()
            DMLSql = New OleDbCommand()
            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text

            DMLSql.CommandText = " SELECT TOP 1 j.*,p.FullName as Nama_Pelanggan,pg.Nama_Pengguna from TblPenjualan  j
                                    LEFT JOIN Members p ON p.MemberId = j.Kode_Pelanggan
                                    LEFT JOIN TblPengguna pg ON pg.Kode_Pengguna = j.Kode_Pengguna
                                    where j.No_Faktur = ?"
            DMLSql.Parameters.AddWithValue("No_Faktur", kodeFaktur)
            Dim reader = DMLSql.ExecuteReader()
            While reader.Read()
                result.NoFaktur = reader("No_Faktur")
                result.TglTransaksi = reader("Tgl_Transaksi")
                result.TotalBayar = reader("Total_Bayar")
                result.Bayar = reader("Bayar")
                result.Kembali = reader("Kembali")
                result.Pelanggan = reader("Nama_Pelanggan").ToString()
                result.Kasir = reader("Nama_Pengguna")
                result.PelangganId = reader("Kode_Pelanggan")
                result.Diskon = IIf(IsDBNull(reader("Diskon")), 0, reader("Diskon"))
                result.Voucher = IIf(IsDBNull(reader("Voucher")), 0, reader("Voucher"))
            End While

            Return result
        Catch ex As Exception
            Return New FakturDto
        Finally
            DMLSql.Dispose()
        End Try

    End Function
End Class
