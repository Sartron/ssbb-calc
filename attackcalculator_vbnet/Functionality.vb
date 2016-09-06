Module AttackCalculator_Functions
    Public Class Character
        Shared int_Damage As Integer
        Public Shared Function get_Damage() As Integer
            get_Damage = int_Damage
            Return get_Damage
        End Function
        Public Shared Function set_Damage(ByVal dmg As Integer) As Integer
            int_Damage = dmg
            Return Nothing
        End Function

        Shared int_WeightIndex As Integer
        Public Shared Function get_WeightIndex() As Integer
            get_WeightIndex = int_WeightIndex
            Return get_WeightIndex
        End Function

        Public Shared Function set_Weight(ByVal index As Integer) As Integer
            int_WeightIndex = index
            Return Nothing
        End Function

        Public Shared Function get_Weight(ByVal index As Integer) As Integer
            'Retrieve character weight
            Dim Weight As Integer
            int_WeightIndex = index
            Select Case index
                Case 0
                    'Mario
                    Weight = 100
                Case 1
                    'Donkey Kong
                    Weight = 114
                Case 2
                    'Link
                    Weight = 104
                Case 3
                    'Samus
                    Weight = 110
                Case 4
                    'Zero Suit Samus
                    Weight = 85
                Case 5
                    'Yoshi
                    Weight = 111
                Case 6
                    'Kirby
                    Weight = 74
                Case 7
                    'Fox
                    Weight = 75
                Case 8
                    'Pikachu
                    Weight = 80
                Case 9
                    'Luigi
                    Weight = 100
                Case 10
                    'Ice Climbers
                    Weight = 88
                Case 11
                    'Captain Falcon
                    Weight = 104
                Case 12
                    'Ness
                    Weight = 94
                Case 13
                    'Bowser
                    Weight = 118
                Case 14
                    'Peach
                    Weight = 90
                Case 15
                    'Zelda
                    Weight = 90
                Case 16
                    'Sheik
                    Weight = 90
                Case 17
                    'Marth
                    Weight = 87
                Case 18
                    'Mr. Game & Watch
                    Weight = 75
                Case 19
                    'Falco
                    Weight = 80
                Case 20
                    'Ganondorf
                    Weight = 109
                Case 21
                    'Wario
                    Weight = 107
                Case 22
                    'Meta Knight
                    Weight = 70
                Case 23
                    'Pit
                    Weight = 80
                Case 24
                    'Olimar
                    Weight = 90
                Case 25
                    'Lucas
                    Weight = 80
                Case 26
                    'Diddy Kong
                    Weight = 85
                Case 27
                    'King Dedede
                    Weight = 112
                Case 28
                    'Lucario
                    Weight = 100
                Case 29
                    'Ike
                    Weight = 105
                Case 30
                    'R.O.B.
                    Weight = 106
                Case 31
                    'Jigglypuff
                    Weight = 60
                Case 32
                    'Toon Link
                    Weight = 85
                Case 33
                    'Wolf
                    Weight = 85
                Case 34
                    'Snake
                    Weight = 105
                Case 35
                    'Sonic
                    Weight = 82
                Case 36
                    'Charizard
                    Weight = 110
                Case 37
                    'Squirtle
                    Weight = 82
                Case 38
                    'Ivysaur
                    Weight = 85
                Case 39
                    'Roy
                    Weight = 85
                Case 40
                    'Mewtwo
                    Weight = 97
                    'Case 41
                    '    'Lyn
                    '    Weight = 78
                    'Case 42
                    '    'Knuckles
                    '    Weight = 95
                    'Case 43
                    '    'Isaac
                    '    Weight = 103
            End Select
            Return Weight
        End Function
        Public Shared Function get_Gravity(ByVal index As Integer) As Decimal
            'Retrieve character Gravity
            Dim Gravity As Decimal
            Select Case index
                Case 0
                    'Mario
                    Gravity = 0.095
                Case 1
                    'Donkey Kong
                    Gravity = 0.1
                Case 2
                    'Link
                    Gravity = 0.11
                Case 3
                    'Samus
                    Gravity = 0.066
                Case 4
                    'Zero Suit Samus
                    Gravity = 0.135
                Case 5
                    'Yoshi
                    Gravity = 0.093
                Case 6
                    'Kirby
                    Gravity = 0.08
                Case 7
                    'Fox
                    Gravity = 0.23
                Case 8
                    'Pikachu
                    Gravity = 0.11
                Case 9
                    'Luigi
                    Gravity = 0.069
                Case 10
                    'Ice Climbers
                    Gravity = 0.1
                Case 11
                    'Captain Falcon
                    Gravity = 0.13
                Case 12
                    'Ness
                    Gravity = 0.09
                Case 13
                    'Bowser
                    Gravity = 0.13
                Case 14
                    'Peach
                    Gravity = 0.08
                Case 15
                    'Zelda
                    Gravity = 0.073
                Case 16
                    'Sheik
                    Gravity = 0.12
                Case 17
                    'Marth
                    Gravity = 0.085
                Case 18
                    'Mr. Game & Watch
                    Gravity = 0.095
                Case 19
                    'Falco
                    Gravity = 0.17
                Case 20
                    'Ganondorf
                    Gravity = 0.13
                Case 21
                    'Wario
                    Gravity = 0.112
                Case 22
                    'Meta Knight
                    Gravity = 0.11
                Case 23
                    'Pit
                    Gravity = 0.095
                Case 24
                    'Olimar
                    Gravity = 0.09
                Case 25
                    'Lucas
                    Gravity = 0.125
                Case 26
                    'Diddy Kong
                    Gravity = 0.12
                Case 27
                    'King Dedede
                    Gravity = 0.095
                Case 28
                    'Lucario
                    Gravity = 0.125
                Case 29
                    'Ike
                    Gravity = 0.103
                Case 30
                    'R.O.B.
                    Gravity = 0.09
                Case 31
                    'Jigglypuff
                    Gravity = 0.064
                Case 32
                    'Toon Link
                    Gravity = 0.11
                Case 33
                    'Wolf
                    Gravity = 0.16
                Case 34
                    'Snake
                    Gravity = 0.098
                Case 35
                    'Sonic
                    Gravity = 0.1105
                Case 36
                    'Charizard
                    Gravity = 0.095
                Case 37
                    'Squirtle
                    Gravity = 0.126
                Case 38
                    'Ivysaur
                    Gravity = 0.075
                Case 39
                    'Roy
                    Gravity = 0.114
                Case 40
                    'Mewtwo
                    Gravity = 0.082
                    'Case 41
                    '    'Lyn
                    '    Gravity = 0.12
                    'Case 42
                    '    'Knuckles
                    '    Gravity = 0.135
                    'Case 43
                    '    'Isaac
                    '    Gravity = 0.112
            End Select
            Return Gravity
        End Function
        Public Shared Function get_TerminalVelocity(ByVal index As Integer) As Decimal
            'Retrieve character TerminalVelocity
            Dim TerminalVelocity As Decimal
            Select Case index
                Case 0
                    'Mario
                    TerminalVelocity = 1.7
                Case 1
                    'Donkey Kong
                    TerminalVelocity = 2.4
                Case 2
                    'Link
                    TerminalVelocity = 2.13
                Case 3
                    'Samus
                    TerminalVelocity = 1.4
                Case 4
                    'Zero Suit Samus
                    TerminalVelocity = 2.05
                Case 5
                    'Yoshi
                    TerminalVelocity = 1.92
                Case 6
                    'Kirby
                    TerminalVelocity = 1.6
                Case 7
                    'Fox
                    TerminalVelocity = 2.8
                Case 8
                    'Pikachu
                    TerminalVelocity = 1.9
                Case 9
                    'Luigi
                    TerminalVelocity = 1.6
                Case 10
                    'Ice Climbers
                    TerminalVelocity = 1.6
                Case 11
                    'Captain Falcon
                    TerminalVelocity = 2.9
                Case 12
                    'Ness
                    TerminalVelocity = 1.83
                Case 13
                    'Bowser
                    TerminalVelocity = 1.9
                Case 14
                    'Peach
                    TerminalVelocity = 1.5
                Case 15
                    'Zelda
                    TerminalVelocity = 1.4
                Case 16
                    'Sheik
                    TerminalVelocity = 2.13
                Case 17
                    'Marth
                    TerminalVelocity = 2.2
                Case 18
                    'Mr. Game & Watch
                    TerminalVelocity = 1.7
                Case 19
                    'Falco
                    TerminalVelocity = 3.1
                Case 20
                    'Ganondorf
                    TerminalVelocity = 2
                Case 21
                    'Wario
                    TerminalVelocity = 1.85
                Case 22
                    'Meta Knight
                    TerminalVelocity = 2.45
                Case 23
                    'Pit
                    TerminalVelocity = 1.9
                Case 24
                    'Olimar
                    TerminalVelocity = 1.9
                Case 25
                    'Lucas
                    TerminalVelocity = 2.3
                Case 26
                    'Diddy Kong
                    TerminalVelocity = 2.55
                Case 27
                    'King Dedede
                    TerminalVelocity = 2.25
                Case 28
                    'Lucario
                    TerminalVelocity = 2
                Case 29
                    'Ike
                    TerminalVelocity = 2.05
                Case 30
                    'R.O.B.
                    TerminalVelocity = 1.65
                Case 31
                    'Jigglypuff
                    TerminalVelocity = 1.3
                Case 32
                    'Toon Link
                    TerminalVelocity = 2.13
                Case 33
                    'Wolf
                    TerminalVelocity = 3.2
                Case 34
                    'Snake
                    TerminalVelocity = 2.12
                Case 35
                    'Sonic
                    TerminalVelocity = 1.9
                Case 36
                    'Charizard
                    TerminalVelocity = 1.7
                Case 37
                    'Squirtle
                    TerminalVelocity = 1.7
                Case 38
                    'Ivysaur
                    TerminalVelocity = 1.7
                Case 39
                    'Roy
                    TerminalVelocity = 2.4
                Case 40
                    'Mewtwo
                    TerminalVelocity = 1.5
                    'Case 41
                    '    'Lyn
                    '    TerminalVelocity = 2
                    'Case 42
                    '    'Knuckles
                    '    TerminalVelocity = 2.5
                    'Case 43
                    '    'Isaac
                    '    TerminalVelocity = 2.265
            End Select
            Return TerminalVelocity
        End Function
        Shared bool_crouchcancel As Boolean
        Public Shared Function set_crouchcancel(ByVal crouchcancel As Boolean) As Boolean
            bool_crouchcancel = crouchcancel
            Return Nothing
        End Function
        Public Shared Function get_crouchcancel() As Boolean
            get_crouchcancel = bool_crouchcancel
            Return get_crouchcancel
        End Function
        Shared bool_charging As Boolean
        Public Shared Function set_charging(ByVal charging As Boolean) As Boolean
            bool_charging = charging
            Return Nothing
        End Function
        Public Shared Function get_charging() As Boolean
            get_charging = bool_charging
            Return get_charging
        End Function
    End Class
    Public Class Hitbox
        Shared int_id As Integer
        Public Shared Function get_ID() As Integer
            get_ID = int_id
            Return get_ID
        End Function
        Public Shared Function set_ID(ByVal id As Integer) As Integer
            int_id = id
            Return Nothing
        End Function
        Shared dec_size As Decimal
        Public Shared Function get_size() As Decimal
            get_size = dec_size
            Return get_size
        End Function
        Public Shared Function set_size(ByVal size As Decimal) As Decimal
            dec_size = size
            Return Nothing
        End Function
        Shared int_Damage As Integer
        Public Shared Function get_damage() As Integer
            get_damage = int_Damage
            Return get_damage
        End Function
        Public Shared Function set_damage(ByVal dmg As Integer) As Integer
            int_Damage = dmg
            Return Nothing
        End Function
        Shared int_shieldDamage As Integer
        Public Shared Function get_shielddamage() As Integer
            get_shielddamage = int_shieldDamage
            Return get_shielddamage
        End Function
        Public Shared Function set_shielddamage(ByVal dmg As Integer) As Integer
            int_shieldDamage = dmg
            Return Nothing
        End Function
        Shared int_angle As Integer
        Public Shared Function get_angle() As Integer
            get_angle = int_angle
            Return get_angle
        End Function
        Public Shared Function set_angle(ByVal angle As Integer) As Integer
            int_angle = angle
            Return Nothing
        End Function
        Shared int_hitlagmultiplier As Decimal
        Public Shared Function get_hitlagmultiplier() As Decimal
            get_hitlagmultiplier = int_hitlagmultiplier
            Return get_hitlagmultiplier
        End Function
        Public Shared Function set_hitlagmultiplier(ByVal hitlagmultiplier As Decimal) As Decimal
            int_hitlagmultiplier = hitlagmultiplier
            Return Nothing
        End Function
        Shared int_sdimultiplier As Decimal
        Public Shared Function get_sdimultiplier() As Decimal
            get_sdimultiplier = int_sdimultiplier
            Return get_sdimultiplier
        End Function
        Public Shared Function set_sdimultiplier(ByVal sdimultiplier As Decimal) As Decimal
            int_sdimultiplier = sdimultiplier
            Return Nothing
        End Function
        Shared int_basekb As Integer
        Public Shared Function get_basekb() As Integer
            get_basekb = int_basekb
            Return get_basekb
        End Function
        Public Shared Function set_basekb(ByVal kb As Integer) As Integer
            int_basekb = kb
            Return Nothing
        End Function
        Shared int_kbgrowth As Integer
        Public Shared Function get_kbgrowth() As Integer
            get_kbgrowth = int_kbgrowth
            Return get_kbgrowth
        End Function
        Public Shared Function set_kbgrowth(ByVal kb As Integer) As Integer
            int_kbgrowth = kb
            Return Nothing
        End Function
        Shared int_weightkb As Integer
        Public Shared Function get_weightkb() As Integer
            get_weightkb = int_weightkb
            Return get_weightkb
        End Function
        Public Shared Function set_weightkb(ByVal kb As Integer) As Integer
            int_weightkb = kb
            Return Nothing
        End Function
        'Offensive Collision Flags
        Shared int_flags As Integer
        Public Shared Function get_flags() As Integer
            get_flags = int_flags
            Return get_flags
        End Function
        Public Shared Function set_flags(ByVal flags As Integer) As Integer
            int_flags = flags
            Return Nothing
        End Function
        Shared int_hexflags As String
        Public Shared Function get_hexflags() As String
            get_hexflags = int_hexflags
            Return get_hexflags
        End Function
        Public Shared Function set_hexflags(ByVal hexflags As String) As String
            int_hexflags = hexflags
            Return Nothing
        End Function
        Public Shared Function get_binflags() As String
            get_binflags = ConvertHexToBin(get_hexflags)
            Return get_binflags
        End Function
        'Special Offensive Collision Flags
        Shared int_specialflags As Integer
        Public Shared Function get_specialflags() As Integer
            get_specialflags = int_specialflags
            Return get_specialflags
        End Function
        Public Shared Function set_specialflags(ByVal specialflags As Integer) As Integer
            int_specialflags = specialflags
            Return Nothing
        End Function
        Shared int_hexspecialflags As String
        Public Shared Function get_hexspecialflags() As String
            get_hexspecialflags = int_hexspecialflags
            Return get_hexspecialflags
        End Function
        Public Shared Function set_hexspecialflags(ByVal hexspecialflags As String) As String
            int_hexspecialflags = hexspecialflags
            Return Nothing
        End Function
        Public Shared Function get_binspecialflags() As String
            get_binspecialflags = ConvertHexToBin(get_hexspecialflags)
            Return get_binspecialflags
        End Function
        'Conversion Functions
        Public Shared Function ConvertHexToBin(hex As String) As String
            'Hexadecimal to Binary
            If hex = Nothing Then
                Return Nothing
            Else
                Select Case hex.Length
                    Case 7
                        hex = "0" & hex
                    Case 6
                        hex = "00" & hex
                    Case 5
                        hex = "000" & hex
                    Case 4
                        hex = "0000" & hex
                    Case 3
                        hex = "00000" & hex
                    Case 2
                        hex = "000000" & hex
                    Case 1
                        hex = "0000000" & hex
                End Select
                Dim output As String
                output = ""
                For i = 1 To Len(hex)
                    Select Case Mid(hex, i, 1)
                        Case "0"
                            output = output & "0000"
                        Case "1"
                            output = output & "0001"
                        Case "2"
                            output = output & "0010"
                        Case "3"
                            output = output & "0011"
                        Case "4"
                            output = output & "0100"
                        Case "5"
                            output = output & "0101"
                        Case "6"
                            output = output & "0110"
                        Case "7"
                            output = output & "0111"
                        Case "8"
                            output = output & "1000"
                        Case "9"
                            output = output & "1001"
                        Case "A"
                            output = output & "1010"
                        Case "B"
                            output = output & "1011"
                        Case "C"
                            output = output & "1100"
                        Case "D"
                            output = output & "1101"
                        Case "E"
                            output = output & "1110"
                        Case "F"
                            output = output & "1111"
                    End Select
                Next
                Return output
            End If
        End Function

        Public Shared Function ConvertHexToDec(ByVal hex As String) As String
            'Hexadecimal to Decimal
            If hex = Nothing Then
                Return Nothing
            Else
                Return CLng("&H" & hex)
            End If
        End Function

        Public Shared Function ConvertBinToHex(ByVal bin As String) As String
            'Binary to Hexadecimal
            If Bin = Nothing Then
                Return String.Empty
            Else
                Return Convert.ToString(Convert.ToInt32(Bin, 2), 16).ToUpper
            End If
        End Function
        'Flags
        Public Shared Function get_aerialgrounded(ByVal binflags As String) As String
            'Bit 15 = Aerial
            'Bit 16 = Grounded
            'TT: 00110011110000 1 1 0010000001000011
            'TF: 00110011110000 1 0 0010000001000011
            'FT: 00110011110000 0 1 0010000001000011
            'FF: 00110011110000 0 0 0010000001000011

            Dim int_aerialbit As Integer = ConvertHexToDec(ConvertBinToHex(Right(Left(binflags, 15), 1)))
            Dim int_groundedbit As Integer = ConvertHexToDec(ConvertBinToHex(Right(Left(binflags, 16), 1)))
            'Check if both are false
            If (int_aerialbit = 1) And (int_groundedbit = 1) Then
                'Exit function, return nothing
                Return get_aerialgrounded
            End If
            'Write beginning of string
            'Check to see if either were false
            If (int_aerialbit = 0) And (int_groundedbit = 0) Then
                get_aerialgrounded = "None"
            ElseIf (int_aerialbit = 0) And (int_groundedbit = 1) Then
                get_aerialgrounded = "Grounded"
            ElseIf (int_aerialbit = 1) And (int_groundedbit = 0) Then
                get_aerialgrounded = "Aerial"
            End If
            Return get_aerialgrounded
        End Function

        Public Shared Function get_clank(ByVal binflags As String) As Boolean
            Dim clankbit As String
            clankbit = Left(binflags, 5)
            clankbit = Right(clankbit, 1)
            clankbit = ConvertBinToHex(clankbit)
            Select Case clankbit
                Case 0
                    'False
                    get_clank = False
                Case 1
                    'True
                    get_clank = True
            End Select
            Return get_clank
        End Function

        Public Shared Function get_element(ByVal binflags As String) As String
            Dim effectbit As String = ConvertHexToDec(ConvertBinToHex(Right(binflags, 5)))
            Select Case effectbit
                Case 0
                    'Normal
                    '00000
                    get_element = "Normal"
                Case 1
                    'None
                    '00001
                    get_element = "None"
                Case 2
                    'Slash
                    '00010
                    get_element = "Slash"
                Case 3
                    'Electric
                    '00011
                    get_element = "Electric"
                Case 4
                    'Freezing
                    '00100
                    get_element = "Freezing"
                Case 5
                    'Flame
                    '00101
                    get_element = "Flame"
                Case 6
                    'Coin
                    '00110
                    get_element = "Coin"
                Case 7
                    'Reverse
                    '00111
                    get_element = "Reverse"
                Case 8
                    'Slip
                    '01000
                    get_element = "Slip"
                Case 9
                    'Sleep
                    '01001
                    get_element = "Sleep"
                Case 11
                    'Bury
                    '01011
                    get_element = "Bury"
                Case 12
                    'Stun
                    '01100
                    get_element = "Stun"
                Case 13
                    'Light (Project M)
                    get_element = "Light"
                Case 14
                    'Flower
                    '
                    get_element = "Flower"
                Case 15
                    'Luigi's Green Fireballs (Project M)
                    get_element = "Green Flame"
                Case 17
                    'Grass
                    '
                    get_element = "Grass"
                Case 18
                    'Water
                    '
                    get_element = "Water"
                Case 19
                    'Darkness
                    '
                    get_element = "Darkness"
                Case 20
                    'Paralyze
                    '
                    get_element = "Paralyze"
                Case 21
                    'Aura
                    '
                    get_element = "Aura"
                Case 22
                    'Plunge
                    '
                    get_element = "Plunge"
                Case 23
                    'Down
                    '
                    get_element = "Down"
                Case 24
                    'Flinchless
                    '
                    get_element = "Flinchless"
                Case Else
                    'N/A
                    get_element = "N/A"
            End Select
            Return get_element
        End Function

        Public Shared Function get_canhit(ByVal binflags As String) As String

            Return get_canhit
        End Function
    End Class
    Public Class Calculations
        Public Shared Function calc_totaldmg() As Integer
            'Total Damage = Stale Damage + Victim's Damage
            Dim int_staledmg As Integer = Attack_Calculator.AttackCalculator_Functions.Hitbox.get_damage
            Dim int_victimdmg As Integer = AttackCalculator_Functions.Character.get_Damage
            calc_totaldmg = int_victimdmg + int_staledmg
            Return calc_totaldmg
        End Function

        Private Shared Function calc_X() As Decimal
            'Damage * Total Damage * 0.05
            calc_X = Attack_Calculator.AttackCalculator_Functions.Hitbox.get_damage * calc_totaldmg() * 0.05
            Return calc_X
        End Function

        Private Shared Function calc_Y() As Decimal
            'Total Damage * 0.1
            calc_Y = calc_totaldmg() * 0.1
            Return calc_Y
        End Function

        Private Shared Function int_Z() As Integer
            Return 1
        End Function

        Private Shared Function calc_W() As Decimal
            Dim int_weight As Integer = AttackCalculator_Functions.Character.get_Weight(AttackCalculator_Functions.Character.get_WeightIndex)
            'W = 200 / (Weight + 100)
            calc_W = 200 / (int_weight + 100)
            Return calc_W
        End Function

        Public Shared Function int_BaseKnockback() As Integer
            'Attack's Base Knockback
            Return Attack_Calculator.AttackCalculator_Functions.Hitbox.get_basekb
        End Function

        Public Shared Function int_KnockbackGrowth() As Integer
            'Attack's Knockback Growth
            Return Attack_Calculator.AttackCalculator_Functions.Hitbox.get_kbgrowth
        End Function

        Public Shared Function int_SetKnockback() As Integer
            'Weight Dependent Set Knockback
            Return Attack_Calculator.AttackCalculator_Functions.Hitbox.get_weightkb
        End Function

        Public Shared Function dec_electric() As Decimal
            Dim Element As String = AttackCalculator_Functions.Hitbox.get_element(AttackCalculator_Functions.Hitbox.get_binflags)
            Dim Electric As Boolean
            If Element = "Electric" Then
                Electric = True
            Else
                Electric = False
            End If
            Select Case Electric
                Case True
                    dec_electric = 1.5
                Case False
                    dec_electric = 1
            End Select
            Return dec_electric
        End Function

        Public Shared Function dec_CrouchCancel() As Decimal
            'Victim crouch canceling
            Select Case AttackCalculator_Functions.Character.get_crouchcancel
                Case True
                    dec_CrouchCancel = 0.66
                Case False
                    dec_CrouchCancel = 1
            End Select
            Return dec_CrouchCancel
        End Function

        Public Shared Function dec_ChargedSmash() As Decimal
            'Victim charging smash attack
            Select Case AttackCalculator_Functions.Character.get_charging
                Case True
                    dec_ChargedSmash = 1.2
                Case False
                    dec_ChargedSmash = 1
            End Select
            'dec_ChargedSmash = 1
            Return dec_ChargedSmash
        End Function

        Public Shared Function calc_WDSKPart() As Decimal
            'WDSK part = Weight Dependent Set Knockback * 10 * 0.05 + 1
            calc_WDSKPart = Attack_Calculator.AttackCalculator_Functions.Hitbox.get_weightkb * 10 * 0.05 + 1
            Return calc_WDSKPart
        End Function

        Public Shared Function calc_WDSK() As Decimal
            'Charging Smash * Crouch Cancel * (Base Knockback + 0.01 * Knockback Growth * (18 + (calc_W() * 1.4 * int_Z() * calc_WDSKPart())))
            calc_WDSK = dec_ChargedSmash() * dec_CrouchCancel() * (int_BaseKnockback() + 0.01 * int_KnockbackGrowth() * (18 + (calc_W() * 1.4 * int_Z() * calc_WDSKPart())))
            Return calc_WDSK
        End Function

        Public Shared Function calc_NormalKnockback() As Decimal
            'Charging Smash * Crouch Cancel * (Base Knockback + 0.01 * Knockback Growth * (18 + (calc_W() * 1.4 * int_Z() * (calc_X() + calc_Y()))))
            calc_NormalKnockback = dec_ChargedSmash() * dec_CrouchCancel() * (int_BaseKnockback() + 0.01 * int_KnockbackGrowth() * (18 + (calc_W() * 1.4 * int_Z() * (calc_X() + calc_Y()))))
            Return calc_NormalKnockback
        End Function

        Public Shared Function calc_Knockback() As Decimal
            If Attack_Calculator.AttackCalculator_Functions.Hitbox.get_weightkb = 0 Or Nothing Then
                calc_Knockback = calc_NormalKnockback()
            Else
                calc_Knockback = calc_WDSK()
            End If
            Return calc_Knockback
        End Function

        Public Shared Function calc_launchspeed() As Decimal
            'Melee = Knockback * 0.03
			'Brawl = Knockback / 0.03
            calc_launchspeed = calc_Knockback() * 0.03
            Return calc_launchspeed
        End Function

        Public Shared Function calc_hitstun()
            'Floor(Knockback * 0.4)
            calc_hitstun = Math.Floor(calc_Knockback() * 0.4)
            Return calc_hitstun
        End Function

        Public Shared Function calc_ShieldStun() As Decimal
            'Shieldstun = Floor((Damage + 4.45) / 2.235)
            calc_ShieldStun = Math.Floor((Attack_Calculator.AttackCalculator_Functions.Hitbox.get_damage + 4.45) / 2.235)
            Return calc_ShieldStun
        End Function

        Public Shared Function calc_victimhitlag() As Decimal
            'Floor(Crouch Cancel * Floor(Electric * Floor((Damage/3) + 3)))
            calc_victimhitlag = Math.Floor(dec_CrouchCancel() * Math.Floor(Math.Floor((Attack_Calculator.AttackCalculator_Functions.Hitbox.get_damage / 3) + 3)))
            Return calc_victimhitlag
        End Function

        Public Shared Function calc_attackerhitlag() As Integer
            ''Floor((Damage / 3) + 3)
            'calc_attackerhitlag = Math.Floor((Attack_Calculator.AttackCalculator_Functions.Hitbox.get_damage / 3) + 3)
            'Floor(Damage * 0.3333334 + 3)
            calc_attackerhitlag = Math.Floor(Attack_Calculator.AttackCalculator_Functions.Hitbox.get_damage * 0.3333334 + 3)
            Return calc_attackerhitlag
        End Function

        Public Shared Function calc_totalvictimHitlag(ByVal hitlag As Decimal) As Integer
            'Floor((Victim Hitlag * 1.5) * Hitlag Multiplier)
            'Floor(Floor((Damage * 0.3333334 + 3)) * Electric)
            If AttackCalculator_Functions.Hitbox.get_element(AttackCalculator_Functions.Hitbox.get_binflags) = "Electric" Then
                calc_totalvictimHitlag = Math.Floor((hitlag * 1.5) * Hitbox.get_hitlagmultiplier)
            Else
                calc_totalvictimHitlag = Math.Floor(hitlag * Hitbox.get_hitlagmultiplier)
            End If
            Return calc_totalvictimHitlag
        End Function

        Public Shared Function calc_totalattackerHitlag(ByVal hitlag As Decimal) As Integer
            'Floor(Attacker Hitlag * Hitlag Multiplier)
            calc_totalattackerHitlag = Math.Floor(hitlag * Hitbox.get_hitlagmultiplier)
            Return calc_totalattackerHitlag
        End Function
    End Class
    Public Class Settings
        Shared int_output As String = "113111110111111111"
        Public Shared Function get_output() As String
            get_output = int_output
            Return get_output
        End Function
        Public Shared Function set_output(ByVal output As String) As String
            'Default = 113111110111111101
            int_output = output
            Return Nothing
        End Function
        Shared int_format As Integer = 0
        Public Shared Function get_format() As Integer
            get_format = int_format
            Return get_format
        End Function
        Public Shared Sub set_format(ByVal format As Integer)
            int_format = format
        End Sub
    End Class
End Module
