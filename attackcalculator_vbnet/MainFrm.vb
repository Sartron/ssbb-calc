Public Class MainFrm
#Region "Textboxes"
    Private Sub txt_movesetcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_movesetcode.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

    Private Sub txt_generatedcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_generatedcode.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub
#End Region
#Region "BB Code String Builder"
    Private Shared Function str_ID() As String
        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(AttackCalculator_Functions.Settings.get_output, 1), 1) = "1" Then
            Select Case AttackCalculator_Functions.Settings.get_format
                Case 0
                    'BB Code
                    str_ID = "ID=" & AttackCalculator_Functions.Hitbox.get_ID & ", "
                Case 1
                    'Table
                    str_ID = AttackCalculator_Functions.Hitbox.get_ID & "|"
            End Select
        End If
        Return str_ID
    End Function

    Private Shared Function str_Size() As String
        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(AttackCalculator_Functions.Settings.get_output, 2), 1) = "1" Then
            Select Case AttackCalculator_Functions.Settings.get_format
                Case 0
                    'BB Code
                    str_Size = "Size=" & AttackCalculator_Functions.Hitbox.get_size & ", "
                Case 1
                    'Table
                    str_Size = AttackCalculator_Functions.Hitbox.get_size & "|"
            End Select
        End If
        Return str_Size
    End Function

    Private Shared Function str_Damage() As String
        Select Case Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(AttackCalculator_Functions.Settings.get_output, 3), 1)
            Case 1
                'Hit Damage
                Select Case AttackCalculator_Functions.Settings.get_format
                    Case 0
                        'BB Code
                        str_Damage = "Damage=" & AttackCalculator_Functions.Hitbox.get_damage & ", "
                    Case 1
                        'Table
                        str_Damage = AttackCalculator_Functions.Hitbox.get_damage & "|"
                End Select
            Case 2
                'Shield Damage
                Dim dec_totalshielddamage As Decimal
                'Shield Damage = ((Damage * 0.7) + (Shield Damage * 0.7))
                If AttackCalculator_Functions.Hitbox.get_shielddamage > 0 Then
                    'Greater than 0
                    dec_totalshielddamage = ((AttackCalculator_Functions.Hitbox.get_damage * 0.7) + (AttackCalculator_Functions.Hitbox.get_shielddamage * 0.7))
                Else
                    'Less than 0
                    dec_totalshielddamage = (AttackCalculator_Functions.Hitbox.get_damage * 0.7)
                End If
                Select Case AttackCalculator_Functions.Settings.get_format
                    Case 0
                        'BB Code
                        str_Damage = "Shield Damage=" & dec_totalshielddamage & ", "
                    Case 1
                        'Table
                        str_Damage = dec_totalshielddamage & "|"
                End Select
            Case 3
                'Both
                Dim dec_totalshielddamage As Decimal
                If AttackCalculator_Functions.Hitbox.get_shielddamage > 0 Then
                    'Greater than 0
                    dec_totalshielddamage = ((AttackCalculator_Functions.Hitbox.get_damage * 0.7) + (AttackCalculator_Functions.Hitbox.get_shielddamage * 0.7))
                Else
                    'Less than 0
                    dec_totalshielddamage = (AttackCalculator_Functions.Hitbox.get_damage * 0.7)
                End If
                Select Case AttackCalculator_Functions.Settings.get_format
                    Case 0
                        'BB Code
                        str_Damage = "Damage (Hit/Shield)=" & AttackCalculator_Functions.Hitbox.get_damage & "/" & dec_totalshielddamage & ", "
                    Case 1
                        'Table
                        str_Damage = AttackCalculator_Functions.Hitbox.get_damage & "/" & dec_totalshielddamage & "|"
                End Select
        End Select
        Return str_Damage
    End Function

    Private Shared Function str_Angle() As String
        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(AttackCalculator_Functions.Settings.get_output, 4), 1) = "1" Then
            Select Case AttackCalculator_Functions.Settings.get_format
                Case 0
                    'BB Code
                    str_Angle = "Angle=" & AttackCalculator_Functions.Hitbox.get_angle & "°, "
                Case 1
                    'Table
                    str_Angle = AttackCalculator_Functions.Hitbox.get_angle & "°|"
            End Select
        End If
        Return str_Angle
    End Function

    Private Shared Function str_KBUnits() As String
        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(AttackCalculator_Functions.Settings.get_output, 5), 1) = "1" Then
            AttackCalculator_Functions.Character.set_Damage(0)
            Dim int_kbunits_0 As Decimal = AttackCalculator_Functions.Calculations.calc_Knockback
            AttackCalculator_Functions.Character.set_Damage(100)
            Dim int_kbunits_100 As Decimal = AttackCalculator_Functions.Calculations.calc_Knockback
            AttackCalculator_Functions.Character.set_Damage(0)
            If int_kbunits_0 = int_kbunits_100 Then
                Select Case AttackCalculator_Functions.Settings.get_format
                    Case 0
                        'BB Code
                        str_KBUnits = "KB Units=" & int_kbunits_0 & ", "
                    Case 1
                        'Table
                        str_KBUnits = int_kbunits_0 & "|"
                End Select
            Else
                Select Case AttackCalculator_Functions.Settings.get_format
                    Case 0
                        'BB Code
                        str_KBUnits = "KB Units (0%/100%)=" & int_kbunits_0 & "/" & int_kbunits_100 & ", "
                    Case 1
                        'Table
                        str_KBUnits = int_kbunits_0 & "/" & int_kbunits_100 & "|"
                End Select
            End If
        End If
        Return str_KBUnits
    End Function

    Private Shared Function str_BKB() As String
        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(AttackCalculator_Functions.Settings.get_output, 6), 1) = "1" Then
            Select Case AttackCalculator_Functions.Settings.get_format
                Case 0
                    'BB Code
                    str_BKB = "BKB=" & AttackCalculator_Functions.Hitbox.get_basekb & ", "
                Case 1
                    'Table
                    str_BKB = AttackCalculator_Functions.Hitbox.get_basekb
            End Select
        End If
        Return str_BKB
    End Function

    Private Shared Function str_WDSK() As String
        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(AttackCalculator_Functions.Settings.get_output, 7), 1) = "1" Then
            Select Case AttackCalculator_Functions.Settings.get_format
                Case 0
                    'BB Code
                    str_WDSK = "WDSK=" & AttackCalculator_Functions.Hitbox.get_weightkb & ", "
                Case 1
                    'Table
                    str_WDSK = AttackCalculator_Functions.Hitbox.get_weightkb
            End Select
        End If
        Return str_WDSK
    End Function

    Private Shared Function str_KBG() As String
        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(AttackCalculator_Functions.Settings.get_output, 8), 1) = "1" Then
            Select Case AttackCalculator_Functions.Settings.get_format
                Case 0
                    'BB Code
                    str_KBG = "KBG=" & AttackCalculator_Functions.Hitbox.get_kbgrowth & ", "
                Case 1
                    'Table
                    str_KBG = AttackCalculator_Functions.Hitbox.get_kbgrowth
            End Select
        End If
        Return str_KBG
    End Function

    Private Shared Function str_HitlagMulti() As String
        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(AttackCalculator_Functions.Settings.get_output, 9), 1) = "1" Then
            Select Case AttackCalculator_Functions.Settings.get_format
                Case 0
                    'BB Code
                    str_HitlagMulti = "Hitlag Multiplier=" & AttackCalculator_Functions.Hitbox.get_hitlagmultiplier & "x, "
                Case 1
                    'Table
                    str_HitlagMulti = AttackCalculator_Functions.Hitbox.get_hitlagmultiplier & "x|"
            End Select
        End If
        Return str_HitlagMulti
    End Function

    Private Shared Function str_SDIMulti() As String
        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(AttackCalculator_Functions.Settings.get_output, 10), 1) = "1" Then
            Select Case AttackCalculator_Functions.Settings.get_format
                Case 0
                    'BB Code
                    str_SDIMulti = "SDI Multiplier=" & AttackCalculator_Functions.Hitbox.get_sdimultiplier & "x, "
                Case 1
                    'Table
                    str_SDIMulti = AttackCalculator_Functions.Hitbox.get_sdimultiplier & "x|"
            End Select
        End If
        Return str_SDIMulti
    End Function

    Private Shared Function str_Clang() As String
        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(AttackCalculator_Functions.Settings.get_output, 11), 1) = "1" Then
            Select Case AttackCalculator_Functions.Settings.get_format
                Case 0
                    'BB Code
                    str_Clang = "Clang=" & AttackCalculator_Functions.Hitbox.get_clank(AttackCalculator_Functions.Hitbox.get_binflags) & ", "
                Case 1
                    'Table
                    str_Clang = AttackCalculator_Functions.Hitbox.get_clank(AttackCalculator_Functions.Hitbox.get_binflags) & "|"
            End Select
        End If
        Return str_Clang
    End Function

    Private Shared Function str_CanHit() As String
        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(AttackCalculator_Functions.Settings.get_output, 12), 1) = "1" Then
            If AttackCalculator_Functions.Hitbox.get_aerialgrounded(AttackCalculator_Functions.Hitbox.get_binflags) = Nothing Then
                'Standard attack (hits both aerial and grounded)
            Else
                'Return specific target
                Select Case AttackCalculator_Functions.Settings.get_format
                    Case 0
                        'BB Code
                        str_CanHit = "Hits=" & AttackCalculator_Functions.Hitbox.get_aerialgrounded(AttackCalculator_Functions.Hitbox.get_binflags) & ", "
                    Case 1
                        'Table
                        str_CanHit = AttackCalculator_Functions.Hitbox.get_aerialgrounded(AttackCalculator_Functions.Hitbox.get_binflags) & "|"
                End Select
            End If
        End If
        Return str_CanHit
    End Function

    Private Shared Function str_Effect() As String
        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(AttackCalculator_Functions.Settings.get_output, 13), 1) = "1" Then
            Select Case AttackCalculator_Functions.Settings.get_format
                Case 0
                    'BB Code
                    str_Effect = "Effect=" & AttackCalculator_Functions.Hitbox.get_element(AttackCalculator_Functions.Hitbox.get_binflags) & ", "
                Case 1
                    'Table
                    Select Case AttackCalculator_Functions.Hitbox.get_element(AttackCalculator_Functions.Hitbox.get_binflags)
                        Case "Electric"
                            str_Effect = "[COLOR=#ffff00]" & AttackCalculator_Functions.Hitbox.get_element(AttackCalculator_Functions.Hitbox.get_binflags) & "[/COLOR]|"
                        Case Else
                            str_Effect = AttackCalculator_Functions.Hitbox.get_element(AttackCalculator_Functions.Hitbox.get_binflags) & "|"
                    End Select
            End Select
        End If
        Return str_Effect
    End Function

    Private Shared Function str_Hitstun() As String
        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(AttackCalculator_Functions.Settings.get_output, 14), 1) = "1" Then
            If AttackCalculator_Functions.Hitbox.get_aerialgrounded(AttackCalculator_Functions.Hitbox.get_binflags) = Nothing Then
                'Standard attack (hits both aerial and grounded)
                AttackCalculator_Functions.Character.set_Damage(0)
                Dim int_hitstun_0 As Integer = AttackCalculator_Functions.Calculations.calc_hitstun
                AttackCalculator_Functions.Character.set_Damage(100)
                Dim int_hitstun_100 As Integer = AttackCalculator_Functions.Calculations.calc_hitstun
                AttackCalculator_Functions.Character.set_Damage(0)
                If int_hitstun_0 = int_hitstun_100 Then
                    Select Case AttackCalculator_Functions.Settings.get_format
                        Case 0
                            'BB Code
                            str_Hitstun = "Hitstun=" & int_hitstun_0 & ", "
                        Case 1
                            'Table
                            str_Hitstun = int_hitstun_0 & "|"
                    End Select
                Else
                    Select Case AttackCalculator_Functions.Settings.get_format
                        Case 0
                            'BB Code
                            str_Hitstun = "Hitstun (0%/100%)=" & int_hitstun_0 & "/" & int_hitstun_100 & ", "
                        Case 1
                            'Table
                            str_Hitstun = int_hitstun_0 & "/" & int_hitstun_100 & "|"
                    End Select
                End If
            Else
                'Return specific target (None, Grounded, Aerial)
                Select Case AttackCalculator_Functions.Hitbox.get_aerialgrounded(AttackCalculator_Functions.Hitbox.get_binflags)
                    Case "None"
                        str_Hitstun = Nothing
                    Case Else
                        AttackCalculator_Functions.Character.set_Damage(0)
                        Dim int_hitstun_0 As Integer = AttackCalculator_Functions.Calculations.calc_hitstun
                        AttackCalculator_Functions.Character.set_Damage(100)
                        Dim int_hitstun_100 As Integer = AttackCalculator_Functions.Calculations.calc_hitstun
                        AttackCalculator_Functions.Character.set_Damage(0)
                        If int_hitstun_0 = int_hitstun_100 Then
                            Select Case AttackCalculator_Functions.Settings.get_format
                                Case 0
                                    'BB Code
                                    str_Hitstun = "Hitstun=" & int_hitstun_0 & ", "
                                Case 1
                                    'Table
                                    str_Hitstun = int_hitstun_0 & "|"
                            End Select
                        Else
                            Select Case AttackCalculator_Functions.Settings.get_format
                                Case 0
                                    'BB Code
                                    str_Hitstun = "Hitstun (0%/100%)=" & int_hitstun_0 & "/" & int_hitstun_100 & ", "
                                Case 1
                                    'Table
                                    str_Hitstun = int_hitstun_0 & "/" & int_hitstun_100 & "|"
                            End Select
                        End If
                End Select
            End If
        End If
        Return str_Hitstun
    End Function

    Private Shared Function str_Shieldstun() As String
        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(AttackCalculator_Functions.Settings.get_output, 15), 1) = "1" Then
            If AttackCalculator_Functions.Hitbox.get_aerialgrounded(AttackCalculator_Functions.Hitbox.get_binflags) = Nothing Then
                'Standard attack (hits both aerial and grounded)
                Select Case AttackCalculator_Functions.Settings.get_format
                    Case 0
                        'BB Code
                        str_Shieldstun = "Shieldstun=" & AttackCalculator_Functions.Calculations.calc_ShieldStun & ", "
                    Case 1
                        'Table
                        str_Shieldstun = AttackCalculator_Functions.Calculations.calc_ShieldStun & "|"
                End Select
            Else
                'Return specific target (None, Grounded, Aerial)
                If AttackCalculator_Functions.Hitbox.get_aerialgrounded(AttackCalculator_Functions.Hitbox.get_binflags) = "Grounded" Then
                    Select Case AttackCalculator_Functions.Settings.get_format
                        Case 0
                            'BB Code
                            str_Shieldstun = "Shieldstun=" & AttackCalculator_Functions.Calculations.calc_ShieldStun & ", "
                        Case 1
                            'Table
                            str_Shieldstun = AttackCalculator_Functions.Calculations.calc_ShieldStun & "|"
                    End Select
                Else
                    str_Shieldstun = Nothing
                End If
            End If
        End If
        Return str_Shieldstun
    End Function

    Private Shared Function str_Hitlag() As String
        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(AttackCalculator_Functions.Settings.get_output, 16), 1) = "1" Then
            If AttackCalculator_Functions.Hitbox.get_aerialgrounded(AttackCalculator_Functions.Hitbox.get_binflags) = Nothing Then
                'Standard attack (hits both aerial and grounded)
                Dim int_attackerhitlag As Integer = Attack_Calculator.AttackCalculator_Functions.Calculations.calc_totalattackerHitlag(AttackCalculator_Functions.Calculations.calc_attackerhitlag)
                Dim int_victimhitlag As Integer = Attack_Calculator.AttackCalculator_Functions.Calculations.calc_totalvictimHitlag(AttackCalculator_Functions.Calculations.calc_victimhitlag)
                If AttackCalculator_Functions.Hitbox.get_element(AttackCalculator_Functions.Hitbox.get_binflags) = "Electric" Then
                    Select Case AttackCalculator_Functions.Settings.get_format
                        Case 0
                            'BB Code
                            str_Hitlag = "Hitlag (Attacker/Victim)=" & int_attackerhitlag & "/" & int_victimhitlag & ", "
                        Case 1
                            'Table
                            Select Case AttackCalculator_Functions.Hitbox.get_element(AttackCalculator_Functions.Hitbox.get_binflags)
                                Case "Electric"
                                    str_Hitlag = int_attackerhitlag & "/[COLOR=#ffff00]" & int_victimhitlag & "[/COLOR]|"
                                Case Else
                                    str_Hitlag = int_attackerhitlag & "/" & int_victimhitlag & "|"
                            End Select
                    End Select
                Else
                    Select Case AttackCalculator_Functions.Settings.get_format
                        Case 0
                            'BB Code
                            str_Hitlag = "Hitlag=" & int_attackerhitlag & ", "
                        Case 1
                            'Table
                            str_Hitlag = int_attackerhitlag & "|"
                    End Select
                End If
            Else
                'Return specific target (None, Grounded, Aerial)
                Select Case AttackCalculator_Functions.Hitbox.get_aerialgrounded(AttackCalculator_Functions.Hitbox.get_binflags)
                    Case "None"
                        str_Hitlag = Nothing
                    Case Else
                        Dim int_attackerhitlag As Integer = Attack_Calculator.AttackCalculator_Functions.Calculations.calc_totalattackerHitlag(AttackCalculator_Functions.Calculations.calc_attackerhitlag)
                        Dim int_victimhitlag As Integer = Attack_Calculator.AttackCalculator_Functions.Calculations.calc_totalvictimHitlag(AttackCalculator_Functions.Calculations.calc_victimhitlag)
                        If AttackCalculator_Functions.Hitbox.get_element(AttackCalculator_Functions.Hitbox.get_binflags) = "Electric" Then
                            Select Case AttackCalculator_Functions.Settings.get_format
                                Case 0
                                    'BB Code
                                    str_Hitlag = "Hitlag (Attacker/Victim)=" & int_attackerhitlag & "/" & int_victimhitlag & ", "
                                Case 1
                                    'Table
                                    Select Case AttackCalculator_Functions.Hitbox.get_element(AttackCalculator_Functions.Hitbox.get_binflags)
                                        Case "Electric"
                                            str_Hitlag = int_attackerhitlag & "/[COLOR=#ffff00]" & int_victimhitlag & "[/COLOR]|"
                                        Case Else
                                            str_Hitlag = int_attackerhitlag & "/" & int_victimhitlag & "|"
                                    End Select
                            End Select
                        Else
                            Select Case AttackCalculator_Functions.Settings.get_format
                                Case 0
                                    'BB Code
                                    str_Hitlag = "Hitlag=" & int_attackerhitlag & ", "
                                Case 1
                                    'Table
                                    str_Hitlag = int_attackerhitlag & "|"
                            End Select
                        End If
                End Select
            End If
        End If
        Return str_Hitlag
    End Function

    Private Shared Function str_HitAdvantage() As String
        'If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(AttackCalculator_Functions.Settings.get_output, 13), 1) = "1" Then
        '    AttackCalculator_Functions.Character.set_Damage(0)
        '    Dim int_hitstun_0 As Integer = AttackCalculator_Functions.Calculations.calc_hitstun
        '    AttackCalculator_Functions.Character.set_Damage(100)
        '    Dim int_hitstun_100 As Integer = AttackCalculator_Functions.Calculations.calc_hitstun
        '    AttackCalculator_Functions.Character.set_Damage(0)
        '    If int_hitstun_0 = int_hitstun_100 Then
        '        str_HitAdvantage = "Hit Advantage=N/A, "
        '    Else
        '        str_HitAdvantage = "Hit Advantage (0%/100%)=N/A, "
        '    End If
        'End If
        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(AttackCalculator_Functions.Settings.get_output, 17), 1) = "1" Then
            If AttackCalculator_Functions.Hitbox.get_aerialgrounded(AttackCalculator_Functions.Hitbox.get_binflags) = Nothing Then
                'Standard attack (hits both aerial and grounded)
                AttackCalculator_Functions.Character.set_Damage(0)
                Dim int_hitstun_0 As Integer = AttackCalculator_Functions.Calculations.calc_hitstun
                AttackCalculator_Functions.Character.set_Damage(100)
                Dim int_hitstun_100 As Integer = AttackCalculator_Functions.Calculations.calc_hitstun
                AttackCalculator_Functions.Character.set_Damage(0)
                If int_hitstun_0 = int_hitstun_100 Then
                    Select Case AttackCalculator_Functions.Settings.get_format
                        Case 0
                            'BB Code
                            str_HitAdvantage = "Hit Advantage=N/A, "
                        Case 1
                            'Table
                            str_HitAdvantage = "-|"
                    End Select
                Else
                    Select Case AttackCalculator_Functions.Settings.get_format
                        Case 0
                            'BB Code
                            str_HitAdvantage = "Hit Advantage (0%/100%)=N/A, "
                        Case 1
                            'Table
                            str_HitAdvantage = "-|"
                    End Select
                End If
            Else
                'Return specific target (None, Grounded, Aerial)
                Select Case AttackCalculator_Functions.Hitbox.get_aerialgrounded(AttackCalculator_Functions.Hitbox.get_binflags)
                    Case "None"
                        str_HitAdvantage = Nothing
                    Case Else
                        AttackCalculator_Functions.Character.set_Damage(0)
                        Dim int_hitstun_0 As Integer = AttackCalculator_Functions.Calculations.calc_hitstun
                        AttackCalculator_Functions.Character.set_Damage(100)
                        Dim int_hitstun_100 As Integer = AttackCalculator_Functions.Calculations.calc_hitstun
                        AttackCalculator_Functions.Character.set_Damage(0)
                        If int_hitstun_0 = int_hitstun_100 Then
                            Select Case AttackCalculator_Functions.Settings.get_format
                                Case 0
                                    'BB Code
                                    str_HitAdvantage = "Hit Advantage=N/A, "
                                Case 1
                                    'Table
                                    str_HitAdvantage = "-|"
                            End Select
                        Else
                            Select Case AttackCalculator_Functions.Settings.get_format
                                Case 0
                                    'BB Code
                                    str_HitAdvantage = "Hit Advantage (0%/100%)=N/A, "
                                Case 1
                                    'Table
                                    str_HitAdvantage = "-|"
                            End Select
                        End If
                End Select
            End If
        End If
        Return str_HitAdvantage
    End Function

    Private Shared Function str_ShieldAdvantage() As String
        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(AttackCalculator_Functions.Settings.get_output, 18), 1) = "1" Then
            If AttackCalculator_Functions.Hitbox.get_aerialgrounded(AttackCalculator_Functions.Hitbox.get_binflags) = Nothing Then
                'Standard attack (hits both aerial and grounded)
                Select Case AttackCalculator_Functions.Settings.get_format
                    Case 0
                        'BB Code
                        str_ShieldAdvantage = "Shield Advantage=N/A, "
                    Case 1
                        'Table
                        str_ShieldAdvantage = "-|"
                End Select
            Else
                'Return specific target (None, Grounded, Aerial)
                If AttackCalculator_Functions.Hitbox.get_aerialgrounded(AttackCalculator_Functions.Hitbox.get_binflags) = "Grounded" Then
                    Select Case AttackCalculator_Functions.Settings.get_format
                        Case 0
                            'BB Code
                            str_ShieldAdvantage = "Shield Advantage=N/A, "
                        Case 1
                            'Table
                            str_ShieldAdvantage = "-|"
                    End Select
                Else
                    str_ShieldAdvantage = Nothing
                End If
            End If
        End If
        Return str_ShieldAdvantage
    End Function

    Private Shared Function str_generatedcode(ByVal Operation As String) As String
        Select Case AttackCalculator_Functions.Settings.get_format
            Case 0
                'BB Code
                Select Case Operation
                    Case "Hitbox"
                        If AttackCalculator_Functions.Hitbox.get_aerialgrounded(AttackCalculator_Functions.Hitbox.get_binflags) = "None" Then
                            str_generatedcode = str_ID() & str_Size() & str_CanHit()
                        Else
                            str_generatedcode = str_ID() & str_Size() & str_Damage() & str_Angle() & str_KBUnits() & str_BKB() & str_WDSK() & str_KBG() & str_HitlagMulti() & _
                str_SDIMulti() & str_Clang() & str_Effect() & str_CanHit() & str_Hitstun() & str_Shieldstun() & str_Hitlag() & str_HitAdvantage() & str_ShieldAdvantage()
                        End If
                        str_generatedcode = Microsoft.VisualBasic.Left(str_generatedcode, str_generatedcode.Length - 2)
                    Case "Throw"
                        str_generatedcode = str_ID() & str_Damage() & str_Angle() & str_KBUnits() & str_BKB() & str_WDSK() & str_KBG() & str_Hitstun()
                        str_generatedcode = Microsoft.VisualBasic.Left(str_generatedcode, str_generatedcode.Length - 2)
                End Select
            Case 1
                'Table
                Select Case Operation
                    Case "Hitbox"
                        If AttackCalculator_Functions.Hitbox.get_aerialgrounded(AttackCalculator_Functions.Hitbox.get_binflags) = "None" Then
                            str_generatedcode = str_ID() & str_Size() & str_CanHit()
                        Else
                            str_generatedcode = "-|" & str_ID() & str_Size() & str_Damage() & str_Angle() & str_KBUnits() & str_BKB() & "/" & str_WDSK() & "/" & str_KBG() & "|" & str_HitlagMulti() & _
                str_SDIMulti() & str_Clang() & str_Effect() & str_CanHit() & str_Hitstun() & str_Shieldstun() & str_Hitlag() & str_HitAdvantage() & str_ShieldAdvantage()
                        End If
                        str_generatedcode = Microsoft.VisualBasic.Left(str_generatedcode, str_generatedcode.Length - 1)
                    Case "Throw"
                        str_generatedcode = str_ID() & AttackCalculator_Functions.Hitbox.get_damage & "|" & str_Angle() & str_KBUnits() & str_BKB() & "/" & str_WDSK() & "/" & str_KBG() & "|" & str_Hitstun() & "BOOL "
                        str_generatedcode = Microsoft.VisualBasic.Left(str_generatedcode, str_generatedcode.Length - 1)
                End Select
        End Select
        Return str_generatedcode
    End Function
#End Region
    '#Region "Table String Builder"
    '    Private Shared Function str_table_generatedcode(ByVal Operation As String) As String
    '        '        [table=head]Hitbox Duration|ID|Size|Damage (Hit/Shield)|Angle|KB Units (0/100%)|BKB/WDSK/KBG|SDI Multiplier|Clang|Effect|Target|Hitstun (0/100%)|Shieldstun|Hitlag|Hit Advantage|Shield Advantage
    '        '-|-|-|-|-|-|-|-|-|-|-|-|-|-|-[/table]
    '        Select Case Operation
    '            Case "Hitbox"
    '                If AttackCalculator_Functions.Hitbox.get_aerialgrounded(AttackCalculator_Functions.Hitbox.get_binflags) = "None" Then
    '                    str_table_generatedcode = "-|" & str_ID() & "|" & str_Size() & "|-|-|-|-|-|-|-|-|-|-" & str_CanHit()
    '                Else
    '                    str_table_generatedcode = str_ID() & str_Size() & str_Damage() & str_Angle() & str_KBUnits() & str_BKB() & str_WDSK() & str_KBG() & str_HitlagMulti() & _
    '        str_SDIMulti() & str_Clang() & str_Effect() & str_CanHit() & str_Hitstun() & str_Shieldstun() & str_Hitlag() & str_HitAdvantage() & str_ShieldAdvantage()
    '                End If
    '                str_table_generatedcode = Microsoft.VisualBasic.Left(str_table_generatedcode, str_table_generatedcode.Length - 2)
    '            Case "Throw"
    '                str_table_generatedcode = str_ID() & str_Damage() & str_Angle() & str_KBUnits() & str_BKB() & str_WDSK() & str_KBG() & str_Hitstun()
    '                str_table_generatedcode = Microsoft.VisualBasic.Left(str_table_generatedcode, str_table_generatedcode.Length - 2)
    '        End Select
    '        Return str_table_generatedcode
    '    End Function
    '#End Region
    Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        Dim tempArray() As String
        tempArray = txt_movesetcode.Lines
        For ctr = 0 To tempArray.GetUpperBound(0)
            If tempArray(ctr).Contains("Offensive Collision:") Then
                Dim int_strlength As Integer = tempArray(ctr).Length - (Microsoft.VisualBasic.InStr(tempArray(ctr), "Id") - 1)
                Dim str_hitbox As String() = tempArray(ctr).Substring(Microsoft.VisualBasic.InStr(tempArray(ctr), "Id") - 1, int_strlength).Split(",")
                'Assign variables
                AttackCalculator_Functions.Hitbox.set_ID(str_hitbox(0).Substring(Microsoft.VisualBasic.InStr(str_hitbox(0), "Id=") + 2))
                AttackCalculator_Functions.Hitbox.set_size(str_hitbox(8).Substring(Microsoft.VisualBasic.InStr(str_hitbox(0), "Size=") + 6))
                AttackCalculator_Functions.Hitbox.set_damage(str_hitbox(2).Substring(Microsoft.VisualBasic.InStr(str_hitbox(2), "Damage=") + 6))
                AttackCalculator_Functions.Hitbox.set_shielddamage(str_hitbox(3).Substring(Microsoft.VisualBasic.InStr(str_hitbox(3), "Shield Damage=") + 14))
                AttackCalculator_Functions.Hitbox.set_angle(str_hitbox(4).Substring(Microsoft.VisualBasic.InStr(str_hitbox(4), "Direction=") + 9))
                AttackCalculator_Functions.Hitbox.set_basekb(str_hitbox(5).Substring(Microsoft.VisualBasic.InStr(str_hitbox(5), "BaseKnockback=") + 13))
                AttackCalculator_Functions.Hitbox.set_weightkb(str_hitbox(6).Substring(Microsoft.VisualBasic.InStr(str_hitbox(6), "WeightKnockback=") + 15))
                AttackCalculator_Functions.Hitbox.set_kbgrowth(str_hitbox(7).Substring(Microsoft.VisualBasic.InStr(str_hitbox(7), "KnockbackGrowth=") + 15))
                AttackCalculator_Functions.Hitbox.set_hitlagmultiplier(str_hitbox(13).Substring(Microsoft.VisualBasic.InStr(str_hitbox(13), "HitlagMultiplier=x") + 17))
                AttackCalculator_Functions.Hitbox.set_sdimultiplier(str_hitbox(14).Substring(Microsoft.VisualBasic.InStr(str_hitbox(14), "SDIMultiplier=x") + 14))
                AttackCalculator_Functions.Hitbox.set_flags(str_hitbox(15).Substring(Microsoft.VisualBasic.InStr(str_hitbox(15), "Flags=") + 5))
                AttackCalculator_Functions.Hitbox.set_hexflags(Hex(AttackCalculator_Functions.Hitbox.get_flags))
                'Calculate variables
                If txt_generatedcode.Text = Nothing Then
                    txt_generatedcode.Text = str_generatedcode("Hitbox")
                Else
                    txt_generatedcode.AppendText(vbNewLine & str_generatedcode("Hitbox"))
                End If
                If tempArray(ctr).Contains("Special") Then
                    Dim int_rehitrate As Integer = str_hitbox(16).Substring(Microsoft.VisualBasic.InStr(str_hitbox(16), "Rehit Rate=") + 10)
                    If int_rehitrate = 0 Then
                    Else
                        txt_generatedcode.AppendText(", Rehit Rate=" & int_rehitrate)
                    End If
                End If
            ElseIf tempArray(ctr).Contains("Throw Specifier:") Then
                'MsgBox("BrawlBox/PSA")
                Dim int_strlength As Integer = tempArray(ctr).Length - (Microsoft.VisualBasic.InStr(tempArray(ctr), "ID") - 1)
                Dim str_hitbox As String() = tempArray(ctr).Substring(Microsoft.VisualBasic.InStr(tempArray(ctr), "ID") - 1, int_strlength).Split(",")
                'Assign variables
                AttackCalculator_Functions.Hitbox.set_ID(str_hitbox(0).Substring(Microsoft.VisualBasic.InStr(str_hitbox(0), "ID=") + 2))
                AttackCalculator_Functions.Hitbox.set_size(0)
                AttackCalculator_Functions.Hitbox.set_damage(str_hitbox(2).Substring(Microsoft.VisualBasic.InStr(str_hitbox(2), "Damage=") + 6))
                AttackCalculator_Functions.Hitbox.set_shielddamage(0)
                AttackCalculator_Functions.Hitbox.set_angle(str_hitbox(3).Substring(Microsoft.VisualBasic.InStr(str_hitbox(3), "Direction=") + 9))
                AttackCalculator_Functions.Hitbox.set_basekb(str_hitbox(6).Substring(Microsoft.VisualBasic.InStr(str_hitbox(6), "BaseKnockback=") + 13))
                AttackCalculator_Functions.Hitbox.set_weightkb(str_hitbox(5).Substring(Microsoft.VisualBasic.InStr(str_hitbox(5), "WeightKnockback=") + 15))
                AttackCalculator_Functions.Hitbox.set_kbgrowth(str_hitbox(4).Substring(Microsoft.VisualBasic.InStr(str_hitbox(4), "KnockbackGrowth=") + 15))
                AttackCalculator_Functions.Hitbox.set_hitlagmultiplier(0)
                AttackCalculator_Functions.Hitbox.set_sdimultiplier(0)
                AttackCalculator_Functions.Hitbox.set_flags(0)
                AttackCalculator_Functions.Hitbox.set_hexflags(0)
                'Calculate variables
                If txt_generatedcode.Text = Nothing Then
                    txt_generatedcode.Text = str_generatedcode("Throw")
                Else
                    txt_generatedcode.AppendText(vbNewLine & str_generatedcode("Throw"))
                End If
            End If
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub txt_movesetcode_TextChanged(sender As Object, e As EventArgs) Handles txt_movesetcode.TextChanged
        If txt_movesetcode.Text = Nothing Then
            btn_calculate.Enabled = False
        Else
            btn_calculate.Enabled = True
        End If
    End Sub

    Private Sub VictimToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VictimToolStripMenuItem.Click
        CharacterSettingsFrm.Show()
    End Sub

    Private Sub BlockCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlockCalculatorToolStripMenuItem.Click
        BlockCalcFrm.Show()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_movesetcode.Text = Nothing
        txt_generatedcode.Text = Nothing
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        sfd_gencode.ShowDialog()
    End Sub

    Private Sub sfd_gencode_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfd_gencode.FileOk

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Program written by Sartron" & vbNewLine & "Thanks to Magus for formulas", , "About")
    End Sub

    Private Sub UsageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsageToolStripMenuItem.Click
        MsgBox("Dump BrawlBox/PSA hitboxes into the top box. Hit Process and presto!", , "Usage")
    End Sub

    Private Sub ChargedSmashCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChargedSmashCalculatorToolStripMenuItem.Click
        SmashChargeFrm.Show()
    End Sub

    Private Sub FlagAnalyzerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlagAnalyzerToolStripMenuItem.Click
        FlagFrm.Show()
    End Sub

    Private Sub KnockbackCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KnockbackCalculatorToolStripMenuItem.Click
        KBCalc.Show()
    End Sub

    Private Sub ThrowCalculationDumpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThrowCalculationDumpToolStripMenuItem.Click
        ThrowFrm.Show()
    End Sub

    Private Sub OutputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutputToolStripMenuItem.Click
        OutputSettingsFrm.Show()
    End Sub

    Private Sub DebugToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DebugToolStripMenuItem.Click

    End Sub

    Private Sub DebugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebugToolStripMenuItem.Click
        MsgBox(Microsoft.VisualBasic.Right("4.70", 1))
    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combobox_game.SelectedIndex = 0
        combobox_format.SelectedIndex = 0
    End Sub

    Private Sub combobox_format_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_format.SelectedIndexChanged
        AttackCalculator_Functions.Settings.set_format(combobox_format.SelectedIndex)
    End Sub
End Class
