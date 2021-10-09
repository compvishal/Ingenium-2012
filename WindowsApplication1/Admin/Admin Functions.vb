Public Class Admin_Functions

    Private Sub MergeSchoolButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MergeSchoolButton.Click
        If MsgBox("This will permamentally merge data of School Id " & TextBox1.Text & " In School Id " & TextBox2.Text & vbCrLf & " Sure??", MsgBoxStyle.YesNo, "School Merge Module") = MsgBoxResult.Yes Then
            'merge school
            Dim Url As New Ingenium_2011DataSetTableAdapters.QueriesTableAdapter
            Try
                Url.MergeSchool2toSchool1(TextBox2.Text, TextBox1.Text)
                If MsgBox("Schools Merged! Now Delete SchoolId " & TextBox1.Text & " ?", MsgBoxStyle.YesNo, "School Merge Module") = MsgBoxResult.Yes Then
                    Try
                        'MsgBox(" School " & TextBox1.Text & " Deleted!", MsgBoxStyle.Critical, "School Merge Module")
                        Url.DeleteSchoolId(TextBox1.Text)
                        MsgBox(" School " & TextBox1.Text & " Deleted!", MsgBoxStyle.Information, "School Merge Module!")
                    Catch ex As Exception
                        MsgBox("Error while Deleting Schools !", MsgBoxStyle.Critical, "School Merge Module")
                    End Try
                End If
            Catch ex As Exception
                MsgBox("Error while merging Schools !", MsgBoxStyle.Critical, "School Merge Module")
            End Try
        End If
    End Sub
End Class