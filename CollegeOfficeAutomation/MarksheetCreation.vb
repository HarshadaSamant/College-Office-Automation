Imports System.Data.OleDb
Public Class MarksheetCreation
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As OleDbDataReader
    Dim a As String
    Dim b As Integer
    Dim str As String
    Dim count As Integer
    Dim sem As String
    Private Sub Marksheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()
        TextBox1.Text = Form1.TextBox4.Text

        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        cmd.CommandText = "select FacultyName from FacultyTable where ID=" & Trim(TextBox1.Text) & ""
        Dim a As String = cmd.ExecuteScalar
        TextBox2.Text = a


        adp = New OleDbDataAdapter("Select * from MarksheetTable", con)
        adp.Fill(ds, "MarksheetTable")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "MarksheetTable"

        Me.adp.Fill(Me.ds)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        ComboBox1.Text = DataGridView1.Item(2, i).Value
        TextBox4.Text = DataGridView1.Item(3, i).Value
        ComboBox2.Text = DataGridView1.Item(4, i).Value
        TextBox18.Text = DataGridView1.Item(5, i).Value
        TextBox5.Text = DataGridView1.Item(6, i).Value
        TextBox7.Text = DataGridView1.Item(7, i).Value
        TextBox9.Text = DataGridView1.Item(8, i).Value
        TextBox10.Text = DataGridView1.Item(9, i).Value
        TextBox6.Text = DataGridView1.Item(10, i).Value
        TextBox8.Text = DataGridView1.Item(11, i).Value
        TextBox11.Text = DataGridView1.Item(12, i).Value
        TextBox13.Text = DataGridView1.Item(13, i).Value
        TextBox14.Text = DataGridView1.Item(14, i).Value
        TextBox15.Text = DataGridView1.Item(15, i).Value
        TextBox12.Text = DataGridView1.Item(16, i).Value
        TextBox16.Text = DataGridView1.Item(17, i).Value
        TextBox17.Text = DataGridView1.Item(18, i).Value

    End Sub
    Private Sub ComboBox1_textchanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        Dim cmd As New OleDbCommand("Select CId from CourseTable where CName='" & ComboBox1.Text & "' ", con)
        Dim str As String = cmd.ExecuteScalar
        TextBox4.Text = str
    End Sub
    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles ComboBox1.DropDown
        Dim cmd As New OleDbCommand("Select CName from CourseTable", con)
        Dim adp As New OleDbDataAdapter(cmd)
        Dim table As New DataTable()
        adp.Fill(table)
        ComboBox1.DataSource = table
        ComboBox1.DisplayMember = "CName"
        ComboBox1.Text = ""
    End Sub

    Private Sub ComboBox2_textchanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
        Dim cmd As New OleDbCommand("Select ClsID from ClassMaster where ClsName='" & Trim(ComboBox2.Text) & "' ", con)
        Dim str As String = cmd.ExecuteScalar
        TextBox18.Text = Trim(str)
    End Sub
    Private Sub ComboBox2_DropDown(sender As Object, e As EventArgs) Handles ComboBox2.DropDown
        Dim cmd As New OleDbCommand("Select ClsName from ClassMaster", con)
        Dim adp As New OleDbDataAdapter(cmd)
        Dim table As New DataTable()
        adp.Fill(table)
        ComboBox2.DataSource = table
        ComboBox2.DisplayMember = "ClsName"
        ComboBox2.Text = ""
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = Nothing Then
            TextBox7.Text = Nothing
        Else
            Dim cmd As New OleDbCommand("Select SFirstName from StudentTable where ID=" & Trim(TextBox5.Text) & "", con)
            Dim str As String = cmd.ExecuteScalar
            TextBox7.Text = str
        End If
    End Sub
    Private Sub TextBox5_TextChanged2(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = Nothing Then
            TextBox9.Text = Nothing
        Else
            Dim cmd As New OleDbCommand("Select SMiddleName from StudentTable where ID=" & Trim(TextBox5.Text) & "", con)
            Dim str As String = cmd.ExecuteScalar
            TextBox9.Text = str
        End If
    End Sub
    Private Sub TextBox5_TextChanged3(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = Nothing Then
            TextBox10.Text = Nothing
        Else
            Dim cmd As New OleDbCommand("Select SLastName from StudentTable where ID=" & Trim(TextBox5.Text) & "", con)
            Dim str As String = cmd.ExecuteScalar
            TextBox10.Text = str
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        TextBox16.Text = Val(TextBox6.Text) + Val(TextBox8.Text) + Val(TextBox11.Text) + Val(TextBox13.Text) + Val(TextBox14.Text) + Val(TextBox15.Text)
        TextBox12.Text = 600


        TextBox17.Text = (Val(TextBox16.Text) / 600) * 100

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()

        If MsgBox("Do you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            If RadioButton3.Checked = True And RadioButton4.Checked = False Then
                sem = RadioButton3.Text
            ElseIf RadioButton4.Checked = True And RadioButton3.Checked = False Then
                sem = RadioButton4.Text
            End If
            str = "insert into MarksheetTable values(" & CInt(TextBox1.Text) & ",' " & Trim(TextBox2.Text) & " '," & Trim(TextBox4.Text) & " , '" & Trim(ComboBox1.Text) & " ' , " & Trim(TextBox18.Text) & ",' " & Trim(ComboBox2.Text) & " ' , " & Trim(TextBox5.Text) & " ,' " & LTrim(TextBox7.Text) & "' ,' " & Trim(TextBox9.Text) & " ',' " & Trim(TextBox10.Text) & "',' " & Trim(sem) & "' , " & Trim(TextBox6.Text) & " , " & Trim(TextBox8.Text) & " , " & Trim(TextBox11.Text) & " , " & Trim(TextBox13.Text) & " , " & Trim(TextBox14.Text) & " , " & Trim(TextBox15.Text) & " , " & Trim(TextBox12.Text) & " , " & Trim(TextBox16.Text) & " , " & Trim(TextBox17.Text) & ")"
            cmd = New OleDbCommand(str, con)
            count = cmd.ExecuteNonQuery



            ds.Clear()
            adp = New OleDbDataAdapter("Select * from MarksheetTable", con)
            adp.Fill(ds, "MarksheetTable")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "MarksheetTable"
            DataGridView1.Refresh()
            DataGridView1.Show()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        TextBox17.Clear()
        TextBox18.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        ds.Clear()
        adp = New OleDbDataAdapter("Select * from MarksheetTable", con)
        adp.Fill(ds, "MarksheetTable")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "MarksheetTable"
        DataGridView1.Refresh()
        DataGridView1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()

        Dim cmd As String
        If (RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton5.Checked = False And RadioButton6.Checked = False And RadioButton7.Checked = False) Then
            MsgBox("select the search pettern")
        End If

        If RadioButton1.Checked Then
            If TextBox7.Text = Nothing Then
                MsgBox("Please enter  Student Name to search")
                TextBox7.Focus()
            Else

                cmd = "select * from MarksheetTable where SFirstName= '" & Trim(TextBox7.Text) & "'"
                Dim adp As New OleDbDataAdapter(cmd, con)
                Dim dt As New DataTable
                adp.Fill(dt)
                If dt.Rows.Count = 0 Then
                    MsgBox("no records found.")
                Else
                    DataGridView1.DataSource = dt

                    MsgBox("record found")

                End If
            End If
        End If



        If RadioButton2.Checked Then
            If TextBox5.Text = Nothing Then
                MsgBox("Please enter Student ID to search")
                TextBox5.Focus()
            Else

                cmd = "select * from MarksheetTable where SID= " & Trim(TextBox5.Text) & ""
                Dim adp As New OleDbDataAdapter(cmd, con)
                Dim dt As New DataTable
                adp.Fill(dt)
                If dt.Rows.Count = 0 Then
                    MsgBox("no records found.")
                Else

                    DataGridView1.DataSource = dt

                    MsgBox("record found")

                End If
            End If
        End If

        If RadioButton5.Checked Then
            If ComboBox1.Text = Nothing Then
                MsgBox("Please enter Course Name to search")
                ComboBox1.Focus()
            Else

                cmd = "select * from MarksheetTable where CName=' " & Trim(ComboBox1.Text) & "'"
                Dim adp As New OleDbDataAdapter(cmd, con)
                Dim dt As New DataTable
                adp.Fill(dt)
                If dt.Rows.Count = 0 Then
                    MsgBox("no records found.")
                Else
                    DataGridView1.DataSource = dt
                    MsgBox("record found")
                End If
            End If
        End If

        If RadioButton6.Checked Then
            If ComboBox2.Text = Nothing Then
                MsgBox("Please enter Class Name to search")
                ComboBox2.Focus()
            Else

                cmd = "select * from MarksheetTable where ClsName=' " & Trim(ComboBox2.Text) & "'"
                Dim adp As New OleDbDataAdapter(cmd, con)
                Dim dt As New DataTable
                adp.Fill(dt)
                If dt.Rows.Count = 0 Then
                    MsgBox("no records found.")
                Else

                    DataGridView1.DataSource = dt

                    MsgBox("record found")
                End If
            End If
        End If

        If RadioButton7.Checked Then
            If RadioButton3.Checked = False And RadioButton4.Checked = False Then
                MsgBox("Please select Semester to search")

            Else

                cmd = "select * from MarksheetTable where Semester=' " & Trim(sem) & "'"
                Dim adp As New OleDbDataAdapter(cmd, con)
                Dim dt As New DataTable
                adp.Fill(dt)
                If dt.Rows.Count = 0 Then
                    MsgBox("no records found.")
                Else

                    DataGridView1.DataSource = dt

                    MsgBox("record found")
                End If
            End If
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If MsgBox("Do you want to update this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            con = New OleDbConnection("Provider= Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
            con.Open()
            cmd = New OleDbCommand("Update MarksheetTable Set CID=" & Trim(TextBox4.Text) & ", CName='" & Trim(ComboBox1.Text) & "', ClsID=" & Trim(TextBox18.Text) & ", ClsName='" & Trim(ComboBox2.Text) & "', SFirstName='" & Trim(TextBox7.Text) & "', SMiddleName='" & Trim(TextBox9.Text) & "', SLastName='" & Trim(TextBox10.Text) & "', SubjectName1M =" & Trim(TextBox6.Text) & ", SubjectName2M =" & Trim(TextBox8.Text) & ", SubjectName3M =" & Trim(TextBox11.Text) & ", SubjectName4M =" & Trim(TextBox13.Text) & ", SubjectName5M =" & Trim(TextBox14.Text) & ", SubjectName6M =" & Trim(TextBox15.Text) & ", TotalMarks =" & Trim(TextBox12.Text) & ", MarksObtained =" & Trim(TextBox16.Text) & ", Percentage =" & Trim(TextBox17.Text) & " where SID= " & CInt(TextBox5.Text) & " ", con)
            count = cmd.ExecuteScalar
            MessageBox.Show(count & "Rows updated")


            ds.Clear()
            adp = New OleDbDataAdapter("Select * from MarksheetTable", con)
            adp.Fill(ds, "MarksheetTable")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "MarksheetTable"
            DataGridView1.Refresh()
            DataGridView1.Show()
        End If

    End Sub


End Class