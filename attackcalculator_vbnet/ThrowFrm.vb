Public Class ThrowFrm
#Region "Textboxes"
    Private Sub txt_throw_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_movesetcode.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

    Private Sub txt_throwdump_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_generatedcode.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub
#End Region
#Region "Functions"
    Private Shared Function str_Hitlag() As String
        Dim int_attackerhitlag As Integer = Attack_Calculator.AttackCalculator_Functions.Calculations.calc_totalattackerHitlag(AttackCalculator_Functions.Calculations.calc_attackerhitlag)
        Dim int_victimhitlag As Integer = Attack_Calculator.AttackCalculator_Functions.Calculations.calc_totalvictimHitlag(AttackCalculator_Functions.Calculations.calc_victimhitlag)
        If AttackCalculator_Functions.Hitbox.get_element(AttackCalculator_Functions.Hitbox.get_binflags) = "Electric" Then
            str_Hitlag = "Hitlag (Attacker/Victim/Shield)=" & int_attackerhitlag & "/" & int_victimhitlag & "/" & int_attackerhitlag
        Else
            str_Hitlag = "Hitlag (Attacker/Victim)=" & int_attackerhitlag & "/" & int_victimhitlag
        End If
        Return str_Hitlag
    End Function
#End Region
    Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        txt_max.Enabled = False
        btn_calculate.Enabled = False
        btn_calculate.Visible = False
        Dim tempArray() As String
        tempArray = txt_movesetcode.Lines
        For ctr = 0 To tempArray.GetUpperBound(0)
            If tempArray(ctr).Contains(" - ") = False Then
                If tempArray(ctr).Contains("Offensive") Then
                    Dim int_strlength As Integer = tempArray(ctr).Length - (Microsoft.VisualBasic.InStr(tempArray(ctr), "Id") - 1)
                    Dim str_hitbox As String() = tempArray(ctr).Substring(Microsoft.VisualBasic.InStr(tempArray(ctr), "Id") - 1, int_strlength).Split(",")
                    'Assign variables
                    AttackCalculator_Functions.Hitbox.set_ID(((str_hitbox(0).Substring(Microsoft.VisualBasic.InStr(str_hitbox(0), "Id=") + 2))))
                    AttackCalculator_Functions.Hitbox.set_size(((str_hitbox(8).Substring(Microsoft.VisualBasic.InStr(str_hitbox(0), "Size=") + 6))))
                    AttackCalculator_Functions.Hitbox.set_damage(((str_hitbox(2).Substring(Microsoft.VisualBasic.InStr(str_hitbox(2), "Damage=") + 6))))
                    Dim int_shielddamage As Integer = ((str_hitbox(3).Substring(Microsoft.VisualBasic.InStr(str_hitbox(3), "Shield Damage=") + 14)))
                    Dim dec_totalshielddamage As Decimal
                    'Shield Damage = ((Damage * 0.7) + (Shield Damage * 0.7))
                    If int_shielddamage > 0 Then
                        'Greater than 0
                        dec_totalshielddamage = ((AttackCalculator_Functions.Hitbox.get_damage * 0.7) + (int_shielddamage * 0.7))
                        'dec_totalshielddamage = Format(dec_totalshielddamage, "####.00")
                    Else
                        'Less than 0
                        dec_totalshielddamage = (AttackCalculator_Functions.Hitbox.get_damage * 0.7)
                        'dec_totalshielddamage = Format(dec_totalshielddamage, "####.00")
                    End If
                    AttackCalculator_Functions.Hitbox.set_angle(((str_hitbox(4).Substring(Microsoft.VisualBasic.InStr(str_hitbox(4), "Direction=") + 9))))
                    AttackCalculator_Functions.Hitbox.set_basekb(((str_hitbox(5).Substring(Microsoft.VisualBasic.InStr(str_hitbox(5), "BaseKnockback=") + 13))))
                    AttackCalculator_Functions.Hitbox.set_weightkb(((str_hitbox(6).Substring(Microsoft.VisualBasic.InStr(str_hitbox(6), "WeightKnockback=") + 15))))
                    AttackCalculator_Functions.Hitbox.set_kbgrowth(((str_hitbox(7).Substring(Microsoft.VisualBasic.InStr(str_hitbox(7), "KnockbackGrowth=") + 15))))
                    AttackCalculator_Functions.Hitbox.set_hitlagmultiplier(((str_hitbox(13).Substring(Microsoft.VisualBasic.InStr(str_hitbox(13), "HitlagMultiplier=x") + 17))))
                    AttackCalculator_Functions.Hitbox.set_sdimultiplier(((str_hitbox(14).Substring(Microsoft.VisualBasic.InStr(str_hitbox(14), "SDIMultiplier=x") + 14))))
                    AttackCalculator_Functions.Hitbox.set_flags(((str_hitbox(15).Substring(Microsoft.VisualBasic.InStr(str_hitbox(15), "Flags=") + 5))))
                    AttackCalculator_Functions.Hitbox.set_hexflags(Hex(AttackCalculator_Functions.Hitbox.get_flags))
                    'Calculate variables
                    Dim dec_knockback0 As Decimal = AttackCalculator_Functions.Calculations.calc_Knockback
                    dec_knockback0 = Format(dec_knockback0, "####.000")
                    Dim int_shieldstun As Integer = AttackCalculator_Functions.Calculations.calc_ShieldStun
                    Dim int_hitstun0 As Integer = AttackCalculator_Functions.Calculations.calc_hitstun
                    Dim int_attackerhitlag As Integer = Attack_Calculator.AttackCalculator_Functions.Calculations.calc_totalattackerHitlag(AttackCalculator_Functions.Calculations.calc_attackerhitlag)
                    Dim int_victimhitlag As Integer = Attack_Calculator.AttackCalculator_Functions.Calculations.calc_totalvictimHitlag(AttackCalculator_Functions.Calculations.calc_victimhitlag)
                    AttackCalculator_Functions.Character.set_Damage(100)
                    Dim dec_knockback100 As Decimal = AttackCalculator_Functions.Calculations.calc_Knockback
                    dec_knockback100 = Format(dec_knockback100, "####.000")
                    Dim int_hitstun100 As Integer = AttackCalculator_Functions.Calculations.calc_hitstun
                    AttackCalculator_Functions.Character.set_Damage(0)
                    Dim str_clang As String = AttackCalculator_Functions.Hitbox.get_clank(AttackCalculator_Functions.Hitbox.get_binflags)
                    If tempArray(ctr).Contains("Special") Then
                        If txt_generatedcode.Text = Nothing Then
                            txt_generatedcode.AppendText("Hitbox ID=" & AttackCalculator_Functions.Hitbox.get_ID & ", Size=" & AttackCalculator_Functions.Hitbox.get_size & ", Damage=" & AttackCalculator_Functions.Hitbox.get_damage & _
                                                     ", Shield Damage=" & dec_totalshielddamage & ", Angle=" & AttackCalculator_Functions.Hitbox.get_angle & "°" & ", Raw Knockback (0%/100%)=" & dec_knockback0 & "/" & dec_knockback100 & _
                                                     ", Base Knockback=" & AttackCalculator_Functions.Hitbox.get_basekb & ", Weight Dependent Set Knockback=" & AttackCalculator_Functions.Hitbox.get_weightkb & _
                                                     ", Knockback Growth=" & AttackCalculator_Functions.Hitbox.get_kbgrowth & "%, SDI Multiplier=" & AttackCalculator_Functions.Hitbox.get_sdimultiplier & _
                                                     "x, Clang=" & str_clang & ", Effect=" & AttackCalculator_Functions.Hitbox.get_element(AttackCalculator_Functions.Hitbox.get_binflags) & AttackCalculator_Functions.Hitbox.get_aerialgrounded(AttackCalculator_Functions.Hitbox.get_binflags) & ", Hitstun (0%/100%)=" & int_hitstun0 & "/" & int_hitstun100 & ", Shieldstun=" & int_shieldstun & ", " & str_Hitlag() & ", Advantage (First/Avg)=N/A")
                        Else
                            txt_generatedcode.AppendText(vbNewLine & "Hitbox ID=" & AttackCalculator_Functions.Hitbox.get_ID & ", Size=" & AttackCalculator_Functions.Hitbox.get_size & ", Damage=" & AttackCalculator_Functions.Hitbox.get_damage & _
                                                     ", Shield Damage=" & dec_totalshielddamage & ", Angle=" & AttackCalculator_Functions.Hitbox.get_angle & "°" & ", Raw Knockback (0%/100%)=" & dec_knockback0 & "/" & dec_knockback100 & _
                                                     ", Base Knockback=" & AttackCalculator_Functions.Hitbox.get_basekb & ", Weight Dependent Set Knockback=" & AttackCalculator_Functions.Hitbox.get_weightkb & _
                                                     ", Knockback Growth=" & AttackCalculator_Functions.Hitbox.get_kbgrowth & "%, SDI Multiplier=" & AttackCalculator_Functions.Hitbox.get_sdimultiplier & _
                                                     "x, Clang=" & str_clang & ", Effect=" & AttackCalculator_Functions.Hitbox.get_element(AttackCalculator_Functions.Hitbox.get_binflags) & AttackCalculator_Functions.Hitbox.get_aerialgrounded(AttackCalculator_Functions.Hitbox.get_binflags) & ", Hitstun (0%/100%)=" & int_hitstun0 & "/" & int_hitstun100 & ", Shieldstun=" & int_shieldstun & ", " & str_Hitlag() & ", Advantage (First/Avg)=N/A")
                        End If
                        Dim int_rehitrate As Integer = ((str_hitbox(16).Substring(Microsoft.VisualBasic.InStr(str_hitbox(16), "RehitRate=") + 9)))
                        AttackCalculator_Functions.Hitbox.set_specialflags(((str_hitbox(17).Substring(Microsoft.VisualBasic.InStr(str_hitbox(17), "SpecialFlags=") + 12))))
                        AttackCalculator_Functions.Hitbox.set_hexspecialflags(Hex(AttackCalculator_Functions.Hitbox.get_specialflags))
                        'MsgBox(AttackCalculator_Functions.Hitbox.get_canhit(AttackCalculator_Functions.Hitbox.get_binspecialflags))
                        Dim str_canhit As String = ""
                        txt_generatedcode.AppendText(", Rehit Rate=" & int_rehitrate)
                        Select Case AttackCalculator_Functions.Hitbox.get_hexspecialflags
                            '0, 2, 5 = Direction=Away from attacker
                            '1, 3 = Direction=Attacker is facing
                            '4 = Direction=Attacker is not facing
                            '6, 7 = Direction=Toward screen
                            Case "4FFFC3"
                                txt_generatedcode.AppendText(", Can Hit=(Ceilings, Floors, Walls, Players, SSE), Direction=Attacker is facing")
                            Case "4FFFC0"
                                txt_generatedcode.AppendText(", Can Hit=(Ceilings, Floors, Walls, Players, SSE), Direction=Away from attacker")
                            Case "4FFFC1"
                                txt_generatedcode.AppendText(", Can Hit=(Ceilings, Floors, Walls, Players, SSE), Direction=Attacker is facing")
                            Case "84FFFC3"
                                txt_generatedcode.AppendText(", Can Hit=(Ceilings, Floors, Walls, Players, SSE), Direction=Attacker is facing")
                            Case "84FFFD3"
                                txt_generatedcode.AppendText(", Can Hit=(Ceilings, Floors, Walls, Players, SSE), Direction=Attacker is facing")
                            Case "284FFFC3"
                                txt_generatedcode.AppendText(", Can Hit=(Ceilings, Floors, Walls, Players, SSE), Direction=Attacker is facing, No Hitlag=True")
                            Case "104FFFC0"
                                txt_generatedcode.AppendText(", Can Hit=(Ceilings, Floors, Walls, Players, SSE), Direction=Away from attacker, Ignore Invincibility=True")
                            Case "FFFC0"
                                'Zelda's Down Tilt
                                txt_generatedcode.AppendText(", Can Hit=(Ceilings, Floors, Walls, Players, SSE), Direction=Away from attacker, Shieldable=False")
                            Case "4FFFC4"
                                txt_generatedcode.AppendText(", Can Hit=(Ceilings, Floors, Walls, Players, SSE), Direction=Attacker is not facing")
                            Case "4FBDC0"
                                txt_generatedcode.AppendText(", Can Hit=(Ceilings, Floors, Players, SSE), Direction=Away from attacker")
                            Case "4FBDC3"
                                txt_generatedcode.AppendText(", Can Hit=(Ceilings, Floors, Players, SSE), Direction=Attacker is facing")
                            Case Else
                                txt_generatedcode.AppendText(", Flags=(" & AttackCalculator_Functions.Hitbox.get_specialflags & ", " & AttackCalculator_Functions.Hitbox.get_hexspecialflags & ", " & AttackCalculator_Functions.Hitbox.get_binspecialflags & ")")
                        End Select
                    Else
                        Dim int_victimdamage As Integer = 0
                        Dim int_max As Integer = txt_max.Text
                        pb_calculate.Value = 0
                        pb_calculate.Maximum = int_max + 1
                        For i = 1 To int_max + 1
                            AttackCalculator_Functions.Character.set_Damage(int_victimdamage)
                            Dim dec_knockback As Decimal = AttackCalculator_Functions.Calculations.calc_Knockback
                            Dim int_hitstun As Integer = AttackCalculator_Functions.Calculations.calc_hitstun
                            Dim dec_launchspeed As Decimal = AttackCalculator_Functions.Calculations.calc_launchspeed
                            If txt_generatedcode.Text = Nothing Then
                                txt_generatedcode.AppendText("Hitbox ID=" & AttackCalculator_Functions.Hitbox.get_ID & ", Victim Damage=" & Format(int_victimdamage, "00#") & ", Raw Knockback=" & Format(dec_knockback, "00#.000") & ", Hitstun=" & Format(int_hitstun, "00#") & ", Launch Speed=" & Format(dec_launchspeed, "0#.0000"))
                            Else
                                txt_generatedcode.AppendText(vbNewLine & "Hitbox ID=" & AttackCalculator_Functions.Hitbox.get_ID & ", Victim Damage=" & Format(int_victimdamage, "00#") & ", Raw Knockback=" & Format(dec_knockback, "00#.000") & ", Hitstun=" & Format(int_hitstun, "00#") & ", Launch Speed=" & Format(dec_launchspeed, "0#.0000"))
                            End If
                            pb_calculate.Value = pb_calculate.Value + 1
                            int_victimdamage = int_victimdamage + 1
                        Next
                    End If
                ElseIf tempArray(ctr).Contains("Specifier") Then
                    Dim int_strlength As Integer = tempArray(ctr).Length - (Microsoft.VisualBasic.InStr(tempArray(ctr), "ID") - 1)
                    Dim str_throw As String() = tempArray(ctr).Substring(Microsoft.VisualBasic.InStr(tempArray(ctr), "ID") - 1, int_strlength).Split(",")
                    'Assign variables
                    AttackCalculator_Functions.Hitbox.set_ID(((str_throw(0).Substring(Microsoft.VisualBasic.InStr(str_throw(0), "Id=") + 3))))
                    AttackCalculator_Functions.Hitbox.set_damage(((str_throw(2).Substring(Microsoft.VisualBasic.InStr(str_throw(2), "Damage=") + 6))))
                    AttackCalculator_Functions.Hitbox.set_angle(((str_throw(3).Substring(Microsoft.VisualBasic.InStr(str_throw(3), "Direction=") + 9))))
                    AttackCalculator_Functions.Hitbox.set_kbgrowth(((str_throw(4).Substring(Microsoft.VisualBasic.InStr(str_throw(4), "KnockbackGrowth=") + 15))))
                    AttackCalculator_Functions.Hitbox.set_weightkb(((str_throw(5).Substring(Microsoft.VisualBasic.InStr(str_throw(5), "WeightKnockback=") + 15))))
                    AttackCalculator_Functions.Hitbox.set_basekb(((str_throw(6).Substring(Microsoft.VisualBasic.InStr(str_throw(6), "BaseKnockback=") + 13))))
                    Dim int_victimdamage As Integer = 0
                    Dim int_max As Integer = txt_max.Text
                    pb_calculate.Value = 0
                    pb_calculate.Maximum = int_max
                    For i = 1 To int_max + 1
                        AttackCalculator_Functions.Character.set_Damage(int_victimdamage)
                        AttackCalculator_Functions.Character.set_Weight(0)
                        Dim int_hitstun As Integer = AttackCalculator_Functions.Calculations.calc_hitstun
                        Dim dec_knockback As Decimal = AttackCalculator_Functions.Calculations.calc_Knockback
                        Dim dec_launchspeed As Decimal = AttackCalculator_Functions.Calculations.calc_launchspeed
                        If txt_generatedcode.Text = Nothing Then
                            txt_generatedcode.AppendText("Victim Damage=" & Format(int_victimdamage, "00#") & ", Raw Knockback=" & Format(dec_knockback, "#.000") & ", Hitstun=" & Format(int_hitstun, "00#") & ", Launch Speed=" & Format(dec_launchspeed, "0#.0000"))
                        Else
                            txt_generatedcode.AppendText(vbNewLine & "Victim Damage=" & Format(int_victimdamage, "00#") & ", Raw Knockback=" & Format(dec_knockback, "#.000") & ", Hitstun=" & Format(int_hitstun, "00#") & ", Launch Speed=" & Format(dec_launchspeed, "0#.0000"))
                        End If
                        pb_calculate.Value = pb_calculate.Value + 1
                        int_victimdamage = int_victimdamage + 1
                    Next
                End If
            End If
        Next
        txt_max.Enabled = True
        btn_calculate.Enabled = True
        btn_calculate.Visible = True
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_generatedcode.Text = Nothing
    End Sub

    Private Sub txt_max_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_max.KeyPress
        If (Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Microsoft.VisualBasic.Chr(Keys.Back)) Then
            e.Handled = True
        End If
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        ElseIf e.KeyChar = Convert.ToChar(3) Then
            DirectCast(sender, TextBox).Copy()
            e.Handled = True
        ElseIf e.KeyChar = Convert.ToChar(22) Then
            DirectCast(sender, TextBox).Paste()
            e.Handled = True
        End If
    End Sub

End Class