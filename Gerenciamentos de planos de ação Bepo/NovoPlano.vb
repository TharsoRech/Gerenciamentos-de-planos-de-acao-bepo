Imports System.Deployment.Application
Imports MetroFramework

Public Class NovoPlano

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If Cliente.Text <> "" And Origem.Text <> "" And NumeroPlano.Text <> "" And MetroGrid1.Rows.Count > 0 Then
                Dim newpl As New PlanoDeAção
                newpl.Cliente = Cliente.Text
                newpl.CriadorPor = Form1.currentuser.user
                newpl.Origem = Origem.Text
                newpl.Numero = NumeroPlano.Text

                For Each x10 As DataGridViewRow In MetroGrid1.Rows
                    If x10.Cells(0).Value <> "" Then
                        Dim newac As New Ação
                        newac.NãoConformidadeFalha = x10.Cells(0).Value
                        newac.Ação = x10.Cells(1).Value
                        Dim words As String() = x10.Cells(2).Value.Split(New Char() {";"c})
                        If newac.Responsáveis Is Nothing Then
                            newac.Responsáveis = New List(Of String)
                        End If
                        For Each word In words
                            If word.Contains("@") Then
                                newac.Responsáveis.Add(word)
                            End If
                        Next
                        newac.GerenteEmail = x10.Cells(3).Value
                        newac.Evidência = x10.Cells(4).Value
                        newac.Status = "Previsto"
                        newac.Previsto = True
                        newac.Inicio = x10.Cells(6).Value
                        newac.Prazo = x10.Cells(7).Value
                        newac.Aprovado = x10.Cells(8).Value
                        newac.AvaliadorPor = x10.Cells(9).Value
                        newac.Pontuacao = x10.Cells(10).Value
                        newac.Obs = x10.Cells(11).Value
                        newpl.Ações.Add(newac)
                        Dim evidenciacaminho = newac.Evidência
                            If IO.Directory.Exists(My.Settings.DatabaseLocation & "\" & Cliente.Text) Then
                                Dim count As Integer = 0
                                Dim fileNameOnly As String = IO.Path.GetFileNameWithoutExtension(evidenciacaminho)
                                Dim extension As String = IO.Path.GetExtension(evidenciacaminho)
                                Dim path As String = My.Settings.DatabaseLocation & "\" & Cliente.Text
                                Dim newFullPath As String = My.Settings.DatabaseLocation & "\" & Cliente.Text & "\" & IO.Path.GetFileName(evidenciacaminho)
                                While IO.File.Exists(newFullPath)
                                    Dim tempFileName As String = fileNameOnly & count + 1
                                    newFullPath = IO.Path.Combine(path, (tempFileName + extension))
                                    count = count + 1
                                End While
                                If IO.File.Exists(evidenciacaminho) Then
                                    IO.File.Copy(evidenciacaminho, newFullPath, True)
                                    newac.Evidência = newFullPath
                                End If
                            Else
                                IO.Directory.CreateDirectory(My.Settings.DatabaseLocation & "\" & Cliente.Text)
                                Dim count As Integer = 0
                                Dim fileNameOnly As String = IO.Path.GetFileNameWithoutExtension(evidenciacaminho)
                                Dim extension As String = IO.Path.GetExtension(evidenciacaminho)
                                Dim path As String = My.Settings.DatabaseLocation & "\" & Cliente.Text
                                Dim newFullPath As String = My.Settings.DatabaseLocation & "\" & Cliente.Text & "\" & IO.Path.GetFileName(evidenciacaminho)
                                While IO.File.Exists(newFullPath)
                                    Dim tempFileName As String = fileNameOnly & count + 1
                                    newFullPath = IO.Path.Combine(path, (tempFileName + extension))
                                    count = count + 1
                                End While
                                If IO.File.Exists(evidenciacaminho) Then
                                    IO.File.Copy(evidenciacaminho, newFullPath, True)
                                    newac.Evidência = newFullPath
                                End If
                            End If
                        End If
                Next
                newpl.Inicio = Inicio.Text
                newpl.Atualização = DateTime.Now.ToString("yyyy-MM-dd HH:mm tt")

                For Each x1 As User In Form1.database.users
                    If x1.user = Form1.currentuser.user Then
                        newpl.AlteradorPor = x1.user
                        For Each x2 As PlanoDeAção In x1.Planos
                            If x2.Numero = NumeroPlano.Text Then
                                MetroMessageBox.Show(Me, "Erro ao adicionar novo plano ,Plano já existente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        Next

                        If Form1.database.HistoricodePlanos IsNot Nothing Then
                            Form1.database.HistoricodePlanos.Add(newpl)
                        Else
                            Form1.database.HistoricodePlanos = New List(Of PlanoDeAção)
                            Form1.database.HistoricodePlanos.Add(newpl)
                        End If
                        x1.Planos.Add(newpl)
                        Form1.save()
                        enviaralerta(NumeroPlano.Text)
                        MetroMessageBox.Show(Me, "Novo Plano adicionado com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                    End If
                Next
            Else
                MetroMessageBox.Show(Me, "Erro ao adicionar novo plano ,Parece estar faltando alguma informação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MetroMessageBox.Show(Me, ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

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

    Public Sub enviaralerta(ByVal selectaAlert As String)
        Try
            For Each x1 As User In Form1.database.users
                For Each x2 As PlanoDeAção In x1.Planos
                    If x2.Numero = selectaAlert Then
                        For Each ac As Ação In x2.Ações

                            Dim responsaveis As String = ""
                            If ac.Responsáveis Is Nothing Then
                                ac.Responsáveis = New List(Of String)
                                Form1.save()
                            End If
                            For Each lt As String In ac.Responsáveis
                                responsaveis = responsaveis & Before(lt, "@") & ";"
                            Next
                            Dim html1 As String = ""
                            Dim teste1 As String = "<table style=""width:100%"" border=""1"" cellspacing=""2""><tr><th>Plano de ação</th></tr></table><table style = ""width:100%"" border=""1"" cellspacing=""2""><tr>
    <td width = ""18%"" >Empresa :<b> Bepo</td>
     <td width = ""20%"" >Data Atualização:<b>" & x2.Atualização & ",Pelo usuário:" & x2.AlteradorPor & "</td>
  </tr> 
  <tr>
    <td width = ""18%"" >Elaborador Por:<b> " & x1.user & "</td>
     <td width = ""20%"" >Avaliador Por:<b>" & ac.AvaliadorPor & "</td>
  </tr>
</table>"
                            If ac.Atrasada Then
                                html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><div><font color=""red"">Atenção plano de ação Criado:</font><div><strong>Esse email é enviado automaticamente para alerta e avisos de planos de ações,por favor não responda esse email.</strong><body><p align=""center"" style = ""font-size:36px"">Plano de Ação Atrasado:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                If ac.Ação <> "" Then
                                    html1 = html1 & "<tr  bgcolor=""red""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                End If
                            End If
                            If ac.Previsto Then
                                html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><div><font color=""red"">Atenção plano de ação Criado:</font><div><strong>Esse email é enviado automaticamente para alerta e avisos de planos de ações,por favor não responda esse email.</strong><body><p align=""center"" style = ""font-size:36px"">Plano De Ação Previsto:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                If ac.Ação <> "" Then
                                    html1 = html1 & "<tr  bgcolor=""DodgerBlue""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                End If

                            End If
                            If ac.EmExecução Then
                                html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><div><font color=""red"">Atenção plano de ação Criado:</font><div><strong>Esse email é enviado automaticamente para alerta e avisos de planos de ações,por favor não responda esse email.</strong><body><p align=""center"" style = ""font-size:36px"">Plano de ação em Andamento:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                If ac.Ação <> "" Then
                                    html1 = html1 & "<tr  bgcolor=""Yellow""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                End If
                            End If
                            If ac.concluida Then
                                html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><div><font color=""red"">Atenção plano de ação Criado:</font><div><strong>Esse email é enviado automaticamente para alerta e avisos de planos de ações,por favor não responda esse email.</strong><body><p align=""center"" style = ""font-size:36px"">Plano de ação concluido:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                If ac.Ação <> "" Then
                                    html1 = html1 & "<tr  bgcolor=""Green""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                End If
                            End If
                            Form1.sendmessage(html1, ac.Responsáveis, ac.GerenteEmail, True, False)
                        Next
                    End If
                Next
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub removeracao_Click(sender As Object, e As EventArgs) Handles removeracao.Click
        Try
            For Each x10 As DataGridViewRow In MetroGrid1.SelectedRows
                MetroGrid1.Rows.Remove(x10)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub addacao_Click(sender As Object, e As EventArgs) Handles addacao.Click
        Try
            Addaction.Gridtoadd = MetroGrid1
            Addaction.Status.Text = "Previsto"
            Addaction.Status.Enabled = False
            Addaction.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles EditarAcao.Click
        Try
            Dim words As String() = MetroGrid1.SelectedRows(0).Cells(2).Value.Split(New Char() {";"c})
            For Each word In words
                If word.Contains("@") Then
                    Addaction.TreeView1.Nodes.Add(word)
                End If
            Next
            Addaction.Gridtoadd = MetroGrid1
            Addaction.Selectrow1 = MetroGrid1.SelectedRows(0)
            Addaction.Falha.Text = MetroGrid1.SelectedRows(0).Cells(0).Value.ToString
            Addaction.Acao.Text = MetroGrid1.SelectedRows(0).Cells(1).Value.ToString
            Addaction.GerenteEmail.Text = MetroGrid1.SelectedRows(0).Cells(3).Value.ToString
            Addaction.Evidencia.Text = MetroGrid1.SelectedRows(0).Cells(4).Value.ToString
            Addaction.Prazo.Text = MetroGrid1.SelectedRows(0).Cells(5).Value.ToString
            Addaction.Status.Text = MetroGrid1.SelectedRows(0).Cells(6).Value.ToString
            Addaction.addacao.Text = "Atualizar Ação"
            Addaction.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles abrirevidencia.Click
        Try
            Try
                If IO.File.Exists(MetroGrid1.SelectedRows(0).Cells(4).Value.ToString) Then
                    Process.Start(MetroGrid1.SelectedRows(0).Cells(4).Value.ToString)
                Else
                    MetroMessageBox.Show(Form1, "Arquivo Não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentDoubleClick
        Try
            Dim words As String() = MetroGrid1.SelectedRows(0).Cells(2).Value.Split(New Char() {";"c})
            For Each word In words
                If word.Contains("@") Then
                    Addaction.TreeView1.Nodes.Add(word)
                End If
            Next
            Addaction.Gridtoadd = MetroGrid1
            Addaction.Selectrow1 = MetroGrid1.SelectedRows(0)
            Addaction.Falha.Text = MetroGrid1.SelectedRows(0).Cells(0).Value.ToString
            Addaction.Acao.Text = MetroGrid1.SelectedRows(0).Cells(1).Value.ToString
            Addaction.GerenteEmail.Text = MetroGrid1.SelectedRows(0).Cells(3).Value.ToString
            Addaction.Evidencia.Text = MetroGrid1.SelectedRows(0).Cells(4).Value.ToString
            Addaction.Prazo.Text = MetroGrid1.SelectedRows(0).Cells(5).Value.ToString
            Addaction.Status.Text = MetroGrid1.SelectedRows(0).Cells(6).Value.ToString
            Addaction.addacao.Text = "Atualizar Ação"
            Addaction.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NovoPlano_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each x1 As String In Form1.database.Clientes
                Cliente.Items.Add(x1)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Try
            If Form1.currentuser.admin = False Then
                MetroMessageBox.Show(Me, "Você precisa ser administrador para adicionar um cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim Prompt As String = "Informe o cliente "
                Dim Titulo As String = "Adicionar Cliente"
                Dim valorRetornado As String = ""

                valorRetornado = InputBox(Prompt, Titulo)
                Cliente.Items.Add(valorRetornado)
                Cliente.Text = valorRetornado.ToString
            End If

        Catch ex As Exception

        End Try
    End Sub



End Class