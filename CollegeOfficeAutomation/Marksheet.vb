Imports System.Data.OleDb
Public Class Marksheet
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As OleDbDataReader
    Dim str As String
    Dim count As Integer
    Private Sub Marksheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()
        Me.TextBox1.Text = Form1.TextBox6.Text

        GroupBox1.Visible = False

        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        cmd.CommandText = "Select SFirstName from StudentTable where ID=" & TextBox1.Text & ""
        Dim SFName As String = cmd.ExecuteScalar
        TextBox2.Text = SFName

        Dim cmd1 As New OleDbCommand("Select CName from StudentTable where ID=" & TextBox1.Text & "", con)
        Dim CName As String = cmd1.ExecuteScalar
        TextBox3.Text = CName

        Dim cmd2 As New OleDbCommand("Select SCourseYear from StudentTable where ID=" & TextBox1.Text & "", con)
        Dim clsName As String = cmd2.ExecuteScalar
        TextBox4.Text = clsName

        Dim cmd3 As New OleDbCommand("Select SubjectName1M from MarksheetTable where SID=" & TextBox1.Text & "", con)
        Dim sub1 As Integer = cmd3.ExecuteScalar
        TextBox6.Text = sub1

        Dim cmd4 As New OleDbCommand("Select SubjectName2M from MarksheetTable where SID=" & TextBox1.Text & "", con)
        Dim sub2 As Integer = cmd4.ExecuteScalar
        TextBox8.Text = sub2

        Dim cmd5 As New OleDbCommand("Select SubjectName3M from MarksheetTable where SID=" & TextBox1.Text & "", con)
        Dim sub3 As Integer = cmd5.ExecuteScalar
        TextBox11.Text = sub3

        Dim cmd6 As New OleDbCommand("Select SubjectName4M from MarksheetTable where SID=" & TextBox1.Text & "", con)
        Dim sub4 As Integer = cmd6.ExecuteScalar
        TextBox13.Text = sub4

        Dim cmd7 As New OleDbCommand("Select SubjectName5M from MarksheetTable where SID=" & TextBox1.Text & "", con)
        Dim sub5 As Integer = cmd7.ExecuteScalar
        TextBox14.Text = sub5

        Dim cmd8 As New OleDbCommand("Select SubjectName6M from MarksheetTable where SID=" & TextBox1.Text & "", con)
        Dim sub6 As Integer = cmd8.ExecuteScalar
        TextBox15.Text = sub6

        Dim cmd9 As New OleDbCommand("Select TotalMarks from MarksheetTable where SID=" & TextBox1.Text & "", con)
        Dim TMarks As Integer = cmd9.ExecuteScalar
        TextBox12.Text = TMarks

        Dim cmd10 As New OleDbCommand("Select MarksObtained from MarksheetTable where SID=" & TextBox1.Text & "", con)
        Dim MarksObt As Integer = cmd10.ExecuteScalar
        TextBox16.Text = MarksObt

        Dim cmd11 As New OleDbCommand("Select Percentage from MarksheetTable where SID=" & TextBox1.Text & "", con)
        Dim Per As Integer = cmd11.ExecuteScalar
        TextBox17.Text = Per
    End Sub

End Class