Public Class UCGantiPass

    Sub Bersih()
        TxtPassLama.Text = ""
        TxtPassBaru.Text = ""
        TxtPassUlang.Text = ""
        TxtPassLama.Focus()
    End Sub

    Private Sub UCGantiPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtPassLama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassLama.KeyPress
        If e.KeyChar = Chr(13) Then
            If TxtPassLama.Text = "" Then MsgBox("Masukkan Password Lama", vbInformation, "Pesan") : TxtPassLama.Focus() : Exit Sub

            Call Koneksi()
            Tampil.Connection = Database
            Tampil.CommandType = CommandType.Text
            Tampil.CommandText = "select * from TblPengguna where Kode_Pengguna = '" & FrmMenuUtama.LblKodeUser.Text & "' and Password='" & _
                TxtPassLama.Text & "'"
            Tampilkan = Tampil.ExecuteReader
            If Tampilkan.HasRows = True Then
                TxtPassBaru.Focus()
            Else
                MsgBox("Password Lama Salah ", vbInformation, "Pesan")
                Call Bersih()
                TxtPassLama.Focus()
            End If
        End If
    End Sub

    Private Sub TxtPassLama_TextChanged(sender As Object, e As EventArgs) Handles TxtPassLama.TextChanged

    End Sub

    Private Sub TxtPassBaru_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassBaru.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtPassUlang.Focus()
        End If
    End Sub

    Private Sub TxtPassBaru_TextChanged(sender As Object, e As EventArgs) Handles TxtPassBaru.TextChanged

    End Sub

    Private Sub TxtPassUlang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassUlang.KeyPress
        If e.KeyChar = Chr(13) Then
            If TxtPassUlang.Text = TxtPassBaru.Text Then
                BtnGanti.Focus()
            Else
                MsgBox("Password Ulang Tidak Sama dengan Password Baru", vbInformation, "Pesan")
                TxtPassUlang.Text = ""
                TxtPassUlang.Focus()
            End If
        End If
    End Sub

    Private Sub TxtPassUlang_TextChanged(sender As Object, e As EventArgs) Handles TxtPassUlang.TextChanged

    End Sub

    Private Sub BtnGanti_Click(sender As Object, e As EventArgs) Handles BtnGanti.Click
        If TxtPassLama.Text = "" Then MsgBox("Password Lama Masih Kosong", vbInformation, "Pesan") : TxtPassLama.Focus() : Exit Sub
        If TxtPassBaru.Text = "" Then MsgBox("Password Baru Masih Kosong", vbInformation, "Pesan") : TxtPassBaru.Focus() : Exit Sub
        If TxtPassUlang.Text = "" Then MsgBox("Password Ulang Masih Kosong", vbInformation, "Pesan") : TxtPassUlang.Focus() : Exit Sub

        If TxtPassUlang.Text <> TxtPassBaru.Text Then MsgBox("Password Ulang Tidak Sama dengan Password Baru", vbInformation, "Pesan") : Exit Sub


        Call Koneksi()
        Tampil.Connection = Database
        Tampil.CommandType = CommandType.Text
        Tampil.CommandText = "select * from TblPengguna where Kode_Pengguna = '" & FrmMenuUtama.LblKodeUser.Text & "' and Password='" & _
            TxtPassLama.Text & "'"
        Tampilkan = Tampil.ExecuteReader
        If Tampilkan.HasRows = True Then
            Tampil2.Connection = Database
            Tampil2.CommandType = CommandType.Text
            Tampil2.CommandText = "Update TblPengguna set Password='" & TxtPassBaru.Text & "' where Kode_Pengguna = '" & FrmMenuUtama.LblKodeUser.Text & "'"
            Tampil2.ExecuteNonQuery()
            MsgBox("Password Berhasil Dirubah ", vbInformation, "Pesan")
            Call Bersih()
            TxtPassLama.Focus()
        Else
            MsgBox("Password Lama Salah ", vbInformation, "Pesan")
            Call Bersih()
            TxtPassLama.Focus()
        End If
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        FrmMenuUtama.UcMenuUtama1.BringToFront()
    End Sub
End Class
