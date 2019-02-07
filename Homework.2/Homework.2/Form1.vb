'Joshua Ciffer
'02/07/2019

Public Class Form1

	Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
		Dim earthWeight, venusWeight, marsWeight As Double
		If IsNumeric(weightTextBox.Text) Then
			If Convert.ToDouble(weightTextBox.Text) >= 0 Then
				earthWeight = Convert.ToDouble(weightTextBox.Text)
				venusWeight = Convert.ToDouble(earthWeight * 0.907)
				marsWeight = Convert.ToDouble(earthWeight * 0.377)
				If venusRadioButton.Checked = False And marsRadioButton.Checked = False Then
					MsgBox("Please select a planet.", , "Select a Planet")
				ElseIf venusRadioButton.Checked = True Then
					poundsWeightLabel.Text = venusWeight
					kilogramsWeightLabel.Text = venusWeight * 0.454
				ElseIf marsRadioButton.Checked = True Then
					poundsWeightLabel.Text = marsWeight
					kilogramsWeightLabel.Text = marsWeight * 0.454
				End If
			Else
				MsgBox("Please enter a positive value for your weight.", , "Negative Input")
			End If
		Else
			MsgBox("Please enter a numeric value for your weight.", , "Non-Numeric Input")
		End If
	End Sub

	Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
		weightTextBox.Clear()
		poundsWeightLabel.Text = ""
		kilogramsWeightLabel.Text = ""
		venusRadioButton.Checked = False
		marsRadioButton.Checked = False
		weightTextBox.Focus()
	End Sub

End Class