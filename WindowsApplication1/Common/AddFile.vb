Public Class AddFile
    Public Function ReadTextFilefrmApplicationFolder(ByVal FileName As String) As String
        'this reads a file from Application Folder
        Try
            Dim FILE_NAME As String = Application.StartupPath & "\" & FileName '"\Hotel_Email_Draft.txt"
            ReadTextFilefrmApplicationFolder = System.IO.File.ReadAllText(FILE_NAME)
            'MsgBox("Saved", MsgBoxStyle.Information, "File Save Module")
        Catch ex As Exception
            ReadTextFilefrmApplicationFolder = ""
        End Try
    End Function
End Class
