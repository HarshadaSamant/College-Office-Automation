
Imports System.Data.OleDb

Public Class Faculty
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim str As String
    Dim count As Integer

    Dim adp As New OleDbDataAdapter
    Dim ds As New DataSet()

    Dim dt As New DataTable
    Dim bsource As New BindingSource
    Dim ftype As String
    Dim gender As String


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        AdminMDI.Show()
    End Sub

    Private Sub Faculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()

        ListBox1.Visible = False
        ListBox2.Visible = False

        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = con
        cmd.CommandText = "Select Max (ID) from [FacultyTable]"



        Dim a As Integer = cmd.ExecuteScalar


        TextBox9.Text = a + 1
        If TextBox9.Text = "" Then
            Exit Sub
        End If

        ComboBox1.Items.Add("Assistant Professor")
        ComboBox1.Items.Add("Coordinator")
        ComboBox1.Items.Add("Head of Department")

        ComboBox2.Items.Add("BCA")
        ComboBox2.Items.Add("BBA")
        ComboBox2.Items.Add("MCA")
        ComboBox2.Items.Add("MBA")
        ComboBox2.Items.Add("BCOM")
        ComboBox2.Items.Add("MCOM")
        ComboBox2.Items.Add("BE")
        ComboBox2.Items.Add("ME")
        ComboBox2.Items.Add("Other")

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\Users\Guest1\Desktop\CollegeOfficeAutomation\CollegeAutomation.mdb")
        con.Open()


        If MsgBox("Do you want to save this record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            If RadioButton3.Checked = True Then
                ftype = RadioButton3.Text
            ElseIf RadioButton4.Checked = True Then
                ftype = RadioButton4.Text
            End If

            If RadioButton1.Checked = True Then
                gender = RadioButton1.Text
            ElseIf RadioButton4.Checked = True Then
                gender = RadioButton2.Text
            End If

            str = "insert into FacultyTable values(" & CInt(TextBox9.Text) & ",' " & TextBox1.Text & " ',' " & (TextBox2.Text) & " ',' " & (RichTextBox2.Text) & " ',' " & gender & " ',' " & TextBox3.Text & "' ,' " & TextBox4.Text & "',' " & (TextBox5.Text) & " ',' " & (DateTimePicker1.Text) & " ', " & CInt(TextBox6.Text) & " ,' " & (ComboBox2.Text) & " ',' " & (TextBox10.Text) & " ',' " & (CheckedListBox3.SelectedItem) & " ',' " & (TextBox10.Text) & " ',' " & (ComboBox1.Text) & " ',' " & (TextBox7.Text) & " ',' " & (DateTimePicker2.Text) & "' ,' " & ftype & " ')"
            cmd = New OleDbCommand(str, con)
            count = cmd.ExecuteNonQuery



            MessageBox.Show(count & "Rows inserted")

            cmd.CommandType = CommandType.Text
            cmd.Connection = con
            cmd.CommandText = "Select Max (ID) from [FacultyTable]"

            Dim a As Integer = cmd.ExecuteScalar
            TextBox9.Text = a + 1
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
        TextBox10.Clear()
        RichTextBox2.Clear()
        RichTextBox2.Clear()

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False

        ComboBox1.ResetText()
        ComboBox2.ResetText()

        Dim i As Integer
        For i = 0 To (CheckedListBox2.Items.Count - 1) 'Listbox is the listbox's name
            CheckedListBox2.SetItemChecked(i, False)
        Next
        Dim j As Integer
        For j = 0 To (CheckedListBox3.Items.Count - 1) 'Listbox is the listbox's name
            CheckedListBox3.SetItemChecked(j, False)
        Next
        CheckedListBox2.Refresh()
        CheckedListBox3.Refresh()




    End Sub

    Private Sub DateTimePicker1_leave(sender As Object, e As EventArgs) Handles DateTimePicker1.Leave
        Dim d1 As Date
        Dim d2 As Date
        Dim d As Integer

        d1 = Format(DateTimePicker1.Value, "yyyy/MM/dd")
        d2 = Format(System.DateTime.Now, "yyyy/MM/dd")
        d = DateDiff(DateInterval.Year, d1, d2)
        TextBox6.Text = d
    End Sub

    'Private Sub CheckedListBox3_itemcheck(sender As Object, e As EventArgs) Handles CheckedListBox3.ItemCheck
    '    ListBox1.Visible = True
    '    Dim items As String
    '    items = CheckedListBox3.SelectedItem
    '    ListBox1.Items.Add(items)
    'End Sub
    'Private Sub CheckedListBox2_itemcheck(sender As Object, e As EventArgs) Handles CheckedListBox2.ItemCheck
    '    ListBox2.Visible = True
    '    Dim items As String
    '    items = CheckedListBox2.SelectedItem
    '    ListBox2.Items.Add(items)
    'End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Visible = True


        ListBox1.Items.Add(CheckedListBox3.SelectedItem)


    End Sub
End Class