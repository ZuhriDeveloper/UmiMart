Public Class UCPengguna

    Sub Data_Record()
        Try
            Call Koneksi()
            Ds = New DataSet

            Tabel = "SELECT * FROM TblPengguna"
            Grid = New OleDb.OleDbDataAdapter(Tabel, Database)
            Grid.Fill(Ds, "TblPengguna")

            Dim GridView As New DataView(Ds.Tables("TblPengguna"))
            DGV.DataSource = GridView
            DGV.Columns(0).Width = 100
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Sub Kode_Pengguna()
        Call Koneksi()

        Tampil.Connection = Database
        Tampil.CommandType = CommandType.Text
        Tampil.CommandText = "select * from TblPengguna order by Kode_Pengguna Asc"
        Tampilkan = Tampil.ExecuteReader

        If Tampilkan.HasRows = True Then
            While Tampilkan.Read()
                TxtKode.Text = Tampilkan("Kode_Pengguna")
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
        TxtNmUser.Text = ""
        TxtPassword.Text = ""
        CBOStatus.Text = ""

        TxtKode.Enabled = False
        TxtNama.Enabled = True
        TxtNmUser.Enabled = True
        TxtPassword.Enabled = True
        CBOStatus.Enabled = True
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = True
        CBOStatus.Items.Clear()

        CBOStatus.Items.Add("Admin")
        CBOStatus.Items.Add("Kasir")

        Call Data_Record()
        Call Kode_Pengguna()
        TxtNama.Focus()
    End Sub

    Private Sub UCPengguna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Bersih()
    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()

            Tampil.Connection = Database
            Tampil.CommandType = CommandType.Text

            Tampil.CommandText = "select * from TblPengguna where Nama_Pengguna = '" & TxtNama.Text & "' "
            Tampilkan = Tampil.ExecuteReader
            If Tampilkan.HasRows = True Then
                Tampilkan.Read()
                MsgBox("Data Sudah Ada")
                TxtKode.Text = Tampilkan("Kode_Pengguna")
                TxtNama.Text = Tampilkan("Nama_Pengguna")
                TxtNmUser.Text = Tampilkan("Nama_Login")
                TxtPassword.Text = Tampilkan("Password")
                CBOStatus.Text = Tampilkan("Status")
                TxtKode.Enabled = False
                TxtNama.Enabled = False
                TxtNmUser.Enabled = False
                TxtPassword.Enabled = False
                CBOStatus.Enabled = False
                BtnSimpan.Enabled = False
                BtnHapus.Enabled = True
                BtnBatal.Focus()
            Else
                BtnSimpan.Enabled = True
                BtnHapus.Enabled = False
                TxtNmUser.Focus()
            End If
        End If
    End Sub

    Private Sub TxtNmUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNmUser.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()

            Tampil.Connection = Database
            Tampil.CommandType = CommandType.Text

            Tampil.CommandText = "select * from TblPengguna where Nama_Login = '" & TxtNmUser.Text & "' "
            Tampilkan = Tampil.ExecuteReader
            If Tampilkan.HasRows = True Then
                Tampilkan.Read()
                MsgBox("Data Sudah Ada")
                TxtKode.Text = Tampilkan("Kode_Pengguna")
                TxtNama.Text = Tampilkan("Nama_Pengguna")
                TxtNmUser.Text = Tampilkan("Nama_Login")
                TxtPassword.Text = Tampilkan("Password")
                CBOStatus.Text = Tampilkan("Status")
                TxtKode.Enabled = False
                TxtNama.Enabled = False
                TxtNmUser.Enabled = False
                TxtPassword.Enabled = False
                CBOStatus.Enabled = False
                BtnSimpan.Enabled = False
                BtnHapus.Enabled = True
                BtnBatal.Focus()
            Else
                BtnSimpan.Enabled = True
                BtnHapus.Enabled = False
                TxtPassword.Focus()
            End If
        End If
    End Sub

    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            CBOStatus.Focus()
        End If
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub CBOStatus_Click(sender As Object, e As EventArgs) Handles CBOStatus.Click

    End Sub

    Private Sub CBOStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOStatus.SelectedIndexChanged
        If BtnSimpan.Enabled = True Then
            BtnSimpan.Focus()
        Else
            BtnBatal.Focus()
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtNama.Text = "" Or TxtNmUser.Text = "" Or TxtPassword.Text = "" Or CBOStatus.Text = "" Then _
            MsgBox("Data Belum Lengkap") : Exit Sub

        Call Koneksi()

        Tampil.Connection = Database
        Tampil.CommandType = CommandType.Text

        Tampil.CommandText = "select * from TblPengguna where Kode_Pengguna='" & TxtKode.Text & "' or Nama_Pengguna='" & _
            TxtNama.Text & "' or Nama_Login = '" & TxtNmUser.Text & "' "
        Tampilkan = Tampil.ExecuteReader
        If Tampilkan.HasRows = True Then
            Tampilkan.Read()
            MsgBox("Data Sudah Ada")
            TxtKode.Text = Tampilkan("Kode_Pengguna")
            TxtNama.Text = Tampilkan("Nama_Pengguna")
            TxtNmUser.Text = Tampilkan("Nama_Login")
            TxtPassword.Text = Tampilkan("Password")
            CBOStatus.Text = Tampilkan("Status")
            TxtKode.Enabled = False
            TxtNama.Enabled = False
            TxtNmUser.Enabled = False
            TxtPassword.Enabled = False
            CBOStatus.Enabled = False
            BtnSimpan.Enabled = False
            BtnHapus.Enabled = True
            BtnBatal.Focus()
        Else
            Try
                Call Koneksi()
                DMLSql.Connection = Database
                DMLSql.CommandType = CommandType.Text

                DMLSql.CommandText = "Insert into TblPengguna values('" & TxtKode.Text & "','" & TxtNama.Text & "','" & _
                    TxtNmUser.Text & "','" & TxtPassword.Text & "','" & CBOStatus.Text & "')"
                DMLSql.ExecuteNonQuery()

                Call Bersih()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        On Error Resume Next
        'Menampilkan data Pengguna saat Klik Grid
        TxtKode.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        Call Koneksi()

        Tampil.Connection = Database
        Tampil.CommandType = CommandType.Text

        Tampil.CommandText = "select * from TblPengguna where Kode_Pengguna = '" & TxtKode.Text & "' "
        Tampilkan = Tampil.ExecuteReader
        If Tampilkan.HasRows = True Then
            Tampilkan.Read()
            TxtNama.Text = Tampilkan("Nama_Pengguna")
            TxtNmUser.Text = Tampilkan("Nama_Login")
            TxtPassword.Text = Tampilkan("Password")
            CBOStatus.Text = Tampilkan("Status")
            TxtKode.Enabled = False
            TxtNama.Enabled = False
            TxtNmUser.Enabled = False
            TxtPassword.Enabled = False
            CBOStatus.Enabled = False
            BtnSimpan.Enabled = False
            BtnHapus.Enabled = True
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Try
            Call Koneksi()

            DMLSql.Connection = Database
            DMLSql.CommandType = CommandType.Text

            DMLSql.CommandText = "Delete from TblPengguna where Kode_Pengguna = '" & TxtKode.Text & "' "
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

            Tabel = "SELECT * FROM TblPengguna where nama_Pengguna like '%" & TxtCari.Text & "%'"
            Grid = New OleDb.OleDbDataAdapter(Tabel, Database)
            Grid.Fill(Ds, "TblPengguna")

            Dim GridView As New DataView(Ds.Tables("TblPengguna"))
            DGV.DataSource = GridView
            DGV.Columns(0).Width = 100
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub TxtNama_TextChanged(sender As Object, e As EventArgs) Handles TxtNama.TextChanged

    End Sub

    Private Sub TxtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()

            Tampil.Connection = Database
            Tampil.CommandType = CommandType.Text

            Tampil.CommandText = "select * from TblPengguna where Kode_Pengguna = '" & TxtKode.Text & "' "
            Tampilkan = Tampil.ExecuteReader
            If Tampilkan.HasRows = True Then
                Tampilkan.Read()
                MsgBox("Data Sudah Ada")
                TxtKode.Text = Tampilkan("Kode_Pengguna")
                TxtNama.Text = Tampilkan("Nama_Pengguna")
                TxtNmUser.Text = Tampilkan("Nama_Login")
                TxtPassword.Text = Tampilkan("Password")
                CBOStatus.Text = Tampilkan("Status")
                TxtKode.Enabled = False
                TxtNama.Enabled = False
                TxtNmUser.Enabled = False
                TxtPassword.Enabled = False
                CBOStatus.Enabled = False
                BtnSimpan.Enabled = False
                BtnHapus.Enabled = True
                BtnBatal.Focus()
            Else
                BtnSimpan.Enabled = True
                BtnHapus.Enabled = False
                TxtNmUser.Focus()
            End If
        End If
    End Sub

    Private Sub TxtKode_TextChanged(sender As Object, e As EventArgs) Handles TxtKode.TextChanged

    End Sub

    Private Sub TxtNmUser_TextChanged(sender As Object, e As EventArgs) Handles TxtNmUser.TextChanged

    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Call Bersih()
    End Sub
End Class
