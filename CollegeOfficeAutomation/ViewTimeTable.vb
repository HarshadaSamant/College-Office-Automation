Imports System.Data.OleDb
Public Class ViewTimeTable
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand

    Dim str As String
    Dim count As Integer

    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As OleDbDataReader
    Private Sub ViewTimeTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()


        If TextBox33.Visible = True Then
            TextBox33.Text = Form1.TextBox6.Text

            '    Dim cmd As New OleDbCommand("Select SFirstName from StudentTable where ID=" & TextBox33.Text & "", con)
            '    Dim SFName As String = cmd.ExecuteScalar
            '    TextBox34.Text = SFName

            '    Dim cmd1 As New OleDbCommand("Select CName from StudentTable where ID=" & TextBox33.Text & "", con)
            '    Dim CName As String = cmd1.ExecuteScalar
            '    ComboBox2.Text = CName

            'ElseIf TextBox33.Visible = False Then


            '    Dim cmd As New OleDbCommand("Select CName from CourseTable", con)
            '    Dim adp As New OleDbDataAdapter(cmd)
            '    Dim table As New DataTable()
            '    adp.Fill(table)
            '    ComboBox2.DataSource = table
            '    ComboBox2.DisplayMember = "CName"
            '    ComboBox2.Text = "" 
        End If
    End Sub
    Private Sub ComboBox2_textchanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
        Dim cmd As New OleDbCommand("Select CId from CourseTable where CName='" & ComboBox2.Text & "' ", con)
        Dim str As String = cmd.ExecuteScalar
        TextBox31.Text = str
    End Sub
    Private Sub ComboBox2_DropDown(sender As Object, e As EventArgs) Handles ComboBox2.DropDown

        Dim cmd As New OleDbCommand("Select CName from CourseTable", con)
            Dim adp As New OleDbDataAdapter(cmd)
        Dim table As New DataTable()
        adp.Fill(table)
        ComboBox2.DataSource = table
        ComboBox2.DisplayMember = "CName"
            ComboBox2.Text = ""

    End Sub

    Private Sub ComboBox1_textchanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        Dim cmd As New OleDbCommand("Select ClsID from ClassMaster where ClsName='" & Trim(ComboBox1.Text) & "' ", con)
        Dim str As String = cmd.ExecuteScalar
        TextBox32.Text = Trim(str)
    End Sub
    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles ComboBox1.DropDown
        Dim cmd As New OleDbCommand("Select ClsName from ClassMaster where CName='" & Trim(ComboBox2.Text) & "' ", con)
        Dim adp As New OleDbDataAdapter(cmd)
        Dim table As New DataTable()
        adp.Fill(table)
        ComboBox1.DataSource = table
        ComboBox1.DisplayMember = "ClsName"
        ComboBox1.Text = ""
    End Sub

    Private Sub TextBox32_TextChanged(sender As Object, e As EventArgs) Handles TextBox32.TextChanged
        'Dim cmd As New OleDbCommand
        'cmd.CommandType = CommandType.Text
        'cmd.Connection = con
        'cmd.CommandText = "Select ExamDate from ExamTimeTable where ClsID=" & TextBox32.Text & ""
        'Dim edate As String = cmd.ExecuteScalar
        'TextBox1.Text = edate

        Dim cmd As New OleDbCommand("Select ExamDate from ExamTimeTable where ClsID=" & TextBox32.Text & "", con)
        Dim edate As String = cmd.ExecuteScalar
        TextBox1.Text = edate

        Dim cmd1 As New OleDbCommand("Select ExamStartTime from ExamTimeTable where ClsID=" & TextBox32.Text & "", con)
        Dim estime As Integer = cmd1.ExecuteScalar
        TextBox2.Text = estime

        Dim cmd2 As New OleDbCommand("Select ExamEndTime from ExamTimeTable where ClsID=" & TextBox32.Text & "", con)
        Dim eetime As Integer = cmd2.ExecuteScalar
        TextBox3.Text = eetime

        Dim cmd3 As New OleDbCommand("Select SubName from ExamTimeTable where ClsID=" & TextBox32.Text & "", con)
        Dim sname As String = cmd1.ExecuteScalar
        TextBox4.Text = estime

        Dim cmd4 As New OleDbCommand("Select SubCode from ExamTimeTable where ClsID=" & TextBox32.Text & "", con)
        Dim scode As Integer = cmd2.ExecuteScalar
        TextBox5.Text = eetime
    End Sub
End Class