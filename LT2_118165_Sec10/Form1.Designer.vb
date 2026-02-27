<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Button2 = New Button()
        Button1 = New Button()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        Button3 = New Button()
        ListBox1 = New ListBox()
        TextBox5 = New TextBox()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        Button4 = New Button()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(30, 58)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(303, 335)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(126, 290)
        Button2.Name = "Button2"
        Button2.Size = New Size(171, 29)
        Button2.TabIndex = 18
        Button2.Text = "Clear All TextBoxes"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(14, 290)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 17
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(107, 215)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(190, 27)
        TextBox3.TabIndex = 16
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(107, 158)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(190, 27)
        TextBox4.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 218)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 14
        Label1.Text = "Grade"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(39, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 20)
        Label3.TabIndex = 13
        Label3.Text = "Marks"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(107, 106)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(190, 27)
        TextBox2.TabIndex = 12
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(107, 55)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(190, 27)
        TextBox1.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(14, 106)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 20)
        Label4.TabIndex = 10
        Label4.Text = "Course ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 20)
        Label2.TabIndex = 9
        Label2.Text = "Student ID"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(388, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 58)
        Button3.TabIndex = 1
        Button3.Text = "Click List By Student Id"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Location = New Point(370, 103)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(150, 284)
        ListBox1.TabIndex = 2
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(820, 28)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(584, 29)
        Label5.Name = "Label5"
        Label5.Size = New Size(176, 20)
        Label5.TabIndex = 4
        Label5.Text = "Number of Courses taken"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(584, 108)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(361, 230)
        DataGridView1.TabIndex = 5
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(809, 389)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 6
        Button4.Text = "Exit"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(985, 450)
        Controls.Add(Button4)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        Controls.Add(TextBox5)
        Controls.Add(ListBox1)
        Controls.Add(Button3)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button4 As Button
End Class
