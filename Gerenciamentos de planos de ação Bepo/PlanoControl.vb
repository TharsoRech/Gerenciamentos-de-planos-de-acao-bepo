Imports MetroFramework

Public Class PlanoControl
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SalvarAlteracoes.Click
        Try
            For Each x1 As User In Form1.database.users
                For Each x2 As PlanoDeAção In x1.Planos
                    If x2.Numero.ToLower = NumeroPlano.Text.ToLower Then
                        x2.Ações.Clear()
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
                                    newac.Responsáveis.Add(word)
                                Next
                                newac.GerenteEmail = x10.Cells(3).Value
                                newac.Evidência = x10.Cells(4).Value
                                newac.Inicio = x10.Cells(6).Value
                                newac.Prazo = x10.Cells(7).Value
                                newac.Aprovado = x10.Cells(8).Value
                                newac.AvaliadorPor = x10.Cells(9).Value
                                newac.Pontuacao = x10.Cells(10).Value
                                newac.Obs = x10.Cells(11).Value
                                If x10.Cells(5).Value = "Previsto" Then
                                    newac.Previsto = True
                                    newac.Status = "Previsto"
                                Else
                                    newac.Previsto = False
                                End If
                                If x10.Cells(5).Value = "Execução" Then
                                    newac.EmExecução = True
                                    newac.Status = "Execução"
                                Else
                                    newac.EmExecução = False
                                End If
                                If x10.Cells(5).Value = "Atrasado" Then
                                    newac.Atrasada = True
                                    newac.Status = "Atrasado"
                                Else
                                    newac.Atrasada = False
                                End If
                                If x10.Cells(5).Value = "Concluido" Then
                                    newac.concluida = True
                                    newac.Status = "Concluido"
                                Else
                                    newac.concluida = False
                                End If
                                Dim evidenciacaminho = newac.Evidência
                                If evidenciacaminho <> "" Then
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
                                x2.Ações.Add(newac)
                                End If
                        Next
                        x2.Cliente = Cliente.Text
                        x2.Origem = Origem.Text
                        x2.Numero = NumeroPlano.Text
                        x2.Inicio = Inicio.Text
                        x2.Atualização = DateTime.Now.ToString("yyyy-MM-dd HH:mm tt")
                        x2.AlteradorPor = Form1.currentuser.user
                        Form1.save()
                        Dim html1 As String = ""
                        For Each ac As Ação In x2.Ações
                            Dim responsaveis As String = ""
                            If ac.Responsáveis Is Nothing Then
                                ac.Responsáveis = New List(Of String)
                                Form1.save()
                            End If
                            For Each lt As String In ac.Responsáveis
                                responsaveis = responsaveis & Before(lt, "@") & ";"
                            Next
                            For Each x5 As Alerta In Form1.database.Alertas
                                If x5.NúmeroPlanodeAção = x2.Numero And x5.Status = ac.Status Then
                                    Form1.database.Alertas.Remove(x5)
                                    Exit For
                                End If
                            Next
                            If ac.EmExecução Then
                                Dim newl As New Alerta
                                newl.Status = ac.Status
                                newl.Prazo = ac.Prazo
                                newl.Inicio = x2.Inicio
                                newl.Cliente = x2.Cliente
                                newl.NúmeroPlanodeAção = x2.Numero
                                newl.Responsáveis = ac.Responsáveis
                                newl.Ação = ac.Ação
                                newl.Falha = ac.NãoConformidadeFalha
                                newl.Gerente = ac.GerenteEmail
                                newl.Mensagem = "Plano de ação em andamento."
                                Form1.database.Alertas.Add(newl)
                                Form1.save()
                            End If
                            If ac.Atrasada Then
                                Dim newl As New Alerta
                                newl.Status = ac.Status
                                newl.Prazo = ac.Prazo
                                newl.Inicio = x2.Inicio
                                newl.Cliente = x2.Cliente
                                newl.NúmeroPlanodeAção = x2.Numero
                                newl.Responsáveis = ac.Responsáveis
                                newl.Gerente = ac.GerenteEmail
                                newl.Ação = ac.Ação
                                newl.Falha = ac.NãoConformidadeFalha
                                newl.Mensagem = "Plano de ação atrasado."
                                Form1.database.Alertas.Add(newl)
                                Form1.save()
                            End If
                            If Form1.templist.Count > 0 Then
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
                                    html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><div><font color=""red"">Atenção plano de ação atualizado:</font><div><strong>Esse email é enviado automaticamente para alerta e avisos de planos de ações,por favor não responda esse email.</strong><body><p align=""center"" style = ""font-size:36px"">Plano de Ação Atrasado:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                    If ac.Ação <> "" Then
                                        html1 = html1 & "<tr  bgcolor=""red""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                    End If
                                End If
                                If ac.Previsto Then
                                    html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><div><font color=""red"">Atenção plano de ação atualizado:</font><div><strong>Esse email é enviado automaticamente para alerta e avisos de planos de ações,por favor não responda esse email.</strong><body><p align=""center"" style = ""font-size:36px"">Plano De Ação Previsto:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                    If ac.Ação <> "" Then
                                        html1 = html1 & "<tr  bgcolor=""DodgerBlue""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                    End If

                                End If
                                If ac.EmExecução Then
                                    html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><div><font color=""red"">Atenção plano de ação atualizado:</font><div><strong>Esse email é enviado automaticamente para alerta e avisos de planos de ações,por favor não responda esse email.</strong><body><p align=""center"" style = ""font-size:36px"">Plano de ação em Andamento:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                    If ac.Ação <> "" Then
                                        html1 = html1 & "<tr  bgcolor=""Yellow""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                    End If
                                End If
                                If ac.concluida Then
                                    html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><div><font color=""red"">Atenção plano de ação atualizado:</font><div><strong>Esse email é enviado automaticamente para alerta e avisos de planos de ações,por favor não responda esse email.</strong><body><p align=""center"" style = ""font-size:36px"">Plano de ação concluido:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                    If ac.Ação <> "" Then
                                        html1 = html1 & "<tr  bgcolor=""Green""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                    End If
                                End If
                                For Each action As Ação In Form1.templist
                                    If action.NãoConformidadeFalha = ac.NãoConformidadeFalha And action.Ação = ac.Ação Then
                                        If Form1.sendmessage(html1, ac.Responsáveis, ac.GerenteEmail, True, False) Then

                                        End If
                                    End If
                                Next
                            End If
                        Next


                            End If
                Next
            Next
            MetroMessageBox.Show(Form1, "Plano de ação atualizado com sucesso", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form1.templist.Clear()
        Catch ex As Exception
            MetroMessageBox.Show(Form1, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
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





    Private Sub addacao_Click(sender As Object, e As EventArgs) Handles addacao.Click
        Try
            Addaction.Gridtoadd = MetroGrid1
            Addaction.Status.Text = "Previsto"
            Addaction.Status.Enabled = False
            Addaction.numeroplanodeacao = NumeroPlano.Text
            Addaction.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub removeracao_Click(sender As Object, e As EventArgs)
        Try
            For Each x10 As DataGridViewRow In MetroGrid1.SelectedRows
                MetroGrid1.Rows.Remove(x10)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EditarAcao_Click(sender As Object, e As EventArgs) Handles EditarAcao.Click
        Try

            Addaction.Gridtoadd = MetroGrid1
            Addaction.numeroplanodeacao = NumeroPlano.Text
            Addaction.Selectrow1 = MetroGrid1.SelectedRows(0)
            Addaction.Falha.Text = MetroGrid1.SelectedRows(0).Cells(0).Value.ToString
            Addaction.Acao.Text = MetroGrid1.SelectedRows(0).Cells(1).Value.ToString
            Dim words As String() = MetroGrid1.SelectedRows(0).Cells(2).Value.Split(New Char() {";"c})
            For Each word In words
                If word.Contains("@") Then
                    Addaction.TreeView1.Nodes.Add(word)
                End If
            Next
            Addaction.GerenteEmail.Text = MetroGrid1.SelectedRows(0).Cells(3).Value.ToString
            Addaction.Evidencia.Text = MetroGrid1.SelectedRows(0).Cells(4).Value.ToString
            Addaction.Inicio.Text = MetroGrid1.SelectedRows(0).Cells(6).Value.ToString
            Addaction.Status.Text = MetroGrid1.SelectedRows(0).Cells(5).Value.ToString
            Addaction.Prazo.Text = MetroGrid1.SelectedRows(0).Cells(7).Value.ToString
            Dim Aprovadoo As String = temvalor(MetroGrid1.SelectedRows(0).Cells(8).Value).ToLower
            If Aprovadoo = "Sim".ToLower Then
                Addaction.Sim.Checked = True
            End If
            If Aprovadoo = "Não".ToLower Then
                Addaction.Nao.Checked = True
                Addaction.Obs.Text = MetroGrid1.SelectedRows(0).Cells(11).Value.ToString
            End If
            Addaction.AvaliadoPor.Text = temvalor(MetroGrid1.SelectedRows(0).Cells(9).Value)
            Addaction.Pontuacao.Text = temvalor(MetroGrid1.SelectedRows(0).Cells(10).Value)


            Addaction.addacao.Text = "Atualizar Ação"
            Addaction.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
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
            Addaction.numeroplanodeacao = NumeroPlano.Text
            Addaction.Gridtoadd = MetroGrid1
            Addaction.Selectrow1 = MetroGrid1.SelectedRows(0)
            Addaction.Falha.Text = MetroGrid1.SelectedRows(0).Cells(0).Value.ToString
            Addaction.Acao.Text = MetroGrid1.SelectedRows(0).Cells(1).Value.ToString
            Addaction.GerenteEmail.Text = MetroGrid1.SelectedRows(0).Cells(3).Value.ToString
            Addaction.Evidencia.Text = MetroGrid1.SelectedRows(0).Cells(4).Value.ToString
            Addaction.Inicio.Text = MetroGrid1.SelectedRows(0).Cells(6).Value.ToString
            Addaction.Status.Text = MetroGrid1.SelectedRows(0).Cells(5).Value.ToString
            Addaction.Prazo.Text = MetroGrid1.SelectedRows(0).Cells(7).Value.ToString
            Dim Aprovadoo As String = temvalor(MetroGrid1.SelectedRows(0).Cells(8).Value).ToLower
            If Aprovadoo = "Sim".ToLower Then
                    Addaction.Sim.Checked = True
                End If
            If Aprovadoo = "Não".ToLower Then
                Addaction.Nao.Checked = True
                Addaction.Obs.Text = MetroGrid1.SelectedRows(0).Cells(11).Value.ToString
            End If
            Addaction.AvaliadoPor.Text = temvalor(MetroGrid1.SelectedRows(0).Cells(9).Value)
            Addaction.Pontuacao.Text = temvalor(MetroGrid1.SelectedRows(0).Cells(10).Value)

            Addaction.addacao.Text = "Atualizar Ação"
            Addaction.Show()
        Catch ex As Exception

        End Try
    End Sub
    Public Function temvalor(ByVal objeto As Object) As String
        Dim valor As String = ""
        Try
            If objeto IsNot Nothing Then
                valor = objeto.ToString
                Return valor
            End If
            Return valor
        Catch ex As Exception
            Return valor
        End Try
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            SelecionarRelatorio.Show()
            SelecionarRelatorio.Metrogrid1 = MetroGrid1
            SelecionarRelatorio.NumeroPlano = NumeroPlano.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Try
            If Form1.currentuser.admin = False Then
                MetroMessageBox.Show(Form1, "Você precisa ser administrador para adicionar um cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub DuplicarAçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicarAçãoToolStripMenuItem.Click
        Try
            MetroGrid1.Rows.Add({MetroGrid1.SelectedRows(0).Cells(0).Value, MetroGrid1.SelectedRows(0).Cells(1).Value, MetroGrid1.SelectedRows(0).Cells(2).Value, MetroGrid1.SelectedRows(0).Cells(3).Value, MetroGrid1.SelectedRows(0).Cells(4).Value, MetroGrid1.SelectedRows(0).Cells(5).Value, MetroGrid1.SelectedRows(0).Cells(6).Value})
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MoverAcimaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoverAcimaToolStripMenuItem.Click
        Try
            If MetroGrid1.SelectedRows(0).Index > 0 Then
                Dim index1 As Integer = MetroGrid1.SelectedRows(0).Index
                Dim savedrow As DataGridViewRow = MetroGrid1.Rows(MetroGrid1.SelectedRows(0).Index - 1)
                MetroGrid1.Rows.Remove(MetroGrid1.Rows(MetroGrid1.SelectedRows(0).Index - 1))
                MetroGrid1.Rows.Insert(index1, savedrow)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MoverAbaixoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoverAbaixoToolStripMenuItem.Click
        Try
            If MetroGrid1.Rows(MetroGrid1.SelectedRows(0).Index + 1) IsNot Nothing Then
                Dim index1 As Integer = MetroGrid1.SelectedRows(0).Index + 1
                Dim savedrow As DataGridViewRow = MetroGrid1.SelectedRows(0)
                MetroGrid1.Rows.Remove(MetroGrid1.SelectedRows(0))
                MetroGrid1.Rows.Insert(index1, savedrow)
            End If
        Catch ex As Exception

        End Try
    End Sub


End Class
