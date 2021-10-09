<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Birthday
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.MonthNameComboBox = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(715, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'MonthNameComboBox
        '
        Me.MonthNameComboBox.FormattingEnabled = True
        Me.MonthNameComboBox.Location = New System.Drawing.Point(41, 3)
        Me.MonthNameComboBox.Name = "MonthNameComboBox"
        Me.MonthNameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.MonthNameComboBox.TabIndex = 1
        '
        'Birthday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 382)
        Me.Controls.Add(Me.MonthNameComboBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Birthday"
        Me.Text = "Birthday"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents MonthNameComboBox As System.Windows.Forms.ComboBox
End Class
