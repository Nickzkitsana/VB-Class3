<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdFriend = New System.Windows.Forms.RadioButton()
        Me.rdBuddy = New System.Windows.Forms.RadioButton()
        Me.rdNo = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "จำนวนลูกค้า"
        '
        'TextBoxNum
        '
        Me.TextBoxNum.Location = New System.Drawing.Point(120, 50)
        Me.TextBoxNum.Name = "TextBoxNum"
        Me.TextBoxNum.Size = New System.Drawing.Size(40, 20)
        Me.TextBoxNum.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "คน ต่อโตีะ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ประเภทบัตรสมาชิก"
        '
        'rdFriend
        '
        Me.rdFriend.AutoSize = True
        Me.rdFriend.Location = New System.Drawing.Point(119, 99)
        Me.rdFriend.Name = "rdFriend"
        Me.rdFriend.Size = New System.Drawing.Size(84, 17)
        Me.rdFriend.TabIndex = 4
        Me.rdFriend.TabStop = True
        Me.rdFriend.Text = "BBQ Friends"
        Me.rdFriend.UseVisualStyleBackColor = True
        '
        'rdBuddy
        '
        Me.rdBuddy.AutoSize = True
        Me.rdBuddy.Location = New System.Drawing.Point(119, 124)
        Me.rdBuddy.Name = "rdBuddy"
        Me.rdBuddy.Size = New System.Drawing.Size(80, 17)
        Me.rdBuddy.TabIndex = 5
        Me.rdBuddy.TabStop = True
        Me.rdBuddy.Text = "BBQ Buddy"
        Me.rdBuddy.UseVisualStyleBackColor = True
        '
        'rdNo
        '
        Me.rdNo.AutoSize = True
        Me.rdNo.Location = New System.Drawing.Point(119, 150)
        Me.rdNo.Name = "rdNo"
        Me.rdNo.Size = New System.Drawing.Size(97, 17)
        Me.rdNo.TabIndex = 6
        Me.rdNo.TabStop = True
        Me.rdNo.Text = "ไม่มีบัตรสมาชิก"
        Me.rdNo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ราคารวม"
        '
        'LabelTotal
        '
        Me.LabelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelTotal.Location = New System.Drawing.Point(122, 193)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(131, 26)
        Me.LabelTotal.TabIndex = 8
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Enabled = False
        Me.ButtonCalculate.Location = New System.Drawing.Point(19, 251)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(118, 41)
        Me.ButtonCalculate.TabIndex = 9
        Me.ButtonCalculate.Text = "คำนวณ"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Enabled = False
        Me.ButtonClear.Location = New System.Drawing.Point(147, 251)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(118, 41)
        Me.ButtonClear.TabIndex = 10
        Me.ButtonClear.Text = "ล้างข้อมูล"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(286, 321)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rdNo)
        Me.Controls.Add(Me.rdBuddy)
        Me.Controls.Add(Me.rdFriend)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxNum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "BBQ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rdFriend As RadioButton
    Friend WithEvents rdBuddy As RadioButton
    Friend WithEvents rdNo As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents ButtonClear As Button
End Class
