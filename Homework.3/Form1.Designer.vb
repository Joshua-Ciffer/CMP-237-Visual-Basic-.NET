<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.comicConventionRegistrationLabel = New System.Windows.Forms.Label()
		Me.groupSizeTextBox = New System.Windows.Forms.TextBox()
		Me.clearButton = New System.Windows.Forms.Button()
		Me.calculateButton = New System.Windows.Forms.Button()
		Me.radioButtonGroupBox = New System.Windows.Forms.GroupBox()
		Me.conventionRadioButton = New System.Windows.Forms.RadioButton()
		Me.conventionAutographRadioButton = New System.Windows.Forms.RadioButton()
		Me.conventionExperienceRadioBox = New System.Windows.Forms.RadioButton()
		Me.registrationCostLabel = New System.Windows.Forms.Label()
		Me.costLabel = New System.Windows.Forms.Label()
		Me.groupSizeLabel = New System.Windows.Forms.Label()
		Me.radioButtonGroupBox.SuspendLayout()
		Me.SuspendLayout()
		'
		'comicConventionRegistrationLabel
		'
		Me.comicConventionRegistrationLabel.AutoSize = True
		Me.comicConventionRegistrationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.comicConventionRegistrationLabel.Location = New System.Drawing.Point(110, 50)
		Me.comicConventionRegistrationLabel.Name = "comicConventionRegistrationLabel"
		Me.comicConventionRegistrationLabel.Size = New System.Drawing.Size(757, 61)
		Me.comicConventionRegistrationLabel.TabIndex = 0
		Me.comicConventionRegistrationLabel.Text = "Comic Convention Registration"
		'
		'groupSizeTextBox
		'
		Me.groupSizeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.groupSizeTextBox.Location = New System.Drawing.Point(607, 142)
		Me.groupSizeTextBox.Name = "groupSizeTextBox"
		Me.groupSizeTextBox.Size = New System.Drawing.Size(209, 67)
		Me.groupSizeTextBox.TabIndex = 1
		'
		'clearButton
		'
		Me.clearButton.Location = New System.Drawing.Point(577, 701)
		Me.clearButton.Name = "clearButton"
		Me.clearButton.Size = New System.Drawing.Size(351, 100)
		Me.clearButton.TabIndex = 2
		Me.clearButton.Text = "Clear"
		Me.clearButton.UseVisualStyleBackColor = True
		'
		'calculateButton
		'
		Me.calculateButton.Location = New System.Drawing.Point(88, 701)
		Me.calculateButton.Name = "calculateButton"
		Me.calculateButton.Size = New System.Drawing.Size(351, 100)
		Me.calculateButton.TabIndex = 3
		Me.calculateButton.Text = "Calculate"
		Me.calculateButton.UseVisualStyleBackColor = True
		'
		'radioButtonGroupBox
		'
		Me.radioButtonGroupBox.Controls.Add(Me.conventionRadioButton)
		Me.radioButtonGroupBox.Controls.Add(Me.conventionAutographRadioButton)
		Me.radioButtonGroupBox.Controls.Add(Me.conventionExperienceRadioBox)
		Me.radioButtonGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.radioButtonGroupBox.Location = New System.Drawing.Point(66, 244)
		Me.radioButtonGroupBox.Name = "radioButtonGroupBox"
		Me.radioButtonGroupBox.Size = New System.Drawing.Size(871, 343)
		Me.radioButtonGroupBox.TabIndex = 4
		Me.radioButtonGroupBox.TabStop = False
		Me.radioButtonGroupBox.Text = "Select Ticket Type:"
		'
		'conventionRadioButton
		'
		Me.conventionRadioButton.AutoSize = True
		Me.conventionRadioButton.Location = New System.Drawing.Point(6, 241)
		Me.conventionRadioButton.Name = "conventionRadioButton"
		Me.conventionRadioButton.Size = New System.Drawing.Size(305, 59)
		Me.conventionRadioButton.TabIndex = 2
		Me.conventionRadioButton.TabStop = True
		Me.conventionRadioButton.Text = "Convention"
		Me.conventionRadioButton.UseVisualStyleBackColor = True
		'
		'conventionAutographRadioButton
		'
		Me.conventionAutographRadioButton.AutoSize = True
		Me.conventionAutographRadioButton.Location = New System.Drawing.Point(6, 155)
		Me.conventionAutographRadioButton.Name = "conventionAutographRadioButton"
		Me.conventionAutographRadioButton.Size = New System.Drawing.Size(606, 59)
		Me.conventionAutographRadioButton.TabIndex = 1
		Me.conventionAutographRadioButton.TabStop = True
		Me.conventionAutographRadioButton.Text = "Convention + Autographs"
		Me.conventionAutographRadioButton.UseVisualStyleBackColor = True
		'
		'conventionExperienceRadioBox
		'
		Me.conventionExperienceRadioBox.AutoSize = True
		Me.conventionExperienceRadioBox.Location = New System.Drawing.Point(6, 70)
		Me.conventionExperienceRadioBox.Name = "conventionExperienceRadioBox"
		Me.conventionExperienceRadioBox.Size = New System.Drawing.Size(839, 59)
		Me.conventionExperienceRadioBox.TabIndex = 0
		Me.conventionExperienceRadioBox.TabStop = True
		Me.conventionExperienceRadioBox.Text = "Convention + Superhero Experience"
		Me.conventionExperienceRadioBox.UseVisualStyleBackColor = True
		'
		'registrationCostLabel
		'
		Me.registrationCostLabel.AutoSize = True
		Me.registrationCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.registrationCostLabel.Location = New System.Drawing.Point(111, 619)
		Me.registrationCostLabel.Name = "registrationCostLabel"
		Me.registrationCostLabel.Size = New System.Drawing.Size(458, 55)
		Me.registrationCostLabel.TabIndex = 5
		Me.registrationCostLabel.Text = "Registration Cost:  $"
		'
		'costLabel
		'
		Me.costLabel.AutoSize = True
		Me.costLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.costLabel.Location = New System.Drawing.Point(553, 619)
		Me.costLabel.Name = "costLabel"
		Me.costLabel.Size = New System.Drawing.Size(0, 55)
		Me.costLabel.TabIndex = 6
		'
		'groupSizeLabel
		'
		Me.groupSizeLabel.AutoSize = True
		Me.groupSizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.groupSizeLabel.Location = New System.Drawing.Point(199, 150)
		Me.groupSizeLabel.Name = "groupSizeLabel"
		Me.groupSizeLabel.Size = New System.Drawing.Size(277, 55)
		Me.groupSizeLabel.TabIndex = 7
		Me.groupSizeLabel.Text = "Group Size:"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1004, 888)
		Me.Controls.Add(Me.groupSizeLabel)
		Me.Controls.Add(Me.costLabel)
		Me.Controls.Add(Me.registrationCostLabel)
		Me.Controls.Add(Me.radioButtonGroupBox)
		Me.Controls.Add(Me.calculateButton)
		Me.Controls.Add(Me.clearButton)
		Me.Controls.Add(Me.groupSizeTextBox)
		Me.Controls.Add(Me.comicConventionRegistrationLabel)
		Me.Name = "Form1"
		Me.Text = "Comic Convention Application"
		Me.radioButtonGroupBox.ResumeLayout(False)
		Me.radioButtonGroupBox.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents comicConventionRegistrationLabel As Label
	Friend WithEvents groupSizeTextBox As TextBox
	Friend WithEvents clearButton As Button
	Friend WithEvents calculateButton As Button
	Friend WithEvents radioButtonGroupBox As GroupBox
	Friend WithEvents conventionRadioButton As RadioButton
	Friend WithEvents conventionAutographRadioButton As RadioButton
	Friend WithEvents conventionExperienceRadioBox As RadioButton
	Friend WithEvents registrationCostLabel As Label
	Friend WithEvents costLabel As Label
	Friend WithEvents groupSizeLabel As Label
End Class
