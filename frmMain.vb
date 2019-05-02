Public Class frmMain

    Private Sub MyDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyDetailsToolStripMenuItem.Click
        Dim mForm As New frmDetails()

        With mForm
            .MdiParent = Me
            .ShowInTaskbar = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With


    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BookAppoinmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookToolStripMenuItem.Click
        Dim mForm As New frmBookTime()

        With mForm
            .MdiParent = Me
            .ShowInTaskbar = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub
    Private Sub cancelbookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancToolStripMenuItem.Click
        Dim mForm As New frmCancelApp()

        With mForm
            .MdiParent = Me
            .ShowInTaskbar = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewBookingToolStripMenuItem.Click
        Dim mForm As New frmbookinghistory()

        With mForm
            .MdiParent = Me
            .ShowInTaskbar = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim mForm As New About()

        With mForm
            .MdiParent = Me
            .ShowInTaskbar = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim mForm As New PHistory()

        With mForm
            .MdiParent = Me
            .ShowInTaskbar = False
            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click
        End

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub
End Class
