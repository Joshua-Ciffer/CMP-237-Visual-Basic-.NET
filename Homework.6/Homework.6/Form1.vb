Public Class Form1

	Public Shared cities(9) As String
	Public Shared costs(9) As Double

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim fileReader As IO.StreamReader
		Dim fileLine, city, cost As String
		Dim count As Int16 = 0
		Dim fileName As String = "C:\Users\Joshua\Desktop\rentals.txt"
		If IO.File.Exists(fileName) Then
			fileReader = IO.File.OpenText(fileName)
		Else
			MsgBox("File not found")
		End If
		Do While fileReader.Peek <> -1
			fileLine = fileReader.ReadLine()
			Dim line(1) As String
			line = fileLine.Split(",")
			city = line(0)
			cost = line(1)
			listBox.Items.Add(city)
			cities(count) = city
			costs(count) = cost
			count += 1
		Loop
		fileReader.Close()
	End Sub

	Private Sub listBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox.SelectedIndexChanged
		Dim index As Int16
		index = listBox.SelectedIndex
		If index >= 0 Then
			medianCost.Text = costs(index).ToString("C0")
		End If
	End Sub

	Private Sub computeButton_Click(sender As Object, e As EventArgs) Handles computeButton.Click
		Dim total, average As Double
		For x = 0 To (costs.Length - 1)
			total += costs(x)
		Next
		average = total / 10
		averageCost.Text = average.ToString("C0")
	End Sub

	Private Sub DisplayTop10CitiesAndRentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayTop10CitiesAndRentsToolStripMenuItem.Click
		Dim topTenCities As New Form2
		topTenCities.ShowDialog()
	End Sub

	Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
		listBox.ClearSelected()
		medianCost.Text = ""
		averageCost.Text = ""
	End Sub

	Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
		Close()
	End Sub

End Class