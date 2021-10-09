Public Class Companyold
    Private Sub Company_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCompanyAdapter()
        Companies_VisitedDataGridView.ReadOnly = True
        ShowButtonCompany(False)
    End Sub
    Private Sub LoadCompanyAdapter()
        Dim Ipos As Integer = Companies_VisitedBindingSource.Position
        Me.Company_ContactsTableAdapter.Fill(Me.Ingenium_2011DataSet.Company_Contacts)
        Me.Companies_VisitedTableAdapter.Fill(Me.Ingenium_2011DataSet.Companies_Visited)
        Companies_VisitedBindingSource.Position = Ipos
        Me.EmployeeCompanyVisitTableAdapter.Fill(Me.Ingenium_2011DataSet.EmployeeCompanyVisit)
        Me.Company_VisitTableAdapter.Fill(Me.Ingenium_2011DataSet.Company_Visit)
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
            ToolStripStatusLabel1.Text = "Edit Cancelled Saved"
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
    Private Sub TabPage2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Enter
        Me.EmployeeTableAdapter.Fill(Me.Ingenium_2011DataSet.Employee)
        LoadCompanyVisitAdapter()
        Company_VisitDataGridView.ReadOnly = True
        ShowCVButton(False)
    End Sub
    Private Sub LoadCompanyVisitAdapter()
        Me.EmployeeCompanyVisitTableAdapter.Fill(Me.Ingenium_2011DataSet.EmployeeCompanyVisit)
        Me.Company_VisitTableAdapter.Fill(Me.Ingenium_2011DataSet.Company_Visit)
        ToolStripStatusLabel3.Text = "No. of Company Visits- " & Company_VisitBindingSource.Count & "   "
    End Sub
    Private Sub SaveCompanyVisitAdapter(Optional ByVal Save As Boolean = True)
        If Save Then
            Try
                Me.Validate()
                EmployeeCompanyVisitBindingSource.EndEdit()
                Company_VisitBindingSource.EndEdit()
                'Me.TableAdapterManager.UpdateAll(Me.Ingenium_2011DataSet)
                Me.Companies_VisitedTableAdapter.Update(Me.Ingenium_2011DataSet.Companies_Visited)
                Me.EmployeeCompanyVisitTableAdapter.Update(Me.Ingenium_2011DataSet.EmployeeCompanyVisit)
                ToolStripStatusLabel2.Text = "Saved"
                ToolStripStatusLabel2.BackColor = Color.GreenYellow
            Catch ex As Exception
                ToolStripStatusLabel2.Text = "Error:" & ex.ToString
                ToolStripStatusLabel2.BackColor = Color.Red
            End Try
        Else
            EmployeeCompanyVisitBindingSource.CancelEdit()
            Company_VisitBindingSource.CancelEdit()
            ToolStripStatusLabel2.Text = "Edit Cancelled"
            ToolStripStatusLabel2.BackColor = Color.WhiteSmoke
        End If
    End Sub
    Private Sub ShowCVButton(Optional ByVal Show As Boolean = True)
        If Show Then
            'allow edit
            EVAddNewButton.Enabled = False
            EVEditButton.Enabled = False
            EVSaveCancelPanel.Enabled = True
            EmployeeCompanyVisitDataGridView.ReadOnly = False
            Panel2.Enabled = True
        Else
            'allow edit
            EVAddNewButton.Enabled = True
            EVEditButton.Enabled = True
            EVSaveCancelPanel.Enabled = False
            EmployeeCompanyVisitDataGridView.ReadOnly = True
            Panel2.Enabled = False
        End If
    End Sub

    Private Sub EVAddNewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EVAddNewButton.Click
        Try
            Company_VisitBindingSource.AddNew()
            CompanyIdTextBox1.Text = CompanyIdTextBox.Text
            Visit_DateDateTimePicker.Value = Today.Date
            Visit_DateDateTimePicker.Value = #3/3/2010#
            Visit_DateDateTimePicker.Value = Today.Date
            SaveCompanyVisitAdapter()
            LoadCompanyVisitAdapter()
            ShowCVButton()
            ToolStripStatusLabel2.Text = "New Visit Added"
            ToolStripStatusLabel2.BackColor = Color.GreenYellow
        Catch ex As Exception
            ToolStripStatusLabel2.Text = "Edit Cancelled"
            ToolStripStatusLabel2.BackColor = Color.WhiteSmoke
        End Try
    End Sub

    Private Sub EVEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EVEditButton.Click
        ShowCVButton()
        ToolStripStatusLabel2.Text = "Edit Mode"
        ToolStripStatusLabel2.BackColor = Color.GreenYellow
    End Sub

    Private Sub EVSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EVSaveButton.Click
        SaveCompanyVisitAdapter()
        LoadCompanyVisitAdapter()
        ShowCVButton(False)
    End Sub

    Private Sub EVCancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EVCancelButton.Click
        SaveCompanyVisitAdapter(False)
        LoadCompanyVisitAdapter()
        ShowCVButton(False)
    End Sub

    Private Sub PurposeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurposeComboBox.SelectedIndexChanged
        PurposeTextBox.Text = PurposeComboBox.Text
    End Sub

    Private Sub PurposeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurposeTextBox.TextChanged
        PurposeComboBox.Text = PurposeTextBox.Text
    End Sub
End Class