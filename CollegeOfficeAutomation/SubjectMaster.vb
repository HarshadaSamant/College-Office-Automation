Imports System.Data.OleDb
Public Class SubjectMaster
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand

    Dim str As String
    Dim count As Integer

    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As OleDbDataReader
    Private Sub SubjectMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()
        adp = New OleDbDataAdapter("Select  SubjectCode,SubjectName from SubjectTable", con)
        adp.Fill(ds, "SubjectTable")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "SubjectTable"

        Me.adp.Fill(Me.ds)


        'Dim cmd As New OleDbCommand("Select SubjectName from SubjectTable ", con)
        'Dim adp1 As New OleDbDataAdapter(cmd)
        'Dim table As New DataTable()
        'adp.Fill(table)
        'ComboBox1.DataSource = table
        'ComboBox1.DisplayMember = "SubjectName"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        cmd.CommandText = "Select Max (SubjectCode) from [SubjectTable]"

        Dim a As Integer = cmd.ExecuteScalar

        TextBox1.Text = a + 1
        If TextBox1.Text = "" Then
            Exit Sub
        End If
    End Sub
    Private Sub ComboBox1_lostfocus(sender As Object, e As EventArgs) Handles ComboBox1.LostFocus
        Dim cmd As New OleDbCommand("Select SubjectName from SubjectTable where SubjectCode=" & (ComboBox1.Text) & " ", con)
        Dim str As String = cmd.ExecuteScalar
        TextBox2.Text = str
    End Sub
    Private Sub ComboBox1_DropDown(sender As Object, e As EventArgs) Handles ComboBox1.DropDown
        Dim cmd As New OleDbCommand("Select SubjectCode from SubjectTable", con)
        Dim adp As New OleDbDataAdapter(cmd)
        Dim table As New DataTable()
        adp.Fill(table)
        ComboBox1.DataSource = table
        ComboBox1.DisplayMember = "SubjectCode"
        ComboBox1.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()

        If MsgBox("Do you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            str = "insert into SubjectTable values(" & CInt(TextBox1.Text) & ",' " & Trim(TextBox2.Text) & " ')"
            cmd = New OleDbCommand(str, con)
            count = cmd.ExecuteNonQuery
            MessageBox.Show("Record inserted")

        End If
        ds.Clear()
        adp = New OleDbDataAdapter("Select  SubjectCode,SubjectName from SubjectTable", con)
        adp.Fill(ds, "SubjectTable")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "SubjectTable"

        adp.Fill(ds)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Hide()
        AdminMDI.Show()
    End Sub


End Class