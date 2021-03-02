Public Class ListadeExcluidos
    Private Sub ListadeExcluidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Form1.database.listadeexcluidos Is Nothing Then
                Form1.database.listadeexcluidos = New List(Of Ação)
            End If

            If Form1.currentuser.admin Then
                For Each ac As Ação In Form1.database.listadeexcluidos
                    Dim responsaveis As String = ""
                    If ac.Responsáveis Is Nothing Then
                        ac.Responsáveis = New List(Of String)
                        Form1.save()
                    End If
                    For Each lt As String In ac.Responsáveis
                        responsaveis = responsaveis & Before(lt, "@") & ";"
                    Next
                    If ac.Ação <> "" Then
                        MetroGrid1.Rows.Add({ac.Cliente, ac.Origem, ac.Número, responsaveis, Before(ac.GerenteEmail, "@"), ac.Inicio, ac.Prazo, ac.Status, ac.Ação, ac.NãoConformidadeFalha, ac.excluidopor})
                    End If
                Next
            Else
                For Each ac As Ação In Form1.database.listadeexcluidos
                    Dim responsaveis As String = ""
                    If ac.Responsáveis Is Nothing Then
                        ac.Responsáveis = New List(Of String)
                        Form1.save()
                    End If
                    For Each lt As String In ac.Responsáveis
                        responsaveis = responsaveis & Before(lt, "@") & ";"
                    Next
                    If ac.CriadorPor = Form1.currentuser.user Then
                        If ac.Ação <> "" Then
                            MetroGrid1.Rows.Add({ac.Cliente, ac.Origem, ac.Número, responsaveis, Before(ac.GerenteEmail, "@"), ac.Inicio, ac.Prazo, ac.Status, ac.Ação, ac.NãoConformidadeFalha, ac.excluidopor})
                        End If
                    End If
                Next
            End If
            For i = 0 To MetroGrid1.Rows.Count - 1
                Dim valuestatus As String = MetroGrid1.Rows(i).Cells(7).Value
                If valuestatus.Contains("Previsto") Then
                    MetroGrid1.Rows(i).DefaultCellStyle.BackColor = Color.DodgerBlue
                    MetroGrid1.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                    MetroGrid1.Rows(i).DefaultCellStyle.SelectionBackColor = Color.DodgerBlue
                End If
                If valuestatus.Contains("Execução") Then
                    MetroGrid1.Rows(i).DefaultCellStyle.BackColor = Color.Gold
                    MetroGrid1.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                    MetroGrid1.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Gold
                End If
                If valuestatus.Contains("Atrasado") Then
                    MetroGrid1.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    MetroGrid1.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                    MetroGrid1.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Red
                End If
                If valuestatus.Contains("Concluido") Then
                    MetroGrid1.Rows(i).DefaultCellStyle.BackColor = Color.Green
                    MetroGrid1.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                    MetroGrid1.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Green
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.StackTrace)
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

    Private Sub GerarVisualizaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerarVisualizaçãoToolStripMenuItem.Click
        Try
            For Each x10 As DataGridViewRow In MetroGrid1.SelectedRows
                For Each ac As Ação In Form1.database.listadeexcluidos
                    Dim responsaveis As String = ""
                    If ac.Responsáveis Is Nothing Then
                        ac.Responsáveis = New List(Of String)
                        Form1.save()
                    End If
                    For Each lt As String In ac.Responsáveis
                        responsaveis = responsaveis & Before(lt, "@") & ";"
                    Next
                    If ac.Número.ToLower = x10.Cells(2).Value.ToString.ToLower Then
                        If ac.Ação.ToLower = x10.Cells(8).Value.ToString.ToLower And ac.NãoConformidadeFalha.ToLower = x10.Cells(9).Value.ToString.ToLower Then
                            Dim html1 As String = ""
                            Dim teste1 As String = "<table style=""width:100%"" border=""1"" cellspacing=""2""><tr><th>Plano de ação</th></tr></table><table style = ""width:100%"" border=""1"" cellspacing=""2""><tr>
    <td width = ""18%"" >Empresa :<b> Bepo</td>
     <td width = ""20%"" >Data Atualização:<b>" & ac.atualização & ",Pelo usuário:" & ac.Alteradopor & "</td>
  </tr> 
  <tr>
    <td width = ""18%"" >Elaborador Por:<b> " & ac.CriadorPor & "</td>
     <td width = ""20%"" >Avaliador Por:<b>" & Before(ac.GerenteEmail, "@") & "</td>
  </tr>
</table>"

                            If ac.Previsto Then
                                html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano De Ação Previsto:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                If ac.Ação <> "" Then
                                    html1 = html1 & "<tr  bgcolor=""DodgerBlue""> <th>" & ac.Cliente & "</th>" & "<th>" & ac.Origem & "</th>" & "<th>" & ac.Número & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & ac.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                End If

                            End If
                            If ac.EmExecução Then
                                html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano De Ação Previsto:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                If ac.Ação <> "" Then
                                    html1 = html1 & "<tr  bgcolor=""Yellow""> <th>" & ac.Cliente & "</th>" & "<th>" & ac.Origem & "</th>" & "<th>" & ac.Número & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & ac.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                End If
                            End If
                            If ac.Atrasada Then
                                                                    html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano de Ação Atrasado:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                If ac.Ação <> "" Then
                                    html1 = html1 & "<tr  bgcolor=""red""> <th>" & ac.Cliente & "</th>" & "<th>" & ac.Origem & "</th>" & "<th>" & ac.Número & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & ac.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                End If
                            End If
                            If ac.concluida Then
                                html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano de ação concluido:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                If ac.Ação <> "" Then
                                    html1 = html1 & "<tr  bgcolor=""Green""> <th>" & ac.Cliente & "</th>" & "<th>" & ac.Origem & "</th>" & "<th>" & ac.Número & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & ac.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                End If
                            End If
                            VisualizarPlano.Show()
                            VisualizarPlano.Title = ac.Cliente & ac.Número
                            VisualizarPlano.WebBrowser1.DocumentText = html1
                        End If
                    End If
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentDoubleClick

        Try
            For Each x10 As DataGridViewRow In MetroGrid1.SelectedRows
                For Each ac As Ação In Form1.database.listadeexcluidos
                    Dim responsaveis As String = ""
                    If ac.Responsáveis Is Nothing Then
                        ac.Responsáveis = New List(Of String)
                        Form1.save()
                    End If
                    For Each lt As String In ac.Responsáveis
                        responsaveis = responsaveis & Before(lt, "@") & ";"
                    Next
                    If ac.Número.ToLower = x10.Cells(2).Value.ToString.ToLower Then
                        If ac.Ação.ToLower = x10.Cells(8).Value.ToString.ToLower And ac.NãoConformidadeFalha.ToLower = x10.Cells(9).Value.ToString.ToLower Then
                            Dim html1 As String = ""
                            Dim teste1 As String = "<table style=""width:100%"" border=""1"" cellspacing=""2""><tr><th>Plano de ação</th></tr></table><table style = ""width:100%"" border=""1"" cellspacing=""2""><tr>
    <td width = ""18%"" >Empresa :<b> Bepo</td>
     <td width = ""20%"" >Data Atualização:<b>" & ac.atualização & ",Pelo usuário:" & ac.Alteradopor & "</td>
  </tr> 
  <tr>
    <td width = ""18%"" >Elaborador Por:<b> " & ac.CriadorPor & "</td>
     <td width = ""20%"" >Avaliador Por:<b>" & Before(ac.GerenteEmail, "@") & "</td>
  </tr>
</table>"

                            If ac.Previsto Then
                                html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano De Ação Previsto:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                If ac.Ação <> "" Then
                                    html1 = html1 & "<tr  bgcolor=""DodgerBlue""> <th>" & ac.Cliente & "</th>" & "<th>" & ac.Origem & "</th>" & "<th>" & ac.Número & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & ac.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                End If

                            End If
                            If ac.EmExecução Then
                                html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano De Ação Previsto:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                If ac.Ação <> "" Then
                                    html1 = html1 & "<tr  bgcolor=""Yellow""> <th>" & ac.Cliente & "</th>" & "<th>" & ac.Origem & "</th>" & "<th>" & ac.Número & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & ac.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                End If
                            End If
                            If ac.Atrasada Then
                                                                    html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano de Ação Atrasado:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                If ac.Ação <> "" Then
                                    html1 = html1 & "<tr  bgcolor=""red""> <th>" & ac.Cliente & "</th>" & "<th>" & ac.Origem & "</th>" & "<th>" & ac.Número & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & ac.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                End If
                            End If
                            If ac.concluida Then
                                html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano de ação concluido:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                If ac.Ação <> "" Then
                                    html1 = html1 & "<tr  bgcolor=""Green""> <th>" & ac.Cliente & "</th>" & "<th>" & ac.Origem & "</th>" & "<th>" & ac.Número & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & ac.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Evidência & "</th></tr>"
                                End If
                            End If
                            VisualizarPlano.Show()
                            VisualizarPlano.Title = ac.Cliente & ac.Número
                            VisualizarPlano.WebBrowser1.DocumentText = html1
                        End If
                    End If
                Next
            Next
        Catch ex As Exception

        End Try
    End Sub


    Private Sub LimparListaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            Form1.database.listadeexcluidos.Clear()
            Form1.save()
        Catch ex As Exception

        End Try
    End Sub
End Class