Public Class BlockCalcFrm
    'Symbol list
    'Positive (x>0) = +
    'Neutral (x=0) = ±
    'Negative (x<0) = -
#Region "Textboxes"
    Private Sub txt_hitframe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_hitframe0.KeyPress
        'If txt_hitframe0.Text = Nothing AndAlso "-".Contains(e.KeyChar) Then
        '    e.Handled = True
        'End If
        'If (Not Char.IsNumber(e.KeyChar) AndAlso Not "-".Contains(e.KeyChar) AndAlso Not e.KeyChar = Microsoft.VisualBasic.Chr(Keys.Back)) Then
        '    e.Handled = True
        'End If
        'If "-".Contains(e.KeyChar) AndAlso txt_hitframe0.Text.Contains("-") Then
        '    e.Handled = True
        'End If
        If (Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Microsoft.VisualBasic.Chr(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_shieldstun0_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_shieldstun0.KeyPress
        If txt_shieldstun0.Text = Nothing AndAlso "/".Contains(e.KeyChar) Then
            e.Handled = True
        End If
        If (Not Char.IsNumber(e.KeyChar) AndAlso Not "/".Contains(e.KeyChar) AndAlso Not e.KeyChar = Microsoft.VisualBasic.Chr(Keys.Back)) Then
            e.Handled = True
        End If
        If "/".Contains(e.KeyChar) AndAlso txt_shieldstun0.Text.Contains("/") Then
            e.Handled = True
        End If
    End Sub

    Private Sub DisableNumbers(sender As Object, e As KeyPressEventArgs) Handles txt_lag0.KeyPress, txt_shieldstun1.KeyPress, txt_lag1.KeyPress, txt_hitframe2.KeyPress, txt_shieldstun2.KeyPress, txt_acwindow.KeyPress, txt_aclag.KeyPress
        If (Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Microsoft.VisualBasic.Chr(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub
#End Region
    Dim curmode As Integer = 0
    Private Function TaggedNumber(ByVal int As Integer) As String
        If int > 0 Then
            Select Case AttackCalculator_Functions.Settings.get_format
                Case 0
                    'BB Code
                    TaggedNumber = "+" & int
                Case 1
                    'Chart
                    Select Case int
                        Case Is > 3
                            '4+
                            TaggedNumber = "[COLOR=#4dff4d]+" & int & "[/COLOR]"
                        Case 1 To 3
                            '1-3
                            TaggedNumber = "[COLOR=#a6ff4d]+" & int & "[/COLOR]"
                    End Select
            End Select
        ElseIf int = 0 Then
            Select Case AttackCalculator_Functions.Settings.get_format
                Case 0
                    'BB Code
                    TaggedNumber = "±" & int
                Case 1
                    'Chart
                    '0
                    TaggedNumber = "[COLOR=#ffffff]±" & int & "[/COLOR]"
            End Select
        ElseIf int < 0 Then
            Select Case AttackCalculator_Functions.Settings.get_format
                Case 0
                    'BB Code
                    TaggedNumber = int
                Case 1
                    'Chart
                    'Convert to positive integer for comparison purposes
                    int = int * -1
                    Select Case int
                        Case 1 To 6
                            '1-6 (Normal Range)
                            'Reconvert to positive
                            int = int * -1
                            TaggedNumber = "[COLOR=#ffff4d]" & int & "[/COLOR]"
                        Case 7 To 12
                            '7-12 (Shield Grab Range)
                            int = int * -1
                            TaggedNumber = "[COLOR=#ffa64d]" & int & "[/COLOR]"
                        Case Is > 12
                            '13+ (Anything Range)
                            int = int * -1
                            TaggedNumber = "[COLOR=#ff4d4d]" & int & "[/COLOR]"
                    End Select
            End Select
        End If
        Return TaggedNumber
    End Function

    Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        Select Case curmode
            Case 0
                Dim int_hitframe As Integer = txt_hitframe0.Text
                Dim str_stun As String = txt_shieldstun0.Text
                Dim int_lag As Integer = txt_lag0.Text
                Dim int_hitlag As Integer = txt_shieldhitlag0.Text - txt_attackerhitlag0.Text
                If str_stun.Contains("/") Then
                    'Separate stuns
                    Dim Stuns() As String = txt_shieldstun0.Text.Split("/")
                    'Store stuns into variables
                    Dim int_stun1 As Integer = Stuns(0)
                    Dim int_stun2 As Integer = Stuns(1)
                    'Calculate advantages
                    Dim int_advantage1 As Integer = (int_hitframe + int_stun1 - int_lag)
                    Dim int_advantage2 As Integer = (int_hitframe + int_stun2 - int_lag)
                    txt_advantage0.Text = TaggedNumber(int_advantage1) & "/" & TaggedNumber(int_advantage2)
                Else
                    Dim int_advantage As Integer = (int_hitframe + str_stun - int_lag)
                    txt_advantage0.Text = TaggedNumber(int_advantage)
                End If
            Case 1
                Dim int_lag As Integer = txt_lag1.Text
                Dim int_stun As Integer = txt_shieldstun1.Text
                Dim int_advantage As Integer = int_stun - int_lag
                txt_advantage1.Text = TaggedNumber(int_advantage) & "/" & TaggedNumber(int_stun - Math.Floor(int_lag / 2))
            Case 2
                Dim int_hitframe As Integer = txt_hitframe2.Text
                Dim int_stun As Integer = txt_shieldstun2.Text
                Dim int_window As Integer = txt_acwindow.Text
                Dim int_lag As Integer = txt_aclag.Text
                Dim int_advantage As Integer = (int_hitframe + int_stun) - (int_window + int_lag)
                txt_advantage2.Text = TaggedNumber(int_advantage)
        End Select
    End Sub

    Private Sub btn_switch_Click(sender As Object, e As EventArgs) Handles btn_switch.Click
        Select Case curmode
            Case 0
                'Switch to L-Canceled aerial
                'Size = New Size(327, 161)
                'btn_switch.Location = New Point(233, 98)
                curmode = 1
                Panel0.Visible = False
                Panel1.Visible = True
            Case 1
                'Switch to Auto-Canceled aerial
                'Size = New Size(511, 161)
                'btn_switch.Location = New Point(417, 98)
                curmode = 2
                Panel1.Visible = False
                Panel2.Visible = True
            Case 2
                'Switch to ground moves
                'Size = New Size(646, 92)
                'btn_switch.Location = New Point(359, 98)
                curmode = 0
                Panel2.Visible = False
                Panel0.Visible = True
        End Select
    End Sub
End Class