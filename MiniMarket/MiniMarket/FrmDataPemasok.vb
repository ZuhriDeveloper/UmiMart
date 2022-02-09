Public Class FrmDataPemasok

    Sub Data_Record()
        Try
            Call Koneksi()
            Ds = New DataSet

            Tabel = "SELECT * FROM TblPemasok"
            Grid = New OleDb.OleDbDataAdapter(Tabel, Database)
            Grid.Fill(Ds, "TblPemasok")

            Dim GridView As New DataView(Ds.Tables("TblPemasok"))
            DGV.DataSource = GridView
            DGV.Columns(0).Width = 100
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub FrmDataPemasok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCari.Text = ""
        Call Data_Record()
        TxtCari.Focus()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        'Menampilkan data Barang saat Klik Grid
        FrmPembelian.LblKdPel.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Call Koneksi()

        Tampil.Connection = Database
        Tampil.CommandType = CommandType.Text

        Tampil.CommandText = "select * from TblPemasok where Kode_Pemasok = '" & FrmPembelian.LblKdPel.Text & "' "
        Tampilkan = Tampil.ExecuteReader
        If Tampilkan.HasRows = True Then
            Tampilkan.Read()
            FrmPembelian.LblNmPel.Text = Tampilkan("Nama_Pemasok")
            FrmPembelian.TxtKodeBarcode.Focus()
            Me.Close()
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

            Tabel = "SELECT * FROM TblPemasok where nama_Pemasok like '%" & TxtCari.Text & "%'"
            Grid = New OleDb.OleDbDataAdapter(Tabel, Database)
            Grid.Fill(Ds, "TblPemasok")

            Dim GridView As New DataView(Ds.Tables("TblPemasok"))
            DGV.DataSource = GridView
            DGV.Columns(0).Width = 100
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
End Class