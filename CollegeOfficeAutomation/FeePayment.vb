Imports System.Data.OleDb


Public Class FeePayment

    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim str As String
    Dim count As Integer
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet()
    Dim dt As New DataTable
    Dim bsource As New BindingSource
    Dim strNewText As String
    Dim sem As String
    Dim mode As String





    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()

        TextBox2.Text = StudentRegistration.scname.Text
        TextBox3.Text = StudentRegistration.scyear.Text


        Dim dt As Date = Date.Now()
        Dim strdt As String = dt.ToString("dd MMM yyy")
        Label13.Text = strdt

        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        cmd.CommandText = "Select Max(Fid) from [FeeDetails]"

        Dim i As Integer = cmd.ExecuteScalar

        TextBox9.Text = i + 1
        If TextBox9.Text = "" Then
            Exit Sub
        End If



        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        cmd.CommandText = "select Max(Id) from StudentTable"
        Dim a As Integer = cmd.ExecuteScalar
        txtid.Text = a


        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        cmd.CommandText = "select CId from CourseTable where CName='" & TextBox2.Text & "'"
        Dim b As Integer = cmd.ExecuteScalar
        TextBox1.Text = b

        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        cmd.CommandText = "select CTFees from CourseTable where CId=" & TextBox1.Text & ""
        Dim c As Integer = cmd.ExecuteScalar
        TextBox5.Text = c


    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()
        If MsgBox("Do you want to pay fees?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            TextBox4.Text = Val(TextBox7.Text) - Val(TextBox6.Text)
            TextBox8.Text = Val(TextBox6.Text)



            If CheckBox1.Checked = True Then
                sem = CheckBox1.Text
            ElseIf CheckBox2.Checked = True Then
                sem = CheckBox2.Text
            ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
                sem = "both"
            End If

            If RadioButton1.Checked = True Then
                mode = RadioButton1.Text
            ElseIf RadioButton2.Checked = True Then
                mode = RadioButton2.Text
            End If

            str = "insert into FeeDetails values(" & CInt(TextBox9.Text) & ", " & txtid.Text & "," & TextBox1.Text & ",' " & TextBox2.Text & " ','" & TextBox3.Text & "'," & TextBox5.Text & ",' " & sem & " '," & TextBox7.Text & "," & TextBox6.Text & "," & TextBox8.Text & "," & TextBox4.Text & ",'" & Label13.Text & "',' " & mode & " ')"
                cmd = New OleDbCommand(str, con)
            count = cmd.ExecuteNonQuery

            MessageBox.Show(count & "Fees Paid successfully")

            stdlogin.Show()
            stdlogin.TextBox1.Text = Me.txtid.Text

        End If
    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True And CheckBox2.Checked = False Then
            TextBox7.Text = Val(TextBox5.Text) / 2
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
            TextBox7.Text = Val(TextBox5.Text)
        ElseIf CheckBox2.Checked = True And CheckBox1.Checked = False Then
            TextBox7.Text = Val(TextBox5.Text) / 2
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
            TextBox7.Text = Val(TextBox5.Text)
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False Then
            TextBox7.Clear()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox1.Checked = True And CheckBox2.Checked = False Then
            TextBox7.Text = Val(TextBox5.Text) / 2
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
            TextBox7.Text = Val(TextBox5.Text)
        ElseIf CheckBox2.Checked = True And CheckBox1.Checked = False Then
            TextBox7.Text = Val(TextBox5.Text) / 2
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
            TextBox7.Text = Val(TextBox5.Text)
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False Then
            TextBox7.Clear()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        AdminMDI.Show()
    End Sub
End Class