<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Events_Students_Telecalling
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
        Me.components = New System.ComponentModel.Container()
        Dim CalledLabel As System.Windows.Forms.Label
        Dim Call_DetailsLabel As System.Windows.Forms.Label
        Dim ExpectedLabel As System.Windows.Forms.Label
        Dim Expected_DetailsLabel As System.Windows.Forms.Label
        Dim PresentLabel As System.Windows.Forms.Label
        Dim Present_DetailsLabel As System.Windows.Forms.Label
        Dim Admission_TakenLabel As System.Windows.Forms.Label
        Dim Follow_up_DetailsLabel As System.Windows.Forms.Label
        Dim StreamLabel As System.Windows.Forms.Label
        Dim Student_NameLabel As System.Windows.Forms.Label
        Dim Father_NameLabel As System.Windows.Forms.Label
        Dim Address_PermanentLabel As System.Windows.Forms.Label
        Dim Mobile_PersonalLabel As System.Windows.Forms.Label
        Dim Mobile_GuardianLabel As System.Windows.Forms.Label
        Dim Other_NoLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim Father_OccupationLabel As System.Windows.Forms.Label
        Dim BPLLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim _10th_GradeLabel As System.Windows.Forms.Label
        Dim Ingenium_Label As System.Windows.Forms.Label
        Dim Discount_offeredLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim StuIdLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource8 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource10 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource11 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Event_Student_CompleteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ingenium_2011DataSet = New WindowsApplication1.Ingenium_2011DataSet()
        Me.Complete_School_in_EventBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Event_MasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Visited_SchoolsTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter()
        Me.VisitedSchoolsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Event_MasterTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_MasterTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager()
        Me.Event_SchoolTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_SchoolTableAdapter()
        Me.Event_StudentsTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_StudentsTableAdapter()
        Me.StreamTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.StreamTableAdapter()
        Me.StudentTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.StudentTableAdapter()
        Me.Event_Student_CompleteTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_Student_CompleteTableAdapter()
        Me.Event_Student_CompleteDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Call_DetailsTextBox = New System.Windows.Forms.TextBox()
        Me.Event_StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Present_TimerDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.EventStuIdTextBox = New System.Windows.Forms.TextBox()
        Me.EventIdTextBox = New System.Windows.Forms.TextBox()
        Me.SchoolIdTextBox = New System.Windows.Forms.TextBox()
        Me.StudentIdTextBox = New System.Windows.Forms.TextBox()
        Me.CalledCheckBox = New System.Windows.Forms.CheckBox()
        Me.ExpectedCheckBox = New System.Windows.Forms.CheckBox()
        Me.Expected_DetailsTextBox = New System.Windows.Forms.TextBox()
        Me.PresentCheckBox = New System.Windows.Forms.CheckBox()
        Me.Present_DetailsTextBox = New System.Windows.Forms.TextBox()
        Me.Admission_TakenCheckBox = New System.Windows.Forms.CheckBox()
        Me.Follow_up_DetailsTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.StreamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_NameTextBox = New System.Windows.Forms.TextBox()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Father_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Address_PermanentTextBox = New System.Windows.Forms.TextBox()
        Me.Father_OccupationComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.StuIdTextBox = New System.Windows.Forms.TextBox()
        Me.SchoolIdTextBox1 = New System.Windows.Forms.TextBox()
        Me.Mobile_PersonalTextBox = New System.Windows.Forms.TextBox()
        Me.Mobile_GuardianTextBox = New System.Windows.Forms.TextBox()
        Me.Other_NoTextBox = New System.Windows.Forms.TextBox()
        Me.DOBTextBox = New System.Windows.Forms.TextBox()
        Me.Father_OccupationTextBox = New System.Windows.Forms.TextBox()
        Me.BPLCheckBox = New System.Windows.Forms.CheckBox()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me._10th_GradeTextBox = New System.Windows.Forms.TextBox()
        Me.Ingenium_TextBox = New System.Windows.Forms.TextBox()
        Me.Discount_offeredTextBox = New System.Windows.Forms.TextBox()
        Me.EventMasterComboBox = New System.Windows.Forms.ComboBox()
        Me.SearchSchoolNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SearchStuIdTextBox = New System.Windows.Forms.TextBox()
        Me.CallStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.SearchStuNameTextBox = New System.Windows.Forms.TextBox()
        Me.CancelSearchButton = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.EditEventsButton = New System.Windows.Forms.Button()
        Me.EventSavePanel = New System.Windows.Forms.Panel()
        Me.CancelEditButton = New System.Windows.Forms.Button()
        Me.SaveEditButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TwelthButton = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.SMSButton = New System.Windows.Forms.Button()
        Me.Add2InterestedButton = New System.Windows.Forms.Button()
        Me.StuIdTextBox1 = New System.Windows.Forms.TextBox()
        Me.StuSavePanel = New System.Windows.Forms.Panel()
        Me.CancelStuButton = New System.Windows.Forms.Button()
        Me.SaveStuButton = New System.Windows.Forms.Button()
        Me.EditStudentButton = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPagePresentCertificate = New System.Windows.Forms.TabPage()
        Me.CheckBoxAllPresent = New System.Windows.Forms.CheckBox()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ReportButton = New System.Windows.Forms.Button()
        Me.ReportTextBox = New System.Windows.Forms.TextBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPagecertificateCRT = New System.Windows.Forms.TabPage()
        Me.ReportViewer5 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPageCRTCallDetails = New System.Windows.Forms.TabPage()
        Me.ReportViewer6 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.ReportViewer7 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPageDetails = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPageCallDetails = New System.Windows.Forms.TabPage()
        Me.ReportViewer8 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPageSchoolDetails = New System.Windows.Forms.TabPage()
        Me.ReportViewer9 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPagePresentDetails = New System.Windows.Forms.TabPage()
        Me.ReportViewer10 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPageCallSummary = New System.Windows.Forms.TabPage()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPageSchoolSummary = New System.Windows.Forms.TabPage()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPagePresentSummary = New System.Windows.Forms.TabPage()
        Me.ReportViewer4 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReportViewerSMS = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Event_SchoolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllEventsCheckBox = New System.Windows.Forms.CheckBox()
        Me.ReportCheckBox = New System.Windows.Forms.CheckBox()
        Me.Complete_School_in_EventTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Complete_School_in_EventTableAdapter()
        Me.Event_Student_Complete1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Event_Student_Complete1TableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_Student_Complete1TableAdapter()
        CalledLabel = New System.Windows.Forms.Label()
        Call_DetailsLabel = New System.Windows.Forms.Label()
        ExpectedLabel = New System.Windows.Forms.Label()
        Expected_DetailsLabel = New System.Windows.Forms.Label()
        PresentLabel = New System.Windows.Forms.Label()
        Present_DetailsLabel = New System.Windows.Forms.Label()
        Admission_TakenLabel = New System.Windows.Forms.Label()
        Follow_up_DetailsLabel = New System.Windows.Forms.Label()
        StreamLabel = New System.Windows.Forms.Label()
        Student_NameLabel = New System.Windows.Forms.Label()
        Father_NameLabel = New System.Windows.Forms.Label()
        Address_PermanentLabel = New System.Windows.Forms.Label()
        Mobile_PersonalLabel = New System.Windows.Forms.Label()
        Mobile_GuardianLabel = New System.Windows.Forms.Label()
        Other_NoLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        Father_OccupationLabel = New System.Windows.Forms.Label()
        BPLLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        _10th_GradeLabel = New System.Windows.Forms.Label()
        Ingenium_Label = New System.Windows.Forms.Label()
        Discount_offeredLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        StuIdLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.Event_Student_CompleteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Complete_School_in_EventBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_MasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.VisitedSchoolsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_Student_CompleteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Event_StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.StreamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.EventSavePanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.StuSavePanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPagePresentCertificate.SuspendLayout()
        Me.TabPagecertificateCRT.SuspendLayout()
        Me.TabPageCRTCallDetails.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPageDetails.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPageCallDetails.SuspendLayout()
        Me.TabPageSchoolDetails.SuspendLayout()
        Me.TabPagePresentDetails.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPageCallSummary.SuspendLayout()
        Me.TabPageSchoolSummary.SuspendLayout()
        Me.TabPagePresentSummary.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Event_SchoolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_Student_Complete1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CalledLabel
        '
        CalledLabel.AutoSize = True
        CalledLabel.Location = New System.Drawing.Point(1, 33)
        CalledLabel.Name = "CalledLabel"
        CalledLabel.Size = New System.Drawing.Size(39, 13)
        CalledLabel.TabIndex = 8
        CalledLabel.Text = "Called:"
        '
        'Call_DetailsLabel
        '
        Call_DetailsLabel.AutoSize = True
        Call_DetailsLabel.Location = New System.Drawing.Point(26, 52)
        Call_DetailsLabel.Name = "Call_DetailsLabel"
        Call_DetailsLabel.Size = New System.Drawing.Size(62, 13)
        Call_DetailsLabel.TabIndex = 10
        Call_DetailsLabel.Text = "Call Details:"
        '
        'ExpectedLabel
        '
        ExpectedLabel.AutoSize = True
        ExpectedLabel.Location = New System.Drawing.Point(7, 71)
        ExpectedLabel.Name = "ExpectedLabel"
        ExpectedLabel.Size = New System.Drawing.Size(55, 13)
        ExpectedLabel.TabIndex = 12
        ExpectedLabel.Text = "Expected:"
        '
        'Expected_DetailsLabel
        '
        Expected_DetailsLabel.AutoSize = True
        Expected_DetailsLabel.Location = New System.Drawing.Point(1, 92)
        Expected_DetailsLabel.Name = "Expected_DetailsLabel"
        Expected_DetailsLabel.Size = New System.Drawing.Size(90, 13)
        Expected_DetailsLabel.TabIndex = 14
        Expected_DetailsLabel.Text = "Expected Details:"
        '
        'PresentLabel
        '
        PresentLabel.AutoSize = True
        PresentLabel.Location = New System.Drawing.Point(7, 115)
        PresentLabel.Name = "PresentLabel"
        PresentLabel.Size = New System.Drawing.Size(46, 13)
        PresentLabel.TabIndex = 16
        PresentLabel.Text = "Present:"
        '
        'Present_DetailsLabel
        '
        Present_DetailsLabel.AutoSize = True
        Present_DetailsLabel.Location = New System.Drawing.Point(7, 128)
        Present_DetailsLabel.Name = "Present_DetailsLabel"
        Present_DetailsLabel.Size = New System.Drawing.Size(81, 13)
        Present_DetailsLabel.TabIndex = 18
        Present_DetailsLabel.Text = "Present Details:"
        '
        'Admission_TakenLabel
        '
        Admission_TakenLabel.AutoSize = True
        Admission_TakenLabel.Location = New System.Drawing.Point(3, 147)
        Admission_TakenLabel.Name = "Admission_TakenLabel"
        Admission_TakenLabel.Size = New System.Drawing.Size(91, 13)
        Admission_TakenLabel.TabIndex = 20
        Admission_TakenLabel.Text = "Admission Taken:"
        '
        'Follow_up_DetailsLabel
        '
        Follow_up_DetailsLabel.AutoSize = True
        Follow_up_DetailsLabel.Location = New System.Drawing.Point(107, 144)
        Follow_up_DetailsLabel.Name = "Follow_up_DetailsLabel"
        Follow_up_DetailsLabel.Size = New System.Drawing.Size(90, 13)
        Follow_up_DetailsLabel.TabIndex = 22
        Follow_up_DetailsLabel.Text = "Follow-up Details:"
        '
        'StreamLabel
        '
        StreamLabel.AutoSize = True
        StreamLabel.Location = New System.Drawing.Point(8, 6)
        StreamLabel.Name = "StreamLabel"
        StreamLabel.Size = New System.Drawing.Size(43, 13)
        StreamLabel.TabIndex = 4
        StreamLabel.Text = "Stream:"
        '
        'Student_NameLabel
        '
        Student_NameLabel.AutoSize = True
        Student_NameLabel.Location = New System.Drawing.Point(6, 33)
        Student_NameLabel.Name = "Student_NameLabel"
        Student_NameLabel.Size = New System.Drawing.Size(78, 13)
        Student_NameLabel.TabIndex = 6
        Student_NameLabel.Text = "Student Name:"
        '
        'Father_NameLabel
        '
        Father_NameLabel.AutoSize = True
        Father_NameLabel.Location = New System.Drawing.Point(6, 59)
        Father_NameLabel.Name = "Father_NameLabel"
        Father_NameLabel.Size = New System.Drawing.Size(71, 13)
        Father_NameLabel.TabIndex = 8
        Father_NameLabel.Text = "Father Name:"
        '
        'Address_PermanentLabel
        '
        Address_PermanentLabel.AutoSize = True
        Address_PermanentLabel.Location = New System.Drawing.Point(7, 85)
        Address_PermanentLabel.Name = "Address_PermanentLabel"
        Address_PermanentLabel.Size = New System.Drawing.Size(48, 13)
        Address_PermanentLabel.TabIndex = 10
        Address_PermanentLabel.Text = "Address:"
        '
        'Mobile_PersonalLabel
        '
        Mobile_PersonalLabel.AutoSize = True
        Mobile_PersonalLabel.Location = New System.Drawing.Point(3, 137)
        Mobile_PersonalLabel.Name = "Mobile_PersonalLabel"
        Mobile_PersonalLabel.Size = New System.Drawing.Size(85, 13)
        Mobile_PersonalLabel.TabIndex = 14
        Mobile_PersonalLabel.Text = "Mobile Personal:"
        '
        'Mobile_GuardianLabel
        '
        Mobile_GuardianLabel.AutoSize = True
        Mobile_GuardianLabel.Location = New System.Drawing.Point(3, 163)
        Mobile_GuardianLabel.Name = "Mobile_GuardianLabel"
        Mobile_GuardianLabel.Size = New System.Drawing.Size(87, 13)
        Mobile_GuardianLabel.TabIndex = 16
        Mobile_GuardianLabel.Text = "Mobile Guardian:"
        '
        'Other_NoLabel
        '
        Other_NoLabel.AutoSize = True
        Other_NoLabel.Location = New System.Drawing.Point(3, 192)
        Other_NoLabel.Name = "Other_NoLabel"
        Other_NoLabel.Size = New System.Drawing.Size(53, 13)
        Other_NoLabel.TabIndex = 18
        Other_NoLabel.Text = "Other No:"
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(214, 188)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 22
        DOBLabel.Text = "DOB:"
        '
        'Father_OccupationLabel
        '
        Father_OccupationLabel.AutoSize = True
        Father_OccupationLabel.Location = New System.Drawing.Point(5, 216)
        Father_OccupationLabel.Name = "Father_OccupationLabel"
        Father_OccupationLabel.Size = New System.Drawing.Size(98, 13)
        Father_OccupationLabel.TabIndex = 24
        Father_OccupationLabel.Text = "Father Occupation:"
        '
        'BPLLabel
        '
        BPLLabel.AutoSize = True
        BPLLabel.Location = New System.Drawing.Point(241, 212)
        BPLLabel.Name = "BPLLabel"
        BPLLabel.Size = New System.Drawing.Size(30, 13)
        BPLLabel.TabIndex = 26
        BPLLabel.Text = "BPL:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(6, 242)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(52, 13)
        CategoryLabel.TabIndex = 28
        CategoryLabel.Text = "Category:"
        '
        '_10th_GradeLabel
        '
        _10th_GradeLabel.AutoSize = True
        _10th_GradeLabel.Location = New System.Drawing.Point(150, 238)
        _10th_GradeLabel.Name = "_10th_GradeLabel"
        _10th_GradeLabel.Size = New System.Drawing.Size(34, 13)
        _10th_GradeLabel.TabIndex = 30
        _10th_GradeLabel.Text = "10th :"
        '
        'Ingenium_Label
        '
        Ingenium_Label.AutoSize = True
        Ingenium_Label.Location = New System.Drawing.Point(228, 238)
        Ingenium_Label.Name = "Ingenium_Label"
        Ingenium_Label.Size = New System.Drawing.Size(61, 13)
        Ingenium_Label.TabIndex = 32
        Ingenium_Label.Text = "Ingenium%:"
        '
        'Discount_offeredLabel
        '
        Discount_offeredLabel.AutoSize = True
        Discount_offeredLabel.Location = New System.Drawing.Point(1, 274)
        Discount_offeredLabel.Name = "Discount_offeredLabel"
        Discount_offeredLabel.Size = New System.Drawing.Size(88, 13)
        Discount_offeredLabel.TabIndex = 34
        Discount_offeredLabel.Text = "Discount offered:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(78, 30)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(74, 13)
        Label1.TabIndex = 3
        Label1.Text = "School Name:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(73, 6)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(78, 13)
        Label2.TabIndex = 3
        Label2.Text = "Student Name:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(11, 57)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(60, 13)
        Label3.TabIndex = 5
        Label3.Text = "Call Status:"
        '
        'StuIdLabel
        '
        StuIdLabel.AutoSize = True
        StuIdLabel.Location = New System.Drawing.Point(23, 8)
        StuIdLabel.Name = "StuIdLabel"
        StuIdLabel.Size = New System.Drawing.Size(38, 13)
        StuIdLabel.TabIndex = 12
        StuIdLabel.Text = "Stu Id:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(243, 53)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(38, 13)
        Label4.TabIndex = 13
        Label4.Text = "Stu Id:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(15, 9)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(69, 13)
        Label5.TabIndex = 23
        Label5.Text = "Event Name:"
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
        'Event_MasterBindingSource
        '
        Me.Event_MasterBindingSource.DataMember = "Event Master"
        Me.Event_MasterBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(818, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripLabel1.Text = "Select Event"
        '
        'Visited_SchoolsTableAdapter
        '
        Me.Visited_SchoolsTableAdapter.ClearBeforeFill = True
        '
        'VisitedSchoolsBindingSource
        '
        Me.VisitedSchoolsBindingSource.DataMember = "Visited Schools"
        Me.VisitedSchoolsBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Event_MasterTableAdapter
        '
        Me.Event_MasterTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Event_MasterTableAdapter = Me.Event_MasterTableAdapter
        Me.TableAdapterManager.Event_SchoolTableAdapter = Me.Event_SchoolTableAdapter
        Me.TableAdapterManager.Event_StudentsTableAdapter = Me.Event_StudentsTableAdapter
        Me.TableAdapterManager.Interested_StudentTableAdapter = Nothing
        Me.TableAdapterManager.School_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.School_VisitTableAdapter = Nothing
        Me.TableAdapterManager.SMS_TextTableAdapter = Nothing
        Me.TableAdapterManager.StreamTableAdapter = Me.StreamTableAdapter
        Me.TableAdapterManager.StudentTableAdapter = Me.StudentTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Visited_SchoolsTableAdapter = Me.Visited_SchoolsTableAdapter
        '
        'Event_SchoolTableAdapter
        '
        Me.Event_SchoolTableAdapter.ClearBeforeFill = True
        '
        'Event_StudentsTableAdapter
        '
        Me.Event_StudentsTableAdapter.ClearBeforeFill = True
        '
        'StreamTableAdapter
        '
        Me.StreamTableAdapter.ClearBeforeFill = True
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'Event_Student_CompleteTableAdapter
        '
        Me.Event_Student_CompleteTableAdapter.ClearBeforeFill = True
        '
        'Event_Student_CompleteDataGridView
        '
        Me.Event_Student_CompleteDataGridView.AllowUserToAddRows = False
        Me.Event_Student_CompleteDataGridView.AllowUserToDeleteRows = False
        Me.Event_Student_CompleteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Event_Student_CompleteDataGridView.Location = New System.Drawing.Point(5, 92)
        Me.Event_Student_CompleteDataGridView.Name = "Event_Student_CompleteDataGridView"
        Me.Event_Student_CompleteDataGridView.ReadOnly = True
        Me.Event_Student_CompleteDataGridView.RowHeadersWidth = 11
        Me.Event_Student_CompleteDataGridView.Size = New System.Drawing.Size(356, 425)
        Me.Event_Student_CompleteDataGridView.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel1.Controls.Add(Me.Call_DetailsTextBox)
        Me.Panel1.Controls.Add(Me.Present_TimerDateTimePicker)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.EventStuIdTextBox)
        Me.Panel1.Controls.Add(Me.EventIdTextBox)
        Me.Panel1.Controls.Add(Me.SchoolIdTextBox)
        Me.Panel1.Controls.Add(Me.StudentIdTextBox)
        Me.Panel1.Controls.Add(CalledLabel)
        Me.Panel1.Controls.Add(Me.CalledCheckBox)
        Me.Panel1.Controls.Add(Call_DetailsLabel)
        Me.Panel1.Controls.Add(ExpectedLabel)
        Me.Panel1.Controls.Add(Me.ExpectedCheckBox)
        Me.Panel1.Controls.Add(Expected_DetailsLabel)
        Me.Panel1.Controls.Add(Me.Expected_DetailsTextBox)
        Me.Panel1.Controls.Add(PresentLabel)
        Me.Panel1.Controls.Add(Me.PresentCheckBox)
        Me.Panel1.Controls.Add(Present_DetailsLabel)
        Me.Panel1.Controls.Add(Me.Present_DetailsTextBox)
        Me.Panel1.Controls.Add(Admission_TakenLabel)
        Me.Panel1.Controls.Add(Me.Admission_TakenCheckBox)
        Me.Panel1.Controls.Add(Follow_up_DetailsLabel)
        Me.Panel1.Controls.Add(Me.Follow_up_DetailsTextBox)
        Me.Panel1.Location = New System.Drawing.Point(91, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 198)
        Me.Panel1.TabIndex = 2
        '
        'Call_DetailsTextBox
        '
        Me.Call_DetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_StudentsBindingSource, "Call Details", True))
        Me.Call_DetailsTextBox.Location = New System.Drawing.Point(94, 30)
        Me.Call_DetailsTextBox.Multiline = True
        Me.Call_DetailsTextBox.Name = "Call_DetailsTextBox"
        Me.Call_DetailsTextBox.Size = New System.Drawing.Size(231, 35)
        Me.Call_DetailsTextBox.TabIndex = 10
        '
        'Event_StudentsBindingSource
        '
        Me.Event_StudentsBindingSource.DataMember = "Event Student Complete_Event Students"
        Me.Event_StudentsBindingSource.DataSource = Me.Event_Student_CompleteBindingSource
        '
        'Present_TimerDateTimePicker
        '
        Me.Present_TimerDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Event_StudentsBindingSource, "Present Timer", True))
        Me.Present_TimerDateTimePicker.Location = New System.Drawing.Point(141, 42)
        Me.Present_TimerDateTimePicker.Name = "Present_TimerDateTimePicker"
        Me.Present_TimerDateTimePicker.Size = New System.Drawing.Size(96, 20)
        Me.Present_TimerDateTimePicker.TabIndex = 24
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_Student_CompleteBindingSource, "Event Name", True))
        Me.TextBox1.Location = New System.Drawing.Point(93, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(232, 20)
        Me.TextBox1.TabIndex = 11
        '
        'EventStuIdTextBox
        '
        Me.EventStuIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_StudentsBindingSource, "EventStuId", True))
        Me.EventStuIdTextBox.Location = New System.Drawing.Point(264, 41)
        Me.EventStuIdTextBox.Name = "EventStuIdTextBox"
        Me.EventStuIdTextBox.Size = New System.Drawing.Size(11, 20)
        Me.EventStuIdTextBox.TabIndex = 1
        '
        'EventIdTextBox
        '
        Me.EventIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_StudentsBindingSource, "EventId", True))
        Me.EventIdTextBox.Location = New System.Drawing.Point(281, 41)
        Me.EventIdTextBox.Name = "EventIdTextBox"
        Me.EventIdTextBox.Size = New System.Drawing.Size(11, 20)
        Me.EventIdTextBox.TabIndex = 3
        '
        'SchoolIdTextBox
        '
        Me.SchoolIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_StudentsBindingSource, "SchoolId", True))
        Me.SchoolIdTextBox.Location = New System.Drawing.Point(306, 44)
        Me.SchoolIdTextBox.Name = "SchoolIdTextBox"
        Me.SchoolIdTextBox.Size = New System.Drawing.Size(11, 20)
        Me.SchoolIdTextBox.TabIndex = 5
        '
        'StudentIdTextBox
        '
        Me.StudentIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_StudentsBindingSource, "StudentId", True))
        Me.StudentIdTextBox.Location = New System.Drawing.Point(226, 42)
        Me.StudentIdTextBox.Name = "StudentIdTextBox"
        Me.StudentIdTextBox.Size = New System.Drawing.Size(11, 20)
        Me.StudentIdTextBox.TabIndex = 7
        '
        'CalledCheckBox
        '
        Me.CalledCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Event_StudentsBindingSource, "Called", True))
        Me.CalledCheckBox.Location = New System.Drawing.Point(43, 28)
        Me.CalledCheckBox.Name = "CalledCheckBox"
        Me.CalledCheckBox.Size = New System.Drawing.Size(24, 24)
        Me.CalledCheckBox.TabIndex = 9
        Me.CalledCheckBox.UseVisualStyleBackColor = True
        '
        'ExpectedCheckBox
        '
        Me.ExpectedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Event_StudentsBindingSource, "Expected", True))
        Me.ExpectedCheckBox.Location = New System.Drawing.Point(64, 66)
        Me.ExpectedCheckBox.Name = "ExpectedCheckBox"
        Me.ExpectedCheckBox.Size = New System.Drawing.Size(24, 24)
        Me.ExpectedCheckBox.TabIndex = 11
        Me.ExpectedCheckBox.UseVisualStyleBackColor = True
        '
        'Expected_DetailsTextBox
        '
        Me.Expected_DetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_StudentsBindingSource, "Expected Details", True))
        Me.Expected_DetailsTextBox.Location = New System.Drawing.Point(94, 71)
        Me.Expected_DetailsTextBox.Multiline = True
        Me.Expected_DetailsTextBox.Name = "Expected_DetailsTextBox"
        Me.Expected_DetailsTextBox.Size = New System.Drawing.Size(232, 24)
        Me.Expected_DetailsTextBox.TabIndex = 12
        '
        'PresentCheckBox
        '
        Me.PresentCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Event_StudentsBindingSource, "Present", True))
        Me.PresentCheckBox.Location = New System.Drawing.Point(53, 110)
        Me.PresentCheckBox.Name = "PresentCheckBox"
        Me.PresentCheckBox.Size = New System.Drawing.Size(24, 18)
        Me.PresentCheckBox.TabIndex = 13
        Me.PresentCheckBox.UseVisualStyleBackColor = True
        '
        'Present_DetailsTextBox
        '
        Me.Present_DetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_StudentsBindingSource, "Present Details", True))
        Me.Present_DetailsTextBox.Location = New System.Drawing.Point(94, 111)
        Me.Present_DetailsTextBox.Multiline = True
        Me.Present_DetailsTextBox.Name = "Present_DetailsTextBox"
        Me.Present_DetailsTextBox.Size = New System.Drawing.Size(232, 30)
        Me.Present_DetailsTextBox.TabIndex = 14
        '
        'Admission_TakenCheckBox
        '
        Me.Admission_TakenCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Event_StudentsBindingSource, "Admission Taken", True))
        Me.Admission_TakenCheckBox.Location = New System.Drawing.Point(11, 160)
        Me.Admission_TakenCheckBox.Name = "Admission_TakenCheckBox"
        Me.Admission_TakenCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.Admission_TakenCheckBox.TabIndex = 15
        Me.Admission_TakenCheckBox.UseVisualStyleBackColor = True
        '
        'Follow_up_DetailsTextBox
        '
        Me.Follow_up_DetailsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_StudentsBindingSource, "Follow-up Details", True))
        Me.Follow_up_DetailsTextBox.Location = New System.Drawing.Point(95, 160)
        Me.Follow_up_DetailsTextBox.Multiline = True
        Me.Follow_up_DetailsTextBox.Name = "Follow_up_DetailsTextBox"
        Me.Follow_up_DetailsTextBox.Size = New System.Drawing.Size(231, 24)
        Me.Follow_up_DetailsTextBox.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel2.Controls.Add(Me.ComboBox2)
        Me.Panel2.Controls.Add(Me.Student_NameTextBox)
        Me.Panel2.Controls.Add(Me.Father_NameTextBox)
        Me.Panel2.Controls.Add(Me.Address_PermanentTextBox)
        Me.Panel2.Controls.Add(Me.Father_OccupationComboBox)
        Me.Panel2.Controls.Add(Me.CategoryComboBox)
        Me.Panel2.Controls.Add(Me.StuIdTextBox)
        Me.Panel2.Controls.Add(Me.SchoolIdTextBox1)
        Me.Panel2.Controls.Add(StreamLabel)
        Me.Panel2.Controls.Add(Student_NameLabel)
        Me.Panel2.Controls.Add(Father_NameLabel)
        Me.Panel2.Controls.Add(Address_PermanentLabel)
        Me.Panel2.Controls.Add(Mobile_PersonalLabel)
        Me.Panel2.Controls.Add(Me.Mobile_PersonalTextBox)
        Me.Panel2.Controls.Add(Mobile_GuardianLabel)
        Me.Panel2.Controls.Add(Me.Mobile_GuardianTextBox)
        Me.Panel2.Controls.Add(Other_NoLabel)
        Me.Panel2.Controls.Add(Me.Other_NoTextBox)
        Me.Panel2.Controls.Add(DOBLabel)
        Me.Panel2.Controls.Add(Me.DOBTextBox)
        Me.Panel2.Controls.Add(Father_OccupationLabel)
        Me.Panel2.Controls.Add(Me.Father_OccupationTextBox)
        Me.Panel2.Controls.Add(BPLLabel)
        Me.Panel2.Controls.Add(Me.BPLCheckBox)
        Me.Panel2.Controls.Add(CategoryLabel)
        Me.Panel2.Controls.Add(Me.CategoryTextBox)
        Me.Panel2.Controls.Add(_10th_GradeLabel)
        Me.Panel2.Controls.Add(Me._10th_GradeTextBox)
        Me.Panel2.Controls.Add(Ingenium_Label)
        Me.Panel2.Controls.Add(Me.Ingenium_TextBox)
        Me.Panel2.Controls.Add(Discount_offeredLabel)
        Me.Panel2.Controls.Add(Me.Discount_offeredTextBox)
        Me.Panel2.Location = New System.Drawing.Point(89, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(348, 311)
        Me.Panel2.TabIndex = 3
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.StreamBindingSource
        Me.ComboBox2.DisplayMember = "Stream"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(90, 3)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 0
        Me.ComboBox2.ValueMember = "StreamId"
        '
        'StreamBindingSource
        '
        Me.StreamBindingSource.DataMember = "Stream"
        Me.StreamBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Student_NameTextBox
        '
        Me.Student_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Student Name", True))
        Me.Student_NameTextBox.Location = New System.Drawing.Point(90, 30)
        Me.Student_NameTextBox.Name = "Student_NameTextBox"
        Me.Student_NameTextBox.Size = New System.Drawing.Size(248, 20)
        Me.Student_NameTextBox.TabIndex = 1
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Father_NameTextBox
        '
        Me.Father_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Father Name", True))
        Me.Father_NameTextBox.Location = New System.Drawing.Point(90, 56)
        Me.Father_NameTextBox.Name = "Father_NameTextBox"
        Me.Father_NameTextBox.Size = New System.Drawing.Size(248, 20)
        Me.Father_NameTextBox.TabIndex = 2
        '
        'Address_PermanentTextBox
        '
        Me.Address_PermanentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Address", True))
        Me.Address_PermanentTextBox.Location = New System.Drawing.Point(85, 82)
        Me.Address_PermanentTextBox.Multiline = True
        Me.Address_PermanentTextBox.Name = "Address_PermanentTextBox"
        Me.Address_PermanentTextBox.Size = New System.Drawing.Size(248, 46)
        Me.Address_PermanentTextBox.TabIndex = 3
        '
        'Father_OccupationComboBox
        '
        Me.Father_OccupationComboBox.FormattingEnabled = True
        Me.Father_OccupationComboBox.Items.AddRange(New Object() {"Business", "Govt. Job", "Teacher", "Police", "KESCO", "Farmer", "Private Job", "Other"})
        Me.Father_OccupationComboBox.Location = New System.Drawing.Point(110, 212)
        Me.Father_OccupationComboBox.Name = "Father_OccupationComboBox"
        Me.Father_OccupationComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Father_OccupationComboBox.TabIndex = 10
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Items.AddRange(New Object() {"General", "SC", "ST", "OBC", "Minority", "Other"})
        Me.CategoryComboBox.Location = New System.Drawing.Point(55, 238)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(96, 21)
        Me.CategoryComboBox.TabIndex = 12
        '
        'StuIdTextBox
        '
        Me.StuIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_Student_CompleteBindingSource, "StudentId", True))
        Me.StuIdTextBox.Location = New System.Drawing.Point(285, 101)
        Me.StuIdTextBox.Name = "StuIdTextBox"
        Me.StuIdTextBox.Size = New System.Drawing.Size(18, 20)
        Me.StuIdTextBox.TabIndex = 1
        '
        'SchoolIdTextBox1
        '
        Me.SchoolIdTextBox1.Location = New System.Drawing.Point(278, 101)
        Me.SchoolIdTextBox1.Name = "SchoolIdTextBox1"
        Me.SchoolIdTextBox1.Size = New System.Drawing.Size(18, 20)
        Me.SchoolIdTextBox1.TabIndex = 3
        '
        'Mobile_PersonalTextBox
        '
        Me.Mobile_PersonalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Mobile Personal", True))
        Me.Mobile_PersonalTextBox.Location = New System.Drawing.Point(90, 134)
        Me.Mobile_PersonalTextBox.Name = "Mobile_PersonalTextBox"
        Me.Mobile_PersonalTextBox.Size = New System.Drawing.Size(147, 20)
        Me.Mobile_PersonalTextBox.TabIndex = 5
        '
        'Mobile_GuardianTextBox
        '
        Me.Mobile_GuardianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Mobile Guardian", True))
        Me.Mobile_GuardianTextBox.Location = New System.Drawing.Point(90, 160)
        Me.Mobile_GuardianTextBox.Name = "Mobile_GuardianTextBox"
        Me.Mobile_GuardianTextBox.Size = New System.Drawing.Size(147, 20)
        Me.Mobile_GuardianTextBox.TabIndex = 6
        '
        'Other_NoTextBox
        '
        Me.Other_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Other No", True))
        Me.Other_NoTextBox.Location = New System.Drawing.Point(90, 188)
        Me.Other_NoTextBox.Name = "Other_NoTextBox"
        Me.Other_NoTextBox.Size = New System.Drawing.Size(111, 20)
        Me.Other_NoTextBox.TabIndex = 7
        '
        'DOBTextBox
        '
        Me.DOBTextBox.Location = New System.Drawing.Point(253, 185)
        Me.DOBTextBox.Name = "DOBTextBox"
        Me.DOBTextBox.Size = New System.Drawing.Size(65, 20)
        Me.DOBTextBox.TabIndex = 9
        '
        'Father_OccupationTextBox
        '
        Me.Father_OccupationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Father Occupation", True))
        Me.Father_OccupationTextBox.Location = New System.Drawing.Point(261, 108)
        Me.Father_OccupationTextBox.Name = "Father_OccupationTextBox"
        Me.Father_OccupationTextBox.Size = New System.Drawing.Size(10, 20)
        Me.Father_OccupationTextBox.TabIndex = 25
        '
        'BPLCheckBox
        '
        Me.BPLCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.StudentBindingSource, "BPL", True))
        Me.BPLCheckBox.Location = New System.Drawing.Point(276, 207)
        Me.BPLCheckBox.Name = "BPLCheckBox"
        Me.BPLCheckBox.Size = New System.Drawing.Size(19, 24)
        Me.BPLCheckBox.TabIndex = 11
        Me.BPLCheckBox.UseVisualStyleBackColor = True
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Category", True))
        Me.CategoryTextBox.Location = New System.Drawing.Point(302, 108)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(10, 20)
        Me.CategoryTextBox.TabIndex = 29
        '
        '_10th_GradeTextBox
        '
        Me._10th_GradeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "10th Grade", True))
        Me._10th_GradeTextBox.Location = New System.Drawing.Point(184, 235)
        Me._10th_GradeTextBox.Name = "_10th_GradeTextBox"
        Me._10th_GradeTextBox.Size = New System.Drawing.Size(38, 20)
        Me._10th_GradeTextBox.TabIndex = 13
        '
        'Ingenium_TextBox
        '
        Me.Ingenium_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Ingenium%", True))
        Me.Ingenium_TextBox.Location = New System.Drawing.Point(295, 235)
        Me.Ingenium_TextBox.Name = "Ingenium_TextBox"
        Me.Ingenium_TextBox.Size = New System.Drawing.Size(38, 20)
        Me.Ingenium_TextBox.TabIndex = 14
        '
        'Discount_offeredTextBox
        '
        Me.Discount_offeredTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Discount offered", True))
        Me.Discount_offeredTextBox.Location = New System.Drawing.Point(95, 268)
        Me.Discount_offeredTextBox.Multiline = True
        Me.Discount_offeredTextBox.Name = "Discount_offeredTextBox"
        Me.Discount_offeredTextBox.Size = New System.Drawing.Size(228, 40)
        Me.Discount_offeredTextBox.TabIndex = 15
        '
        'EventMasterComboBox
        '
        Me.EventMasterComboBox.DataSource = Me.Event_MasterBindingSource
        Me.EventMasterComboBox.DisplayMember = "Event Name"
        Me.EventMasterComboBox.FormattingEnabled = True
        Me.EventMasterComboBox.Location = New System.Drawing.Point(91, 4)
        Me.EventMasterComboBox.Name = "EventMasterComboBox"
        Me.EventMasterComboBox.Size = New System.Drawing.Size(278, 21)
        Me.EventMasterComboBox.TabIndex = 0
        Me.EventMasterComboBox.ValueMember = "EventId"
        '
        'SearchSchoolNameTextBox
        '
        Me.SearchSchoolNameTextBox.Location = New System.Drawing.Point(160, 26)
        Me.SearchSchoolNameTextBox.Name = "SearchSchoolNameTextBox"
        Me.SearchSchoolNameTextBox.Size = New System.Drawing.Size(184, 20)
        Me.SearchSchoolNameTextBox.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel4.Controls.Add(Me.SearchStuIdTextBox)
        Me.Panel4.Controls.Add(Label4)
        Me.Panel4.Controls.Add(Label3)
        Me.Panel4.Controls.Add(Me.CallStatusComboBox)
        Me.Panel4.Controls.Add(Label1)
        Me.Panel4.Controls.Add(Me.SearchSchoolNameTextBox)
        Me.Panel4.Controls.Add(Label2)
        Me.Panel4.Controls.Add(Me.SearchStuNameTextBox)
        Me.Panel4.Controls.Add(Me.CancelSearchButton)
        Me.Panel4.Location = New System.Drawing.Point(6, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(356, 80)
        Me.Panel4.TabIndex = 0
        '
        'SearchStuIdTextBox
        '
        Me.SearchStuIdTextBox.Location = New System.Drawing.Point(288, 50)
        Me.SearchStuIdTextBox.Name = "SearchStuIdTextBox"
        Me.SearchStuIdTextBox.Size = New System.Drawing.Size(56, 20)
        Me.SearchStuIdTextBox.TabIndex = 3
        '
        'CallStatusComboBox
        '
        Me.CallStatusComboBox.FormattingEnabled = True
        Me.CallStatusComboBox.Items.AddRange(New Object() {"All", "Called", "Not-Called", "Expected", "Called-Not Expected", "Present", "Expected-Not Present", "Present-Not Expected", "Not Present", "Admission Taken", "Admission Not Taken", "Called-Not Present"})
        Me.CallStatusComboBox.Location = New System.Drawing.Point(81, 49)
        Me.CallStatusComboBox.Name = "CallStatusComboBox"
        Me.CallStatusComboBox.Size = New System.Drawing.Size(142, 21)
        Me.CallStatusComboBox.TabIndex = 2
        Me.CallStatusComboBox.Text = "All"
        '
        'SearchStuNameTextBox
        '
        Me.SearchStuNameTextBox.Location = New System.Drawing.Point(160, 3)
        Me.SearchStuNameTextBox.Name = "SearchStuNameTextBox"
        Me.SearchStuNameTextBox.Size = New System.Drawing.Size(184, 20)
        Me.SearchStuNameTextBox.TabIndex = 0
        '
        'CancelSearchButton
        '
        Me.CancelSearchButton.Location = New System.Drawing.Point(3, 3)
        Me.CancelSearchButton.Name = "CancelSearchButton"
        Me.CancelSearchButton.Size = New System.Drawing.Size(68, 44)
        Me.CancelSearchButton.TabIndex = 3
        Me.CancelSearchButton.Text = "Cancel Search"
        Me.CancelSearchButton.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 580)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(818, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(74, 17)
        Me.ToolStripStatusLabel1.Text = "Event Details"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.Plum
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(86, 17)
        Me.ToolStripStatusLabel2.Text = "Student Details"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.SandyBrown
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(66, 17)
        Me.ToolStripStatusLabel3.Text = "View Mode"
        '
        'EditEventsButton
        '
        Me.EditEventsButton.Location = New System.Drawing.Point(9, 63)
        Me.EditEventsButton.Name = "EditEventsButton"
        Me.EditEventsButton.Size = New System.Drawing.Size(75, 45)
        Me.EditEventsButton.TabIndex = 0
        Me.EditEventsButton.Text = "Edit Event Details"
        Me.EditEventsButton.UseVisualStyleBackColor = True
        '
        'EventSavePanel
        '
        Me.EventSavePanel.Controls.Add(Me.CancelEditButton)
        Me.EventSavePanel.Controls.Add(Me.SaveEditButton)
        Me.EventSavePanel.Location = New System.Drawing.Point(3, 114)
        Me.EventSavePanel.Name = "EventSavePanel"
        Me.EventSavePanel.Size = New System.Drawing.Size(84, 77)
        Me.EventSavePanel.TabIndex = 10
        '
        'CancelEditButton
        '
        Me.CancelEditButton.Location = New System.Drawing.Point(6, 41)
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TwelthButton)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.EventSavePanel)
        Me.Panel3.Controls.Add(Me.EditEventsButton)
        Me.Panel3.Location = New System.Drawing.Point(367, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(435, 195)
        Me.Panel3.TabIndex = 2
        '
        'TwelthButton
        '
        Me.TwelthButton.BackColor = System.Drawing.Color.DarkRed
        Me.TwelthButton.Enabled = False
        Me.TwelthButton.Location = New System.Drawing.Point(6, 1)
        Me.TwelthButton.Name = "TwelthButton"
        Me.TwelthButton.Size = New System.Drawing.Size(84, 60)
        Me.TwelthButton.TabIndex = 17
        Me.TwelthButton.Text = "11th Student"
        Me.TwelthButton.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel5.Controls.Add(Me.SMSButton)
        Me.Panel5.Controls.Add(Me.Add2InterestedButton)
        Me.Panel5.Controls.Add(StuIdLabel)
        Me.Panel5.Controls.Add(Me.StuIdTextBox1)
        Me.Panel5.Controls.Add(Me.StuSavePanel)
        Me.Panel5.Controls.Add(Me.EditStudentButton)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Location = New System.Drawing.Point(365, 199)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(441, 318)
        Me.Panel5.TabIndex = 3
        '
        'SMSButton
        '
        Me.SMSButton.Location = New System.Drawing.Point(3, 259)
        Me.SMSButton.Name = "SMSButton"
        Me.SMSButton.Size = New System.Drawing.Size(84, 51)
        Me.SMSButton.TabIndex = 15
        Me.SMSButton.Text = "Send SMS"
        Me.SMSButton.UseVisualStyleBackColor = True
        '
        'Add2InterestedButton
        '
        Me.Add2InterestedButton.Location = New System.Drawing.Point(3, 187)
        Me.Add2InterestedButton.Name = "Add2InterestedButton"
        Me.Add2InterestedButton.Size = New System.Drawing.Size(84, 66)
        Me.Add2InterestedButton.TabIndex = 14
        Me.Add2InterestedButton.Text = "Add Student as Interested"
        Me.Add2InterestedButton.UseVisualStyleBackColor = True
        '
        'StuIdTextBox1
        '
        Me.StuIdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "StuId", True))
        Me.StuIdTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.StuIdTextBox1.Location = New System.Drawing.Point(3, 24)
        Me.StuIdTextBox1.Name = "StuIdTextBox1"
        Me.StuIdTextBox1.ReadOnly = True
        Me.StuIdTextBox1.Size = New System.Drawing.Size(83, 26)
        Me.StuIdTextBox1.TabIndex = 13
        '
        'StuSavePanel
        '
        Me.StuSavePanel.Controls.Add(Me.CancelStuButton)
        Me.StuSavePanel.Controls.Add(Me.SaveStuButton)
        Me.StuSavePanel.Location = New System.Drawing.Point(3, 107)
        Me.StuSavePanel.Name = "StuSavePanel"
        Me.StuSavePanel.Size = New System.Drawing.Size(83, 77)
        Me.StuSavePanel.TabIndex = 12
        '
        'CancelStuButton
        '
        Me.CancelStuButton.Location = New System.Drawing.Point(6, 41)
        Me.CancelStuButton.Name = "CancelStuButton"
        Me.CancelStuButton.Size = New System.Drawing.Size(75, 32)
        Me.CancelStuButton.TabIndex = 1
        Me.CancelStuButton.Text = "&Cancel"
        Me.CancelStuButton.UseVisualStyleBackColor = True
        '
        'SaveStuButton
        '
        Me.SaveStuButton.Location = New System.Drawing.Point(5, 3)
        Me.SaveStuButton.Name = "SaveStuButton"
        Me.SaveStuButton.Size = New System.Drawing.Size(75, 32)
        Me.SaveStuButton.TabIndex = 0
        Me.SaveStuButton.Text = "&Save"
        Me.SaveStuButton.UseVisualStyleBackColor = True
        '
        'EditStudentButton
        '
        Me.EditStudentButton.Location = New System.Drawing.Point(8, 56)
        Me.EditStudentButton.Name = "EditStudentButton"
        Me.EditStudentButton.Size = New System.Drawing.Size(75, 45)
        Me.EditStudentButton.TabIndex = 0
        Me.EditStudentButton.Text = "Edit Student Details"
        Me.EditStudentButton.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPagePresentCertificate)
        Me.TabControl1.Controls.Add(Me.TabPagecertificateCRT)
        Me.TabControl1.Controls.Add(Me.TabPageCRTCallDetails)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPageDetails)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(818, 555)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.Event_Student_CompleteDataGridView)
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(810, 529)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPagePresentCertificate
        '
        Me.TabPagePresentCertificate.Controls.Add(Me.CheckBoxAllPresent)
        Me.TabPagePresentCertificate.Controls.Add(Me.ButtonRefresh)
        Me.TabPagePresentCertificate.Controls.Add(Me.ReportButton)
        Me.TabPagePresentCertificate.Controls.Add(Me.ReportTextBox)
        Me.TabPagePresentCertificate.Controls.Add(Me.ReportViewer1)
        Me.TabPagePresentCertificate.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePresentCertificate.Name = "TabPagePresentCertificate"
        Me.TabPagePresentCertificate.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePresentCertificate.Size = New System.Drawing.Size(810, 529)
        Me.TabPagePresentCertificate.TabIndex = 1
        Me.TabPagePresentCertificate.Text = "Present-Certificate"
        Me.TabPagePresentCertificate.UseVisualStyleBackColor = True
        '
        'CheckBoxAllPresent
        '
        Me.CheckBoxAllPresent.AutoSize = True
        Me.CheckBoxAllPresent.Location = New System.Drawing.Point(9, 7)
        Me.CheckBoxAllPresent.Name = "CheckBoxAllPresent"
        Me.CheckBoxAllPresent.Size = New System.Drawing.Size(105, 17)
        Me.CheckBoxAllPresent.TabIndex = 6
        Me.CheckBoxAllPresent.Text = "Show all Present"
        Me.CheckBoxAllPresent.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Image = Global.WindowsApplication1.My.Resources.Resources.Refresh
        Me.ButtonRefresh.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ButtonRefresh.Location = New System.Drawing.Point(703, 0)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(100, 51)
        Me.ButtonRefresh.TabIndex = 5
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ReportButton
        '
        Me.ReportButton.Location = New System.Drawing.Point(273, 5)
        Me.ReportButton.Name = "ReportButton"
        Me.ReportButton.Size = New System.Drawing.Size(216, 23)
        Me.ReportButton.TabIndex = 3
        Me.ReportButton.Text = "Show all for given Date (dd/mm/yyyy)"
        Me.ReportButton.UseVisualStyleBackColor = True
        '
        'ReportTextBox
        '
        Me.ReportTextBox.Location = New System.Drawing.Point(120, 5)
        Me.ReportTextBox.Name = "ReportTextBox"
        Me.ReportTextBox.Size = New System.Drawing.Size(127, 20)
        Me.ReportTextBox.TabIndex = 2
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "Ingenium_2011DataSet_Event_Student_Complete"
        ReportDataSource1.Value = Me.Event_Student_CompleteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event Certificate2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 32)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 499)
        Me.ReportViewer1.TabIndex = 0
        '
        'TabPagecertificateCRT
        '
        Me.TabPagecertificateCRT.Controls.Add(Me.ReportViewer5)
        Me.TabPagecertificateCRT.Location = New System.Drawing.Point(4, 22)
        Me.TabPagecertificateCRT.Name = "TabPagecertificateCRT"
        Me.TabPagecertificateCRT.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagecertificateCRT.Size = New System.Drawing.Size(810, 529)
        Me.TabPagecertificateCRT.TabIndex = 5
        Me.TabPagecertificateCRT.Text = "Certificate-Criterion"
        Me.TabPagecertificateCRT.UseVisualStyleBackColor = True
        '
        'ReportViewer5
        '
        Me.ReportViewer5.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "Ingenium_2011DataSet_Event_Student_Complete"
        ReportDataSource2.Value = Me.Event_Student_CompleteBindingSource
        Me.ReportViewer5.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer5.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event Certificate2.rdlc"
        Me.ReportViewer5.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer5.Name = "ReportViewer5"
        Me.ReportViewer5.Size = New System.Drawing.Size(804, 523)
        Me.ReportViewer5.TabIndex = 1
        '
        'TabPageCRTCallDetails
        '
        Me.TabPageCRTCallDetails.Controls.Add(Me.ReportViewer6)
        Me.TabPageCRTCallDetails.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCRTCallDetails.Name = "TabPageCRTCallDetails"
        Me.TabPageCRTCallDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCRTCallDetails.Size = New System.Drawing.Size(810, 529)
        Me.TabPageCRTCallDetails.TabIndex = 6
        Me.TabPageCRTCallDetails.Text = "Criterion-Call Details"
        Me.TabPageCRTCallDetails.UseVisualStyleBackColor = True
        '
        'ReportViewer6
        '
        Me.ReportViewer6.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "Ingenium_2011DataSet_Event_Student_Complete"
        ReportDataSource3.Value = Me.Event_Student_Complete1BindingSource
        Me.ReportViewer6.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer6.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event Report StuNumbers-new.rdlc"
        Me.ReportViewer6.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer6.Name = "ReportViewer6"
        Me.ReportViewer6.Size = New System.Drawing.Size(804, 523)
        Me.ReportViewer6.TabIndex = 9
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.ReportViewer7)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(810, 529)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "TabPage8"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'ReportViewer7
        '
        Me.ReportViewer7.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "Ingenium_2011DataSet_Event_Student_Complete"
        ReportDataSource4.Value = Me.Event_Student_CompleteBindingSource
        Me.ReportViewer7.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer7.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event Criterion Summary-by School.rdlc"
        Me.ReportViewer7.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer7.Name = "ReportViewer7"
        Me.ReportViewer7.Size = New System.Drawing.Size(804, 523)
        Me.ReportViewer7.TabIndex = 0
        '
        'TabPageDetails
        '
        Me.TabPageDetails.Controls.Add(Me.TabControl2)
        Me.TabPageDetails.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDetails.Name = "TabPageDetails"
        Me.TabPageDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDetails.Size = New System.Drawing.Size(810, 529)
        Me.TabPageDetails.TabIndex = 8
        Me.TabPageDetails.Text = "Details"
        Me.TabPageDetails.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPageCallDetails)
        Me.TabControl2.Controls.Add(Me.TabPageSchoolDetails)
        Me.TabControl2.Controls.Add(Me.TabPagePresentDetails)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(804, 523)
        Me.TabControl2.TabIndex = 0
        '
        'TabPageCallDetails
        '
        Me.TabPageCallDetails.Controls.Add(Me.ReportViewer8)
        Me.TabPageCallDetails.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCallDetails.Name = "TabPageCallDetails"
        Me.TabPageCallDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCallDetails.Size = New System.Drawing.Size(796, 497)
        Me.TabPageCallDetails.TabIndex = 0
        Me.TabPageCallDetails.Text = "Call Details"
        Me.TabPageCallDetails.UseVisualStyleBackColor = True
        '
        'ReportViewer8
        '
        Me.ReportViewer8.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource5.Name = "Ingenium_2011DataSet_Event_Student_Complete"
        ReportDataSource5.Value = Me.Event_Student_CompleteBindingSource
        Me.ReportViewer8.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer8.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event Call Summary-by School.rdlc"
        Me.ReportViewer8.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer8.Name = "ReportViewer8"
        Me.ReportViewer8.Size = New System.Drawing.Size(790, 491)
        Me.ReportViewer8.TabIndex = 1
        '
        'TabPageSchoolDetails
        '
        Me.TabPageSchoolDetails.Controls.Add(Me.ReportViewer9)
        Me.TabPageSchoolDetails.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSchoolDetails.Name = "TabPageSchoolDetails"
        Me.TabPageSchoolDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSchoolDetails.Size = New System.Drawing.Size(796, 497)
        Me.TabPageSchoolDetails.TabIndex = 1
        Me.TabPageSchoolDetails.Text = "School Details"
        Me.TabPageSchoolDetails.UseVisualStyleBackColor = True
        '
        'ReportViewer9
        '
        Me.ReportViewer9.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource6.Name = "Ingenium_2011DataSet_Event_Student_Complete"
        ReportDataSource6.Value = Me.Event_Student_CompleteBindingSource
        Me.ReportViewer9.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer9.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event School-Summary.rdlc"
        Me.ReportViewer9.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer9.Name = "ReportViewer9"
        Me.ReportViewer9.Size = New System.Drawing.Size(790, 491)
        Me.ReportViewer9.TabIndex = 1
        '
        'TabPagePresentDetails
        '
        Me.TabPagePresentDetails.Controls.Add(Me.ReportViewer10)
        Me.TabPagePresentDetails.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePresentDetails.Name = "TabPagePresentDetails"
        Me.TabPagePresentDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePresentDetails.Size = New System.Drawing.Size(796, 497)
        Me.TabPagePresentDetails.TabIndex = 2
        Me.TabPagePresentDetails.Text = "Present Details"
        Me.TabPagePresentDetails.UseVisualStyleBackColor = True
        '
        'ReportViewer10
        '
        Me.ReportViewer10.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource7.Name = "Ingenium_2011DataSet_Event_Student_Complete"
        ReportDataSource7.Value = Me.Event_Student_CompleteBindingSource
        Me.ReportViewer10.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer10.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event Present-Summary.rdlc"
        Me.ReportViewer10.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer10.Name = "ReportViewer10"
        Me.ReportViewer10.Size = New System.Drawing.Size(790, 491)
        Me.ReportViewer10.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TabControl3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(810, 529)
        Me.TabPage3.TabIndex = 9
        Me.TabPage3.Text = "Summary"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPageCallSummary)
        Me.TabControl3.Controls.Add(Me.TabPageSchoolSummary)
        Me.TabControl3.Controls.Add(Me.TabPagePresentSummary)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Location = New System.Drawing.Point(3, 3)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(804, 523)
        Me.TabControl3.TabIndex = 1
        '
        'TabPageCallSummary
        '
        Me.TabPageCallSummary.Controls.Add(Me.ReportViewer2)
        Me.TabPageCallSummary.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCallSummary.Name = "TabPageCallSummary"
        Me.TabPageCallSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCallSummary.Size = New System.Drawing.Size(796, 497)
        Me.TabPageCallSummary.TabIndex = 0
        Me.TabPageCallSummary.Text = "Call Summary"
        Me.TabPageCallSummary.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource8.Name = "Ingenium_2011DataSet_Event_Student_Complete"
        ReportDataSource8.Value = Me.Event_Student_CompleteBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource8)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event S-call.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(790, 491)
        Me.ReportViewer2.TabIndex = 1
        '
        'TabPageSchoolSummary
        '
        Me.TabPageSchoolSummary.Controls.Add(Me.ReportViewer3)
        Me.TabPageSchoolSummary.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSchoolSummary.Name = "TabPageSchoolSummary"
        Me.TabPageSchoolSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSchoolSummary.Size = New System.Drawing.Size(796, 497)
        Me.TabPageSchoolSummary.TabIndex = 1
        Me.TabPageSchoolSummary.Text = "School Summary"
        Me.TabPageSchoolSummary.UseVisualStyleBackColor = True
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource9.Name = "Ingenium_2011DataSet_Event_Student_Complete"
        ReportDataSource9.Value = Me.Event_Student_CompleteBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource9)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event S.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(790, 491)
        Me.ReportViewer3.TabIndex = 1
        '
        'TabPagePresentSummary
        '
        Me.TabPagePresentSummary.Controls.Add(Me.ReportViewer4)
        Me.TabPagePresentSummary.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePresentSummary.Name = "TabPagePresentSummary"
        Me.TabPagePresentSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePresentSummary.Size = New System.Drawing.Size(796, 497)
        Me.TabPagePresentSummary.TabIndex = 2
        Me.TabPagePresentSummary.Text = "Present Summary"
        Me.TabPagePresentSummary.UseVisualStyleBackColor = True
        '
        'ReportViewer4
        '
        Me.ReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource10.Name = "Ingenium_2011DataSet_Event_Student_Complete"
        ReportDataSource10.Value = Me.Event_Student_CompleteBindingSource
        Me.ReportViewer4.LocalReport.DataSources.Add(ReportDataSource10)
        Me.ReportViewer4.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event S-present.rdlc"
        Me.ReportViewer4.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer4.Name = "ReportViewer4"
        Me.ReportViewer4.Size = New System.Drawing.Size(790, 491)
        Me.ReportViewer4.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewerSMS)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(810, 529)
        Me.TabPage2.TabIndex = 10
        Me.TabPage2.Text = "SMS Data"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewerSMS
        '
        Me.ReportViewerSMS.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource11.Name = "Ingenium_2011DataSet_Complete_School_in_Event"
        ReportDataSource11.Value = Me.Complete_School_in_EventBindingSource
        Me.ReportViewerSMS.LocalReport.DataSources.Add(ReportDataSource11)
        Me.ReportViewerSMS.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event Report StuNumbers-SMS.rdlc"
        Me.ReportViewerSMS.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewerSMS.Name = "ReportViewerSMS"
        Me.ReportViewerSMS.Size = New System.Drawing.Size(804, 523)
        Me.ReportViewerSMS.TabIndex = 10
        '
        'Event_SchoolBindingSource
        '
        Me.Event_SchoolBindingSource.DataMember = "Event MasterEvent School"
        Me.Event_SchoolBindingSource.DataSource = Me.Event_MasterBindingSource
        '
        'AllEventsCheckBox
        '
        Me.AllEventsCheckBox.AutoSize = True
        Me.AllEventsCheckBox.Location = New System.Drawing.Point(395, 7)
        Me.AllEventsCheckBox.Name = "AllEventsCheckBox"
        Me.AllEventsCheckBox.Size = New System.Drawing.Size(103, 17)
        Me.AllEventsCheckBox.TabIndex = 9
        Me.AllEventsCheckBox.Text = "Show All Events"
        Me.AllEventsCheckBox.UseVisualStyleBackColor = True
        '
        'ReportCheckBox
        '
        Me.ReportCheckBox.AutoSize = True
        Me.ReportCheckBox.Location = New System.Drawing.Point(641, 7)
        Me.ReportCheckBox.Name = "ReportCheckBox"
        Me.ReportCheckBox.Size = New System.Drawing.Size(88, 17)
        Me.ReportCheckBox.TabIndex = 10
        Me.ReportCheckBox.Text = "Show Report"
        Me.ReportCheckBox.UseVisualStyleBackColor = True
        '
        'Complete_School_in_EventTableAdapter
        '
        Me.Complete_School_in_EventTableAdapter.ClearBeforeFill = True
        '
        'Event_Student_Complete1BindingSource
        '
        Me.Event_Student_Complete1BindingSource.DataMember = "Event Student Complete1"
        Me.Event_Student_Complete1BindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Event_Student_Complete1TableAdapter
        '
        Me.Event_Student_Complete1TableAdapter.ClearBeforeFill = True
        '
        'Events_Students_Telecalling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(818, 602)
        Me.Controls.Add(Me.ReportCheckBox)
        Me.Controls.Add(Me.AllEventsCheckBox)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.EventMasterComboBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Events_Students_Telecalling"
        Me.Text = "Events_Desk_Telecalling"
        CType(Me.Event_Student_CompleteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Complete_School_in_EventBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_MasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.VisitedSchoolsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_Student_CompleteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Event_StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.StreamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.EventSavePanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.StuSavePanel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPagePresentCertificate.ResumeLayout(False)
        Me.TabPagePresentCertificate.PerformLayout()
        Me.TabPagecertificateCRT.ResumeLayout(False)
        Me.TabPageCRTCallDetails.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TabPageDetails.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPageCallDetails.ResumeLayout(False)
        Me.TabPageSchoolDetails.ResumeLayout(False)
        Me.TabPagePresentDetails.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPageCallSummary.ResumeLayout(False)
        Me.TabPageSchoolSummary.ResumeLayout(False)
        Me.TabPagePresentSummary.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Event_SchoolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_Student_Complete1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Visited_SchoolsTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter
    Friend WithEvents VisitedSchoolsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ingenium_2011DataSet As WindowsApplication1.Ingenium_2011DataSet
    Friend WithEvents Event_MasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_MasterTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_MasterTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Event_Student_CompleteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_Student_CompleteTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_Student_CompleteTableAdapter
    Friend WithEvents Event_StudentsTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_StudentsTableAdapter
    Friend WithEvents Event_Student_CompleteDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Event_StudentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EventStuIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EventIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SchoolIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CalledCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Call_DetailsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExpectedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Expected_DetailsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PresentCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Present_DetailsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Admission_TakenCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Follow_up_DetailsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents StuIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SchoolIdTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Student_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Father_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Address_PermanentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mobile_PersonalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mobile_GuardianTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Other_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Father_OccupationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BPLCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents _10th_GradeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ingenium_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Discount_offeredTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EventMasterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SearchSchoolNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents SearchStuNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CancelSearchButton As System.Windows.Forms.Button
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Father_OccupationComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents EditEventsButton As System.Windows.Forms.Button
    Friend WithEvents EventSavePanel As System.Windows.Forms.Panel
    Friend WithEvents CancelEditButton As System.Windows.Forms.Button
    Friend WithEvents SaveEditButton As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents StuSavePanel As System.Windows.Forms.Panel
    Friend WithEvents CancelStuButton As System.Windows.Forms.Button
    Friend WithEvents SaveStuButton As System.Windows.Forms.Button
    Friend WithEvents EditStudentButton As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents StreamBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StreamTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.StreamTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPagePresentCertificate As System.Windows.Forms.TabPage
    Friend WithEvents Event_SchoolBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_SchoolTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_SchoolTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SchoolNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CallStatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TabPagecertificateCRT As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer5 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents StuIdTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SearchStuIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPageCRTCallDetails As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer6 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AllEventsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ReportCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Present_TimerDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReportTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReportButton As System.Windows.Forms.Button
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer7 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Add2InterestedButton As System.Windows.Forms.Button
    Friend WithEvents TwelthButton As System.Windows.Forms.Button
    Friend WithEvents SMSButton As System.Windows.Forms.Button
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.StudentTableAdapter
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents CheckBoxAllPresent As System.Windows.Forms.CheckBox
    Friend WithEvents TabPageDetails As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageCallDetails As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer8 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPageSchoolDetails As System.Windows.Forms.TabPage
    Friend WithEvents TabPagePresentDetails As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer9 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer10 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageCallSummary As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPageSchoolSummary As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPagePresentSummary As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer4 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewerSMS As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Complete_School_in_EventBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Complete_School_in_EventTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Complete_School_in_EventTableAdapter
    Friend WithEvents Event_Student_Complete1BindingSource As BindingSource
    Friend WithEvents Event_Student_Complete1TableAdapter As Ingenium_2011DataSetTableAdapters.Event_Student_Complete1TableAdapter
End Class
