Public Class AdminMDI

    Private Sub NewRegistrationToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        StudentInformation.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub NewRegistrationToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NewRegistrationToolStripMenuItem.Click
        StudentRegistration.Show()
    End Sub


    Private Sub CourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CourseToolStripMenuItem.Click
        CourseDetails.Show()
    End Sub

    Private Sub MarkFacultyAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkFacultyAttendanceToolStripMenuItem.Click
        FacultyAttendance.Show()
    End Sub

    Private Sub ViewStudentAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStudentAttendanceToolStripMenuItem.Click
        StudentAttendance.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        SubjectMaster.Show()
    End Sub

    Private Sub NewRegistrationToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles NewRegistrationToolStripMenuItem1.Click
        Faculty.Show()
    End Sub

    Private Sub UpdateProfileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpdateProfileToolStripMenuItem1.Click
        Form2.Show()
    End Sub

    Private Sub CoursesAndFeesDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeesDetailsToolStripMenuItem.Click
        FeeReciept.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        ClassDetails.Show()
    End Sub

    Private Sub ExamTimetableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExamTimetableToolStripMenuItem.Click
        ExamTimeTable.Show()
    End Sub

    Private Sub ViewExamTimetableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewExamTimetableToolStripMenuItem.Click
        ViewTimeTable.Show()
        ViewTimeTable.Label5.Visible = False
        ViewTimeTable.TextBox33.Visible = False
        ViewTimeTable.Label6.Visible = False
        ViewTimeTable.TextBox34.Visible = False
    End Sub
End Class