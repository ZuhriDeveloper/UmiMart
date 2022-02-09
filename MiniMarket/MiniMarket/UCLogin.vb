Public Class UCLogin

    Sub Bersih()
        TxtUser.Text = ""
        TxtPassword.Text = ""
        TxtUser.Focus()
    End Sub

    Sub Login()
        If TxtUser.Text = "" Then TxtUser.Focus() : Exit Sub
        If TxtPassword.Text = "" Then TxtPassword.Focus() : Exit Sub

        Call Koneksi()
        Tampil.Connection = Database
        Tampil.CommandType = CommandType.Text
        Tampil.CommandText = "select * from TblPengguna where Nama_Login = '" & TxtUser.Text & "' and Password='" & _
            TxtPassword.Text & "'"
        Tampilkan = Tampil.ExecuteReader
        If Tampilkan.HasRows = True Then
            Tampilkan.Read()
            Dim Lvl_pengguna As String
            Lvl_pengguna = Tampilkan("Status")
            FrmMenuUtama.LblKodeUser.Text = Tampilkan("Kode_Pengguna")
            FrmMenuUtama.LblNamaUser.Text = Tampilkan("Nama_Pengguna")

            If Lvl_pengguna = "Kasir" Then
                FrmMenuUtama.BtnHome.Enabled = True
                FrmMenuUtama.BtnUser.Enabled = False
                FrmMenuUtama.BtnBarang.Enabled = False
                FrmMenuUtama.BtnKelompok.Enabled = False
                FrmMenuUtama.BtnSatuan.Enabled = False
                FrmMenuUtama.BtnPemasok.Enabled = False
                FrmMenuUtama.BtnPelanggan.Enabled = False
                FrmMenuUtama.BtnLaporan.Enabled = False
                FrmMenuUtama.BtnPenjualan.Enabled = True
                FrmMenuUtama.BtnPembelian.Enabled = True
                FrmMenuUtama.UcMenuUtama1.BringToFront()

            Else
                FrmMenuUtama.BtnHome.Enabled = True
                FrmMenuUtama.BtnUser.Enabled = True
                FrmMenuUtama.BtnBarang.Enabled = True
                FrmMenuUtama.BtnKelompok.Enabled = True
                FrmMenuUtama.BtnSatuan.Enabled = True
                FrmMenuUtama.BtnPemasok.Enabled = True
                FrmMenuUtama.BtnPelanggan.Enabled = True
                FrmMenuUtama.BtnLaporan.Enabled = True
                FrmMenuUtama.BtnPenjualan.Enabled = True
                FrmMenuUtama.BtnPembelian.Enabled = True
                FrmMenuUtama.UcMenuUtama1.BringToFront()
            End If
        Else
            MsgBox("User / Password Salah ", vbInformation, "Pesan")
            Call Bersih()
        End If
    End Sub

    Private Sub UCLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Bersih()
    End Sub

    Private Sub TxtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUser.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Login()
        End If
    End Sub

    Private Sub TxtUser_TextChanged(sender As Object, e As EventArgs) Handles TxtUser.TextChanged

    End Sub

    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Login()
        End If
    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged

    End Sub

    Private Sub BtnPelanggan_Click(sender As Object, e As EventArgs) Handles BtnPelanggan.Click
        Call Login()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        End
    End Sub
End Class
