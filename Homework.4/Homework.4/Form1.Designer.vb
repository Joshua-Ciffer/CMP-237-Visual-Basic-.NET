<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.enterButton = New System.Windows.Forms.Button()
		Me.clearButton = New System.Windows.Forms.Button()
		Me.exitButton = New System.Windows.Forms.Button()
		Me.listBox = New System.Windows.Forms.ListBox()
		Me.totalLabel = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(203, 77)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(555, 69)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Softball Scoreboard"
		'
		'enterButton
		'
		Me.enterButton.Location = New System.Drawing.Point(73, 621)
		Me.enterButton.Name = "enterButton"
		Me.enterButton.Size = New System.Drawing.Size(361, 110)
		Me.enterButton.TabIndex = 1
		Me.enterButton.Text = "Enter"
		Me.enterButton.UseVisualStyleBackColor = True
		'
		'clearButton
		'
		Me.clearButton.Location = New System.Drawing.Point(503, 621)
		Me.clearButton.Name = "clearButton"
		Me.clearButton.Size = New System.Drawing.Size(361, 110)
		Me.clearButton.TabIndex = 2
		Me.clearButton.Text = "Clear"
		Me.clearButton.UseVisualStyleBackColor = True
		'
		'exitButton
		'
		Me.exitButton.Location = New System.Drawing.Point(924, 621)
		Me.exitButton.Name = "exitButton"
		Me.exitButton.Size = New System.Drawing.Size(361, 110)
		Me.exitButton.TabIndex = 3
		Me.exitButton.Text = "Exit"
		Me.exitButton.UseVisualStyleBackColor = True
		'
		'listBox
		'
		Me.listBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.listBox.FormattingEnabled = True
		Me.listBox.ItemHeight = 46
		Me.listBox.Location = New System.Drawing.Point(73, 171)
		Me.listBox.Name = "listBox"
		Me.listBox.Size = New System.Drawing.Size(791, 418)
		Me.listBox.TabIndex = 4
		'
		'totalLabel
		'
		Me.totalLabel.AutoSize = True
		Me.totalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.totalLabel.Location = New System.Drawing.Point(924, 535)
		Me.totalLabel.Name = "totalLabel"
		Me.totalLabel.Size = New System.Drawing.Size(0, 46)
		Me.totalLabel.TabIndex = 5
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.Homework._4.My.Resources.Resources._316_lg_3a5a7ddbbc7d8c9205fd342a7407d5e2_1_
		Me.PictureBox1.Location = New System.Drawing.Point(924, 54)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(674, 438)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 6
		Me.PictureBox1.TabStop = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1675, 790)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.totalLabel)
		Me.Controls.Add(Me.listBox)
		Me.Controls.Add(Me.exitButton)
		Me.Controls.Add(Me.clearButton)
		Me.Controls.Add(Me.enterButton)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.Text = "Softball Scoreboard"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents enterButton As Button
	Friend WithEvents clearButton As Button
	Friend WithEvents exitButton As Button
	Friend WithEvents listBox As ListBox
	Friend WithEvents totalLabel As Label
	Friend WithEvents PictureBox1 As PictureBox
End Class
