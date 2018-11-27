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
        Me.CbBold = New System.Windows.Forms.CheckBox()
        Me.CbItalic = New System.Windows.Forms.CheckBox()
        Me.CbUnderline = New System.Windows.Forms.CheckBox()
        Me.CbStrikeout = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CbBold
        '
        Me.CbBold.AutoSize = True
        Me.CbBold.Location = New System.Drawing.Point(67, 35)
        Me.CbBold.Name = "CbBold"
        Me.CbBold.Size = New System.Drawing.Size(47, 17)
        Me.CbBold.TabIndex = 0
        Me.CbBold.Text = "Bold"
        Me.CbBold.UseVisualStyleBackColor = True
        '
        'CbItalic
        '
        Me.CbItalic.AutoSize = True
        Me.CbItalic.Location = New System.Drawing.Point(173, 35)
        Me.CbItalic.Name = "CbItalic"
        Me.CbItalic.Size = New System.Drawing.Size(48, 17)
        Me.CbItalic.TabIndex = 1
        Me.CbItalic.Text = "Italic"
        Me.CbItalic.UseVisualStyleBackColor = True
        '
        'CbUnderline
        '
        Me.CbUnderline.AutoSize = True
        Me.CbUnderline.Location = New System.Drawing.Point(276, 35)
        Me.CbUnderline.Name = "CbUnderline"
        Me.CbUnderline.Size = New System.Drawing.Size(71, 17)
        Me.CbUnderline.TabIndex = 2
        Me.CbUnderline.Text = "Underline"
        Me.CbUnderline.UseVisualStyleBackColor = True
        '
        'CbStrikeout
        '
        Me.CbStrikeout.AutoSize = True
        Me.CbStrikeout.Location = New System.Drawing.Point(387, 35)
        Me.CbStrikeout.Name = "CbStrikeout"
        Me.CbStrikeout.Size = New System.Drawing.Size(68, 17)
        Me.CbStrikeout.TabIndex = 3
        Me.CbStrikeout.Text = "Strikeout"
        Me.CbStrikeout.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(67, 102)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(388, 123)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "Simple Text"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(412, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "---------------------------------------------------------------------------------" &
    "------------------------------------------------------"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 280)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CbStrikeout)
        Me.Controls.Add(Me.CbUnderline)
        Me.Controls.Add(Me.CbItalic)
        Me.Controls.Add(Me.CbBold)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CbBold As Windows.Forms.CheckBox
    Friend WithEvents CbItalic As Windows.Forms.CheckBox
    Friend WithEvents CbUnderline As Windows.Forms.CheckBox
    Friend WithEvents CbStrikeout As Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
