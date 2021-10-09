<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Event_Student_Report
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Event_Student_Complete1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ingenium_2011DataSet = New WindowsApplication1.Ingenium_2011DataSet()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.AllEventsCheckBox = New System.Windows.Forms.CheckBox()
        Me.EventMasterComboBox = New System.Windows.Forms.ComboBox()
        Me.EventMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ReportViewer6 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Event_Student_Complete1TableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_Student_Complete1TableAdapter()
        Me.Event_MasterTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_MasterTableAdapter()
        Me.ReportViewer5 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Event_Student_CompleteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Event_Student_CompleteTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_Student_CompleteTableAdapter()
        CType(Me.Event_Student_Complete1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.EventMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Event_Student_CompleteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Event_Student_Complete1BindingSource
        '
        Me.Event_Student_Complete1BindingSource.DataMember = "Event Student Complete1"
        Me.Event_Student_Complete1BindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Ingenium_2011DataSet
        '
        Me.Ingenium_2011DataSet.DataSetName = "Ingenium_2011DataSet"
        Me.Ingenium_2011DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(684, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripLabel1.Text = "Select Event"
        '
        'AllEventsCheckBox
        '
        Me.AllEventsCheckBox.AutoSize = True
        Me.AllEventsCheckBox.Location = New System.Drawing.Point(404, 3)
        Me.AllEventsCheckBox.Name = "AllEventsCheckBox"
        Me.AllEventsCheckBox.Size = New System.Drawing.Size(103, 17)
        Me.AllEventsCheckBox.TabIndex = 11
        Me.AllEventsCheckBox.Text = "Show All Events"
        Me.AllEventsCheckBox.UseVisualStyleBackColor = True
        '
        'EventMasterComboBox
        '
        Me.EventMasterComboBox.DataSource = Me.EventMasterBindingSource
        Me.EventMasterComboBox.DisplayMember = "Event Name"
        Me.EventMasterComboBox.FormattingEnabled = True
        Me.EventMasterComboBox.Location = New System.Drawing.Point(99, 4)
        Me.EventMasterComboBox.Name = "EventMasterComboBox"
        Me.EventMasterComboBox.Size = New System.Drawing.Size(278, 21)
        Me.EventMasterComboBox.TabIndex = 10
        Me.EventMasterComboBox.ValueMember = "EventId"
        '
        'EventMasterBindingSource
        '
        Me.EventMasterBindingSource.DataMember = "Event Master"
        Me.EventMasterBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(684, 450)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReportViewer6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(676, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Numbers"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ReportViewer6
        '
        Me.ReportViewer6.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Ingenium_2011DataSet_Event_Student_Complete"
        ReportDataSource1.Value = Me.Event_Student_Complete1BindingSource
        Me.ReportViewer6.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer6.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event Report StuNumbers-new.rdlc"
        Me.ReportViewer6.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer6.Name = "ReportViewer6"
        Me.ReportViewer6.Size = New System.Drawing.Size(670, 418)
        Me.ReportViewer6.TabIndex = 10
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(676, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Certificate"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Event_Student_Complete1TableAdapter
        '
        Me.Event_Student_Complete1TableAdapter.ClearBeforeFill = True
        '
        'Event_MasterTableAdapter
        '
        Me.Event_MasterTableAdapter.ClearBeforeFill = True
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
        Me.ReportViewer5.Size = New System.Drawing.Size(670, 418)
        Me.ReportViewer5.TabIndex = 2
        '
        'Event_Student_CompleteBindingSource
        '
        Me.Event_Student_CompleteBindingSource.DataMember = "Event Student Complete"
        Me.Event_Student_CompleteBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Event_Student_CompleteTableAdapter
        '
        Me.Event_Student_CompleteTableAdapter.ClearBeforeFill = True
        '
        'Event_Student_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 475)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.AllEventsCheckBox)
        Me.Controls.Add(Me.EventMasterComboBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Event_Student_Report"
        Me.Text = "Event_Student_Report"
        CType(Me.Event_Student_Complete1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.EventMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Event_Student_CompleteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents AllEventsCheckBox As CheckBox
    Friend WithEvents EventMasterComboBox As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ReportViewer6 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Event_Student_Complete1BindingSource As BindingSource
    Friend WithEvents Ingenium_2011DataSet As Ingenium_2011DataSet
    Friend WithEvents Event_Student_Complete1TableAdapter As Ingenium_2011DataSetTableAdapters.Event_Student_Complete1TableAdapter
    Friend WithEvents EventMasterBindingSource As BindingSource
    Friend WithEvents Event_MasterTableAdapter As Ingenium_2011DataSetTableAdapters.Event_MasterTableAdapter
    Friend WithEvents ReportViewer5 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Event_Student_CompleteBindingSource As BindingSource
    Friend WithEvents Event_Student_CompleteTableAdapter As Ingenium_2011DataSetTableAdapters.Event_Student_CompleteTableAdapter
End Class
