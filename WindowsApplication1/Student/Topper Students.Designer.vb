<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Topper_Students
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
        Dim Label8 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.Tested_School_ToppersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ingenium_2011DataSet = New WindowsApplication1.Ingenium_2011DataSet
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Visited_SchoolsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Visited_SchoolsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SchoolIdTextBox = New System.Windows.Forms.TextBox
        Me.TextBoxAddress = New System.Windows.Forms.TextBox
        Me.AllEmplyButton = New System.Windows.Forms.Button
        Me.SearchEmployeeComboBox = New System.Windows.Forms.ComboBox
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchCityTextBox = New System.Windows.Forms.TextBox
        Me.SearchSchoolNameTextBox = New System.Windows.Forms.TextBox
        Me.CancelSearchButton = New System.Windows.Forms.Button
        Me.Tested_School_ToppersTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Tested_School_ToppersTableAdapter
        Me.Visited_SchoolsTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
        Me.EmployeeTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.EmployeeTableAdapter
        Me.Student_Toppers_CompleteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_Toppers_CompleteTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Student_Toppers_CompleteTableAdapter
        Me.ButtonAllSchoolsReport = New System.Windows.Forms.Button
        Label8 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        CType(Me.Tested_School_ToppersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Visited_SchoolsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Visited_SchoolsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_Toppers_CompleteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tested_School_ToppersBindingSource
        '
        Me.Tested_School_ToppersBindingSource.DataMember = "Tested School Toppers"
        Me.Tested_School_ToppersBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Ingenium_2011DataSet
        '
        Me.Ingenium_2011DataSet.DataSetName = "Ingenium_2011DataSet"
        Me.Ingenium_2011DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(83, 33)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(48, 13)
        Label8.TabIndex = 34
        Label8.Text = "Address:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(376, 36)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(102, 13)
        Label6.TabIndex = 32
        Label6.Text = "Attached Employee:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(433, 9)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(27, 13)
        Label5.TabIndex = 29
        Label5.Text = "City:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(88, 11)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(74, 13)
        Label3.TabIndex = 36
        Label3.Text = "School Name:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(756, 509)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TabControl2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(748, 483)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Summary"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(742, 477)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ReportViewer1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(734, 451)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "By Employee"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Ingenium_2011DataSet_Tested_School_Toppers"
        ReportDataSource1.Value = Me.Tested_School_ToppersBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Toppers by Employee.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(728, 445)
        Me.ReportViewer1.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ReportViewer2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(645, 451)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "By City"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "Ingenium_2011DataSet_Tested_School_Toppers"
        ReportDataSource2.Value = Me.Tested_School_ToppersBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Toppers by City.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(639, 445)
        Me.ReportViewer2.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.ReportViewer3)
        Me.TabPage2.Controls.Add(Me.Visited_SchoolsDataGridView)
        Me.TabPage2.Controls.Add(Me.SchoolIdTextBox)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(748, 483)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Report"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "Ingenium_2011DataSet_Student_Toppers_Complete"
        ReportDataSource3.Value = Me.Student_Toppers_CompleteBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Toppers School St list.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(275, 60)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(470, 420)
        Me.ReportViewer3.TabIndex = 1
        '
        'Visited_SchoolsDataGridView
        '
        Me.Visited_SchoolsDataGridView.AllowUserToAddRows = False
        Me.Visited_SchoolsDataGridView.AllowUserToDeleteRows = False
        Me.Visited_SchoolsDataGridView.AutoGenerateColumns = False
        Me.Visited_SchoolsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Visited_SchoolsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Visited_SchoolsDataGridView.DataSource = Me.Visited_SchoolsBindingSource
        Me.Visited_SchoolsDataGridView.Dock = System.Windows.Forms.DockStyle.Left
        Me.Visited_SchoolsDataGridView.Location = New System.Drawing.Point(3, 60)
        Me.Visited_SchoolsDataGridView.Name = "Visited_SchoolsDataGridView"
        Me.Visited_SchoolsDataGridView.RowHeadersWidth = 21
        Me.Visited_SchoolsDataGridView.Size = New System.Drawing.Size(272, 420)
        Me.Visited_SchoolsDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "School Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "School Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn3.HeaderText = "City"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 85
        '
        'Visited_SchoolsBindingSource
        '
        Me.Visited_SchoolsBindingSource.DataMember = "Visited Schools"
        Me.Visited_SchoolsBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ButtonAllSchoolsReport)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.TextBoxAddress)
        Me.Panel1.Controls.Add(Label8)
        Me.Panel1.Controls.Add(Me.AllEmplyButton)
        Me.Panel1.Controls.Add(Label6)
        Me.Panel1.Controls.Add(Me.SearchEmployeeComboBox)
        Me.Panel1.Controls.Add(Me.SearchCityTextBox)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Me.SearchSchoolNameTextBox)
        Me.Panel1.Controls.Add(Me.CancelSearchButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(742, 57)
        Me.Panel1.TabIndex = 0
        '
        'SchoolIdTextBox
        '
        Me.SchoolIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Visited_SchoolsBindingSource, "SchoolId", True))
        Me.SchoolIdTextBox.Location = New System.Drawing.Point(114, 154)
        Me.SchoolIdTextBox.Name = "SchoolIdTextBox"
        Me.SchoolIdTextBox.Size = New System.Drawing.Size(20, 20)
        Me.SchoolIdTextBox.TabIndex = 37
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Location = New System.Drawing.Point(137, 31)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxAddress.TabIndex = 35
        '
        'AllEmplyButton
        '
        Me.AllEmplyButton.Location = New System.Drawing.Point(610, 30)
        Me.AllEmplyButton.Name = "AllEmplyButton"
        Me.AllEmplyButton.Size = New System.Drawing.Size(72, 24)
        Me.AllEmplyButton.TabIndex = 33
        Me.AllEmplyButton.Text = "All Emply"
        Me.AllEmplyButton.UseVisualStyleBackColor = True
        '
        'SearchEmployeeComboBox
        '
        Me.SearchEmployeeComboBox.DataSource = Me.EmployeeBindingSource
        Me.SearchEmployeeComboBox.DisplayMember = "Emply Name"
        Me.SearchEmployeeComboBox.FormattingEnabled = True
        Me.SearchEmployeeComboBox.Location = New System.Drawing.Point(483, 33)
        Me.SearchEmployeeComboBox.Name = "SearchEmployeeComboBox"
        Me.SearchEmployeeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SearchEmployeeComboBox.TabIndex = 31
        Me.SearchEmployeeComboBox.ValueMember = "EmplyId"
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'SearchCityTextBox
        '
        Me.SearchCityTextBox.Location = New System.Drawing.Point(465, 7)
        Me.SearchCityTextBox.Name = "SearchCityTextBox"
        Me.SearchCityTextBox.Size = New System.Drawing.Size(99, 20)
        Me.SearchCityTextBox.TabIndex = 30
        '
        'SearchSchoolNameTextBox
        '
        Me.SearchSchoolNameTextBox.Location = New System.Drawing.Point(175, 4)
        Me.SearchSchoolNameTextBox.Name = "SearchSchoolNameTextBox"
        Me.SearchSchoolNameTextBox.Size = New System.Drawing.Size(250, 20)
        Me.SearchSchoolNameTextBox.TabIndex = 26
        '
        'CancelSearchButton
        '
        Me.CancelSearchButton.Location = New System.Drawing.Point(5, 3)
        Me.CancelSearchButton.Name = "CancelSearchButton"
        Me.CancelSearchButton.Size = New System.Drawing.Size(77, 53)
        Me.CancelSearchButton.TabIndex = 25
        Me.CancelSearchButton.Text = "Cancel Search"
        Me.CancelSearchButton.UseVisualStyleBackColor = True
        '
        'Tested_School_ToppersTableAdapter
        '
        Me.Tested_School_ToppersTableAdapter.ClearBeforeFill = True
        '
        'Visited_SchoolsTableAdapter
        '
        Me.Visited_SchoolsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.Event_MasterTableAdapter = Nothing
        Me.TableAdapterManager.Event_SchoolTableAdapter = Nothing
        Me.TableAdapterManager.Event_StudentsTableAdapter = Nothing
        Me.TableAdapterManager.Interested_StudentTableAdapter = Nothing
        Me.TableAdapterManager.School_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.School_VisitTableAdapter = Nothing
        Me.TableAdapterManager.SMS_TextTableAdapter = Nothing
        Me.TableAdapterManager.StreamTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Visited_SchoolsTableAdapter = Me.Visited_SchoolsTableAdapter
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'Student_Toppers_CompleteBindingSource
        '
        Me.Student_Toppers_CompleteBindingSource.DataMember = "Student Toppers Complete"
        Me.Student_Toppers_CompleteBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Student_Toppers_CompleteTableAdapter
        '
        Me.Student_Toppers_CompleteTableAdapter.ClearBeforeFill = True
        '
        'ButtonAllSchoolsReport
        '
        Me.ButtonAllSchoolsReport.Location = New System.Drawing.Point(570, 4)
        Me.ButtonAllSchoolsReport.Name = "ButtonAllSchoolsReport"
        Me.ButtonAllSchoolsReport.Size = New System.Drawing.Size(167, 24)
        Me.ButtonAllSchoolsReport.TabIndex = 37
        Me.ButtonAllSchoolsReport.Text = "Show All School Report"
        Me.ButtonAllSchoolsReport.UseVisualStyleBackColor = True
        '
        'Topper_Students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 509)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Topper_Students"
        Me.Text = "Topper_Students"
        CType(Me.Tested_School_ToppersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Visited_SchoolsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Visited_SchoolsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_Toppers_CompleteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Tested_School_ToppersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ingenium_2011DataSet As WindowsApplication1.Ingenium_2011DataSet
    Friend WithEvents Tested_School_ToppersTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Tested_School_ToppersTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Visited_SchoolsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Visited_SchoolsTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Visited_SchoolsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBoxAddress As System.Windows.Forms.TextBox
    Friend WithEvents AllEmplyButton As System.Windows.Forms.Button
    Friend WithEvents SearchEmployeeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SearchCityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SearchSchoolNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CancelSearchButton As System.Windows.Forms.Button
    Friend WithEvents EmployeeTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SchoolIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Student_Toppers_CompleteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Student_Toppers_CompleteTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Student_Toppers_CompleteTableAdapter
    Friend WithEvents ButtonAllSchoolsReport As System.Windows.Forms.Button
End Class
