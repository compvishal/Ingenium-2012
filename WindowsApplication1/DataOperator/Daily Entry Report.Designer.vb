﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Daily_Entry_Report
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReportViewerSMS = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Ingenium_2011DataSet = New WindowsApplication1.Ingenium_2011DataSet()
        Me.Data_EntryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Data_EntryTableAdapter = New WindowsApplication1.Ingenium_2011DataSetTableAdapters.Data_EntryTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_EntryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Size = New System.Drawing.Size(631, 369)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(623, 343)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Summary"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewerSMS)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(623, 343)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Daily Summary"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewerSMS
        '
        Me.ReportViewerSMS.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.Data_EntryBindingSource
        Me.ReportViewerSMS.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewerSMS.LocalReport.ReportEmbeddedResource = "WindowsApplication1.marks Entry Daily.rdlc"
        Me.ReportViewerSMS.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewerSMS.Name = "ReportViewerSMS"
        Me.ReportViewerSMS.Size = New System.Drawing.Size(617, 337)
        Me.ReportViewerSMS.TabIndex = 12
        '
        'Ingenium_2011DataSet
        '
        Me.Ingenium_2011DataSet.DataSetName = "Ingenium_2011DataSet"
        Me.Ingenium_2011DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Data_EntryBindingSource
        '
        Me.Data_EntryBindingSource.DataMember = "Data Entry"
        Me.Data_EntryBindingSource.DataSource = Me.Ingenium_2011DataSet
        '
        'Data_EntryTableAdapter
        '
        Me.Data_EntryTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Data_EntryBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.marks Entry Summary.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(617, 337)
        Me.ReportViewer1.TabIndex = 13
        '
        'Daily_Entry_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 369)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Daily_Entry_Report"
        Me.Text = "Daily_Entry_Report"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Ingenium_2011DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_EntryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ReportViewerSMS As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Data_EntryBindingSource As BindingSource
    Friend WithEvents Ingenium_2011DataSet As Ingenium_2011DataSet
    Friend WithEvents Data_EntryTableAdapter As Ingenium_2011DataSetTableAdapters.Data_EntryTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
