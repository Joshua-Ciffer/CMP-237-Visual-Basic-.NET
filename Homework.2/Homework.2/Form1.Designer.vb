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
        Me.weightTextBox = New System.Windows.Forms.TextBox()
        Me.weightLabel = New System.Windows.Forms.Label()
        Me.radioButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.venusRadioButton = New System.Windows.Forms.RadioButton()
        Me.marsRadioButton = New System.Windows.Forms.RadioButton()
        Me.poundsWeightLabel = New System.Windows.Forms.Label()
        Me.poundsLabel = New System.Windows.Forms.Label()
        Me.kilogramsWeightLabel = New System.Windows.Forms.Label()
        Me.kilogramsLabel = New System.Windows.Forms.Label()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.yourWeightLabel = New System.Windows.Forms.Label()
        Me.labelGroupBox = New System.Windows.Forms.GroupBox()
        Me.selectPlanetLabel = New System.Windows.Forms.Label()
        Me.radioButtonGroupBox.SuspendLayout()
        Me.labelGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'weightTextBox
        '
        Me.weightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weightTextBox.Location = New System.Drawing.Point(766, 56)
        Me.weightTextBox.Name = "weightTextBox"
        Me.weightTextBox.Size = New System.Drawing.Size(385, 75)
        Me.weightTextBox.TabIndex = 0
        '
        'weightLabel
        '
        Me.weightLabel.AutoSize = True
        Me.weightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weightLabel.Location = New System.Drawing.Point(41, 56)
        Me.weightLabel.Name = "weightLabel"
        Me.weightLabel.Size = New System.Drawing.Size(664, 63)
        Me.weightLabel.TabIndex = 1
        Me.weightLabel.Text = "Your weight on Earth (lbs):"
        '
        'radioButtonGroupBox
        '
        Me.radioButtonGroupBox.Controls.Add(Me.selectPlanetLabel)
        Me.radioButtonGroupBox.Controls.Add(Me.marsRadioButton)
        Me.radioButtonGroupBox.Controls.Add(Me.venusRadioButton)
        Me.radioButtonGroupBox.Location = New System.Drawing.Point(77, 189)
        Me.radioButtonGroupBox.Name = "radioButtonGroupBox"
        Me.radioButtonGroupBox.Size = New System.Drawing.Size(425, 264)
        Me.radioButtonGroupBox.TabIndex = 2
        Me.radioButtonGroupBox.TabStop = False
        '
        'venusRadioButton
        '
        Me.venusRadioButton.AutoSize = True
        Me.venusRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.venusRadioButton.Location = New System.Drawing.Point(100, 100)
        Me.venusRadioButton.Name = "venusRadioButton"
        Me.venusRadioButton.Size = New System.Drawing.Size(217, 67)
        Me.venusRadioButton.TabIndex = 0
        Me.venusRadioButton.TabStop = True
        Me.venusRadioButton.Text = "Venus"
        Me.venusRadioButton.UseVisualStyleBackColor = True
        '
        'marsRadioButton
        '
        Me.marsRadioButton.AutoSize = True
        Me.marsRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marsRadioButton.Location = New System.Drawing.Point(100, 177)
        Me.marsRadioButton.Name = "marsRadioButton"
        Me.marsRadioButton.Size = New System.Drawing.Size(184, 67)
        Me.marsRadioButton.TabIndex = 3
        Me.marsRadioButton.TabStop = True
        Me.marsRadioButton.Text = "Mars"
        Me.marsRadioButton.UseVisualStyleBackColor = True
        '
        'poundsWeightLabel
        '
        Me.poundsWeightLabel.AutoSize = True
        Me.poundsWeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poundsWeightLabel.Location = New System.Drawing.Point(106, 100)
        Me.poundsWeightLabel.Name = "poundsWeightLabel"
        Me.poundsWeightLabel.Size = New System.Drawing.Size(129, 69)
        Me.poundsWeightLabel.TabIndex = 3
        Me.poundsWeightLabel.Text = "100"
        '
        'poundsLabel
        '
        Me.poundsLabel.AutoSize = True
        Me.poundsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poundsLabel.Location = New System.Drawing.Point(276, 100)
        Me.poundsLabel.Name = "poundsLabel"
        Me.poundsLabel.Size = New System.Drawing.Size(107, 69)
        Me.poundsLabel.TabIndex = 4
        Me.poundsLabel.Text = "lbs"
        '
        'kilogramsWeightLabel
        '
        Me.kilogramsWeightLabel.AutoSize = True
        Me.kilogramsWeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kilogramsWeightLabel.Location = New System.Drawing.Point(106, 179)
        Me.kilogramsWeightLabel.Name = "kilogramsWeightLabel"
        Me.kilogramsWeightLabel.Size = New System.Drawing.Size(129, 69)
        Me.kilogramsWeightLabel.TabIndex = 5
        Me.kilogramsWeightLabel.Text = "100"
        '
        'kilogramsLabel
        '
        Me.kilogramsLabel.AutoSize = True
        Me.kilogramsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kilogramsLabel.Location = New System.Drawing.Point(276, 179)
        Me.kilogramsLabel.Name = "kilogramsLabel"
        Me.kilogramsLabel.Size = New System.Drawing.Size(93, 69)
        Me.kilogramsLabel.TabIndex = 6
        Me.kilogramsLabel.Text = "kg"
        '
        'calculateButton
        '
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(142, 515)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(370, 133)
        Me.calculateButton.TabIndex = 7
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(667, 515)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(370, 133)
        Me.clearButton.TabIndex = 8
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'yourWeightLabel
        '
        Me.yourWeightLabel.AutoSize = True
        Me.yourWeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yourWeightLabel.Location = New System.Drawing.Point(6, 21)
        Me.yourWeightLabel.Name = "yourWeightLabel"
        Me.yourWeightLabel.Size = New System.Drawing.Size(497, 55)
        Me.yourWeightLabel.TabIndex = 9
        Me.yourWeightLabel.Text = "Your weight would be:"
        '
        'labelGroupBox
        '
        Me.labelGroupBox.Controls.Add(Me.poundsLabel)
        Me.labelGroupBox.Controls.Add(Me.yourWeightLabel)
        Me.labelGroupBox.Controls.Add(Me.kilogramsLabel)
        Me.labelGroupBox.Controls.Add(Me.poundsWeightLabel)
        Me.labelGroupBox.Controls.Add(Me.kilogramsWeightLabel)
        Me.labelGroupBox.Location = New System.Drawing.Point(623, 189)
        Me.labelGroupBox.Name = "labelGroupBox"
        Me.labelGroupBox.Size = New System.Drawing.Size(515, 264)
        Me.labelGroupBox.TabIndex = 10
        Me.labelGroupBox.TabStop = False
        '
        'selectPlanetLabel
        '
        Me.selectPlanetLabel.AutoSize = True
        Me.selectPlanetLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectPlanetLabel.Location = New System.Drawing.Point(6, 16)
        Me.selectPlanetLabel.Name = "selectPlanetLabel"
        Me.selectPlanetLabel.Size = New System.Drawing.Size(399, 63)
        Me.selectPlanetLabel.TabIndex = 4
        Me.selectPlanetLabel.Text = "Select a planet:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 720)
        Me.Controls.Add(Me.labelGroupBox)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.radioButtonGroupBox)
        Me.Controls.Add(Me.weightLabel)
        Me.Controls.Add(Me.weightTextBox)
        Me.Name = "Form1"
        Me.Text = "Planetary Weight Application"
        Me.radioButtonGroupBox.ResumeLayout(False)
        Me.radioButtonGroupBox.PerformLayout()
        Me.labelGroupBox.ResumeLayout(False)
        Me.labelGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents weightTextBox As TextBox
    Friend WithEvents weightLabel As Label
    Friend WithEvents radioButtonGroupBox As GroupBox
    Friend WithEvents venusRadioButton As RadioButton
    Friend WithEvents marsRadioButton As RadioButton
    Friend WithEvents poundsWeightLabel As Label
    Friend WithEvents poundsLabel As Label
    Friend WithEvents kilogramsWeightLabel As Label
    Friend WithEvents kilogramsLabel As Label
    Friend WithEvents calculateButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents yourWeightLabel As Label
    Friend WithEvents selectPlanetLabel As Label
    Friend WithEvents labelGroupBox As GroupBox
End Class
