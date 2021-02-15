Imports System.Net
Imports MetroFramework
Imports Microsoft.Exchange.WebServices.Data

Public Class Contatar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Alteracaosenha_CheckedChanged(sender As Object, e As EventArgs) Handles Alteracaosenha.Click
        Try
            If Alteracaosenha.Checked Then
                addcl.Checked = False
                Outros.Checked = False
                Enviar.Enabled = True
            Else
                Enviar.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub addcl_CheckedChanged(sender As Object, e As EventArgs) Handles addcl.Click
        Try
            If addcl.Checked Then
                Alteracaosenha.Checked = False
                Outros.Checked = False
                Enviar.Enabled = True
            Else
                Enviar.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Outros_CheckedChanged(sender As Object, e As EventArgs) Handles Outros.CheckedChanged
        Try
            If Outros.Checked Then
                Alteracaosenha.Checked = False
                addcl.Checked = False
                Enviar.Enabled = True
            Else
                Enviar.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Contatar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each x1 As User In Form1.database.users
                If x1.admin Then
                    admins.Items.Add(x1.Email)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Enviar_Click(sender As Object, e As EventArgs) Handles Enviar.Click
        Try
            Dim html1 As String = ""
            Dim subject As String = ""
            If User.Text = "" Then
                User.Text = Environment.UserName
            End If
            If Alteracaosenha.Checked Then
                subject = "Pedido de alteração de senha-Planos de ação bepo"
                html1 = html1 & "<div><font color=""red"">Atenção:</font><div><strong>O usuário" & Space(2) & User.Text & Space(2) & "Requisitou que a sua senha seja trocada. </strong>"
            End If
            If addcl.Checked Then
                subject = "Novo cliente ou remoçao de cliente"
                html1 = html1 & "<div><font color=""red"">Atenção:</font><div><strong>O usuário" & Space(2) & User.Text & Space(2) & "Requisitou uma remoçaõ ou adição de cliente: </strong>"
            End If
            If Outros.Checked Then
                subject = "Suporte ao usuário"
                html1 = html1 & "<div><font color=""red"">Atenção:</font><div><strong>O usuário" & Space(2) & User.Text & Space(2) & "precisa de assistência: </strong>"
            End If
            html1 = html1 & "<br>" & Mensagem.Text
            If sendmessage(html1, admins.Text, subject) Then
                MetroMessageBox.Show(Me, "Email enviado com sucesso", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MetroMessageBox.Show(Me, "erro ao enviar email", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Function sendmessage(ByVal html As String, ByVal emailresponsavel As String, ByVal subject As String) As Boolean
        Dim send As Boolean = False
        Try
            Dim user As String = Form1.database.Emailadmin
            Dim pass As String = Form1.database.Senhaadmin
            Dim server As String = Form1.database.servidorEmail
            Dim service As New Global.Microsoft.Exchange.WebServices.Data.ExchangeService
            service.Credentials = New WebCredentials(user, pass, Environment.UserDomainName)
            service.Url = New Uri("https://" & server & "/ews/Exchange.asmx")
            Try

                Dim message As New EmailMessage(service)
                message.Subject = subject
                message.Body = New MessageBody(BodyType.HTML, html)
                message.ToRecipients.Add(emailresponsavel)
                message.Send()
                send = True
                Return send
            Catch ex As ServiceRequestException
                Return send

            Catch ex As WebException
                Return send
            End Try
            Return send
        Catch ex As Exception
            Return send
        End Try
        Return send
    End Function


End Class