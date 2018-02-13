<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentMDI
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ManageAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExamsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeeRecieptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarksheetToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageAccountToolStripMenuItem, Me.ExamsToolStripMenuItem, Me.FeeRecieptToolStripMenuItem, Me.AttendenceToolStripMenuItem, Me.MarksheetToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(667, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ManageAccountToolStripMenuItem
        '
        Me.ManageAccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateInformationToolStripMenuItem})
        Me.ManageAccountToolStripMenuItem.Name = "ManageAccountToolStripMenuItem"
        Me.ManageAccountToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.ManageAccountToolStripMenuItem.Text = "Manage Account"
        '
        'UpdateInformationToolStripMenuItem
        '
        Me.UpdateInformationToolStripMenuItem.Name = "UpdateInformationToolStripMenuItem"
        Me.UpdateInformationToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.UpdateInformationToolStripMenuItem.Text = "Update Information"
        '
        'ExamsToolStripMenuItem
        '
        Me.ExamsToolStripMenuItem.Name = "ExamsToolStripMenuItem"
        Me.ExamsToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.ExamsToolStripMenuItem.Text = "Exam Time Table"
        '
        'FeeRecieptToolStripMenuItem
        '
        Me.FeeRecieptToolStripMenuItem.Name = "FeeRecieptToolStripMenuItem"
        Me.FeeRecieptToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.FeeRecieptToolStripMenuItem.Text = "Fee Reciept"
        '
        'AttendenceToolStripMenuItem
        '
        Me.AttendenceToolStripMenuItem.Name = "AttendenceToolStripMenuItem"
        Me.AttendenceToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.AttendenceToolStripMenuItem.Text = "Attendence"
        '
        'MarksheetToolStripMenuItem1
        '
        Me.MarksheetToolStripMenuItem1.Name = "MarksheetToolStripMenuItem1"
        Me.MarksheetToolStripMenuItem1.Size = New System.Drawing.Size(74, 20)
        Me.MarksheetToolStripMenuItem1.Text = "Marksheet"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StudentMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 428)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "StudentMDI"
        Me.Text = "StudentMDI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ManageAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExamsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeeRecieptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttendenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarksheetToolStripMenuItem1 As ToolStripMenuItem
End Class
