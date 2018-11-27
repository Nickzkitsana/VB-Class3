Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub CbStrikeout_CheckedChanged(sender As Object, e As EventArgs) Handles CbUnderline.CheckedChanged, CbStrikeout.CheckedChanged, CbItalic.CheckedChanged, CbBold.CheckedChanged
        Dim fontstyle As FontStyle = FontStyle.Regular
        If CbBold.Checked Then
            fontstyle += FontStyle.Bold
        End If
        If CbItalic.Checked Then
            fontstyle += FontStyle.Italic
        End If
        If CbUnderline.Checked Then
            fontstyle += FontStyle.Underline
        End If
        If CbStrikeout.Checked Then
            fontstyle += FontStyle.Strikeout
        End If
        TextBox1.Font = New Font("Arial", 20, fontstyle)
    End Sub
End Class
