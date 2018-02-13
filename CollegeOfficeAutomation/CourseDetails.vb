Imports System.Data.OleDb
Public Class CourseDetails
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim str As String
    Dim count As Integer
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet()
    Dim dt As New DataTable
    Dim bsource As New BindingSource
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()


        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        cmd.CommandText = "Select Max (CId) from [CourseTable]"
        Dim a As Integer = cmd.ExecuteScalar
        con.Close()
        TextBox1.Text = a + 1
        If TextBox1.Text = "" Then
            Exit Sub
        End If

        adp = New OleDbDataAdapter("Select * from CourseTable", con)
        adp.Fill(ds, "CourseTable")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "CourseTable"

        Me.adp.Fill(Me.ds)



    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()
        If MsgBox("Do you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            str = "insert into CourseTable values(" & CInt(TextBox1.Text) & ",' " & Trim(TextBox2.Text) & " '," & Trim(TextBox3.Text) & " , " & Trim(TextBox4.Text) & " , " & Trim(TextBox5.Text) & ")"
            cmd = New OleDbCommand(str, con)
            count = cmd.ExecuteNonQuery

            MessageBox.Show(count & "Rows inserted")


            StudentRegistration.scname.Items.Add(TextBox2.Text)
            cmd.CommandType = CommandType.Text
            cmd.Connection = con
            cmd.CommandText = "Select Max (CId) from [CourseTable]"

            Dim a As Integer = cmd.ExecuteScalar
            TextBox1.Text = a + 1
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()


            TextBox2.Focus()

            ds.Clear()
            adp = New OleDbDataAdapter("Select * from CourseTable", con)
            adp.Fill(ds, "CourseTable")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "CourseTable"
            DataGridView1.Refresh()
            DataGridView1.Show()



        End If
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Me.TextBox1.Text = DataGridView1.Item(0, i).Value
        Me.TextBox2.Text = DataGridView1.Item(1, i).Value
        Me.TextBox3.Text = DataGridView1.Item(2, i).Value
        Me.TextBox4.Text = DataGridView1.Item(3, i).Value
        Me.TextBox5.Text = DataGridView1.Item(4, i).Value


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()

        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        cmd.CommandText = "Select Max (CId) from [CourseTable]"

        Dim a As Integer = cmd.ExecuteScalar
        TextBox1.Text = a + 1
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()


        TextBox2.Focus()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        con = New OleDbConnection("Provider= Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()
        cmd = New OleDbCommand("Update CourseTable Set CName=' " & TextBox2.Text & "', CDuration=" & TextBox3.Text & ", CSemesters=" & TextBox4.Text & ", CTFees=" & TextBox5.Text & " where CId= " & CInt(TextBox1.Text) & " ", con)
        count = cmd.ExecuteScalar


        If MsgBox("Do you want to update this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            MessageBox.Show(count & "Rows updated")


            ds.Clear()
            adp = New OleDbDataAdapter("Select * from CourseTable", con)
            adp.Fill(ds, "CourseTable")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "CourseTable"
            DataGridView1.Refresh()
            DataGridView1.Show()

        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        cmd.CommandText = "Select Max (CId) from [CourseTable]"

        Dim a As Integer = cmd.ExecuteScalar
        TextBox1.Text = a + 1
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()


        TextBox2.Focus()


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
                MsgBox("Please enter  Course ID to search")
                TextBox1.Focus()
            Else

                cmd = "select * from CourseTable where CId= " & Val(TextBox1.Text)
                Dim adp As New OleDbDataAdapter(cmd, con)
                Dim dt As New DataTable
                adp.Fill(dt)
                If dt.Rows.Count = 0 Then
                    MsgBox("no records found.")
                Else
                    DataGridView1.DataSource = dt
                    Dim i As New Integer
                    i = DataGridView1.CurrentRow.Index
                    Me.TextBox1.Text = DataGridView1.Item(0, i).Value
                    Me.TextBox2.Text = DataGridView1.Item(1, i).Value
                    Me.TextBox3.Text = DataGridView1.Item(2, i).Value
                    Me.TextBox4.Text = DataGridView1.Item(3, i).Value
                    Me.TextBox5.Text = DataGridView1.Item(4, i).Value


                    MsgBox("record found")
                    'TextBox2.Clear()
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()
                    TextBox5.Clear()

                    ds.Clear()
                    adp = New OleDbDataAdapter("Select * from CourseTable", con)
                    adp.Fill(ds, "CourseTable")
                    DataGridView1.DataSource = ds
                    DataGridView1.DataMember = "CourseTable"
                    DataGridView1.Refresh()
                    DataGridView1.Show()
                    ' con.Close()
                    Dim cmd1 As New OleDbCommand
                    cmd1.CommandType = CommandType.Text
                    cmd1.Connection = con


                    cmd1.CommandText = "Select Max (CId) from [CourseTable]"

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
                MsgBox("Please enter Course Name to search")
                TextBox2.Focus()
            Else

                cmd = "select * from CourseTable where CName=' " & CStr(TextBox2.Text) & "'"
                Dim adp As New OleDbDataAdapter(cmd, con)
                Dim dt As New DataTable
                adp.Fill(dt)
                If dt.Rows.Count = 0 Then
                    MsgBox("no records found.")
                Else

                    DataGridView1.DataSource = dt
                    Dim i As New Integer
                    i = DataGridView1.CurrentRow.Index
                    Me.TextBox1.Text = DataGridView1.Item(0, i).Value
                    Me.TextBox2.Text = DataGridView1.Item(1, i).Value
                    Me.TextBox3.Text = DataGridView1.Item(2, i).Value
                    Me.TextBox4.Text = DataGridView1.Item(3, i).Value
                    Me.TextBox5.Text = DataGridView1.Item(4, i).Value


                    MsgBox("record found")

                    ds.Clear()
                    adp = New OleDbDataAdapter("Select * from CourseTable", con)
                    adp.Fill(ds, "CourseTable")
                    DataGridView1.DataSource = ds
                    DataGridView1.DataMember = "CourseTable"
                    DataGridView1.Refresh()
                    DataGridView1.Show()
                    Dim cmd1 As New OleDbCommand
                    cmd1.CommandType = CommandType.Text
                    cmd1.Connection = con


                    cmd1.CommandText = "Select Max (CId) from [CourseTable]"

                    Dim a As Integer = cmd1.ExecuteScalar
                    con.Close()
                    TextBox1.Text = a + 1
                    If TextBox1.Text = "" Then
                        Exit Sub
                    End If


                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()
                    TextBox5.Clear()

                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()

        If MsgBox("Do you want to delete this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            cmd = New OleDbCommand("Delete from CourseTable where CId=" & TextBox1.Text, con)
            count = cmd.ExecuteNonQuery
            MessageBox.Show(count & "Rows Deleted")
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()


            TextBox2.Focus()

            ds.Clear()
            adp = New OleDbDataAdapter("Select * from CourseTable", con)
            adp.Fill(ds, "CourseTable")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "CourseTable"
            DataGridView1.Refresh()
            DataGridView1.Show()
            con.Close()

        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = Nothing Then
            TextBox4.Text = Nothing
        Else
            Dim a As Integer = TextBox3.Text
            TextBox4.Text = a * 2
        End If

    End Sub


End Class