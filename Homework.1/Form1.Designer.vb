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
		Me.bookTripButton = New System.Windows.Forms.Button()
		Me.radioButtonGroupBox = New System.Windows.Forms.GroupBox()
		Me.myrtleBeachRadioButton = New System.Windows.Forms.RadioButton()
		Me.keyWestRadioButton = New System.Windows.Forms.RadioButton()
		Me.veniceBeachRadioButton = New System.Windows.Forms.RadioButton()
		Me.pictureBox = New System.Windows.Forms.PictureBox()
		Me.radioButtonGroupBox.SuspendLayout()
		CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'bookTripButton
		'
		Me.bookTripButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bookTripButton.Location = New System.Drawing.Point(412, 713)
		Me.bookTripButton.Name = "bookTripButton"
		Me.bookTripButton.Size = New System.Drawing.Size(345, 123)
		Me.bookTripButton.TabIndex = 0
		Me.bookTripButton.Text = "Book Trip"
		Me.bookTripButton.UseVisualStyleBackColor = True
		'
		'radioButtonGroupBox
		'
		Me.radioButtonGroupBox.Controls.Add(Me.veniceBeachRadioButton)
		Me.radioButtonGroupBox.Controls.Add(Me.keyWestRadioButton)
		Me.radioButtonGroupBox.Controls.Add(Me.myrtleBeachRadioButton)
		Me.radioButtonGroupBox.Location = New System.Drawing.Point(2, 525)
		Me.radioButtonGroupBox.Name = "radioButtonGroupBox"
		Me.radioButtonGroupBox.Size = New System.Drawing.Size(1190, 155)
		Me.radioButtonGroupBox.TabIndex = 2
		Me.radioButtonGroupBox.TabStop = False
		'
		'myrtleBeachRadioButton
		'
		Me.myrtleBeachRadioButton.AutoSize = True
		Me.myrtleBeachRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.myrtleBeachRadioButton.Location = New System.Drawing.Point(42, 61)
		Me.myrtleBeachRadioButton.Name = "myrtleBeachRadioButton"
		Me.myrtleBeachRadioButton.Size = New System.Drawing.Size(341, 59)
		Me.myrtleBeachRadioButton.TabIndex = 0
		Me.myrtleBeachRadioButton.TabStop = True
		Me.myrtleBeachRadioButton.Text = "Myrtle Beach"
		Me.myrtleBeachRadioButton.UseVisualStyleBackColor = True
		'
		'keyWestRadioButton
		'
		Me.keyWestRadioButton.AutoSize = True
		Me.keyWestRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.keyWestRadioButton.Location = New System.Drawing.Point(440, 61)
		Me.keyWestRadioButton.Name = "keyWestRadioButton"
		Me.keyWestRadioButton.Size = New System.Drawing.Size(266, 59)
		Me.keyWestRadioButton.TabIndex = 1
		Me.keyWestRadioButton.TabStop = True
		Me.keyWestRadioButton.Text = "Key West"
		Me.keyWestRadioButton.UseVisualStyleBackColor = True
		'
		'veniceBeachRadioButton
		'
		Me.veniceBeachRadioButton.AutoSize = True
		Me.veniceBeachRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.veniceBeachRadioButton.Location = New System.Drawing.Point(767, 61)
		Me.veniceBeachRadioButton.Name = "veniceBeachRadioButton"
		Me.veniceBeachRadioButton.Size = New System.Drawing.Size(358, 59)
		Me.veniceBeachRadioButton.TabIndex = 2
		Me.veniceBeachRadioButton.TabStop = True
		Me.veniceBeachRadioButton.Text = "Venice Beach"
		Me.veniceBeachRadioButton.UseVisualStyleBackColor = True
		'
		'pictureBox
		'
		Me.pictureBox.Location = New System.Drawing.Point(29, 30)
		Me.pictureBox.Name = "pictureBox"
		Me.pictureBox.Size = New System.Drawing.Size(1120, 505)
		Me.pictureBox.TabIndex = 3
		Me.pictureBox.TabStop = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1185, 885)
		Me.Controls.Add(Me.pictureBox)
		Me.Controls.Add(Me.radioButtonGroupBox)
		Me.Controls.Add(Me.bookTripButton)
		Me.Name = "Form1"
		Me.Text = "Spring Break Travel Specials"
		Me.radioButtonGroupBox.ResumeLayout(False)
		Me.radioButtonGroupBox.PerformLayout()
		CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents bookTripButton As Button
	Friend WithEvents radioButtonGroupBox As GroupBox
	Friend WithEvents veniceBeachRadioButton As RadioButton
	Friend WithEvents keyWestRadioButton As RadioButton
	Friend WithEvents myrtleBeachRadioButton As RadioButton
	Friend WithEvents pictureBox As PictureBox
End Class
