Public Class StudentMDI
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub



    Private Sub MarksheetToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Marksheet.Show()
        'Marksheet.TextBox1.Text = Form1.TextBox6.Text
    End Sub

    Private Sub ViewExamTimetableToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ViewTimeTable.Show()
    End Sub

    Private Sub FeeRecieptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeeRecieptToolStripMenuItem.Click
        FeeReciept.Show()
        FeeReciept.TextBox7.Text = Form1.TextBox6.Text
        FeeReciept.Button2.Visible = False
        FeeReciept.TextBox7.Enabled = False
    End Sub

    Private Sub MarksheetToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MarksheetToolStripMenuItem1.Click
        Marksheet.Show()
    End Sub

    Private Sub ExamsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExamsToolStripMenuItem.Click
        ViewTimeTable.Show()

        ViewTimeTable.Label5.Visible = True
        ViewTimeTable.TextBox33.Visible = True
        ViewTimeTable.Label6.Visible = True
        ViewTimeTable.TextBox34.Visible = True

    End Sub
End Class