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
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.squareFootageTextBox = New System.Windows.Forms.TextBox()
		Me.squareFootageLabel = New System.Windows.Forms.Label()
		Me.cityTextBox = New System.Windows.Forms.TextBox()
		Me.cityLabel = New System.Windows.Forms.Label()
		Me.lastNameTextBox = New System.Windows.Forms.TextBox()
		Me.lastNameLabel = New System.Windows.Forms.Label()
		Me.firstNameTextBox = New System.Windows.Forms.TextBox()
		Me.firstNameLabel = New System.Windows.Forms.Label()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.optionalGroupBox = New System.Windows.Forms.GroupBox()
		Me.gourmetKitchenCheckBox = New System.Windows.Forms.CheckBox()
		Me.fireplaceCheckBox = New System.Windows.Forms.CheckBox()
		Me.centralAirCheckBox = New System.Windows.Forms.CheckBox()
		Me.twelveCourseBasementCheckBox = New System.Windows.Forms.CheckBox()
		Me.floorGroupBox = New System.Windows.Forms.GroupBox()
		Me.hardwoodFloorsRadioButton = New System.Windows.Forms.RadioButton()
		Me.wallCarpetingRadioButton = New System.Windows.Forms.RadioButton()
		Me.floorLabel = New System.Windows.Forms.Label()
		Me.exteriorGroupBox = New System.Windows.Forms.GroupBox()
		Me.stoneRadioButton = New System.Windows.Forms.RadioButton()
		Me.stuccoRadioButton = New System.Windows.Forms.RadioButton()
		Me.brickRadioButton = New System.Windows.Forms.RadioButton()
		Me.sidingRadioButton = New System.Windows.Forms.RadioButton()
		Me.exteriorLabel = New System.Windows.Forms.Label()
		Me.numBathroomsGroupBox = New System.Windows.Forms.GroupBox()
		Me.fourBathroomRadioButton = New System.Windows.Forms.RadioButton()
		Me.threeBathroomRadioButton = New System.Windows.Forms.RadioButton()
		Me.twoBathroomRadioButton = New System.Windows.Forms.RadioButton()
		Me.oneBathroomRadioButton = New System.Windows.Forms.RadioButton()
		Me.numBathroomsLabel = New System.Windows.Forms.Label()
		Me.carGarageGroupBox = New System.Windows.Forms.GroupBox()
		Me.attachedGarageRadioButton = New System.Windows.Forms.RadioButton()
		Me.twoCarGarageRadioButton = New System.Windows.Forms.RadioButton()
		Me.oneCarGarageRadioButton = New System.Windows.Forms.RadioButton()
		Me.carGarageLabel = New System.Windows.Forms.Label()
		Me.numBedroomsGroupBox = New System.Windows.Forms.GroupBox()
		Me.fourBedroomRadioButton = New System.Windows.Forms.RadioButton()
		Me.threeBedroomRadioButton = New System.Windows.Forms.RadioButton()
		Me.twoBedroomRadioButton = New System.Windows.Forms.RadioButton()
		Me.oneBedroomRadioButton = New System.Windows.Forms.RadioButton()
		Me.numBedroomsLabel = New System.Windows.Forms.Label()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.summaryLabel = New System.Windows.Forms.Label()
		Me.summaryListBox = New System.Windows.Forms.ListBox()
		Me.finalPrice = New System.Windows.Forms.Label()
		Me.finalPriceLabel = New System.Windows.Forms.Label()
		Me.exitButton = New System.Windows.Forms.Button()
		Me.clearButton = New System.Windows.Forms.Button()
		Me.saveButton = New System.Windows.Forms.Button()
		Me.calculateButton = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		Me.optionalGroupBox.SuspendLayout()
		Me.floorGroupBox.SuspendLayout()
		Me.exteriorGroupBox.SuspendLayout()
		Me.numBathroomsGroupBox.SuspendLayout()
		Me.carGarageGroupBox.SuspendLayout()
		Me.numBedroomsGroupBox.SuspendLayout()
		Me.TabPage3.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Controls.Add(Me.TabPage3)
		Me.TabControl1.Location = New System.Drawing.Point(0, 0)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(1401, 972)
		Me.TabControl1.TabIndex = 0
		'
		'TabPage1
		'
		Me.TabPage1.Controls.Add(Me.PictureBox1)
		Me.TabPage1.Controls.Add(Me.squareFootageTextBox)
		Me.TabPage1.Controls.Add(Me.squareFootageLabel)
		Me.TabPage1.Controls.Add(Me.cityTextBox)
		Me.TabPage1.Controls.Add(Me.cityLabel)
		Me.TabPage1.Controls.Add(Me.lastNameTextBox)
		Me.TabPage1.Controls.Add(Me.lastNameLabel)
		Me.TabPage1.Controls.Add(Me.firstNameTextBox)
		Me.TabPage1.Controls.Add(Me.firstNameLabel)
		Me.TabPage1.Location = New System.Drawing.Point(10, 48)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(1381, 914)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Customer Info"
		Me.TabPage1.UseVisualStyleBackColor = True
		'
		'squareFootageTextBox
		'
		Me.squareFootageTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.squareFootageTextBox.Location = New System.Drawing.Point(385, 345)
		Me.squareFootageTextBox.Name = "squareFootageTextBox"
		Me.squareFootageTextBox.Size = New System.Drawing.Size(504, 53)
		Me.squareFootageTextBox.TabIndex = 7
		'
		'squareFootageLabel
		'
		Me.squareFootageLabel.AutoSize = True
		Me.squareFootageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.squareFootageLabel.Location = New System.Drawing.Point(26, 348)
		Me.squareFootageLabel.Name = "squareFootageLabel"
		Me.squareFootageLabel.Size = New System.Drawing.Size(317, 46)
		Me.squareFootageLabel.TabIndex = 6
		Me.squareFootageLabel.Text = "Square Footage:"
		'
		'cityTextBox
		'
		Me.cityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cityTextBox.Location = New System.Drawing.Point(385, 252)
		Me.cityTextBox.Name = "cityTextBox"
		Me.cityTextBox.Size = New System.Drawing.Size(504, 53)
		Me.cityTextBox.TabIndex = 5
		'
		'cityLabel
		'
		Me.cityLabel.AutoSize = True
		Me.cityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cityLabel.Location = New System.Drawing.Point(241, 252)
		Me.cityLabel.Name = "cityLabel"
		Me.cityLabel.Size = New System.Drawing.Size(100, 46)
		Me.cityLabel.TabIndex = 4
		Me.cityLabel.Text = "City:"
		'
		'lastNameTextBox
		'
		Me.lastNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lastNameTextBox.Location = New System.Drawing.Point(385, 147)
		Me.lastNameTextBox.Name = "lastNameTextBox"
		Me.lastNameTextBox.Size = New System.Drawing.Size(504, 53)
		Me.lastNameTextBox.TabIndex = 3
		'
		'lastNameLabel
		'
		Me.lastNameLabel.AutoSize = True
		Me.lastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lastNameLabel.Location = New System.Drawing.Point(118, 154)
		Me.lastNameLabel.Name = "lastNameLabel"
		Me.lastNameLabel.Size = New System.Drawing.Size(223, 46)
		Me.lastNameLabel.TabIndex = 2
		Me.lastNameLabel.Text = "Last Name:"
		'
		'firstNameTextBox
		'
		Me.firstNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.firstNameTextBox.Location = New System.Drawing.Point(385, 48)
		Me.firstNameTextBox.Name = "firstNameTextBox"
		Me.firstNameTextBox.Size = New System.Drawing.Size(504, 53)
		Me.firstNameTextBox.TabIndex = 1
		'
		'firstNameLabel
		'
		Me.firstNameLabel.AutoSize = True
		Me.firstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.firstNameLabel.Location = New System.Drawing.Point(118, 51)
		Me.firstNameLabel.Name = "firstNameLabel"
		Me.firstNameLabel.Size = New System.Drawing.Size(225, 46)
		Me.firstNameLabel.TabIndex = 0
		Me.firstNameLabel.Text = "First Name:"
		'
		'TabPage2
		'
		Me.TabPage2.Controls.Add(Me.optionalGroupBox)
		Me.TabPage2.Controls.Add(Me.floorGroupBox)
		Me.TabPage2.Controls.Add(Me.floorLabel)
		Me.TabPage2.Controls.Add(Me.exteriorGroupBox)
		Me.TabPage2.Controls.Add(Me.exteriorLabel)
		Me.TabPage2.Controls.Add(Me.numBathroomsGroupBox)
		Me.TabPage2.Controls.Add(Me.numBathroomsLabel)
		Me.TabPage2.Controls.Add(Me.carGarageGroupBox)
		Me.TabPage2.Controls.Add(Me.carGarageLabel)
		Me.TabPage2.Controls.Add(Me.numBedroomsGroupBox)
		Me.TabPage2.Controls.Add(Me.numBedroomsLabel)
		Me.TabPage2.Location = New System.Drawing.Point(10, 48)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(1381, 914)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Home Options"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'optionalGroupBox
		'
		Me.optionalGroupBox.Controls.Add(Me.gourmetKitchenCheckBox)
		Me.optionalGroupBox.Controls.Add(Me.fireplaceCheckBox)
		Me.optionalGroupBox.Controls.Add(Me.centralAirCheckBox)
		Me.optionalGroupBox.Controls.Add(Me.twelveCourseBasementCheckBox)
		Me.optionalGroupBox.Location = New System.Drawing.Point(53, 600)
		Me.optionalGroupBox.Name = "optionalGroupBox"
		Me.optionalGroupBox.Size = New System.Drawing.Size(1254, 201)
		Me.optionalGroupBox.TabIndex = 10
		Me.optionalGroupBox.TabStop = False
		'
		'gourmetKitchenCheckBox
		'
		Me.gourmetKitchenCheckBox.AutoSize = True
		Me.gourmetKitchenCheckBox.Location = New System.Drawing.Point(683, 117)
		Me.gourmetKitchenCheckBox.Name = "gourmetKitchenCheckBox"
		Me.gourmetKitchenCheckBox.Size = New System.Drawing.Size(395, 36)
		Me.gourmetKitchenCheckBox.TabIndex = 3
		Me.gourmetKitchenCheckBox.Text = "Gourmet Kitchen ($20,000)"
		Me.gourmetKitchenCheckBox.UseVisualStyleBackColor = True
		'
		'fireplaceCheckBox
		'
		Me.fireplaceCheckBox.AutoSize = True
		Me.fireplaceCheckBox.Location = New System.Drawing.Point(97, 117)
		Me.fireplaceCheckBox.Name = "fireplaceCheckBox"
		Me.fireplaceCheckBox.Size = New System.Drawing.Size(284, 36)
		Me.fireplaceCheckBox.TabIndex = 2
		Me.fireplaceCheckBox.Text = "Fireplace ($1,500)"
		Me.fireplaceCheckBox.UseVisualStyleBackColor = True
		'
		'centralAirCheckBox
		'
		Me.centralAirCheckBox.AutoSize = True
		Me.centralAirCheckBox.Location = New System.Drawing.Point(683, 55)
		Me.centralAirCheckBox.Name = "centralAirCheckBox"
		Me.centralAirCheckBox.Size = New System.Drawing.Size(484, 36)
		Me.centralAirCheckBox.TabIndex = 1
		Me.centralAirCheckBox.Text = "Central Air Conditioning ($10,000)"
		Me.centralAirCheckBox.UseVisualStyleBackColor = True
		'
		'twelveCourseBasementCheckBox
		'
		Me.twelveCourseBasementCheckBox.AutoSize = True
		Me.twelveCourseBasementCheckBox.Location = New System.Drawing.Point(97, 55)
		Me.twelveCourseBasementCheckBox.Name = "twelveCourseBasementCheckBox"
		Me.twelveCourseBasementCheckBox.Size = New System.Drawing.Size(447, 36)
		Me.twelveCourseBasementCheckBox.TabIndex = 0
		Me.twelveCourseBasementCheckBox.Text = "12 Course Basement ($15,000)"
		Me.twelveCourseBasementCheckBox.UseVisualStyleBackColor = True
		'
		'floorGroupBox
		'
		Me.floorGroupBox.Controls.Add(Me.hardwoodFloorsRadioButton)
		Me.floorGroupBox.Controls.Add(Me.wallCarpetingRadioButton)
		Me.floorGroupBox.Location = New System.Drawing.Point(226, 465)
		Me.floorGroupBox.Name = "floorGroupBox"
		Me.floorGroupBox.Size = New System.Drawing.Size(825, 89)
		Me.floorGroupBox.TabIndex = 9
		Me.floorGroupBox.TabStop = False
		'
		'hardwoodFloorsRadioButton
		'
		Me.hardwoodFloorsRadioButton.AutoSize = True
		Me.hardwoodFloorsRadioButton.Location = New System.Drawing.Point(400, 37)
		Me.hardwoodFloorsRadioButton.Name = "hardwoodFloorsRadioButton"
		Me.hardwoodFloorsRadioButton.Size = New System.Drawing.Size(396, 36)
		Me.hardwoodFloorsRadioButton.TabIndex = 1
		Me.hardwoodFloorsRadioButton.TabStop = True
		Me.hardwoodFloorsRadioButton.Text = "Hardwood Floors ($40,000)"
		Me.hardwoodFloorsRadioButton.UseVisualStyleBackColor = True
		'
		'wallCarpetingRadioButton
		'
		Me.wallCarpetingRadioButton.AutoSize = True
		Me.wallCarpetingRadioButton.Location = New System.Drawing.Point(15, 37)
		Me.wallCarpetingRadioButton.Name = "wallCarpetingRadioButton"
		Me.wallCarpetingRadioButton.Size = New System.Drawing.Size(368, 36)
		Me.wallCarpetingRadioButton.TabIndex = 0
		Me.wallCarpetingRadioButton.TabStop = True
		Me.wallCarpetingRadioButton.Text = "Wall Carpeting ($30,000)"
		Me.wallCarpetingRadioButton.UseVisualStyleBackColor = True
		'
		'floorLabel
		'
		Me.floorLabel.AutoSize = True
		Me.floorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.floorLabel.Location = New System.Drawing.Point(22, 498)
		Me.floorLabel.Name = "floorLabel"
		Me.floorLabel.Size = New System.Drawing.Size(104, 39)
		Me.floorLabel.TabIndex = 8
		Me.floorLabel.Text = "Floor:"
		'
		'exteriorGroupBox
		'
		Me.exteriorGroupBox.Controls.Add(Me.stoneRadioButton)
		Me.exteriorGroupBox.Controls.Add(Me.stuccoRadioButton)
		Me.exteriorGroupBox.Controls.Add(Me.brickRadioButton)
		Me.exteriorGroupBox.Controls.Add(Me.sidingRadioButton)
		Me.exteriorGroupBox.Location = New System.Drawing.Point(226, 340)
		Me.exteriorGroupBox.Name = "exteriorGroupBox"
		Me.exteriorGroupBox.Size = New System.Drawing.Size(1081, 105)
		Me.exteriorGroupBox.TabIndex = 7
		Me.exteriorGroupBox.TabStop = False
		'
		'stoneRadioButton
		'
		Me.stoneRadioButton.AutoSize = True
		Me.stoneRadioButton.Location = New System.Drawing.Point(809, 37)
		Me.stoneRadioButton.Name = "stoneRadioButton"
		Me.stoneRadioButton.Size = New System.Drawing.Size(256, 36)
		Me.stoneRadioButton.TabIndex = 3
		Me.stoneRadioButton.TabStop = True
		Me.stoneRadioButton.Text = "Stone ($35,000)"
		Me.stoneRadioButton.UseVisualStyleBackColor = True
		'
		'stuccoRadioButton
		'
		Me.stuccoRadioButton.AutoSize = True
		Me.stuccoRadioButton.Location = New System.Drawing.Point(534, 37)
		Me.stuccoRadioButton.Name = "stuccoRadioButton"
		Me.stuccoRadioButton.Size = New System.Drawing.Size(268, 36)
		Me.stuccoRadioButton.TabIndex = 2
		Me.stuccoRadioButton.TabStop = True
		Me.stuccoRadioButton.Text = "Stucco ($30,000)"
		Me.stuccoRadioButton.UseVisualStyleBackColor = True
		'
		'brickRadioButton
		'
		Me.brickRadioButton.AutoSize = True
		Me.brickRadioButton.Location = New System.Drawing.Point(283, 37)
		Me.brickRadioButton.Name = "brickRadioButton"
		Me.brickRadioButton.Size = New System.Drawing.Size(244, 36)
		Me.brickRadioButton.TabIndex = 1
		Me.brickRadioButton.TabStop = True
		Me.brickRadioButton.Text = "Brick ($40,000)"
		Me.brickRadioButton.UseVisualStyleBackColor = True
		'
		'sidingRadioButton
		'
		Me.sidingRadioButton.AutoSize = True
		Me.sidingRadioButton.Location = New System.Drawing.Point(15, 37)
		Me.sidingRadioButton.Name = "sidingRadioButton"
		Me.sidingRadioButton.Size = New System.Drawing.Size(262, 36)
		Me.sidingRadioButton.TabIndex = 0
		Me.sidingRadioButton.TabStop = True
		Me.sidingRadioButton.Text = "Siding ($20,000)"
		Me.sidingRadioButton.UseVisualStyleBackColor = True
		'
		'exteriorLabel
		'
		Me.exteriorLabel.AutoSize = True
		Me.exteriorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.exteriorLabel.Location = New System.Drawing.Point(22, 378)
		Me.exteriorLabel.Name = "exteriorLabel"
		Me.exteriorLabel.Size = New System.Drawing.Size(143, 39)
		Me.exteriorLabel.TabIndex = 6
		Me.exteriorLabel.Text = "Exterior:"
		'
		'numBathroomsGroupBox
		'
		Me.numBathroomsGroupBox.Controls.Add(Me.fourBathroomRadioButton)
		Me.numBathroomsGroupBox.Controls.Add(Me.threeBathroomRadioButton)
		Me.numBathroomsGroupBox.Controls.Add(Me.twoBathroomRadioButton)
		Me.numBathroomsGroupBox.Controls.Add(Me.oneBathroomRadioButton)
		Me.numBathroomsGroupBox.Location = New System.Drawing.Point(657, 237)
		Me.numBathroomsGroupBox.Name = "numBathroomsGroupBox"
		Me.numBathroomsGroupBox.Size = New System.Drawing.Size(394, 107)
		Me.numBathroomsGroupBox.TabIndex = 5
		Me.numBathroomsGroupBox.TabStop = False
		'
		'fourBathroomRadioButton
		'
		Me.fourBathroomRadioButton.AutoSize = True
		Me.fourBathroomRadioButton.Location = New System.Drawing.Point(290, 37)
		Me.fourBathroomRadioButton.Name = "fourBathroomRadioButton"
		Me.fourBathroomRadioButton.Size = New System.Drawing.Size(68, 36)
		Me.fourBathroomRadioButton.TabIndex = 3
		Me.fourBathroomRadioButton.TabStop = True
		Me.fourBathroomRadioButton.Text = "4"
		Me.fourBathroomRadioButton.UseVisualStyleBackColor = True
		'
		'threeBathroomRadioButton
		'
		Me.threeBathroomRadioButton.AutoSize = True
		Me.threeBathroomRadioButton.Location = New System.Drawing.Point(206, 37)
		Me.threeBathroomRadioButton.Name = "threeBathroomRadioButton"
		Me.threeBathroomRadioButton.Size = New System.Drawing.Size(68, 36)
		Me.threeBathroomRadioButton.TabIndex = 2
		Me.threeBathroomRadioButton.TabStop = True
		Me.threeBathroomRadioButton.Text = "3"
		Me.threeBathroomRadioButton.UseVisualStyleBackColor = True
		'
		'twoBathroomRadioButton
		'
		Me.twoBathroomRadioButton.AutoSize = True
		Me.twoBathroomRadioButton.Location = New System.Drawing.Point(111, 38)
		Me.twoBathroomRadioButton.Name = "twoBathroomRadioButton"
		Me.twoBathroomRadioButton.Size = New System.Drawing.Size(68, 36)
		Me.twoBathroomRadioButton.TabIndex = 1
		Me.twoBathroomRadioButton.TabStop = True
		Me.twoBathroomRadioButton.Text = "2"
		Me.twoBathroomRadioButton.UseVisualStyleBackColor = True
		'
		'oneBathroomRadioButton
		'
		Me.oneBathroomRadioButton.AutoSize = True
		Me.oneBathroomRadioButton.Location = New System.Drawing.Point(16, 37)
		Me.oneBathroomRadioButton.Name = "oneBathroomRadioButton"
		Me.oneBathroomRadioButton.Size = New System.Drawing.Size(68, 36)
		Me.oneBathroomRadioButton.TabIndex = 0
		Me.oneBathroomRadioButton.TabStop = True
		Me.oneBathroomRadioButton.Text = "1"
		Me.oneBathroomRadioButton.UseVisualStyleBackColor = True
		'
		'numBathroomsLabel
		'
		Me.numBathroomsLabel.AutoSize = True
		Me.numBathroomsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.numBathroomsLabel.Location = New System.Drawing.Point(22, 268)
		Me.numBathroomsLabel.Name = "numBathroomsLabel"
		Me.numBathroomsLabel.Size = New System.Drawing.Size(575, 39)
		Me.numBathroomsLabel.TabIndex = 4
		Me.numBathroomsLabel.Text = "Number of Bathrooms ($3,000 each):"
		'
		'carGarageGroupBox
		'
		Me.carGarageGroupBox.Controls.Add(Me.attachedGarageRadioButton)
		Me.carGarageGroupBox.Controls.Add(Me.twoCarGarageRadioButton)
		Me.carGarageGroupBox.Controls.Add(Me.oneCarGarageRadioButton)
		Me.carGarageGroupBox.Location = New System.Drawing.Point(301, 121)
		Me.carGarageGroupBox.Name = "carGarageGroupBox"
		Me.carGarageGroupBox.Size = New System.Drawing.Size(936, 100)
		Me.carGarageGroupBox.TabIndex = 3
		Me.carGarageGroupBox.TabStop = False
		'
		'attachedGarageRadioButton
		'
		Me.attachedGarageRadioButton.AutoSize = True
		Me.attachedGarageRadioButton.Location = New System.Drawing.Point(539, 38)
		Me.attachedGarageRadioButton.Name = "attachedGarageRadioButton"
		Me.attachedGarageRadioButton.Size = New System.Drawing.Size(380, 36)
		Me.attachedGarageRadioButton.TabIndex = 2
		Me.attachedGarageRadioButton.TabStop = True
		Me.attachedGarageRadioButton.Text = "Attached Garage ($1,000)"
		Me.attachedGarageRadioButton.UseVisualStyleBackColor = True
		'
		'twoCarGarageRadioButton
		'
		Me.twoCarGarageRadioButton.AutoSize = True
		Me.twoCarGarageRadioButton.Location = New System.Drawing.Point(283, 38)
		Me.twoCarGarageRadioButton.Name = "twoCarGarageRadioButton"
		Me.twoCarGarageRadioButton.Size = New System.Drawing.Size(249, 36)
		Me.twoCarGarageRadioButton.TabIndex = 1
		Me.twoCarGarageRadioButton.TabStop = True
		Me.twoCarGarageRadioButton.Text = "2 Car ($12,000)"
		Me.twoCarGarageRadioButton.UseVisualStyleBackColor = True
		'
		'oneCarGarageRadioButton
		'
		Me.oneCarGarageRadioButton.AutoSize = True
		Me.oneCarGarageRadioButton.Location = New System.Drawing.Point(25, 38)
		Me.oneCarGarageRadioButton.Name = "oneCarGarageRadioButton"
		Me.oneCarGarageRadioButton.Size = New System.Drawing.Size(261, 36)
		Me.oneCarGarageRadioButton.TabIndex = 0
		Me.oneCarGarageRadioButton.TabStop = True
		Me.oneCarGarageRadioButton.Text = "1 Car (Standard)"
		Me.oneCarGarageRadioButton.UseVisualStyleBackColor = True
		'
		'carGarageLabel
		'
		Me.carGarageLabel.AutoSize = True
		Me.carGarageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.carGarageLabel.Location = New System.Drawing.Point(22, 156)
		Me.carGarageLabel.Name = "carGarageLabel"
		Me.carGarageLabel.Size = New System.Drawing.Size(203, 39)
		Me.carGarageLabel.TabIndex = 2
		Me.carGarageLabel.Text = "Car Garage:"
		'
		'numBedroomsGroupBox
		'
		Me.numBedroomsGroupBox.Controls.Add(Me.fourBedroomRadioButton)
		Me.numBedroomsGroupBox.Controls.Add(Me.threeBedroomRadioButton)
		Me.numBedroomsGroupBox.Controls.Add(Me.twoBedroomRadioButton)
		Me.numBedroomsGroupBox.Controls.Add(Me.oneBedroomRadioButton)
		Me.numBedroomsGroupBox.Location = New System.Drawing.Point(652, 0)
		Me.numBedroomsGroupBox.Name = "numBedroomsGroupBox"
		Me.numBedroomsGroupBox.Size = New System.Drawing.Size(399, 100)
		Me.numBedroomsGroupBox.TabIndex = 1
		Me.numBedroomsGroupBox.TabStop = False
		'
		'fourBedroomRadioButton
		'
		Me.fourBedroomRadioButton.AutoSize = True
		Me.fourBedroomRadioButton.Location = New System.Drawing.Point(310, 38)
		Me.fourBedroomRadioButton.Name = "fourBedroomRadioButton"
		Me.fourBedroomRadioButton.Size = New System.Drawing.Size(68, 36)
		Me.fourBedroomRadioButton.TabIndex = 3
		Me.fourBedroomRadioButton.TabStop = True
		Me.fourBedroomRadioButton.Text = "4"
		Me.fourBedroomRadioButton.UseVisualStyleBackColor = True
		'
		'threeBedroomRadioButton
		'
		Me.threeBedroomRadioButton.AutoSize = True
		Me.threeBedroomRadioButton.Location = New System.Drawing.Point(203, 38)
		Me.threeBedroomRadioButton.Name = "threeBedroomRadioButton"
		Me.threeBedroomRadioButton.Size = New System.Drawing.Size(68, 36)
		Me.threeBedroomRadioButton.TabIndex = 2
		Me.threeBedroomRadioButton.TabStop = True
		Me.threeBedroomRadioButton.Text = "3"
		Me.threeBedroomRadioButton.UseVisualStyleBackColor = True
		'
		'twoBedroomRadioButton
		'
		Me.twoBedroomRadioButton.AutoSize = True
		Me.twoBedroomRadioButton.Location = New System.Drawing.Point(101, 38)
		Me.twoBedroomRadioButton.Name = "twoBedroomRadioButton"
		Me.twoBedroomRadioButton.Size = New System.Drawing.Size(68, 36)
		Me.twoBedroomRadioButton.TabIndex = 1
		Me.twoBedroomRadioButton.TabStop = True
		Me.twoBedroomRadioButton.Text = "2"
		Me.twoBedroomRadioButton.UseVisualStyleBackColor = True
		'
		'oneBedroomRadioButton
		'
		Me.oneBedroomRadioButton.AutoSize = True
		Me.oneBedroomRadioButton.Location = New System.Drawing.Point(7, 38)
		Me.oneBedroomRadioButton.Name = "oneBedroomRadioButton"
		Me.oneBedroomRadioButton.Size = New System.Drawing.Size(68, 36)
		Me.oneBedroomRadioButton.TabIndex = 0
		Me.oneBedroomRadioButton.TabStop = True
		Me.oneBedroomRadioButton.Text = "1"
		Me.oneBedroomRadioButton.UseVisualStyleBackColor = True
		'
		'numBedroomsLabel
		'
		Me.numBedroomsLabel.AutoSize = True
		Me.numBedroomsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.numBedroomsLabel.Location = New System.Drawing.Point(15, 40)
		Me.numBedroomsLabel.Name = "numBedroomsLabel"
		Me.numBedroomsLabel.Size = New System.Drawing.Size(566, 39)
		Me.numBedroomsLabel.TabIndex = 0
		Me.numBedroomsLabel.Text = "Number of Bedrooms ($5,000 each):"
		'
		'TabPage3
		'
		Me.TabPage3.Controls.Add(Me.summaryLabel)
		Me.TabPage3.Controls.Add(Me.summaryListBox)
		Me.TabPage3.Controls.Add(Me.finalPrice)
		Me.TabPage3.Controls.Add(Me.finalPriceLabel)
		Me.TabPage3.Controls.Add(Me.exitButton)
		Me.TabPage3.Controls.Add(Me.clearButton)
		Me.TabPage3.Controls.Add(Me.saveButton)
		Me.TabPage3.Controls.Add(Me.calculateButton)
		Me.TabPage3.Location = New System.Drawing.Point(10, 48)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage3.Size = New System.Drawing.Size(1381, 914)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "Summary"
		Me.TabPage3.UseVisualStyleBackColor = True
		'
		'summaryLabel
		'
		Me.summaryLabel.AutoSize = True
		Me.summaryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.summaryLabel.Location = New System.Drawing.Point(41, 38)
		Me.summaryLabel.Name = "summaryLabel"
		Me.summaryLabel.Size = New System.Drawing.Size(243, 55)
		Me.summaryLabel.TabIndex = 7
		Me.summaryLabel.Text = "Summary:"
		'
		'summaryListBox
		'
		Me.summaryListBox.FormattingEnabled = True
		Me.summaryListBox.ItemHeight = 31
		Me.summaryListBox.Location = New System.Drawing.Point(51, 111)
		Me.summaryListBox.Name = "summaryListBox"
		Me.summaryListBox.Size = New System.Drawing.Size(1275, 500)
		Me.summaryListBox.TabIndex = 6
		'
		'finalPrice
		'
		Me.finalPrice.AutoSize = True
		Me.finalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.finalPrice.Location = New System.Drawing.Point(617, 661)
		Me.finalPrice.Name = "finalPrice"
		Me.finalPrice.Size = New System.Drawing.Size(0, 46)
		Me.finalPrice.TabIndex = 5
		'
		'finalPriceLabel
		'
		Me.finalPriceLabel.AutoSize = True
		Me.finalPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.finalPriceLabel.Location = New System.Drawing.Point(376, 661)
		Me.finalPriceLabel.Name = "finalPriceLabel"
		Me.finalPriceLabel.Size = New System.Drawing.Size(220, 46)
		Me.finalPriceLabel.TabIndex = 4
		Me.finalPriceLabel.Text = "Final Price:"
		'
		'exitButton
		'
		Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.exitButton.Location = New System.Drawing.Point(1067, 766)
		Me.exitButton.Name = "exitButton"
		Me.exitButton.Size = New System.Drawing.Size(214, 78)
		Me.exitButton.TabIndex = 3
		Me.exitButton.Text = "Exit"
		Me.exitButton.UseVisualStyleBackColor = True
		'
		'clearButton
		'
		Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.clearButton.Location = New System.Drawing.Point(757, 767)
		Me.clearButton.Name = "clearButton"
		Me.clearButton.Size = New System.Drawing.Size(214, 77)
		Me.clearButton.TabIndex = 2
		Me.clearButton.Text = "Clear"
		Me.clearButton.UseVisualStyleBackColor = True
		'
		'saveButton
		'
		Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.saveButton.Location = New System.Drawing.Point(432, 767)
		Me.saveButton.Name = "saveButton"
		Me.saveButton.Size = New System.Drawing.Size(214, 77)
		Me.saveButton.TabIndex = 1
		Me.saveButton.Text = "Save"
		Me.saveButton.UseVisualStyleBackColor = True
		'
		'calculateButton
		'
		Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.calculateButton.Location = New System.Drawing.Point(107, 767)
		Me.calculateButton.Name = "calculateButton"
		Me.calculateButton.Size = New System.Drawing.Size(214, 77)
		Me.calculateButton.TabIndex = 0
		Me.calculateButton.Text = "Calculate"
		Me.calculateButton.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.Final_Project.My.Resources.Resources.home_buying_course_1_
		Me.PictureBox1.Location = New System.Drawing.Point(184, 458)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(696, 383)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 8
		Me.PictureBox1.TabStop = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1414, 1313)
		Me.Controls.Add(Me.TabControl1)
		Me.Name = "Form1"
		Me.Text = "Custom Home System"
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage1.PerformLayout()
		Me.TabPage2.ResumeLayout(False)
		Me.TabPage2.PerformLayout()
		Me.optionalGroupBox.ResumeLayout(False)
		Me.optionalGroupBox.PerformLayout()
		Me.floorGroupBox.ResumeLayout(False)
		Me.floorGroupBox.PerformLayout()
		Me.exteriorGroupBox.ResumeLayout(False)
		Me.exteriorGroupBox.PerformLayout()
		Me.numBathroomsGroupBox.ResumeLayout(False)
		Me.numBathroomsGroupBox.PerformLayout()
		Me.carGarageGroupBox.ResumeLayout(False)
		Me.carGarageGroupBox.PerformLayout()
		Me.numBedroomsGroupBox.ResumeLayout(False)
		Me.numBedroomsGroupBox.PerformLayout()
		Me.TabPage3.ResumeLayout(False)
		Me.TabPage3.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents lastNameTextBox As TextBox
	Friend WithEvents lastNameLabel As Label
	Friend WithEvents firstNameTextBox As TextBox
	Friend WithEvents firstNameLabel As Label
	Friend WithEvents squareFootageTextBox As TextBox
	Friend WithEvents squareFootageLabel As Label
	Friend WithEvents cityTextBox As TextBox
	Friend WithEvents cityLabel As Label
	Friend WithEvents numBedroomsLabel As Label
	Friend WithEvents numBedroomsGroupBox As GroupBox
	Friend WithEvents fourBedroomRadioButton As RadioButton
	Friend WithEvents threeBedroomRadioButton As RadioButton
	Friend WithEvents twoBedroomRadioButton As RadioButton
	Friend WithEvents oneBedroomRadioButton As RadioButton
	Friend WithEvents carGarageGroupBox As GroupBox
	Friend WithEvents twoCarGarageRadioButton As RadioButton
	Friend WithEvents oneCarGarageRadioButton As RadioButton
	Friend WithEvents carGarageLabel As Label
	Friend WithEvents attachedGarageRadioButton As RadioButton
	Friend WithEvents numBathroomsGroupBox As GroupBox
	Friend WithEvents numBathroomsLabel As Label
	Friend WithEvents oneBathroomRadioButton As RadioButton
	Friend WithEvents fourBathroomRadioButton As RadioButton
	Friend WithEvents threeBathroomRadioButton As RadioButton
	Friend WithEvents twoBathroomRadioButton As RadioButton
	Friend WithEvents exteriorLabel As Label
	Friend WithEvents exteriorGroupBox As GroupBox
	Friend WithEvents brickRadioButton As RadioButton
	Friend WithEvents sidingRadioButton As RadioButton
	Friend WithEvents stuccoRadioButton As RadioButton
	Friend WithEvents stoneRadioButton As RadioButton
	Friend WithEvents floorGroupBox As GroupBox
	Friend WithEvents floorLabel As Label
	Friend WithEvents hardwoodFloorsRadioButton As RadioButton
	Friend WithEvents wallCarpetingRadioButton As RadioButton
	Friend WithEvents optionalGroupBox As GroupBox
	Friend WithEvents gourmetKitchenCheckBox As CheckBox
	Friend WithEvents fireplaceCheckBox As CheckBox
	Friend WithEvents centralAirCheckBox As CheckBox
	Friend WithEvents twelveCourseBasementCheckBox As CheckBox
	Friend WithEvents summaryLabel As Label
	Friend WithEvents summaryListBox As ListBox
	Friend WithEvents finalPrice As Label
	Friend WithEvents finalPriceLabel As Label
	Friend WithEvents exitButton As Button
	Friend WithEvents clearButton As Button
	Friend WithEvents saveButton As Button
	Friend WithEvents calculateButton As Button
	Friend WithEvents PictureBox1 As PictureBox
End Class
