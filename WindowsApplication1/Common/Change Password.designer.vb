<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change_Password
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ConfirmPassTextBox = New System.Windows.Forms.TextBox
        Me.NewPasswordTextBox = New System.Windows.Forms.TextBox
        Me.OldPassTextBox = New System.Windows.Forms.TextBox
        Me.CancelButton = New System.Windows.Forms.Button
        Me.ChangeButton = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConfirmPassTextBox
        '
        Me.ConfirmPassTextBox.Location = New System.Drawing.Point(111, 73)
        Me.ConfirmPassTextBox.Name = "ConfirmPassTextBox"
        Me.ConfirmPassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPassTextBox.Size = New System.Drawing.Size(113, 20)
        Me.ConfirmPassTextBox.TabIndex = 15
        '
        'NewPasswordTextBox
        '
        Me.NewPasswordTextBox.Location = New System.Drawing.Point(111, 41)
        Me.NewPasswordTextBox.Name = "NewPasswordTextBox"
        Me.NewPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPasswordTextBox.Size = New System.Drawing.Size(113, 20)
        Me.NewPasswordTextBox.TabIndex = 14
        '
        'OldPassTextBox
        '
        Me.OldPassTextBox.Location = New System.Drawing.Point(111, 9)
        Me.OldPassTextBox.Name = "OldPassTextBox"
        Me.OldPassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.OldPassTextBox.Size = New System.Drawing.Size(113, 20)
        Me.OldPassTextBox.TabIndex = 13
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(138, 111)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 12
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'ChangeButton
        '
        Me.ChangeButton.Location = New System.Drawing.Point(38, 111)
        Me.ChangeButton.Name = "ChangeButton"
        Me.ChangeButton.Size = New System.Drawing.Size(75, 23)
        Me.ChangeButton.TabIndex = 11
        Me.ChangeButton.Text = "Change"
        Me.ChangeButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ConfirmPassword"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "New Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Present Password"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Change_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 138)
        Me.Controls.Add(Me.ConfirmPassTextBox)
        Me.Controls.Add(Me.NewPasswordTextBox)
        Me.Controls.Add(Me.OldPassTextBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ChangeButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Change_Password"
        Me.Text = "Change_Password"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConfirmPassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NewPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OldPassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents ChangeButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
