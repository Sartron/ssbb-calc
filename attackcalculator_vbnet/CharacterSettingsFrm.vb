Public Class CharacterSettingsFrm
    Private Sub txt_damage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_damage.KeyPress
        If (Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Microsoft.VisualBasic.Chr(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CharacterSettingsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_damage.Text = AttackCalculator_Functions.Character.get_Damage
        cb_characters.SelectedIndex = AttackCalculator_Functions.Character.get_WeightIndex
        cb_crouchcancel.Checked = AttackCalculator_Functions.Character.get_crouchcancel
        cb_charging.Checked = AttackCalculator_Functions.Character.get_charging
    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        AttackCalculator_Functions.Character.set_Damage(txt_damage.Text)
        AttackCalculator_Functions.Character.set_Weight(cb_characters.SelectedIndex)
        AttackCalculator_Functions.Character.set_crouchcancel(cb_crouchcancel.CheckState)
        AttackCalculator_Functions.Character.set_charging(cb_charging.CheckState)
        Close()
    End Sub

    Private Sub CharacterSettingsFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
End Class