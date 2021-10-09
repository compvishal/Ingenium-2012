Imports System.Data
Imports System.Data.OleDb
Imports System.Collections
Imports System.Configuration
Public Class Student_Data_Report


    Private Sub Student_Data_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Data_Collected_School' table. You can move, or remove it, as needed.
        Me.Data_Collected_SchoolTableAdapter.Fill(Me.Ingenium_2011DataSet.Data_Collected_School)
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Student' table. You can move, or remove it, as needed.
        
        FillComboboxes()
        ResetFilter()
        'Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub FillComboboxes()
        Try
            'get all basic things
            Dim DSet As New DataSet
            Dim COn As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.Ingenium_2011ConnectionString")
            Dim ConString = COn.ConnectionString
            Dim Cn As New OleDbConnection(ConString)
            'Cn.Open()
            Dim ADDapter As New OleDbDataAdapter()
            'Fill Type
            ADDapter.SelectCommand = New OleDbCommand("SELECT DISTINCT Type FROM [Visited Schools]", Cn)
            ADDapter.Fill(DSet)
            TypeComboBox.DataSource = DSet.Tables(0)
            TypeComboBox.DisplayMember = "Type"
            TypeComboBox.ValueMember = "Type"

            'city Type
            DSet.Tables.Add()
            ADDapter.SelectCommand = New OleDbCommand("SELECT DISTINCT City FROM [Visited Schools]", Cn)
            ADDapter.Fill(DSet.Tables(1))
            CityComboBox.DataSource = DSet.Tables(1)
            CityComboBox.DisplayMember = "City"
            CityComboBox.ValueMember = "City"

            'Employee Type
            DSet.Tables.Add()
            ADDapter.SelectCommand = New OleDbCommand("SELECT DISTINCT [Emply Name], EmplyId FROM  Employee", Cn)
            ADDapter.Fill(DSet.Tables(2))
            AtEmplyComboBox.DataSource = DSet.Tables(2)
            AtEmplyComboBox.DisplayMember = "Emply Name"
            AtEmplyComboBox.ValueMember = "EmplyId"

            'Stream Type
            DSet.Tables.Add()
            ADDapter.SelectCommand = New OleDbCommand("SELECT DISTINCT Stream FROM Student", Cn)
            ADDapter.Fill(DSet.Tables(3))
            StreamComboBox.DataSource = DSet.Tables(3)
            StreamComboBox.DisplayMember = "Stream"
            StreamComboBox.ValueMember = "Stream"


            'Category Type
            DSet.Tables.Add()
            ADDapter.SelectCommand = New OleDbCommand("SELECT DISTINCT Category FROM Student", Cn)
            ADDapter.Fill(DSet.Tables(4))
            CategoryComboBox.DataSource = DSet.Tables(4)
            CategoryComboBox.DisplayMember = "Category"
            CategoryComboBox.ValueMember = "Category"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ResetFilter()
        DataCollectedSchoolBindingSource.Filter = ""
        ToolStripStatusLabel1.Text = "Filter Removed"
    End Sub
    Private Sub ResetFilter()
        TypeCheckBox.Checked = True
        CityCheckBox.Checked = True
        AtEmplyCheckBox.Checked = True
        StreamCheckBox.Checked = True
        CategoryCheckBox.Checked = True
        SchoolNameTextBox.Text = ""
        SchoolNameCheckBox.Checked = True
        'reset report
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        ReportDataSource1.Name = "Ingenium_2011DataSet_Data_Collected_School"
        ReportDataSource1.Value = Me.Data_Collected_SchoolBindingSource
        Me.ReportViewer2.LocalReport.DataSources.RemoveAt(0)    'remove existing
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Data Collected School.rdlc"
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub CategoryComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryComboBox.SelectedIndexChanged
        CategoryCheckBox.Checked = False
    End Sub

    Private Sub StreamComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StreamComboBox.SelectedIndexChanged
        StreamCheckBox.Checked = False
    End Sub

    Private Sub AtEmplyComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtEmplyComboBox.SelectedIndexChanged
        AtEmplyCheckBox.Checked = False
    End Sub

    Private Sub CityComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CityComboBox.SelectedIndexChanged
        CityCheckBox.Checked = False
    End Sub

    Private Sub TypeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeComboBox.SelectedIndexChanged
        TypeCheckBox.Checked = False
    End Sub

    Private Sub SchoolNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchoolNameTextBox.TextChanged
        If SchoolNameTextBox.Text <> "" Then
            SchoolNameCheckBox.Checked = False
        End If
    End Sub

    Private Sub ApplyFilterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyFilterButton.Click
        ApplyFilter()
        RefreshReport()
    End Sub
    Private Sub ApplyFilter()
        Dim FilterString As String = ""
        If Not (TypeCheckBox.Checked) Then
            FilterString &= " AND Type='" & TypeComboBox.Text & "'"
        End If
        If Not (CityCheckBox.Checked) Then
            FilterString &= " AND City='" & CityComboBox.Text & "'"
        End If
        If Not (AtEmplyCheckBox.Checked) Then
            FilterString &= " AND [Attached Employee]=" & AtEmplyComboBox.SelectedValue
        End If
        If Not (SchoolNameCheckBox.Checked) Then
            FilterString &= " AND [School Name] LIKE '%" & SchoolNameTextBox.Text & "%'"
        End If
        'now apply filter
        FilterString = IIf(FilterString <> "", Mid(FilterString, 5, Len(FilterString)), "") 'remove AND
        DataCollectedSchoolBindingSource.Filter = FilterString
        ToolStripStatusLabel1.Text = "Filter Mode"
        ToolStripStatusLabel2.Text = "No. of School: " & DataCollectedSchoolBindingSource.Count '& " No. of Students:" & StudentBindingSource.Count

        If FilterString <> "" Then

            Dim DSet As New DataSet
            Dim COn As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.Ingenium_2011ConnectionString")
            Dim ConString = COn.ConnectionString
            Dim Cn As New OleDbConnection(ConString)
            'Cn.Open()
            Dim ADDapter As New OleDbDataAdapter()
            'Fill Type
            ADDapter.SelectCommand = New OleDbCommand("SELECT DISTINCT [Visited Schools].SchoolId, [Visited Schools].[School Name], [Visited Schools].City, [Visited Schools].Address, [Visited Schools].Tel,[Visited Schools].[PCM Students], [Visited Schools].[PCB Students], [Visited Schools].[Commerce  Students], [Visited Schools].[Arts Students],[Visited Schools].[PGDM Students], [Visited Schools].Type, [Visited Schools].[Test Conducted], [Visited Schools].[Attached Employee] FROM ([Visited Schools] INNER JOIN Student ON [Visited Schools].SchoolId = Student.SchoolId) Where " & FilterString, Cn)
            ADDapter.Fill(DSet)
            Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
            ReportDataSource1.Name = "Ingenium_2011DataSet_Data_Collected_School"
            ReportDataSource1.Value = DSet.Tables(0)
            Me.ReportViewer2.LocalReport.DataSources.RemoveAt(0)    'remove existing
            Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
            Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Data Collected School.rdlc"
            Me.ReportViewer2.RefreshReport()
        End If

    End Sub

    Private Sub RefreshReport()

    End Sub
End Class