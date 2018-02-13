Imports System.Data.OleDb
Public Class FeeReciept
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim str As String
    Dim count As Integer
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet()
    Dim dt As New DataTable
    Dim bsource As New BindingSource

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()

        Dim cmd As String


        If TextBox7.Text = Nothing Then
            MsgBox("Please enter  Student ID to search")
            TextBox7.Focus()
        Else

            cmd = "select * from FeeDetails where Sid= " & Val(TextBox7.Text)
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
                Me.TextBox7.Text = DataGridView1.Item(1, i).Value
                Me.TextBox2.Text = DataGridView1.Item(2, i).Value
                Me.TextBox3.Text = DataGridView1.Item(3, i).Value
                Me.TextBox4.Text = DataGridView1.Item(4, i).Value
                Me.TextBox5.Text = DataGridView1.Item(5, i).Value
                Me.TextBox6.Text = DataGridView1.Item(6, i).Value
                Me.TextBox8.Text = DataGridView1.Item(12, i).Value
                Me.TextBox9.Text = DataGridView1.Item(11, i).Value
                Me.TextBox11.Text = DataGridView1.Item(9, i).Value
                Me.TextBox12.Text = DataGridView1.Item(10, i).Value



                MsgBox("record found")

            End If
                End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        DataGridView1.DataSource = Nothing

    End Sub


End Class