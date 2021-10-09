Public Class Topper_Students

    Private Sub Topper_Students_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Student_Toppers_Complete' table. You can move, or remove it, as needed.

        Me.Tested_School_ToppersTableAdapter.Fill(Me.Ingenium_2011DataSet.Tested_School_Toppers)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
        LoadAdapter()
    End Sub
    Private Sub LoadAdapter()
        Me.EmployeeTableAdapter.Fill(Me.Ingenium_2011DataSet.Employee)
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Visited_Schools' table. You can move, or remove it, as needed.
        Me.Visited_SchoolsTableAdapter.Fill(Me.Ingenium_2011DataSet.Visited_Schools)
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Tested_School_Toppers' table. You can move, or remove it, as needed.
        Me.Tested_School_ToppersTableAdapter.Fill(Me.Ingenium_2011DataSet.Tested_School_Toppers)
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Tested_School_Toppers' table. You can move, or remove it, as needed.
        CancelSearch(True)
    End Sub
    Private Sub ShowReportAdapter()
        Try
            Me.Student_Toppers_CompleteTableAdapter.FillBySchoolId(Me.Ingenium_2011DataSet.Student_Toppers_Complete, SchoolIdTextBox.Text)
            Me.ReportViewer3.RefreshReport()
        Catch ex As Exception

        End Try


    End Sub
    Private Sub CancelSearch(Optional ByVal Cancel As Boolean = True)
        If Cancel Then
            SearchSchoolNameTextBox.Text = ""
            'testedComboBox.Text = "All"
            SearchCityTextBox.Text = ""
            Visited_SchoolsBindingSource.Filter = ""
            TextBoxAddress.Text = ""
            SearchEmployeeComboBox.Text = "All"
            CancelSearchButton.Enabled = False
            'ToolStripStatusLabel1.Text = "Showing All Schools"
        Else
            Dim FilterText As String
            FilterText = "[School Name] Like( '%" & SearchSchoolNameTextBox.Text & "%')"
            
            If SearchCityTextBox.Text <> "" Then
                FilterText &= " AND [City] Like( '%" & SearchCityTextBox.Text & "%')"
            End If
            If TextBoxAddress.Text <> "" Then
                FilterText &= " AND [Address] Like( '%" & TextBoxAddress.Text & "%')"
            End If
            If SearchEmployeeComboBox.Text <> "All" And SearchEmployeeComboBox.Text <> "" Then
                FilterText &= " AND [Attached Employee]=" & SearchEmployeeComboBox.SelectedValue
            End If
            Visited_SchoolsBindingSource.Filter = FilterText
            CancelSearchButton.Enabled = True
            'ToolStripStatusLabel1.Text = "Filter On " & Visited_SchoolsBindingSource.Count & " Schools Selected"

        End If
    End Sub

    Private Sub SearchSchoolNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSchoolNameTextBox.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub SearchCityTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchCityTextBox.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub TextBoxAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxAddress.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub SearchEmployeeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchEmployeeComboBox.SelectedIndexChanged
        CancelSearch(False)
    End Sub

    Private Sub CancelSearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelSearchButton.Click
        CancelSearch(True)
    End Sub

    Private Sub SchoolIdTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchoolIdTextBox.TextChanged
        ShowReportAdapter()
    End Sub

    Private Sub AllEmplyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllEmplyButton.Click
        SearchEmployeeComboBox.Text = "All"
        CancelSearch(False)
    End Sub

    Private Sub ButtonAllSchoolsReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAllSchoolsReport.Click
        Try
            Me.Student_Toppers_CompleteTableAdapter.Fill(Me.Ingenium_2011DataSet.Student_Toppers_Complete)
            Me.ReportViewer3.RefreshReport()
        Catch ex As Exception

        End Try
    End Sub
End Class
