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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.listBox = New System.Windows.Forms.ListBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.computeButton = New System.Windows.Forms.Button()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.medianCost = New System.Windows.Forms.Label()
		Me.averageCost = New System.Windows.Forms.Label()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DisplayTop10CitiesAndRentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(270, 49)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(733, 46)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Two-Bedroom Median Apartment Rental"
		'
		'listBox
		'
		Me.listBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.listBox.FormattingEnabled = True
		Me.listBox.ItemHeight = 46
		Me.listBox.Location = New System.Drawing.Point(705, 195)
		Me.listBox.Name = "listBox"
		Me.listBox.Size = New System.Drawing.Size(528, 464)
		Me.listBox.TabIndex = 1
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(697, 148)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(213, 44)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Select City:"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.Homework._6.My.Resources.Resources.apartment_rent_770_1_
		Me.PictureBox1.Location = New System.Drawing.Point(52, 195)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(564, 464)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 3
		Me.PictureBox1.TabStop = False
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(103, 713)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(887, 55)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "The selected city rental's median cost of:"
		'
		'computeButton
		'
		Me.computeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.computeButton.Location = New System.Drawing.Point(351, 808)
		Me.computeButton.Name = "computeButton"
		Me.computeButton.Size = New System.Drawing.Size(591, 97)
		Me.computeButton.TabIndex = 5
		Me.computeButton.Text = "Compute Average Rental"
		Me.computeButton.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(270, 949)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(478, 46)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Average Rental City Cost:"
		'
		'medianCost
		'
		Me.medianCost.AutoSize = True
		Me.medianCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.medianCost.Location = New System.Drawing.Point(1020, 713)
		Me.medianCost.Name = "medianCost"
		Me.medianCost.Size = New System.Drawing.Size(0, 55)
		Me.medianCost.TabIndex = 7
		'
		'averageCost
		'
		Me.averageCost.AutoSize = True
		Me.averageCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.averageCost.Location = New System.Drawing.Point(782, 949)
		Me.averageCost.Name = "averageCost"
		Me.averageCost.Size = New System.Drawing.Size(0, 46)
		Me.averageCost.TabIndex = 8
		'
		'MenuStrip1
		'
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(1313, 49)
		Me.MenuStrip1.TabIndex = 9
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayTop10CitiesAndRentsToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(75, 48)
		Me.FileToolStripMenuItem.Text = "File"
		'
		'DisplayTop10CitiesAndRentsToolStripMenuItem
		'
		Me.DisplayTop10CitiesAndRentsToolStripMenuItem.Name = "DisplayTop10CitiesAndRentsToolStripMenuItem"
		Me.DisplayTop10CitiesAndRentsToolStripMenuItem.Size = New System.Drawing.Size(544, 46)
		Me.DisplayTop10CitiesAndRentsToolStripMenuItem.Text = "Display Top 10 Cities and Rents"
		'
		'ClearToolStripMenuItem
		'
		Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
		Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(544, 46)
		Me.ClearToolStripMenuItem.Text = "Clear"
		'
		'ExitToolStripMenuItem
		'
		Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
		Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(544, 46)
		Me.ExitToolStripMenuItem.Text = "Exit"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1313, 1150)
		Me.Controls.Add(Me.averageCost)
		Me.Controls.Add(Me.medianCost)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.computeButton)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.listBox)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "Form1"
		Me.Text = "Apartment Rental By City"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents listBox As ListBox
	Friend WithEvents Label2 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label3 As Label
	Friend WithEvents computeButton As Button
	Friend WithEvents Label4 As Label
	Friend WithEvents medianCost As Label
	Friend WithEvents averageCost As Label
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DisplayTop10CitiesAndRentsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
