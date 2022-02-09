Public Class UCMenuUtama

    Private Sub BtnKunci_Click(sender As Object, e As EventArgs) Handles BtnKunci.Click
        FrmMenuUtama.Bersih()
        FrmMenuUtama.UcLogin1.Bersih()
        FrmMenuUtama.UcLogin1.BringToFront()
        FrmMenuUtama.UcLogin1.TxtUser.Focus()
    End Sub

    Private Sub BtnGantiPassword_Click(sender As Object, e As EventArgs) Handles BtnGantiPassword.Click
        FrmMenuUtama.UcGantiPass1.Bersih()
        FrmMenuUtama.UcGantiPass1.BringToFront()
        FrmMenuUtama.UcGantiPass1.TxtPassLama.Focus()
    End Sub
End Class
