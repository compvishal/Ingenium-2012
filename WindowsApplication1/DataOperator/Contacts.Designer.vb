<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contacts
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim SectorIdLabel As System.Windows.Forms.Label
        Dim SchoolIdLabel As System.Windows.Forms.Label
        Dim Contact_NameLabel As System.Windows.Forms.Label
        Dim E_mail_AddressLabel As System.Windows.Forms.Label
        Dim Job_TitleLabel As System.Windows.Forms.Label
        Dim Business_PhoneLabel As System.Windows.Forms.Label
        Dim Mobile_Phone1Label As System.Windows.Forms.Label
        Dim Mobile_Phone2Label As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim EmployeeIdLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityIdLabel As System.Windows.Forms.Label
        Dim VerifiedLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Label1 As System.Windows.Forms.Label
        Me.Ingenium_2011DataSet = New WindowsApplication1.Ingenium_2011DataSet()
        Me.ContactsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContactsTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.ContactsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager()
        Me.ContactsDataGridView = New System.Windows.Forms.DataGridView()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.EmployeeTableAdapter()
        Me.CityTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.CityTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBoxCity = New System.Windows.Forms.ComboBox()
        Me.CityBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxEmployee = New System.Windows.Forms.ComboBox()
        Me.EmployeeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.VisitedSchoolsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SectorComboBox = New System.Windows.Forms.ComboBox()
        Me.SectorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.SectorIdTextBox = New System.Windows.Forms.TextBox()
        Me.SchoolIdTextBox = New System.Windows.Forms.TextBox()
        Me.Contact_NameTextBox = New System.Windows.Forms.TextBox()
        Me.E_mail_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Job_TitleTextBox = New System.Windows.Forms.TextBox()
        Me.Business_PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Mobile_Phone1TextBox = New System.Windows.Forms.TextBox()
        Me.Mobile_Phone2TextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeIdTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityIdTextBox = New System.Windows.Forms.TextBox()
        Me.VerifiedCheckBox = New System.Windows.Forms.CheckBox()
        Me.SaveCancelPanel = New System.Windows.Forms.Panel()
        Me.CancelRecordButton = New System.Windows.Forms.Button()
        Me.SaveRecordButton = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PanelSearch = New System.Windows.Forms.Panel()
        Me.SearchEmployeeComboBox = New System.Windows.Forms.ComboBox()
        Me.SearchNameTextBox = New System.Windows.Forms.TextBox()
        Me.CancelSearchButton = New System.Windows.Forms.Button()
        Me.SectorTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.SectorTableAdapter()
        Me.Visited_SchoolsTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.AddNewButton1 = New System.Windows.Forms.Button()
        Me.AddEditPanel = New System.Windows.Forms.Panel()
        Me.ContactsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TextBoxCOntactId = New System.Windows.Forms.TextBox()
        Me.ComboBoxCitySearch = New System.Windows.Forms.ComboBox()
        Me.CityBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.EmployeeBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        IDLabel = New System.Windows.Forms.Label()
        SectorIdLabel = New System.Windows.Forms.Label()
        SchoolIdLabel = New System.Windows.Forms.Label()
        Contact_NameLabel = New System.Windows.Forms.Label()
        E_mail_AddressLabel = New System.Windows.Forms.Label()
        Job_TitleLabel = New System.Windows.Forms.Label()
        Business_PhoneLabel = New System.Windows.Forms.Label()
        Mobile_Phone1Label = New System.Windows.Forms.Label()
        Mobile_Phone2Label = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        EmployeeIdLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityIdLabel = New System.Windows.Forms.Label()
        VerifiedLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContactsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.CityBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitedSchoolsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SectorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SaveCancelPanel.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.PanelSearch.SuspendLayout()
        Me.AddEditPanel.SuspendLayout()
        CType(Me.ContactsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(109, 6)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(25, 17)
        IDLabel.TabIndex = 0
        IDLabel.Text = "ID:"
        '
        'SectorIdLabel
        '
        SectorIdLabel.AutoSize = True
        SectorIdLabel.Location = New System.Drawing.Point(66, 34)
        SectorIdLabel.Name = "SectorIdLabel"
        SectorIdLabel.Size = New System.Drawing.Size(68, 17)
        SectorIdLabel.TabIndex = 2
        SectorIdLabel.Text = "Sector Id:"
        '
        'SchoolIdLabel
        '
        SchoolIdLabel.AutoSize = True
        SchoolIdLabel.Location = New System.Drawing.Point(64, 62)
        SchoolIdLabel.Name = "SchoolIdLabel"
        SchoolIdLabel.Size = New System.Drawing.Size(70, 17)
        SchoolIdLabel.TabIndex = 4
        SchoolIdLabel.Text = "School Id:"
        '
        'Contact_NameLabel
        '
        Contact_NameLabel.AutoSize = True
        Contact_NameLabel.Location = New System.Drawing.Point(33, 90)
        Contact_NameLabel.Name = "Contact_NameLabel"
        Contact_NameLabel.Size = New System.Drawing.Size(101, 17)
        Contact_NameLabel.TabIndex = 6
        Contact_NameLabel.Text = "Contact Name:"
        '
        'E_mail_AddressLabel
        '
        E_mail_AddressLabel.AutoSize = True
        E_mail_AddressLabel.Location = New System.Drawing.Point(27, 207)
        E_mail_AddressLabel.Name = "E_mail_AddressLabel"
        E_mail_AddressLabel.Size = New System.Drawing.Size(107, 17)
        E_mail_AddressLabel.TabIndex = 8
        E_mail_AddressLabel.Text = "E-mail Address:"
        '
        'Job_TitleLabel
        '
        Job_TitleLabel.AutoSize = True
        Job_TitleLabel.Location = New System.Drawing.Point(68, 118)
        Job_TitleLabel.Name = "Job_TitleLabel"
        Job_TitleLabel.Size = New System.Drawing.Size(66, 17)
        Job_TitleLabel.TabIndex = 10
        Job_TitleLabel.Text = "Job Title:"
        '
        'Business_PhoneLabel
        '
        Business_PhoneLabel.AutoSize = True
        Business_PhoneLabel.Location = New System.Drawing.Point(20, 190)
        Business_PhoneLabel.Name = "Business_PhoneLabel"
        Business_PhoneLabel.Size = New System.Drawing.Size(114, 17)
        Business_PhoneLabel.TabIndex = 12
        Business_PhoneLabel.Text = "Business Phone:"
        '
        'Mobile_Phone1Label
        '
        Mobile_Phone1Label.AutoSize = True
        Mobile_Phone1Label.Location = New System.Drawing.Point(28, 146)
        Mobile_Phone1Label.Name = "Mobile_Phone1Label"
        Mobile_Phone1Label.Size = New System.Drawing.Size(106, 17)
        Mobile_Phone1Label.TabIndex = 16
        Mobile_Phone1Label.Text = "Mobile Phone1:"
        '
        'Mobile_Phone2Label
        '
        Mobile_Phone2Label.AutoSize = True
        Mobile_Phone2Label.Location = New System.Drawing.Point(28, 165)
        Mobile_Phone2Label.Name = "Mobile_Phone2Label"
        Mobile_Phone2Label.Size = New System.Drawing.Size(106, 17)
        Mobile_Phone2Label.TabIndex = 18
        Mobile_Phone2Label.Text = "Mobile Phone2:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(85, 240)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(49, 17)
        NotesLabel.TabIndex = 22
        NotesLabel.Text = "Notes:"
        '
        'EmployeeIdLabel
        '
        EmployeeIdLabel.AutoSize = True
        EmployeeIdLabel.Location = New System.Drawing.Point(45, 313)
        EmployeeIdLabel.Name = "EmployeeIdLabel"
        EmployeeIdLabel.Size = New System.Drawing.Size(89, 17)
        EmployeeIdLabel.TabIndex = 24
        EmployeeIdLabel.Text = "Employee Id:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(316, 120)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(64, 17)
        AddressLabel.TabIndex = 26
        AddressLabel.Text = "Address:"
        '
        'CityIdLabel
        '
        CityIdLabel.AutoSize = True
        CityIdLabel.Location = New System.Drawing.Point(316, 187)
        CityIdLabel.Name = "CityIdLabel"
        CityIdLabel.Size = New System.Drawing.Size(93, 17)
        CityIdLabel.TabIndex = 28
        CityIdLabel.Text = "City/Location:"
        '
        'VerifiedLabel
        '
        VerifiedLabel.AutoSize = True
        VerifiedLabel.Location = New System.Drawing.Point(373, 310)
        VerifiedLabel.Name = "VerifiedLabel"
        VerifiedLabel.Size = New System.Drawing.Size(60, 17)
        VerifiedLabel.TabIndex = 30
        VerifiedLabel.Text = "Verified:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(296, 55)
        Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(74, 17)
        Label6.TabIndex = 21
        Label6.Text = "Employee:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(1, 55)
        Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(93, 17)
        Label5.TabIndex = 6
        Label5.Text = "City/Location:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(269, 18)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(101, 17)
        Label3.TabIndex = 3
        Label3.Text = "Contact Name:"
        '
        'Ingenium_2011DataSet
        '
        Me.Ingenium_2011DataSet.DataSetName = "Ingenium_2011DataSet"
        Me.Ingenium_2011DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContactsBindingSource
        '
        Me.ContactsBindingSource.DataMember = "Contacts"
        Me.ContactsBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'ContactsTableAdapter
        '
        Me.ContactsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager._12thTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CityTableAdapter = Nothing
        Me.TableAdapterManager.Companies_VisitedTableAdapter = Nothing
        Me.TableAdapterManager.Company_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.Company_VisitTableAdapter = Nothing
        Me.TableAdapterManager.ContactsTableAdapter = Me.ContactsTableAdapter
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
        Me.TableAdapterManager.SectorTableAdapter = Nothing
        Me.TableAdapterManager.SMS_TextTableAdapter = Nothing
        Me.TableAdapterManager.StreamTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Visited_SchoolsTableAdapter = Nothing
        '
        'ContactsDataGridView
        '
        Me.ContactsDataGridView.AllowUserToAddRows = False
        Me.ContactsDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Olive
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ContactsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ContactsDataGridView.AutoGenerateColumns = False
        Me.ContactsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContactsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn15})
        Me.ContactsDataGridView.DataSource = Me.ContactsBindingSource
        Me.ContactsDataGridView.Dock = System.Windows.Forms.DockStyle.Left
        Me.ContactsDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.ContactsDataGridView.Name = "ContactsDataGridView"
        Me.ContactsDataGridView.RowHeadersWidth = 21
        Me.ContactsDataGridView.RowTemplate.Height = 24
        Me.ContactsDataGridView.Size = New System.Drawing.Size(632, 608)
        Me.ContactsDataGridView.TabIndex = 1
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'CityBindingSource
        '
        Me.CityBindingSource.DataMember = "City"
        Me.CityBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'CityTableAdapter
        '
        Me.CityTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Wheat
        Me.Panel1.Controls.Add(Me.NotesTextBox)
        Me.Panel1.Controls.Add(Me.ComboBoxCity)
        Me.Panel1.Controls.Add(Me.ComboBoxEmployee)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.SectorComboBox)
        Me.Panel1.Controls.Add(IDLabel)
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Controls.Add(SectorIdLabel)
        Me.Panel1.Controls.Add(Me.SectorIdTextBox)
        Me.Panel1.Controls.Add(SchoolIdLabel)
        Me.Panel1.Controls.Add(Me.SchoolIdTextBox)
        Me.Panel1.Controls.Add(Contact_NameLabel)
        Me.Panel1.Controls.Add(Me.Contact_NameTextBox)
        Me.Panel1.Controls.Add(E_mail_AddressLabel)
        Me.Panel1.Controls.Add(Me.E_mail_AddressTextBox)
        Me.Panel1.Controls.Add(Job_TitleLabel)
        Me.Panel1.Controls.Add(Me.Job_TitleTextBox)
        Me.Panel1.Controls.Add(Business_PhoneLabel)
        Me.Panel1.Controls.Add(Me.Business_PhoneTextBox)
        Me.Panel1.Controls.Add(Mobile_Phone1Label)
        Me.Panel1.Controls.Add(Me.Mobile_Phone1TextBox)
        Me.Panel1.Controls.Add(Mobile_Phone2Label)
        Me.Panel1.Controls.Add(Me.Mobile_Phone2TextBox)
        Me.Panel1.Controls.Add(NotesLabel)
        Me.Panel1.Controls.Add(EmployeeIdLabel)
        Me.Panel1.Controls.Add(Me.EmployeeIdTextBox)
        Me.Panel1.Controls.Add(AddressLabel)
        Me.Panel1.Controls.Add(Me.AddressTextBox)
        Me.Panel1.Controls.Add(CityIdLabel)
        Me.Panel1.Controls.Add(Me.CityIdTextBox)
        Me.Panel1.Controls.Add(VerifiedLabel)
        Me.Panel1.Controls.Add(Me.VerifiedCheckBox)
        Me.Panel1.Location = New System.Drawing.Point(643, 172)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(537, 364)
        Me.Panel1.TabIndex = 2
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactsBindingSource, "Notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(140, 237)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(273, 54)
        Me.NotesTextBox.TabIndex = 11
        '
        'ComboBoxCity
        '
        Me.ComboBoxCity.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ContactsBindingSource, "CityId", True))
        Me.ComboBoxCity.DataSource = Me.CityBindingSource1
        Me.ComboBoxCity.DisplayMember = "City Name"
        Me.ComboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCity.FormattingEnabled = True
        Me.ComboBoxCity.Location = New System.Drawing.Point(317, 207)
        Me.ComboBoxCity.Name = "ComboBoxCity"
        Me.ComboBoxCity.Size = New System.Drawing.Size(195, 24)
        Me.ComboBoxCity.TabIndex = 10
        Me.ComboBoxCity.ValueMember = "CityID"
        '
        'CityBindingSource1
        '
        Me.CityBindingSource1.DataMember = "City"
        Me.CityBindingSource1.DataSource = Me.Ingenium_2011DataSet
        '
        'ComboBoxEmployee
        '
        Me.ComboBoxEmployee.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ContactsBindingSource, "EmployeeId", True))
        Me.ComboBoxEmployee.DataSource = Me.EmployeeBindingSource1
        Me.ComboBoxEmployee.DisplayMember = "Emply Name"
        Me.ComboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEmployee.FormattingEnabled = True
        Me.ComboBoxEmployee.Location = New System.Drawing.Point(140, 307)
        Me.ComboBoxEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxEmployee.Name = "ComboBoxEmployee"
        Me.ComboBoxEmployee.Size = New System.Drawing.Size(226, 24)
        Me.ComboBoxEmployee.TabIndex = 12
        Me.ComboBoxEmployee.ValueMember = "EmplyId"
        '
        'EmployeeBindingSource1
        '
        Me.EmployeeBindingSource1.DataMember = "Employee"
        Me.EmployeeBindingSource1.DataSource = Me.Ingenium_2011DataSet
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ContactsBindingSource, "SchoolId", True))
        Me.ComboBox2.DataSource = Me.VisitedSchoolsBindingSource
        Me.ComboBox2.DisplayMember = "School Name"
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(140, 61)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(271, 24)
        Me.ComboBox2.TabIndex = 2
        Me.ComboBox2.ValueMember = "SchoolId"
        '
        'VisitedSchoolsBindingSource
        '
        Me.VisitedSchoolsBindingSource.DataMember = "Visited Schools"
        Me.VisitedSchoolsBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'SectorComboBox
        '
        Me.SectorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ContactsBindingSource, "SectorId", True))
        Me.SectorComboBox.DataSource = Me.SectorBindingSource
        Me.SectorComboBox.DisplayMember = "Sector Name"
        Me.SectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SectorComboBox.FormattingEnabled = True
        Me.SectorComboBox.Location = New System.Drawing.Point(140, 31)
        Me.SectorComboBox.Name = "SectorComboBox"
        Me.SectorComboBox.Size = New System.Drawing.Size(271, 24)
        Me.SectorComboBox.TabIndex = 1
        Me.SectorComboBox.ValueMember = "SectorId"
        '
        'SectorBindingSource
        '
        Me.SectorBindingSource.DataMember = "Sector"
        Me.SectorBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(140, 3)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(33, 22)
        Me.IDTextBox.TabIndex = 0
        '
        'SectorIdTextBox
        '
        Me.SectorIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactsBindingSource, "SectorId", True))
        Me.SectorIdTextBox.Location = New System.Drawing.Point(291, 259)
        Me.SectorIdTextBox.Name = "SectorIdTextBox"
        Me.SectorIdTextBox.ReadOnly = True
        Me.SectorIdTextBox.Size = New System.Drawing.Size(33, 22)
        Me.SectorIdTextBox.TabIndex = 15
        '
        'SchoolIdTextBox
        '
        Me.SchoolIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactsBindingSource, "SchoolId", True))
        Me.SchoolIdTextBox.Location = New System.Drawing.Point(238, 259)
        Me.SchoolIdTextBox.Name = "SchoolIdTextBox"
        Me.SchoolIdTextBox.ReadOnly = True
        Me.SchoolIdTextBox.Size = New System.Drawing.Size(33, 22)
        Me.SchoolIdTextBox.TabIndex = 16
        '
        'Contact_NameTextBox
        '
        Me.Contact_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactsBindingSource, "Contact Name", True))
        Me.Contact_NameTextBox.Location = New System.Drawing.Point(140, 87)
        Me.Contact_NameTextBox.Name = "Contact_NameTextBox"
        Me.Contact_NameTextBox.Size = New System.Drawing.Size(273, 22)
        Me.Contact_NameTextBox.TabIndex = 3
        '
        'E_mail_AddressTextBox
        '
        Me.E_mail_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactsBindingSource, "E-mail Address", True))
        Me.E_mail_AddressTextBox.Location = New System.Drawing.Point(140, 209)
        Me.E_mail_AddressTextBox.Name = "E_mail_AddressTextBox"
        Me.E_mail_AddressTextBox.Size = New System.Drawing.Size(162, 22)
        Me.E_mail_AddressTextBox.TabIndex = 8
        '
        'Job_TitleTextBox
        '
        Me.Job_TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactsBindingSource, "Job Title", True))
        Me.Job_TitleTextBox.Location = New System.Drawing.Point(140, 115)
        Me.Job_TitleTextBox.Name = "Job_TitleTextBox"
        Me.Job_TitleTextBox.Size = New System.Drawing.Size(104, 22)
        Me.Job_TitleTextBox.TabIndex = 4
        '
        'Business_PhoneTextBox
        '
        Me.Business_PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactsBindingSource, "Business Phone", True))
        Me.Business_PhoneTextBox.Location = New System.Drawing.Point(140, 187)
        Me.Business_PhoneTextBox.Name = "Business_PhoneTextBox"
        Me.Business_PhoneTextBox.Size = New System.Drawing.Size(162, 22)
        Me.Business_PhoneTextBox.TabIndex = 7
        '
        'Mobile_Phone1TextBox
        '
        Me.Mobile_Phone1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactsBindingSource, "Mobile Phone1", True))
        Me.Mobile_Phone1TextBox.Location = New System.Drawing.Point(140, 143)
        Me.Mobile_Phone1TextBox.Name = "Mobile_Phone1TextBox"
        Me.Mobile_Phone1TextBox.Size = New System.Drawing.Size(162, 22)
        Me.Mobile_Phone1TextBox.TabIndex = 5
        '
        'Mobile_Phone2TextBox
        '
        Me.Mobile_Phone2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactsBindingSource, "Mobile Phone2", True))
        Me.Mobile_Phone2TextBox.Location = New System.Drawing.Point(140, 165)
        Me.Mobile_Phone2TextBox.Name = "Mobile_Phone2TextBox"
        Me.Mobile_Phone2TextBox.Size = New System.Drawing.Size(162, 22)
        Me.Mobile_Phone2TextBox.TabIndex = 6
        '
        'EmployeeIdTextBox
        '
        Me.EmployeeIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactsBindingSource, "EmployeeId", True))
        Me.EmployeeIdTextBox.Location = New System.Drawing.Point(152, 259)
        Me.EmployeeIdTextBox.Name = "EmployeeIdTextBox"
        Me.EmployeeIdTextBox.Size = New System.Drawing.Size(33, 22)
        Me.EmployeeIdTextBox.TabIndex = 17
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactsBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(317, 143)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(179, 44)
        Me.AddressTextBox.TabIndex = 9
        '
        'CityIdTextBox
        '
        Me.CityIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContactsBindingSource, "CityId", True))
        Me.CityIdTextBox.Location = New System.Drawing.Point(152, 259)
        Me.CityIdTextBox.Name = "CityIdTextBox"
        Me.CityIdTextBox.Size = New System.Drawing.Size(14, 22)
        Me.CityIdTextBox.TabIndex = 13
        '
        'VerifiedCheckBox
        '
        Me.VerifiedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ContactsBindingSource, "Verified", True))
        Me.VerifiedCheckBox.Location = New System.Drawing.Point(439, 306)
        Me.VerifiedCheckBox.Name = "VerifiedCheckBox"
        Me.VerifiedCheckBox.Size = New System.Drawing.Size(33, 24)
        Me.VerifiedCheckBox.TabIndex = 13
        Me.VerifiedCheckBox.UseVisualStyleBackColor = True
        '
        'SaveCancelPanel
        '
        Me.SaveCancelPanel.Controls.Add(Me.CancelRecordButton)
        Me.SaveCancelPanel.Controls.Add(Me.SaveRecordButton)
        Me.SaveCancelPanel.Location = New System.Drawing.Point(947, 113)
        Me.SaveCancelPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveCancelPanel.Name = "SaveCancelPanel"
        Me.SaveCancelPanel.Size = New System.Drawing.Size(221, 52)
        Me.SaveCancelPanel.TabIndex = 6
        '
        'CancelRecordButton
        '
        Me.CancelRecordButton.Location = New System.Drawing.Point(109, 4)
        Me.CancelRecordButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelRecordButton.Name = "CancelRecordButton"
        Me.CancelRecordButton.Size = New System.Drawing.Size(100, 44)
        Me.CancelRecordButton.TabIndex = 19
        Me.CancelRecordButton.Text = "&Cancel"
        Me.CancelRecordButton.UseVisualStyleBackColor = True
        '
        'SaveRecordButton
        '
        Me.SaveRecordButton.Location = New System.Drawing.Point(7, 4)
        Me.SaveRecordButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveRecordButton.Name = "SaveRecordButton"
        Me.SaveRecordButton.Size = New System.Drawing.Size(100, 44)
        Me.SaveRecordButton.TabIndex = 18
        Me.SaveRecordButton.Text = "&Accept"
        Me.SaveRecordButton.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(632, 607)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(606, 26)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.BackColor = System.Drawing.Color.Thistle
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel5.Text = "ToolStripStatusLabel5"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(109, 20)
        Me.ToolStripStatusLabel1.Text = "School Module"
        '
        'PanelSearch
        '
        Me.PanelSearch.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelSearch.Controls.Add(Me.ComboBoxCitySearch)
        Me.PanelSearch.Controls.Add(Me.TextBoxCOntactId)
        Me.PanelSearch.Controls.Add(Label1)
        Me.PanelSearch.Controls.Add(Label6)
        Me.PanelSearch.Controls.Add(Me.SearchEmployeeComboBox)
        Me.PanelSearch.Controls.Add(Label5)
        Me.PanelSearch.Controls.Add(Label3)
        Me.PanelSearch.Controls.Add(Me.SearchNameTextBox)
        Me.PanelSearch.Controls.Add(Me.CancelSearchButton)
        Me.PanelSearch.Enabled = False
        Me.PanelSearch.Location = New System.Drawing.Point(639, 29)
        Me.PanelSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(577, 84)
        Me.PanelSearch.TabIndex = 0
        '
        'SearchEmployeeComboBox
        '
        Me.SearchEmployeeComboBox.DataSource = Me.EmployeeBindingSource2
        Me.SearchEmployeeComboBox.DisplayMember = "Emply Name"
        Me.SearchEmployeeComboBox.FormattingEnabled = True
        Me.SearchEmployeeComboBox.Location = New System.Drawing.Point(378, 52)
        Me.SearchEmployeeComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchEmployeeComboBox.Name = "SearchEmployeeComboBox"
        Me.SearchEmployeeComboBox.Size = New System.Drawing.Size(185, 24)
        Me.SearchEmployeeComboBox.TabIndex = 2
        Me.SearchEmployeeComboBox.ValueMember = "EmplyId"
        '
        'SearchNameTextBox
        '
        Me.SearchNameTextBox.Location = New System.Drawing.Point(376, 14)
        Me.SearchNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchNameTextBox.Name = "SearchNameTextBox"
        Me.SearchNameTextBox.Size = New System.Drawing.Size(186, 22)
        Me.SearchNameTextBox.TabIndex = 0
        '
        'CancelSearchButton
        '
        Me.CancelSearchButton.Location = New System.Drawing.Point(4, 4)
        Me.CancelSearchButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelSearchButton.Name = "CancelSearchButton"
        Me.CancelSearchButton.Size = New System.Drawing.Size(103, 45)
        Me.CancelSearchButton.TabIndex = 3
        Me.CancelSearchButton.Text = "Cancel Search"
        Me.CancelSearchButton.UseVisualStyleBackColor = True
        '
        'SectorTableAdapter
        '
        Me.SectorTableAdapter.ClearBeforeFill = True
        '
        'Visited_SchoolsTableAdapter
        '
        Me.Visited_SchoolsTableAdapter.ClearBeforeFill = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(108, 4)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(97, 44)
        Me.EditButton.TabIndex = 10
        Me.EditButton.Text = "&Edit Data"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'AddNewButton1
        '
        Me.AddNewButton1.Location = New System.Drawing.Point(6, 4)
        Me.AddNewButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.AddNewButton1.Name = "AddNewButton1"
        Me.AddNewButton1.Size = New System.Drawing.Size(97, 44)
        Me.AddNewButton1.TabIndex = 9
        Me.AddNewButton1.Text = "Add &New"
        Me.AddNewButton1.UseVisualStyleBackColor = True
        '
        'AddEditPanel
        '
        Me.AddEditPanel.Controls.Add(Me.AddNewButton1)
        Me.AddEditPanel.Controls.Add(Me.EditButton)
        Me.AddEditPanel.Location = New System.Drawing.Point(650, 115)
        Me.AddEditPanel.Name = "AddEditPanel"
        Me.AddEditPanel.Size = New System.Drawing.Size(221, 53)
        Me.AddEditPanel.TabIndex = 0
        '
        'ContactsBindingNavigator
        '
        Me.ContactsBindingNavigator.AddNewItem = Nothing
        Me.ContactsBindingNavigator.BindingSource = Me.ContactsBindingSource
        Me.ContactsBindingNavigator.CountItem = Nothing
        Me.ContactsBindingNavigator.DeleteItem = Nothing
        Me.ContactsBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContactsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ContactsBindingNavigator.MoveFirstItem = Nothing
        Me.ContactsBindingNavigator.MoveLastItem = Nothing
        Me.ContactsBindingNavigator.MoveNextItem = Nothing
        Me.ContactsBindingNavigator.MovePreviousItem = Nothing
        Me.ContactsBindingNavigator.Name = "ContactsBindingNavigator"
        Me.ContactsBindingNavigator.PositionItem = Nothing
        Me.ContactsBindingNavigator.Size = New System.Drawing.Size(1238, 25)
        Me.ContactsBindingNavigator.TabIndex = 0
        Me.ContactsBindingNavigator.Text = "BindingNavigator1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(113, 14)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(75, 17)
        Label1.TabIndex = 22
        Label1.Text = "Contact Id:"
        '
        'TextBoxCOntactId
        '
        Me.TextBoxCOntactId.Location = New System.Drawing.Point(196, 13)
        Me.TextBoxCOntactId.Name = "TextBoxCOntactId"
        Me.TextBoxCOntactId.Size = New System.Drawing.Size(52, 22)
        Me.TextBoxCOntactId.TabIndex = 23
        '
        'ComboBoxCitySearch
        '
        Me.ComboBoxCitySearch.DataSource = Me.CityBindingSource2
        Me.ComboBoxCitySearch.DisplayMember = "City Name"
        Me.ComboBoxCitySearch.FormattingEnabled = True
        Me.ComboBoxCitySearch.Location = New System.Drawing.Point(94, 52)
        Me.ComboBoxCitySearch.Name = "ComboBoxCitySearch"
        Me.ComboBoxCitySearch.Size = New System.Drawing.Size(195, 24)
        Me.ComboBoxCitySearch.TabIndex = 24
        Me.ComboBoxCitySearch.ValueMember = "CityID"
        '
        'CityBindingSource2
        '
        Me.CityBindingSource2.DataMember = "City"
        Me.CityBindingSource2.DataSource = Me.Ingenium_2011DataSet
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 40
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Contact Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Contact Name"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Mobile Phone1"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Mobile Phone1"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 70
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "EmployeeId"
        Me.DataGridViewTextBoxColumn13.DataSource = Me.EmployeeBindingSource
        Me.DataGridViewTextBoxColumn13.DisplayMember = "Emply Name"
        Me.DataGridViewTextBoxColumn13.HeaderText = "EmployeeId"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn13.ValueMember = "EmplyId"
        Me.DataGridViewTextBoxColumn13.Width = 70
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "CityId"
        Me.DataGridViewTextBoxColumn15.DataSource = Me.CityBindingSource
        Me.DataGridViewTextBoxColumn15.DisplayMember = "City Name"
        Me.DataGridViewTextBoxColumn15.HeaderText = "CityId"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn15.ValueMember = "CityID"
        Me.DataGridViewTextBoxColumn15.Width = 70
        '
        'EmployeeBindingSource2
        '
        Me.EmployeeBindingSource2.DataMember = "Employee"
        Me.EmployeeBindingSource2.DataSource = Me.Ingenium_2011DataSet
        '
        'Contacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1238, 633)
        Me.Controls.Add(Me.AddEditPanel)
        Me.Controls.Add(Me.PanelSearch)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SaveCancelPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ContactsDataGridView)
        Me.Controls.Add(Me.ContactsBindingNavigator)
        Me.Name = "Contacts"
        Me.Text = "Contacts"
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContactsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CityBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitedSchoolsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SectorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SaveCancelPanel.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.PanelSearch.ResumeLayout(False)
        Me.PanelSearch.PerformLayout()
        Me.AddEditPanel.ResumeLayout(False)
        CType(Me.ContactsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ingenium_2011DataSet As Ingenium_2011DataSet
    Friend WithEvents ContactsBindingSource As BindingSource
    Friend WithEvents ContactsTableAdapter As Ingenium_2011DataSetTableAdapters.ContactsTableAdapter
    Friend WithEvents TableAdapterManager As Ingenium_2011DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ContactsDataGridView As DataGridView
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As Ingenium_2011DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents CityBindingSource As BindingSource
    Friend WithEvents CityTableAdapter As Ingenium_2011DataSetTableAdapters.CityTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents SchoolIdTextBox As TextBox
    Friend WithEvents Contact_NameTextBox As TextBox
    Friend WithEvents E_mail_AddressTextBox As TextBox
    Friend WithEvents Job_TitleTextBox As TextBox
    Friend WithEvents Business_PhoneTextBox As TextBox
    Friend WithEvents Mobile_Phone1TextBox As TextBox
    Friend WithEvents Mobile_Phone2TextBox As TextBox
    Friend WithEvents NotesTextBox As TextBox
    Friend WithEvents EmployeeIdTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityIdTextBox As TextBox
    Friend WithEvents VerifiedCheckBox As CheckBox
    Friend WithEvents SaveCancelPanel As Panel
    Friend WithEvents CancelRecordButton As Button
    Friend WithEvents SaveRecordButton As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents PanelSearch As Panel
    Friend WithEvents SearchEmployeeComboBox As ComboBox
    Friend WithEvents SearchNameTextBox As TextBox
    Friend WithEvents CancelSearchButton As Button
    Friend WithEvents SectorComboBox As ComboBox
    Friend WithEvents EmployeeBindingSource1 As BindingSource
    Friend WithEvents SectorBindingSource As BindingSource
    Friend WithEvents SectorTableAdapter As Ingenium_2011DataSetTableAdapters.SectorTableAdapter
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents SectorIdTextBox As TextBox
    Friend WithEvents VisitedSchoolsBindingSource As BindingSource
    Friend WithEvents Visited_SchoolsTableAdapter As Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter
    Friend WithEvents ComboBoxEmployee As ComboBox
    Friend WithEvents EditButton As Button
    Friend WithEvents AddNewButton1 As Button
    Friend WithEvents AddEditPanel As Panel
    Friend WithEvents ContactsBindingNavigator As BindingNavigator
    Friend WithEvents ComboBoxCity As ComboBox
    Friend WithEvents CityBindingSource1 As BindingSource
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TextBoxCOntactId As TextBox
    Friend WithEvents ComboBoxCitySearch As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewComboBoxColumn
    Friend WithEvents CityBindingSource2 As BindingSource
    Friend WithEvents EmployeeBindingSource2 As BindingSource
End Class
