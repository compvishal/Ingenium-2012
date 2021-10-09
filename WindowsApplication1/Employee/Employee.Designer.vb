<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Dim VisitIdLabel As System.Windows.Forms.Label
        Dim SchoolIdLabel As System.Windows.Forms.Label
        Dim Visit_DateLabel As System.Windows.Forms.Label
        Dim PurposeLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.School_Visit_CompleteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ingenium_2011DataSet = New WindowsApplication1.Ingenium_2011DataSet
        Me.Company_Employee_CompleteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ArtTextBox = New System.Windows.Forms.TextBox
        Me.CommerceTextBox = New System.Windows.Forms.TextBox
        Me.Emply_NameTextBox = New System.Windows.Forms.TextBox
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmplyIdTextBox = New System.Windows.Forms.TextBox
        Me.PCBTextBox = New System.Windows.Forms.TextBox
        Me.PCMTextBox = New System.Windows.Forms.TextBox
        Me.NoStudentTextBox = New System.Windows.Forms.TextBox
        Me.NoSchoolVisitTextBox = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.EmployeeDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.EmployeeSchoolVisitDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.EmployeeSchoolVisitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.School_VisitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolVisitPanel = New System.Windows.Forms.Panel
        Me.NotesTextBox = New System.Windows.Forms.TextBox
        Me.PurposeComboBox = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.VisitedSchoolsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VisitIdTextBox = New System.Windows.Forms.TextBox
        Me.SchoolIdTextBox = New System.Windows.Forms.TextBox
        Me.Visit_DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.PurposeTextBox = New System.Windows.Forms.TextBox
        Me.EditButton = New System.Windows.Forms.Button
        Me.SaveCancelPanel = New System.Windows.Forms.Panel
        Me.CancelRecordButton = New System.Windows.Forms.Button
        Me.SaveRecordButton = New System.Windows.Forms.Button
        Me.AddNewButton1 = New System.Windows.Forms.Button
        Me.School_VisitDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.EmployeeTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.EmployeeTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
        Me.School_VisitTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.School_VisitTableAdapter
        Me.Visited_SchoolsTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter
        Me.EmployeeSchoolVisitTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.EmployeeSchoolVisitTableAdapter
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.School_Visit_CompleteTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.School_Visit_CompleteTableAdapter
        Me.Company_Employee_CompleteTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Company_Employee_CompleteTableAdapter
        Me.TabPage5 = New System.Windows.Forms.TabPage
        VisitIdLabel = New System.Windows.Forms.Label
        SchoolIdLabel = New System.Windows.Forms.Label
        Visit_DateLabel = New System.Windows.Forms.Label
        PurposeLabel = New System.Windows.Forms.Label
        NotesLabel = New System.Windows.Forms.Label
        CType(Me.School_Visit_CompleteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Company_Employee_CompleteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        CType(Me.EmployeeSchoolVisitDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeSchoolVisitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.School_VisitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SchoolVisitPanel.SuspendLayout()
        CType(Me.VisitedSchoolsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaveCancelPanel.SuspendLayout()
        CType(Me.School_VisitDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VisitIdLabel
        '
        VisitIdLabel.AutoSize = True
        VisitIdLabel.Location = New System.Drawing.Point(14, 9)
        VisitIdLabel.Name = "VisitIdLabel"
        VisitIdLabel.Size = New System.Drawing.Size(41, 13)
        VisitIdLabel.TabIndex = 0
        VisitIdLabel.Text = "Visit Id:"
        '
        'SchoolIdLabel
        '
        SchoolIdLabel.AutoSize = True
        SchoolIdLabel.Location = New System.Drawing.Point(14, 35)
        SchoolIdLabel.Name = "SchoolIdLabel"
        SchoolIdLabel.Size = New System.Drawing.Size(55, 13)
        SchoolIdLabel.TabIndex = 2
        SchoolIdLabel.Text = "School Id:"
        '
        'Visit_DateLabel
        '
        Visit_DateLabel.AutoSize = True
        Visit_DateLabel.Location = New System.Drawing.Point(14, 62)
        Visit_DateLabel.Name = "Visit_DateLabel"
        Visit_DateLabel.Size = New System.Drawing.Size(55, 13)
        Visit_DateLabel.TabIndex = 4
        Visit_DateLabel.Text = "Visit Date:"
        '
        'PurposeLabel
        '
        PurposeLabel.AutoSize = True
        PurposeLabel.Location = New System.Drawing.Point(14, 87)
        PurposeLabel.Name = "PurposeLabel"
        PurposeLabel.Size = New System.Drawing.Size(49, 13)
        PurposeLabel.TabIndex = 6
        PurposeLabel.Text = "Purpose:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(14, 113)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(38, 13)
        NotesLabel.TabIndex = 8
        NotesLabel.Text = "Notes:"
        '
        'School_Visit_CompleteBindingSource
        '
        Me.School_Visit_CompleteBindingSource.DataMember = "School Visit Complete"
        Me.School_Visit_CompleteBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Ingenium_2011DataSet
        '
        Me.Ingenium_2011DataSet.DataSetName = "Ingenium_2011DataSet"
        Me.Ingenium_2011DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Company_Employee_CompleteBindingSource
        '
        Me.Company_Employee_CompleteBindingSource.DataMember = "Company Employee Complete"
        Me.Company_Employee_CompleteBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(855, 467)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.EmployeeDataGridView)
        Me.TabPage1.Controls.Add(Me.StatusStrip1)
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(847, 441)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Member Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ArtTextBox)
        Me.Panel1.Controls.Add(Me.CommerceTextBox)
        Me.Panel1.Controls.Add(Me.Emply_NameTextBox)
        Me.Panel1.Controls.Add(Me.EmplyIdTextBox)
        Me.Panel1.Controls.Add(Me.PCBTextBox)
        Me.Panel1.Controls.Add(Me.PCMTextBox)
        Me.Panel1.Controls.Add(Me.NoStudentTextBox)
        Me.Panel1.Controls.Add(Me.NoSchoolVisitTextBox)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(445, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(303, 272)
        Me.Panel1.TabIndex = 6
        '
        'ArtTextBox
        '
        Me.ArtTextBox.Enabled = False
        Me.ArtTextBox.Location = New System.Drawing.Point(194, 164)
        Me.ArtTextBox.Name = "ArtTextBox"
        Me.ArtTextBox.Size = New System.Drawing.Size(79, 20)
        Me.ArtTextBox.TabIndex = 28
        '
        'CommerceTextBox
        '
        Me.CommerceTextBox.Enabled = False
        Me.CommerceTextBox.Location = New System.Drawing.Point(194, 138)
        Me.CommerceTextBox.Name = "CommerceTextBox"
        Me.CommerceTextBox.Size = New System.Drawing.Size(79, 20)
        Me.CommerceTextBox.TabIndex = 27
        '
        'Emply_NameTextBox
        '
        Me.Emply_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Emply Name", True))
        Me.Emply_NameTextBox.Location = New System.Drawing.Point(78, 226)
        Me.Emply_NameTextBox.Name = "Emply_NameTextBox"
        Me.Emply_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Emply_NameTextBox.TabIndex = 5
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'EmplyIdTextBox
        '
        Me.EmplyIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "EmplyId", True))
        Me.EmplyIdTextBox.Location = New System.Drawing.Point(50, 225)
        Me.EmplyIdTextBox.Name = "EmplyIdTextBox"
        Me.EmplyIdTextBox.Size = New System.Drawing.Size(22, 20)
        Me.EmplyIdTextBox.TabIndex = 4
        '
        'PCBTextBox
        '
        Me.PCBTextBox.Enabled = False
        Me.PCBTextBox.Location = New System.Drawing.Point(194, 112)
        Me.PCBTextBox.Name = "PCBTextBox"
        Me.PCBTextBox.Size = New System.Drawing.Size(79, 20)
        Me.PCBTextBox.TabIndex = 26
        '
        'PCMTextBox
        '
        Me.PCMTextBox.Enabled = False
        Me.PCMTextBox.Location = New System.Drawing.Point(194, 82)
        Me.PCMTextBox.Name = "PCMTextBox"
        Me.PCMTextBox.Size = New System.Drawing.Size(79, 20)
        Me.PCMTextBox.TabIndex = 25
        '
        'NoStudentTextBox
        '
        Me.NoStudentTextBox.Enabled = False
        Me.NoStudentTextBox.Location = New System.Drawing.Point(159, 58)
        Me.NoStudentTextBox.Name = "NoStudentTextBox"
        Me.NoStudentTextBox.Size = New System.Drawing.Size(63, 20)
        Me.NoStudentTextBox.TabIndex = 24
        '
        'NoSchoolVisitTextBox
        '
        Me.NoSchoolVisitTextBox.Enabled = False
        Me.NoSchoolVisitTextBox.Location = New System.Drawing.Point(159, 25)
        Me.NoSchoolVisitTextBox.Name = "NoSchoolVisitTextBox"
        Me.NoSchoolVisitTextBox.Size = New System.Drawing.Size(63, 20)
        Me.NoSchoolVisitTextBox.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(97, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Test-Arts"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(97, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Test-Commerce"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(97, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Test-PCB"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(97, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Test-PCM"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "No of Students Test Held"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "No of Schools Visited"
        '
        'EmployeeDataGridView
        '
        Me.EmployeeDataGridView.AllowUserToDeleteRows = False
        Me.EmployeeDataGridView.AutoGenerateColumns = False
        Me.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.EmployeeDataGridView.DataSource = Me.EmployeeBindingSource
        Me.EmployeeDataGridView.Location = New System.Drawing.Point(6, 31)
        Me.EmployeeDataGridView.Name = "EmployeeDataGridView"
        Me.EmployeeDataGridView.Size = New System.Drawing.Size(396, 381)
        Me.EmployeeDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Emply Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Marketing Manager Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Mobile No"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Mobile No"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 416)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(841, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(103, 17)
        Me.ToolStripStatusLabel1.Text = "Employee Module"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(841, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Save Changes"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.StatusStrip2)
        Me.TabPage2.Controls.Add(Me.EmployeeSchoolVisitDataGridView)
        Me.TabPage2.Controls.Add(Me.SchoolVisitPanel)
        Me.TabPage2.Controls.Add(Me.EditButton)
        Me.TabPage2.Controls.Add(Me.SaveCancelPanel)
        Me.TabPage2.Controls.Add(Me.AddNewButton1)
        Me.TabPage2.Controls.Add(Me.School_VisitDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(847, 441)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "School Visits"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel2})
        Me.StatusStrip2.Location = New System.Drawing.Point(291, 416)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(553, 22)
        Me.StatusStrip2.TabIndex = 23
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.DarkKhaki
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(129, 17)
        Me.ToolStripStatusLabel3.Text = "ToolStripStatusLabel3"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(109, 17)
        Me.ToolStripStatusLabel2.Text = "School Vsit Module"
        '
        'EmployeeSchoolVisitDataGridView
        '
        Me.EmployeeSchoolVisitDataGridView.AutoGenerateColumns = False
        Me.EmployeeSchoolVisitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeSchoolVisitDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6})
        Me.EmployeeSchoolVisitDataGridView.DataSource = Me.EmployeeSchoolVisitBindingSource
        Me.EmployeeSchoolVisitDataGridView.Location = New System.Drawing.Point(307, 244)
        Me.EmployeeSchoolVisitDataGridView.Name = "EmployeeSchoolVisitDataGridView"
        Me.EmployeeSchoolVisitDataGridView.Size = New System.Drawing.Size(370, 126)
        Me.EmployeeSchoolVisitDataGridView.TabIndex = 22
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "EmplyId"
        Me.DataGridViewTextBoxColumn6.DataSource = Me.EmployeeBindingSource
        Me.DataGridViewTextBoxColumn6.DisplayMember = "Emply Name"
        Me.DataGridViewTextBoxColumn6.HeaderText = "EmplyId"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.ValueMember = "EmplyId"
        Me.DataGridViewTextBoxColumn6.Width = 200
        '
        'EmployeeSchoolVisitBindingSource
        '
        Me.EmployeeSchoolVisitBindingSource.DataMember = "School VisitEmployeeSchoolVisit"
        Me.EmployeeSchoolVisitBindingSource.DataSource = Me.School_VisitBindingSource
        '
        'School_VisitBindingSource
        '
        Me.School_VisitBindingSource.DataMember = "School Visit"
        Me.School_VisitBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'SchoolVisitPanel
        '
        Me.SchoolVisitPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SchoolVisitPanel.Controls.Add(Me.NotesTextBox)
        Me.SchoolVisitPanel.Controls.Add(Me.PurposeComboBox)
        Me.SchoolVisitPanel.Controls.Add(Me.ComboBox1)
        Me.SchoolVisitPanel.Controls.Add(VisitIdLabel)
        Me.SchoolVisitPanel.Controls.Add(Me.VisitIdTextBox)
        Me.SchoolVisitPanel.Controls.Add(SchoolIdLabel)
        Me.SchoolVisitPanel.Controls.Add(Me.SchoolIdTextBox)
        Me.SchoolVisitPanel.Controls.Add(Visit_DateLabel)
        Me.SchoolVisitPanel.Controls.Add(Me.Visit_DateDateTimePicker)
        Me.SchoolVisitPanel.Controls.Add(PurposeLabel)
        Me.SchoolVisitPanel.Controls.Add(Me.PurposeTextBox)
        Me.SchoolVisitPanel.Controls.Add(NotesLabel)
        Me.SchoolVisitPanel.Location = New System.Drawing.Point(307, 51)
        Me.SchoolVisitPanel.Name = "SchoolVisitPanel"
        Me.SchoolVisitPanel.Size = New System.Drawing.Size(403, 176)
        Me.SchoolVisitPanel.TabIndex = 22
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.School_VisitBindingSource, "Notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(75, 110)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(283, 54)
        Me.NotesTextBox.TabIndex = 9
        '
        'PurposeComboBox
        '
        Me.PurposeComboBox.FormattingEnabled = True
        Me.PurposeComboBox.Items.AddRange(New Object() {"Test", "Test & Presentation", "Presentation", "Data Collection", "General", "Student Campus Visit", "Prize Distribution", "Prize Distribution & Presentation"})
        Me.PurposeComboBox.Location = New System.Drawing.Point(75, 84)
        Me.PurposeComboBox.Name = "PurposeComboBox"
        Me.PurposeComboBox.Size = New System.Drawing.Size(136, 21)
        Me.PurposeComboBox.TabIndex = 11
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.School_VisitBindingSource, "SchoolId", True))
        Me.ComboBox1.DataSource = Me.VisitedSchoolsBindingSource
        Me.ComboBox1.DisplayMember = "School Name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(76, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(199, 21)
        Me.ComboBox1.TabIndex = 10
        Me.ComboBox1.ValueMember = "SchoolId"
        '
        'VisitedSchoolsBindingSource
        '
        Me.VisitedSchoolsBindingSource.DataMember = "Visited Schools"
        Me.VisitedSchoolsBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'VisitIdTextBox
        '
        Me.VisitIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.School_VisitBindingSource, "VisitId", True))
        Me.VisitIdTextBox.Enabled = False
        Me.VisitIdTextBox.Location = New System.Drawing.Point(75, 6)
        Me.VisitIdTextBox.Name = "VisitIdTextBox"
        Me.VisitIdTextBox.Size = New System.Drawing.Size(25, 20)
        Me.VisitIdTextBox.TabIndex = 1
        '
        'SchoolIdTextBox
        '
        Me.SchoolIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.School_VisitBindingSource, "SchoolId", True))
        Me.SchoolIdTextBox.Location = New System.Drawing.Point(167, 127)
        Me.SchoolIdTextBox.Name = "SchoolIdTextBox"
        Me.SchoolIdTextBox.Size = New System.Drawing.Size(25, 20)
        Me.SchoolIdTextBox.TabIndex = 3
        '
        'Visit_DateDateTimePicker
        '
        Me.Visit_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.School_VisitBindingSource, "Visit Date", True))
        Me.Visit_DateDateTimePicker.Location = New System.Drawing.Point(75, 58)
        Me.Visit_DateDateTimePicker.Name = "Visit_DateDateTimePicker"
        Me.Visit_DateDateTimePicker.Size = New System.Drawing.Size(137, 20)
        Me.Visit_DateDateTimePicker.TabIndex = 5
        '
        'PurposeTextBox
        '
        Me.PurposeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.School_VisitBindingSource, "Purpose", True))
        Me.PurposeTextBox.Location = New System.Drawing.Point(228, 127)
        Me.PurposeTextBox.Name = "PurposeTextBox"
        Me.PurposeTextBox.Size = New System.Drawing.Size(25, 20)
        Me.PurposeTextBox.TabIndex = 7
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(413, 6)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(98, 36)
        Me.EditButton.TabIndex = 20
        Me.EditButton.Text = "&Edit Visit Data"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'SaveCancelPanel
        '
        Me.SaveCancelPanel.Controls.Add(Me.CancelRecordButton)
        Me.SaveCancelPanel.Controls.Add(Me.SaveRecordButton)
        Me.SaveCancelPanel.Location = New System.Drawing.Point(536, 3)
        Me.SaveCancelPanel.Name = "SaveCancelPanel"
        Me.SaveCancelPanel.Size = New System.Drawing.Size(174, 42)
        Me.SaveCancelPanel.TabIndex = 21
        '
        'CancelRecordButton
        '
        Me.CancelRecordButton.Location = New System.Drawing.Point(82, 3)
        Me.CancelRecordButton.Name = "CancelRecordButton"
        Me.CancelRecordButton.Size = New System.Drawing.Size(75, 36)
        Me.CancelRecordButton.TabIndex = 19
        Me.CancelRecordButton.Text = "&Cancel"
        Me.CancelRecordButton.UseVisualStyleBackColor = True
        '
        'SaveRecordButton
        '
        Me.SaveRecordButton.Location = New System.Drawing.Point(5, 3)
        Me.SaveRecordButton.Name = "SaveRecordButton"
        Me.SaveRecordButton.Size = New System.Drawing.Size(75, 36)
        Me.SaveRecordButton.TabIndex = 18
        Me.SaveRecordButton.Text = "&Save"
        Me.SaveRecordButton.UseVisualStyleBackColor = True
        '
        'AddNewButton1
        '
        Me.AddNewButton1.Location = New System.Drawing.Point(297, 6)
        Me.AddNewButton1.Name = "AddNewButton1"
        Me.AddNewButton1.Size = New System.Drawing.Size(107, 36)
        Me.AddNewButton1.TabIndex = 19
        Me.AddNewButton1.Text = "Add &New Visit"
        Me.AddNewButton1.UseVisualStyleBackColor = True
        '
        'School_VisitDataGridView
        '
        Me.School_VisitDataGridView.AllowUserToAddRows = False
        Me.School_VisitDataGridView.AllowUserToDeleteRows = False
        Me.School_VisitDataGridView.AutoGenerateColumns = False
        Me.School_VisitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.School_VisitDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4})
        Me.School_VisitDataGridView.DataSource = Me.School_VisitBindingSource
        Me.School_VisitDataGridView.Dock = System.Windows.Forms.DockStyle.Left
        Me.School_VisitDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.School_VisitDataGridView.Name = "School_VisitDataGridView"
        Me.School_VisitDataGridView.RowHeadersWidth = 21
        Me.School_VisitDataGridView.Size = New System.Drawing.Size(288, 435)
        Me.School_VisitDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Visit Date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Visit Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SchoolId"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.VisitedSchoolsBindingSource
        Me.DataGridViewTextBoxColumn4.DisplayMember = "School Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "SchoolId"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "SchoolId"
        Me.DataGridViewTextBoxColumn4.Width = 160
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ReportViewer1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(847, 441)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Visit Reports"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Ingenium_2011DataSet_School_Visit_Complete"
        ReportDataSource1.Value = Me.School_Visit_CompleteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.School Visit-by Employee.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(841, 435)
        Me.ReportViewer1.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ReportViewer2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(847, 441)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Company Visit"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "Ingenium_2011DataSet_Company_Employee_Complete"
        ReportDataSource2.Value = Me.Company_Employee_CompleteBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Company Visit-Employee.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(841, 435)
        Me.ReportViewer2.TabIndex = 0
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Companies_VisitedTableAdapter = Nothing
        Me.TableAdapterManager.Company_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.Company_VisitTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeCompanyVisitTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeSchoolVisitTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.School_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.School_VisitTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Visited_SchoolsTableAdapter = Nothing
        '
        'School_VisitTableAdapter
        '
        Me.School_VisitTableAdapter.ClearBeforeFill = True
        '
        'Visited_SchoolsTableAdapter
        '
        Me.Visited_SchoolsTableAdapter.ClearBeforeFill = True
        '
        'EmployeeSchoolVisitTableAdapter
        '
        Me.EmployeeSchoolVisitTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'School_Visit_CompleteTableAdapter
        '
        Me.School_Visit_CompleteTableAdapter.ClearBeforeFill = True
        '
        'Company_Employee_CompleteTableAdapter
        '
        Me.Company_Employee_CompleteTableAdapter.ClearBeforeFill = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(847, 441)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 467)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Employee"
        Me.Text = "Employee"
        CType(Me.School_Visit_CompleteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Company_Employee_CompleteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        CType(Me.EmployeeSchoolVisitDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeSchoolVisitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.School_VisitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SchoolVisitPanel.ResumeLayout(False)
        Me.SchoolVisitPanel.PerformLayout()
        CType(Me.VisitedSchoolsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaveCancelPanel.ResumeLayout(False)
        CType(Me.School_VisitDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Ingenium_2011DataSet As WindowsApplication1.Ingenium_2011DataSet
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents School_VisitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents School_VisitTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.School_VisitTableAdapter
    Friend WithEvents School_VisitDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents VisitedSchoolsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Visited_SchoolsTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents SchoolVisitPanel As System.Windows.Forms.Panel
    Friend WithEvents VisitIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SchoolIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Visit_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PurposeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents SaveCancelPanel As System.Windows.Forms.Panel
    Friend WithEvents CancelRecordButton As System.Windows.Forms.Button
    Friend WithEvents SaveRecordButton As System.Windows.Forms.Button
    Friend WithEvents AddNewButton1 As System.Windows.Forms.Button
    Friend WithEvents EmployeeSchoolVisitBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeSchoolVisitTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.EmployeeSchoolVisitTableAdapter
    Friend WithEvents EmployeeSchoolVisitDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents PurposeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EmplyIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Emply_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents School_Visit_CompleteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents School_Visit_CompleteTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.School_Visit_CompleteTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ArtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CommerceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PCBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PCMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoStudentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoSchoolVisitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Company_Employee_CompleteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Company_Employee_CompleteTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Company_Employee_CompleteTableAdapter
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
End Class
