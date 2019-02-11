'Joshua Ciffer
'02/07/2019

Public Class Form1

	Private Sub bookTripButton_Click(sender As Object, e As EventArgs) Handles bookTripButton.Click
		If veniceBeachRadioButton.Checked = False And keyWestRadioButton.Checked = False And myrtleBeachRadioButton.Checked = False Then
			MsgBox("Please select a destination.", , "Error")
		Else
			If veniceBeachRadioButton.Checked = True Then
				MsgBox("Enjoy your trip to Venice Beach.", , "Bon Voyage")
				Close()
			ElseIf keyWestRadioButton.Checked = True Then
				MsgBox("Enjoy your trip to Key West.", , "Bon Voyage")
				Close()
			ElseIf myrtleBeachRadioButton.Checked = True Then
				MsgBox("Enjoy your trip to Myrtle Beach.", , "Bon Voyage")
				Close()
			End If
		End If
	End Sub

	Private Sub veniceBeachRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles veniceBeachRadioButton.CheckedChanged
		If veniceBeachRadioButton.Checked = True Then
			veniceBeachPictureBox.Visible = True
			myrtleBeachPictureBox.Visible = False
			keyWestPictureBox.Visible = False
		End If
	End Sub

	Private Sub keyWestRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles keyWestRadioButton.CheckedChanged
		If keyWestRadioButton.Checked = True Then
			keyWestPictureBox.Visible = True
			myrtleBeachPictureBox.Visible = False
			veniceBeachPictureBox.Visible = False
		End If
	End Sub

	Private Sub myrtleBeachRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles myrtleBeachRadioButton.CheckedChanged
		If myrtleBeachRadioButton.Checked = True Then
			myrtleBeachPictureBox.Visible = True
			keyWestPictureBox.Visible = False
			veniceBeachPictureBox.Visible = False
		End If
	End Sub

End Class