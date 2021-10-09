<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class School_Visit
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
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolComboBox = New System.Windows.Forms.ComboBox
        Me.EmployeeSchoolVisitTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.EmployeeSchoolVisitTableAdapter
        Me.EmployeeTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.EmployeeTableAdapter
        Me.AllSchoolsCheckBox = New System.Windows.Forms.CheckBox
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Ingenium_2011DataSet = New WindowsApplication1.Ingenium_2011DataSet
        Me.School_Visit_CompleteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.School_Visit_CompleteTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.School_Visit_CompleteTableAdapter
        Me.VisitedSchoolsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Visited_SchoolsTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.ReportViewer4 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.School_Visit_CompleteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitedSchoolsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(710, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 427)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(710, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(710, 402)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(702, 376)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Report-by School"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ReportViewer2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(702, 376)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Report-by Date"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ReportViewer3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(702, 376)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Report-by Activity"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.ReportViewer4)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(702, 376)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Report-by Employee"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'SchoolComboBox
        '
        Me.SchoolComboBox.DataSource = Me.VisitedSchoolsBindingSource
        Me.SchoolComboBox.DisplayMember = "School Name"
        Me.SchoolComboBox.FormattingEnabled = True
        Me.SchoolComboBox.Location = New System.Drawing.Point(25, 4)
        Me.SchoolComboBox.Name = "SchoolComboBox"
        Me.SchoolComboBox.Size = New System.Drawing.Size(305, 21)
        Me.SchoolComboBox.TabIndex = 3
        Me.SchoolComboBox.ValueMember = "SchoolId"
        '
        'EmployeeSchoolVisitTableAdapter
        '
        Me.EmployeeSchoolVisitTableAdapter.ClearBeforeFill = True
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'AllSchoolsCheckBox
        '
        Me.AllSchoolsCheckBox.AutoSize = True
        Me.AllSchoolsCheckBox.Location = New System.Drawing.Point(375, 4)
        Me.AllSchoolsCheckBox.Name = "AllSchoolsCheckBox"
        Me.AllSchoolsCheckBox.Size = New System.Drawing.Size(78, 17)
        Me.AllSchoolsCheckBox.TabIndex = 4
        Me.AllSchoolsCheckBox.Text = "All Schools"
        Me.AllSchoolsCheckBox.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Ingenium_2011DataSet_School_Visit_Complete"
        ReportDataSource1.Value = Me.School_Visit_CompleteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.School Visit-by School.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(696, 370)
        Me.ReportViewer1.TabIndex = 0
        '
        'Ingenium_2011DataSet
        '
        Me.Ingenium_2011DataSet.DataSetName = "Ingenium_2011DataSet"
        Me.Ingenium_2011DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'School_Visit_CompleteBindingSource
        '
        Me.School_Visit_CompleteBindingSource.DataMember = "School Visit Complete"
        Me.School_Visit_CompleteBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'School_Visit_CompleteTableAdapter
        '
        Me.School_Visit_CompleteTableAdapter.ClearBeforeFill = True
        '
        'VisitedSchoolsBindingSource
        '
        Me.VisitedSchoolsBindingSource.DataMember = "Visited Schools"
        Me.VisitedSchoolsBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Visited_SchoolsTableAdapter
        '
        Me.Visited_SchoolsTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "Ingenium_2011DataSet_School_Visit_Complete"
        ReportDataSource2.Value = Me.School_Visit_CompleteBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "WindowsApplication1.School Visit-by Date.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(696, 370)
        Me.ReportViewer2.TabIndex = 0
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "Ingenium_2011DataSet_School_Visit_Complete"
        ReportDataSource3.Value = Me.School_Visit_CompleteBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "WindowsApplication1.School Visit-by Purpose.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(696, 370)
        Me.ReportViewer3.TabIndex = 0
        '
        'ReportViewer4
        '
        Me.ReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "Ingenium_2011DataSet_School_Visit_Complete"
        ReportDataSource4.Value = Me.School_Visit_CompleteBindingSource
        Me.ReportViewer4.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer4.LocalReport.ReportEmbeddedResource = "WindowsApplication1.School Visit-by Employee.rdlc"
        Me.ReportViewer4.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer4.Name = "ReportViewer4"
        Me.ReportViewer4.Size = New System.Drawing.Size(696, 370)
        Me.ReportViewer4.TabIndex = 0
        '
        'School_Visit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 449)
        Me.Controls.Add(Me.AllSchoolsCheckBox)
        Me.Controls.Add(Me.SchoolComboBox)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "School_Visit"
        Me.Text = "School_Visit"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.School_Visit_CompleteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitedSchoolsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SchoolComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EmployeeSchoolVisitTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.EmployeeSchoolVisitTableAdapter
    Friend WithEvents EmployeeTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents AllSchoolsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents School_Visit_CompleteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ingenium_2011DataSet As WindowsApplication1.Ingenium_2011DataSet
    Friend WithEvents School_Visit_CompleteTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.School_Visit_CompleteTableAdapter
    Friend WithEvents VisitedSchoolsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Visited_SchoolsTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Visited_SchoolsTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer4 As Microsoft.Reporting.WinForms.ReportViewer
End Class
