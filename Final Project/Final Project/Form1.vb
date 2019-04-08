Public Class Form1

	'Closes the program
	Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
		Close()
	End Sub

	'Resets all of the form controls
	Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
		firstNameTextBox.Text = ""
		lastNameTextBox.Text = ""
		cityTextBox.Text = ""
		squareFootageTextBox.Text = ""
		oneBedroomRadioButton.Checked = False
		twoBedroomRadioButton.Checked = False
		threeBedroomRadioButton.Checked = False
		fourBedroomRadioButton.Checked = False
		oneCarGarageRadioButton.Checked = False
		twoCarGarageRadioButton.Checked = False
		attachedGarageRadioButton.Checked = False
		oneBathroomRadioButton.Checked = False
		twoBathroomRadioButton.Checked = False
		threeBedroomRadioButton.Checked = False
		fourBedroomRadioButton.Checked = False
		sidingRadioButton.Checked = False
		brickRadioButton.Checked = False
		stuccoRadioButton.Checked = False
		stuccoRadioButton.Checked = False
		wallCarpetingRadioButton.Checked = False
		hardwoodFloorsRadioButton.Checked = False
		twelveCourseBasementCheckBox.Checked = False
		fireplaceCheckBox.Checked = False
		centralAirCheckBox.Checked = False
		gourmetKitchenCheckBox.Checked = False
		summaryListBox.Items.Clear()
		finalPrice.Text = ""
	End Sub

	'Calculates the total cost of the home by adding up all of the selected features and calculating the cost per square footage.
	Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
		Dim valid As Boolean = True
		If firstNameTextBox.Text = "" Then
			MsgBox("Please enter your first name.", , "Validation")
			valid = False
		End If
		If lastNameTextBox.Text = "" Then
			MsgBox("Please enter your last name.", , "Validation")
			valid = False
		End If
		If cityTextBox.Text = "" Then
			MsgBox("Please enter your city.", , "Validation")
			valid = False
		End If
		If squareFootageTextBox.Text = "" Then
			MsgBox("Please enter the square footage.", , "Validation")
			valid = False
		Else
			Try
				Convert.ToInt16(squareFootageTextBox.Text)
			Catch ex As FormatException
				MsgBox("Please enter a numerical value for the square footage.", , "Validation")
				valid = False
			End Try
		End If
		If oneBedroomRadioButton.Checked = False And twoBedroomRadioButton.Checked = False And threeBedroomRadioButton.Checked = False And fourBedroomRadioButton.Checked = False Then
			valid = False
			MsgBox("Please select the number of bedrooms.", , "Validation")
		End If
		If oneCarGarageRadioButton.Checked = False And twoCarGarageRadioButton.Checked = False And attachedGarageRadioButton.Checked = False Then
			valid = False
			MsgBox("Please select a garage.", , "Validation")
		End If
		If oneBathroomRadioButton.Checked = False And twoBathroomRadioButton.Checked = False And threeBathroomRadioButton.Checked = False And fourBathroomRadioButton.Checked = False Then
			valid = False
			MsgBox("Please select the number of bathrooms.", , "Validation")
		End If
		If sidingRadioButton.Checked = False And brickRadioButton.Checked = False And stuccoRadioButton.Checked = False And stoneRadioButton.Checked = False Then
			valid = False
			MsgBox("Please select an exterior.", , "Validation")
		End If
		If wallCarpetingRadioButton.Checked = False And hardwoodFloorsRadioButton.Checked = False Then
			valid = False
			MsgBox("Please select a flooring.", , "Validation")
		End If
		If valid = True Then
			Dim fileWriter As New IO.StreamWriter("C:\Users\Joshua\Desktop\home.txt")
			If Not IO.File.Exists("C:\Users\Joshua\Desktop\home.txt") Then
				MsgBox("The file is not available.", , "IO Error")
			End If
			summaryListBox.Items.Clear()
			summaryListBox.Items.Add("Name: " & firstNameTextBox.Text & " " & lastNameTextBox.Text)
			fileWriter.WriteLine("Name: " & firstNameTextBox.Text & " " & lastNameTextBox.Text)
			summaryListBox.Items.Add("City: " & cityTextBox.Text)
			fileWriter.WriteLine("City: " & cityTextBox.Text)
			Dim cost As Double = Convert.ToDouble(squareFootageTextBox.Text) * 50
			summaryListBox.Items.Add("Square Footage: " & squareFootageTextBox.Text & " (" & cost.ToString("C0") & ")")
			fileWriter.WriteLine("Square Footage: " & squareFootageTextBox.Text & " (" & cost.ToString("C0") & ")")
			If oneBedroomRadioButton.Checked = True Then
				cost += 5000
				summaryListBox.Items.Add("One Bedroom ($5,000)")
				fileWriter.WriteLine("One Bedroom ($5,000)")
			ElseIf twoBedroomRadioButton.Checked = True Then
				cost += 10000
				summaryListBox.Items.Add("Two Bedrooms ($10,000)")
				fileWriter.WriteLine("Two Bedrooms ($10,000)")
			ElseIf threeBedroomRadioButton.Checked = True Then
				cost += 15000
				summaryListBox.Items.Add("Three Bedrooms ($15,000)")
				fileWriter.WriteLine("Three Bedrooms ($15,000)")
			ElseIf fourBedroomRadioButton.Checked = True Then
				cost += 20000
				summaryListBox.Items.Add("Four Bedrooms ($20,000)")
				fileWriter.WriteLine("Four Bedrooms ($20,000)")
			End If
			If oneCarGarageRadioButton.Checked = True Then
				cost += 0
				summaryListBox.Items.Add("One Car Garage (No added cost)")
				fileWriter.WriteLine("One Car Garage (No added cost)")
			ElseIf twoCarGarageRadioButton.Checked = True Then
				cost += 12000
				summaryListBox.Items.Add("Two Car Garage ($12,000)")
				fileWriter.WriteLine("Two Car Garage ($12,000)")
			ElseIf attachedGarageRadioButton.Checked = True Then
				cost += 1000
				summaryListBox.Items.Add("Attached Garage ($1,000)")
				fileWriter.WriteLine("Attached Garage ($1,000)")
			End If
			If oneBathroomRadioButton.Checked = True Then
				cost += 3000
				summaryListBox.Items.Add("One Bathroom ($3,000)")
				fileWriter.WriteLine("One Bathroom ($3,000)")
			ElseIf twoBathroomRadioButton.Checked = True Then
				cost += 6000
				summaryListBox.Items.Add("Two Bathrooms ($6,000)")
				fileWriter.WriteLine("Two Bathrooms ($6,000)")
			ElseIf threeBathroomRadioButton.Checked = True Then
				cost += 9000
				summaryListBox.Items.Add("Three Bathrooms ($9,000)")
				fileWriter.WriteLine("Three Bathrooms ($9,000)")
			ElseIf fourBathroomRadioButton.Checked = True Then
				cost += 12000
				summaryListBox.Items.Add("Four Bathrooms ($12,000)")
				fileWriter.WriteLine("Four Bathrooms ($12,000)")
			End If
			If sidingRadioButton.Checked = True Then
				cost += 20000
				summaryListBox.Items.Add("Siding ($20,000)")
				fileWriter.WriteLine("Siding ($20,000)")
			ElseIf brickRadioButton.Checked = True Then
				cost += 40000
				summaryListBox.Items.Add("Brick ($40,000)")
				fileWriter.WriteLine("Brick ($40,000)")
			ElseIf stuccoRadioButton.Checked = True Then
				cost += 30000
				summaryListBox.Items.Add("Stucco ($30,000)")
				fileWriter.WriteLine("Stucco ($30,000)")
			ElseIf stoneRadioButton.Checked = True Then
				cost += 35000
				summaryListBox.Items.Add("Stone ($35,000)")
				fileWriter.WriteLine("Stone ($35,000)")
			End If
			If wallCarpetingRadioButton.Checked = True Then
				cost += 30000
				summaryListBox.Items.Add("Wall Carpeting ($30,000)")
				fileWriter.WriteLine("Wall Carpeting ($30,000)")
			ElseIf hardwoodFloorsRadioButton.Checked = True Then
				cost += 40000
				summaryListBox.Items.Add("Hardwood Floors ($40,000)")
				fileWriter.WriteLine("Hardwood Floors ($40,000)")
			End If
			If twelveCourseBasementCheckBox.Checked = True Then
				cost += 15000
				summaryListBox.Items.Add("12 Course Basement ($15,000)")
				fileWriter.WriteLine("12 Course Basement ($15,000)")
			End If
			If centralAirCheckBox.Checked = True Then
				cost += 10000
				summaryListBox.Items.Add("Central Air Conditioning ($10,000)")
				fileWriter.WriteLine("Central Air Conditioning ($10,000)")
			End If
			If fireplaceCheckBox.Checked = True Then
				cost += 1500
				summaryListBox.Items.Add("Fireplace ($1,500)")
				fileWriter.WriteLine("Fireplace ($1,500)")
			End If
			If gourmetKitchenCheckBox.Checked = True Then
				cost += 20000
				summaryListBox.Items.Add("Gourmet Kitchen ($20,000)")
				fileWriter.WriteLine("Gourmet Kitchen ($20,000)")
			End If
			finalPrice.Text = cost.ToString("C0")
			fileWriter.WriteLine("Total cost: " & cost.ToString("C0"))
			fileWriter.Close()
		End If
	End Sub

End Class