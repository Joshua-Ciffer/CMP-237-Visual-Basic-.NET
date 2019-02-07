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
        Me.marsRadioButton = New System.Windows.Forms.GroupBox()
        Me.venusRadioButton = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.marsRadioButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'weightTextBox
        '
        Me.weightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weightTextBox.Location = New System.Drawing.Point(604, 106)
        Me.weightTextBox.Name = "weightTextBox"
        Me.weightTextBox.Size = New System.Drawing.Size(485, 75)
        Me.weightTextBox.TabIndex = 0
        '
        'weightLabel
        '
        Me.weightLabel.AutoSize = True
        Me.weightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weightLabel.Location = New System.Drawing.Point(68, 106)
        Me.weightLabel.Name = "weightLabel"
        Me.weightLabel.Size = New System.Drawing.Size(485, 69)
        Me.weightLabel.TabIndex = 1
        Me.weightLabel.Text = "Weight (pounds):"
        '
        'marsRadioButton
        '
        Me.marsRadioButton.Controls.Add(Me.RadioButton2)
        Me.marsRadioButton.Controls.Add(Me.venusRadioButton)
        Me.marsRadioButton.Location = New System.Drawing.Point(80, 321)
        Me.marsRadioButton.Name = "marsRadioButton"
        Me.marsRadioButton.Size = New System.Drawing.Size(235, 175)
        Me.marsRadioButton.TabIndex = 2
        Me.marsRadioButton.TabStop = False
        '
        'venusRadioButton
        '
        Me.venusRadioButton.AutoSize = True
        Me.venusRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.venusRadioButton.Location = New System.Drawing.Point(6, 22)
        Me.venusRadioButton.Name = "venusRadioButton"
        Me.venusRadioButton.Size = New System.Drawing.Size(217, 67)
        Me.venusRadioButton.TabIndex = 0
        Me.venusRadioButton.TabStop = True
        Me.venusRadioButton.Text = "Venus"
        Me.venusRadioButton.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(6, 95)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(184, 67)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Mars"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 865)
        Me.Controls.Add(Me.marsRadioButton)
        Me.Controls.Add(Me.weightLabel)
        Me.Controls.Add(Me.weightTextBox)
        Me.Name = "Form1"
        Me.Text = "Planetary Weight Application"
        Me.marsRadioButton.ResumeLayout(False)
        Me.marsRadioButton.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents weightTextBox As TextBox
    Friend WithEvents weightLabel As Label
    Friend WithEvents marsRadioButton As GroupBox
    Friend WithEvents venusRadioButton As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
