Public Class Form1
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxNum.Text = ""
        rdBuddy.Checked = False
        rdFriend.Checked = False
        rdNo.Checked = False
        ButtonCalculate.Enabled = False
        ButtonClear.Enabled = False
        LabelTotal.Text = ""
    End Sub

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        Dim num_customer As Integer

        Try
            num_customer = CInt(TextBoxNum.Text)
        Catch ex As Exception
            MessageBox.Show("กรุณาป้อนจำนวนลูกค้าเป็นตัวเลข", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxNum.Text = ""
            ButtonCalculate.Enabled = False
            ButtonClear.Enabled = False
            Exit Sub
        End Try
        If rdBuddy.Checked = False And rdFriend.Checked = False And rdNo.Checked = False Then
            MessageBox.Show("กรุณาป้อนจำนวนลูกค้าหรือเลือกประเภทของบัตร", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Dim totalcustomer As Double
        Dim percent As Double
        Dim total As Double
        If rdBuddy.Checked = True Then
            totalcustomer = (num_customer * 299)
            percent = (totalcustomer * 10) / 100
            total = totalcustomer - percent
            LabelTotal.Text = Format(total, "#,###.00 บาท")
        End If
        If rdFriend.Checked = True Then
            totalcustomer = (num_customer * 299)
            percent = (totalcustomer * 5) / 100
            total = totalcustomer - percent
            LabelTotal.Text = Format(total, "#,###.00 บาท")
        End If
        If rdNo.Checked = True Then
            totalcustomer = (num_customer * 299)
            total = totalcustomer
            LabelTotal.Text = Format(total, "#,###.00 บาท")
        End If

    End Sub

    Private Sub rdNo_CheckedChanged(sender As Object, e As EventArgs) Handles rdNo.CheckedChanged, rdFriend.CheckedChanged, rdBuddy.CheckedChanged

    End Sub

    Private Sub TextBoxNum_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNum.TextChanged
        If TextBoxNum.TextLength >= 1 Then
            ButtonCalculate.Enabled = True
            ButtonClear.Enabled = True
        Else
            ButtonCalculate.Enabled = False
            ButtonClear.Enabled = False
        End If
    End Sub
End Class
