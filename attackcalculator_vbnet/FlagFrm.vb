Public Class FlagFrm
    Function ConvertHexToBin(ByVal a As String) As String  'Converts Hex to Binary
        Dim strRet As String = String.Empty
        Dim strB As String
        For j As Integer = 0 To a.Length - 1
            strB = "0000" & Convert.ToString(Convert.ToInt32(a.Substring(j, 1), 16), 2)
            strRet &= strB.Substring(strB.Length - 4, 4) & " "
        Next
        Return strRet
    End Function

    Private Sub txt_flags_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_flags.KeyPress
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

    Private Sub btn_convert_Click(sender As Object, e As EventArgs) Handles btn_convert.Click
        txt_hexflags.Text = Hex(txt_flags.Text)
        txt_binflags.Text = ConvertHexToBin(txt_hexflags.Text)
    End Sub

    Private Sub txt_flags_TextChanged(sender As Object, e As EventArgs) Handles txt_flags.TextChanged
        If txt_flags.Text = Nothing Then
            btn_convert.Enabled = False
        Else
            btn_convert.Enabled = True
        End If
        lbl_flags.Text = "Decimal Flags - " & txt_flags.Text.Length
    End Sub

    Private Sub txt_binflags_TextChanged(sender As Object, e As EventArgs) Handles txt_binflags.TextChanged
        lbl_binflags.Text = "Binary Flags - " & txt_hexflags.Text.Length * 4
    End Sub

    Private Sub txt_hexflags_TextChanged(sender As Object, e As EventArgs) Handles txt_hexflags.TextChanged
        lbl_hexflags.Text = "Hexidecimal Flags - " & txt_hexflags.Text.Length
    End Sub

    Private Sub txt_hexflags_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_hexflags.KeyPress, txt_binflags.KeyPress
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