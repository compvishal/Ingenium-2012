<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class School_Test
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
        Dim TelLabel As System.Windows.Forms.Label
        Dim PCM_StudentsLabel As System.Windows.Forms.Label
        Dim PCB_StudentsLabel As System.Windows.Forms.Label
        Dim Commerce__StudentsLabel As System.Windows.Forms.Label
        Dim Arts_StudentsLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim Test_ConductedLabel As System.Windows.Forms.Label
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.Tested_SchoolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ingenium_2011DataSet = New WindowsApplication1.Ingenium_2011DataSet
        Me.Visited_SchoolsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.SaveButton = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SchoolIdTextBox = New System.Windows.Forms.TextBox
        Me.School_NameTextBox = New System.Windows.Forms.TextBox
        Me.CityTextBox = New System.Windows.Forms.TextBox
        Me.AddressTextBox = New System.Windows.Forms.TextBox
        Me.TelTextBox = New System.Windows.Forms.TextBox
        Me.PCM_StudentsTextBox = New System.Windows.Forms.TextBox
        Me.PCB_StudentsTextBox = New System.Windows.Forms.TextBox
        Me.Commerce__StudentsTextBox = New System.Windows.Forms.TextBox
        Me.Arts_StudentsTextBox = New System.Windows.Forms.TextBox
        Me.TypeTextBox = New System.Windows.Forms.TextBox
        Me.Test_ConductedCheckBox = New System.Windows.Forms.CheckBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.RefreshButton = New System.Windows.Forms.Button
        Me.Visited_SchoolsDataGridView = New System.Windows.Forms.DataGridView
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Visited_SchoolsTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
        Me.Tested_SchoolTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Tested_SchoolTableAdapter
        Me.EmployeeTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.EmployeeTableAdapter
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.NumberStudents = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        SchoolIdLabel = New System.Windows.Forms.Label
        School_NameLabel = New System.Windows.Forms.Label
        CityLabel = New System.Windows.Forms.Label
        AddressLabel = New System.Windows.Forms.Label
        TelLabel = New System.Windows.Forms.Label
        PCM_StudentsLabel = New System.Windows.Forms.Label
        PCB_StudentsLabel = New System.Windows.Forms.Label
        Commerce__StudentsLabel = New System.Windows.Forms.Label
        Arts_StudentsLabel = New System.Windows.Forms.Label
        TypeLabel = New System.Windows.Forms.Label
        Test_ConductedLabel = New System.Windows.Forms.Label
        CType(Me.Tested_SchoolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Visited_SchoolsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Visited_SchoolsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SchoolIdLabel
        '
        SchoolIdLabel.AutoSize = True
        SchoolIdLabel.Location = New System.Drawing.Point(6, 17)
        SchoolIdLabel.Name = "SchoolIdLabel"
        SchoolIdLabel.Size = New System.Drawing.Size(55, 13)
        SchoolIdLabel.TabIndex = 0
        SchoolIdLabel.Text = "School Id:"
        '
        'School_NameLabel
        '
        School_NameLabel.AutoSize = True
        School_NameLabel.Location = New System.Drawing.Point(6, 43)
        School_NameLabel.Name = "School_NameLabel"
        School_NameLabel.Size = New System.Drawing.Size(74, 13)
        School_NameLabel.TabIndex = 2
        School_NameLabel.Text = "School Name:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(6, 69)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 4
        CityLabel.Text = "City:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(6, 95)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 6
        AddressLabel.Text = "Address:"
        '
        'TelLabel
        '
        TelLabel.AutoSize = True
        TelLabel.Location = New System.Drawing.Point(6, 121)
        TelLabel.Name = "TelLabel"
        TelLabel.Size = New System.Drawing.Size(25, 13)
        TelLabel.TabIndex = 8
        TelLabel.Text = "Tel:"
        '
        'PCM_StudentsLabel
        '
        PCM_StudentsLabel.AutoSize = True
        PCM_StudentsLabel.Location = New System.Drawing.Point(6, 147)
        PCM_StudentsLabel.Name = "PCM_StudentsLabel"
        PCM_StudentsLabel.Size = New System.Drawing.Size(78, 13)
        PCM_StudentsLabel.TabIndex = 10
        PCM_StudentsLabel.Text = "PCM Students:"
        '
        'PCB_StudentsLabel
        '
        PCB_StudentsLabel.AutoSize = True
        PCB_StudentsLabel.Location = New System.Drawing.Point(6, 173)
        PCB_StudentsLabel.Name = "PCB_StudentsLabel"
        PCB_StudentsLabel.Size = New System.Drawing.Size(76, 13)
        PCB_StudentsLabel.TabIndex = 12
        PCB_StudentsLabel.Text = "PCB Students:"
        '
        'Commerce__StudentsLabel
        '
        Commerce__StudentsLabel.AutoSize = True
        Commerce__StudentsLabel.Location = New System.Drawing.Point(6, 199)
        Commerce__StudentsLabel.Name = "Commerce__StudentsLabel"
        Commerce__StudentsLabel.Size = New System.Drawing.Size(108, 13)
        Commerce__StudentsLabel.TabIndex = 14
        Commerce__StudentsLabel.Text = "Commerce  Students:"
        '
        'Arts_StudentsLabel
        '
        Arts_StudentsLabel.AutoSize = True
        Arts_StudentsLabel.Location = New System.Drawing.Point(6, 225)
        Arts_StudentsLabel.Name = "Arts_StudentsLabel"
        Arts_StudentsLabel.Size = New System.Drawing.Size(73, 13)
        Arts_StudentsLabel.TabIndex = 16
        Arts_StudentsLabel.Text = "Arts Students:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(6, 251)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(34, 13)
        TypeLabel.TabIndex = 18
        TypeLabel.Text = "Type:"
        '
        'Test_ConductedLabel
        '
        Test_ConductedLabel.AutoSize = True
        Test_ConductedLabel.Location = New System.Drawing.Point(6, 279)
        Test_ConductedLabel.Name = "Test_ConductedLabel"
        Test_ConductedLabel.Size = New System.Drawing.Size(86, 13)
        Test_ConductedLabel.TabIndex = 20
        Test_ConductedLabel.Text = "Test Conducted:"
        '
        'Tested_SchoolBindingSource
        '
        Me.Tested_SchoolBindingSource.DataMember = "Tested School"
        Me.Tested_SchoolBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Ingenium_2011DataSet
        '
        Me.Ingenium_2011DataSet.DataSetName = "Ingenium_2011DataSet"
        Me.Ingenium_2011DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Visited_SchoolsBindingSource
        '
        Me.Visited_SchoolsBindingSource.DataMember = "Visited Schools"
        Me.Visited_SchoolsBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(859, 505)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.SaveButton)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.StatusStrip1)
        Me.TabPage1.Controls.Add(Me.RefreshButton)
        Me.TabPage1.Controls.Add(Me.Visited_SchoolsDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(851, 479)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "School Test"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(732, 15)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 56)
        Me.SaveButton.TabIndex = 4
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(SchoolIdLabel)
        Me.Panel1.Controls.Add(Me.SchoolIdTextBox)
        Me.Panel1.Controls.Add(School_NameLabel)
        Me.Panel1.Controls.Add(Me.School_NameTextBox)
        Me.Panel1.Controls.Add(CityLabel)
        Me.Panel1.Controls.Add(Me.CityTextBox)
        Me.Panel1.Controls.Add(AddressLabel)
        Me.Panel1.Controls.Add(Me.AddressTextBox)
        Me.Panel1.Controls.Add(TelLabel)
        Me.Panel1.Controls.Add(Me.TelTextBox)
        Me.Panel1.Controls.Add(PCM_StudentsLabel)
        Me.Panel1.Controls.Add(Me.PCM_StudentsTextBox)
        Me.Panel1.Controls.Add(PCB_StudentsLabel)
        Me.Panel1.Controls.Add(Me.PCB_StudentsTextBox)
        Me.Panel1.Controls.Add(Commerce__StudentsLabel)
        Me.Panel1.Controls.Add(Me.Commerce__StudentsTextBox)
        Me.Panel1.Controls.Add(Arts_StudentsLabel)
        Me.Panel1.Controls.Add(Me.Arts_StudentsTextBox)
        Me.Panel1.Controls.Add(TypeLabel)
        Me.Panel1.Controls.Add(Me.TypeTextBox)
        Me.Panel1.Controls.Add(Test_ConductedLabel)
        Me.Panel1.Controls.Add(Me.Test_ConductedCheckBox)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(550, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 318)
        Me.Panel1.TabIndex = 3
        '
        'SchoolIdTextBox
        '
        Me.SchoolIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Visited_SchoolsBindingSource, "SchoolId", True))
        Me.SchoolIdTextBox.Location = New System.Drawing.Point(120, 14)
        Me.SchoolIdTextBox.Name = "SchoolIdTextBox"
        Me.SchoolIdTextBox.Size = New System.Drawing.Size(104, 20)
        Me.SchoolIdTextBox.TabIndex = 1
        '
        'School_NameTextBox
        '
        Me.School_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Visited_SchoolsBindingSource, "School Name", True))
        Me.School_NameTextBox.Location = New System.Drawing.Point(120, 40)
        Me.School_NameTextBox.Name = "School_NameTextBox"
        Me.School_NameTextBox.Size = New System.Drawing.Size(159, 20)
        Me.School_NameTextBox.TabIndex = 3
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Visited_SchoolsBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(120, 66)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(104, 20)
        Me.CityTextBox.TabIndex = 5
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Visited_SchoolsBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(120, 92)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(104, 20)
        Me.AddressTextBox.TabIndex = 7
        '
        'TelTextBox
        '
        Me.TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Visited_SchoolsBindingSource, "Tel", True))
        Me.TelTextBox.Location = New System.Drawing.Point(120, 118)
        Me.TelTextBox.Name = "TelTextBox"
        Me.TelTextBox.Size = New System.Drawing.Size(104, 20)
        Me.TelTextBox.TabIndex = 9
        '
        'PCM_StudentsTextBox
        '
        Me.PCM_StudentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Visited_SchoolsBindingSource, "PCM Students", True))
        Me.PCM_StudentsTextBox.Location = New System.Drawing.Point(120, 144)
        Me.PCM_StudentsTextBox.Name = "PCM_StudentsTextBox"
        Me.PCM_StudentsTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PCM_StudentsTextBox.TabIndex = 11
        '
        'PCB_StudentsTextBox
        '
        Me.PCB_StudentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Visited_SchoolsBindingSource, "PCB Students", True))
        Me.PCB_StudentsTextBox.Location = New System.Drawing.Point(120, 170)
        Me.PCB_StudentsTextBox.Name = "PCB_StudentsTextBox"
        Me.PCB_StudentsTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PCB_StudentsTextBox.TabIndex = 13
        '
        'Commerce__StudentsTextBox
        '
        Me.Commerce__StudentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Visited_SchoolsBindingSource, "Commerce  Students", True))
        Me.Commerce__StudentsTextBox.Location = New System.Drawing.Point(120, 196)
        Me.Commerce__StudentsTextBox.Name = "Commerce__StudentsTextBox"
        Me.Commerce__StudentsTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Commerce__StudentsTextBox.TabIndex = 15
        '
        'Arts_StudentsTextBox
        '
        Me.Arts_StudentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Visited_SchoolsBindingSource, "Arts Students", True))
        Me.Arts_StudentsTextBox.Location = New System.Drawing.Point(120, 222)
        Me.Arts_StudentsTextBox.Name = "Arts_StudentsTextBox"
        Me.Arts_StudentsTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Arts_StudentsTextBox.TabIndex = 17
        '
        'TypeTextBox
        '
        Me.TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Visited_SchoolsBindingSource, "Type", True))
        Me.TypeTextBox.Location = New System.Drawing.Point(120, 248)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(104, 20)
        Me.TypeTextBox.TabIndex = 19
        '
        'Test_ConductedCheckBox
        '
        Me.Test_ConductedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Visited_SchoolsBindingSource, "Test Conducted", True))
        Me.Test_ConductedCheckBox.Location = New System.Drawing.Point(120, 274)
        Me.Test_ConductedCheckBox.Name = "Test_ConductedCheckBox"
        Me.Test_ConductedCheckBox.Size = New System.Drawing.Size(26, 24)
        Me.Test_ConductedCheckBox.TabIndex = 21
        Me.Test_ConductedCheckBox.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(544, 454)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(304, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.DarkGray
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
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(613, 15)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 56)
        Me.RefreshButton.TabIndex = 1
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'Visited_SchoolsDataGridView
        '
        Me.Visited_SchoolsDataGridView.AutoGenerateColumns = False
        Me.Visited_SchoolsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Visited_SchoolsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.NumberStudents, Me.DataGridViewComboBoxColumn1})
        Me.Visited_SchoolsDataGridView.DataSource = Me.Visited_SchoolsBindingSource
        Me.Visited_SchoolsDataGridView.Dock = System.Windows.Forms.DockStyle.Left
        Me.Visited_SchoolsDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Visited_SchoolsDataGridView.Name = "Visited_SchoolsDataGridView"
        Me.Visited_SchoolsDataGridView.RowHeadersWidth = 21
        Me.Visited_SchoolsDataGridView.Size = New System.Drawing.Size(541, 473)
        Me.Visited_SchoolsDataGridView.TabIndex = 0
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(851, 479)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tested Schools"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "Ingenium_2011DataSet_Tested_School"
        ReportDataSource4.Value = Me.Tested_SchoolBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Tested Scool.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(845, 473)
        Me.ReportViewer1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ReportViewer2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(851, 479)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Not Tested Schools"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource5.Name = "Ingenium_2011DataSet_Visited_Schools"
        ReportDataSource5.Value = Me.Visited_SchoolsBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Not Tested.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(845, 473)
        Me.ReportViewer2.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ReportViewer3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(851, 479)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Employee Tested"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Visited_SchoolsTableAdapter
        '
        Me.Visited_SchoolsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Companies_VisitedTableAdapter = Nothing
        Me.TableAdapterManager.Company_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.Company_VisitTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeCompanyVisitTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeSchoolVisitTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.School_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.School_VisitTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Visited_SchoolsTableAdapter = Me.Visited_SchoolsTableAdapter
        '
        'Tested_SchoolTableAdapter
        '
        Me.Tested_SchoolTableAdapter.ClearBeforeFill = True
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource6.Name = "Ingenium_2011DataSet_Tested_School"
        ReportDataSource6.Value = Me.Tested_SchoolBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Employee Tested.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(845, 473)
        Me.ReportViewer3.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SchoolId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "School Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "School Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 185
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn3.HeaderText = "City"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Test Conducted"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Test"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'NumberStudents
        '
        Me.NumberStudents.HeaderText = "NumberStudents"
        Me.NumberStudents.Name = "NumberStudents"
        Me.NumberStudents.Width = 60
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.DataPropertyName = "Attached Employee"
        Me.DataGridViewComboBoxColumn1.DataSource = Me.EmployeeBindingSource
        Me.DataGridViewComboBoxColumn1.DisplayMember = "Emply Name"
        Me.DataGridViewComboBoxColumn1.HeaderText = "Attached Employee"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn1.ValueMember = "EmplyId"
        '
        'School_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 505)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "School_Test"
        Me.Text = "School_Test"
        CType(Me.Tested_SchoolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Visited_SchoolsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Visited_SchoolsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Ingenium_2011DataSet As WindowsApplication1.Ingenium_2011DataSet
    Friend WithEvents Visited_SchoolsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Visited_SchoolsTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Visited_SchoolsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SchoolIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents School_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PCM_StudentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PCB_StudentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Commerce__StudentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Arts_StudentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_ConductedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Tested_SchoolBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tested_SchoolTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Tested_SchoolTableAdapter
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NumberStudents As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
