Imports System.Data.SqlClient
Public Class frmBookTime


    Dim FDate As String = ""
    Dim AppTime As String
    Dim dSP As New DataTable
    Dim dDName As New DataTable
    Dim dCHKDate As New DataTable
    Dim Query As String = ""
    Dim RetrunV As String = ""
    Dim Rowss As Integer = 0

    Private Sub Book_Click(sender As Object, e As EventArgs) Handles btnbook.Click
        If tbapnmntid.Text = String.Empty Then

            MessageBox.Show("Please Enter Appoinment ID.", "Doctor Appointmnet System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbapnmntid.Focus()
        End If
        If cbSpecialization.Text = String.Empty Then

            MessageBox.Show("Please Select Specialization .", "Doctor Appointmnet System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbSpecialization.Focus()
        End If
        If cbdname.Text = String.Empty Then

            MessageBox.Show("Please Select Doctor Name .", "Doctor Appointmnet System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbdname.Focus()
        End If
        If tbPtName.Text = String.Empty Then

            MessageBox.Show("Please Enter Patient Name.", "Doctor Appointmnet System", MessageBoxButtons.OK, MessageBoxIcon.Error)

            tbPtName.Focus()
        End If
        If TextBox1.Text = String.Empty Then

            MessageBox.Show("Please Enter Patient Phone No.", "Doctor Appointmnet System", MessageBoxButtons.OK, MessageBoxIcon.Error)

            TextBox1.Focus()
        End If



        Query = "INSERT INTO Appointment (Appointment_ID,                  Specialization,                   Appointment_Date,                                                 Appointment_Time,          Doctor_Name,                     Patient_Name,         Phone_No)" &
                          "VALUES        ('" & tbapnmntid.Text & "','" & cbSpecialization.Text & "',    '" & Format("dd/MM/yyyy", mcnewbookings.Value.ToString("D")) & "',  '" & AppTime & "',      '" & cbdname.SelectedItem & "', '" & tbPtName.Text & "',      '" & TextBox1.Text & "')"

        RetrunV = DB_ExecuteNonQuery(Query, CommandType.Text)

        If RetrunV = "Y" Then

            MessageBox.Show("Data Saved.", "Doctor Appointmnet System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmBookTime_Load(Nothing, Nothing)

        Else
            MessageBox.Show("Data not Saved.", "Doctor Appointmnet System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Dispose()
    End Sub

    Private Sub frmBookTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mcnewbookings.Value = Format(DateTime.Now, "dd/MM/yyyy")

        tbapnmntid.Clear()
        Button1.Text = "New Time Bookings"
        tbPtName.Clear()
        Button1.Text = "New Time Bookings"
        TextBox1.Clear()
        Button1.Text = "New Time Bookings"

        cbSpecialization.Items.Clear()
        cbdname.Items.Clear()

        cbSpecialization.Items.Add("Please Select...")
        cbdname.Items.Add("Please Select...")

        cbSpecialization.SelectedItem = "Please Select..."
        cbdname.SelectedItem = "Please Select..."
        ButtonEnable()
        DataLoading("Loading Doctor SP")
    End Sub

    Private Function ButtonEnable() As String
        t101030.Enabled = True
        t103011.Enabled = True
        t111130.Enabled = True
        t1130.Enabled = True
        t113002.Enabled = True
        t113012.Enabled = True
        t2230.Enabled = True
        t2303.Enabled = True
        t3304.Enabled = True
        t3330.Enabled = True
        t5306.Enabled = True
        t5530.Enabled = True
        t6307.Enabled = True
        t6630.Enabled = True
        t7308.Enabled = True
        t7730.Enabled = True
        t93010.Enabled = True
        t9930.Enabled = True


        Return ""
    End Function


    Private Sub t9930_Click(sender As Object, e As EventArgs) Handles t9930.Click
        AppTime = t9930.Name.ToString
        Button1.Text = "You Select Time for Appointment: " & t9930.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ButtonEnable()
        CHKDateTime()
    End Sub

    Private Sub t93010_Click(sender As Object, e As EventArgs) Handles t93010.Click
        AppTime = t93010.Name.ToString
        Button1.Text = "You Select Time for Appointment: " & t93010.Text
    End Sub

    Private Function CHKDateTime(Optional ByVal WorkAction As String = "") As String

        FDate = Format("dd/MM/yyyy", mcnewbookings.Value.ToString("D"))



        Query = "SELECT Appointment_Date, Appointment_Time FROM Appointment WHERE " &
        "(Appointment_Date = '" & FDate & "') AND (Doctor_Name = '" & cbdname.SelectedItem & "')"

        dCHKDate.Rows.Clear()
        dCHKDate.Clear()

        Rowss = RowsCount(Query)
        RetrunV = DBFilDTable(dCHKDate, Query)

        For i As Integer = 0 To Rowss
            If i = Rowss Then
                Exit For
            Else
                CType(Me.Controls(dCHKDate.Rows(i)("Appointment_Time").ToString().Trim()), Button).Enabled = False

            End If
        Next

        Return ""
    End Function

    Private Function DataLoading(Optional ByVal WorkAction As String = "") As String

        If WorkAction = "Loading Doctor SP" Then

            Query = "SELECT DISTINCT Specialization FROM Doctor"

            Rowss = RowsCount(Query)
            RetrunV = DBFilDTable(dSP, Query)

            For i As Integer = 0 To Rowss
                If i = Rowss Then
                    Exit For
                Else
                    cbSpecialization.Items.Add(dSP.Rows(i)("Specialization").ToString)
                End If
            Next


        ElseIf WorkAction = "Loading Doctor Names" Then

            Query = "SELECT DISTINCT Doctor_Name FROM Doctor WHERE (Specialization = '" & cbSpecialization.SelectedItem & "')"


            dDName.Rows.Clear()
            dDName.Clear()

            Rowss = RowsCount(Query)
            RetrunV = DBFilDTable(dDName, Query)

            cbdname.Items.Clear()

            For i As Integer = 0 To Rowss
                If i = Rowss Then
                    Exit For
                Else
                    cbdname.Items.Add(dDName.Rows(i)("Doctor_Name").ToString)
                End If
            Next

        End If


        'MessageBox.Show("Data loaded.", "Doctor Appointmnet System", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Return ""
    End Function

    Private Sub t101030_Click(sender As Object, e As EventArgs) Handles t101030.Click
        AppTime = t101030.Name.ToString
        Button1.Text = "You Select Time for Appointment: " & t101030.Text
    End Sub

    Private Sub cbSpecialization_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSpecialization.SelectedIndexChanged
        If cbSpecialization.SelectedItem <> "Please Select..." Then
            DataLoading("Loading Doctor Names")
        End If
    End Sub

    Private Sub t103011_Click(sender As Object, e As EventArgs) Handles t103011.Click
        AppTime = t103011.Name.ToString
        Button1.Text = "You Select Time for Appointment: " & t103011.Text
    End Sub

    Private Sub t111130_Click(sender As Object, e As EventArgs) Handles t111130.Click
        AppTime = t111130.Name.ToString
        Button1.Text = "You Select Time for Appointment: " & t111130.Text
    End Sub

    Private Sub t113012_Click(sender As Object, e As EventArgs) Handles t113012.Click
        AppTime = t113012.Name.ToString
        Button1.Text = "You Select Time for Appointment: " & t113012.Text
    End Sub

    Private Sub t1130_Click(sender As Object, e As EventArgs) Handles t1130.Click
        AppTime = t1130.Name.ToString
        Button1.Text = "You Select Time for Appointment: " & t1130.Text
    End Sub

    Private Sub t113002_Click(sender As Object, e As EventArgs) Handles t113002.Click
        AppTime = t113002.Name.ToString
        Button1.Text = "You Select Time for Appointment: " & t113002.Text
    End Sub

    Private Sub t2230_Click(sender As Object, e As EventArgs) Handles t2230.Click
        AppTime = t2230.Name.ToString
        Button1.Text = "You Select Time for Appointment: " & t2230.Text
    End Sub

    Private Sub t2303_Click(sender As Object, e As EventArgs) Handles t2303.Click
        AppTime = t2303.Name.ToString
        Button1.Text = "You Select Time for Appointment: " & t2303.Text
    End Sub

    Private Sub t3330_Click(sender As Object, e As EventArgs) Handles t3330.Click
        AppTime = t3330.Name.ToString
        Button1.Text = "You Select Time for Appointment: " & t3330.Text
    End Sub

    Private Sub t3304_Click(sender As Object, e As EventArgs) Handles t3304.Click
        AppTime = t3304.Name.ToString
        Button1.Text = "You Select Time for Appointment: " & t3304.Text
    End Sub

    Private Sub t5530_Click(sender As Object, e As EventArgs) Handles t5530.Click
        AppTime = t5530.Name.ToString
        Button1.Text = "You Select Time for Appointment: " & t5530.Text
    End Sub

    Private Sub t5306_Click(sender As Object, e As EventArgs) Handles t5306.Click
        AppTime = t5306.Name.ToString
        Button1.Text = "You Select Time for Appointment: " & t5306.Text
    End Sub

    Private Sub t6630_Click(sender As Object, e As EventArgs) Handles t6630.Click
        AppTime = t6630.Name.ToString
        Button1.Text = "You Select Time for Appointment: " & t6630.Text
    End Sub

    Private Sub t6307_Click(sender As Object, e As EventArgs) Handles t6307.Click
        AppTime = t6307.Name.ToString
        Button1.Text = "You Select Time for Appointment: " & t6307.Text
    End Sub

    Private Sub t7730_Click(sender As Object, e As EventArgs) Handles t7730.Click
        AppTime = t7730.Name.ToString
        Button1.Text = "You Select Time for Appointment: " & t7730.Text
    End Sub

    Private Sub t7308_Click(sender As Object, e As EventArgs) Handles t7308.Click
        AppTime = t7308.Name.ToString
        Button1.Text = "You Select Time for Appointment: " & t7308.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub tbPtName_TextChanged(sender As Object, e As EventArgs) Handles tbPtName.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class