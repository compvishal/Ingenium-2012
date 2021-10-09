Public Class Employee_Azure
    Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmployeeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AzureSQLDataset)

    End Sub

    Private Sub Employee_Azure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AzureSQLDataset.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.AzureSQLDataset.Employee)

    End Sub
End Class