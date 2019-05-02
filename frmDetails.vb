Imports System.Data.SqlClient

Public Class frmDetails
    Dim Datatable As New DataTable
    Dim Query As String = ""
    Dim Returnvalue As String = ""


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If tbPatientID.Text = String.Empty Then

            MessageBox.Show("Please Enter Patient ID.", "Doctor Appointmnet System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbPatientID.Focus()
        End If
        If tbPatientName.Text = String.Empty Then

            MessageBox.Show("Please Enter Patient Name.", "Doctor Appointmnet System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbPatientName.Focus()
        End If
        If tbPatientEmail.Text = String.Empty Then

            MessageBox.Show("Please Enter Patient Email.", "Doctor Appointmnet System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbPatientEmail.Focus()

            If Not tbPatientEmail.Text.Contains("@") Or Not tbPatientEmail.Text.Contains(".com") Then

                MessageBox.Show("Email is incorrect.", "Doctor Appointmnet System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        End If
        If tbPhone.Text = String.Empty Then

            MessageBox.Show("Please Enter Patient Phone Number.", "Doctor Appointmnet System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbPhone.Focus()
        End If
        If tbPatientAddress.Text = String.Empty Then
            MessageBox.Show("Please Enter Patient Address.", "Doctor Appointmnet System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbPatientAddress.Focus()
        End If

        Query = " INSERT INTO Patient  (Patient_ID,              Patient_Name,                Patient_Email,             Patient_Phone_NO,           Patient_address)" &
                "VALUES (         '" & tbPatientID.Text & "','" & tbPatientName.Text & "','" & tbPatientEmail.Text & "','" & tbPhone.Text & "','" & tbPatientAddress.Text & "')"
        Returnvalue = DB_ExecuteNonQuery(Query, CommandType.Text)

        If Returnvalue = "Y" Then
            MessageBox.Show("Data Saved.", "Doctor Appointmnet System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call frmDetails_Load(Nothing, Nothing)
        Else
            MessageBox.Show(Returnvalue, "Doctor Appointmnet System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Dispose()
    End Sub

    Private Sub frmDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tbPatientID.Clear()
        tbPatientName.Clear()
        tbPatientEmail.Clear()
        tbPhone.Clear()
        tbPatientAddress.Clear()

    End Sub
End Class