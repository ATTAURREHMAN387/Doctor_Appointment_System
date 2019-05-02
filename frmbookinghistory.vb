Imports System.Data.SqlClient

Public Class frmbookinghistory
    Dim Datatablee As New DataTable
    Dim Query As String = ""
    Dim Returnvalue As String = ""


    Private Sub bookinghistory_Click(sender As Object, e As EventArgs) Handles txtbookinghistory.Click


    End Sub
    Private Sub frmDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtbookinghistory_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txtbookinghistory.LinkClicked

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Datatablee.Clear()
        DataGridView.DataSource = Datatablee

        Query = "SELECT * FROM Appointment"
        DBFilDTable(Datatablee, Query)
        DataGridView.DataSource = Datatablee

    End Sub

    Private Sub DataGridView_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridView.MouseDoubleClick
        Dim srow As Integer = DataGridView.CurrentRow.Index

        Dim mForm As New frmCancelApp()

        With mForm
            .MdiParent = frmMain

            .ShowInTaskbar = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()

            .TextBox1.Text = DataGridView.Rows(srow).Cells("Appointment_ID").Value.ToString

        End With


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If RefreshGrid = True Then
            Button1_Click(Nothing, Nothing)
            RefreshGrid = False
        End If
    End Sub
End Class

