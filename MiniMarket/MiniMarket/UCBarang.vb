Public Class UCBarang
    Sub Data_Record()
        Try
            Call Koneksi()
            Ds = New DataSet

            Tabel = "SELECT * FROM TblBarang"
            Grid = New OleDb.OleDbDataAdapter(Tabel, Database)
            Grid.Fill(Ds, "TblBarang")

            Dim GridView As New DataView(Ds.Tables("TblBarang"))
            DGV.DataSource = GridView
            DGV.Columns(0).Width = 100
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub Kode_Barang()
        Call Koneksi()

        Tampil.Connection = Database
        Tampil.CommandType = CommandType.Text
        Tampil.CommandText = "select * from TblBarang order by Kode_Barang Asc"
        Tampilkan = Tampil.ExecuteReader

        If Tampilkan.HasRows = True Then
            While Tampilkan.Read()
                TxtKodeBrg.Text = Tampilkan("Kode_Barang")
            End While
            TxtKodeBrg.Text = TxtKodeBrg.Text + 1

            If Len(TxtKodeBrg.Text) = 1 Then
                TxtKodeBrg.Text = "0000" & TxtKodeBrg.Text & ""
            ElseIf Len(TxtKodeBrg.Text) = 2 Then
                TxtKodeBrg.Text = "000" & TxtKodeBrg.Text & ""
            ElseIf Len(TxtKodeBrg.Text) = 3 Then
                TxtKodeBrg.Text = "00" & TxtKodeBrg.Text & ""
            ElseIf Len(TxtKodeBrg.Text) = 4 Then
                TxtKodeBrg.Text = "0" & TxtKodeBrg.Text & ""
            ElseIf Len(TxtKodeBrg.Text) = 5 Then
                TxtKodeBrg.Text = "" & TxtKodeBrg.Text & ""
            Else
                TxtKodeBrg.Text = TxtKodeBrg.Text
            End If
            TxtKodeBar.Focus()
        Else
            TxtKodeBrg.Text = "00001"
        End If
    End Sub

    Sub Kelompok()
        Call Koneksi()
        Tampil.Connection = Database
        Tampil.CommandType = CommandType.Text
        Tampil.CommandText = "select * from TblKelompok order by Kelompok Asc"
        Tampilkan = Tampil.ExecuteReader

        If Tampilkan.HasRows = True Then
            While Tampilkan.Read()
                CmbKelompok.Items.Add(Tampilkan("Kelompok"))
            End While
        End If
    End Sub

    Sub Satuan()
        Call Koneksi()
        Tampil.Connection = Database
        Tampil.CommandType = CommandType.Text
        Tampil.CommandText = "select * from TblSatuan order by Satuan Asc"
        Tampilkan = Tampil.ExecuteReader

        If Tampilkan.HasRows = True Then
            While Tampilkan.Read()
                CmbSatuan.Items.Add(Tampilkan("Satuan"))
            End While
        End If
    End Sub
    Sub Bersih()
        TxtKodeBrg.Enabled = False

        TxtKodeBar.Text = ""
        TxtNama.Text = ""
        CmbKelompok.Text = ""
        CmbSatuan.Text = ""
        TxtHrgBeli.Text = ""
        TxtHrgJual.Text = ""
        TxtDiskon.Text = ""
        TxtStock.Text = ""
        TxtKeterangan.Text = ""
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = True
        TxtKodeBar.Enabled = True
        Call Data_Record()
        Call Kode_Barang()

        TxtKodeBar.Focus()
    End Sub

    Private Sub UCBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Bersih()
        Call Kelompok()
        Call Satuan()
    End Sub

    Private Sub TxtKodeBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKodeBar.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()

            Tampil.Connection = Database
            Tampil.CommandType = CommandType.Text

            Tampil.CommandText = "select * from TblBarang where Kode_Barcode = '" & TxtKodeBar.Text & "' "
            Tampilkan = Tampil.ExecuteReader
            If Tampilkan.HasRows = True Then
                Tampilkan.Read()
                MsgBox("Data Sudah Ada")
                TxtKodeBrg.Text = Tampilkan("Kode_Barang")
                TxtKodeBar.Text = Tampilkan("Kode_Barcode")
                TxtNama.Text = Tampilkan("Nama_Barang")
                CmbKelompok.Text = Tampilkan("Kelompok")
                CmbSatuan.Text = Tampilkan("satuan")
                TxtHrgBeli.Text = Tampilkan("Harga_Beli")
                TxtHrgJual.Text = Tampilkan("Harga_Jual")
                TxtDiskon.Text = Tampilkan("Diskon_Jual")
                TxtStock.Text = Tampilkan("Stock")
                TxtKeterangan.Text = Tampilkan("Keterangan")
                BtnSimpan.Enabled = False
                BtnBatal.Focus()
            Else
                BtnSimpan.Enabled = True
                BtnHapus.Enabled = False
                BtnUbah.Enabled = False
                TxtNama.Focus()
            End If
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            CmbKelompok.Focus()
        End If
    End Sub

    Private Sub CmbKelompok_Click(sender As Object, e As EventArgs) Handles CmbKelompok.Click

    End Sub

    Private Sub CmbKelompok_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbKelompok.SelectedIndexChanged
        CmbSatuan.Focus()
    End Sub

    Private Sub CmbSatuan_Click(sender As Object, e As EventArgs) Handles CmbSatuan.Click

    End Sub

    Private Sub CmbSatuan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSatuan.SelectedIndexChanged
        TxtHrgBeli.Focus()
    End Sub

    Private Sub TxtHrgBeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHrgBeli.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtHrgJual.Focus()
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TxtHrgBeli_TextChanged(sender As Object, e As EventArgs) Handles TxtHrgBeli.TextChanged

    End Sub

    Private Sub TxtHrgJual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHrgJual.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtDiskon.Focus()
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TxtHrgJual_TextChanged(sender As Object, e As EventArgs) Handles TxtHrgJual.TextChanged

    End Sub

    Private Sub TxtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStock.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtKeterangan.Focus()
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TxtStock_TextChanged(sender As Object, e As EventArgs) Handles TxtStock.TextChanged

    End Sub

    Private Sub TxtKeterangan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKeterangan.KeyPress
        If e.KeyChar = Chr(13) Then
            If BtnSimpan.Enabled = True Then
                BtnSimpan.Focus()
            Else
                BtnBatal.Focus()
            End If
        End If
    End Sub

    Private Sub TxtKeterangan_TextChanged(sender As Object, e As EventArgs) Handles TxtKeterangan.TextChanged

    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtKodeBar.Text = "" Or TxtNama.Text = "" Or CmbKelompok.Text = "" Or CmbSatuan.Text = "" Or _
            TxtHrgBeli.Text = "" Or TxtHrgJual.Text = "" Or TxtDiskon.Text = "" Or _
            TxtStock.Text = "" Or TxtKeterangan.Text = "" Then MsgBox("Data Belum Lengkap") : Exit Sub

        Try
            Call Koneksi()
            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text

            DMLSql.CommandText = "Insert into TblBarang values('" & TxtKodeBrg.Text & "','" & TxtKodeBar.Text & "','" & _
               TxtNama.Text & "','" & CmbKelompok.Text & "','" & CmbSatuan.Text & "','" & Val(TxtHrgBeli.Text) & "','" & _
                Val(TxtHrgJual.Text) & "','" & Val(TxtDiskon.Text) & "','" & Val(TxtStock.Text) & "','" & TxtKeterangan.Text & "')"
            DMLSql.ExecuteNonQuery()

            Call Bersih()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        'Menampilkan data Barang saat Klik Grid
        TxtKodeBrg.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Call Koneksi()

        Tampil.Connection = Database
        Tampil.CommandType = CommandType.Text

        Tampil.CommandText = "select * from TblBarang where Kode_Barang = '" & TxtKodeBrg.Text & "' "
        Tampilkan = Tampil.ExecuteReader
        If Tampilkan.HasRows = True Then
            Tampilkan.Read()
            TxtKodeBrg.Text = Tampilkan("Kode_Barang")
            TxtKodeBar.Text = Tampilkan("Kode_Barcode")
            TxtNama.Text = Tampilkan("Nama_Barang")
            CmbKelompok.Text = Tampilkan("Kelompok")
            CmbSatuan.Text = Tampilkan("satuan")
            TxtHrgBeli.Text = Tampilkan("Harga_Beli")
            TxtHrgJual.Text = Tampilkan("Harga_Jual")
            TxtDiskon.Text = Tampilkan("Diskon_Jual")
            TxtStock.Text = Tampilkan("Stock")
            TxtKeterangan.Text = Tampilkan("Keterangan")
            TxtKodeBar.Enabled = False
            BtnSimpan.Enabled = False
            BtnHapus.Enabled = True
            BtnUbah.Enabled = True
        End If
    End Sub

    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick

    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call Bersih()
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If TxtKodeBar.Text = "" Or TxtNama.Text = "" Or CmbKelompok.Text = "" Or CmbSatuan.Text = "" Or _
            TxtHrgBeli.Text = "" Or TxtHrgJual.Text = "" Or TxtDiskon.Text = "" Or _
            TxtStock.Text = "" Or TxtKeterangan.Text = "" Then MsgBox("Data Belum Lengkap") : Exit Sub
        Try
            Call Koneksi()

            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text

            DMLSql.CommandText = "update TblBarang set Kode_Barcode = '" & TxtKodeBar.Text & "',Nama_Barang='" & _
               TxtNama.Text & "',Kelompok='" & CmbKelompok.Text & "',satuan='" & CmbSatuan.Text & "',Harga_Beli='" & _
               Val(TxtHrgBeli.Text) & "',Harga_Jual='" & Val(TxtHrgJual.Text) & "',Diskon_Jual='" & Val(TxtDiskon.Text) & _
               "', Stock='" & Val(TxtStock.Text) & "',Keterangan='" & TxtKeterangan.Text & _
               "' where Kode_Barang = '" & TxtKodeBrg.Text & "' "
            DMLSql.ExecuteNonQuery()

            Call Bersih()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Try
            Call Koneksi()

            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text

            DMLSql.CommandText = "Delete from TblBarang where Kode_Barang = '" & TxtKodeBrg.Text & "' "
            DMLSql.ExecuteNonQuery()

            Call Bersih()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        Try
            Call Koneksi()
            Ds = New DataSet

            Tabel = "SELECT * FROM TblBarang where nama_barang like '%" & TxtCari.Text & "%'"
            Grid = New OleDb.OleDbDataAdapter(Tabel, Database)
            Grid.Fill(Ds, "TblBarang")

            Dim GridView As New DataView(Ds.Tables("TblBarang"))
            DGV.DataSource = GridView
            DGV.Columns(0).Width = 100
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub TxtDiskon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDiskon.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtStock.Focus()
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub
End Class
