Public Class OutputSettingsFrm
    Private Function booltoint(ByVal bool As Boolean) As Integer
        If bool = True Then
            booltoint = 1
        ElseIf bool = False Then
            booltoint = 0
        End If
        Return booltoint
    End Function

    Dim bool_save As Boolean = False
    Private Sub OutputSettingsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Default = 113111110111111101
        Dim int_output As String = AttackCalculator_Functions.Settings.get_output()
        cb_id.Checked = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(int_output, 1), 1) 'Bit 1
        cb_size.Checked = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(int_output, 2), 1) 'Bit 2
        Dim int_damage As Integer = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(int_output, 3), 1) 'Bit 3
        Select Case int_damage
            Case 0
                'Off
                cb_hitdamage.Checked = False
                cb_shielddamage.Checked = False
            Case 1
                'Hit
                cb_hitdamage.Checked = True
                cb_shielddamage.Checked = False
            Case 2
                'Shield
                cb_hitdamage.Checked = False
                cb_shielddamage.Checked = True
            Case 3
                'Both
                cb_hitdamage.Checked = True
                cb_shielddamage.Checked = True
        End Select
        cb_angle.Checked = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(int_output, 4), 1) 'Bit 4
        cb_kbunits.Checked = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(int_output, 5), 1) 'Bit 5
        cb_bkb.Checked = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(int_output, 6), 1) 'Bit 6
        cb_wdsk.Checked = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(int_output, 7), 1) 'Bit 7
        cb_kbg.Checked = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(int_output, 8), 1) 'Bit 8
        cb_hitlagmulti.Checked = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(int_output, 9), 1) 'Bit 9
        cb_sdimulti.Checked = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(int_output, 10), 1) 'Bit 10
        cb_Clang.Checked = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(int_output, 11), 1) 'Bit 11
        cb_CanHit.Checked = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(int_output, 12), 1) 'Bit 12
        cb_Effect.Checked = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(int_output, 13), 1) 'Bit 13
        cb_hitstun.Checked = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(int_output, 14), 1) 'Bit 14
        cb_shieldstun.Checked = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(int_output, 15), 1) 'Bit 15
        cb_hitlag.Checked = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(int_output, 16), 1) 'Bit 16
        cb_hitadvantage.Checked = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(int_output, 17), 1) 'Bit 17
        cb_shieldadvantage.Checked = Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(int_output, 18), 1) 'Bit 18
    End Sub

    Private Sub OutputSettingsFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If bool_save = True Then
            Dim int_output As String
            Dim int_bit3 As Integer
            If (cb_hitdamage.Checked = False) And (cb_shielddamage.Checked = False) Then
                'Bit2 = 0
                int_bit3 = 0
            ElseIf (cb_hitdamage.Checked = True) And (cb_shielddamage.Checked = False) Then
                'Bit2 = 1
                int_bit3 = 1
            ElseIf (cb_hitdamage.Checked = False) And (cb_shielddamage.Checked = True) Then
                'Bit2 = 2
                int_bit3 = 2
            ElseIf (cb_hitdamage.Checked = True) And (cb_shielddamage.Checked = True) Then
                'Bit2 = 3
                int_bit3 = 3
            End If
            int_output = booltoint(cb_id.Checked) & booltoint(cb_size.Checked) & int_bit3 & booltoint(cb_angle.Checked) & booltoint(cb_kbunits.Checked) & _
                booltoint(cb_bkb.Checked) & booltoint(cb_wdsk.Checked) & booltoint(cb_kbg.Checked) & booltoint(cb_hitlagmulti.Checked) & booltoint(cb_sdimulti.Checked) & _
                booltoint(cb_Clang.Checked) & booltoint(cb_CanHit.Checked) & booltoint(cb_Effect.Checked) & booltoint(cb_hitstun.Checked) & booltoint(cb_shieldstun.Checked) & _
                booltoint(cb_hitlag.Checked) & booltoint(cb_hitadvantage.Checked) & booltoint(cb_shieldadvantage.Checked)
            'MsgBox(int_output & " (" & int_output.Length & ")")
            AttackCalculator_Functions.Settings.set_output(int_output)
            'MsgBox(AttackCalculator_Functions.Settings.get_output & " (" & int_output.Length & ")")
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        bool_save = False
        Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        bool_save = True
        Close()
    End Sub
End Class