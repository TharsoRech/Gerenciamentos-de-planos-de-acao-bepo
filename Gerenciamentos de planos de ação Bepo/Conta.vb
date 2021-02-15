Imports MetroFramework

Public Class Conta
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Usertext.Text <> "" And SenhaText.Text <> "" And EmailText.Text <> "" And EmailGerenteText.Text <> "" Then
                If Usertext.Text.ToLower <> Form1.currentuser.user.ToLower And Form1.currentuser.admin = False Then
                    MetroMessageBox.Show(Me, "Erro no registro ,Você não tem permissão de alterar informações outros usuários", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                For Each x1 As User In Form1.database.users
                        If x1.user = Usertext.Text Then
                            x1.user = Usertext.Text
                            x1.Senha = SenhaText.Text
                            x1.Email = EmailText.Text
                        x1.EmailDoGerente = EmailGerenteText.Text
                        x1.admin = Useradmin.Checked
                        Form1.save()
                            MetroMessageBox.Show(Me, "Usuario Atualizado com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        End If
                    Next
                Else
                    MetroMessageBox.Show(Me, "Erro no registro parece que falta alguma informação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message & "erro ao atualizar informação ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Conta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each x1 As User In Form1.database.users
                If x1.user = Form1.currentuser.user Then
                    Usertext.Text = x1.user
                    SenhaText.Text = x1.Senha
                    EmailText.Text = x1.Email
                    EmailGerenteText.Text = x1.EmailDoGerente
                    Useradmin.Checked = x1.admin
                    If Usertext.Text = "admin" Then
                        Usertext.Enabled = False
                        Useradmin.Enabled = False
                    ElseIf Form1.currentuser.admin Then
                        Usertext.Enabled = False
                        Useradmin.Enabled = True
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class