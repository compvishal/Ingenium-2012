Public Class School_Azure
    Private Sub Visited_SchoolsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Visited_SchoolsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Visited_SchoolsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AzureSQLDataset)

    End Sub

    Private Sub School_Azure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AzureSQLDataset.Visited_Schools' table. You can move, or remove it, as needed.
        Me.Visited_SchoolsTableAdapter.Fill(Me.AzureSQLDataset.Visited_Schools)

    End Sub
End Class