Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btCal.Click

        If TextBoxName.TextLength = 0 Then
            MessageBox.Show("คุณไม่ได้กรอกชื่อลูกค้า", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If rd1.Checked = False And rd2.Checked = False And rd3.Checked = False Then
            MessageBox.Show("คุณไม่ได้เลือกปริมาณข้าว", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If cb1.Checked = False And cb2.Checked = False And cb3.Checked = False And cb4.Checked = False Then
            MessageBox.Show("คุณไม่ได้เลือกหน้า", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim Cost As Integer = 0
        If rd1.Checked Then
            Cost += 10
        ElseIf rd2.Checked Then
            Cost += 15
        ElseIf rd3.Checked Then
            Cost += 20
        Else
            Cost += 0
        End If
        If cb1.Checked Then
            Cost += 45
        End If
        If cb2.Checked Then
            Cost += 20
        End If
        If cb3.Checked Then
            Cost += 30
        End If
        If cb4.Checked Then
            Cost += 50
        End If
        Dim fontstyle As FontStyle = FontStyle.Regular
        fontstyle += FontStyle.Bold
        TextBoxTotal.Font = New Font("Arial", 14, fontstyle)
        TextBoxTotal.Text = Format(Cost, "#,###.00") & " บาท"


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btReset.Click
        TextBoxName.Text = ""
        rd1.Checked = False
        rd2.Checked = False
        rd3.Checked = False
        cb1.Checked = False
        cb2.Checked = False
        cb3.Checked = False
        cb4.Checked = False
        TextBoxTotal.Text = ""
    End Sub
End Class
