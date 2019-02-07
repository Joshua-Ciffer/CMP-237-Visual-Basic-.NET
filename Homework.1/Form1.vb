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

	Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox.Click
		If veniceBeachRadioButton.Checked = True Then
			pictureBox.Image = Homework._1.Resources.veniceBeach.jpg
			pictureBox.Visible = True
		ElseIf keyWestRadioButton.Checked = True Then
			pictureBox.Image = Image.FromFile(Properties.Resources.keyWest.jpg)
			pictureBox.Visible = True
		ElseIf myrtleBeachRadioButton.Checked = True Then
			pictureBox.Image = Image.FromFile("Homework.1\Resources\myrtleBeach.jpg")
			pictureBox.Visible = True
		Else
			pictureBox.Visible = False
		End If
	End Sub

End Class