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
        Me.btCal = New System.Windows.Forms.Button()
        Me.btReset = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rd3 = New System.Windows.Forms.RadioButton()
        Me.rd2 = New System.Windows.Forms.RadioButton()
        Me.rd1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cb4 = New System.Windows.Forms.CheckBox()
        Me.cb3 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btCal
        '
        Me.btCal.Location = New System.Drawing.Point(16, 234)
        Me.btCal.Name = "btCal"
        Me.btCal.Size = New System.Drawing.Size(102, 37)
        Me.btCal.TabIndex = 0
        Me.btCal.Text = "สั่งอาหาร"
        Me.btCal.UseVisualStyleBackColor = True
        '
        'btReset
        '
        Me.btReset.Location = New System.Drawing.Point(205, 234)
        Me.btReset.Name = "btReset"
        Me.btReset.Size = New System.Drawing.Size(102, 37)
        Me.btReset.TabIndex = 1
        Me.btReset.Text = "ล้างข้อมูล"
        Me.btReset.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rd3)
        Me.GroupBox1.Controls.Add(Me.rd2)
        Me.GroupBox1.Controls.Add(Me.rd1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 130)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เลือกข้าว"
        '
        'rd3
        '
        Me.rd3.AutoSize = True
        Me.rd3.Location = New System.Drawing.Point(16, 68)
        Me.rd3.Name = "rd3"
        Me.rd3.Size = New System.Drawing.Size(94, 17)
        Me.rd3.TabIndex = 2
        Me.rd3.TabStop = True
        Me.rd3.Text = "พิเศษ  20 บาท"
        Me.rd3.UseVisualStyleBackColor = True
        '
        'rd2
        '
        Me.rd2.AutoSize = True
        Me.rd2.Location = New System.Drawing.Point(16, 44)
        Me.rd2.Name = "rd2"
        Me.rd2.Size = New System.Drawing.Size(88, 17)
        Me.rd2.TabIndex = 1
        Me.rd2.TabStop = True
        Me.rd2.Text = "เยอะ  15 บาท"
        Me.rd2.UseVisualStyleBackColor = True
        '
        'rd1
        '
        Me.rd1.AutoSize = True
        Me.rd1.Location = New System.Drawing.Point(16, 20)
        Me.rd1.Name = "rd1"
        Me.rd1.Size = New System.Drawing.Size(86, 17)
        Me.rd1.TabIndex = 0
        Me.rd1.TabStop = True
        Me.rd1.Text = "ปกติ  10 บาท"
        Me.rd1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb4)
        Me.GroupBox2.Controls.Add(Me.cb3)
        Me.GroupBox2.Controls.Add(Me.cb2)
        Me.GroupBox2.Controls.Add(Me.cb1)
        Me.GroupBox2.Location = New System.Drawing.Point(171, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 130)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "เลือกหน้า"
        '
        'cb4
        '
        Me.cb4.AutoSize = True
        Me.cb4.Location = New System.Drawing.Point(6, 89)
        Me.cb4.Name = "cb4"
        Me.cb4.Size = New System.Drawing.Size(107, 17)
        Me.cb4.TabIndex = 3
        Me.cb4.Text = "เนื้อสไลด์ 50 บาท"
        Me.cb4.UseVisualStyleBackColor = True
        '
        'cb3
        '
        Me.cb3.AutoSize = True
        Me.cb3.Location = New System.Drawing.Point(6, 65)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(102, 17)
        Me.cb3.TabIndex = 2
        Me.cb3.Text = "หมูสไลด์ 30 บาท"
        Me.cb3.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Location = New System.Drawing.Point(6, 42)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(101, 17)
        Me.cb2.TabIndex = 1
        Me.cb2.Text = "ใส้กรอก 20 บาท"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Location = New System.Drawing.Point(6, 19)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(97, 17)
        Me.cb1.TabIndex = 0
        Me.cb1.Text = "หมูทอด 45 บาท"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "กรอกชื่อลูกค้า"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(116, 23)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(191, 20)
        Me.TextBoxName.TabIndex = 5
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Enabled = False
        Me.TextBoxTotal.Location = New System.Drawing.Point(16, 195)
        Me.TextBoxTotal.Multiline = True
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(291, 33)
        Me.TextBoxTotal.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 294)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btReset)
        Me.Controls.Add(Me.btCal)
        Me.Name = "Form1"
        Me.Text = "Order Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btCal As Button
    Friend WithEvents btReset As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rd3 As RadioButton
    Friend WithEvents rd2 As RadioButton
    Friend WithEvents rd1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cb4 As CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxTotal As TextBox
End Class
