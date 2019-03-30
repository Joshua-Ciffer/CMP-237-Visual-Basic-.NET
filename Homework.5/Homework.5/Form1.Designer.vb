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
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.comboBox = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.numTickets = New System.Windows.Forms.TextBox()
		Me.ticketCostButton = New System.Windows.Forms.Button()
		Me.clearFormButton = New System.Windows.Forms.Button()
		Me.costLabel = New System.Windows.Forms.Label()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.Homework._5.My.Resources.Resources._01_gallery_imax_inside_1_
		Me.PictureBox1.Location = New System.Drawing.Point(29, 35)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(591, 534)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(812, 56)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(484, 55)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "IMAX Theatre Tickets"
		'
		'comboBox
		'
		Me.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.comboBox.FormattingEnabled = True
		Me.comboBox.Items.AddRange(New Object() {"Matinee $16", "Evening $27"})
		Me.comboBox.Location = New System.Drawing.Point(822, 180)
		Me.comboBox.Name = "comboBox"
		Me.comboBox.Size = New System.Drawing.Size(489, 54)
		Me.comboBox.TabIndex = 2
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(856, 296)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(426, 55)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Number of Tickets:"
		Me.Label2.Visible = False
		'
		'numTickets
		'
		Me.numTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.numTickets.Location = New System.Drawing.Point(953, 429)
		Me.numTickets.Name = "numTickets"
		Me.numTickets.Size = New System.Drawing.Size(236, 53)
		Me.numTickets.TabIndex = 4
		Me.numTickets.Visible = False
		'
		'ticketCostButton
		'
		Me.ticketCostButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ticketCostButton.Location = New System.Drawing.Point(866, 535)
		Me.ticketCostButton.Name = "ticketCostButton"
		Me.ticketCostButton.Size = New System.Drawing.Size(380, 104)
		Me.ticketCostButton.TabIndex = 5
		Me.ticketCostButton.Text = "Ticket Cost"
		Me.ticketCostButton.UseVisualStyleBackColor = True
		Me.ticketCostButton.Visible = False
		'
		'clearFormButton
		'
		Me.clearFormButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.clearFormButton.Location = New System.Drawing.Point(866, 688)
		Me.clearFormButton.Name = "clearFormButton"
		Me.clearFormButton.Size = New System.Drawing.Size(380, 104)
		Me.clearFormButton.TabIndex = 6
		Me.clearFormButton.Text = "Clear Form"
		Me.clearFormButton.UseVisualStyleBackColor = True
		Me.clearFormButton.Visible = False
		'
		'costLabel
		'
		Me.costLabel.AutoSize = True
		Me.costLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.costLabel.Location = New System.Drawing.Point(120, 688)
		Me.costLabel.Name = "costLabel"
		Me.costLabel.Size = New System.Drawing.Size(0, 55)
		Me.costLabel.TabIndex = 7
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1591, 984)
		Me.Controls.Add(Me.costLabel)
		Me.Controls.Add(Me.clearFormButton)
		Me.Controls.Add(Me.ticketCostButton)
		Me.Controls.Add(Me.numTickets)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.comboBox)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Name = "Form1"
		Me.Text = "IMAX Theatre"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label1 As Label
	Friend WithEvents comboBox As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents numTickets As TextBox
	Friend WithEvents ticketCostButton As Button
	Friend WithEvents clearFormButton As Button
	Friend WithEvents costLabel As Label
End Class
