<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Event_Covered
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Event_Student_CompleteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ingenium_2011DataSet = New WindowsApplication1.Ingenium_2011DataSet()
        Me.Not_Covered_SchoolsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Event_Student_Complete2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPagenotcovered = New System.Windows.Forms.TabPage()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPageNotCoveredCity = New System.Windows.Forms.TabPage()
        Me.ReportViewer4 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPagebyCounselling = New System.Windows.Forms.TabPage()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.ReportViewer5 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.EventMasterComboBox = New System.Windows.Forms.ComboBox()
        Me.EventMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Event_Student_CompleteTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_Student_CompleteTableAdapter()
        Me.Not_Covered_SchoolsTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Not_Covered_SchoolsTableAdapter()
        Me.Event_MasterTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_MasterTableAdapter()
        Me.Event_Student_Complete2TableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_Student_Complete2TableAdapter()
        Me.ReportViewer6 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.Event_Student_CompleteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Not_Covered_SchoolsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_Student_Complete2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPagenotcovered.SuspendLayout()
        Me.TabPageNotCoveredCity.SuspendLayout()
        Me.TabPagebyCounselling.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.EventMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'Not_Covered_SchoolsBindingSource
        '
        Me.Not_Covered_SchoolsBindingSource.DataMember = "Not Covered Schools"
        Me.Not_Covered_SchoolsBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Event_Student_Complete2BindingSource
        '
        Me.Event_Student_Complete2BindingSource.DataMember = "Event Student Complete2"
        Me.Event_Student_Complete2BindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPagebyCounselling)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(667, 425)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TabControl2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(659, 399)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "By Employee"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPagenotcovered)
        Me.TabControl2.Controls.Add(Me.TabPageNotCoveredCity)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(653, 393)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ReportViewer1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(645, 367)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Covered"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "Ingenium_2011DataSet_Event_Student_Complete"
        ReportDataSource3.Value = Me.Event_Student_CompleteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event Employee-Summary.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(639, 361)
        Me.ReportViewer1.TabIndex = 0
        '
        'TabPagenotcovered
        '
        Me.TabPagenotcovered.Controls.Add(Me.ReportViewer2)
        Me.TabPagenotcovered.Location = New System.Drawing.Point(4, 22)
        Me.TabPagenotcovered.Name = "TabPagenotcovered"
        Me.TabPagenotcovered.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagenotcovered.Size = New System.Drawing.Size(645, 367)
        Me.TabPagenotcovered.TabIndex = 1
        Me.TabPagenotcovered.Text = "Not Covered"
        Me.TabPagenotcovered.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "Ingenium_2011DataSet_Not_Covered_Schools"
        ReportDataSource4.Value = Me.Not_Covered_SchoolsBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Not Covered by Employee.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(639, 361)
        Me.ReportViewer2.TabIndex = 1
        '
        'TabPageNotCoveredCity
        '
        Me.TabPageNotCoveredCity.Controls.Add(Me.ReportViewer4)
        Me.TabPageNotCoveredCity.Location = New System.Drawing.Point(4, 22)
        Me.TabPageNotCoveredCity.Name = "TabPageNotCoveredCity"
        Me.TabPageNotCoveredCity.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageNotCoveredCity.Size = New System.Drawing.Size(645, 367)
        Me.TabPageNotCoveredCity.TabIndex = 2
        Me.TabPageNotCoveredCity.Text = "Not Covered by City"
        Me.TabPageNotCoveredCity.UseVisualStyleBackColor = True
        '
        'ReportViewer4
        '
        Me.ReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource5.Name = "Ingenium_2011DataSet_Not_Covered_Schools"
        ReportDataSource5.Value = Me.Not_Covered_SchoolsBindingSource
        Me.ReportViewer4.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer4.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Not Covered by City.rdlc"
        Me.ReportViewer4.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer4.Name = "ReportViewer4"
        Me.ReportViewer4.Size = New System.Drawing.Size(639, 361)
        Me.ReportViewer4.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(659, 399)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "By School"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPagebyCounselling
        '
        Me.TabPagebyCounselling.Controls.Add(Me.ReportViewer3)
        Me.TabPagebyCounselling.Location = New System.Drawing.Point(4, 22)
        Me.TabPagebyCounselling.Name = "TabPagebyCounselling"
        Me.TabPagebyCounselling.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagebyCounselling.Size = New System.Drawing.Size(659, 399)
        Me.TabPagebyCounselling.TabIndex = 2
        Me.TabPagebyCounselling.Text = "By Counselling"
        Me.TabPagebyCounselling.UseVisualStyleBackColor = True
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource6.Name = "Ingenium_2011DataSet_Event_Student_Complete"
        ReportDataSource6.Value = Me.Event_Student_CompleteBindingSource
        Me.ReportViewer3.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer3.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event School details.rdlc"
        Me.ReportViewer3.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.Size = New System.Drawing.Size(653, 393)
        Me.ReportViewer3.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.TabControl3)
        Me.TabPage4.Controls.Add(Me.EventMasterComboBox)
        Me.TabPage4.Controls.Add(Me.ToolStrip1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(659, 399)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Calling-Certificate Data"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage6)
        Me.TabControl3.Controls.Add(Me.TabPage5)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Location = New System.Drawing.Point(3, 28)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(653, 368)
        Me.TabControl3.TabIndex = 5
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.ReportViewer5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(645, 342)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Sheet"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'ReportViewer5
        '
        Me.ReportViewer5.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.Event_Student_Complete2BindingSource
        Me.ReportViewer5.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer5.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event covered Sheet.rdlc"
        Me.ReportViewer5.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer5.Name = "ReportViewer5"
        Me.ReportViewer5.Size = New System.Drawing.Size(639, 336)
        Me.ReportViewer5.TabIndex = 4
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.ReportViewer6)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(645, 342)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "Printout"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'EventMasterComboBox
        '
        Me.EventMasterComboBox.DataSource = Me.EventMasterBindingSource
        Me.EventMasterComboBox.DisplayMember = "Event Name"
        Me.EventMasterComboBox.FormattingEnabled = True
        Me.EventMasterComboBox.Location = New System.Drawing.Point(99, 6)
        Me.EventMasterComboBox.Name = "EventMasterComboBox"
        Me.EventMasterComboBox.Size = New System.Drawing.Size(278, 21)
        Me.EventMasterComboBox.TabIndex = 3
        Me.EventMasterComboBox.ValueMember = "EventId"
        '
        'EventMasterBindingSource
        '
        Me.EventMasterBindingSource.DataMember = "Event Master"
        Me.EventMasterBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(653, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripLabel1.Text = "Select Event"
        '
        'Event_Student_CompleteTableAdapter
        '
        Me.Event_Student_CompleteTableAdapter.ClearBeforeFill = True
        '
        'Not_Covered_SchoolsTableAdapter
        '
        Me.Not_Covered_SchoolsTableAdapter.ClearBeforeFill = True
        '
        'Event_MasterTableAdapter
        '
        Me.Event_MasterTableAdapter.ClearBeforeFill = True
        '
        'Event_Student_Complete2TableAdapter
        '
        Me.Event_Student_Complete2TableAdapter.ClearBeforeFill = True
        '
        'ReportViewer6
        '
        Me.ReportViewer6.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Event_Student_Complete2BindingSource
        Me.ReportViewer6.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer6.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event covered Sheet -Printout.rdlc"
        Me.ReportViewer6.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer6.Name = "ReportViewer6"
        Me.ReportViewer6.Size = New System.Drawing.Size(639, 336)
        Me.ReportViewer6.TabIndex = 5
        '
        'Event_Covered
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 425)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Event_Covered"
        Me.Text = "Event_Covered"
        CType(Me.Event_Student_CompleteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Not_Covered_SchoolsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_Student_Complete2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPagenotcovered.ResumeLayout(False)
        Me.TabPageNotCoveredCity.ResumeLayout(False)
        Me.TabPagebyCounselling.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        CType(Me.EventMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPagenotcovered As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Event_Student_CompleteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ingenium_2011DataSet As WindowsApplication1.Ingenium_2011DataSet
    Friend WithEvents Event_Student_CompleteTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_Student_CompleteTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Not_Covered_SchoolsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Not_Covered_SchoolsTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Not_Covered_SchoolsTableAdapter
    Friend WithEvents TabPagebyCounselling As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPageNotCoveredCity As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer4 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents EventMasterComboBox As ComboBox
    Friend WithEvents EventMasterBindingSource As BindingSource
    Friend WithEvents Event_MasterTableAdapter As Ingenium_2011DataSetTableAdapters.Event_MasterTableAdapter
    Friend WithEvents ReportViewer5 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Event_Student_Complete2BindingSource As BindingSource
    Friend WithEvents Event_Student_Complete2TableAdapter As Ingenium_2011DataSetTableAdapters.Event_Student_Complete2TableAdapter
    Friend WithEvents ReportViewer6 As Microsoft.Reporting.WinForms.ReportViewer
End Class
