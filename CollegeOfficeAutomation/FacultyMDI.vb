Public Class FacultyMDI
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click
        MarksheetCreation.Show()
    End Sub

    Private Sub ExamsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExamsToolStripMenuItem.Click
        ViewTimeTable.Show()
        ViewTimeTable.Label5.Visible = False
        ViewTimeTable.TextBox33.Visible = False
        ViewTimeTable.Label6.Visible = False
        ViewTimeTable.TextBox34.Visible = False
    End Sub

    Private Sub ViewMarksheetsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMarksheetsToolStripMenuItem.Click
        Marksheet.Show()
    End Sub
    Private Sub MarkStudentAttendenceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MarkStudentAttendenceToolStripMenuItem1.Click
        StudentAttendance.Show()
    End Sub
End Class