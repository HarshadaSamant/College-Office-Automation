Imports System.Data.OleDb
Public Class stdlogin
    Dim con As OleDbConnection
    Dim daLogin As OleDbDataAdapter
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim str As String
    Dim count As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()
        If MsgBox("Do you want to create student login?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            str = "insert into StudentLogin values(" & CInt(TextBox1.Text) & ",'" & TextBox2.Text & "')"
            cmd = New OleDbCommand(str, con)
            count = cmd.ExecuteNonQuery

            MessageBox.Show(count & "Login created")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class