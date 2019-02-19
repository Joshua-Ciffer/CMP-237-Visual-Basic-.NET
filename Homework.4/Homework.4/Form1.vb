Public Class Form1

	Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
		Close()
	End Sub

	Private Sub enterButton_Click_1(sender As Object, e As EventArgs) Handles enterButton.Click
		Dim score, total As Double
		Dim counter As Int16
		Dim valid As Boolean = False
		Dim strScore As String
		For counter = 1 To 7
			valid = False
			Do While valid = False
				strScore = InputBox("Enter the score for this inning", "Score")
				If IsNumeric(strScore) Then
					score = CDbl(strScore)
					If score >= 0 Then
						total += score
						valid = True
						listBox.Items.Add(strScore)
					Else
						MsgBox("Score must be greater or equal to zero.", , "Validation")
					End If
				Else
					MsgBox("Score must be numeric", , "Validation")
				End If
			Loop
		Next
		totalLabel.Text = "Total Score: " + total.ToString()
	End Sub

	Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
		totalLabel.Text = ""
		listBox.Items.Clear()
	End Sub

End Class