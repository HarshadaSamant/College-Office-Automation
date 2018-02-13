Imports System.Data.OleDb
Public Class Form1
    Dim con As OleDbConnection
    Dim daLogin As OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()


        If ComboBox1.Text = Nothing Then
            MessageBox.Show("Please Select User Type First")
            ComboBox1.Focus()

        ElseIf TextBox1.Text = Nothing Then
            MsgBox("Please enter User ID")
            TextBox1.Focus()

        ElseIf TextBox2.Text = Nothing Then
            MessageBox.Show("Admin Password cannot be Empty")
            TextBox2.Focus()
        End If


        cmd = New OleDbCommand("Select * from AdminLogin where AdminId= " & (TextBox1.Text) & " AND AdminPassword='" & TextBox2.Text & "'", con)
        dr = cmd.ExecuteReader()
        Try
            If (dr.Read() = True) Then
                MsgBox("Login SuccessFull...")
                Me.Hide()
                AdminMDI.Show()
            Else
                MsgBox("Invalid Password or userid")
            End If
        Catch a As Exception
            MsgBox("execption Catch")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("Admin")
        ComboBox1.Items.Add("Faculty")
        ComboBox1.Items.Add("Student")



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Select Case ComboBox1.SelectedIndex
            Case 0
                GroupBox1.Show()
                GroupBox2.Hide()
                GroupBox3.Hide()

            Case 1
                GroupBox2.Show()
                GroupBox1.Hide()
                GroupBox3.Hide()
            Case 2
                GroupBox3.Show()
                GroupBox1.Hide()
                GroupBox2.Hide()
        End Select

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()


        If ComboBox1.Text = Nothing Then
            MessageBox.Show("Please Select User Type First")
            ComboBox1.Focus()

        ElseIf TextBox4.Text = Nothing Then
            MsgBox("Please enter User ID")
            TextBox4.Focus()

        ElseIf TextBox3.Text = Nothing Then
            MessageBox.Show("Faculty Password cannot be Empty")
            TextBox3.Focus()
        End If


        cmd = New OleDbCommand("Select * from FacultyLogin where FacultyId= " & TextBox4.Text & " AND FacultyPassword='" & TextBox3.Text & "'", con)
        dr = cmd.ExecuteReader()
        Try
            If (dr.Read() = True) Then
                MsgBox("Login SuccessFull...")
                Me.Hide()
                FacultyMDI.Show()
            Else
                MsgBox("Invalid Password or userid")
            End If
        Catch a As Exception
            MsgBox("execption Catch")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()


        If ComboBox1.Text = Nothing Then
            MessageBox.Show("Please Select User Type First")
            ComboBox1.Focus()

        ElseIf TextBox6.Text = Nothing Then
            MsgBox("Please enter User ID")
            TextBox6.Focus()

        ElseIf TextBox5.Text = Nothing Then
            MessageBox.Show("Student Password cannot be Empty")
            TextBox5.Focus()
        End If



        cmd = New OleDbCommand("Select * from StudentLogin where StudId= " & TextBox6.Text & " AND StudPassword='" & TextBox5.Text & "'", con)
        dr = cmd.ExecuteReader()
        Try
            If (dr.Read() = True) Then
                MsgBox("Login SuccessFull...")
                Me.Hide()
                StudentMDI.Show()
            Else
                MsgBox("Invalid Password or userid")
            End If
        Catch a As Exception
            MsgBox("execption Catch")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub



    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        If ComboBox1.Text = Nothing Then
            MessageBox.Show("Please Select User Type First")
            TextBox1.Clear()
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click

        If ComboBox1.Text = Nothing Then
            MessageBox.Show("Please Select User Type First")
            TextBox4.Clear()
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub TextBox6_Click(sender As Object, e As EventArgs) Handles TextBox6.Click

        If ComboBox1.Text = Nothing Then
            MessageBox.Show("Please Select User Type First")
            TextBox6.Clear()
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        If ComboBox1.Text = Nothing Then
            MessageBox.Show("Please Select User Type First")
            TextBox2.Clear()
            ComboBox1.Focus()
        ElseIf TextBox1.Text = Nothing Then
            MsgBox("Please enter User ID")
            TextBox2.Clear()
            TextBox1.Focus()
        End If

    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        If ComboBox1.Text = Nothing Then
            MessageBox.Show("Please Select User Type First")
            TextBox3.Clear()
            ComboBox1.Focus()
        ElseIf TextBox4.Text = Nothing Then
            MsgBox("Please enter User ID")
            TextBox3.Clear()
            TextBox4.Focus()
        End If

    End Sub

    Private Sub TextBox5_Click(sender As Object, e As EventArgs) Handles TextBox5.Click
        If ComboBox1.Text = Nothing Then
            MessageBox.Show("Please Select User Type First")
            TextBox5.Clear()
            ComboBox1.Focus()


        ElseIf TextBox6.Text = Nothing Then
            MsgBox("Please enter User ID")
            TextBox5.Clear()
            TextBox6.Focus()
        End If
    End Sub
End Class
