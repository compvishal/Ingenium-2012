Public Class City


    Private Sub City_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.City' table. You can move, or remove it, as needed.
        Me.CityTableAdapter.Fill(Me.Ingenium_2011DataSet.City)

    End Sub

    Private Sub ToolStripButtonEdit_Click(sender As Object, e As EventArgs) Handles ToolStripButtonEdit.Click
        CityDataGridView.ReadOnly = False
    End Sub



    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.CityBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ingenium_2011DataSet)
        CityDataGridView.ReadOnly = True
    End Sub
End Class