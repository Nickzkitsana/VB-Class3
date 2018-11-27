Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.TextLength >= 1 Then
            LbResult.Text = "Low"
            LbResult.BackColor = Color.Red
        End If
        If TextBox1.TextLength >= 7 Then
            LbResult.Text = "Medium"
            LbResult.BackColor = Color.Yellow
        End If
        If TextBox1.TextLength >= 10 Then
            LbResult.Text = "High"
            LbResult.BackColor = Color.Green
        End If
    End Sub
End Class
