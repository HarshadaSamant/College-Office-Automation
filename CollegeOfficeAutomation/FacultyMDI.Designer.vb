<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FacultyMDI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ManageAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarksheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMarksheetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExamsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkStudentAttendenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkStudentAttendenceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStudentAttendenceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageAccountToolStripMenuItem, Me.ToolStripMenuItem1, Me.MarksheetToolStripMenuItem, Me.ExamsToolStripMenuItem, Me.AttendenceToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(812, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ManageAccountToolStripMenuItem
        '
        Me.ManageAccountToolStripMenuItem.Name = "ManageAccountToolStripMenuItem"
        Me.ManageAccountToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.ManageAccountToolStripMenuItem.Text = "Manage Account"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarkStudentAttendenceToolStripMenuItem1, Me.ViewStudentAttendenceToolStripMenuItem1})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(124, 20)
        Me.ToolStripMenuItem1.Text = "Student Attendence"
        '
        'MarksheetToolStripMenuItem
        '
        Me.MarksheetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateToolStripMenuItem, Me.ViewMarksheetsToolStripMenuItem})
        Me.MarksheetToolStripMenuItem.Name = "MarksheetToolStripMenuItem"
        Me.MarksheetToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.MarksheetToolStripMenuItem.Text = "Marksheet"
        '
        'CreateToolStripMenuItem
        '
        Me.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem"
        Me.CreateToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CreateToolStripMenuItem.Text = "Create Marksheets"
        '
        'ViewMarksheetsToolStripMenuItem
        '
        Me.ViewMarksheetsToolStripMenuItem.Name = "ViewMarksheetsToolStripMenuItem"
        Me.ViewMarksheetsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ViewMarksheetsToolStripMenuItem.Text = "View Marksheets"
        '
        'ExamsToolStripMenuItem
        '
        Me.ExamsToolStripMenuItem.Name = "ExamsToolStripMenuItem"
        Me.ExamsToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.ExamsToolStripMenuItem.Text = "Exam Time Table"
        '
        'AttendenceToolStripMenuItem
        '
        Me.AttendenceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarkStudentAttendenceToolStripMenuItem})
        Me.AttendenceToolStripMenuItem.Name = "AttendenceToolStripMenuItem"
        Me.AttendenceToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.AttendenceToolStripMenuItem.Text = "Attendence"
        '
        'MarkStudentAttendenceToolStripMenuItem
        '
        Me.MarkStudentAttendenceToolStripMenuItem.Name = "MarkStudentAttendenceToolStripMenuItem"
        Me.MarkStudentAttendenceToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.MarkStudentAttendenceToolStripMenuItem.Text = "View Attendence"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MarkStudentAttendenceToolStripMenuItem1
        '
        Me.MarkStudentAttendenceToolStripMenuItem1.Name = "MarkStudentAttendenceToolStripMenuItem1"
        Me.MarkStudentAttendenceToolStripMenuItem1.Size = New System.Drawing.Size(209, 22)
        Me.MarkStudentAttendenceToolStripMenuItem1.Text = "Mark Student Attendence"
        '
        'ViewStudentAttendenceToolStripMenuItem1
        '
        Me.ViewStudentAttendenceToolStripMenuItem1.Name = "ViewStudentAttendenceToolStripMenuItem1"
        Me.ViewStudentAttendenceToolStripMenuItem1.Size = New System.Drawing.Size(209, 22)
        Me.ViewStudentAttendenceToolStripMenuItem1.Text = "View Student Attendence"
        '
        'FacultyMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 382)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FacultyMDI"
        Me.Text = "FacultyMDI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ManageAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarksheetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewMarksheetsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExamsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttendenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarkStudentAttendenceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarkStudentAttendenceToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewStudentAttendenceToolStripMenuItem1 As ToolStripMenuItem
End Class
