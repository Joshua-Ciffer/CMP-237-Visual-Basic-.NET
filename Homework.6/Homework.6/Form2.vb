Public Class Form2

	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		For Each city In Form1.cities
			citiesList.Items.Add(city)
		Next
		For Each cost In Form1.costs
			costsList.Items.Add(cost.ToString("C0"))
		Next
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Hide()
	End Sub

End Class