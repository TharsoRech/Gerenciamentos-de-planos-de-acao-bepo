Imports System.Net
Imports MetroFramework
Imports Microsoft.Exchange.WebServices.Data

Public Class Form1
    Public currentuser As New User
    Public database As Database = New Database
    Public templist As New List(Of Ação)
    Public Inicializando As Boolean = True


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim folderdatabase As String = My.Application.Info.DirectoryPath & "\"
            If IO.Directory.Exists(My.Settings.DatabaseLocation) And My.Settings.DatabaseLocation <> "" Then
                folderdatabase = My.Settings.DatabaseLocation & "\"
            Else
                My.Settings.DatabaseLocation = folderdatabase
                My.Settings.Save()
            End If
            If IO.Directory.Exists(My.Settings.DataLocate) Then
                folderdatabase = My.Settings.DataLocate & "\"
                My.Settings.DatabaseLocation = folderdatabase
                My.Settings.Save()
            End If
            If IO.File.Exists(folderdatabase & "Database.Gpab") Then
                Dim infoReader As System.IO.FileInfo
                infoReader = My.Computer.FileSystem.GetFileInfo(folderdatabase & "Database.Gpab")
                Dim sizeInBytes As Long = infoReader.Length
                If IO.File.Exists(folderdatabase & "DatabaseBKP.Gpab") Then
                    Dim infoReader1 As System.IO.FileInfo
                    infoReader1 = My.Computer.FileSystem.GetFileInfo(folderdatabase & "DatabaseBKP.Gpab")
                    Dim sizeInBytes1 As Long = infoReader1.Length
                    If sizeInBytes = 0 Then
                        IO.File.Delete(folderdatabase & "Database.Gpab")
                        IO.File.Copy(folderdatabase & "DatabaseBKP.Gpab", folderdatabase & "Database.Gpab", True)
                        Application.Restart()
                    End If
                End If
            End If
            If IO.File.Exists(folderdatabase & "Database.Gpab") Then
                Dim seri As New ObjectSerializer(Of Database)
                database = seri.GetSerializedObject(folderdatabase & "Database.Gpab")
                save()
            Else
                IO.File.Create(folderdatabase & "Database.Gpab").Close()
                database = New Database
                database.users = New List(Of User)
                database.HistoricodePlanos = New List(Of PlanoDeAção)
                database.listadeexcluidos = New List(Of Ação)
                database.Clientes = New List(Of String)
                save()
                Dim seri3 As New ObjectSerializer(Of Database)
                database = seri3.GetSerializedObject(folderdatabase & "Database.Gpab")
                ' save()
            End If


            If database IsNot Nothing Then
                If IO.File.Exists(folderdatabase & "DatabaseBKP.Gpab") = False Then
                    IO.File.Create(folderdatabase & "DatabaseBKP.Gpab").Close()
                    Dim seri As New ObjectSerializer(Of Database)
                    seri.SaveSerializedObject(database, folderdatabase & "DatabaseBKP.Gpab")
                Else
                    Dim seri As New ObjectSerializer(Of Database)
                    seri.SaveSerializedObject(database, folderdatabase & "DatabaseBKP.Gpab")
                End If
                If My.Application.CommandLineArgs.Count > 0 Then
                    Me.Hide()
                    Checaralertas()
                    Application.Exit()
                Else
                    If database.users.Count = 0 Then
                        Dim news As New User
                        news.admin = True
                        news.user = My.Settings.Admin
                        news.Senha = My.Settings.Senha
                        news.DataCriacao = Date.Now.ToString
                        database.users.Add(news)
                        currentuser = news
                        Me.Text = Me.Text & Space(2) & "-" & currentuser.user
                        save()
                    Else
                        Login.Show()
                        Me.Hide()
                    End If
                    Dim p2 As New Historico
                    p2.Dock = DockStyle.Fill
                    p2.MetroGrid1.UseCustomBackColor = True
                    For Each x1 As User In database.users

                        For Each x2 As PlanoDeAção In x1.Planos
                            Dim aleradyhave As Boolean = False
                            Dim nodetoadd As New TreeNode
                            For Each nd As TreeNode In TreeView1.Nodes
                                If nd.Text = x2.Cliente Then
                                    nodetoadd = nd
                                    aleradyhave = True
                                    Exit For
                                End If
                            Next
                            If aleradyhave = False Then

                                nodetoadd = TreeView1.Nodes.Add(x2.Cliente)
                            End If
                            nodetoadd.Nodes.Add(x2.Numero)
                            For Each ac As Ação In x2.Ações
                                Dim responsaveis As String = ""
                                If ac.Responsáveis Is Nothing Then
                                    ac.Responsáveis = New List(Of String)
                                    save()
                                End If
                                If ac.EmExecução Or ac.Atrasada Then
                                    For Each lt As String In ac.Responsáveis
                                        responsaveis = responsaveis & Before(lt, "@") & ";"
                                    Next
                                    If ac.Ação <> "" Then
                                        p2.MetroGrid1.Rows.Add({x2.Cliente, x2.Origem, x2.Numero, ac.Ação, ac.NãoConformidadeFalha, responsaveis, Before(ac.GerenteEmail, "@"), x2.Inicio, ac.Prazo, ac.Status, ac.Evidência})
                                    End If
                                End If
                            Next
                        Next
                        For i = 0 To p2.MetroGrid1.Rows.Count - 1
                            If p2.MetroGrid1.Rows(i).Cells(9).Value = "Execução" Then
                                p2.MetroGrid1.Rows(i).DefaultCellStyle.BackColor = Color.Gold
                                p2.MetroGrid1.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                                p2.MetroGrid1.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Gold
                            End If
                            If p2.MetroGrid1.Rows(i).Cells(9).Value = "Atrasado" Then
                                p2.MetroGrid1.Rows(i).DefaultCellStyle.BackColor = Color.Red
                                p2.MetroGrid1.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                                p2.MetroGrid1.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Red
                            End If
                        Next

                    Next
                    Dim totaly As Integer = 0
                    Dim concluidas As Integer = 0
                    Dim Previstas As Integer = 0
                    Dim Atrasadas As Integer = 0
                    Dim Emexecução As Integer = 0
                    For Each x1 As User In database.users
                        For Each x2 As PlanoDeAção In x1.Planos
                            totaly = totaly + x2.Ações.Count
                            For Each ac In x2.Ações
                                If ac.concluida Then
                                    concluidas = concluidas + 1
                                End If
                                If ac.Previsto Then
                                    Previstas = Previstas + 1
                                End If
                                If ac.Atrasada Then
                                    Atrasadas = Atrasadas + 1
                                End If
                                If ac.EmExecução Then
                                    Emexecução = Emexecução + 1
                                End If
                            Next
                        Next
                    Next
                    If concluidas > 0 Then
                        Chart1.Series(0).Points(0).IsValueShownAsLabel = True
                    End If
                    If Previstas > 0 Then
                        Chart1.Series(0).Points(1).IsValueShownAsLabel = True
                    End If
                    If Atrasadas > 0 Then
                        Chart1.Series(0).Points(3).IsValueShownAsLabel = True
                    End If
                    If Emexecução > 0 Then
                        Chart1.Series(0).Points(2).IsValueShownAsLabel = True
                    End If
                    Chart1.Series(0).Points(0).SetValueXY(totaly, concluidas)
                    Chart1.Series(0).Points(1).SetValueXY(totaly, Previstas)
                    Chart1.Series(0).Points(3).SetValueXY(totaly, Atrasadas)
                    Chart1.Series(0).Points(2).SetValueXY(totaly, Emexecução)
                    TabPage1.Controls.Add(p2)
                    Inicializando = False
                    MetroTabControl1.SelectedTab = TabPage2
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub save()
        Try
            Dim seri As New ObjectSerializer(Of Database)
            seri.SaveSerializedObject(database, My.Settings.DatabaseLocation & "Database.Gpab")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub exitbutton(sender As Object, e As EventArgs) Handles RibbonOrbMenuItem4.Click
        Try
            Application.Exit()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub newReg(sender As Object, e As EventArgs) Handles NewRegButton.Click
        Try
            NewRegistry.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub configbutton(sender As Object, e As EventArgs) Handles RibbonOrbMenuItem3.Click
        Try
            Configurações.Show()

            Configurações.DatabaseLocationtext.Text = My.Settings.DatabaseLocation & "Database.Gpab"


        Catch ex As Exception

        End Try
    End Sub
    Private Sub newact(sender As Object, e As EventArgs) Handles NewActionButton.Click
        Try
            NovoPlano.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub newcliente(sender As Object, e As EventArgs) Handles addcbutton.Click
        Try
            Clientes.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub newact1(sender As Object, e As EventArgs) Handles RibbonOrbMenuItem1.Click
        Try
            NovoPlano.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub userconfig(sender As Object, e As EventArgs) Handles UserConfigurantionButton.Click
        Try
            Conta.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub userconfig1(sender As Object, e As EventArgs) Handles RibbonOrbMenuItem2.Click
        Try
            Conta.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Historico1(sender As Object, e As EventArgs) Handles AgendaButton.Click
        Try
            Histórico_de_Plano_de_Ação.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Alerrtas1(sender As Object, e As EventArgs) Handles CheckActionButton.Click
        Try
            AlertasControlvb.Show()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub itensexcludios(sender As Object, e As EventArgs) Handles ListaExcluidos.Click
        Try
            ListadeExcluidos.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Try
            If e.Node.Parent IsNot Nothing Then
                templist.Clear()
                If Inicializando = False Then
                    MetroTabControl1.SelectedTab = TabPage1
                    If TabPage2 IsNot Nothing Then
                        MetroTabControl1.TabPages.Remove(TabPage2)
                    End If
                End If
                    For Each x1 As User In database.users
                        For Each x2 As PlanoDeAção In x1.Planos
                            If x2.Numero.ToLower = e.Node.Text.ToLower Then
                                TabPage1.Controls.Clear()
                                Dim newpl As New PlanoControl
                                If currentuser.admin = False And x1.user.ToLower <> currentuser.user.ToLower Then

                                    newpl.Cliente.Enabled = False
                                    newpl.Origem.Enabled = False
                                    newpl.NumeroPlano.Enabled = False

                                    newpl.addacao.Enabled = False
                                    newpl.EditarAcao.Enabled = False

                                    newpl.SalvarAlteracoes.Enabled = False
                                    newpl.Inicio.Enabled = False

                                End If
                                For Each x11 As String In database.Clientes
                                    newpl.Cliente.Items.Add(x11)
                                Next
                                newpl.Cliente.Text = x2.Cliente
                                newpl.Origem.Text = x2.Origem
                                newpl.NumeroPlano.Text = x2.Numero

                                If x2.Ações Is Nothing Then
                                    x2.Ações = New List(Of Ação)
                                End If
                                For Each ac As Ação In x2.Ações
                                    Dim responsaveis As String = ""
                                    If ac.Responsáveis Is Nothing Then
                                        ac.Responsáveis = New List(Of String)
                                        save()
                                    End If
                                    For Each lt As String In ac.Responsáveis
                                        responsaveis = responsaveis & lt & ";"
                                    Next
                                    If ac.Ação <> "" Then
                                        newpl.MetroGrid1.Rows.Add({ac.NãoConformidadeFalha, ac.Ação, responsaveis, ac.GerenteEmail, ac.Evidência, ac.Prazo, ac.Status})
                                    End If
                                Next
                                newpl.Inicio.Text = x2.Inicio
                                newpl.ATualizado.Text = "Alterado pela última vez na data:" & x2.Atualização & ",Pelo usuário:" & x2.AlteradorPor
                                For i = 0 To newpl.MetroGrid1.Rows.Count - 1
                                    If newpl.MetroGrid1.Rows(i).Cells(6).Value = "Previsto" Then
                                        newpl.MetroGrid1.Rows(i).DefaultCellStyle.BackColor = Color.DodgerBlue
                                        newpl.MetroGrid1.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                                        newpl.MetroGrid1.Rows(i).DefaultCellStyle.SelectionBackColor = Color.DodgerBlue
                                    End If
                                    If newpl.MetroGrid1.Rows(i).Cells(6).Value = "Execução" Then
                                        newpl.MetroGrid1.Rows(i).DefaultCellStyle.BackColor = Color.Gold
                                        newpl.MetroGrid1.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                                        newpl.MetroGrid1.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Gold
                                    End If
                                    If newpl.MetroGrid1.Rows(i).Cells(6).Value = "Atrasado" Then
                                        newpl.MetroGrid1.Rows(i).DefaultCellStyle.BackColor = Color.Red
                                        newpl.MetroGrid1.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                                        newpl.MetroGrid1.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Red
                                    End If
                                    If newpl.MetroGrid1.Rows(i).Cells(6).Value = "Concluido" Then
                                        newpl.MetroGrid1.Rows(i).DefaultCellStyle.BackColor = Color.Green
                                        newpl.MetroGrid1.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                                        newpl.MetroGrid1.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Green
                                    End If
                                Next
                                TabPage1.Controls.Add(newpl)
                            End If
                        Next
                        '   End If
                    Next
                End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Public Sub Checaralertas()
        Try

            For Each x1 As User In database.users
                For Each x2 As PlanoDeAção In x1.Planos
                    For Each ac1 As Ação In x2.Ações
                        Dim responsaveis As String = ""
                        If ac1.Responsáveis Is Nothing Then
                            ac1.Responsáveis = New List(Of String)
                            save()
                        End If
                        For Each lt As String In ac1.Responsáveis
                            responsaveis = responsaveis & Before(lt, "@") & ";"
                        Next
                        Dim expenddt As Date = DateTime.Parse(ac1.Prazo)
                        If (expenddt - Now.Date).TotalDays < 0 And ac1.concluida = False Then
                            ac1.Status = "Atrasado"
                            ac1.Atrasada = True
                            ac1.EmExecução = False
                            ac1.Previsto = False
                            save()
                        End If
                        If (expenddt - Now.Date).TotalDays = -database.DiaApós And ac1.concluida = False Then
                            If loginews() Then

                                Dim html1 As String = ""
                                Dim teste1 As String = "<table style=""width:100%"" border=""1"" cellspacing=""2""><tr><th>Plano de ação</th></tr></table><table style = ""width:100%"" border=""1"" cellspacing=""2""><tr>
    <td width = ""18%"" >Empresa :<b> Bepo</td>
     <td width = ""20%"" >Data Atualização:<b>" & x2.Atualização & ",Pelo usuário:" & x2.AlteradorPor & "</td>
  </tr> 
  <tr>
    <td width = ""18%"" >Elaborador Por:<b> " & x1.user & "</td>
     <td width = ""20%"" >Aprovador Por:<b>" & Before(ac1.GerenteEmail, "@") & "</td>
  </tr>
</table>"
                                html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><div><font color=""red"">Atenção:</font><div><strong>Esse email é enviado automaticamente para alerta e avisos de planos de ações,por favor não responda esse email.</strong><body><p align=""center"" style = ""font-size:36px"">Plano de Ação Atrasado - 1° ADVERTÊNCIA:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio</th><th>Prazo</th><th>Status</th><th>Evidência</th></tr>"
                                If ac1.Ação <> "" Then
                                    html1 = html1 & "<tr  bgcolor=""red""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac1.NãoConformidadeFalha & "</th>" & "<th>" & ac1.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac1.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac1.Prazo & "</th><th>" & ac1.Status & "</th><th>" & ac1.Evidência & "</th></tr>"
                                End If
                                If sendmessage(html1, ac1.Responsáveis, ac1.GerenteEmail, database.Enviarresponsável1aviso, database.Enviargerente1aviso) Then

                                End If
                            End If
                            End If
                        If (expenddt - Now.Date).TotalDays = -database.DiadoUltimoaviso And ac1.concluida = False Then
                            If loginews() Then
                                Dim html1 As String = ""
                                Dim teste1 As String = "<table style=""width:100%"" border=""1"" cellspacing=""2""><tr><th>Plano de ação</th></tr></table><table style = ""width:100%"" border=""1"" cellspacing=""2""><tr>
    <td width = ""18%"" >Empresa :<b> Bepo</td>
     <td width = ""20%"" >Data Atualização:<b>" & x2.Atualização & ",Pelo usuário:" & x2.AlteradorPor & "</td>
  </tr> 
  <tr>
    <td width = ""18%"" >Elaborador Por:<b> " & x1.user & "</td>
     <td width = ""20%"" >Aprovador Por:<b>" & Before(ac1.GerenteEmail, "@") & "</td>
  </tr>
</table>"
                                html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><div><font color=""red"">Atenção:</font><div><strong>Esse email é enviado automaticamente para alerta e avisos de planos de ações,por favor não responda esse email.</strong><body><p align=""center"" style = ""font-size:36px"">Plano de Ação Atrasado - 2° ADVERTÊNCIA:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio</th><th>Prazo</th><th>Status</th><th>Evidência</th></tr>"

                                If ac1.Ação <> "" Then
                                    html1 = html1 & "<tr  bgcolor=""red""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac1.NãoConformidadeFalha & "</th>" & "<th>" & ac1.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac1.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac1.Prazo & "</th><th>" & ac1.Status & "</th><th>" & ac1.Evidência & "</th></tr>"
                                End If

                                If sendmessage(html1, ac1.Responsáveis, ac1.GerenteEmail, database.Enviarresponsávelultimoaviso, database.Enviargerenteultimoaviso) Then

                                End If
                            End If
                            End If

                        If ac1.Atrasada Then
                            Dim newl As New Alerta
                            newl.Status = ac1.Status
                            newl.Prazo = ac1.Prazo
                            newl.Inicio = x2.Inicio
                            newl.Cliente = x2.Cliente
                            newl.Responsáveis = ac1.Responsáveis
                            newl.Gerente = ac1.GerenteEmail
                            newl.NúmeroPlanodeAção = x2.Numero
                            newl.Ação = ac1.Ação
                            newl.Falha = ac1.NãoConformidadeFalha
                            newl.Mensagem = "O Plano de ação atrasado."
                            database.Alertas.Add(newl)
                            save()
                        End If
                        If (expenddt - DateTime.Parse(x2.Inicio)).TotalDays = database.DiasAntes And ac1.concluida = False Then
                            ac1.EmExecução = True
                            ac1.Atrasada = False
                            ac1.Previsto = False
                            ac1.concluida = False
                            ac1.Status = "Execução"
                            save()
                            Dim html1 As String = ""
                            Dim teste1 As String = "<table style=""width:100%"" border=""1"" cellspacing=""2""><tr><th>Plano de ação</th></tr></table><table style = ""width:100%"" border=""1"" cellspacing=""2""><tr>
    <td width = ""18%"" >Empresa :<b> Bepo</td>
     <td width = ""20%"" >Data Atualização:<b>" & x2.Atualização & ",Pelo usuário:" & x2.AlteradorPor & "</td>
  </tr> 
  <tr>
    <td width = ""18%"" >Elaborador Por:<b> " & x1.user & "</td>
     <td width = ""20%"" >Aprovador Por:<b>" & Before(ac1.GerenteEmail, "@") & "</td>
  </tr>
</table>"
                            Dim mensagem As String = "Plano de ação  em andamento"
                            html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><div><font color=""red"">Atenção:</font><div><strong>Esse email é enviado automaticamente para alerta e avisos de planos de ações,por favor não responda esse email.</strong><body><p align=""center"" style = ""font-size:36px"">" & mensagem & " :</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio</th><th>Prazo</th><th>Status</th><th>Evidência</th></tr>"
                            html1 = html1 & "<tr  bgcolor=""Yellow""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac1.NãoConformidadeFalha & "</th>" & "<th>" & ac1.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac1.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac1.Prazo & "</th><th>" & ac1.Status & "</th><th>" & ac1.Evidência & "</th></tr>"

                            If sendmessage(html1, ac1.Responsáveis, ac1.GerenteEmail, database.Enviarresponsávelantes, database.Enviargerenteantes) Then

                            End If
                        End If
                            If ac1.EmExecução Then
                            Dim newl As New Alerta
                            newl.Prazo = ac1.Prazo
                            newl.Inicio = x2.Inicio
                            newl.Cliente = x2.Cliente
                            newl.Responsáveis = ac1.Responsáveis
                            newl.Gerente = ac1.GerenteEmail
                            newl.NúmeroPlanodeAção = x2.Numero
                            newl.Ação = ac1.Ação
                            newl.Falha = ac1.NãoConformidadeFalha
                            newl.Mensagem = "Plano de ação em andamento"
                            database.Alertas.Add(newl)
                            save()
                        End If
                    Next
                Next
            Next
        Catch ex As Exception
            ' MsgBox(ex.Message & ex.StackTrace)
        End Try

    End Sub
    Public Function loginews() As Boolean
        Dim ok As Boolean = False
        Try
            Dim user As String = database.Emailadmin
            Dim pass As String = database.Senhaadmin
            Dim server As String = database.servidorEmail
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
    Public Function sendmessage(ByVal html As String, ByVal emailresponsavel As List(Of String), ByVal gerenteemail As String, ByVal avisarresponsável As Boolean, ByVal AvisarGerente As Boolean) As Boolean
        Dim send As Boolean = False
        Try
            Dim user As String = database.Emailadmin
            Dim pass As String = database.Senhaadmin
            Dim server As String = database.servidorEmail
            Dim service As New Global.Microsoft.Exchange.WebServices.Data.ExchangeService
            service.Credentials = New WebCredentials(user, pass, Environment.UserDomainName)
            service.Url = New Uri("https://" & server & "/ews/Exchange.asmx")
            Try
                Dim message As New EmailMessage(service)
                message.Subject = "Alerta de Plano de Ação!!!"
                message.Body = New MessageBody(BodyType.HTML, html)
                If avisarresponsável = True Then
                    For Each em As String In emailresponsavel
                        message.ToRecipients.Add(em)
                    Next
                End If
                If AvisarGerente = True Then
                    message.ToRecipients.Add(gerenteemail)
                End If
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

    Function Before(value As String, a As String) As String
        Dim value1 As String = value
        Try
            ' Get index of argument and return substring up to that point.
            Dim posA As Integer = value.IndexOf(a)
            If posA = -1 Then
                Return ""
            End If
            Return value.Substring(0, posA)
        Catch ex As Exception
            Return value1
        End Try
    End Function

End Class
