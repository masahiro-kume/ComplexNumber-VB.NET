<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbxA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxHanbetsu = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbxAns1 = New System.Windows.Forms.TextBox()
        Me.tbxAns2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(205, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Sample 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbxA
        '
        Me.tbxA.Location = New System.Drawing.Point(12, 83)
        Me.tbxA.Name = "tbxA"
        Me.tbxA.Size = New System.Drawing.Size(31, 19)
        Me.tbxA.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "x2 +"
        '
        'tbxB
        '
        Me.tbxB.Location = New System.Drawing.Point(82, 83)
        Me.tbxB.Name = "tbxB"
        Me.tbxB.Size = New System.Drawing.Size(33, 19)
        Me.tbxB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "x +"
        '
        'tbxC
        '
        Me.tbxC.Location = New System.Drawing.Point(148, 83)
        Me.tbxC.Name = "tbxC"
        Me.tbxC.Size = New System.Drawing.Size(35, 19)
        Me.tbxC.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "= 0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "b^2 - 4ac ="
        '
        'tbxHanbetsu
        '
        Me.tbxHanbetsu.Location = New System.Drawing.Point(83, 134)
        Me.tbxHanbetsu.Name = "tbxHanbetsu"
        Me.tbxHanbetsu.Size = New System.Drawing.Size(100, 19)
        Me.tbxHanbetsu.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "x ="
        '
        'tbxAns1
        '
        Me.tbxAns1.Location = New System.Drawing.Point(42, 169)
        Me.tbxAns1.Name = "tbxAns1"
        Me.tbxAns1.Size = New System.Drawing.Size(227, 19)
        Me.tbxAns1.TabIndex = 10
        '
        'tbxAns2
        '
        Me.tbxAns2.Location = New System.Drawing.Point(42, 194)
        Me.tbxAns2.Name = "tbxAns2"
        Me.tbxAns2.Size = New System.Drawing.Size(227, 19)
        Me.tbxAns2.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(205, 126)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Resoleve"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tbxAns2)
        Me.Controls.Add(Me.tbxAns1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbxHanbetsu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxA)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tbxA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbxB As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbxC As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbxHanbetsu As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbxAns1 As System.Windows.Forms.TextBox
    Friend WithEvents tbxAns2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
