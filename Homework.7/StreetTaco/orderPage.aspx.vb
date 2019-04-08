Public Class orderPage

	Inherits System.Web.UI.Page

	Protected Sub btnOrder_Click(sender As Object, e As EventArgs) Handles orderButton.Click
		Dim orderCost As Double
		Dim toppingCost As Decimal = 0.99
		If meatsDropDownList.SelectedValue = 8.99 Then
			orderCost += 8.99
		ElseIf meatsDropDownList.SelectedValue = 9.99 Then
			orderCost += 9.99
		ElseIf meatsDropDownList.SelectedValue = 12.99 Then
			orderCost += 12.99
		Else
			orderCost += 13.99
		End If
		If cheeseCheckBox.Checked Then
			orderCost += toppingCost
		End If
		If lettuceCheckBox.Checked Then
			orderCost += toppingCost
		End If
		If secretSauceCheckBox.Checked Then
			orderCost += toppingCost
		End If
		If sourCreamCheckBox.Checked Then
			orderCost += toppingCost
		End If
		If tomatoesCheckBox.Checked Then
			orderCost += toppingCost
		End If
		finalCostLabel.Text = "Your total amount due is " & orderCost.ToString("C0")
	End Sub

End Class