Public Class Contacts


    Private Sub Contacts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadAdapter()
        LoadOtherAdapter()
        ShowButton(True)
        CancelSearch(True)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ContactsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ingenium_2011DataSet)
    End Sub
    Private Sub ShowButton(show As Boolean)
        If show Then
            Panel1.Enabled = False
            AddEditPanel.Enabled = True
            SaveCancelPanel.Enabled = False
            PanelSearch.Enabled = True
        Else
            CancelSearch(True)
            PanelSearch.Enabled = False
            Panel1.Enabled = True
            AddEditPanel.Enabled = False
            SaveCancelPanel.Enabled = True


        End If


    End Sub

    Private Sub SaveRecordButton_Click(sender As Object, e As EventArgs) Handles SaveRecordButton.Click
        If Not (CheckError()) Then
            SaveAdapter(True)
            ShowButton(True)
            LoadAdapter()
        End If

    End Sub
    Private Sub LoadAdapter()
        Dim Xop As Int16
        Xop = ContactsBindingSource.Position
        Me.ContactsTableAdapter.Fill(Me.Ingenium_2011DataSet.Contacts)
        ContactsBindingSource.Position = Xop
    End Sub
    Private Sub LoadOtherAdapter()
        Me.Visited_SchoolsTableAdapter.Fill(Me.Ingenium_2011DataSet.Visited_Schools)
        Me.SectorTableAdapter.Fill(Me.Ingenium_2011DataSet.Sector)
        Me.CityTableAdapter.Fill(Me.Ingenium_2011DataSet.City)
        Me.EmployeeTableAdapter.Fill(Me.Ingenium_2011DataSet.Employee)

    End Sub
    Private Function CheckError() As Boolean
        CheckError = True
        ErrorProvider1.SetError(Me.Contact_NameTextBox, "")
        ErrorProvider1.SetError(Me.Mobile_Phone1TextBox, "")
        ErrorProvider1.SetError(Me.SectorComboBox, "")
        ErrorProvider1.SetError(Me.ComboBoxCity, "")
        ErrorProvider1.SetError(Me.ComboBoxEmployee, "")
        'check name
        If Contact_NameTextBox.Text = "" Then
            ErrorProvider1.SetError(Me.Contact_NameTextBox, "Provide Name")
            Exit Function
        End If
        'check mobile number
        If (Mobile_Phone1TextBox.Text = "" Or Mobile_Phone1TextBox.Text.Length <> 10 Or Not (IsNumeric(Mobile_Phone1TextBox.Text))) Then
            ErrorProvider1.SetError(Me.Mobile_Phone1TextBox, "Enter 10 digit mobile number")
            Exit Function
        Else
            'check number doesnt exist
            Dim Url2 As New Ingenium_2011DataSetTableAdapters.QueriesTableAdapter, ContactId As Integer
            Try
                ContactId = Url2.CheckMobileNo_ofContacts(Mobile_Phone1TextBox.Text, Mobile_Phone1TextBox.Text, Mobile_Phone1TextBox.Text)
                If ContactId <> IDTextBox.Text Then
                    ErrorProvider1.SetError(Me.Mobile_Phone1TextBox, "Mobile number already exists for ID:" & ContactId)
                    Exit Function
                End If
            Catch ex As Exception

            End Try
        End If
        'check sector
        If SectorComboBox.Text = "" Then
            ErrorProvider1.SetError(Me.SectorComboBox, "Select Sector")
            Exit Function
        End If
        'check city
        If ComboBoxCity.Text = "" Then
            ErrorProvider1.SetError(Me.ComboBoxCity, "Select City/Location")
            Exit Function
        End If
        'check employee
        If ComboBoxEmployee.Text = "" Then
            ErrorProvider1.SetError(Me.ComboBoxEmployee, "Select Employee")
            Exit Function
        End If
        CheckError = False
    End Function
    Private Sub SaveAdapter(Optional ByVal Save As Boolean = True)
        If Save Then
            Try
                Me.Validate()
                Me.ContactsBindingSource.EndEdit()
                'Me.School_ContactsBindingSource.EndEdit()
                Me.ContactsTableAdapter.Update(Me.Ingenium_2011DataSet.Contacts)
                'Me.TableAdapterManager.UpdateAll(Me.Ingenium_2011DataSet)
            Catch ex As Exception
                MsgBox(ex.ToString)
                ToolStripStatusLabel1.Text = ex.ToString
                ToolStripStatusLabel1.BackColor = Color.Red
            End Try
            ToolStripStatusLabel1.Text = "Saved"
            ToolStripStatusLabel1.BackColor = Color.GreenYellow
        Else
            Me.ContactsBindingSource.CancelEdit()

            ToolStripStatusLabel1.Text = "Edit Canceled"
            ToolStripStatusLabel1.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub CancelRecordButton_Click(sender As Object, e As EventArgs) Handles CancelRecordButton.Click
        SaveAdapter(False)
        ShowButton(True)
        LoadAdapter()
    End Sub

    Private Sub AddNewButton1_Click(sender As Object, e As EventArgs) Handles AddNewButton1.Click
        Me.ContactsBindingSource.AddNew()
        VerifiedCheckBox.Checked = False
        ShowButton(False)
        ToolStripStatusLabel1.Text = "New Added"
        ToolStripStatusLabel1.BackColor = Color.GreenYellow
        IDTextBox.Focus()
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        ShowButton(False)
        ToolStripStatusLabel1.Text = "Edit Mode"
        ToolStripStatusLabel1.BackColor = Color.GreenYellow
    End Sub



    Private Sub VerifiedCheckBox_Leave(sender As Object, e As EventArgs) Handles VerifiedCheckBox.Leave
        ' AcceptButton.focus
        SaveRecordButton.Focus()
    End Sub



    Private Sub ContactsDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles ContactsDataGridView.DataError

    End Sub

    Private Sub CancelSearchButton_Click(sender As Object, e As EventArgs) Handles CancelSearchButton.Click
        CancelSearch(True)
    End Sub
    Private Sub CancelSearch(Cancel As Boolean)
        If Cancel Then
            SearchNameTextBox.Text = ""
            TextBoxCOntactId.Text = ""
            'SearchCityTextBox.Text = ""

            SearchEmployeeComboBox.Text = "All"
            ComboBoxCitySearch.Text = "All"
            CancelSearchButton.Enabled = False
            ContactsBindingSource.Filter = ""
            ToolStripStatusLabel5.Text = "Showing All " & ContactsBindingSource.Count & " Contacts"
        Else
            If TextBoxCOntactId.Text <> "" Then
                ContactsBindingSource.Filter = "[ID]=" & TextBoxCOntactId.Text

            Else
                Dim FilterText As String
                FilterText = "[Contact Name] Like( '%" & SearchNameTextBox.Text & "%')"

                If ComboBoxCitySearch.Text <> "" And ComboBoxCitySearch.Text <> "All" Then
                    FilterText &= " AND [CityId]=" & ComboBoxCitySearch.SelectedValue ' " AND [City] Like( '%" & SearchCityTextBox.Text & "%')"
                End If

                If SearchEmployeeComboBox.Text <> "All" And SearchEmployeeComboBox.Text <> "" Then
                    FilterText &= " AND [EmployeeId]=" & SearchEmployeeComboBox.SelectedValue
                End If
                ' Visited_SchoolsBindingSource.Filter = FilterText
                ContactsBindingSource.Filter = FilterText

            End If
            CancelSearchButton.Enabled = True
            ToolStripStatusLabel5.Text = "Filter On " & ContactsBindingSource.Count & " Contacts Selected"

        End If
    End Sub

    Private Sub SearchNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchNameTextBox.TextChanged
        CancelSearch(False)
    End Sub

    Private Sub SearchCityTextBox_TextChanged(sender As Object, e As EventArgs)
        'CancelSearch(False)
    End Sub

    Private Sub SearchEmployeeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchEmployeeComboBox.SelectedIndexChanged
        If SearchEmployeeComboBox.Text <> "All" Then
            CancelSearch(False)
        End If

    End Sub

    Private Sub TextBoxCOntactId_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCOntactId.TextChanged
        'CancelSearch(False)
    End Sub

    Private Sub ComboBoxCitySearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCitySearch.SelectedIndexChanged
        If ComboBoxCity.Text <> "All" Then
            CancelSearch(False)
        End If

    End Sub
End Class