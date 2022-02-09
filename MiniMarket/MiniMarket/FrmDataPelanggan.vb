Public Class FrmDataPelanggan

    Sub Data_Record()
        Try
            Call Koneksi()
            Ds = New DataSet

            Tabel = "SELECT MemberId,FullName,MembershipNumber,Address FROM Members
                        WHERE IsActive = 1"
            Grid = New OleDb.OleDbDataAdapter(Tabel, Database)
            Grid.Fill(Ds, "TblPelanggan")

            Dim GridView As New DataView(Ds.Tables("TblPelanggan"))
            DGV.DataSource = GridView
            DGV.Columns(0).Visible = False
            DGV.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DGV.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DGV.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub FrmDataPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtCari.Text = ""
        Call Data_Record()
        TxtCari.Focus()
        TxtCari.Select()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        'Menampilkan data Barang saat Klik Grid
        FrmPenjualan.LblKdPel.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        FrmPenjualan._currentMemberId = DGV.Rows(e.RowIndex).Cells(0).Value
        Call Koneksi()

        Tampil.Connection = Database
        Tampil.CommandType = CommandType.Text

        Tampil.CommandText = "SELECT MemberId,FullName,MembershipNumber,Address FROM Members
                        WHERE IsActive = 1 AND MembershipNumber = '" & FrmPenjualan.LblKdPel.Text & "' "
        Tampilkan = Tampil.ExecuteReader
        If Tampilkan.HasRows = True Then
            Tampilkan.Read()
            FrmPenjualan.LblNmPel.Text = Tampilkan("FullName")
            FrmPenjualan.TxtKodeBarcode.Focus()
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

            Tabel = "SELECT MemberId,FullName,MembershipNumber,Address FROM Members
                        WHERE IsActive = 1 AND (FullName like '%" & TxtCari.Text & "%' OR MembershipNumber like '%" & TxtCari.Text & "%' OR CardNumber like '%" & TxtCari.Text & "%')"
            Grid = New OleDb.OleDbDataAdapter(Tabel, Database)
            Grid.Fill(Ds, "TblPelanggan")

            Dim GridView As New DataView(Ds.Tables("TblPelanggan"))
            DGV.DataSource = GridView
            DGV.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DGV.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DGV.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
End Class