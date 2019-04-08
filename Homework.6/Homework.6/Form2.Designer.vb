<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.citiesList = New System.Windows.Forms.ListBox()
		Me.costsList = New System.Windows.Forms.ListBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'citiesList
		'
		Me.citiesList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.citiesList.FormattingEnabled = True
		Me.citiesList.ItemHeight = 46
		Me.citiesList.Location = New System.Drawing.Point(66, 69)
		Me.citiesList.Name = "citiesList"
		Me.citiesList.Size = New System.Drawing.Size(491, 510)
		Me.citiesList.TabIndex = 0
		'
		'costsList
		'
		Me.costsList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.costsList.FormattingEnabled = True
		Me.costsList.ItemHeight = 46
		Me.costsList.Location = New System.Drawing.Point(647, 69)
		Me.costsList.Name = "costsList"
		Me.costsList.Size = New System.Drawing.Size(486, 510)
		Me.costsList.TabIndex = 1
		'
		'Button1
		'
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Location = New System.Drawing.Point(393, 619)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(451, 162)
		Me.Button1.TabIndex = 2
		Me.Button1.Text = "Return to Rental Cities"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Form2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1220, 846)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.costsList)
		Me.Controls.Add(Me.citiesList)
		Me.Name = "Form2"
		Me.Text = "City Rentals"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents citiesList As ListBox
	Friend WithEvents costsList As ListBox
	Friend WithEvents Button1 As Button
End Class
