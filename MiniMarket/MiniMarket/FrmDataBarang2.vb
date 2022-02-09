Public Class FrmDataBarang2

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

    Private Sub FrmDataBarang2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCari.Text = ""
        Call Data_Record()
        TxtCari.Focus()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        'Menampilkan data Barang saat Klik Grid
        FrmPembelian.TxtKodeBrg.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Call Koneksi()

        Tampil.Connection = Database
        Tampil.CommandType = CommandType.Text

        Tampil.CommandText = "select * from TblBarang where Kode_Barang = '" & FrmPembelian.TxtKodeBrg.Text & "' "
        Tampilkan = Tampil.ExecuteReader
        If Tampilkan.HasRows = True Then
            Tampilkan.Read()
            FrmPembelian.TxtKodeBarcode.Text = Tampilkan("Kode_Barcode")
            FrmPembelian.TxtNmBrg.Text = Tampilkan("Nama_Barang")
            FrmPembelian.TxtSatuan.Text = Tampilkan("satuan")
            FrmPembelian.TxtHarga.Text = Tampilkan("Harga_Beli")
            Me.Close()
            FrmPembelian.TxtJml.Text = "1"
            FrmPembelian.TxtJml.Focus()

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
End Class