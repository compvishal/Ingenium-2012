<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Complete_Data
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ReportViewerSMS = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Ingenium_2011DataSet = New WindowsApplication1.Ingenium_2011DataSet
        Me.Complete_School_in_EventBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Complete_School_in_EventTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Complete_School_in_EventTableAdapter
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Event_Student_CompleteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Event_Student_CompleteTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_Student_CompleteTableAdapter
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Complete_School_in_EventBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_Student_CompleteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(829, 453)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReportViewerSMS)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(821, 427)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Complete SMS Data"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(821, 427)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewerSMS
        '
        Me.ReportViewerSMS.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Ingenium_2011DataSet_Complete_School_in_Event"
        ReportDataSource1.Value = Me.Complete_School_in_EventBindingSource
        Me.ReportViewerSMS.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerSMS.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Event Report StuNumbers-SMS.rdlc"
        Me.ReportViewerSMS.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewerSMS.Name = "ReportViewerSMS"
        Me.ReportViewerSMS.Size = New System.Drawing.Size(815, 421)
        Me.ReportViewerSMS.TabIndex = 11
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
        'Complete_School_in_EventTableAdapter
        '
        Me.Complete_School_in_EventTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "Ingenium_2011DataSet_Event_Student_Complete"
        ReportDataSource2.Value = Me.Event_Student_CompleteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report-complete Event for SMS.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(815, 421)
        Me.ReportViewer1.TabIndex = 12
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
        'Complete_Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 453)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Complete_Data"
        Me.Text = "Complete_Data"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Complete_School_in_EventBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event_Student_CompleteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewerSMS As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Complete_School_in_EventBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ingenium_2011DataSet As WindowsApplication1.Ingenium_2011DataSet
    Friend WithEvents Complete_School_in_EventTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Complete_School_in_EventTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Event_Student_CompleteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_Student_CompleteTableAdapter As WindowsApplication1.Ingenium_2011DataSetTableAdapters.Event_Student_CompleteTableAdapter
End Class
