<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Day_Sheet
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
        Me.components = New System.ComponentModel.Container
        Dim IDLabel As System.Windows.Forms.Label
        Dim EmplyIdLabel As System.Windows.Forms.Label
        Dim Working_DateLabel As System.Windows.Forms.Label
        Dim PresentLabel As System.Windows.Forms.Label
        Dim Working_NotesLabel As System.Windows.Forms.Label
        Dim Start_Meter_ReadingLabel As System.Windows.Forms.Label
        Dim End_Meter_ReadingLabel As System.Windows.Forms.Label
        Dim Public_Transport_CostLabel As System.Windows.Forms.Label
        Dim Public_Transport_DetailsLabel As System.Windows.Forms.Label
        Dim Other_ExpensesLabel As System.Windows.Forms.Label
        Dim Other_Expenses_DetailsLabel As System.Windows.Forms.Label
        Dim Petrol_CostLabel As System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.EmplyNameComboBox = New System.Windows.Forms.ComboBox
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ingenium_2011DataSet = New WindowsApplication1.Ingenium_2011DataSet
        Me.EmployeeTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.EmployeeTableAdapter
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.DayEditButton = New System.Windows.Forms.Button
        Me.DaySavePanel = New System.Windows.Forms.Panel
        Me.CancelEditButton = New System.Windows.Forms.Button
        Me.SaveEditButton = New System.Windows.Forms.Button
        Me.DayAddNewButton = New System.Windows.Forms.Button
        Me.DayRecordPanel = New System.Windows.Forms.Panel
        Me.Petrol_CostTextBox = New System.Windows.Forms.TextBox
        Me.Employee_Day_SheetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDTextBox = New System.Windows.Forms.TextBox
        Me.EmplyIdTextBox = New System.Windows.Forms.TextBox
        Me.Working_DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.PresentCheckBox = New System.Windows.Forms.CheckBox
        Me.Working_NotesTextBox = New System.Windows.Forms.TextBox
        Me.Start_Meter_ReadingTextBox = New System.Windows.Forms.TextBox
        Me.End_Meter_ReadingTextBox = New System.Windows.Forms.TextBox
        Me.Public_Transport_CostTextBox = New System.Windows.Forms.TextBox
        Me.Public_Transport_DetailsTextBox = New System.Windows.Forms.TextBox
        Me.Other_ExpensesTextBox = New System.Windows.Forms.TextBox
        Me.Other_Expenses_DetailsTextBox = New System.Windows.Forms.TextBox
        Me.Employee_Day_SheetDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Employee_Day_SheetTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Employee_Day_SheetTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        IDLabel = New System.Windows.Forms.Label
        EmplyIdLabel = New System.Windows.Forms.Label
        Working_DateLabel = New System.Windows.Forms.Label
        PresentLabel = New System.Windows.Forms.Label
        Working_NotesLabel = New System.Windows.Forms.Label
        Start_Meter_ReadingLabel = New System.Windows.Forms.Label
        End_Meter_ReadingLabel = New System.Windows.Forms.Label
        Public_Transport_CostLabel = New System.Windows.Forms.Label
        Public_Transport_DetailsLabel = New System.Windows.Forms.Label
        Other_ExpensesLabel = New System.Windows.Forms.Label
        Other_Expenses_DetailsLabel = New System.Windows.Forms.Label
        Petrol_CostLabel = New System.Windows.Forms.Label
        Me.StatusStrip1.SuspendLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.DaySavePanel.SuspendLayout()
        Me.DayRecordPanel.SuspendLayout()
        CType(Me.Employee_Day_SheetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employee_Day_SheetDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(16, 13)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'EmplyIdLabel
        '
        EmplyIdLabel.AutoSize = True
        EmplyIdLabel.Location = New System.Drawing.Point(105, 13)
        EmplyIdLabel.Name = "EmplyIdLabel"
        EmplyIdLabel.Size = New System.Drawing.Size(50, 13)
        EmplyIdLabel.TabIndex = 2
        EmplyIdLabel.Text = "Emply Id:"
        '
        'Working_DateLabel
        '
        Working_DateLabel.AutoSize = True
        Working_DateLabel.Location = New System.Drawing.Point(2, 40)
        Working_DateLabel.Name = "Working_DateLabel"
        Working_DateLabel.Size = New System.Drawing.Size(76, 13)
        Working_DateLabel.TabIndex = 4
        Working_DateLabel.Text = "Working Date:"
        '
        'PresentLabel
        '
        PresentLabel.AutoSize = True
        PresentLabel.Location = New System.Drawing.Point(255, 36)
        PresentLabel.Name = "PresentLabel"
        PresentLabel.Size = New System.Drawing.Size(46, 13)
        PresentLabel.TabIndex = 6
        PresentLabel.Text = "Present:"
        '
        'Working_NotesLabel
        '
        Working_NotesLabel.AutoSize = True
        Working_NotesLabel.Location = New System.Drawing.Point(2, 74)
        Working_NotesLabel.Name = "Working_NotesLabel"
        Working_NotesLabel.Size = New System.Drawing.Size(81, 13)
        Working_NotesLabel.TabIndex = 8
        Working_NotesLabel.Text = "Working Notes:"
        '
        'Start_Meter_ReadingLabel
        '
        Start_Meter_ReadingLabel.AutoSize = True
        Start_Meter_ReadingLabel.Location = New System.Drawing.Point(7, 137)
        Start_Meter_ReadingLabel.Name = "Start_Meter_ReadingLabel"
        Start_Meter_ReadingLabel.Size = New System.Drawing.Size(105, 13)
        Start_Meter_ReadingLabel.TabIndex = 14
        Start_Meter_ReadingLabel.Text = "Start Meter Reading:"
        '
        'End_Meter_ReadingLabel
        '
        End_Meter_ReadingLabel.AutoSize = True
        End_Meter_ReadingLabel.Location = New System.Drawing.Point(7, 163)
        End_Meter_ReadingLabel.Name = "End_Meter_ReadingLabel"
        End_Meter_ReadingLabel.Size = New System.Drawing.Size(102, 13)
        End_Meter_ReadingLabel.TabIndex = 16
        End_Meter_ReadingLabel.Text = "End Meter Reading:"
        '
        'Public_Transport_CostLabel
        '
        Public_Transport_CostLabel.AutoSize = True
        Public_Transport_CostLabel.Location = New System.Drawing.Point(7, 210)
        Public_Transport_CostLabel.Name = "Public_Transport_CostLabel"
        Public_Transport_CostLabel.Size = New System.Drawing.Size(111, 13)
        Public_Transport_CostLabel.TabIndex = 18
        Public_Transport_CostLabel.Text = "Public Transport Cost:"
        '
        'Public_Transport_DetailsLabel
        '
        Public_Transport_DetailsLabel.AutoSize = True
        Public_Transport_DetailsLabel.Location = New System.Drawing.Point(7, 236)
        Public_Transport_DetailsLabel.Name = "Public_Transport_DetailsLabel"
        Public_Transport_DetailsLabel.Size = New System.Drawing.Size(122, 13)
        Public_Transport_DetailsLabel.TabIndex = 20
        Public_Transport_DetailsLabel.Text = "Public Transport Details:"
        '
        'Other_ExpensesLabel
        '
        Other_ExpensesLabel.AutoSize = True
        Other_ExpensesLabel.Location = New System.Drawing.Point(7, 289)
        Other_ExpensesLabel.Name = "Other_ExpensesLabel"
        Other_ExpensesLabel.Size = New System.Drawing.Size(85, 13)
        Other_ExpensesLabel.TabIndex = 22
        Other_ExpensesLabel.Text = "Other Expenses:"
        '
        'Other_Expenses_DetailsLabel
        '
        Other_Expenses_DetailsLabel.AutoSize = True
        Other_Expenses_DetailsLabel.Location = New System.Drawing.Point(7, 315)
        Other_Expenses_DetailsLabel.Name = "Other_Expenses_DetailsLabel"
        Other_Expenses_DetailsLabel.Size = New System.Drawing.Size(120, 13)
        Other_Expenses_DetailsLabel.TabIndex = 24
        Other_Expenses_DetailsLabel.Text = "Other Expenses Details:"
        '
        'Petrol_CostLabel
        '
        Petrol_CostLabel.AutoSize = True
        Petrol_CostLabel.Location = New System.Drawing.Point(203, 149)
        Petrol_CostLabel.Name = "Petrol_CostLabel"
        Petrol_CostLabel.Size = New System.Drawing.Size(61, 13)
        Petrol_CostLabel.TabIndex = 26
        Petrol_CostLabel.Text = "Petrol Cost:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(750, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 483)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(750, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'EmplyNameComboBox
        '
        Me.EmplyNameComboBox.DataSource = Me.EmployeeBindingSource
        Me.EmplyNameComboBox.DisplayMember = "Emply Name"
        Me.EmplyNameComboBox.FormattingEnabled = True
        Me.EmplyNameComboBox.Location = New System.Drawing.Point(13, 3)
        Me.EmplyNameComboBox.Name = "EmplyNameComboBox"
        Me.EmplyNameComboBox.Size = New System.Drawing.Size(244, 21)
        Me.EmplyNameComboBox.TabIndex = 0
        Me.EmplyNameComboBox.ValueMember = "EmplyId"
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Ingenium_2011DataSet
        '
        Me.Ingenium_2011DataSet.DataSetName = "Ingenium_2011DataSet"
        Me.Ingenium_2011DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(750, 458)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.DayEditButton)
        Me.TabPage1.Controls.Add(Me.DaySavePanel)
        Me.TabPage1.Controls.Add(Me.DayAddNewButton)
        Me.TabPage1.Controls.Add(Me.DayRecordPanel)
        Me.TabPage1.Controls.Add(Me.Employee_Day_SheetDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(742, 432)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Day Sheet"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DayEditButton
        '
        Me.DayEditButton.Location = New System.Drawing.Point(478, 7)
        Me.DayEditButton.Name = "DayEditButton"
        Me.DayEditButton.Size = New System.Drawing.Size(91, 36)
        Me.DayEditButton.TabIndex = 2
        Me.DayEditButton.Text = "&Edit Day Details"
        Me.DayEditButton.UseVisualStyleBackColor = True
        '
        'DaySavePanel
        '
        Me.DaySavePanel.Controls.Add(Me.CancelEditButton)
        Me.DaySavePanel.Controls.Add(Me.SaveEditButton)
        Me.DaySavePanel.Location = New System.Drawing.Point(575, 6)
        Me.DaySavePanel.Name = "DaySavePanel"
        Me.DaySavePanel.Size = New System.Drawing.Size(164, 39)
        Me.DaySavePanel.TabIndex = 4
        '
        'CancelEditButton
        '
        Me.CancelEditButton.Location = New System.Drawing.Point(82, 3)
        Me.CancelEditButton.Name = "CancelEditButton"
        Me.CancelEditButton.Size = New System.Drawing.Size(75, 32)
        Me.CancelEditButton.TabIndex = 1
        Me.CancelEditButton.Text = "&Cancel"
        Me.CancelEditButton.UseVisualStyleBackColor = True
        '
        'SaveEditButton
        '
        Me.SaveEditButton.Location = New System.Drawing.Point(5, 3)
        Me.SaveEditButton.Name = "SaveEditButton"
        Me.SaveEditButton.Size = New System.Drawing.Size(75, 32)
        Me.SaveEditButton.TabIndex = 0
        Me.SaveEditButton.Text = "&Save"
        Me.SaveEditButton.UseVisualStyleBackColor = True
        '
        'DayAddNewButton
        '
        Me.DayAddNewButton.Location = New System.Drawing.Point(370, 6)
        Me.DayAddNewButton.Name = "DayAddNewButton"
        Me.DayAddNewButton.Size = New System.Drawing.Size(92, 36)
        Me.DayAddNewButton.TabIndex = 1
        Me.DayAddNewButton.Text = "Add &New Day"
        Me.DayAddNewButton.UseVisualStyleBackColor = True
        '
        'DayRecordPanel
        '
        Me.DayRecordPanel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DayRecordPanel.Controls.Add(Petrol_CostLabel)
        Me.DayRecordPanel.Controls.Add(Me.Petrol_CostTextBox)
        Me.DayRecordPanel.Controls.Add(IDLabel)
        Me.DayRecordPanel.Controls.Add(Me.IDTextBox)
        Me.DayRecordPanel.Controls.Add(EmplyIdLabel)
        Me.DayRecordPanel.Controls.Add(Me.EmplyIdTextBox)
        Me.DayRecordPanel.Controls.Add(Working_DateLabel)
        Me.DayRecordPanel.Controls.Add(Me.Working_DateDateTimePicker)
        Me.DayRecordPanel.Controls.Add(PresentLabel)
        Me.DayRecordPanel.Controls.Add(Me.PresentCheckBox)
        Me.DayRecordPanel.Controls.Add(Working_NotesLabel)
        Me.DayRecordPanel.Controls.Add(Me.Working_NotesTextBox)
        Me.DayRecordPanel.Controls.Add(Start_Meter_ReadingLabel)
        Me.DayRecordPanel.Controls.Add(Me.Start_Meter_ReadingTextBox)
        Me.DayRecordPanel.Controls.Add(End_Meter_ReadingLabel)
        Me.DayRecordPanel.Controls.Add(Me.End_Meter_ReadingTextBox)
        Me.DayRecordPanel.Controls.Add(Public_Transport_CostLabel)
        Me.DayRecordPanel.Controls.Add(Me.Public_Transport_CostTextBox)
        Me.DayRecordPanel.Controls.Add(Public_Transport_DetailsLabel)
        Me.DayRecordPanel.Controls.Add(Me.Public_Transport_DetailsTextBox)
        Me.DayRecordPanel.Controls.Add(Other_ExpensesLabel)
        Me.DayRecordPanel.Controls.Add(Me.Other_ExpensesTextBox)
        Me.DayRecordPanel.Controls.Add(Other_Expenses_DetailsLabel)
        Me.DayRecordPanel.Controls.Add(Me.Other_Expenses_DetailsTextBox)
        Me.DayRecordPanel.Location = New System.Drawing.Point(365, 48)
        Me.DayRecordPanel.Name = "DayRecordPanel"
        Me.DayRecordPanel.Size = New System.Drawing.Size(369, 373)
        Me.DayRecordPanel.TabIndex = 3
        '
        'Petrol_CostTextBox
        '
        Me.Petrol_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_Day_SheetBindingSource, "Petrol Cost", True))
        Me.Petrol_CostTextBox.Location = New System.Drawing.Point(270, 146)
        Me.Petrol_CostTextBox.Name = "Petrol_CostTextBox"
        Me.Petrol_CostTextBox.Size = New System.Drawing.Size(73, 20)
        Me.Petrol_CostTextBox.TabIndex = 5
        '
        'Employee_Day_SheetBindingSource
        '
        Me.Employee_Day_SheetBindingSource.DataMember = "Employee Day Sheet"
        Me.Employee_Day_SheetBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_Day_SheetBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(43, 10)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(36, 20)
        Me.IDTextBox.TabIndex = 1
        '
        'EmplyIdTextBox
        '
        Me.EmplyIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_Day_SheetBindingSource, "EmplyId", True))
        Me.EmplyIdTextBox.Enabled = False
        Me.EmplyIdTextBox.Location = New System.Drawing.Point(163, 10)
        Me.EmplyIdTextBox.Name = "EmplyIdTextBox"
        Me.EmplyIdTextBox.Size = New System.Drawing.Size(36, 20)
        Me.EmplyIdTextBox.TabIndex = 3
        '
        'Working_DateDateTimePicker
        '
        Me.Working_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Employee_Day_SheetBindingSource, "Working Date", True))
        Me.Working_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Working_DateDateTimePicker.Location = New System.Drawing.Point(84, 36)
        Me.Working_DateDateTimePicker.Name = "Working_DateDateTimePicker"
        Me.Working_DateDateTimePicker.Size = New System.Drawing.Size(88, 20)
        Me.Working_DateDateTimePicker.TabIndex = 0
        '
        'PresentCheckBox
        '
        Me.PresentCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Employee_Day_SheetBindingSource, "Present", True))
        Me.PresentCheckBox.Location = New System.Drawing.Point(312, 31)
        Me.PresentCheckBox.Name = "PresentCheckBox"
        Me.PresentCheckBox.Size = New System.Drawing.Size(24, 24)
        Me.PresentCheckBox.TabIndex = 1
        Me.PresentCheckBox.UseVisualStyleBackColor = True
        '
        'Working_NotesTextBox
        '
        Me.Working_NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_Day_SheetBindingSource, "Working Notes", True))
        Me.Working_NotesTextBox.Location = New System.Drawing.Point(84, 62)
        Me.Working_NotesTextBox.Multiline = True
        Me.Working_NotesTextBox.Name = "Working_NotesTextBox"
        Me.Working_NotesTextBox.Size = New System.Drawing.Size(268, 56)
        Me.Working_NotesTextBox.TabIndex = 2
        '
        'Start_Meter_ReadingTextBox
        '
        Me.Start_Meter_ReadingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_Day_SheetBindingSource, "Start Meter Reading", True))
        Me.Start_Meter_ReadingTextBox.Location = New System.Drawing.Point(113, 134)
        Me.Start_Meter_ReadingTextBox.Name = "Start_Meter_ReadingTextBox"
        Me.Start_Meter_ReadingTextBox.Size = New System.Drawing.Size(78, 20)
        Me.Start_Meter_ReadingTextBox.TabIndex = 3
        '
        'End_Meter_ReadingTextBox
        '
        Me.End_Meter_ReadingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_Day_SheetBindingSource, "End Meter Reading", True))
        Me.End_Meter_ReadingTextBox.Location = New System.Drawing.Point(113, 160)
        Me.End_Meter_ReadingTextBox.Name = "End_Meter_ReadingTextBox"
        Me.End_Meter_ReadingTextBox.Size = New System.Drawing.Size(78, 20)
        Me.End_Meter_ReadingTextBox.TabIndex = 4
        '
        'Public_Transport_CostTextBox
        '
        Me.Public_Transport_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_Day_SheetBindingSource, "Public Transport Cost", True))
        Me.Public_Transport_CostTextBox.Location = New System.Drawing.Point(135, 207)
        Me.Public_Transport_CostTextBox.Name = "Public_Transport_CostTextBox"
        Me.Public_Transport_CostTextBox.Size = New System.Drawing.Size(54, 20)
        Me.Public_Transport_CostTextBox.TabIndex = 6
        '
        'Public_Transport_DetailsTextBox
        '
        Me.Public_Transport_DetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_Day_SheetBindingSource, "Public Transport Details", True))
        Me.Public_Transport_DetailsTextBox.Location = New System.Drawing.Point(135, 233)
        Me.Public_Transport_DetailsTextBox.Multiline = True
        Me.Public_Transport_DetailsTextBox.Name = "Public_Transport_DetailsTextBox"
        Me.Public_Transport_DetailsTextBox.Size = New System.Drawing.Size(200, 36)
        Me.Public_Transport_DetailsTextBox.TabIndex = 7
        '
        'Other_ExpensesTextBox
        '
        Me.Other_ExpensesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_Day_SheetBindingSource, "Other Expenses", True))
        Me.Other_ExpensesTextBox.Location = New System.Drawing.Point(135, 286)
        Me.Other_ExpensesTextBox.Name = "Other_ExpensesTextBox"
        Me.Other_ExpensesTextBox.Size = New System.Drawing.Size(54, 20)
        Me.Other_ExpensesTextBox.TabIndex = 8
        '
        'Other_Expenses_DetailsTextBox
        '
        Me.Other_Expenses_DetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employee_Day_SheetBindingSource, "Other Expenses Details", True))
        Me.Other_Expenses_DetailsTextBox.Location = New System.Drawing.Point(135, 312)
        Me.Other_Expenses_DetailsTextBox.Multiline = True
        Me.Other_Expenses_DetailsTextBox.Name = "Other_Expenses_DetailsTextBox"
        Me.Other_Expenses_DetailsTextBox.Size = New System.Drawing.Size(200, 39)
        Me.Other_Expenses_DetailsTextBox.TabIndex = 9
        '
        'Employee_Day_SheetDataGridView
        '
        Me.Employee_Day_SheetDataGridView.AllowUserToAddRows = False
        Me.Employee_Day_SheetDataGridView.AllowUserToDeleteRows = False
        Me.Employee_Day_SheetDataGridView.AutoGenerateColumns = False
        Me.Employee_Day_SheetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Employee_Day_SheetDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn4})
        Me.Employee_Day_SheetDataGridView.DataSource = Me.Employee_Day_SheetBindingSource
        Me.Employee_Day_SheetDataGridView.Dock = System.Windows.Forms.DockStyle.Left
        Me.Employee_Day_SheetDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Employee_Day_SheetDataGridView.Name = "Employee_Day_SheetDataGridView"
        Me.Employee_Day_SheetDataGridView.RowHeadersWidth = 21
        Me.Employee_Day_SheetDataGridView.Size = New System.Drawing.Size(356, 426)
        Me.Employee_Day_SheetDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Working Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Working Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Present"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Present"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Working Notes"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Working Notes"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 170
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(742, 432)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Day Report"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Employee_Day_SheetTableAdapter
        '
        Me.Employee_Day_SheetTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Companies_VisitedTableAdapter = Nothing
        Me.TableAdapterManager.Company_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.Company_VisitTableAdapter = Nothing
        Me.TableAdapterManager.Employee_Day_SheetTableAdapter = Me.Employee_Day_SheetTableAdapter
        Me.TableAdapterManager.EmployeeCompanyVisitTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeSchoolVisitTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.School_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.School_VisitTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Visited_SchoolsTableAdapter = Nothing
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Day_Sheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 505)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.EmplyNameComboBox)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Day_Sheet"
        Me.Text = "Day_Sheet"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.DaySavePanel.ResumeLayout(False)
        Me.DayRecordPanel.ResumeLayout(False)
        Me.DayRecordPanel.PerformLayout()
        CType(Me.Employee_Day_SheetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employee_Day_SheetDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents EmplyNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Ingenium_2011DataSet As WindowsApplication1.Ingenium_2011DataSet
    Friend WithEvents EmployeeTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Employee_Day_SheetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Employee_Day_SheetTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Employee_Day_SheetTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DayRecordPanel As System.Windows.Forms.Panel
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmplyIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Working_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PresentCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Working_NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Start_Meter_ReadingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents End_Meter_ReadingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Public_Transport_CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Public_Transport_DetailsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Other_ExpensesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Other_Expenses_DetailsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Employee_Day_SheetDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DayEditButton As System.Windows.Forms.Button
    Friend WithEvents DaySavePanel As System.Windows.Forms.Panel
    Friend WithEvents CancelEditButton As System.Windows.Forms.Button
    Friend WithEvents SaveEditButton As System.Windows.Forms.Button
    Friend WithEvents DayAddNewButton As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Petrol_CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
