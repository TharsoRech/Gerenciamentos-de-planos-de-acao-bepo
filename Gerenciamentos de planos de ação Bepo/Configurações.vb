Imports System.Deployment.Application
Imports MetroFramework
Imports Microsoft.Exchange.WebServices.Data
Imports Microsoft.Win32.TaskScheduler

Public Class Configurações
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Process.Start(IO.Path.GetDirectoryName(DatabaseLocationtext.Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Try
            For Each x2 As DataGridViewRow In MetroGrid1.SelectedRows
                For Each x1 As User In Form1.database.users
                    If x1.user = x2.Cells(0).Value Then
                        Conta.Show()
                        Conta.Usertext.Text = x1.user
                        Conta.SenhaText.Text = x1.Senha
                        Conta.EmailText.Text = x1.Email
                        Conta.EmailGerenteText.Text = x1.EmailDoGerente
                        If Conta.Usertext.Text.ToLower = "admin".ToLower Then
                            Conta.Useradmin.Enabled = False
                        Else
                            Conta.Useradmin.Enabled = True
                        End If

                        Conta.Useradmin.Checked = x1.admin

                    End If
                Next
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Configurações_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Form1.database.Emailadmin <> "" Then
                Email.Text = Form1.database.Emailadmin
                Senha.Text = Form1.database.Senhaadmin
                Servidor.Text = Form1.database.servidorEmail
            End If
            If Form1.database.users.Count <= 1 Then
                MetroContextMenu1.Enabled = False
            End If
            For Each x1 As User In Form1.database.users
                Dim isadmin As String = "Não"
                If x1.admin Then
                    isadmin = "Sim"
                End If
                MetroGrid1.Rows.Add({x1.user, x1.Email, x1.EmailDoGerente, x1.DataCriacao, isadmin})
            Next
            If Form1.currentuser.user = "admin" Then
                Email.Enabled = True
                Senha.Enabled = True
                Servidor.Enabled = True
                Button2.Enabled = True
                Button3.Enabled = True
                Veragendamentos.Enabled = True
                TornarServidor.Enabled = True
            End If
            Antesresponsavel.Checked = Form1.database.Enviarresponsávelantes
            AntesDiretor.Checked = Form1.database.Enviargerenteantes
            AposResponsavel.Checked = Form1.database.Enviarresponsável1aviso
            AposDiretor.Checked = Form1.database.Enviargerente1aviso
            Aposutlimoresponsavel.Checked = Form1.database.Enviarresponsávelultimoaviso
            AposUltimoDiretor.Checked = Form1.database.Enviargerenteultimoaviso
            CurrentVersion.Text = String.Format("Planos de ação bepo - v{0}", ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4))

        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoverToolStripMenuItem.Click
        Try
            For Each x2 As DataGridViewRow In MetroGrid1.SelectedRows
                For Each x1 As User In Form1.database.users
                    If x2.Cells(0).Value.ToString.ToLower = "admin".ToLower Then
                        MetroMessageBox.Show(Me, "O usuário admin não pode ser excluido,Operaçaõ cancelada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    If x1.user = x2.Cells(0).Value Then
                        Form1.database.users.Remove(x1)
                        Form1.save()
                        MetroGrid1.Rows.Remove(x2)
                        MetroMessageBox.Show(Me, "Usuario Removido com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Form1.TreeView1.Nodes.Clear()

                        For Each x4 As User In Form1.database.users
                            For Each x3 As PlanoDeAção In x4.Planos
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
                    End If
                Next
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If login() Then
                Form1.database.Emailadmin = Email.Text
                Form1.database.Senhaadmin = Senha.Text
                Form1.database.servidorEmail = Servidor.Text
                Form1.save()
                MetroMessageBox.Show(Me, "Conta de Email configurada com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroMessageBox.Show(Me, "Não foi possivel configurar essa conta de email ,verifique se suas informações estão corretas ou se há conexão com a internet", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Function login() As Boolean
        Dim ok As Boolean = False
        Try
            Dim user As String = Email.Text
            Dim pass As String = Senha.Text
            Dim server As String = Servidor.Text
            Dim service As New Global.Microsoft.Exchange.WebServices.Data.ExchangeService
            service.Credentials = New WebCredentials(user, pass, Environment.UserDomainName)
            service.Url = New Uri("https://" & server & "/ews/Exchange.asmx")
            Dim rootfolder As Folder = Folder.Bind(service, WellKnownFolderName.MsgFolderRoot)
            'A GetFolder operation has been performed.
            'Now do something with the folder, such as display each child folder's name and id.
            rootfolder.Load()
            If rootfolder.FindFolders(New FolderView(100)).Count <> 0 Then
                ok = True
                Return ok
            End If
            Return ok
        Catch ex As Exception
            Return ok
        End Try
    End Function

    Private Sub Antesresponsavel_CheckedChanged(sender As Object, e As EventArgs) Handles Antesresponsavel.CheckedChanged
        Try
            Form1.database.Enviarresponsávelantes = Antesresponsavel.Checked
            Form1.save()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AntesDiretor_CheckedChanged(sender As Object, e As EventArgs) Handles AntesDiretor.CheckedChanged
        Try
            Form1.database.Enviargerenteantes = AntesDiretor.Checked
            Form1.save()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AposResponsavel_CheckedChanged(sender As Object, e As EventArgs) Handles AposResponsavel.CheckedChanged
        Try
            Form1.database.Enviarresponsável1aviso = AposResponsavel.Checked
            Form1.save()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AposDiretor_CheckedChanged(sender As Object, e As EventArgs) Handles AposDiretor.CheckedChanged
        Try
            Form1.database.Enviargerente1aviso = AposDiretor.Checked
            Form1.save()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Aposutlimoresponsavel_CheckedChanged(sender As Object, e As EventArgs) Handles Aposutlimoresponsavel.CheckedChanged
        Try
            Form1.database.Enviarresponsávelultimoaviso = Aposutlimoresponsavel.Checked
            Form1.save()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AposUltimoDiretor_CheckedChanged(sender As Object, e As EventArgs) Handles AposUltimoDiretor.CheckedChanged
        Try
            Form1.database.Enviargerenteultimoaviso = AposUltimoDiretor.Checked
            Form1.save()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DiasAntes_ValueChanged(sender As Object, e As EventArgs) Handles DiasAntes.ValueChanged
        Try
            Form1.database.DiasAntes = DiasAntes.Value
            Form1.save()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DiasApos_ValueChanged(sender As Object, e As EventArgs) Handles DiasApos.ValueChanged
        Try
            Form1.database.DiaApós = DiasApos.Value
            Form1.save()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DiasAposUltimo_ValueChanged(sender As Object, e As EventArgs) Handles DiasAposUltimo.ValueChanged
        Try
            Form1.database.DiadoUltimoaviso = DiasAposUltimo.Value
            Form1.save()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TornarServidor_Click(sender As Object, e As EventArgs) Handles TornarServidor.Click

        Try
            Using ts As New TaskService(My.Computer.Name)
                ' Create a new task definition and assign properties
                Dim td As TaskDefinition = ts.NewTask()
                td.Principal.LogonType = TaskLogonType.InteractiveToken
                td.RegistrationInfo.Description = "Checar Alertas"
                td.Data = HorarioInicial.Text
                td.Triggers.Add(New WeeklyTrigger(DaysOfTheWeek.AllDays, 1)).StartBoundary = Convert.ToDateTime(HorarioInicial.Text)
                td.Triggers.Add(New WeeklyTrigger(DaysOfTheWeek.AllDays, 1)).StartBoundary = Convert.ToDateTime(HorarioFinal.Text)
                ' Create an ac.Ação that will launch Notepad whenever the trigger fires
                td.Actions.Add(New ExecAction(Application.ExecutablePath, "Check"))

                ' Register the task in the root folder
                ts.RootFolder.RegisterTaskDefinition("Checar alertas", td, TaskCreation.CreateOrUpdate, UsuarioWindows.Text, SenhaWindows.Text, TaskLogonType.InteractiveTokenOrPassword, Nothing)
                MetroMessageBox.Show(Me, "Agendamento Concluido com Sucesso", "Agendamento", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Veragendamentos.Click
        Try
            Process.Start("Taskschd.msc")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class