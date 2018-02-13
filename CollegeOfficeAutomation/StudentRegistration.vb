Imports System.Data.OleDb

Public Class StudentRegistration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim str As String
    Dim count As Integer
    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet()
    Dim dt As New DataTable
    Dim bsource As New BindingSource
    Dim sgender As String
    Dim query As String


    Private Sub sadd_Click(sender As Object, e As EventArgs) Handles sadd.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()
        If MsgBox("Do you want to save this student details?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then


            If RadioButton1.Checked Then
                sgender = RadioButton1.Text
            ElseIf RadioButton2.Checked = True Then
                sgender = RadioButton2.Text
            End If

            str = "insert into StudentTable values(" & CInt(sid.Text) & ",'" & CStr(sfname.Text) & "','" & CStr(smname.Text) & "','" & CStr(slname.Text) & "','" & CStr(stadd.Text) & "','" & CStr(spadd.Text) & "','" & CStr(sgender) & "',' " & spno.Text & "','" & srno.Text & "','" & CStr(seid.Text) & "','" & CStr(sdob.Text) & "'," & CInt(sage.Text) & ",'" & CStr(snationality.Text) & "'," & CInt(spassno.Text) & ",'" & CStr(sreligion.Text) & "','" & CStr(scaste.Text) & "'," & CInt(sano.Text) & ",'" & CStr(scname.Text) & "','" & CStr(scyear.Text) & "','" & CStr(sscyear.Text) & "'," & CInt(sscpercentage.Text) & ",'" & CStr(hscyear.Text) & "'," & CInt(hscpercentage.Text) & ",'" & CStr(slaclass.Text) & "'," & CInt(slacpercentage.Text) & ")"
            cmd = New OleDbCommand(str, con)
            count = cmd.ExecuteNonQuery

            MessageBox.Show(count & "Rows inserted")


            cmd.CommandType = CommandType.Text
            cmd.Connection = con
            cmd.CommandText = "Select Max (ID) from [StudentTable]"

            Dim a As Integer = cmd.ExecuteScalar
            sid.Text = a + 1
            sfname.Clear()
            smname.Clear()
            spno.Clear()
            srno.Clear()
            sid.Clear()


            sfname.Focus()

            'Dim obj As New Form5
            'obj.StrPass = sid.Text

            FeePayment.Show()
            Me.Hide()

        End If


    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()
        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        cmd.CommandText = "Select Max(ID) from [StudentTable]"

        Dim a As Integer = cmd.ExecuteScalar

        sid.Text = a + 1
        If sid.Text = "" Then
            Exit Sub
        End If


        snationality.Items.Add("Indian")
        snationality.Items.Add("Non Indian")

        sreligion.Items.Add("Hindu")
        sreligion.Items.Add("Muslim")

        scaste.Items.Add("brahmin")
        scaste.Items.Add("maratha")

        'scname.Items.Add("BBA")
        'scname.Items.Add("BCA")
        'scname.Items.Add("BBM")


        Dim comd As New OleDbCommand("Select * from CourseTable", con)
        Dim adp As New OleDbDataAdapter(comd)
        Dim table As New DataTable()
        adp.Fill(table)
        scname.DataSource = table
        scname.DisplayMember = "CName"



    End Sub


    Private Sub sexit_Click(sender As Object, e As EventArgs) Handles sexit.Click
        Me.Close()
        AdminMDI.Show()
    End Sub

    Private Sub sclear_Click(sender As Object, e As EventArgs) Handles sclear.Click
        sid.Clear()
        sfname.Clear()
        smname.Clear()
        slname.Clear()
        stadd.Clear()
        spadd.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        spno.Clear()
        srno.Clear()
        seid.Clear()
        sage.Clear()
        snationality.Text = Nothing
        spassno.Clear()
        sreligion.Text = Nothing
        scaste.Text = Nothing
        sano.Clear()
        scname.Text = Nothing
        scyear.Clear()
        sscpercentage.Clear()
        hscpercentage.Clear()
        slaclass.Clear()
        slacpercentage.Clear()

        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        cmd.CommandText = "Select Max (ID) from [StudentTable]"
        Dim a As Integer = cmd.ExecuteScalar
        sid.Text = a + 1

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Dim str = stadd.Text
        spadd.Text = str
    End Sub

    Private Sub sdob_lostfocus(sender As Object, e As EventArgs) Handles sdob.LostFocus
        Dim d1 As Date
        Dim d2 As Date
        Dim d As Integer

        d1 = Format(sdob.Value, "yyyy/MM/dd")
        d2 = Format(System.DateTime.Now, "yyyy/MM/dd")
        d = DateDiff(DateInterval.Year, d1, d2)
        sage.Text = d

    End Sub
End Class