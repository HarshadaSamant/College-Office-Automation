Imports System.Data.OleDb

Public Class Form2
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim str As String
    Dim count As Integer
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet()
    Dim dt As New DataTable
    Dim bsource As New BindingSource
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()
        adp = New OleDbDataAdapter("Select  ID,FacultyName,FacultySurname,FacultyAddress,FacultyPhoneNo,FacultyEmailId from FacultyTable", con)
        adp.Fill(ds, "FacultyTable")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "FacultyTable"

        Me.adp.Fill(Me.ds)
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Label6.Text = DataGridView1.Item(0, i).Value
        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox3.Text = DataGridView1.Item(1, i).Value
        TextBox4.Text = DataGridView1.Item(2, i).Value
        RichTextBox1.Text = DataGridView1.Item(3, i).Value
        TextBox5.Text = DataGridView1.Item(4, i).Value
        RichTextBox2.Text = DataGridView1.Item(5, i).Value

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()
        cmd = New OleDbCommand("Update FacultyTable Set FacultyName=' " & TextBox3.Text & "',FacultySurname=' " & TextBox4.Text & " ', FacultyAddress=' " & RichTextBox1.Text & "', FacultyPhoneNo='" & TextBox5.Text & "',FacultyEmailId=' " & RichTextBox2.Text & "' where ID= " & TextBox1.Text & " ", con)
        count = cmd.ExecuteScalar

        If MsgBox("Do you want to update this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            MessageBox.Show("Rows updated")


            ds.Clear()
            adp = New OleDbDataAdapter("Select * from FacultyTable", con)
            adp.Fill(ds, "FacultyTable")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "FacultyTable"
            DataGridView1.Refresh()
            DataGridView1.Show()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()
        ds.Clear()
        adp = New OleDbDataAdapter("Select ID,FacultyName,FacultySurname,FacultyAddress,FacultyPhoneNo,FacultyEmailId from FacultyTable", con)
        adp.Fill(ds, "FacultyTable")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "FacultyTable"
        DataGridView1.Refresh()
        Me.adp.Fill(Me.ds)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        Label6.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()
        Dim cmd As String
        If (RadioButton1.Checked = False And RadioButton2.Checked = False) Then
            MsgBox("select the search pettern")
        End If



        If RadioButton1.Checked Then
            If TextBox1.Text = Nothing Then
                MsgBox("Please enter  Faculty ID to search")
                TextBox1.Focus()
            Else

                cmd = "Select  ID,FacultyName,FacultySurname,FacultyAddress,FacultyPhoneNo,FacultyEmailId from FacultyTable where ID= " & Val(TextBox1.Text)
                Dim adp As New OleDbDataAdapter(cmd, con)
                Dim dt As New DataTable
                adp.Fill(dt)
                If dt.Rows.Count = 0 Then
                    MsgBox("no records found.")
                Else
                    DataGridView1.DataSource = dt
                    Dim i As Integer
                    i = DataGridView1.CurrentRow.Index
                    Me.Label6.Text = DataGridView1.Item(0, i).Value

                    Me.TextBox3.Text = DataGridView1.Item(1, i).Value
                    Me.TextBox4.Text = DataGridView1.Item(2, i).Value
                    Me.RichTextBox1.Text = DataGridView1.Item(3, i).Value
                    Me.TextBox5.Text = DataGridView1.Item(4, i).Value
                    Me.RichTextBox2.Text = DataGridView1.Item(5, i).Value
                    MsgBox("record found")

                    ds.Clear()
                    adp = New OleDbDataAdapter("Select  ID,FacultyName,FacultySurname,FacultyAddress,FacultyPhoneNo,FacultyEmailId from FacultyTable", con)
                    adp.Fill(ds, "FacultyTable")
                    DataGridView1.DataSource = ds
                    DataGridView1.DataMember = "FacultyTable"
                    DataGridView1.Refresh()
                    DataGridView1.Show()

                    con.Close()


                End If
            End If
        End If



        If RadioButton2.Checked Then
            If TextBox2.Text = Nothing Then
                MsgBox("Please enter Faculty Name to search")
                TextBox2.Focus()
            Else

                cmd = "Select  ID,FacultyName,FacultySurname,FacultyAddress,FacultyPhoneNo,FacultyEmailId from FacultyTable where FacultyName=' " & Trim(TextBox2.Text) & "'"
                Dim adp As New OleDbDataAdapter(cmd, con)
                Dim dt As New DataTable
                adp.Fill(dt)
                If dt.Rows.Count = 0 Then
                    MsgBox("no records found.")
                Else

                    DataGridView1.DataSource = dt
                    Dim i As Integer
                    i = DataGridView1.CurrentRow.Index
                    Me.Label6.Text = DataGridView1.Item(0, i).Value

                    Me.TextBox3.Text = DataGridView1.Item(1, i).Value
                    Me.TextBox4.Text = DataGridView1.Item(2, i).Value
                    Me.RichTextBox1.Text = DataGridView1.Item(3, i).Value
                    Me.TextBox5.Text = DataGridView1.Item(4, i).Value
                    Me.RichTextBox2.Text = DataGridView1.Item(5, i).Value


                    MsgBox("record found")

                    ds.Clear()
                    adp = New OleDbDataAdapter("Select ID,FacultyName,FacultySurname,FacultyAddress,FacultyPhoneNo,FacultyEmailId from FacultyTable", con)
                    adp.Fill(ds, "FacultyTable")
                    DataGridView1.DataSource = ds
                    DataGridView1.DataMember = "FacultyTable"
                    DataGridView1.Refresh()
                    DataGridView1.Show()

                    con.Close()
                End If
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()

        If MsgBox("Do you want to delete this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            cmd = New OleDbCommand("Delete from FacultyTable where ID=" & TextBox1.Text, con)
            count = cmd.ExecuteNonQuery
            MessageBox.Show(count & "Rows Deleted")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            RichTextBox1.Text = ""
            RichTextBox2.Text = ""
            Label6.Text = ""
            TextBox2.Focus()

            ds.Clear()
            adp = New OleDbDataAdapter("Select * from FacultyTable", con)
            adp.Fill(ds, "FacultyTable")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "FacultyTable"
            DataGridView1.Refresh()
            DataGridView1.Show()
            con.Close()

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        AdminMDI.Show()
    End Sub
End Class