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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lsvStudent = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtstudentid = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtmi = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.dtpbirthdate = New System.Windows.Forms.DateTimePicker()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.cboYearLevel = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnstudentid = New System.Windows.Forms.Button()
        Me.btnlastname = New System.Windows.Forms.Button()
        Me.btndisplayall = New System.Windows.Forms.Button()
        Me.lblage = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtcn = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lsvStudent
        '
        Me.lsvStudent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lsvStudent.FullRowSelect = True
        Me.lsvStudent.GridLines = True
        Me.lsvStudent.HideSelection = False
        Me.lsvStudent.Location = New System.Drawing.Point(64, 34)
        Me.lsvStudent.Margin = New System.Windows.Forms.Padding(4)
        Me.lsvStudent.Name = "lsvStudent"
        Me.lsvStudent.Size = New System.Drawing.Size(933, 446)
        Me.lsvStudent.TabIndex = 0
        Me.lsvStudent.UseCompatibleStateImageBehavior = False
        Me.lsvStudent.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STUDENT ID"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "LASTNAME"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "FIRST NAME"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "MIDDLE INITIAL"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ADDRESS"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "DATE OF BIRTH"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "COURSE"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "YEAR LEVEL"
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "GENDER"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "CONTACT NUMBER"
        Me.ColumnHeader10.Width = 100
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "EMAIL"
        Me.ColumnHeader11.Width = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1043, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "STUDENT PROFILE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1043, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Lastname:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1043, 80)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Student ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1043, 160)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Firstname:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1043, 201)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "MI:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1041, 241)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Address:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1041, 384)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Birthdate:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1043, 426)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Course:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1043, 465)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Year Level:"
        '
        'txtstudentid
        '
        Me.txtstudentid.Location = New System.Drawing.Point(1135, 80)
        Me.txtstudentid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtstudentid.Name = "txtstudentid"
        Me.txtstudentid.Size = New System.Drawing.Size(446, 22)
        Me.txtstudentid.TabIndex = 10
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(1135, 118)
        Me.txtlastname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(446, 22)
        Me.txtlastname.TabIndex = 11
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(1135, 160)
        Me.txtfirstname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(446, 22)
        Me.txtfirstname.TabIndex = 12
        '
        'txtmi
        '
        Me.txtmi.Location = New System.Drawing.Point(1135, 201)
        Me.txtmi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmi.Name = "txtmi"
        Me.txtmi.Size = New System.Drawing.Size(446, 22)
        Me.txtmi.TabIndex = 13
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(1135, 238)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtaddress.Size = New System.Drawing.Size(446, 122)
        Me.txtaddress.TabIndex = 14
        '
        'dtpbirthdate
        '
        Me.dtpbirthdate.Location = New System.Drawing.Point(1135, 377)
        Me.dtpbirthdate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpbirthdate.Name = "dtpbirthdate"
        Me.dtpbirthdate.Size = New System.Drawing.Size(265, 22)
        Me.dtpbirthdate.TabIndex = 15
        '
        'cboCourse
        '
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(1135, 416)
        Me.cboCourse.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(265, 24)
        Me.cboCourse.TabIndex = 18
        '
        'cboYearLevel
        '
        Me.cboYearLevel.DisplayMember = "1"
        Me.cboYearLevel.FormattingEnabled = True
        Me.cboYearLevel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboYearLevel.Location = New System.Drawing.Point(1135, 462)
        Me.cboYearLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.cboYearLevel.Name = "cboYearLevel"
        Me.cboYearLevel.Size = New System.Drawing.Size(265, 24)
        Me.cboYearLevel.TabIndex = 19
        Me.cboYearLevel.Tag = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(60, 502)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Search by:"
        '
        'btnstudentid
        '
        Me.btnstudentid.Location = New System.Drawing.Point(64, 522)
        Me.btnstudentid.Margin = New System.Windows.Forms.Padding(4)
        Me.btnstudentid.Name = "btnstudentid"
        Me.btnstudentid.Size = New System.Drawing.Size(100, 28)
        Me.btnstudentid.TabIndex = 21
        Me.btnstudentid.Text = "Student ID"
        Me.btnstudentid.UseVisualStyleBackColor = True
        '
        'btnlastname
        '
        Me.btnlastname.Location = New System.Drawing.Point(172, 522)
        Me.btnlastname.Margin = New System.Windows.Forms.Padding(4)
        Me.btnlastname.Name = "btnlastname"
        Me.btnlastname.Size = New System.Drawing.Size(100, 28)
        Me.btnlastname.TabIndex = 22
        Me.btnlastname.Text = "Lastname"
        Me.btnlastname.UseVisualStyleBackColor = True
        '
        'btndisplayall
        '
        Me.btndisplayall.Location = New System.Drawing.Point(280, 522)
        Me.btndisplayall.Margin = New System.Windows.Forms.Padding(4)
        Me.btndisplayall.Name = "btndisplayall"
        Me.btndisplayall.Size = New System.Drawing.Size(100, 28)
        Me.btndisplayall.TabIndex = 23
        Me.btndisplayall.Text = "Display All"
        Me.btndisplayall.UseVisualStyleBackColor = True
        '
        'lblage
        '
        Me.lblage.AutoSize = True
        Me.lblage.Location = New System.Drawing.Point(1444, 377)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(37, 17)
        Me.lblage.TabIndex = 24
        Me.lblage.Text = "Age:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1043, 502)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 17)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Gender: "
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Location = New System.Drawing.Point(1135, 502)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(265, 24)
        Me.cboGender.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1041, 543)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 17)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Contact No:"
        '
        'txtcn
        '
        Me.txtcn.Location = New System.Drawing.Point(1135, 543)
        Me.txtcn.Name = "txtcn"
        Me.txtcn.Size = New System.Drawing.Size(446, 22)
        Me.txtcn.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1041, 578)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 17)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Email:"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(1135, 578)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(446, 22)
        Me.txtemail.TabIndex = 30
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1655, 661)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtcn)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblage)
        Me.Controls.Add(Me.btndisplayall)
        Me.Controls.Add(Me.btnlastname)
        Me.Controls.Add(Me.btnstudentid)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboYearLevel)
        Me.Controls.Add(Me.cboCourse)
        Me.Controls.Add(Me.dtpbirthdate)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtmi)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.txtstudentid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lsvStudent)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsvStudent As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtstudentid As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtmi As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents dtpbirthdate As DateTimePicker
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents cboYearLevel As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnstudentid As Button
    Friend WithEvents btnlastname As Button
    Friend WithEvents btndisplayall As Button
    Friend WithEvents lblage As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtcn As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
End Class
