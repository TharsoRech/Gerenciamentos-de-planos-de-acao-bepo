Imports MetroFramework

Public Class Login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Application.Exit()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim found As Boolean = False
            For Each x1 As User In Form1.database.users
                If x1.user.ToLower = Usertext.Text.ToLower And x1.Senha = SenhaText.Text Then
                    found = True
                    Form1.currentuser = x1
                    Form1.Text = Form1.Text & Space(2) & "-" & Form1.currentuser.user
                    Form1.Show()
                    If x1.admin = False Then
                        Form1.NewRegButton.Enabled = False
                        Form1.RibbonOrbMenuItem3.Enabled = False
                    End If
                    Me.Close()
                    End If
            Next
            If found = False Then
                MetroMessageBox.Show(Me, "Erro de login:A senha ou o usuário não parece estar correto,contate o administrador do sistema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SenhaText_Click1(sender As Object, e As KeyEventArgs) Handles SenhaText.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Button1.PerformClick()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Contatar.Show()
        Catch ex As Exception

        End Try
    End Sub
End Class