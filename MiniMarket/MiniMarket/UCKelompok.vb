Public Class UCKelompok
    Sub Data_Record()
        Try
            Call Koneksi()

            Ds = New DataSet

            Tabel = "SELECT * FROM TblKelompok"
            Grid = New OleDb.OleDbDataAdapter(Tabel, Database)
            Grid.Fill(Ds, "TblKelompok")

            Dim GridView As New DataView(Ds.Tables("TblKelompok"))
            DGV.DataSource = GridView
            DGV.Columns(0).Width = 470
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub Atur()
        TxtNama.Text = ""
        BtnSimpan.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        TxtNama.Focus()
        Call Data_Record()
    End Sub

    Private Sub UCKelompok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Atur()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtNama.Text = "" Then Exit Sub
        Try
            Call Koneksi()

            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text

            DMLSql.CommandText = "Insert into TblKelompok values('" & TxtNama.Text & "')"
            DMLSql.ExecuteNonQuery()

            Call Atur()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call Atur()
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If TxtNama.Text = "" Then Exit Sub
        Try
            Call Koneksi()

            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text

            DMLSql.CommandText = "update TblKelompok set Kelompok = '" & TxtNama.Text & "' where Kelompok = '" & DGV.SelectedCells(0).Value & "'"
            DMLSql.ExecuteNonQuery()

            Call Atur()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Try
            Call Koneksi()

            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text

            DMLSql.CommandText = "Delete from TblKelompok where Kelompok = '" & DGV.SelectedCells(0).Value & "'"
            DMLSql.ExecuteNonQuery()

            Call Atur()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        'Menampilkan data Pegawai saat Klik Grid
        TxtNama.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        BtnSimpan.Enabled = False
        BtnHapus.Enabled = True
        BtnUbah.Enabled = True
    End Sub

    Private Sub DGV_DoubleClick(sender As Object, e As EventArgs) Handles DGV.DoubleClick
        Try
            TxtNama.Text = DGV.SelectedCells(0).Value
            BtnSimpan.Enabled = False
            BtnUbah.Enabled = True
            BtnHapus.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()

            Tampil.Connection = Database
            Tampil.CommandType = CommandType.Text

            Tampil.CommandText = "select * from TblKelompok where Kelompok = '" & TxtNama.Text & "' "
            Tampilkan = Tampil.ExecuteReader
            If Tampilkan.HasRows = True Then
                Tampilkan.Read()
                TxtNama.Text = Tampilkan("Kelompok")
                MsgBox("Data Sudah Ada")
                BtnSimpan.Enabled = False
                BtnBatal.Focus()
            Else
                BtnSimpan.Enabled = True
                BtnHapus.Enabled = False
                BtnUbah.Enabled = False
                BtnSimpan.Focus()
            End If
        End If
    End Sub

End Class
