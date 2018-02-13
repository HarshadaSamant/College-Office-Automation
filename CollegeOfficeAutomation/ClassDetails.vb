
Imports System.Data.OleDb
Public Class ClassDetails
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As OleDbDataReader
    Dim str As String
    Dim count As Integer
    Dim sem As String


    Private Sub ClassDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        cmd.CommandText = "Select Max(ClsID) from [ClassMaster]"

        Dim a As Integer = cmd.ExecuteScalar

        TextBox1.Text = a + 1
        If TextBox1.Text = "" Then
            Exit Sub
        End If

        adp = New OleDbDataAdapter("Select * from ClassMaster", con)
        adp.Fill(ds, "ClassMaster")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "ClassMaster"

        Me.adp.Fill(Me.ds)

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()
        If MsgBox("Do you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            If RadioButton3.Checked = True And RadioButton4.Checked = False Then
                sem = RadioButton3.Text
            ElseIf RadioButton4.Checked = True And RadioButton3.Checked = False Then
                sem = RadioButton4.Text
            End If
            str = "insert into ClassMaster values(" & CInt(TextBox1.Text) & ",' " & Trim(TextBox2.Text) & " ','" & Trim(ComboBox1.Text) & "' ,' " & Trim(sem) & "' , " & Trim(TextBox3.Text) & ")"
            cmd = New OleDbCommand(str, con)
            count = cmd.ExecuteNonQuery

            MessageBox.Show(count & "Class Details inserted")



            cmd.CommandType = CommandType.Text
            cmd.Connection = con
            cmd.CommandText = "Select Max (ClsID) from [ClassMaster]"

            Dim a As Integer = cmd.ExecuteScalar
            TextBox1.Text = a + 1
            TextBox2.Clear()
            TextBox3.Clear()
            ComboBox1.Text = ""
            TextBox2.Focus()

            ds.Clear()
            adp = New OleDbDataAdapter("Select * from ClassMaster", con)
            adp.Fill(ds, "ClassMaster")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "ClassMaster"
            DataGridView1.Refresh()
            DataGridView1.Show()



        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        cmd.CommandText = "Select Max (ClsID) from [ClassMaster]"

        Dim a As Integer = cmd.ExecuteScalar
        TextBox1.Text = a + 1
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.Text = ""
        TextBox2.Focus()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        ComboBox1.Text = DataGridView1.Item(2, i).Value
        TextBox3.Text = DataGridView1.Item(4, i).Value

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        If MsgBox("Do you want to update this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            con = New OleDbConnection("Provider= Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
            con.Open()

            cmd = New OleDbCommand("Update ClassMaster Set ClsName=' " & TextBox2.Text & "', CName='" & ComboBox1.Text & "', Semester='" & sem & "', NumberOfStudents=" & TextBox3.Text & " where ClsID= " & CInt(TextBox1.Text) & " ", con)
            count = cmd.ExecuteScalar

            MessageBox.Show(count & "Rows updated")


            ds.Clear()
            adp = New OleDbDataAdapter("Select * from ClassMaster", con)
            adp.Fill(ds, "ClassMaster")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "ClassMaster"
            DataGridView1.Refresh()
            DataGridView1.Show()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()

        If MsgBox("Do you want to delete this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            cmd = New OleDbCommand("Delete from ClassMaster where ClsID=" & TextBox1.Text, con)
            count = cmd.ExecuteNonQuery
            MessageBox.Show(count & "Rows Deleted")
            TextBox2.Clear()
            TextBox3.Clear()
            ComboBox1.Text = ""
            TextBox2.Focus()

            ds.Clear()
            adp = New OleDbDataAdapter("Select * from ClassMaster", con)
            adp.Fill(ds, "ClassMaster")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "ClassMaster"
            DataGridView1.Refresh()
            DataGridView1.Show()
            con.Close()

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()

        Dim cmd As String
        If (RadioButton1.Checked = False And RadioButton2.Checked = False) Then
            MsgBox("select the search pettern")
        End If



        If RadioButton1.Checked Then
            If TextBox1.Text = Nothing Then
                MsgBox("Please enter  Class ID to search")
                TextBox1.Focus()
            Else

                cmd = "select * from ClassMaster where ClsID= " & Val(TextBox1.Text)
                Dim adp As New OleDbDataAdapter(cmd, con)
                Dim dt As New DataTable
                adp.Fill(dt)
                If dt.Rows.Count = 0 Then
                    MsgBox("no records found.")
                Else
                    DataGridView1.DataSource = dt
                    Dim i As New Integer
                    i = DataGridView1.CurrentRow.Index
                    TextBox1.Text = DataGridView1.Item(0, i).Value
                    TextBox2.Text = DataGridView1.Item(1, i).Value
                    ComboBox1.Text = DataGridView1.Item(2, i).Value
                    sem = DataGridView1.Item(3, i).Value
                    TextBox3.Text = DataGridView1.Item(4, i).Value

                    MsgBox("record found")

                    TextBox2.Clear()
                    TextBox3.Clear()
                    ComboBox1.Text = ""

                    ds.Clear()
                    adp = New OleDbDataAdapter("Select * from ClassMaster", con)
                    adp.Fill(ds, "ClassMaster")
                    DataGridView1.DataSource = ds
                    DataGridView1.DataMember = "ClassMaster"
                    DataGridView1.Refresh()
                    DataGridView1.Show()

                    Dim cmd1 As New OleDbCommand
                    cmd1.CommandType = CommandType.Text
                    cmd1.Connection = con


                    cmd1.CommandText = "Select Max (ClsID) from [ClassMaster]"

                    Dim a As Integer = cmd1.ExecuteScalar
                    con.Close()
                    TextBox1.Text = a + 1
                    If TextBox1.Text = "" Then
                        Exit Sub
                    End If
                End If
            End If
        End If



        If RadioButton2.Checked Then
            If TextBox2.Text = Nothing Then
                MsgBox("Please enter Class Name to search")
                TextBox2.Focus()
            Else

                cmd = "select * from ClassMaster where ClsName=' " & CStr(TextBox2.Text) & "'"
                Dim adp As New OleDbDataAdapter(cmd, con)
                Dim dt As New DataTable
                adp.Fill(dt)
                If dt.Rows.Count = 0 Then
                    MsgBox("no records found.")
                Else

                    DataGridView1.DataSource = dt
                    Dim i As New Integer
                    i = DataGridView1.CurrentRow.Index
                    TextBox1.Text = DataGridView1.Item(0, i).Value
                    TextBox2.Text = DataGridView1.Item(1, i).Value
                    ComboBox1.Text = DataGridView1.Item(2, i).Value
                    sem = DataGridView1.Item(3, i).Value
                    TextBox3.Text = DataGridView1.Item(4, i).Value

                    MsgBox("record found")

                    ds.Clear()
                    adp = New OleDbDataAdapter("Select * from ClassMaster", con)
                    adp.Fill(ds, "ClassMaster")
                    DataGridView1.DataSource = ds
                    DataGridView1.DataMember = "ClassMaster"
                    DataGridView1.Refresh()
                    DataGridView1.Show()
                    Dim cmd1 As New OleDbCommand
                    cmd1.CommandType = CommandType.Text
                    cmd1.Connection = con


                    cmd1.CommandText = "Select Max (ClsID) from [ClassMaster]"

                    Dim a As Integer = cmd1.ExecuteScalar
                    con.Close()
                    TextBox1.Text = a + 1
                    If TextBox1.Text = "" Then
                        Exit Sub
                    End If


                    TextBox2.Clear()
                    TextBox3.Clear()
                    ComboBox1.Text = ""

                End If
            End If
        End If
    End Sub
End Class