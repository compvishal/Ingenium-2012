Public Class Company

    Private Sub Company2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Ingenium_2011DataSet.Employee)
        LoadCompanyAdapter()
        Companies_VisitedDataGridView.ReadOnly = True
        ShowButtonCompany(False)
        Company_VisitDataGridView.ReadOnly = True
        ShowCVButton(False)
    End Sub
    Private Sub LoadCompanyAdapter()
        Dim Ipos As Integer = Companies_VisitedBindingSource.Position
        Dim Ipos2 As Integer = Company_VisitBindingSource.Position
        Me.Company_ContactsTableAdapter.Fill(Me.Ingenium_2011DataSet.Company_Contacts)
        Me.Companies_VisitedTableAdapter.Fill(Me.Ingenium_2011DataSet.Companies_Visited)
        Companies_VisitedBindingSource.Position = Ipos
        Me.EmployeeCompanyVisitTableAdapter.Fill(Me.Ingenium_2011DataSet.EmployeeCompanyVisit)
        Me.Company_VisitTableAdapter.Fill(Me.Ingenium_2011DataSet.Company_Visit)
        Company_VisitBindingSource.Position = Ipos2

    End Sub
    Private Sub SaveCompanyAdapter(Optional ByVal Save As Boolean = True)
        If Save Then
            Try
                Me.Validate()
                Me.Companies_VisitedBindingSource.EndEdit()
                Me.Company_ContactsBindingSource.EndEdit()
                EmployeeCompanyVisitBindingSource.EndEdit()
                Company_VisitBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Ingenium_2011DataSet)
                ToolStripStatusLabel1.Text = "Saved"
                ToolStripStatusLabel1.BackColor = Color.GreenYellow
            Catch ex As Exception
                ToolStripStatusLabel1.Text = "Error: " & ex.ToString
                ToolStripStatusLabel1.BackColor = Color.Red
            End Try
        Else
            'cancel edit
            Me.Companies_VisitedBindingSource.CancelEdit()
            Me.Company_ContactsBindingSource.CancelEdit()
            ToolStripStatusLabel1.Text = "Edit Cancelled"
            ToolStripStatusLabel1.BackColor = Color.WhiteSmoke
        End If
    End Sub
    Private Sub ShowButtonCompany(Optional ByVal Show As Boolean = True)
        If Show Then
            'allow edit
            Panel1.Enabled = True
            SaveCancelPanel.Enabled = True
            AddNewButton1.Enabled = False
            EditButton.Enabled = False
            Company_ContactsDataGridView.ReadOnly = False
        Else
            'disallow edit
            Panel1.Enabled = False
            SaveCancelPanel.Enabled = False
            AddNewButton1.Enabled = True
            EditButton.Enabled = True
            Company_ContactsDataGridView.ReadOnly = True
        End If
    End Sub

    Private Sub AddNewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewButton1.Click
        Try
            Companies_VisitedBindingSource.AddNew()
            SaveCompanyAdapter()
            LoadCompanyAdapter()
            ShowButtonCompany()
            Companies_VisitedBindingSource.MoveFirst()
            ToolStripStatusLabel1.Text = "New Company Added"
            ToolStripStatusLabel1.BackColor = Color.GreenYellow
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Error in Adding Company"
            ToolStripStatusLabel1.BackColor = Color.Red
        End Try
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        ShowButtonCompany()
        ToolStripStatusLabel1.Text = "Edit Mode"
        ToolStripStatusLabel1.BackColor = Color.GreenYellow
    End Sub

    Private Sub SaveRecordButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveRecordButton.Click
        Try
            SaveCompanyAdapter()
            LoadCompanyAdapter()
            ShowButtonCompany(False)
            ToolStripStatusLabel1.Text = "Saved"
            ToolStripStatusLabel1.BackColor = Color.GreenYellow
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Error:" & ex.ToString
            ToolStripStatusLabel1.BackColor = Color.Red
        End Try

    End Sub

    Private Sub CancelRecordButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelRecordButton.Click
        SaveCompanyAdapter(False)
        LoadCompanyAdapter()
        ShowButtonCompany(False)
        ToolStripStatusLabel1.Text = "Edit Cancelled"
        ToolStripStatusLabel1.BackColor = Color.GreenYellow
    End Sub

    Private Sub CTypeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTypeComboBox.SelectedIndexChanged
        Company_TypeTextBox.Text = CTypeComboBox.Text
    End Sub

    Private Sub Company_TypeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Company_TypeTextBox.TextChanged
        CTypeComboBox.Text = Company_TypeTextBox.Text
    End Sub

    Private Sub OTypeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OTypeComboBox.SelectedIndexChanged
        Office_TypeTextBox.Text = OTypeComboBox.Text
    End Sub

    Private Sub Office_TypeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Office_TypeTextBox.TextChanged
        OTypeComboBox.Text = Office_TypeTextBox.Text
    End Sub
    '##############################################################
    '##############################################################
    'Company Visit
    '##############################################################
    '##############################################################
    Private Sub LoadCompanyVisitAdapter()
        Me.EmployeeCompanyVisitTableAdapter.Fill(Me.Ingenium_2011DataSet.EmployeeCompanyVisit)
        Me.Company_VisitTableAdapter.Fill(Me.Ingenium_2011DataSet.Company_Visit)
        'ToolStripStatusLabel3.Text = "No. of Company Visits- " & Company_VisitBindingSource.Count & "   "
    End Sub
    Private Sub ShowCVButton(Optional ByVal Show As Boolean = True)
        If Show Then
            'allow edit
            EVAddNewButton.Enabled = False
            EVEditButton.Enabled = False
            EVSaveCancelPanel.Enabled = True
            EmployeeCompanyVisitDataGridView.ReadOnly = False
            VisitDataPanel.Enabled = True
        Else
            'allow edit
            EVAddNewButton.Enabled = True
            EVEditButton.Enabled = True
            EVSaveCancelPanel.Enabled = False
            EmployeeCompanyVisitDataGridView.ReadOnly = True
            VisitDataPanel.Enabled = False
        End If
    End Sub

    Private Sub EVAddNewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EVAddNewButton.Click
        Try
            Company_VisitBindingSource.AddNew()
            CompanyIdTextBox1.Text = CompanyIdTextBox.Text
            Visit_DateDateTimePicker.Value = Today.Date
            Visit_DateDateTimePicker.Value = #3/3/2010#
            Visit_DateDateTimePicker.Value = Today.Date
            SaveCompanyAdapter()
            LoadCompanyVisitAdapter()
            ShowCVButton()
            ToolStripStatusLabel1.Text = "New Visit Added"
            ToolStripStatusLabel1.BackColor = Color.GreenYellow
            Company_VisitBindingSource.MoveLast()
        Catch ex As Exception
            ToolStripStatusLabel1.Text = "Company Visit Edit Cancelled"
            ToolStripStatusLabel1.BackColor = Color.WhiteSmoke
        End Try
    End Sub

    Private Sub EVEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EVEditButton.Click
        ShowCVButton()
        ToolStripStatusLabel1.Text = "Company Visit Edit Mode"
        ToolStripStatusLabel1.BackColor = Color.GreenYellow
    End Sub

    Private Sub EVSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EVSaveButton.Click
        SaveCompanyAdapter()
        LoadCompanyVisitAdapter()
        ShowCVButton(False)
    End Sub

    Private Sub EVCancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EVCancelButton.Click
        SaveCompanyAdapter(False)
        LoadCompanyVisitAdapter()
        ShowCVButton(False)
    End Sub

    Private Sub PurposeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurposeComboBox.SelectedIndexChanged
        PurposeTextBox.Text = PurposeComboBox.Text
    End Sub

    Private Sub PurposeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurposeTextBox.TextChanged
        PurposeComboBox.Text = PurposeTextBox.Text
    End Sub

    Private Sub Company_VisitBindingSource_CurrentItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Company_VisitBindingSource.CurrentItemChanged
        'changed company visit
        If Company_VisitBindingSource.Count = 0 Then
            EVEditButton.Enabled = False
        Else
            EVEditButton.Enabled = True
        End If
        ToolStripStatusLabel2.Text = "No. of Company Visits- " & Company_VisitBindingSource.Count & "   "
    End Sub
End Class