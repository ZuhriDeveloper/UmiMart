Public Class FrmMenuUtama

    Sub Bersih()
        BtnHome.Enabled = False
        BtnUser.Enabled = False
        BtnBarang.Enabled = False
        BtnKelompok.Enabled = False
        BtnSatuan.Enabled = False
        BtnPemasok.Enabled = False
        BtnPelanggan.Enabled = False
        BtnLaporan.Enabled = False
        BtnPembelian.Enabled = False
        BtnPenjualan.Enabled = False
        BtnLaporan.Enabled = False
        LblKodeUser.Text = ""
        LblNamaUser.Text = ""
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
    End Sub

    Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles BtnUser.Click
        SidePanel.Height = BtnUser.Height
        SidePanel.Top = BtnUser.Top
        UcPengguna1.Bersih()
        UcPengguna1.BringToFront()
    End Sub

    Private Sub BtnPelanggan_Click(sender As Object, e As EventArgs) Handles BtnPelanggan.Click
        SidePanel.Height = BtnPelanggan.Height
        SidePanel.Top = BtnPelanggan.Top
        UcPelanggan1.Bersih()
        UcPelanggan1.BringToFront()
    End Sub

    Private Sub BtnPemasok_Click(sender As Object, e As EventArgs) Handles BtnPemasok.Click
        SidePanel.Height = BtnPemasok.Height
        SidePanel.Top = BtnPemasok.Top
        UcPemasok1.Bersih()
        UcPemasok1.BringToFront()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblJam.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub FrmMenuUtama_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.UcLogin1.TxtUser.Select()
    End Sub

    Private Sub FrmMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblHari.Text = Format(Now, "dddd, dd-MMMM-yyyy")
        Call Bersih()
        UcLogin1.BringToFront()
        Me.UcLogin1.TxtUser.Select()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        SidePanel.Height = BtnHome.Height
        SidePanel.Top = BtnHome.Top
        UcMenuUtama1.BringToFront()
    End Sub

    Private Sub BtnLaporan_Click(sender As Object, e As EventArgs) Handles BtnLaporan.Click
        SidePanel.Height = BtnLaporan.Height
        SidePanel.Top = BtnLaporan.Top
    End Sub

    Private Sub BtnKelompok_Click(sender As Object, e As EventArgs) Handles BtnKelompok.Click
        SidePanel.Height = BtnKelompok.Height
        SidePanel.Top = BtnKelompok.Top
        UcKelompok1.BringToFront()
        UcKelompok1.TxtNama.Focus()
    End Sub

    Private Sub BtnSatuan_Click(sender As Object, e As EventArgs) Handles BtnSatuan.Click
        SidePanel.Height = BtnSatuan.Height
        SidePanel.Top = BtnSatuan.Top
    End Sub

    Private Sub BtnBarang_Click(sender As Object, e As EventArgs) Handles BtnBarang.Click
        SidePanel.Height = BtnBarang.Height
        SidePanel.Top = BtnBarang.Top
        UcBarang1.BringToFront()
        Me.UcBarang1.Bersih()
    End Sub

    Private Sub UcPemasok1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnPembelian_Click(sender As Object, e As EventArgs) Handles BtnPembelian.Click
        FrmPembelian.Show()
        FrmPembelian.LblKasir.Text = LblNamaUser.Text
    End Sub

    Private Sub BtnPenjualan_Click(sender As Object, e As EventArgs) Handles BtnPenjualan.Click
        FrmPenjualan.Show()
        FrmPenjualan.LblKasir.Text = LblNamaUser.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmHistoryPenjualan.Show()
    End Sub
End Class