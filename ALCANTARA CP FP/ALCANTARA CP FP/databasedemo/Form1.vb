Public Class Form1

    Sub DisplayFirstRec()
        'Note: The data source is the path of your database 
        DBConnection()
        adoRS = cn.Execute("Select * From studentprofiles")

        Try
            If adoRS.BOF = False Then 'FALSE MEANS THERE ARE RECORDS
                txtstudentid.Text = adoRS.Fields("studentid").Value
                txtlastname.Text = adoRS.Fields("lastname").Value
                txtfirstname.Text = adoRS.Fields("firstname").Value
                txtmi.Text = adoRS.Fields("mi").Value
                txtaddress.Text = adoRS.Fields("address").Value
                dtpbirthdate.Value = adoRS.Fields("dob").Value
                cboCourse.Text = adoRS.Fields("course").Value
                cboYearLevel.Text = adoRS.Fields("yearlevel").Value
                cboGender.Text = adoRS.Fields("gender").Value
                txtcn.Text = adoRS.Fields("contactnumber").Value
                txtemail.Text = adoRS.Fields("email").Value

            End If
        Catch ex As Exception
            MsgBox(ex.Message, 48, "Database Connection Error")
        End Try
        'adoRS.Close()
        'cn.Close()
    End Sub
    Sub FillListview()
        lsvStudent.Items.Clear()
        'Note: The data source is the path of your database 
        DBConnection()
        adoRS = cn.Execute("Select * From studentprofiles")
        Dim arr As String() = New String(11) {}
        Dim itm As ListViewItem
        Try
            If adoRS.BOF = False Then 'FALSE MEANS THERE ARE RECORDS
                Do While Not adoRS.EOF
                    'add items to ListView
                    arr(0) = adoRS.Fields("studentid").Value
                    arr(1) = adoRS.Fields("lastname").Value
                    arr(2) = adoRS.Fields("firstname").Value
                    arr(3) = adoRS.Fields("mi").Value
                    arr(4) = adoRS.Fields("address").Value
                    arr(5) = adoRS.Fields("dob").Value
                    arr(6) = adoRS.Fields("course").Value
                    arr(7) = adoRS.Fields("yearlevel").Value
                    arr(8) = adoRS.Fields("gender").Value
                    arr(9) = adoRS.Fields("contactnumber").Value
                    arr(10) = adoRS.Fields("email").Value

                    itm = New ListViewItem(arr)
                    lsvStudent.Items.Add(itm)
                    adoRS.MoveNext()
                Loop
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 48, "Database Connection Error")
        End Try
        'adoRS.Close()
        'cn.Close()
    End Sub

    Sub CourseCode()
        'for course combo box
        'Note: The data source is the path of your database 
        DBConnection()
        adoRS = cn.Execute("Select * From COURSECODE")

        Try
            If adoRS.BOF = False Then 'FALSE MEANS THERE ARE RECORDS
                Do While Not adoRS.EOF
                    'add items to ListView
                    cboCourse.Items.Add(adoRS.Fields("COURSE").Value)
                    adoRS.MoveNext()
                Loop
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 48, "Database Connection Error")
        Finally
            adoRS.Close()
            cn.Close()
        End Try
    End Sub

    Sub GenderCode()
        'for gender combo box
        'Note: The data source is the path of your database 
        DBConnection()
        adoRS = cn.Execute("Select * From GENDERCODE")

        Try
            If adoRS.BOF = False Then 'FALSE MEANS THERE ARE RECORDS
                Do While Not adoRS.EOF
                    'add items to ListView
                    cboGender.Items.Add(adoRS.Fields("GENDER").Value)
                    adoRS.MoveNext()
                Loop
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 48, "Database Connection Error")
        Finally
            adoRS.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CourseCode()
        GenderCode()
        FillListview()
        DisplayFirstRec()
    End Sub

    Private Sub lsvStudent_Click(sender As Object, e As EventArgs) Handles lsvStudent.Click
        Dim StudentID As String
        StudentID = lsvStudent.SelectedItems.Item(0).SubItems(0).Text
        'Note: The data source is the path of your database 
        DBConnection()
        adoRS = cn.Execute("Select * From studentprofiles where StudentID='" & StudentID & "'")

        Try
            If adoRS.BOF = False Then 'FALSE MEANS THERE ARE RECORDS
                txtstudentid.Text = adoRS.Fields("studentid").Value
                txtlastname.Text = adoRS.Fields("lastname").Value
                txtfirstname.Text = adoRS.Fields("firstname").Value
                txtmi.Text = adoRS.Fields("mi").Value
                txtaddress.Text = adoRS.Fields("address").Value
                dtpbirthdate.Value = adoRS.Fields("dob").Value
                cboCourse.Text = adoRS.Fields("course").Value
                cboYearLevel.Text = adoRS.Fields("yearlevel").Value
                cboGender.Text = adoRS.Fields("gender").Value
                txtcn.Text = adoRS.Fields("contactnumber").Value
                txtemail.Text = adoRS.Fields("email").Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 48, "Database Connection Error")
        End Try
        'adoRS.Close()
        'cn.Close()
    End Sub

    Private Sub btndisplayall_Click(sender As Object, e As EventArgs) Handles btndisplayall.Click
        FillListview()
    End Sub

    Private Sub btnstudentid_Click(sender As Object, e As EventArgs) Handles btnstudentid.Click
        Dim StudentID = InputBox("Enter student ID", "Search by Student ID")
        lsvStudent.Items.Clear()
        'Note: The data source is the path of your database 
        DBConnection()
        adoRS = cn.Execute("Select * From studentprofiles where StudentID like '" & StudentID & "%'")
        Dim arr As String() = New String(11) {}
        Dim itm As ListViewItem
        Try
            If adoRS.BOF = False Then 'FALSE MEANS THERE ARE RECORDS
                Do While Not adoRS.EOF
                    'add items to ListView
                    arr(0) = adoRS.Fields("studentid").Value
                    arr(1) = adoRS.Fields("lastname").Value
                    arr(2) = adoRS.Fields("firstname").Value
                    arr(3) = adoRS.Fields("mi").Value
                    arr(4) = adoRS.Fields("address").Value
                    arr(5) = adoRS.Fields("dob").Value
                    arr(6) = adoRS.Fields("course").Value
                    arr(7) = adoRS.Fields("yearlevel").Value
                    arr(8) = adoRS.Fields("gender").Value
                    arr(9) = adoRS.Fields("contactnumber").Value
                    arr(10) = adoRS.Fields("email").Value

                    itm = New ListViewItem(arr)
                    lsvStudent.Items.Add(itm)
                    adoRS.MoveNext()
                Loop
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 48, "Database Connection Error")
        End Try
    End Sub

    Private Sub btnlastname_Click(sender As Object, e As EventArgs) Handles btnlastname.Click
        Dim Lastname = InputBox("Enter Lastname", "Search by Lastname")
        lsvStudent.Items.Clear()
        'Note: The data source is the path of your database 
        DBConnection()
        adoRS = cn.Execute("Select * From studentprofiles where Lastname like '" & Lastname & "%'")
        Dim arr As String() = New String(11) {}
        Dim itm As ListViewItem
        Try
            If adoRS.BOF = False Then 'FALSE MEANS THERE ARE RECORDS
                Do While Not adoRS.EOF
                    'add items to ListView
                    arr(0) = adoRS.Fields("studentid").Value
                    arr(1) = adoRS.Fields("lastname").Value
                    arr(2) = adoRS.Fields("firstname").Value
                    arr(3) = adoRS.Fields("mi").Value
                    arr(4) = adoRS.Fields("address").Value
                    arr(5) = adoRS.Fields("dob").Value
                    arr(6) = adoRS.Fields("course").Value
                    arr(7) = adoRS.Fields("yearlevel").Value
                    arr(8) = adoRS.Fields("gender").Value
                    arr(9) = adoRS.Fields("contactnumber").Value
                    arr(10) = adoRS.Fields("email").Value

                    itm = New ListViewItem(arr)
                    lsvStudent.Items.Add(itm)
                    adoRS.MoveNext()
                Loop
            End If
        Catch ex As Exception
            MsgBox(ex.Message, 48, "Database Connection Error")
        End Try
    End Sub

    Private Sub dtpbirthdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpbirthdate.ValueChanged

        lblage.Text = "Age: " & Age(dtpbirthdate.Value)

    End Sub

    Public Shared Function Age(DOfB As Object) As String
        If (Month(Date.Today) * 100) + Date.Today.Day >= (Month(DOfB) * 100) + DOfB.Day Then
            Return DateDiff(DateInterval.Year, DOfB, Date.Today)
        Else
            Return DateDiff(DateInterval.Year, DOfB, Date.Today) - 1
        End If
    End Function


End Class
