Imports System.Data.SqlClient
Public Class PHistory
    Dim FormDataTable As New DataTable

    Dim ReturnValue As String = ""
    Dim Query As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Query = "Select Appointment_ID, Patient_Name, Specialization, Appointment_Date, Appointment_Time, Doctor_Name, Phone_No " &
            "From Appointment Where Phone_No = '" & TextBox1.Text & "'"
        ReturnValue = DBFilDTable(FormDataTable, Query)

        If ReturnValue = "Y" Then
            DataGridView.DataSource = FormDataTable
        End If

    End Sub
End Class