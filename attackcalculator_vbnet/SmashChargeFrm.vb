Public Class SmashChargeFrm

    Private Sub txt_damage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_damage.KeyPress
        If (Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Microsoft.VisualBasic.Chr(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        Dim int_chargeddamage As Integer = System.Math.Floor(txt_damage.Text * 1.3667)
        If int_chargeddamage > 999 Then
            txt_chargeddamage.Text = "999"
        Else
            txt_chargeddamage.Text = int_chargeddamage
        End If
    End Sub

    Private Sub txt_damage_TextChanged(sender As Object, e As EventArgs) Handles txt_damage.TextChanged
        If txt_damage.Text = Nothing Then
            btn_calculate.Enabled = False
        Else
            btn_calculate.Enabled = True
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub
End Class