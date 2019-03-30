Public Class Form1

	Private Sub clearFormButton_Click(sender As Object, e As EventArgs) Handles clearFormButton.Click
		comboBox.SelectedIndex = -1
		numTickets.Text = ""
		costLabel.Text = ""
		Label2.Visible = False
		numTickets.Visible = False
		ticketCostButton.Visible = False
		clearFormButton.Visible = False
		costLabel.Visible = False
	End Sub

	Private Sub comboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox.SelectedIndexChanged
		If comboBox.SelectedIndex <> -1 Then
			Label2.Visible = True
			numTickets.Visible = True
			ticketCostButton.Visible = True
			clearFormButton.Visible = True
			costLabel.Visible = True
		End If
	End Sub

	Private Sub ticketCostButton_Click(sender As Object, e As EventArgs) Handles ticketCostButton.Click
		Validate(numTickets.Text)
	End Sub

	Private Sub Validate(ByVal tickets As String)
		Try
			Calculate(Convert.ToInt16(tickets))
		Catch ex As FormatException
			MsgBox("Input needs to be an integer.", , "Validation")
			numTickets.Text = ""
		End Try
	End Sub

	Private Sub Calculate(ByVal tickets As Integer)
		Dim cost As Double
		If comboBox.SelectedIndex = 0 Then
			cost = 16 * tickets
			costLabel.Text = "$" & cost & " for the tickets"
		ElseIf comboBox.SelectedIndex = 1 Then
			cost = 27 * tickets
			costLabel.Text = "$" & cost & " for the tickets"
		End If
	End Sub

End Class