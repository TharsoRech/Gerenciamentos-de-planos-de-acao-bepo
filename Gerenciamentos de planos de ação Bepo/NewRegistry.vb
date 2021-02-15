Imports MetroFramework

Public Class NewRegistry
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If Usertext.Text <> "" And SenhaText.Text <> "" And EmailText.Text <> "" And EmailGerenteText.Text <> "" Then
                For Each x1 As User In Form1.database.users
                    If x1.user = Usertext.Text Then
                        MetroMessageBox.Show(Me, "Erro no registro ,Usuário já existente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next
                Dim news As New User
                news.admin = Useradmin.Checked
                news.user = Usertext.Text
                news.Senha = SenhaText.Text
                news.DataCriacao = Date.Now.ToString
                news.EmailDoGerente = EmailGerenteText.Text
                news.Email = EmailText.Text
                Form1.database.users.Add(news)
                Form1.save()
                MetroMessageBox.Show(Me, "Usuario Registrado com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form1.TreeView1.Nodes.Clear()
                For Each x14 As User In Form1.database.users
                    For Each x3 As PlanoDeAção In x14.Planos
                        Dim aleradyhave As Boolean = False
                        Dim nodetoadd As New TreeNode
                        For Each nd As TreeNode In Form1.TreeView1.Nodes
                            If nd.Text = x3.Cliente Then
                                nodetoadd = nd
                                aleradyhave = True
                                Exit For
                            End If
                        Next
                        If aleradyhave = False Then
                            nodetoadd = Form1.TreeView1.Nodes.Add(x3.Cliente)
                        End If
                        nodetoadd.Nodes.Add(x3.Numero)
                    Next
                Next
                Me.Close()
            Else
                MetroMessageBox.Show(Me, "Erro no registro parece que falta alguma informação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class