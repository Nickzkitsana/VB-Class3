<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxConfirm = New System.Windows.Forms.TextBox()
        Me.TextBoxOther = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdMale = New System.Windows.Forms.RadioButton()
        Me.rdFemale = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkThai = New System.Windows.Forms.CheckBox()
        Me.chkEnglish = New System.Windows.Forms.CheckBox()
        Me.chkJapan = New System.Windows.Forms.CheckBox()
        Me.chkChina = New System.Windows.Forms.CheckBox()
        Me.chkOther = New System.Windows.Forms.CheckBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.LabelConfirm = New System.Windows.Forms.Label()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(139, 41)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(145, 20)
        Me.TextBoxUsername.TabIndex = 0
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(139, 90)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(145, 20)
        Me.TextBoxPassword.TabIndex = 1
        '
        'TextBoxConfirm
        '
        Me.TextBoxConfirm.Location = New System.Drawing.Point(139, 142)
        Me.TextBoxConfirm.Name = "TextBoxConfirm"
        Me.TextBoxConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxConfirm.Size = New System.Drawing.Size(145, 20)
        Me.TextBoxConfirm.TabIndex = 2
        '
        'TextBoxOther
        '
        Me.TextBoxOther.Location = New System.Drawing.Point(203, 378)
        Me.TextBoxOther.Name = "TextBoxOther"
        Me.TextBoxOther.Size = New System.Drawing.Size(81, 20)
        Me.TextBoxOther.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Confirm-Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Gender"
        '
        'rdMale
        '
        Me.rdMale.AutoSize = True
        Me.rdMale.Location = New System.Drawing.Point(139, 191)
        Me.rdMale.Name = "rdMale"
        Me.rdMale.Size = New System.Drawing.Size(48, 17)
        Me.rdMale.TabIndex = 8
        Me.rdMale.TabStop = True
        Me.rdMale.Text = "Male"
        Me.rdMale.UseVisualStyleBackColor = True
        '
        'rdFemale
        '
        Me.rdFemale.AutoSize = True
        Me.rdFemale.Location = New System.Drawing.Point(211, 191)
        Me.rdFemale.Name = "rdFemale"
        Me.rdFemale.Size = New System.Drawing.Size(59, 17)
        Me.rdFemale.TabIndex = 9
        Me.rdFemale.TabStop = True
        Me.rdFemale.Text = "Female"
        Me.rdFemale.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Language"
        '
        'chkThai
        '
        Me.chkThai.AutoSize = True
        Me.chkThai.Location = New System.Drawing.Point(139, 237)
        Me.chkThai.Name = "chkThai"
        Me.chkThai.Size = New System.Drawing.Size(47, 17)
        Me.chkThai.TabIndex = 11
        Me.chkThai.Text = "Thai"
        Me.chkThai.UseVisualStyleBackColor = True
        '
        'chkEnglish
        '
        Me.chkEnglish.AutoSize = True
        Me.chkEnglish.Location = New System.Drawing.Point(139, 270)
        Me.chkEnglish.Name = "chkEnglish"
        Me.chkEnglish.Size = New System.Drawing.Size(60, 17)
        Me.chkEnglish.TabIndex = 12
        Me.chkEnglish.Text = "English"
        Me.chkEnglish.UseVisualStyleBackColor = True
        '
        'chkJapan
        '
        Me.chkJapan.AutoSize = True
        Me.chkJapan.Location = New System.Drawing.Point(139, 305)
        Me.chkJapan.Name = "chkJapan"
        Me.chkJapan.Size = New System.Drawing.Size(72, 17)
        Me.chkJapan.TabIndex = 13
        Me.chkJapan.Text = "Japanese"
        Me.chkJapan.UseVisualStyleBackColor = True
        '
        'chkChina
        '
        Me.chkChina.AutoSize = True
        Me.chkChina.Location = New System.Drawing.Point(139, 342)
        Me.chkChina.Name = "chkChina"
        Me.chkChina.Size = New System.Drawing.Size(64, 17)
        Me.chkChina.TabIndex = 14
        Me.chkChina.Text = "Chinese"
        Me.chkChina.UseVisualStyleBackColor = True
        '
        'chkOther
        '
        Me.chkOther.AutoSize = True
        Me.chkOther.Location = New System.Drawing.Point(139, 380)
        Me.chkOther.Name = "chkOther"
        Me.chkOther.Size = New System.Drawing.Size(58, 17)
        Me.chkOther.TabIndex = 15
        Me.chkOther.Text = "Other :"
        Me.chkOther.UseVisualStyleBackColor = True
        '
        'LabelPassword
        '
        Me.LabelPassword.Location = New System.Drawing.Point(311, 90)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(134, 23)
        Me.LabelPassword.TabIndex = 16
        '
        'LabelConfirm
        '
        Me.LabelConfirm.Location = New System.Drawing.Point(311, 142)
        Me.LabelConfirm.Name = "LabelConfirm"
        Me.LabelConfirm.Size = New System.Drawing.Size(134, 23)
        Me.LabelConfirm.TabIndex = 17
        '
        'ButtonRegister
        '
        Me.ButtonRegister.Location = New System.Drawing.Point(38, 413)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(100, 31)
        Me.ButtonRegister.TabIndex = 18
        Me.ButtonRegister.Text = "Register"
        Me.ButtonRegister.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(184, 413)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(100, 31)
        Me.ButtonReset.TabIndex = 19
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 466)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonRegister)
        Me.Controls.Add(Me.LabelConfirm)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.chkOther)
        Me.Controls.Add(Me.chkChina)
        Me.Controls.Add(Me.chkJapan)
        Me.Controls.Add(Me.chkEnglish)
        Me.Controls.Add(Me.chkThai)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rdFemale)
        Me.Controls.Add(Me.rdMale)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxOther)
        Me.Controls.Add(Me.TextBoxConfirm)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxConfirm As TextBox
    Friend WithEvents TextBoxOther As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rdMale As RadioButton
    Friend WithEvents rdFemale As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents chkThai As CheckBox
    Friend WithEvents chkEnglish As CheckBox
    Friend WithEvents chkJapan As CheckBox
    Friend WithEvents chkChina As CheckBox
    Friend WithEvents chkOther As CheckBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents LabelConfirm As Label
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents ButtonReset As Button
End Class
