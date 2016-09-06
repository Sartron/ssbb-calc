Public Class KBCalc

    Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        'Every frame
        '(knockback stored into kbcomp here)
        'kbcomp = Math.max(kbcomp-0.051, 0);
        'fallcomp = Math.max(fallcomp-gravity, -terminal_velocity);
        'speed = kbcomp + fallcomp;
        'height += speed;
        'Variables
        Dim dec_gravity As Decimal = AttackCalculator_Functions.Character.get_Gravity(cb_character.SelectedIndex)
        Dim dec_terminalvelocity As Decimal = AttackCalculator_Functions.Character.get_TerminalVelocity(cb_character.SelectedIndex)
        Dim dec_knockback As Decimal = txt_knockback.Text
        Dim kbcomp As Decimal = dec_knockback
        Dim fallcomp As Decimal
        Dim speed As Decimal
        Dim height As Decimal = txt_height.Text
        'Computations
        kbcomp = Math.Max(kbcomp - 0.051, 0)
        fallcomp = Math.Max(fallcomp - dec_gravity, -dec_terminalvelocity)
        speed = kbcomp + fallcomp
        height = height + speed
        txt_calc.Text = height & ", " & speed
    End Sub

    Private Sub cb_character_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_character.SelectedIndexChanged
        txt_gravity.Text = AttackCalculator_Functions.Character.get_Gravity(cb_character.SelectedIndex)
        txt_terminalvelocity.Text = AttackCalculator_Functions.Character.get_TerminalVelocity(cb_character.SelectedIndex)
    End Sub

    Private Sub KBCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_character.SelectedIndex = 0
    End Sub
End Class