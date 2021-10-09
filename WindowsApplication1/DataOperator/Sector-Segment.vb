Public Class Sector_Segment
    Private Sub SectorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SectorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SectorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ingenium_2011DataSet)

    End Sub

    Private Sub Sector_Segment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ingenium_2011DataSet.Sector' table. You can move, or remove it, as needed.
        Me.SectorTableAdapter.Fill(Me.Ingenium_2011DataSet.Sector)

    End Sub
End Class