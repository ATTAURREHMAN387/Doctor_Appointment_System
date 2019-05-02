Public Class frmCancelApp

    Dim Query As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Query = "DELETE FROM Appointment WHERE (Appointment_ID = '" & TextBox1.Text & "')"
        DB_ExecuteNonQuery(Query, CommandType.Text)
        MessageBox.Show("Data Deleted.", "Appointment Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        RefreshGrid = True
            Me.Dispose()
    End Sub
End Class
