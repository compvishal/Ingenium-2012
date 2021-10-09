Public Class Common_Functions

    Public Function CheckMob(MobNo) As Boolean
        CheckMob = True
        Try
            If Len(MobNo) <> 10 Then
                Exit Function
            End If
            If Not IsNumeric(MobNo) Then
                Exit Function
            End If
        Catch ex As Exception

        End Try

        CheckMob = False
    End Function

    Public Function ReadHederText() As String
        Dim AFile As New AddFile
        Try
            Dim FileTextMsg As String = AFile.ReadTextFilefrmApplicationFolder("Header")
            ReadHederText = FileTextMsg
        Catch ex As Exception
            ReadHederText = ""
        End Try
    End Function
    Public Function GridColumnTotal(ByVal GRV As DataGridView, ByVal Col As Integer) As Single
        Dim GRow As DataGridViewRow, ReturnAmount As Single = 0
        Try
            For Each GRow In GRV.Rows
                ReturnAmount += GRow.Cells(Col).Value
            Next
        Catch ex As Exception

        End Try
        Return ReturnAmount
    End Function
    Public Function ValidatePasswordStrength(PassWord As String) As String
        ValidatePasswordStrength = ""
        If PassWord = "" Then
            ValidatePasswordStrength = "Password Can't be left Blank"
        ElseIf PassWord.Length < 6 Then
            ValidatePasswordStrength = "Password Can't be less than 6 Characters"
        ElseIf IsNumeric(PassWord) Then
            ValidatePasswordStrength = "Password Should have atleast one character"
        ElseIf Not (HasNumber(PassWord)) = True Then
            ValidatePasswordStrength = "Password Should have atleast one Digit"
        End If

    End Function
    Function HasNumber(strData As String) As Boolean
        Dim iCnt As Integer

        For iCnt = 1 To Len(strData)
            If IsNumeric(Mid(strData, iCnt, 1)) Then
                HasNumber = True
                Exit Function
            End If
        Next iCnt

    End Function
    Public Sub FindId_inBindingSource(IdTextbox As TextBox, IdBindingSrc As BindingSource, IDColName As String)
        Try
            If IdTextbox.Text <> "" Then
                IdBindingSrc.Position = IdBindingSrc.Find(IDColName, IdTextbox.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub
    ' FilterText = " AND ([Mobile1] Like( '%" & MobileTextBox1.Text & "%') OR [Mobile2] Like( '%" & MobileTextBox1.Text & "%'))"
    Public Sub Filter_inBindingSource(FilterText As String, IdBindingSrc As BindingSource)
        Try
            'If FilterText <> "" Then
            'IdBindingSrc.Position = IdBindingSrc.Find(IDColName, "%" & IdTextbox.Text & "%")
            IdBindingSrc.Filter = FilterText

            ' End If
        Catch ex As Exception

        End Try
    End Sub
    Public Function GetDriveSerialNumber() As String
        Dim DriveSerial As Integer
        'Create a FileSystemObject object
        Dim fso As Object = CreateObject("Scripting.FileSystemObject")
        Dim Drv As Object = fso.GetDrive(fso.GetDriveName(Application.StartupPath))
        With Drv
            If .IsReady Then
                DriveSerial = .SerialNumber
            Else    '"Drive Not Ready!"
                DriveSerial = -1
            End If
        End With
        Return DriveSerial.ToString("X2")
    End Function

End Class

