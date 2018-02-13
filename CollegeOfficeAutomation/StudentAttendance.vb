Imports System.Data.OleDb
Public Class StudentAttendance
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim adp1 As New OleDbDataAdapter

    Dim ds As New DataSet
    Dim dr As OleDbDataReader
    Dim bs As New BindingSource

    Dim str As String
    Dim count As Integer
    Private Sub StudentAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()

        textBox1.Text = Form1.TextBox4.Text

        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        cmd.CommandText = "select FacultyName from FacultyTable where ID=" & Trim(TextBox1.Text) & ""
        Dim a As String = cmd.ExecuteScalar
        TextBox2.Text = a

        adp1 = New OleDbDataAdapter("Select * from StudentAttendanceTable", con)
        adp1.Fill(ds, "StudentAttendanceTable")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "StudentAttendanceTable"

        Me.adp1.Fill(Me.ds)
    End Sub




    Private Sub ComboBox2_DropDown(sender As Object, e As EventArgs) Handles ComboBox2.DropDown
        Dim cmd As New OleDbCommand("Select FacultyClass from FacultyTable where ID=" & Trim(TextBox1.Text) & " ", con)
        Dim adp As New OleDbDataAdapter(cmd)
        Dim table As New DataTable()
        adp.Fill(table)
        ComboBox2.DataSource = table
        ComboBox2.DisplayMember = "FacultyClass"
        ComboBox2.Text = ""
    End Sub

    Private Sub ComboBox2_textchanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
        If ComboBox2.Text = Nothing Then
            TextBox5.Text = Nothing
        Else
            Dim cmd As New OleDbCommand("Select ClsID from ClassMaster where ClsName='" & ComboBox2.Text & "' ", con)
            Dim str As Integer = cmd.ExecuteScalar
            TextBox5.Text = str
        End If

    End Sub


    Private Sub ComboBox3_DropDown(sender As Object, e As EventArgs) Handles ComboBox3.DropDown
        Dim cmd As New OleDbCommand("Select SubName from CourseSubject where classid=" & Trim(TextBox5.Text) & " ", con)
        Dim adp As New OleDbDataAdapter(cmd)
        Dim table As New DataTable()
        adp.Fill(table)
        ComboBox3.DataSource = table
        ComboBox3.DisplayMember = "SubName"
        ComboBox3.Text = ""
    End Sub
    Private Sub ComboBox3_textchanged(sender As Object, e As EventArgs) Handles ComboBox3.TextChanged
        If ComboBox3.Text = Nothing Then
            TextBox4.Text = Nothing
        Else
            Dim cmd As New OleDbCommand("Select SubCode from CourseSubject where classid=" & TextBox5.Text & " ", con)
            Dim str As Integer = cmd.ExecuteScalar
            TextBox4.Text = str
        End If

    End Sub
    Private Sub textbox5_textchanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = Nothing Then
            TextBox3.Text = Nothing
        Else
            Dim cmd As New OleDbCommand("Select CName from ClassMaster where ClsID=" & TextBox5.Text & " ", con)
            Dim str As String = cmd.ExecuteScalar
            TextBox3.Text = str
        End If

    End Sub
    'Private Sub ComboBox3_DropDown(sender As Object, e As EventArgs) Handles ComboBox3.DropDown
    '    Dim cmd As New OleDbCommand("Select SubjectCode from SubjectTable", con)
    '    Dim adp As New OleDbDataAdapter(cmd)
    '    Dim tabl As New DataTable()
    '    adp.Fill(tabl)
    '    ComboBox3.DataSource = tabl
    '    ComboBox3.DisplayMember = "SubjectCode"
    '    ComboBox3.Text = ""
    'End Sub
    'Private Sub ComboBox4_LostFocus(sender As Object, e As EventArgs)
    '    Dim cmd As New OleDbCommand("Select SFirstName from StudentTable where SID=" & (ComboBox4.Text) & "", con)
    '    Dim str As String = cmd.ExecuteScalar
    '    TextBox5.Text = str
    'End Sub
    'Private Sub ComboBox3_LostFocus(sender As Object, e As EventArgs) Handles ComboBox3.LostFocus
    '    Dim cmd As New OleDbCommand("Select SubjectName from SubjectTable where SubjectCode=" & (ComboBox3.Text) & "", con)
    '    Dim str As String = cmd.ExecuteScalar
    '    TextBox4.Text = str
    'End Sub
    'Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
    '    If RadioButton1.Checked = True And RadioButton2.Checked = False Then
    '        TextBox6.Text = RadioButton1.Text
    '    End If
    'End Sub
    'Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
    '    If RadioButton2.Checked = True And RadioButton1.Checked = False Then
    '        TextBox6.Text = RadioButton2.Text
    '    End If
    'End Sub
    'Private Sub ComboBox1_LostFocus(sender As Object, e As EventArgs)
    '    Dim cmd As New OleDbCommand("Select FacultyName from FacultyTable where FID=" & (ComboBox1.Text) & "", con)
    '    Dim str As String = cmd.ExecuteScalar
    '    TextBox2.Text = str
    'End Sub
    'Private Sub ComboBox2_LostFocus(sender As Object, e As EventArgs) Handles ComboBox2.LostFocus
    '    Dim cmd As New OleDbCommand("Select Cname from CourseTable where CID=" & (ComboBox2.Text) & "", con)
    '    Dim str As String = cmd.ExecuteScalar
    '    TextBox3.Text = str
    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\HP\Desktop\collegeofficeautomation\CollegeOfficeAutomation\CollegeAutomation.mdb")
    '    con.Open()

    '    If MsgBox("Do you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
    '        str = "insert into StudentAttendanceTable values(" & (TextBox1.Text) & "," & CInt(ComboBox1.Text) & ",'" & Trim(TextBox2.Text) & "'," & CInt(ComboBox4.Text) & ",'" & Trim(TextBox5.Text) & " '," & CInt(ComboBox2.Text) & ",'" & Trim(TextBox3.Text) & "'," & CInt(ComboBox3.Text) & ",'" & Trim(TextBox4.Text) & "','" & DateTimePicker1.Text & "','" & Trim(TextBox6.Text) & "')"
    '        cmd = New OleDbCommand(str, con)
    '        count = cmd.ExecuteNonQuery
    '        MessageBox.Show("Record inserted")
    '    End If
    'End Sub




    'Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    '    Dim i As Integer
    '    i = DataGridView1.CurrentRow.Index
    '    TextBox1.Text = DataGridView1.Item(0, i).Value
    '    TextBox2.Text = DataGridView1.Item(1, i).Value
    '    TextBox3.Text = DataGridView1.Item(2, i).Value
    '    TextBox4.Text = DataGridView1.Item(3, i).Value
    '    TextBox5.Text = DataGridView1.Item(4, i).Value

    'End Sub

End Class