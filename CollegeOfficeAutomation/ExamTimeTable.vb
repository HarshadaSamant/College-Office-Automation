Imports System.Data.OleDb
Public Class ExamTimeTable
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand

    Dim str As String
    Dim count As Integer

    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As OleDbDataReader

    Private Sub ComboBox2_DropDown(sender As Object, e As EventArgs) Handles ComboBox2.DropDown
        Dim cmd As New OleDbCommand("Select SubjectCode from SubjectTable", con)
        Dim adp As New OleDbDataAdapter(cmd)
        Dim table As New DataTable()
        adp.Fill(table)
        ComboBox2.DataSource = table
        ComboBox2.DisplayMember = "SubjectCode"
        ComboBox2.Text = ""
    End Sub

    Private Sub ComboBox2_LostFocus(sender As Object, e As EventArgs) Handles ComboBox2.LostFocus
        Dim cmd As New OleDbCommand("Select SubjectName from SubjectTable where SubjectCode=" & (ComboBox2.Text) & " ", con)
        Dim str As String = cmd.ExecuteScalar
        TextBox3.Text = str
    End Sub

    Private Sub ExamTimeTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()
        TextBox34.Focus()
    End Sub

    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles ComboBox1.DropDown
        Dim cmd As New OleDbCommand("Select CId from CourseTable", con)
        Dim adp As New OleDbDataAdapter(cmd)
        Dim tabl As New DataTable()
        adp.Fill(tabl)
        ComboBox1.DataSource = tabl
        ComboBox1.DisplayMember = "CId"
        ComboBox1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()


        'Fetching Values from grpbx1 to an grpbx2
        If TextBox34.Text = 1 Then
            TextBox8.Focus()
            TextBox8.Text = DateTimePicker1.Text
            TextBox7.Text = ComboBox2.Text
            TextBox6.Text = TextBox3.Text
            TextBox5.Text = TextBox1.Text
            TextBox4.Text = TextBox2.Text
            If MsgBox("Do you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                str = "insert into ExamTimeTable values(" & CInt(ComboBox1.Text) & ",'" & Trim(TextBox8.Text) & "','" & Trim(TextBox7.Text) & "','" & Trim(TextBox6.Text) & "','" & Trim(TextBox5.Text) & "','" & Trim(TextBox4.Text) & "')"
                cmd = New OleDbCommand(str, con)
                count = cmd.ExecuteNonQuery
                MessageBox.Show("Data Entered")
            End If
            GroupBox2.Enabled = False
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox34.Text = ""


            'Fetching Values from grpbx1 to an grpbx3
        ElseIf TextBox34.Text = 2 Then
            TextBox13.Focus()
            TextBox13.Text = DateTimePicker1.Text
            TextBox12.Text = ComboBox2.Text
            TextBox11.Text = TextBox3.Text
            TextBox10.Text = TextBox1.Text
            TextBox9.Text = TextBox2.Text
            If MsgBox("Do you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                str = "insert into ExamTimeTable values(" & CInt(ComboBox1.Text) & ",'" & Trim(TextBox13.Text) & "','" & Trim(TextBox12.Text) & "','" & Trim(TextBox11.Text) & "','" & Trim(TextBox10.Text) & "','" & Trim(TextBox9.Text) & "')"
                cmd = New OleDbCommand(str, con)
                count = cmd.ExecuteNonQuery
                MessageBox.Show("Data Entered")
            End If
            GroupBox3.Enabled = False
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox34.Text = ""


            'Fetching Values from grpbx1 to an grpbx4
        ElseIf TextBox34.Text = 3 Then
            TextBox18.Focus()
            TextBox18.Text = DateTimePicker1.Text
            TextBox17.Text = ComboBox2.Text
            TextBox16.Text = TextBox3.Text
            TextBox15.Text = TextBox1.Text
            TextBox14.Text = TextBox2.Text
            If MsgBox("Do you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                str = "insert into ExamTimeTable values(" & CInt(ComboBox1.Text) & ",'" & Trim(TextBox18.Text) & "','" & Trim(TextBox17.Text) & "','" & Trim(TextBox16.Text) & "','" & Trim(TextBox15.Text) & "','" & Trim(TextBox14.Text) & "')"
                cmd = New OleDbCommand(str, con)
                count = cmd.ExecuteNonQuery
                MessageBox.Show("Data Entered")
            End If
            GroupBox4.Enabled = False
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox34.Text = ""


            'Fetching Values from grpbx1 to an grpbx5
        ElseIf TextBox34.Text = 4 Then
            TextBox23.Focus()
            TextBox23.Text = DateTimePicker1.Text
            TextBox22.Text = ComboBox2.Text
            TextBox21.Text = TextBox3.Text
            TextBox20.Text = TextBox1.Text
            TextBox19.Text = TextBox2.Text
            If MsgBox("Do you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                str = "insert into ExamTimeTable values(" & CInt(ComboBox1.Text) & ",'" & Trim(TextBox23.Text) & "','" & Trim(TextBox22.Text) & "','" & Trim(TextBox21.Text) & "','" & Trim(TextBox20.Text) & "','" & Trim(TextBox4.Text) & "')"
                cmd = New OleDbCommand(str, con)
                count = cmd.ExecuteNonQuery
                MessageBox.Show("Data Entered")
            End If
            GroupBox5.Enabled = False
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox34.Text = ""


            'Fetching Values from grpbx1 to an grpbx6
        ElseIf TextBox34.Text = 5 Then
            TextBox28.Focus()
            TextBox28.Text = DateTimePicker1.Text
            TextBox27.Text = ComboBox2.Text
            TextBox26.Text = TextBox3.Text
            TextBox25.Text = TextBox1.Text
            TextBox24.Text = TextBox2.Text
            If MsgBox("Do you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                str = "insert into ExamTimeTable values(" & CInt(ComboBox1.Text) & ",'" & Trim(TextBox28.Text) & "','" & Trim(TextBox27.Text) & "','" & Trim(TextBox26.Text) & "','" & Trim(TextBox25.Text) & "','" & Trim(TextBox24.Text) & "')"
                cmd = New OleDbCommand(str, con)
                count = cmd.ExecuteNonQuery
                MessageBox.Show("Data Entered")
            End If
            GroupBox6.Enabled = False
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox34.Text = ""


            'Fetching Values from grpbx1 to an grpbx7
        ElseIf TextBox34.Text = 6 Then
            TextBox33.Focus()
            TextBox33.Text = DateTimePicker1.Text
            TextBox32.Text = ComboBox2.Text
            TextBox31.Text = TextBox3.Text
            TextBox30.Text = TextBox1.Text
            TextBox29.Text = TextBox2.Text
            If MsgBox("Do you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                str = "insert into ExamTimeTable values(" & CInt(ComboBox1.Text) & ",'" & Trim(TextBox33.Text) & "','" & Trim(TextBox32.Text) & "','" & Trim(TextBox31.Text) & "','" & Trim(TextBox30.Text) & "','" & Trim(TextBox29.Text) & "')"
                cmd = New OleDbCommand(str, con)
                count = cmd.ExecuteNonQuery
                MessageBox.Show("Data Entered")
            End If
            GroupBox7.Enabled = False
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox34.Text = ""

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Clearing fields of grpbx 1
        TextBox34.Text = ""
        ComboBox1.Text = ""
        DateTimePicker1.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Do you want to Exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Hide()
            AdminMDI.Show()
        End If
    End Sub
End Class