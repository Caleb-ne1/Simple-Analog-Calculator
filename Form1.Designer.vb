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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxOperand1 = New System.Windows.Forms.TextBox()
        Me.TextBoxOperand2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxResult = New System.Windows.Forms.TextBox()
        Me.Operations = New System.Windows.Forms.GroupBox()
        Me.modBtn = New System.Windows.Forms.Button()
        Me.integerDivisionBtn = New System.Windows.Forms.Button()
        Me.standardDivisionBtn = New System.Windows.Forms.Button()
        Me.multiplyBtn = New System.Windows.Forms.Button()
        Me.subtractBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.Operations.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OPERAND 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "OPERAND 2:"
        '
        'TextBoxOperand1
        '
        Me.TextBoxOperand1.BackColor = System.Drawing.Color.White
        Me.TextBoxOperand1.Location = New System.Drawing.Point(85, 46)
        Me.TextBoxOperand1.Name = "TextBoxOperand1"
        Me.TextBoxOperand1.Size = New System.Drawing.Size(153, 20)
        Me.TextBoxOperand1.TabIndex = 3
        '
        'TextBoxOperand2
        '
        Me.TextBoxOperand2.BackColor = System.Drawing.Color.White
        Me.TextBoxOperand2.Location = New System.Drawing.Point(85, 87)
        Me.TextBoxOperand2.Name = "TextBoxOperand2"
        Me.TextBoxOperand2.Size = New System.Drawing.Size(153, 20)
        Me.TextBoxOperand2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(305, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "RESULTS"
        '
        'TextBoxResult
        '
        Me.TextBoxResult.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxResult.Location = New System.Drawing.Point(256, 80)
        Me.TextBoxResult.Name = "TextBoxResult"
        Me.TextBoxResult.Size = New System.Drawing.Size(153, 20)
        Me.TextBoxResult.TabIndex = 6
        '
        'Operations
        '
        Me.Operations.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Operations.Controls.Add(Me.modBtn)
        Me.Operations.Controls.Add(Me.integerDivisionBtn)
        Me.Operations.Controls.Add(Me.standardDivisionBtn)
        Me.Operations.Controls.Add(Me.multiplyBtn)
        Me.Operations.Controls.Add(Me.subtractBtn)
        Me.Operations.Controls.Add(Me.AddBtn)
        Me.Operations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Operations.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Operations.ForeColor = System.Drawing.Color.Black
        Me.Operations.Location = New System.Drawing.Point(85, 164)
        Me.Operations.Name = "Operations"
        Me.Operations.Size = New System.Drawing.Size(237, 137)
        Me.Operations.TabIndex = 7
        Me.Operations.TabStop = False
        Me.Operations.Text = "OPERATIONS"
        '
        'modBtn
        '
        Me.modBtn.BackColor = System.Drawing.Color.White
        Me.modBtn.Location = New System.Drawing.Point(147, 71)
        Me.modBtn.Name = "modBtn"
        Me.modBtn.Size = New System.Drawing.Size(63, 33)
        Me.modBtn.TabIndex = 5
        Me.modBtn.Text = "MOD"
        Me.modBtn.UseVisualStyleBackColor = False
        '
        'integerDivisionBtn
        '
        Me.integerDivisionBtn.BackColor = System.Drawing.Color.White
        Me.integerDivisionBtn.Location = New System.Drawing.Point(78, 71)
        Me.integerDivisionBtn.Name = "integerDivisionBtn"
        Me.integerDivisionBtn.Size = New System.Drawing.Size(63, 33)
        Me.integerDivisionBtn.TabIndex = 4
        Me.integerDivisionBtn.Text = "\"
        Me.integerDivisionBtn.UseVisualStyleBackColor = False
        '
        'standardDivisionBtn
        '
        Me.standardDivisionBtn.BackColor = System.Drawing.Color.White
        Me.standardDivisionBtn.Location = New System.Drawing.Point(9, 71)
        Me.standardDivisionBtn.Name = "standardDivisionBtn"
        Me.standardDivisionBtn.Size = New System.Drawing.Size(63, 33)
        Me.standardDivisionBtn.TabIndex = 3
        Me.standardDivisionBtn.Text = "/"
        Me.standardDivisionBtn.UseVisualStyleBackColor = False
        '
        'multiplyBtn
        '
        Me.multiplyBtn.BackColor = System.Drawing.Color.White
        Me.multiplyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multiplyBtn.Location = New System.Drawing.Point(147, 19)
        Me.multiplyBtn.Name = "multiplyBtn"
        Me.multiplyBtn.Size = New System.Drawing.Size(63, 33)
        Me.multiplyBtn.TabIndex = 2
        Me.multiplyBtn.Text = "*"
        Me.multiplyBtn.UseVisualStyleBackColor = False
        '
        'subtractBtn
        '
        Me.subtractBtn.BackColor = System.Drawing.Color.White
        Me.subtractBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtractBtn.Location = New System.Drawing.Point(78, 19)
        Me.subtractBtn.Name = "subtractBtn"
        Me.subtractBtn.Size = New System.Drawing.Size(63, 33)
        Me.subtractBtn.TabIndex = 1
        Me.subtractBtn.Text = "-"
        Me.subtractBtn.UseVisualStyleBackColor = False
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.White
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Location = New System.Drawing.Point(6, 19)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(66, 33)
        Me.AddBtn.TabIndex = 0
        Me.AddBtn.Text = "+"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.White
        Me.clearBtn.Location = New System.Drawing.Point(346, 183)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(63, 33)
        Me.clearBtn.TabIndex = 8
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.Color.White
        Me.exitBtn.Location = New System.Drawing.Point(346, 235)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(63, 33)
        Me.exitBtn.TabIndex = 9
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(447, 338)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.Operations)
        Me.Controls.Add(Me.TextBoxResult)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxOperand2)
        Me.Controls.Add(Me.TextBoxOperand1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Simple Analog Calc."
        Me.Operations.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxOperand1 As TextBox
    Friend WithEvents TextBoxOperand2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents Operations As GroupBox
    Friend WithEvents subtractBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents multiplyBtn As Button
    Friend WithEvents modBtn As Button
    Friend WithEvents integerDivisionBtn As Button
    Friend WithEvents standardDivisionBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents exitBtn As Button
End Class
