Public Class Form1
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim operand1 As Double = Convert.ToDouble(TextBoxOperand1.Text)
        Dim operand2 As Double = Convert.ToDouble(TextBoxOperand2.Text)
        TextBoxResult.Text = (operand1 + operand2).ToString()
    End Sub

    Private Sub subtractBtn_Click(sender As Object, e As EventArgs) Handles subtractBtn.Click
        Dim operand1 As Double = Convert.ToDouble(TextBoxOperand1.Text)
        Dim operand2 As Double = Convert.ToDouble(TextBoxOperand2.Text)
        TextBoxResult.Text = (operand1 - operand2).ToString()
    End Sub

    Private Sub multiplyBtn_Click(sender As Object, e As EventArgs) Handles multiplyBtn.Click
        Dim operand1 As Double = Convert.ToDouble(TextBoxOperand1.Text)
        Dim operand2 As Double = Convert.ToDouble(TextBoxOperand2.Text)
        TextBoxResult.Text = (operand1 * operand2).ToString()
    End Sub

    Private Sub standardDivisionBtn_Click(sender As Object, e As EventArgs) Handles standardDivisionBtn.Click
        Dim operand1 As Double = Convert.ToDouble(TextBoxOperand1.Text)
        Dim operand2 As Double = Convert.ToDouble(TextBoxOperand2.Text)
        TextBoxResult.Text = (operand1 / operand2).ToString()
    End Sub

    Private Sub integerDivisionBtn_Click(sender As Object, e As EventArgs) Handles integerDivisionBtn.Click
        Dim operand1 As Double = Convert.ToDouble(TextBoxOperand1.Text)
        Dim operand2 As Double = Convert.ToDouble(TextBoxOperand2.Text)
        TextBoxResult.Text = (operand1 \ operand2).ToString()
    End Sub

    Private Sub modBtn_Click(sender As Object, e As EventArgs) Handles modBtn.Click
        Dim operand1 As Double = Convert.ToDouble(TextBoxOperand1.Text)
        Dim operand2 As Double = Convert.ToDouble(TextBoxOperand2.Text)
        TextBoxResult.Text = (operand1 Mod operand2).ToString()
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        TextBoxOperand1.Clear()
        TextBoxOperand2.Clear()
        TextBoxResult.Clear()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub
End Class
