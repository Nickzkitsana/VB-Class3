Public Class Register
    Private Sub TextBosPassword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword.TextChanged
        If TextBoxPassword.TextLength <= 5 Then
            LabelPassword.Text = "Quality: Low"
            LabelPassword.BackColor = Color.Red
        End If
        If TextBoxPassword.TextLength <= 10 And TextBoxPassword.TextLength > 5 Then
            LabelPassword.Text = "Quality: Medium"
            LabelPassword.BackColor = Color.OrangeRed
        End If
        If TextBoxPassword.TextLength > 10 Then
            LabelPassword.Text = "Quality: High"
            LabelPassword.BackColor = Color.Green
        End If
    End Sub

    Private Sub TextBoxConfirm_TextChanged(sender As Object, e As EventArgs) Handles TextBoxConfirm.TextChanged, TextBoxPassword.TextChanged
        Dim pass As String = TextBoxPassword.Text

        If TextBoxConfirm.Text = pass Then
            LabelConfirm.Text = "Correct"
            LabelConfirm.BackColor = Color.Green
        Else
            LabelConfirm.Text = "Incorrect"
            LabelConfirm.BackColor = Color.Red
        End If

    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        'Error
        If TextBoxUsername.Text = "" Then
            MessageBox.Show("Please insert Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If TextBoxPassword.Text = "" And TextBoxConfirm.Text = "" Then
            MessageBox.Show("Please insert Password or Confirm-Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If rdFemale.Checked = False And rdMale.Checked = False Then
            MessageBox.Show("Please choose your gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If chkChina.Checked = False And chkEnglish.Checked = False And chkJapan.Checked = False And chkOther.Checked = False And chkThai.Checked = False Then
            MessageBox.Show("Please choose language", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If chkOther.Checked = True And TextBoxOther.Text = "" Then
            MessageBox.Show("Please insert other language", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        'Gender
        Dim gender As String
        If rdFemale.Checked = True Then
            gender = "Female"
        End If
        If rdMale.Checked = True Then
            gender = "Male"
        End If

        'Language
        Dim lang As String
        If chkChina.Checked = True Then
            lang = "China"
        End If
        If chkEnglish.Checked = True Then
            lang = "English"
        End If
        If chkJapan.Checked = True Then
            lang = "Japan"
        End If
        If chkThai.Checked = True Then
            lang = "Thai"
        End If
        If chkOther.Checked = True Then
            lang = TextBoxOther.Text
        End If


    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        TextBoxPassword.Text = ""
        TextBoxOther.Text = ""
        TextBoxUsername.Text = ""
        TextBoxConfirm.Text = ""
        LabelConfirm.Text = ""
        LabelConfirm.BackColor = DefaultBackColor
        LabelPassword.Text = ""
        LabelPassword.BackColor = DefaultBackColor
        rdFemale.Checked = False
        rdMale.Checked = False
        chkChina.Checked = False
        chkEnglish.Checked = False
        chkJapan.Checked = False
        chkOther.Checked = False
        chkThai.Checked = False
        TextBoxOther.Text = ""
    End Sub
End Class
