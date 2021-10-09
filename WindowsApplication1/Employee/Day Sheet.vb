Public Class Day_Sheet

    Private Sub Day_Sheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.EmployeeTableAdapter.Fill(Me.Ingenium_2011DataSet.Employee)
        If LoginForm1.Role = "Administrator" Then
            EmplyNameComboBox.Enabled = True
        Else
            EmplyNameComboBox.SelectedValue = LoginForm1.EmplyId
            EmplyNameComboBox.Enabled = False
        End If
        Me.Text = "Day Sheet for  " & EmplyNameComboBox.Text
        LoadAdapter()
        ShowButton(False)
        ToolStripStatusLabel2.Text = "View Mode"
        ToolStripStatusLabel2.BackColor = Color.Peru
    End Sub
    Private Sub LoadAdapter()
        'Me.Employee_Day_SheetTableAdapter.Fill(Me.Ingenium_2011DataSet.Employee_Day_Sheet)
        Dim Xpos As Integer = Employee_Day_SheetBindingSource.Position
        Me.Employee_Day_SheetTableAdapter.FillByEmplyId(Me.Ingenium_2011DataSet.Employee_Day_Sheet, EmplyNameComboBox.SelectedValue)
        Employee_Day_SheetBindingSource.Position = Xpos
        ToolStripStatusLabel1.Text = "Total Day Entries: " & Employee_Day_SheetBindingSource.Count
        ToolStripStatusLabel1.BackColor = Color.PowderBlue

    End Sub
    Private Sub ShowButton(Optional ByVal Show As Boolean = True)
        If Show Then
            'allow edit
            DayRecordPanel.Enabled = True
            DaySavePanel.Enabled = True
            DayAddNewButton.Enabled = False
            DayEditButton.Enabled = False
        Else
            ' do not allow edit
            DayRecordPanel.Enabled = False
            DaySavePanel.Enabled = False
            DayAddNewButton.Enabled = True
            DayEditButton.Enabled = True
        End If
    End Sub
    Private Sub SaveAdapter(Optional ByVal Save As Boolean = True)
        Try
            If Save Then
                Employee_Day_SheetBindingSource.EndEdit()
                Employee_Day_SheetTableAdapter.Update(Ingenium_2011DataSet.Employee_Day_Sheet)
                ToolStripStatusLabel2.Text = "Edit Saved"
                ToolStripStatusLabel2.BackColor = Color.GreenYellow
            Else
                Employee_Day_SheetBindingSource.CancelEdit()
                ToolStripStatusLabel2.Text = "Edit Cancelled"
                ToolStripStatusLabel2.BackColor = Color.WhiteSmoke
            End If
        Catch ex As Exception
            ToolStripStatusLabel2.Text = "Error! Data not Saved"
            ToolStripStatusLabel2.BackColor = Color.Red
        End Try

    End Sub
    Private Sub AddNewRecord()
        Employee_Day_SheetBindingSource.AddNew()
        EmplyIdTextBox.Text = EmplyNameComboBox.SelectedValue
        ToolStripStatusLabel2.Text = "New Record Added"
        ToolStripStatusLabel2.BackColor = Color.LightSeaGreen
    End Sub

    Private Sub DayAddNewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayAddNewButton.Click
        AddNewRecord()
        Working_DateDateTimePicker.Value = Today
        PresentCheckBox.Checked = True
        'Start_TimeDateTimePicker.Value = #9:30:00 AM#
        'End_TimeDateTimePicker.Value = #6:30:00 PM#
        'StartTimeTextBox.Text = "10:00"
        'EndTimeTextBox.Text = "18:00"
        ShowButton()
        Working_DateDateTimePicker.Focus()
    End Sub

    Private Sub DayEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayEditButton.Click
        ShowButton(True)
        Working_DateDateTimePicker.Focus()
    End Sub

    Private Sub SaveEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveEditButton.Click
        If CheckError() Then Exit Sub
        SaveAdapter(True)
        ShowButton(False)
        LoadAdapter()
        DayAddNewButton.Focus()
    End Sub

    Private Sub CancelEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelEditButton.Click
        SaveAdapter(False)
        ShowButton(False)
        LoadAdapter()
    End Sub

    Private Sub EmplyNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmplyNameComboBox.SelectedIndexChanged
        Me.Text = "Day Sheet for  " & EmplyNameComboBox.Text
        LoadAdapter()
    End Sub

    Private Sub Other_Expenses_DetailsTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Other_Expenses_DetailsTextBox.LostFocus
        SaveEditButton.Focus()
    End Sub

    Private Function CheckError() As Boolean
        CheckError = True
        ErrorProvider1.SetError(Me.Working_DateDateTimePicker, "")
        ErrorProvider1.SetError(Me.Start_Meter_ReadingTextBox, "")
        ErrorProvider1.SetError(Me.End_Meter_ReadingTextBox, "")
        'ErrorProvider1.SetError(Me.End_Meter_ReadingTextBox, "")

        If Int(End_Meter_ReadingTextBox.Text) < Int(Start_Meter_ReadingTextBox.Text) Then
            ErrorProvider1.SetError(Me.End_Meter_ReadingTextBox, "Incorrect Reading")
            Exit Function
        End If

        CheckError = False
    End Function


End Class