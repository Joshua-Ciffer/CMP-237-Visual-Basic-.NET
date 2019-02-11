'Joshua Ciffer
'02/11/2018

Public Class Form1

	Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
		groupSizeTextBox.Clear()
		groupSizeTextBox.Focus()
		conventionAutographRadioButton.Checked = False
		conventionExperienceRadioBox.Checked = False
		conventionRadioButton.Checked = False
		costLabel.Text = ""
	End Sub

	Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
		If IsNumeric(groupSizeTextBox.Text) Then
			If Convert.ToInt16(groupSizeTextBox.Text) > 0 And Convert.ToInt16(groupSizeTextBox.Text) <= 20 Then
				Dim numTickets As Int16
				Dim cost As Int16
				numTickets = Convert.ToInt16(groupSizeTextBox.Text)
				If conventionExperienceRadioBox.Checked = True Then
					cost = numTickets * 380
					costLabel.Text = cost
				ElseIf conventionAutographRadioButton.Checked = True Then
					cost = numTickets * 275
					costLabel.Text = cost
				ElseIf conventionRadioButton.Checked = True Then
					cost = numTickets * 209
					costLabel.Text = cost
				Else
					MsgBox("Please select a ticket", , "Error")
				End If
			Else
				MsgBox("Please enter a valid value", , "Error")
			End If
		Else
			MsgBox("Please enter a numeric value", , "Error")
		End If
	End Sub

End Class
