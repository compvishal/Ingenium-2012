<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Marks
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
        Dim SchoolIdLabel As System.Windows.Forms.Label
        Dim School_NameLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.StuEditButton = New System.Windows.Forms.Button
        Me.StuSavePanel = New System.Windows.Forms.Panel
        Me.CancelEditButton = New System.Windows.Forms.Button
        Me.SaveEditButton = New System.Windows.Forms.Button
        Me.StuAddNewButton = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.VisitedSchoolsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ingenium_2011DataSet = New WindowsApplication1.Ingenium_2011DataSet
        Me.SchoolIdTextBox = New System.Windows.Forms.TextBox
        Me.School_NameTextBox = New System.Windows.Forms.TextBox
        Me.CityTextBox = New System.Windows.Forms.TextBox
        Me.AddressTextBox = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Test_ConductedCheckBox = New System.Windows.Forms.CheckBox
        Me.SearchSchoolNameTextBox = New System.Windows.Forms.TextBox
        Me.CancelSearchButton = New System.Windows.Forms.Button
        Me.Visited_SchoolsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.StudentDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.StreamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Visited_SchoolsTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter
        Me.StudentTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.StudentTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
        Me.StreamTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.StreamTableAdapter
        SchoolIdLabel = New System.Windows.Forms.Label
        School_NameLabel = New System.Windows.Forms.Label
        CityLabel = New System.Windows.Forms.Label
        AddressLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.StuSavePanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.VisitedSchoolsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Visited_SchoolsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StreamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SchoolIdLabel
        '
        SchoolIdLabel.AutoSize = True
        SchoolIdLabel.Location = New System.Drawing.Point(3, 34)
        SchoolIdLabel.Name = "SchoolIdLabel"
        SchoolIdLabel.Size = New System.Drawing.Size(55, 13)
        SchoolIdLabel.TabIndex = 0
        SchoolIdLabel.Text = "School Id:"
        '
        'School_NameLabel
        '
        School_NameLabel.AutoSize = True
        School_NameLabel.Location = New System.Drawing.Point(3, 4)
        School_NameLabel.Name = "School_NameLabel"
        School_NameLabel.Size = New System.Drawing.Size(74, 13)
        School_NameLabel.TabIndex = 2
        School_NameLabel.Text = "School Name:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(421, 8)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 4
        CityLabel.Text = "City:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(103, 28)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 6
        AddressLabel.Text = "Address:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(114, 7)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(74, 13)
        Label1.TabIndex = 3
        Label1.Text = "School Name:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 489)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(829, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(20, 17)
        Me.ToolStripStatusLabel1.Text = "T1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(0, 17)
        Me.ToolStripStatusLabel3.ToolTipText = "T3"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.Color.Plum
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(66, 17)
        Me.ToolStripStatusLabel4.Text = "View Mode"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(829, 489)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.Orchid
        Me.TabPage1.Controls.Add(Me.StuEditButton)
        Me.TabPage1.Controls.Add(Me.StuSavePanel)
        Me.TabPage1.Controls.Add(Me.StuAddNewButton)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Visited_SchoolsDataGridView)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(821, 463)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Marks Entry"
        '
        'StuEditButton
        '
        Me.StuEditButton.Location = New System.Drawing.Point(268, 103)
        Me.StuEditButton.Name = "StuEditButton"
        Me.StuEditButton.Size = New System.Drawing.Size(110, 36)
        Me.StuEditButton.TabIndex = 6
        Me.StuEditButton.Text = "&Edit Student Marks"
        Me.StuEditButton.UseVisualStyleBackColor = True
        '
        'StuSavePanel
        '
        Me.StuSavePanel.Controls.Add(Me.CancelEditButton)
        Me.StuSavePanel.Controls.Add(Me.SaveEditButton)
        Me.StuSavePanel.Location = New System.Drawing.Point(404, 100)
        Me.StuSavePanel.Name = "StuSavePanel"
        Me.StuSavePanel.Size = New System.Drawing.Size(164, 39)
        Me.StuSavePanel.TabIndex = 7
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
        'StuAddNewButton
        '
        Me.StuAddNewButton.Location = New System.Drawing.Point(584, 101)
        Me.StuAddNewButton.Name = "StuAddNewButton"
        Me.StuAddNewButton.Size = New System.Drawing.Size(100, 36)
        Me.StuAddNewButton.TabIndex = 5
        Me.StuAddNewButton.Text = "Add &New Student"
        Me.StuAddNewButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.CheckBox1)
        Me.Panel3.Controls.Add(SchoolIdLabel)
        Me.Panel3.Controls.Add(Me.SchoolIdTextBox)
        Me.Panel3.Controls.Add(School_NameLabel)
        Me.Panel3.Controls.Add(Me.School_NameTextBox)
        Me.Panel3.Controls.Add(CityLabel)
        Me.Panel3.Controls.Add(Me.CityTextBox)
        Me.Panel3.Controls.Add(AddressLabel)
        Me.Panel3.Controls.Add(Me.AddressTextBox)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(252, 46)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(564, 53)
        Me.Panel3.TabIndex = 4
        '
        'CheckBox1
        '
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.VisitedSchoolsBindingSource, "Test Conducted", True))
        Me.CheckBox1.Location = New System.Drawing.Point(440, 26)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(112, 24)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Test Conducted"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'VisitedSchoolsBindingSource
        '
        Me.VisitedSchoolsBindingSource.DataMember = "Visited Schools"
        Me.VisitedSchoolsBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Ingenium_2011DataSet
        '
        Me.Ingenium_2011DataSet.DataSetName = "Ingenium_2011DataSet"
        Me.Ingenium_2011DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SchoolIdTextBox
        '
        Me.SchoolIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitedSchoolsBindingSource, "SchoolId", True))
        Me.SchoolIdTextBox.Location = New System.Drawing.Point(64, 28)
        Me.SchoolIdTextBox.Name = "SchoolIdTextBox"
        Me.SchoolIdTextBox.Size = New System.Drawing.Size(33, 20)
        Me.SchoolIdTextBox.TabIndex = 1
        '
        'School_NameTextBox
        '
        Me.School_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitedSchoolsBindingSource, "School Name", True))
        Me.School_NameTextBox.Location = New System.Drawing.Point(83, 1)
        Me.School_NameTextBox.Name = "School_NameTextBox"
        Me.School_NameTextBox.Size = New System.Drawing.Size(332, 20)
        Me.School_NameTextBox.TabIndex = 3
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitedSchoolsBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(454, 5)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(98, 20)
        Me.CityTextBox.TabIndex = 5
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitedSchoolsBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(157, 25)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(258, 20)
        Me.AddressTextBox.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.Test_ConductedCheckBox)
        Me.Panel2.Controls.Add(Label1)
        Me.Panel2.Controls.Add(Me.SearchSchoolNameTextBox)
        Me.Panel2.Controls.Add(Me.CancelSearchButton)
        Me.Panel2.Location = New System.Drawing.Point(251, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(566, 33)
        Me.Panel2.TabIndex = 3
        '
        'Test_ConductedCheckBox
        '
        Me.Test_ConductedCheckBox.Location = New System.Drawing.Point(400, 7)
        Me.Test_ConductedCheckBox.Name = "Test_ConductedCheckBox"
        Me.Test_ConductedCheckBox.Size = New System.Drawing.Size(162, 24)
        Me.Test_ConductedCheckBox.TabIndex = 4
        Me.Test_ConductedCheckBox.Text = "Show Only Test Conducted"
        Me.Test_ConductedCheckBox.UseVisualStyleBackColor = True
        '
        'SearchSchoolNameTextBox
        '
        Me.SearchSchoolNameTextBox.Location = New System.Drawing.Point(194, 4)
        Me.SearchSchoolNameTextBox.Name = "SearchSchoolNameTextBox"
        Me.SearchSchoolNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SearchSchoolNameTextBox.TabIndex = 1
        '
        'CancelSearchButton
        '
        Me.CancelSearchButton.Location = New System.Drawing.Point(10, 4)
        Me.CancelSearchButton.Name = "CancelSearchButton"
        Me.CancelSearchButton.Size = New System.Drawing.Size(93, 23)
        Me.CancelSearchButton.TabIndex = 0
        Me.CancelSearchButton.Text = "Cancel Search"
        Me.CancelSearchButton.UseVisualStyleBackColor = True
        '
        'Visited_SchoolsDataGridView
        '
        Me.Visited_SchoolsDataGridView.AllowUserToAddRows = False
        Me.Visited_SchoolsDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Visited_SchoolsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Visited_SchoolsDataGridView.AutoGenerateColumns = False
        Me.Visited_SchoolsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Visited_SchoolsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn6})
        Me.Visited_SchoolsDataGridView.DataSource = Me.VisitedSchoolsBindingSource
        Me.Visited_SchoolsDataGridView.Dock = System.Windows.Forms.DockStyle.Left
        Me.Visited_SchoolsDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Visited_SchoolsDataGridView.Name = "Visited_SchoolsDataGridView"
        Me.Visited_SchoolsDataGridView.RowHeadersWidth = 11
        Me.Visited_SchoolsDataGridView.Size = New System.Drawing.Size(243, 457)
        Me.Visited_SchoolsDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "School Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "School Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 140
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn6.HeaderText = "City"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.StudentDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(249, 143)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 314)
        Me.Panel1.TabIndex = 2
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.AllowUserToAddRows = False
        Me.StudentDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StudentDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.StudentDataGridView.AutoGenerateColumns = False
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.StudentDataGridView.DataSource = Me.StudentBindingSource
        Me.StudentDataGridView.Location = New System.Drawing.Point(0, 3)
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.RowHeadersWidth = 21
        Me.StudentDataGridView.Size = New System.Drawing.Size(555, 308)
        Me.StudentDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Stream"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.StreamBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Stream"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Stream"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "StreamId"
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'StreamBindingSource
        '
        Me.StreamBindingSource.DataMember = "Stream"
        Me.StreamBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Student Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Student Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Father Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Father Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "10th Grade"
        Me.DataGridViewTextBoxColumn15.HeaderText = "10th Grade"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 70
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Ingenium%"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Ingenium%"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 70
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Discount offered"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Discount offered"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 70
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Visited Schools_Student"
        Me.StudentBindingSource.DataSource = Me.VisitedSchoolsBindingSource
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(821, 463)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Report"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Visited_SchoolsTableAdapter
        '
        Me.Visited_SchoolsTableAdapter.ClearBeforeFill = True
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._12thTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Companies_VisitedTableAdapter = Nothing
        Me.TableAdapterManager.Company_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.Company_VisitTableAdapter = Nothing
        Me.TableAdapterManager.Employee_Day_SheetTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeCompanyVisitTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeSchoolVisitTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.Event_MasterTableAdapter = Nothing
        Me.TableAdapterManager.Event_SchoolTableAdapter = Nothing
        Me.TableAdapterManager.Event_StudentsTableAdapter = Nothing
        Me.TableAdapterManager.Interested_StudentTableAdapter = Nothing
        Me.TableAdapterManager.School_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.School_VisitTableAdapter = Nothing
        Me.TableAdapterManager.SMS_TextTableAdapter = Nothing
        Me.TableAdapterManager.StreamTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Me.StudentTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Visited_SchoolsTableAdapter = Me.Visited_SchoolsTableAdapter
        '
        'StreamTableAdapter
        '
        Me.StreamTableAdapter.ClearBeforeFill = True
        '
        'Marks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 511)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Marks"
        Me.Text = "Marks"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.StuSavePanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.VisitedSchoolsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Visited_SchoolsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StreamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Ingenium_2011DataSet As WindowsApplication1.Ingenium_2011DataSet
    Friend WithEvents VisitedSchoolsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Visited_SchoolsTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.StudentTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SchoolIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents School_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Visited_SchoolsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SearchSchoolNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CancelSearchButton As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Test_ConductedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StuEditButton As System.Windows.Forms.Button
    Friend WithEvents StuSavePanel As System.Windows.Forms.Panel
    Friend WithEvents CancelEditButton As System.Windows.Forms.Button
    Friend WithEvents SaveEditButton As System.Windows.Forms.Button
    Friend WithEvents StuAddNewButton As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StreamBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StreamTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.StreamTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
