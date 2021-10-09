<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Event_Report
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
        Dim EventIdLabel As System.Windows.Forms.Label
        Dim SchoolIdLabel As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.Event_Student_CompleteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ingenium_2011DataSet = New WindowsApplication1.Ingenium_2011DataSet
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Event_SchoolDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.VisitedSchoolsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Event_SchoolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Event_MasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolIdTextBox = New System.Windows.Forms.TextBox
        Me.EventIdTextBox = New System.Windows.Forms.TextBox
        Me.Event_MasterDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Event_MasterTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_MasterTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
        Me.Event_SchoolTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_SchoolTableAdapter
        Me.Visited_SchoolsTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter
        Me.Event_Student_CompleteTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_Student_CompleteTableAdapter
        Me.ShowAllCheckBox = New System.Windows.Forms.CheckBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.ReportViewer4 = New Microsoft.Reporting.WinForms.ReportViewer
        EventIdLabel = New System.Windows.Forms.Label
        SchoolIdLabel = New System.Windows.Forms.Label
        CType(Me.Event_Student_CompleteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.Event_SchoolDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitedSchoolsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_SchoolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_MasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_MasterDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'EventIdLabel
        '
        EventIdLabel.AutoSize = True
        EventIdLabel.Location = New System.Drawing.Point(39, 216)
        EventIdLabel.Name = "EventIdLabel"
        EventIdLabel.Size = New System.Drawing.Size(50, 13)
        EventIdLabel.TabIndex = 3
        EventIdLabel.Text = "Event Id:"
        '
        'SchoolIdLabel
        '
        SchoolIdLabel.AutoSize = True
        SchoolIdLabel.Location = New System.Drawing.Point(35, 252)
        SchoolIdLabel.Name = "SchoolIdLabel"
        SchoolIdLabel.Size = New System.Drawing.Size(55, 13)
        SchoolIdLabel.TabIndex = 5
        SchoolIdLabel.Text = "School Id:"
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TabControl1.Location = New System.Drawing.Point(274, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(655, 470)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(647, 444)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Calling Data"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Ingenium_2011DataSet_Event_Student_Complete"
        ReportDataSource1.Value = Me.Event_Student_CompleteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event Report StuNumbers.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(641, 438)
        Me.ReportViewer1.TabIndex = 8
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(647, 444)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Certificate Report"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "Ingenium_2011DataSet_Event_Student_Complete"
        ReportDataSource2.Value = Me.Event_Student_CompleteBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event Certificates.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(641, 438)
        Me.ReportViewer2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ReportViewer3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(647, 444)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "School Summary"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "Ingenium_2011DataSet_Event_Student_Complete"
        ReportDataSource3.Value = Me.Event_Student_CompleteBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event School-Summary.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(641, 438)
        Me.ReportViewer3.TabIndex = 0
        '
        'Event_SchoolDataGridView
        '
        Me.Event_SchoolDataGridView.AutoGenerateColumns = False
        Me.Event_SchoolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Event_SchoolDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7})
        Me.Event_SchoolDataGridView.DataSource = Me.Event_SchoolBindingSource
        Me.Event_SchoolDataGridView.Location = New System.Drawing.Point(12, 152)
        Me.Event_SchoolDataGridView.Name = "Event_SchoolDataGridView"
        Me.Event_SchoolDataGridView.RowHeadersWidth = 21
        Me.Event_SchoolDataGridView.Size = New System.Drawing.Size(256, 314)
        Me.Event_SchoolDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SchoolId"
        Me.DataGridViewTextBoxColumn7.DataSource = Me.VisitedSchoolsBindingSource
        Me.DataGridViewTextBoxColumn7.DisplayMember = "School Name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "SchoolId"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.ValueMember = "SchoolId"
        Me.DataGridViewTextBoxColumn7.Width = 200
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
        'Event_MasterBindingSource
        '
        Me.Event_MasterBindingSource.DataMember = "Event Master"
        Me.Event_MasterBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'SchoolIdTextBox
        '
        Me.SchoolIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_SchoolBindingSource, "SchoolId", True))
        Me.SchoolIdTextBox.Location = New System.Drawing.Point(96, 249)
        Me.SchoolIdTextBox.Name = "SchoolIdTextBox"
        Me.SchoolIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SchoolIdTextBox.TabIndex = 6
        '
        'EventIdTextBox
        '
        Me.EventIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Event_MasterBindingSource, "EventId", True))
        Me.EventIdTextBox.Location = New System.Drawing.Point(95, 213)
        Me.EventIdTextBox.Name = "EventIdTextBox"
        Me.EventIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EventIdTextBox.TabIndex = 4
        '
        'Event_MasterDataGridView
        '
        Me.Event_MasterDataGridView.AutoGenerateColumns = False
        Me.Event_MasterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Event_MasterDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.Event_MasterDataGridView.DataSource = Me.Event_MasterBindingSource
        Me.Event_MasterDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.Event_MasterDataGridView.Name = "Event_MasterDataGridView"
        Me.Event_MasterDataGridView.RowHeadersWidth = 21
        Me.Event_MasterDataGridView.Size = New System.Drawing.Size(256, 101)
        Me.Event_MasterDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Event Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Event Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'Event_MasterTableAdapter
        '
        Me.Event_MasterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
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
        Me.TableAdapterManager.Event_StudentsTableAdapter = Nothing
        Me.TableAdapterManager.School_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.School_VisitTableAdapter = Nothing
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
        'Event_Student_CompleteTableAdapter
        '
        Me.Event_Student_CompleteTableAdapter.ClearBeforeFill = True
        '
        'ShowAllCheckBox
        '
        Me.ShowAllCheckBox.AutoSize = True
        Me.ShowAllCheckBox.Location = New System.Drawing.Point(26, 120)
        Me.ShowAllCheckBox.Name = "ShowAllCheckBox"
        Me.ShowAllCheckBox.Size = New System.Drawing.Size(67, 17)
        Me.ShowAllCheckBox.TabIndex = 7
        Me.ShowAllCheckBox.Text = "Show All"
        Me.ShowAllCheckBox.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ReportViewer4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(647, 444)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Not Called Data"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ReportViewer4
        '
        Me.ReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "Ingenium_2011DataSet_Event_Student_Complete"
        ReportDataSource4.Value = Me.Event_Student_CompleteBindingSource
        Me.ReportViewer4.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer4.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event Report StuNumbers.rdlc"
        Me.ReportViewer4.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer4.Name = "ReportViewer4"
        Me.ReportViewer4.Size = New System.Drawing.Size(641, 438)
        Me.ReportViewer4.TabIndex = 9
        '
        'Event_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 470)
        Me.Controls.Add(Me.ShowAllCheckBox)
        Me.Controls.Add(Me.Event_SchoolDataGridView)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(SchoolIdLabel)
        Me.Controls.Add(Me.SchoolIdTextBox)
        Me.Controls.Add(Me.Event_MasterDataGridView)
        Me.Controls.Add(EventIdLabel)
        Me.Controls.Add(Me.EventIdTextBox)
        Me.Name = "Event_Report"
        Me.Text = "Event_Report"
        CType(Me.Event_Student_CompleteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Event_SchoolDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitedSchoolsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_SchoolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_MasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_MasterDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Ingenium_2011DataSet As WindowsApplication1.Ingenium_2011DataSet
    Friend WithEvents Event_MasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_MasterTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_MasterTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Event_MasterDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Event_SchoolTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_SchoolTableAdapter
    Friend WithEvents Event_SchoolBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_SchoolDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Visited_SchoolsTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter
    Friend WithEvents VisitedSchoolsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Event_Student_CompleteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_Student_CompleteTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_Student_CompleteTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchoolIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EventIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ShowAllCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer4 As Microsoft.Reporting.WinForms.ReportViewer
End Class
