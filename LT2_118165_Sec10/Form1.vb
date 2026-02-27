Public Class Form1
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "118165"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As String = TextBox1.Text
        Dim Courseid As String = TextBox2.Text
        Dim studentmarks() = IO.File.ReadAllLines("StudentMarks.txt")
        Dim query = From s In studentmarks
                    Let data = s.Split(","c)
                    Where data(0) = id And
                        data(1) = Courseid
        If query.ToList().Count = 0 Then
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("StudentMarks.txt", True)
            file.WriteLine(TextBox1.Text & "," & TextBox2.Text & "," & TextBox3.Text & "," & TextBox4.Text)
            file.Close()
        Else
            MessageBox.Show("Already Exist in the file")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim students() = IO.File.ReadAllLines("StudentDetails.txt")
        Dim Line, data() As String
        For i As Integer = 0 To 12
            Line = students(i)
            data = Line.Split(","c)
            ListBox1.Items.Add(data(0))
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim Courses() = IO.File.ReadAllLines("CourseDetails.txt")
        Dim studentmarks() = IO.File.ReadAllLines("StudentMarks.txt")
        Dim id As String = ListBox1.SelectedItem.ToString()
        Dim query = From var In studentmarks
                    Let data = var.Split(","c)
                    Let Grade = data(2)
                    Let CourseId = data(1)
                    Where data(0) = id
                    Select Grade, CourseId

        DataGridView1.DataSource = query.ToList
        Dim query1 = From var In Courses
                     Let data = var.Split(","c)
                     Let CourseTitle = data(2)
                     Let Credits = data(1)
                     Let Department = data(3)
                     Select CourseTitle, Credits, Department
        DataGridView1.DataSource = query1.ToList
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Msg, Style, Title, Response, MyString
        Msg = "Are you sure you want to exit?"
        Style = vbYesNo + vbQuestion
        Title = "Exit"
        Response = MsgBox(Msg, Style, Title)
        If Response = vbYes Then
            MyString = "Yes"
            Close()
        Else
            MyString = "No"
        End If
    End Sub

End Class