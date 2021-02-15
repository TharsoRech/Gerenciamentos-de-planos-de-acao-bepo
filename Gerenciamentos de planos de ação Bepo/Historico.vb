Public Class Historico


    Private Sub AbrirPlanoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirPlanoToolStripMenuItem.Click
        Try
            For Each x10 As DataGridViewRow In MetroGrid1.SelectedRows
                For Each x1 As User In Form1.database.users
                    For Each x2 As PlanoDeAção In x1.Planos
                        If x2.Numero.ToLower = x10.Cells(2).Value.ToString.ToLower Then
                            Form1.TabPage1.Controls.Clear()
                            Dim newpl As New PlanoControl
                            If Form1.currentuser.admin = False And x1.user.ToLower <> Form1.currentuser.user.ToLower Then

                                newpl.Cliente.Enabled = False
                                newpl.Origem.Enabled = False
                                newpl.NumeroPlano.Enabled = False

                                newpl.addacao.Enabled = False
                                newpl.EditarAcao.Enabled = False



                                newpl.Inicio.Enabled = False
                                newpl.SalvarAlteracoes.Enabled = False
                            End If
                            For Each x11 As String In Form1.database.Clientes
                                newpl.Cliente.Items.Add(x11)
                            Next
                            newpl.Cliente.Text = x2.Cliente
                            newpl.Origem.Text = x2.Origem
                            newpl.NumeroPlano.Text = x2.Numero

                            For Each ac As Ação In x2.Ações
                                Dim responsaveis As String = ""
                                If ac.Responsáveis Is Nothing Then
                                    ac.Responsáveis = New List(Of String)
                                    Form1.save()
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
                            Form1.TabPage1.Controls.Add(newpl)
                        End If
                    Next
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentDoubleClick
        Try
            For Each x10 As DataGridViewRow In MetroGrid1.SelectedRows
                For Each x1 As User In Form1.database.users
                    For Each x2 As PlanoDeAção In x1.Planos
                        If x2.Numero.ToLower = x10.Cells(2).Value.ToString.ToLower Then
                            For Each ac As Ação In x2.Ações
                                Dim responsaveis As String = ""
                                If ac.Responsáveis Is Nothing Then
                                    ac.Responsáveis = New List(Of String)
                                    Form1.save()
                                End If
                                For Each lt As String In ac.Responsáveis
                                    responsaveis = responsaveis & Before(lt, "@") & ";"
                                Next
                                If ac.Ação.ToLower = x10.Cells(3).Value.ToString.ToLower And ac.NãoConformidadeFalha.ToLower = x10.Cells(4).Value.ToString.ToLower Then
                                    Dim html1 As String = ""
                                    Dim teste1 As String = "<table style=""width:100%"" border=""1"" cellspacing=""2""><tr><th>Plano de ação</th></tr></table><table style = ""width:100%"" border=""1"" cellspacing=""2""><tr>
    <td width = ""18%"" >Empresa :<b> Bepo</td>
     <td width = ""20%"" >Data Atualização:<b>" & x2.Atualização & ",Pelo usuário:" & x2.AlteradorPor & "</td>
  </tr> 
  <tr>
    <td width = ""18%"" >Elaborador Por:<b> " & x1.user & "</td>
     <td width = ""20%"" >Aprovador Por:<b>" & Before(ac.GerenteEmail, "@") & "</td>
  </tr>
</table>"

                                    If ac.Previsto Then
                                        html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano De Ação Previsto:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio</th><th>Prazo</th><th>Status</th><th>Evidência</th></tr>"
                                        If ac.Ação <> "" Then
                                            html1 = html1 & "<tr  bgcolor=""DodgerBlue""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                        End If

                                    End If
                                    If ac.EmExecução Then
                                        html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano de ação em Andamento:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio</th><th>Prazo</th><th>Status</th><th>Evidência</th></tr>"
                                        If ac.Ação <> "" Then
                                            html1 = html1 & "<tr  bgcolor=""Yellow""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                        End If
                                    End If
                                    If ac.Atrasada Then
                                        html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano de Ação Atrasado:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio</th><th>Prazo</th><th>Status</th><th>Evidência</th></tr>"
                                        If ac.Ação <> "" Then
                                            html1 = html1 & "<tr  bgcolor=""red""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                        End If
                                    End If
                                    If ac.concluida Then
                                        html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano de ação concluido:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio</th><th>Prazo</th><th>Status</th><th>Evidência</th></tr>"
                                        If ac.Ação <> "" Then
                                            html1 = html1 & "<tr  bgcolor=""Green""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                        End If
                                    End If
                                    VisualizarPlano.Show()
                                    VisualizarPlano.Title = x2.Cliente & x2.Numero
                                    VisualizarPlano.WebBrowser1.DocumentText = html1
                                End If
                            Next
                        End If
                    Next
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VisualizarPlanoDeAçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarPlanoDeAçãoToolStripMenuItem.Click
        Try
            For Each x10 As DataGridViewRow In MetroGrid1.SelectedRows
                For Each x1 As User In Form1.database.users
                    For Each x2 As PlanoDeAção In x1.Planos
                        If x2.Numero.ToLower = x10.Cells(2).Value.ToString.ToLower Then
                            For Each ac As Ação In x2.Ações
                                Dim responsaveis As String = ""
                                If ac.Responsáveis Is Nothing Then
                                    ac.Responsáveis = New List(Of String)
                                    Form1.save()
                                End If
                                For Each lt As String In ac.Responsáveis
                                    responsaveis = responsaveis & Before(lt, "@") & ";"
                                Next
                                If ac.Ação.ToLower = x10.Cells(3).Value.ToString.ToLower And ac.NãoConformidadeFalha.ToLower = x10.Cells(4).Value.ToString.ToLower Then
                                    Dim html1 As String = ""
                                    Dim teste1 As String = "<table style=""width:100%"" border=""1"" cellspacing=""2""><tr><th>Plano de ação</th></tr></table><table style = ""width:100%"" border=""1"" cellspacing=""2""><tr>
    <td width = ""18%"" >Empresa :<b> Bepo</td>
     <td width = ""20%"" >Data Atualização:<b>" & x2.Atualização & ",Pelo usuário:" & x2.AlteradorPor & "</td>
  </tr> 
  <tr>
    <td width = ""18%"" >Elaborador Por:<b> " & x1.user & "</td>
     <td width = ""20%"" >Aprovador Por:<b>" & Before(ac.GerenteEmail, "@") & "</td>
  </tr>
</table>"
                                    If ac.Previsto Then
                                        html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano De Ação Previsto:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio</th><th>Prazo</th><th>Status</th><th>Evidência</th></tr>"
                                        If ac.Ação <> "" Then
                                            html1 = html1 & "<tr  bgcolor=""DodgerBlue""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                        End If

                                    End If
                                    If ac.EmExecução Then
                                        html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano de ação em Andamento:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio</th><th>Prazo</th><th>Status</th><th>Evidência</th></tr>"
                                        If ac.Ação <> "" Then
                                            html1 = html1 & "<tr  bgcolor=""Yellow""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                        End If
                                    End If
                                    If ac.Atrasada Then
                                        html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano de Ação Atrasado:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio</th><th>Prazo</th><th>Status</th><th>Evidência</th></tr>"
                                        If ac.Ação <> "" Then
                                            html1 = html1 & "<tr  bgcolor=""red""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                        End If
                                    End If
                                    If ac.concluida Then
                                        html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano de ação concluido:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio</th><th>Prazo</th><th>Status</th><th>Evidência</th></tr>"
                                        If ac.Ação <> "" Then
                                            html1 = html1 & "<tr  bgcolor=""Green""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                        End If
                                    End If
                                    VisualizarPlano.Show()
                                    VisualizarPlano.Title = x2.Cliente & x2.Numero
                                    VisualizarPlano.WebBrowser1.DocumentText = html1
                                End If
                            Next
                        End If
                    Next
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub
    Function Before(value As String, a As String) As String
        Dim value1 As String = value
        Try
            ' Get index of argument and return substring up to that point."</th><th>" & x2.Inicio & "</th><th>"
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
