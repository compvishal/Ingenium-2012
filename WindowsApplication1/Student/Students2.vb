Imports System.Data
Imports System.Data.OleDb
Imports System.Collections
Imports System.Configuration
Public Class Students2

    Private Sub Students2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadOtherAdapter()
        Me.StreamTableAdapter.Fill(Me.Ingenium_2011DataSet.Stream)
        LoadAdapter()
        'Me.ReportViewer2.RefreshReport()
    End Sub
    Private Sub LoadOtherAdapter()
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Ingenium_2011DataSet.Employee)
    End Sub
    Private Sub LoadAdapter()
        Me.Student_School_COmpleteTableAdapter.Fill(Me.Ingenium_2011DataSet.Student_School_COmplete)
        CancelSearch(True)
    End Sub
    Private Sub CancelSearch(Optional ByVal Cancel As Boolean = True)
        Dim FilterText As String = "", StreamF As Boolean = False
        If Cancel Then
            SearchSchoolNameTextBox.Text = ""
            SearchStuNameTextBox.Text = ""
            SearchStuIdTextBox.Text = ""
            'CancelSearchButton.Enabled = False
            SearchCityTextBox.Text = ""
            MobileTextBox.Text = ""
            SearchStreamComboBox.Text = "All"
            ToolStripStatusLabel1.Text = "Showing All Students"
        Else
            FilterText = "[School Name] Like( '%" & SearchSchoolNameTextBox.Text & "%')"
            If SearchStuNameTextBox.Text <> "" Then
                FilterText &= " AND [Student Name] Like( '%" & SearchStuNameTextBox.Text & "%')"
            End If
            If SearchStuIdTextBox.Text <> "" Then
                FilterText &= " AND [StuId] =" & SearchStuIdTextBox.Text
            End If
            If SearchCityTextBox.Text <> "" Then
                FilterText &= " AND [City] Like( '%" & SearchCityTextBox.Text & "%')"
            End If
            If SearchStreamComboBox.Text <> "All" Then
                FilterText &= " AND [Expr1] Like( '%" & SearchStreamComboBox.Text & "%')"
                StreamF = True
            End If
            If MobileTextBox.Text <> "" Then
                FilterText &= " AND ([Mobile Personal] Like( '%" & MobileTextBox.Text & "%') OR [Mobile Guardian] Like( '%" & MobileTextBox.Text & "%') OR [Other No] Like( '%" & MobileTextBox.Text & "%'))"
            End If
            Student_School_COmpleteBindingSource.Filter = FilterText
            ToolStripStatusLabel1.Text = "Showing " & Student_School_COmpleteBindingSource.Count & " Students"
            If LoginForm1.Role = "Administrator" Then
                If StreamF Then
                    'FilterText = FilterText.Replace("StreamName", "Stream.Stream")
                End If
                'Fillreport(FilterText)
            End If
        End If
    End Sub
    Private Sub CancelSearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelSearchButton.Click
        CancelSearch(True)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CancelSearch(False)
    End Sub

    Private Sub Add2InterestedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add2InterestedButton.Click
        Dim Url As New Ingenium_2011DataSetTableAdapters.QueriesTableAdapter
        If Url.GetStudentinInterested(StuIdTextBox.Text) <> 0 Then
            MsgBox("Student already added!", MsgBoxStyle.Critical, "Add Student as Interested")
            Exit Sub
        End If
        ' now add student
        Try
            Url.InsertInterestedStudentbyId(StuIdTextBox.Text, Today)
            ToolStripStatusLabel2.Text = "Student Added"
            ToolStripStatusLabel2.BackColor = Color.GreenYellow
            LoadAdapter()
            MsgBox("Student Added", MsgBoxStyle.OkOnly, "Add Student as Interested")
        Catch ex As Exception
            ToolStripStatusLabel2.Text = "Error! Student Not Added"
            ToolStripStatusLabel2.BackColor = Color.Red
        End Try

    End Sub

    Private Sub SearchStuNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStuNameTextBox.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub SearchSchoolNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSchoolNameTextBox.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub SearchCityTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchCityTextBox.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub SearchStuIdTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStuIdTextBox.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub StuIdTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StuIdTextBox.TextChanged
        Me.StudentTableAdapter.FillByStudentId(Me.Ingenium_2011DataSet.Student, StuIdTextBox.Text)

    End Sub

    Private Sub Fillreport(ByVal FilterText As String)
        Try
            If FilterText <> "" Then
                Dim DSet As New DataSet
                Dim COn As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("WindowsApplication1.My.MySettings.Ingenium_2011ConnectionString")
                Dim ConString = COn.ConnectionString
                Dim Cn As New OleDbConnection(ConString)
                'Cn.Open()
                Dim ADDapter As New OleDbDataAdapter()
                'Fill Type
                ADDapter.SelectCommand = New OleDbCommand("SELECT  Student.StuId, Student.SchoolId, Student.Stream, Student.[Student Name], Student.[Father Name], Student.[Address Permanent], Student.[Address Correspondance], Student.[Mobile Personal], Student.[Mobile Guardian], Student.[Other No], Student.EmailId, Student.DOB, Student.[Father Occupation], Student.BPL, Student.Category, Student.[10th Grade], Student.[Ingenium%], Student.[Discount offered], [Visited Schools].[School Name], [Visited Schools].City, [Visited Schools].Address, Stream.Stream AS StreamName FROM ((Student INNER JOIN [Visited Schools] ON Student.SchoolId = [Visited Schools].SchoolId) INNER JOIN  Stream ON Student.Stream = Stream.StreamId)  Where " & FilterText, Cn)
                ADDapter.Fill(DSet)
                Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
                ReportDataSource1.Name = "Ingenium_2011DataSet_Student_School_COmplete"
                ReportDataSource1.Value = DSet.Tables(0)
                With ReportViewer1
                    .LocalReport.DataSources.RemoveAt(0)
                    .LocalReport.DataSources.Add(ReportDataSource1)
                    .LocalReport.ReportEmbeddedResource = "WindowsApplication1.Student-Calling.rdlc"
                    .RefreshReport()
                End With
                With ReportViewer2
                    .LocalReport.DataSources.RemoveAt(0)
                    .LocalReport.DataSources.Add(ReportDataSource1)
                    .LocalReport.ReportEmbeddedResource = "WindowsApplication1.School Summary.rdlc"
                    .RefreshReport()
                End With
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Sub

    Private Sub AllStreamButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllStreamButton.Click
        SearchStreamComboBox.Text = "All"
        CancelSearch(False)
    End Sub

    Private Sub SearchStreamComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStreamComboBox.SelectedIndexChanged
        CancelSearch(False)
    End Sub

    Private Sub MobileTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MobileTextBox.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub Visited_Schools_SchoolIdTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Visited_Schools_SchoolIdTextBox.TextChanged
        'change selected school
        Try
            Me.Visited_SchoolsTableAdapter.FillBySchoolId(Me.Ingenium_2011DataSet.Visited_Schools, Visited_Schools_SchoolIdTextBox.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TwelthButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TwelthButton.Click

    End Sub
End Class