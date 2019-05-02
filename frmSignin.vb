Public Class frmSignin

    Private Sub frmSignin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSignIN_Click(sender As Object, e As EventArgs) Handles btnSignIN.Click

        If TextBox1.Text = "Attiq" And TextBox2.Text = "1234567890" Then
            MsgBox("You are logged In  ", MsgBoxStyle.Information, "Login")

            Dim Form As New frmMain
            Form.Show()
            Me.Hide()
        Else
            If TextBox1.Text = "" And TextBox2.Text = "" Then
                MsgBox("No Username or Password Found!  ", MsgBoxStyle.Critical, "Error")
            Else
                If TextBox1.Text = "" Then
                    MsgBox("No Username Found!  ", MsgBoxStyle.Critical, "Error")
                Else
                    If TextBox2.Text = "" Then
                        MsgBox("No Password Found!  ", MsgBoxStyle.Critical, "Error")
                    Else
                        MsgBox("Invalid Username or Password! ", MsgBoxStyle.Critical, "Error")

                    End If
                End If
            End If
        End If
    End Sub
End Class
