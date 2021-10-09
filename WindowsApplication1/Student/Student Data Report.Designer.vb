<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Data_Report
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
        Dim TypeLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim Attached_EmployeeLabel As System.Windows.Forms.Label
        Dim StreamLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.Data_Collected_SchoolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ingenium_2011DataSet = New WindowsApplication1.Ingenium_2011DataSet
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SchoolNameCheckBox = New System.Windows.Forms.CheckBox
        Me.SchoolNameTextBox = New System.Windows.Forms.TextBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.DataCollectedSchoolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApplyFilterButton = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.CategoryCheckBox = New System.Windows.Forms.CheckBox
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox
        Me.StreamCheckBox = New System.Windows.Forms.CheckBox
        Me.StreamComboBox = New System.Windows.Forms.ComboBox
        Me.AtEmplyCheckBox = New System.Windows.Forms.CheckBox
        Me.AtEmplyComboBox = New System.Windows.Forms.ComboBox
        Me.CityCheckBox = New System.Windows.Forms.CheckBox
        Me.CityComboBox = New System.Windows.Forms.ComboBox
        Me.TypeCheckBox = New System.Windows.Forms.CheckBox
        Me.TypeComboBox = New System.Windows.Forms.ComboBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Data_Collected_SchoolTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Data_Collected_SchoolTableAdapter
        Me.TableAdapterManager = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
        TypeLabel = New System.Windows.Forms.Label
        CityLabel = New System.Windows.Forms.Label
        Attached_EmployeeLabel = New System.Windows.Forms.Label
        StreamLabel = New System.Windows.Forms.Label
        CategoryLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        CType(Me.Data_Collected_SchoolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataCollectedSchoolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(68, 14)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(34, 13)
        TypeLabel.TabIndex = 0
        TypeLabel.Text = "Type:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(78, 45)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 2
        CityLabel.Text = "City:"
        '
        'Attached_EmployeeLabel
        '
        Attached_EmployeeLabel.AutoSize = True
        Attached_EmployeeLabel.Location = New System.Drawing.Point(3, 70)
        Attached_EmployeeLabel.Name = "Attached_EmployeeLabel"
        Attached_EmployeeLabel.Size = New System.Drawing.Size(102, 13)
        Attached_EmployeeLabel.TabIndex = 4
        Attached_EmployeeLabel.Text = "Attached Employee:"
        '
        'StreamLabel
        '
        StreamLabel.AutoSize = True
        StreamLabel.Location = New System.Drawing.Point(59, 93)
        StreamLabel.Name = "StreamLabel"
        StreamLabel.Size = New System.Drawing.Size(43, 13)
        StreamLabel.TabIndex = 6
        StreamLabel.Text = "Stream:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(50, 120)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(52, 13)
        CategoryLabel.TabIndex = 8
        CategoryLabel.Text = "Category:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(27, 147)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(74, 13)
        Label1.TabIndex = 23
        Label1.Text = "School Name:"
        '
        'Data_Collected_SchoolBindingSource
        '
        Me.Data_Collected_SchoolBindingSource.DataMember = "Data Collected School"
        Me.Data_Collected_SchoolBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Ingenium_2011DataSet
        '
        Me.Ingenium_2011DataSet.DataSetName = "Ingenium_2011DataSet"
        Me.Ingenium_2011DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 528)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(884, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(75, 17)
        Me.ToolStripStatusLabel1.Text = "Data Module"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(88, 17)
        Me.ToolStripStatusLabel2.Text = "Student Record"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SchoolNameCheckBox)
        Me.Panel1.Controls.Add(Me.SchoolNameTextBox)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.ApplyFilterButton)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.CategoryCheckBox)
        Me.Panel1.Controls.Add(Me.CategoryComboBox)
        Me.Panel1.Controls.Add(Me.StreamCheckBox)
        Me.Panel1.Controls.Add(Me.StreamComboBox)
        Me.Panel1.Controls.Add(Me.AtEmplyCheckBox)
        Me.Panel1.Controls.Add(Me.AtEmplyComboBox)
        Me.Panel1.Controls.Add(Me.CityCheckBox)
        Me.Panel1.Controls.Add(Me.CityComboBox)
        Me.Panel1.Controls.Add(Me.TypeCheckBox)
        Me.Panel1.Controls.Add(Me.TypeComboBox)
        Me.Panel1.Controls.Add(CategoryLabel)
        Me.Panel1.Controls.Add(StreamLabel)
        Me.Panel1.Controls.Add(Attached_EmployeeLabel)
        Me.Panel1.Controls.Add(CityLabel)
        Me.Panel1.Controls.Add(TypeLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(276, 528)
        Me.Panel1.TabIndex = 1
        '
        'SchoolNameCheckBox
        '
        Me.SchoolNameCheckBox.AutoSize = True
        Me.SchoolNameCheckBox.Location = New System.Drawing.Point(237, 146)
        Me.SchoolNameCheckBox.Name = "SchoolNameCheckBox"
        Me.SchoolNameCheckBox.Size = New System.Drawing.Size(37, 17)
        Me.SchoolNameCheckBox.TabIndex = 25
        Me.SchoolNameCheckBox.Text = "All"
        Me.SchoolNameCheckBox.UseVisualStyleBackColor = True
        '
        'SchoolNameTextBox
        '
        Me.SchoolNameTextBox.Location = New System.Drawing.Point(109, 146)
        Me.SchoolNameTextBox.Name = "SchoolNameTextBox"
        Me.SchoolNameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.SchoolNameTextBox.TabIndex = 24
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.DataCollectedSchoolBindingSource
        Me.ListBox1.DisplayMember = "School Name"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 225)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(276, 303)
        Me.ListBox1.TabIndex = 22
        Me.ListBox1.ValueMember = "SchoolId"
        '
        'DataCollectedSchoolBindingSource
        '
        Me.DataCollectedSchoolBindingSource.DataMember = "Data Collected School"
        Me.DataCollectedSchoolBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'ApplyFilterButton
        '
        Me.ApplyFilterButton.Location = New System.Drawing.Point(153, 172)
        Me.ApplyFilterButton.Name = "ApplyFilterButton"
        Me.ApplyFilterButton.Size = New System.Drawing.Size(75, 41)
        Me.ApplyFilterButton.TabIndex = 21
        Me.ApplyFilterButton.Text = "&Apply Filter"
        Me.ApplyFilterButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(62, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 41)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "&Reset Filter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CategoryCheckBox
        '
        Me.CategoryCheckBox.AutoSize = True
        Me.CategoryCheckBox.Location = New System.Drawing.Point(237, 120)
        Me.CategoryCheckBox.Name = "CategoryCheckBox"
        Me.CategoryCheckBox.Size = New System.Drawing.Size(37, 17)
        Me.CategoryCheckBox.TabIndex = 19
        Me.CategoryCheckBox.Text = "All"
        Me.CategoryCheckBox.UseVisualStyleBackColor = True
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(109, 118)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CategoryComboBox.TabIndex = 18
        '
        'StreamCheckBox
        '
        Me.StreamCheckBox.AutoSize = True
        Me.StreamCheckBox.Location = New System.Drawing.Point(237, 93)
        Me.StreamCheckBox.Name = "StreamCheckBox"
        Me.StreamCheckBox.Size = New System.Drawing.Size(37, 17)
        Me.StreamCheckBox.TabIndex = 17
        Me.StreamCheckBox.Text = "All"
        Me.StreamCheckBox.UseVisualStyleBackColor = True
        '
        'StreamComboBox
        '
        Me.StreamComboBox.FormattingEnabled = True
        Me.StreamComboBox.Location = New System.Drawing.Point(109, 91)
        Me.StreamComboBox.Name = "StreamComboBox"
        Me.StreamComboBox.Size = New System.Drawing.Size(121, 21)
        Me.StreamComboBox.TabIndex = 16
        '
        'AtEmplyCheckBox
        '
        Me.AtEmplyCheckBox.AutoSize = True
        Me.AtEmplyCheckBox.Location = New System.Drawing.Point(237, 66)
        Me.AtEmplyCheckBox.Name = "AtEmplyCheckBox"
        Me.AtEmplyCheckBox.Size = New System.Drawing.Size(37, 17)
        Me.AtEmplyCheckBox.TabIndex = 15
        Me.AtEmplyCheckBox.Text = "All"
        Me.AtEmplyCheckBox.UseVisualStyleBackColor = True
        '
        'AtEmplyComboBox
        '
        Me.AtEmplyComboBox.FormattingEnabled = True
        Me.AtEmplyComboBox.Location = New System.Drawing.Point(109, 64)
        Me.AtEmplyComboBox.Name = "AtEmplyComboBox"
        Me.AtEmplyComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AtEmplyComboBox.TabIndex = 14
        '
        'CityCheckBox
        '
        Me.CityCheckBox.AutoSize = True
        Me.CityCheckBox.Location = New System.Drawing.Point(237, 39)
        Me.CityCheckBox.Name = "CityCheckBox"
        Me.CityCheckBox.Size = New System.Drawing.Size(37, 17)
        Me.CityCheckBox.TabIndex = 13
        Me.CityCheckBox.Text = "All"
        Me.CityCheckBox.UseVisualStyleBackColor = True
        '
        'CityComboBox
        '
        Me.CityComboBox.FormattingEnabled = True
        Me.CityComboBox.Location = New System.Drawing.Point(109, 37)
        Me.CityComboBox.Name = "CityComboBox"
        Me.CityComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CityComboBox.TabIndex = 12
        '
        'TypeCheckBox
        '
        Me.TypeCheckBox.AutoSize = True
        Me.TypeCheckBox.Location = New System.Drawing.Point(237, 13)
        Me.TypeCheckBox.Name = "TypeCheckBox"
        Me.TypeCheckBox.Size = New System.Drawing.Size(37, 17)
        Me.TypeCheckBox.TabIndex = 11
        Me.TypeCheckBox.Text = "All"
        Me.TypeCheckBox.UseVisualStyleBackColor = True
        '
        'TypeComboBox
        '
        Me.TypeComboBox.FormattingEnabled = True
        Me.TypeComboBox.Location = New System.Drawing.Point(109, 10)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TypeComboBox.TabIndex = 10
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TabControl1.Location = New System.Drawing.Point(282, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(602, 528)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReportViewer2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(594, 502)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Summary"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Ingenium_2011DataSet_Data_Collected_School"
        ReportDataSource1.Value = Me.Data_Collected_SchoolBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Data Collected School.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(588, 496)
        Me.ReportViewer2.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(508, 502)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Details"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Data_Collected_SchoolTableAdapter
        '
        Me.Data_Collected_SchoolTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Companies_VisitedTableAdapter = Nothing
        Me.TableAdapterManager.Company_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.Company_VisitTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.EmployeeCompanyVisitTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeSchoolVisitTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.School_ContactsTableAdapter = Nothing
        Me.TableAdapterManager.School_VisitTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Visited_SchoolsTableAdapter = Nothing
        '
        'Student_Data_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 550)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Student_Data_Report"
        Me.Text = "Student_Data_Report"
        CType(Me.Data_Collected_SchoolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataCollectedSchoolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Ingenium_2011DataSet As WindowsApplication1.Ingenium_2011DataSet
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents AtEmplyCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AtEmplyComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CityCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CityComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TypeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CategoryCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents StreamCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents StreamComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ApplyFilterButton As System.Windows.Forms.Button
    Friend WithEvents SchoolNameCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SchoolNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataCollectedSchoolBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Data_Collected_SchoolTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Data_Collected_SchoolTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Ingenium_2011DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Data_Collected_SchoolBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
End Class
