<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Event_Master
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
        Me.components = New System.ComponentModel.Container()
        Dim EventIdLabel As System.Windows.Forms.Label
        Dim Event_NameLabel As System.Windows.Forms.Label
        Dim Event_DateLabel As System.Windows.Forms.Label
        Dim CommentsLabel As System.Windows.Forms.Label
        Dim SchoolIdLabel As System.Windows.Forms.Label
        Dim School_NameLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Attached_EmployeeLabel As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim Label3 As System.Windows.Forms.Label
        Me.Event_Student_CompleteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ingenium_2011DataSet = New WindowsApplication1.Ingenium_2011DataSet()
        Me.Complete_School_in_EventBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompleteSchoolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Event_MasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Event_MasterTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_MasterTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager()
        Me.Event_SchoolTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_SchoolTableAdapter()
        Me.Visited_SchoolsTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.EditEventButton = New System.Windows.Forms.Button()
        Me.EventSaveCancelPanel = New System.Windows.Forms.Panel()
        Me.CancelRecordButton = New System.Windows.Forms.Button()
        Me.SaveRecordButton = New System.Windows.Forms.Button()
        Me.AddNewEventButton = New System.Windows.Forms.Button()
        Me.Event_SchoolDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.VisitedSchoolsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Event_SchoolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Event_MasterDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolPanel = New System.Windows.Forms.Panel()
        Me.PanelAdmin = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UpdateStudentButton = New System.Windows.Forms.Button()
        Me.RemoveSchoolButton = New System.Windows.Forms.Button()
        Me.AddSchoolButton = New System.Windows.Forms.Button()
        Me.Visited_SchoolsDataGridView = New System.Windows.Forms.DataGridView()
        Me.SchoolId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ingenium_2011DataSet1 = New WindowsApplication1.Ingenium_2011DataSet()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SchoolIdTextBox = New System.Windows.Forms.TextBox()
        Me.School_NameTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.SearchCityTextBox = New System.Windows.Forms.TextBox()
        Me.SearchSchoolNameTextBox = New System.Windows.Forms.TextBox()
        Me.CancelSearchButton = New System.Windows.Forms.Button()
        Me.EventMasterPanel = New System.Windows.Forms.Panel()
        Me.EventFinishedCheckBox = New System.Windows.Forms.CheckBox()
        Me.EventIdTextBox = New System.Windows.Forms.TextBox()
        Me.Event_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Event_DateTextBox = New System.Windows.Forms.TextBox()
        Me.CommentsTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.EmployeeTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.EmployeeTableAdapter()
        Me.CompleteSchoolTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.CompleteSchoolTableAdapter()
        Me.Complete_School_in_EventTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Complete_School_in_EventTableAdapter()
        Me.Event_Student_CompleteTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_Student_CompleteTableAdapter()
        Me.SearchTextBoxSchoolId = New System.Windows.Forms.TextBox()
        EventIdLabel = New System.Windows.Forms.Label()
        Event_NameLabel = New System.Windows.Forms.Label()
        Event_DateLabel = New System.Windows.Forms.Label()
        CommentsLabel = New System.Windows.Forms.Label()
        SchoolIdLabel = New System.Windows.Forms.Label()
        School_NameLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Attached_EmployeeLabel = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.Event_Student_CompleteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Complete_School_in_EventBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompleteSchoolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_MasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.EventSaveCancelPanel.SuspendLayout()
        CType(Me.Event_SchoolDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitedSchoolsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_SchoolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_MasterDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SchoolPanel.SuspendLayout()
        Me.PanelAdmin.SuspendLayout()
        CType(Me.Visited_SchoolsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingenium_2011DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.EventMasterPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EventIdLabel
        '
        EventIdLabel.AutoSize = True
        EventIdLabel.Location = New System.Drawing.Point(9, 4)
        EventIdLabel.Name = "EventIdLabel"
        EventIdLabel.Size = New System.Drawing.Size(65, 17)
        EventIdLabel.TabIndex = 0
        EventIdLabel.Text = "Event Id:"
        '
        'Event_NameLabel
        '
        Event_NameLabel.AutoSize = True
        Event_NameLabel.Location = New System.Drawing.Point(9, 32)
        Event_NameLabel.Name = "Event_NameLabel"
        Event_NameLabel.Size = New System.Drawing.Size(88, 17)
        Event_NameLabel.TabIndex = 2
        Event_NameLabel.Text = "Event Name:"
        '
        'Event_DateLabel
        '
        Event_DateLabel.AutoSize = True
        Event_DateLabel.Location = New System.Drawing.Point(150, 4)
        Event_DateLabel.Name = "Event_DateLabel"
        Event_DateLabel.Size = New System.Drawing.Size(82, 17)
        Event_DateLabel.TabIndex = 4
        Event_DateLabel.Text = "Event Date:"
        '
        'CommentsLabel
        '
        CommentsLabel.AutoSize = True
        CommentsLabel.Location = New System.Drawing.Point(9, 64)
        CommentsLabel.Name = "CommentsLabel"
        CommentsLabel.Size = New System.Drawing.Size(80, 17)
        CommentsLabel.TabIndex = 6
        CommentsLabel.Text = "Comments:"
        '
        'SchoolIdLabel
        '
        SchoolIdLabel.AutoSize = True
        SchoolIdLabel.Location = New System.Drawing.Point(394, 50)
        SchoolIdLabel.Name = "SchoolIdLabel"
        SchoolIdLabel.Size = New System.Drawing.Size(70, 17)
        SchoolIdLabel.TabIndex = 0
        SchoolIdLabel.Text = "School Id:"
        '
        'School_NameLabel
        '
        School_NameLabel.AutoSize = True
        School_NameLabel.Location = New System.Drawing.Point(3, 14)
        School_NameLabel.Name = "School_NameLabel"
        School_NameLabel.Size = New System.Drawing.Size(93, 17)
        School_NameLabel.TabIndex = 2
        School_NameLabel.Text = "School Name:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(6, 46)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(37, 17)
        CityLabel.TabIndex = 4
        CityLabel.Text = "City:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(6, 81)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(61, 17)
        AddressLabel.TabIndex = 6
        AddressLabel.Text = "Address:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(125, 7)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(93, 17)
        Label1.TabIndex = 3
        Label1.Text = "School Name:"
        '
        'Attached_EmployeeLabel
        '
        Attached_EmployeeLabel.AutoSize = True
        Attached_EmployeeLabel.Location = New System.Drawing.Point(339, 81)
        Attached_EmployeeLabel.Name = "Attached_EmployeeLabel"
        Attached_EmployeeLabel.Size = New System.Drawing.Size(132, 17)
        Attached_EmployeeLabel.TabIndex = 9
        Attached_EmployeeLabel.Text = "Attached Employee:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(358, 30)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(61, 17)
        Label8.TabIndex = 27
        Label8.Text = "Address:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(181, 32)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(37, 17)
        Label5.TabIndex = 25
        Label5.Text = "City:"
        '
        'Event_Student_CompleteBindingSource
        '
        Me.Event_Student_CompleteBindingSource.DataMember = "Event Student Complete"
        Me.Event_Student_CompleteBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Ingenium_2011DataSet
        '
        Me.Ingenium_2011DataSet.DataSetName = "Ingenium_2011DataSet"
        Me.Ingenium_2011DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Complete_School_in_EventBindingSource
        '
        Me.Complete_School_in_EventBindingSource.DataMember = "Complete School in Event"
        Me.Complete_School_in_EventBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'CompleteSchoolBindingSource
        '
        Me.CompleteSchoolBindingSource.DataMember = "CompleteSchool"
        Me.CompleteSchoolBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Event_MasterBindingSource
        '
        Me.Event_MasterBindingSource.DataMember = "Event Master"
        Me.Event_MasterBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Event_MasterTableAdapter
        '
        Me.Event_MasterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._12thTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CityTableAdapter = Nothing
        Me.TableAdapterManager.Companies_VisitedTableAdapter = Nothing
        Me.TableAdapterManager.Company_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.Company_VisitTableAdapter = Nothing
        Me.TableAdapterManager.ContactsTableAdapter = Nothing
        Me.TableAdapterManager.Employee_Day_SheetTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeCompanyVisitTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeSchoolVisitTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.Event_MasterTableAdapter = Me.Event_MasterTableAdapter
        Me.TableAdapterManager.Event_SchoolTableAdapter = Me.Event_SchoolTableAdapter
        Me.TableAdapterManager.Event_StudentsTableAdapter = Nothing
        Me.TableAdapterManager.Interested_StudentTableAdapter = Nothing
        Me.TableAdapterManager.School_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.School_VisitTableAdapter = Nothing
        Me.TableAdapterManager.SectorTableAdapter = Nothing
        Me.TableAdapterManager.SMS_TextTableAdapter = Nothing
        Me.TableAdapterManager.StreamTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Visited_SchoolsTableAdapter = Me.Visited_SchoolsTableAdapter
        '
        'Event_SchoolTableAdapter
        '
        Me.Event_SchoolTableAdapter.ClearBeforeFill = True
        '
        'Visited_SchoolsTableAdapter
        '
        Me.Visited_SchoolsTableAdapter.ClearBeforeFill = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Size = New System.Drawing.Size(951, 661)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "School Report"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "Ingenium_2011DataSet_Event_Student_Complete"
        ReportDataSource4.Value = Me.Event_Student_CompleteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event School-Just Summary.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 4)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(945, 653)
        Me.ReportViewer1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.StatusStrip1)
        Me.TabPage1.Controls.Add(Me.EditEventButton)
        Me.TabPage1.Controls.Add(Me.EventSaveCancelPanel)
        Me.TabPage1.Controls.Add(Me.AddNewEventButton)
        Me.TabPage1.Controls.Add(Me.Event_SchoolDataGridView)
        Me.TabPage1.Controls.Add(Me.Event_MasterDataGridView)
        Me.TabPage1.Controls.Add(Me.SchoolPanel)
        Me.TabPage1.Controls.Add(Me.EventMasterPanel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(951, 661)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Event Data"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 631)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(945, 26)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.Plum
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'EditEventButton
        '
        Me.EditEventButton.Location = New System.Drawing.Point(335, 59)
        Me.EditEventButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EditEventButton.Name = "EditEventButton"
        Me.EditEventButton.Size = New System.Drawing.Size(76, 34)
        Me.EditEventButton.TabIndex = 7
        Me.EditEventButton.Text = "&Edit Event Data"
        Me.EditEventButton.UseVisualStyleBackColor = True
        '
        'EventSaveCancelPanel
        '
        Me.EventSaveCancelPanel.Controls.Add(Me.CancelRecordButton)
        Me.EventSaveCancelPanel.Controls.Add(Me.SaveRecordButton)
        Me.EventSaveCancelPanel.Location = New System.Drawing.Point(418, 4)
        Me.EventSaveCancelPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EventSaveCancelPanel.Name = "EventSaveCancelPanel"
        Me.EventSaveCancelPanel.Size = New System.Drawing.Size(87, 100)
        Me.EventSaveCancelPanel.TabIndex = 8
        '
        'CancelRecordButton
        '
        Me.CancelRecordButton.Location = New System.Drawing.Point(6, 55)
        Me.CancelRecordButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CancelRecordButton.Name = "CancelRecordButton"
        Me.CancelRecordButton.Size = New System.Drawing.Size(76, 34)
        Me.CancelRecordButton.TabIndex = 19
        Me.CancelRecordButton.Text = "&Cancel"
        Me.CancelRecordButton.UseVisualStyleBackColor = True
        '
        'SaveRecordButton
        '
        Me.SaveRecordButton.Location = New System.Drawing.Point(6, 4)
        Me.SaveRecordButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SaveRecordButton.Name = "SaveRecordButton"
        Me.SaveRecordButton.Size = New System.Drawing.Size(76, 44)
        Me.SaveRecordButton.TabIndex = 18
        Me.SaveRecordButton.Text = "&Save"
        Me.SaveRecordButton.UseVisualStyleBackColor = True
        '
        'AddNewEventButton
        '
        Me.AddNewEventButton.Location = New System.Drawing.Point(335, 7)
        Me.AddNewEventButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddNewEventButton.Name = "AddNewEventButton"
        Me.AddNewEventButton.Size = New System.Drawing.Size(76, 44)
        Me.AddNewEventButton.TabIndex = 6
        Me.AddNewEventButton.Text = "Add &New Event"
        Me.AddNewEventButton.UseVisualStyleBackColor = True
        '
        'Event_SchoolDataGridView
        '
        Me.Event_SchoolDataGridView.AllowUserToAddRows = False
        Me.Event_SchoolDataGridView.AllowUserToDeleteRows = False
        Me.Event_SchoolDataGridView.AutoGenerateColumns = False
        Me.Event_SchoolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Event_SchoolDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5})
        Me.Event_SchoolDataGridView.DataSource = Me.Event_SchoolBindingSource
        Me.Event_SchoolDataGridView.Location = New System.Drawing.Point(7, 247)
        Me.Event_SchoolDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Event_SchoolDataGridView.Name = "Event_SchoolDataGridView"
        Me.Event_SchoolDataGridView.ReadOnly = True
        Me.Event_SchoolDataGridView.RowHeadersWidth = 21
        Me.Event_SchoolDataGridView.Size = New System.Drawing.Size(339, 373)
        Me.Event_SchoolDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SchoolId"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.VisitedSchoolsBindingSource
        Me.DataGridViewTextBoxColumn5.DisplayMember = "School Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SchoolId"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "SchoolId"
        Me.DataGridViewTextBoxColumn5.Width = 250
        '
        'VisitedSchoolsBindingSource
        '
        Me.VisitedSchoolsBindingSource.DataMember = "Visited Schools"
        Me.VisitedSchoolsBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Event_SchoolBindingSource
        '
        Me.Event_SchoolBindingSource.DataMember = "Event MasterEvent School"
        Me.Event_SchoolBindingSource.DataSource = Me.Event_MasterBindingSource
        '
        'Event_MasterDataGridView
        '
        Me.Event_MasterDataGridView.AutoGenerateColumns = False
        Me.Event_MasterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Event_MasterDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Event_MasterDataGridView.DataSource = Me.Event_MasterBindingSource
        Me.Event_MasterDataGridView.Location = New System.Drawing.Point(7, 7)
        Me.Event_MasterDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Event_MasterDataGridView.Name = "Event_MasterDataGridView"
        Me.Event_MasterDataGridView.RowHeadersWidth = 21
        Me.Event_MasterDataGridView.Size = New System.Drawing.Size(321, 233)
        Me.Event_MasterDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Event Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Event Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Event Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Event Date"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'SchoolPanel
        '
        Me.SchoolPanel.BackColor = System.Drawing.Color.BurlyWood
        Me.SchoolPanel.Controls.Add(Me.PanelAdmin)
        Me.SchoolPanel.Controls.Add(Me.AddSchoolButton)
        Me.SchoolPanel.Controls.Add(Me.Visited_SchoolsDataGridView)
        Me.SchoolPanel.Controls.Add(Me.Panel3)
        Me.SchoolPanel.Controls.Add(Me.Panel1)
        Me.SchoolPanel.Location = New System.Drawing.Point(353, 101)
        Me.SchoolPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SchoolPanel.Name = "SchoolPanel"
        Me.SchoolPanel.Size = New System.Drawing.Size(582, 519)
        Me.SchoolPanel.TabIndex = 3
        '
        'PanelAdmin
        '
        Me.PanelAdmin.BackColor = System.Drawing.Color.Bisque
        Me.PanelAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAdmin.Controls.Add(Me.Label2)
        Me.PanelAdmin.Controls.Add(Me.UpdateStudentButton)
        Me.PanelAdmin.Controls.Add(Me.RemoveSchoolButton)
        Me.PanelAdmin.Location = New System.Drawing.Point(203, 437)
        Me.PanelAdmin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelAdmin.Name = "PanelAdmin"
        Me.PanelAdmin.Size = New System.Drawing.Size(326, 57)
        Me.PanelAdmin.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Admin"
        '
        'UpdateStudentButton
        '
        Me.UpdateStudentButton.Location = New System.Drawing.Point(65, 0)
        Me.UpdateStudentButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UpdateStudentButton.Name = "UpdateStudentButton"
        Me.UpdateStudentButton.Size = New System.Drawing.Size(126, 54)
        Me.UpdateStudentButton.TabIndex = 8
        Me.UpdateStudentButton.Text = "Update Student List"
        Me.UpdateStudentButton.UseVisualStyleBackColor = True
        '
        'RemoveSchoolButton
        '
        Me.RemoveSchoolButton.Location = New System.Drawing.Point(197, 0)
        Me.RemoveSchoolButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RemoveSchoolButton.Name = "RemoveSchoolButton"
        Me.RemoveSchoolButton.Size = New System.Drawing.Size(126, 54)
        Me.RemoveSchoolButton.TabIndex = 9
        Me.RemoveSchoolButton.Text = "Remove School from Event"
        Me.RemoveSchoolButton.UseVisualStyleBackColor = True
        '
        'AddSchoolButton
        '
        Me.AddSchoolButton.Location = New System.Drawing.Point(7, 441)
        Me.AddSchoolButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddSchoolButton.Name = "AddSchoolButton"
        Me.AddSchoolButton.Size = New System.Drawing.Size(146, 54)
        Me.AddSchoolButton.TabIndex = 7
        Me.AddSchoolButton.Text = "Add School to Event"
        Me.AddSchoolButton.UseVisualStyleBackColor = True
        '
        'Visited_SchoolsDataGridView
        '
        Me.Visited_SchoolsDataGridView.AutoGenerateColumns = False
        Me.Visited_SchoolsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Visited_SchoolsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SchoolId, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6})
        Me.Visited_SchoolsDataGridView.DataSource = Me.VisitedSchoolsBindingSource
        Me.Visited_SchoolsDataGridView.Location = New System.Drawing.Point(13, 73)
        Me.Visited_SchoolsDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Visited_SchoolsDataGridView.Name = "Visited_SchoolsDataGridView"
        Me.Visited_SchoolsDataGridView.RowHeadersWidth = 51
        Me.Visited_SchoolsDataGridView.Size = New System.Drawing.Size(546, 222)
        Me.Visited_SchoolsDataGridView.TabIndex = 6
        '
        'SchoolId
        '
        Me.SchoolId.DataPropertyName = "SchoolId"
        Me.SchoolId.HeaderText = "SchoolId"
        Me.SchoolId.MinimumWidth = 6
        Me.SchoolId.Name = "SchoolId"
        Me.SchoolId.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "School Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "School Name"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 260
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn6.HeaderText = "City"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Attached_EmployeeLabel)
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
        Me.Panel3.Location = New System.Drawing.Point(3, 302)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(526, 132)
        Me.Panel3.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VisitedSchoolsBindingSource, "Attached Employee", True))
        Me.ComboBox1.DataSource = Me.EmployeeBindingSource
        Me.ComboBox1.DisplayMember = "Emply Name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(325, 101)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(184, 24)
        Me.ComboBox1.TabIndex = 10
        Me.ComboBox1.ValueMember = "EmplyId"
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Ingenium_2011DataSet1
        '
        'Ingenium_2011DataSet1
        '
        Me.Ingenium_2011DataSet1.DataSetName = "Ingenium_2011DataSet"
        Me.Ingenium_2011DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBox1
        '
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.VisitedSchoolsBindingSource, "Test Conducted", True))
        Me.CheckBox1.Location = New System.Drawing.Point(265, 46)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(131, 30)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Test Conducted"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'SchoolIdTextBox
        '
        Me.SchoolIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitedSchoolsBindingSource, "SchoolId", True))
        Me.SchoolIdTextBox.Location = New System.Drawing.Point(465, 43)
        Me.SchoolIdTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SchoolIdTextBox.Name = "SchoolIdTextBox"
        Me.SchoolIdTextBox.Size = New System.Drawing.Size(38, 24)
        Me.SchoolIdTextBox.TabIndex = 1
        '
        'School_NameTextBox
        '
        Me.School_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitedSchoolsBindingSource, "School Name", True))
        Me.School_NameTextBox.Location = New System.Drawing.Point(97, 10)
        Me.School_NameTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.School_NameTextBox.Name = "School_NameTextBox"
        Me.School_NameTextBox.Size = New System.Drawing.Size(387, 24)
        Me.School_NameTextBox.TabIndex = 3
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitedSchoolsBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(44, 42)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(205, 24)
        Me.CityTextBox.TabIndex = 5
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitedSchoolsBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(69, 78)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(240, 48)
        Me.AddressTextBox.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.SearchTextBoxSchoolId)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.TextBoxAddress)
        Me.Panel1.Controls.Add(Label8)
        Me.Panel1.Controls.Add(Me.SearchCityTextBox)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Me.SearchSchoolNameTextBox)
        Me.Panel1.Controls.Add(Me.CancelSearchButton)
        Me.Panel1.Location = New System.Drawing.Point(3, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(555, 62)
        Me.Panel1.TabIndex = 5
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Location = New System.Drawing.Point(421, 28)
        Me.TextBoxAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(115, 24)
        Me.TextBoxAddress.TabIndex = 28
        '
        'SearchCityTextBox
        '
        Me.SearchCityTextBox.Location = New System.Drawing.Point(218, 29)
        Me.SearchCityTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchCityTextBox.Name = "SearchCityTextBox"
        Me.SearchCityTextBox.Size = New System.Drawing.Size(115, 24)
        Me.SearchCityTextBox.TabIndex = 26
        '
        'SearchSchoolNameTextBox
        '
        Me.SearchSchoolNameTextBox.Location = New System.Drawing.Point(218, 4)
        Me.SearchSchoolNameTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchSchoolNameTextBox.Name = "SearchSchoolNameTextBox"
        Me.SearchSchoolNameTextBox.Size = New System.Drawing.Size(291, 24)
        Me.SearchSchoolNameTextBox.TabIndex = 1
        '
        'CancelSearchButton
        '
        Me.CancelSearchButton.Location = New System.Drawing.Point(3, 4)
        Me.CancelSearchButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CancelSearchButton.Name = "CancelSearchButton"
        Me.CancelSearchButton.Size = New System.Drawing.Size(108, 28)
        Me.CancelSearchButton.TabIndex = 0
        Me.CancelSearchButton.Text = "Cancel Search"
        Me.CancelSearchButton.UseVisualStyleBackColor = True
        '
        'EventMasterPanel
        '
        Me.EventMasterPanel.BackColor = System.Drawing.Color.PowderBlue
        Me.EventMasterPanel.Controls.Add(Me.EventFinishedCheckBox)
        Me.EventMasterPanel.Controls.Add(EventIdLabel)
        Me.EventMasterPanel.Controls.Add(Me.EventIdTextBox)
        Me.EventMasterPanel.Controls.Add(Event_NameLabel)
        Me.EventMasterPanel.Controls.Add(Me.Event_NameTextBox)
        Me.EventMasterPanel.Controls.Add(Event_DateLabel)
        Me.EventMasterPanel.Controls.Add(Me.Event_DateTextBox)
        Me.EventMasterPanel.Controls.Add(CommentsLabel)
        Me.EventMasterPanel.Controls.Add(Me.CommentsTextBox)
        Me.EventMasterPanel.Location = New System.Drawing.Point(512, 4)
        Me.EventMasterPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EventMasterPanel.Name = "EventMasterPanel"
        Me.EventMasterPanel.Size = New System.Drawing.Size(423, 90)
        Me.EventMasterPanel.TabIndex = 2
        '
        'EventFinishedCheckBox
        '
        Me.EventFinishedCheckBox.AutoSize = True
        Me.EventFinishedCheckBox.Enabled = False
        Me.EventFinishedCheckBox.Location = New System.Drawing.Point(238, 28)
        Me.EventFinishedCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EventFinishedCheckBox.Name = "EventFinishedCheckBox"
        Me.EventFinishedCheckBox.Size = New System.Drawing.Size(78, 21)
        Me.EventFinishedCheckBox.TabIndex = 8
        Me.EventFinishedCheckBox.Text = "Finished"
        Me.EventFinishedCheckBox.UseVisualStyleBackColor = True
        '
        'EventIdTextBox
        '
        Me.EventIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_MasterBindingSource, "EventId", True))
        Me.EventIdTextBox.Location = New System.Drawing.Point(75, 0)
        Me.EventIdTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EventIdTextBox.Name = "EventIdTextBox"
        Me.EventIdTextBox.Size = New System.Drawing.Size(68, 24)
        Me.EventIdTextBox.TabIndex = 1
        '
        'Event_NameTextBox
        '
        Me.Event_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_MasterBindingSource, "Event Name", True))
        Me.Event_NameTextBox.Location = New System.Drawing.Point(97, 28)
        Me.Event_NameTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Event_NameTextBox.Name = "Event_NameTextBox"
        Me.Event_NameTextBox.Size = New System.Drawing.Size(116, 24)
        Me.Event_NameTextBox.TabIndex = 3
        '
        'Event_DateTextBox
        '
        Me.Event_DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_MasterBindingSource, "Event Date", True))
        Me.Event_DateTextBox.Location = New System.Drawing.Point(232, 0)
        Me.Event_DateTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Event_DateTextBox.Name = "Event_DateTextBox"
        Me.Event_DateTextBox.Size = New System.Drawing.Size(138, 24)
        Me.Event_DateTextBox.TabIndex = 5
        '
        'CommentsTextBox
        '
        Me.CommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_MasterBindingSource, "Comments", True))
        Me.CommentsTextBox.Location = New System.Drawing.Point(97, 60)
        Me.CommentsTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CommentsTextBox.Multiline = True
        Me.CommentsTextBox.Name = "CommentsTextBox"
        Me.CommentsTextBox.Size = New System.Drawing.Size(296, 22)
        Me.CommentsTextBox.TabIndex = 7
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(959, 690)
        Me.TabControl1.TabIndex = 0
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'CompleteSchoolTableAdapter
        '
        Me.CompleteSchoolTableAdapter.ClearBeforeFill = True
        '
        'Complete_School_in_EventTableAdapter
        '
        Me.Complete_School_in_EventTableAdapter.ClearBeforeFill = True
        '
        'Event_Student_CompleteTableAdapter
        '
        Me.Event_Student_CompleteTableAdapter.ClearBeforeFill = True
        '
        'SearchTextBoxSchoolId
        '
        Me.SearchTextBoxSchoolId.Location = New System.Drawing.Point(77, 33)
        Me.SearchTextBoxSchoolId.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchTextBoxSchoolId.Name = "SearchTextBoxSchoolId"
        Me.SearchTextBoxSchoolId.Size = New System.Drawing.Size(67, 24)
        Me.SearchTextBoxSchoolId.TabIndex = 30
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(7, 36)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(70, 17)
        Label3.TabIndex = 29
        Label3.Text = "School Id:"
        '
        'Event_Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 690)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Event_Master"
        Me.Text = "Event_Master"
        CType(Me.Event_Student_CompleteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Complete_School_in_EventBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompleteSchoolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_MasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.EventSaveCancelPanel.ResumeLayout(False)
        CType(Me.Event_SchoolDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitedSchoolsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_SchoolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_MasterDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SchoolPanel.ResumeLayout(False)
        Me.PanelAdmin.ResumeLayout(False)
        Me.PanelAdmin.PerformLayout()
        CType(Me.Visited_SchoolsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingenium_2011DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.EventMasterPanel.ResumeLayout(False)
        Me.EventMasterPanel.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ingenium_2011DataSet As WindowsApplication1.Ingenium_2011DataSet
    Friend WithEvents Event_MasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_MasterTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_MasterTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Event_MasterDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchoolPanel As System.Windows.Forms.Panel
    Friend WithEvents EventMasterPanel As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Event_SchoolTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_SchoolTableAdapter
    Friend WithEvents Event_SchoolBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Visited_SchoolsTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter
    Friend WithEvents Event_SchoolDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VisitedSchoolsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EditEventButton As System.Windows.Forms.Button
    Friend WithEvents EventSaveCancelPanel As System.Windows.Forms.Panel
    Friend WithEvents CancelRecordButton As System.Windows.Forms.Button
    Friend WithEvents SaveRecordButton As System.Windows.Forms.Button
    Friend WithEvents AddNewEventButton As System.Windows.Forms.Button
    Friend WithEvents EventIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Event_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Event_DateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents SchoolIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents School_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SearchSchoolNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CancelSearchButton As System.Windows.Forms.Button
    Friend WithEvents Visited_SchoolsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AddSchoolButton As System.Windows.Forms.Button
    Friend WithEvents RemoveSchoolButton As System.Windows.Forms.Button
    Friend WithEvents UpdateStudentButton As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Ingenium_2011DataSet1 As WindowsApplication1.Ingenium_2011DataSet
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CompleteSchoolBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompleteSchoolTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.CompleteSchoolTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Complete_School_in_EventBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Complete_School_in_EventTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Complete_School_in_EventTableAdapter
    Friend WithEvents PanelAdmin As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EventFinishedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Event_Student_CompleteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_Student_CompleteTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_Student_CompleteTableAdapter
    Friend WithEvents TextBoxAddress As System.Windows.Forms.TextBox
    Friend WithEvents SearchCityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SchoolId As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents SearchTextBoxSchoolId As TextBox
End Class
