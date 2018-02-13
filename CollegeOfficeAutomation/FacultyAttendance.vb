Imports System.Data.OleDb
Public Class FacultyAttendance
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As OleDbDataReader

    Dim str As String
    Dim count As Integer

    'for fetching facultyid from facultytable in combobox2
    Dim cmd1 As New OleDbCommand
    Dim adp1 As New OleDbDataAdapter

    Private Sub FacultyAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Hide()
        AdminMDI.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()
        If MsgBox("Do you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            str = "insert into FacultyAttendanceTable values(" & CInt(ComboBox1.Text) & "," & CInt(ComboBox2.Text) & " ,' " & Trim(TextBox1.Text) & " ',' " & (DateTimePicker1.Text) & " ',' " & Trim(TextBox2.Text) & " ')"
            cmd = New OleDbCommand(str, con)
            count = cmd.ExecuteNonQuery

            MessageBox.Show("Record inserted")

            TextBox1.Text = ""
            TextBox2.Text = ""


        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True And RadioButton2.Checked = False Then
            TextBox2.Text = RadioButton1.Text
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True And RadioButton1.Checked = False Then
            TextBox2.Text = RadioButton2.Text
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles ComboBox1.DropDown
        'Filling values of adminid to combobox1

        Dim cmd As New OleDbCommand("Select AdminId from AdminLogin", con)
        Dim adp As New OleDbDataAdapter(cmd)
        Dim table As New DataTable()
        adp.Fill(table)
        ComboBox1.DataSource = table
        ComboBox1.DisplayMember = "AdminId"
        ComboBox1.Text = ""
    End Sub

    Private Sub ComboBox2_DropDown(sender As Object, e As EventArgs) Handles ComboBox2.DropDown
        'Filling values of facultyId to combobox2
        Dim cmd As New OleDbCommand("Select FID from FacultyTable", con)
        Dim adp As New OleDbDataAdapter(cmd)
        Dim table As New DataTable()
        adp.Fill(table)
        ComboBox2.DataSource = table
        ComboBox2.DisplayMember = "FID"
        ComboBox2.Text = ""
    End Sub

    Private Sub ComboBox2_LostFocus(sender As Object, e As EventArgs) Handles ComboBox2.LostFocus
        Dim cmd As New OleDbCommand("Select FacultyName from FacultyTable where FID=" & (ComboBox2.Text) & "", con)
        Dim str As String = cmd.ExecuteScalar
        TextBox1.Text = str
    End Sub


End Class