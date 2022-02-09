Imports System.Globalization

Public Class FrmDataBarang

    Sub Data_Record()
        Try
            Call Koneksi()
            Ds = New DataSet

            Tabel = "SELECT Barcode,[Nama] =  Name,[Harga Jual] = CAST(SellPrice AS INT) FROM Products WHERE IsActive = 1"
            Grid = New OleDb.OleDbDataAdapter(Tabel, Database)
            Grid.Fill(Ds, "TblBarang")

            Dim GridView As New DataView(Ds.Tables("TblBarang"))
            DGV.DataSource = GridView
            DGV.Columns(0).Width = 100
            DGV.Columns(1).Width = 400
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub FrmDataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCari.Text = ""
        Call Data_Record()
        TxtCari.Focus()
        TxtCari.Select()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        'Menampilkan data Barang saat Klik Grid
        FrmPenjualan.TxtKodeBrg.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Call Koneksi()

        Tampil.Connection = Database
        Tampil.CommandType = CommandType.Text

        Tampil.CommandText = "select * from Products where Barcode = '" & FrmPenjualan.TxtKodeBrg.Text & "' "
        Tampilkan = Tampil.ExecuteReader
        If Tampilkan.HasRows = True Then
            Tampilkan.Read()
            FrmPenjualan._currentProductId = Tampilkan("ProductId")
            FrmPenjualan.TxtKodeBarcode.Text = Tampilkan("Barcode")
            FrmPenjualan.TxtNmBrg.Text = IIf(Tampilkan("Name").ToString().Length > 20, Strings.Left(Tampilkan("Name").ToString(), 20), Tampilkan("Name").ToString())
            FrmPenjualan.TxtSatuan.Text = "pcs"
            FrmPenjualan.TxtHarga.Text = CInt(Tampilkan("SellPrice"))
            'FrmPenjualan.TxtDiskon.Text = Tampilkan("Diskon_Jual")
            'FrmPenjualan.TxtStock.Text = Tampilkan("Stock")
            Me.Close()
            FrmPenjualan.TxtJml.Text = "1"
            FrmPenjualan.TxtJml.Focus()

        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub TxtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCari.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        Try
            Call Koneksi()
            Ds = New DataSet

            Tabel = "SELECT Barcode,[Nama] =  Name,[Harga Jual] = SellPrice FROM Products WHERE IsActive = 1 AND Name like '%" & TxtCari.Text & "%'"
            Grid = New OleDb.OleDbDataAdapter(Tabel, Database)
            Grid.Fill(Ds, "TblBarang")

            Dim GridView As New DataView(Ds.Tables("TblBarang"))
            DGV.DataSource = GridView
            DGV.Columns(0).Width = 100
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
End Class