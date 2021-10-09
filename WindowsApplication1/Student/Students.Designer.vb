<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Students
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.Student_School_COmpleteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ingenium_2011DataSet = New WindowsApplication1.Ingenium_2011DataSet
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.SchoolListBox = New System.Windows.Forms.ListBox
        Me.Visited_SchoolsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_School_COmpleteTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Student_School_COmpleteTableAdapter
        Me.Visited_SchoolsTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
        CType(Me.Student_School_COmpleteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.Visited_SchoolsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Student_School_COmpleteBindingSource
        '
        Me.Student_School_COmpleteBindingSource.DataMember = "Student School COmplete"
        Me.Student_School_COmpleteBindingSource.DataSource = Me.Ingenium_2011DataSet
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
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(859, 547)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(851, 521)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "School vise"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Ingenium_2011DataSet_Student_School_COmplete"
        ReportDataSource1.Value = Me.Student_School_COmpleteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.School-Student-Summary.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(845, 515)
        Me.ReportViewer1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(851, 521)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Stu-Complete Data"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "Ingenium_2011DataSet_Student_School_COmplete"
        ReportDataSource2.Value = Me.Student_School_COmpleteBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Student-complete Details.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(845, 515)
        Me.ReportViewer2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.ReportViewer3)
        Me.TabPage3.Controls.Add(Me.SchoolListBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(851, 521)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Student Exam"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Dock = System.Windows.Forms.DockStyle.Right
        ReportDataSource3.Name = "Ingenium_2011DataSet_Student_School_COmplete"
        ReportDataSource3.Value = Me.Student_School_COmpleteBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Student Test.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(250, 3)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(598, 515)
        Me.ReportViewer3.TabIndex = 1
        '
        'SchoolListBox
        '
        Me.SchoolListBox.DataSource = Me.Visited_SchoolsBindingSource
        Me.SchoolListBox.DisplayMember = "School Name"
        Me.SchoolListBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.SchoolListBox.FormattingEnabled = True
        Me.SchoolListBox.Location = New System.Drawing.Point(3, 3)
        Me.SchoolListBox.Name = "SchoolListBox"
        Me.SchoolListBox.Size = New System.Drawing.Size(241, 511)
        Me.SchoolListBox.TabIndex = 0
        Me.SchoolListBox.ValueMember = "SchoolId"
        '
        'Visited_SchoolsBindingSource
        '
        Me.Visited_SchoolsBindingSource.DataMember = "Visited Schools"
        Me.Visited_SchoolsBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Student_School_COmpleteTableAdapter
        '
        Me.Student_School_COmpleteTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Employee_Day_SheetTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeCompanyVisitTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeSchoolVisitTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.Event_MasterTableAdapter = Nothing
        Me.TableAdapterManager.Event_SchoolTableAdapter = Nothing
        Me.TableAdapterManager.Event_StudentsTableAdapter = Nothing
        Me.TableAdapterManager.School_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.School_VisitTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Visited_SchoolsTableAdapter = Me.Visited_SchoolsTableAdapter
        '
        'Students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 547)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Students"
        Me.Text = "Students"
        CType(Me.Student_School_COmpleteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Visited_SchoolsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Student_School_COmpleteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ingenium_2011DataSet As WindowsApplication1.Ingenium_2011DataSet
    Friend WithEvents Student_School_COmpleteTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Student_School_COmpleteTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Visited_SchoolsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Visited_SchoolsTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
    Friend WithEvents SchoolListBox As System.Windows.Forms.ListBox
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
End Class
