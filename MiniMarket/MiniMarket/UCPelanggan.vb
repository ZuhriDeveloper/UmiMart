Public Class UCPelanggan
   Sub Data_Record()
        Try
            Call Koneksi()
            Ds = New DataSet

            Tabel = "SELECT * FROM TblPelanggan"
            Grid = New OleDb.OleDbDataAdapter(Tabel, Database)
            Grid.Fill(Ds, "TblPelanggan")

            Dim GridView As New DataView(Ds.Tables("TblPelanggan"))
            DGV.DataSource = GridView
            DGV.Columns(0).Width = 120
            DGV.Columns(1).Width = 120
            DGV.Columns(2).Width = 250
            DGV.Columns(3).Width = 110
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub Kode_Pelanggan()
        Call Koneksi()

        Tampil.Connection = Database
        Tampil.CommandType = CommandType.Text
        Tampil.CommandText = "select * from TblPelanggan order by Kode_Pelanggan Asc"
        Tampilkan = Tampil.ExecuteReader

        If Tampilkan.HasRows = True Then
            While Tampilkan.Read()
                TxtKode.Text = Tampilkan("Kode_Pelanggan")
            End While
            TxtKode.Text = TxtKode.Text + 1

            If Len(TxtKode.Text) = 1 Then
                TxtKode.Text = "000" & TxtKode.Text & ""
            ElseIf Len(TxtKode.Text) = 2 Then
                TxtKode.Text = "00" & TxtKode.Text & ""
            ElseIf Len(TxtKode.Text) = 3 Then
                TxtKode.Text = "0" & TxtKode.Text & ""
            ElseIf Len(TxtKode.Text) = 4 Then
                TxtKode.Text = "" & TxtKode.Text & ""
            Else
                TxtKode.Text = TxtKode.Text
            End If
            TxtNama.Focus()
        Else
            TxtKode.Text = "0001"
        End If
    End Sub

    Sub Bersih()
        TxtKode.Enabled = False

        TxtNama.Text = ""
        TxtAlamat.Text = ""
        TxtNo.Text = ""
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = True
        Call Data_Record()
        Call Kode_Pelanggan()
        TxtNama.Focus()
    End Sub

    Private Sub UCPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Bersih()
    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtAlamat.Focus()
        End If
    End Sub

    Private Sub TxtAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAlamat.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtNo.Focus()
        End If
    End Sub

    Private Sub TxtNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNo.KeyPress
        If e.KeyChar = Chr(13) Then
            If BtnSimpan.Enabled = True Then
                BtnSimpan.Focus()
            Else
                BtnBatal.Focus()
            End If
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtNama.Text = "" Or TxtAlamat.Text = "" Or TxtNo.Text = "" Then MsgBox("Data Belum Lengkap") : Exit Sub

        Try
            Call Koneksi()
            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text

            DMLSql.CommandText = "Insert into TblPelanggan values('" & TxtKode.Text & "','" & TxtNama.Text & "','" & _
               TxtAlamat.Text & "','" & Val(TxtNo.Text) & "')"
            DMLSql.ExecuteNonQuery()

            Call Bersih()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        On Error Resume Next
        'Menampilkan data Pegawai saat Klik Grid
        TxtKode.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Call Koneksi()

        Tampil.Connection = Database
        Tampil.CommandType = CommandType.Text

        Tampil.CommandText = "select * from TblPelanggan where Kode_Pelanggan = '" & TxtKode.Text & "' "
        Tampilkan = Tampil.ExecuteReader
        If Tampilkan.HasRows = True Then
            Tampilkan.Read()
            TxtKode.Text = Tampilkan("Kode_Pelanggan")
            TxtNama.Text = Tampilkan("Nama_Pelanggan")
            TxtAlamat.Text = Tampilkan("Alamat")
            TxtNo.Text = Tampilkan("Telepon")
            BtnSimpan.Enabled = False
            BtnHapus.Enabled = True
            BtnUbah.Enabled = True
        End If
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call Bersih()
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If TxtNama.Text = "" Or TxtAlamat.Text = "" Or TxtNo.Text = "" Then MsgBox("Data Belum Lengkap") : Exit Sub

        Try
            Call Koneksi()

            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text

            DMLSql.CommandText = "update TblPelanggan set Nama_Pelanggan='" & TxtNama.Text & "',Alamat='" & _
               TxtAlamat.Text & "',Telepon='" & Val(TxtNo.Text) & "' where Kode_Pelanggan = '" & TxtKode.Text & "' "
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

            DMLSql.CommandText = "Delete from TblPelanggan where Kode_Pelanggan = '" & TxtKode.Text & "' "
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

            Tabel = "SELECT * FROM TblPelanggan where nama_Pelanggan like '%" & TxtCari.Text & "%'"
            Grid = New OleDb.OleDbDataAdapter(Tabel, Database)
            Grid.Fill(Ds, "TblPelanggan")

            Dim GridView As New DataView(Ds.Tables("TblPelanggan"))
            DGV.DataSource = GridView
            DGV.Columns(0).Width = 120
            DGV.Columns(1).Width = 120
            DGV.Columns(2).Width = 250
            DGV.Columns(3).Width = 110
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DGV_CellMouseClick1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        'Menampilkan data Pegawai saat Klik Grid
        TxtKode.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Call Koneksi()

        Tampil.Connection = Database
        Tampil.CommandType = CommandType.Text

        Tampil.CommandText = "select * from TblPelanggan where Kode_Pelanggan = '" & TxtKode.Text & "' "
        Tampilkan = Tampil.ExecuteReader
        If Tampilkan.HasRows = True Then
            Tampilkan.Read()
            TxtKode.Text = Tampilkan("Kode_Pelanggan")
            TxtNama.Text = Tampilkan("Nama_Pelanggan")
            TxtAlamat.Text = Tampilkan("Alamat")
            TxtNo.Text = Tampilkan("Telepon")
            BtnSimpan.Enabled = False
            BtnHapus.Enabled = True
            BtnUbah.Enabled = True
        End If
    End Sub
End Class
