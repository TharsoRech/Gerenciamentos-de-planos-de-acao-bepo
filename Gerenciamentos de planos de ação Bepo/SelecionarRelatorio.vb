Imports System.IO
Imports MetroFramework
Imports OfficeOpenXml
Imports OfficeOpenXml.Table

Public Class SelecionarRelatorio
    Public Metrogrid1 As Wisder.W3Common.WMetroControl.Controls.MetroGrid
    Public NumeroPlano As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub addacao_Click(sender As Object, e As EventArgs) Handles addacao.Click
        Try

            Dim htmlend As String = ""
                For Each x10 As DataGridViewRow In Metrogrid1.SelectedRows
                    For Each x1 As User In Form1.database.users
                        For Each x2 As PlanoDeAção In x1.Planos
                            If x2.Numero.ToLower = NumeroPlano.ToLower Then
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
                                If ac.Previsto And Previstas.Checked = True Or ac.Previsto And Todas.Checked = True Then
                                    html1 = html1 & "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano De Ação Previsto:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                    If ac.Ação <> "" Then
                                        html1 = html1 & "<tr  bgcolor=""DodgerBlue""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Aprovado & "</th><th>" & ac.Obs & "</th><th>" & ac.Pontuacao & "</th><th>" & ac.Evidência & "</th></tr></table><br>"
                                        html1 = Checarvaloresnulos(ac, html1)
                                    End If

                                End If
                                If ac.EmExecução And Emexecucao.Checked = True Or ac.EmExecução And Todas.Checked = True Then
                                    html1 = html1 & "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano de ação em Andamento:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                    If ac.Ação <> "" Then
                                        html1 = html1 & "<tr  bgcolor=""Yellow""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Aprovado & "</th><th>" & ac.Obs & "</th><th>" & ac.Pontuacao & "</th><th>" & ac.Evidência & "</th></tr></table><br>"
                                        html1 = Checarvaloresnulos(ac, html1)
                                    End If
                                End If
                                If ac.Atrasada And Atrasadas.Checked = True Or ac.Atrasada And Todas.Checked = True Then
                                    html1 = html1 & "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano de Ação Atrasado:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                    If ac.Ação <> "" Then
                                        html1 = html1 & "<tr  bgcolor=""red""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Aprovado & "</th><th>" & ac.Obs & "</th><th>" & ac.Pontuacao & "</th><th>" & ac.Evidência & "</th></tr></table><br>"
                                        html1 = Checarvaloresnulos(ac, html1)
                                    End If
                                End If
                                If ac.concluida And Concluidas.Checked = True Or ac.concluida And Todas.Checked = True Then
                                    html1 = html1 & "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano de ação concluido:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                    If ac.Ação <> "" Then
                                        html1 = html1 & "<tr  bgcolor=""Green""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Aprovado & "</th><th>" & ac.Obs & "</th><th>" & ac.Pontuacao & "</th><th>" & ac.Evidência & "</th></tr></table><br>"
                                        html1 = Checarvaloresnulos(ac, html1)
                                    End If
                                End If
                                htmlend = htmlend & html1 & "<br>"
                            Next
                            End If
                        Next
                    Next
                Next
                VisualizarPlano.Title = "Relatório de ações"
                VisualizarPlano.WebBrowser1.DocumentText = htmlend
                VisualizarPlano.Show()

        Catch ex As Exception

        End Try
    End Sub
    Public Function Checarvaloresnulos(ac1 As Ação, html11 As String) As String
        Try
            If ac1.Aprovado = "" Then
                html11 = html11.Replace("<th>Aprovado</th>", "")
                html11 = html11.Replace("<th></th>", "")
            End If
            If ac1.Obs = "" Then
                html11 = html11.Replace("<th>Obs</th>", "")
                html11 = html11.Replace("<th></th>", "")
            End If
            If ac1.Pontuacao = "" Then
                html11 = html11.Replace("<th>Pontuação</th>", "")
                html11 = html11.Replace("<th></th>", "")
            End If
            If ac1.Evidência = "" Then
                html11 = html11.Replace("<th>Evidência</th>", "")
                html11 = html11.Replace("<th></th>", "")
            End If
            Return html11
        Catch ex As Exception
            Return html11
        End Try
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

    Private Sub Todas_CheckedChanged(sender As Object, e As EventArgs) Handles Todas.Click
        Try
            If Todas.Checked Then
                Previstas.Checked = False
                Emexecucao.Checked = False
                Atrasadas.Checked = False
                Concluidas.Checked = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Concluidas_CheckedChanged(sender As Object, e As EventArgs) Handles Concluidas.Click
        Try
            If Concluidas.Checked Then
                Previstas.Checked = False
                Emexecucao.Checked = False
                Atrasadas.Checked = False
                Todas.Checked = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Atradadas_CheckedChanged(sender As Object, e As EventArgs) Handles Atrasadas.Click
        Try
            If Atrasadas.Checked Then
                Previstas.Checked = False
                Emexecucao.Checked = False
                Todas.Checked = False
                Concluidas.Checked = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Emexecucao_CheckedChanged(sender As Object, e As EventArgs) Handles Emexecucao.Click
        Try
            If Emexecucao.Checked Then
                Previstas.Checked = False
                Todas.Checked = False
                Atrasadas.Checked = False
                Concluidas.Checked = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Previstas_CheckedChanged(sender As Object, e As EventArgs) Handles Previstas.Click
        Try
            If Previstas.Checked Then
                Todas.Checked = False
                Emexecucao.Checked = False
                Atrasadas.Checked = False
                Concluidas.Checked = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Gráfico.Show()
            Gráfico.Chart1.Titles(0).Text = "Gráfico Plano de ação  " & NumeroPlano
            For Each x10 As DataGridViewRow In Metrogrid1.SelectedRows
                For Each x1 As User In Form1.database.users
                    For Each x2 As PlanoDeAção In x1.Planos
                        If x2.Numero.ToLower = NumeroPlano.ToLower Then
                            Dim totaly As Integer = x2.Ações.Count
                            Dim concluidas1 As Integer = 0
                            Dim Previstas1 As Integer = 0
                            Dim Atrasadas1 As Integer = 0
                            Dim Emexecução1 As Integer = 0
                            For Each ac In x2.Ações
                                If ac.concluida Then
                                    concluidas1 = concluidas1 + 1
                                End If
                                If ac.Previsto Then
                                    Previstas1 = Previstas1 + 1
                                End If
                                If ac.Atrasada Then
                                    Atrasadas1 = Atrasadas1 + 1
                                End If
                                If ac.EmExecução Then
                                    Emexecução1 = Emexecução1 + 1
                                End If
                            Next
                            If concluidas1 > 0 Then
                                Gráfico.Chart1.Series(0).Points(0).IsValueShownAsLabel = True
                            End If
                            If Previstas1 > 0 Then
                                Gráfico.Chart1.Series(0).Points(1).IsValueShownAsLabel = True
                            End If
                            If Atrasadas1 > 0 Then
                                Gráfico.Chart1.Series(0).Points(3).IsValueShownAsLabel = True
                            End If
                            If Emexecução1 > 0 Then
                                Gráfico.Chart1.Series(0).Points(2).IsValueShownAsLabel = True
                            End If
                            Gráfico.Chart1.Series(0).Points(0).SetValueXY(totaly, concluidas1)
                            Gráfico.Chart1.Series(0).Points(1).SetValueXY(totaly, Previstas1)
                            Gráfico.Chart1.Series(0).Points(3).SetValueXY(totaly, Atrasadas1)
                            Gráfico.Chart1.Series(0).Points(2).SetValueXY(totaly, Emexecução1)
                        End If
                    Next
                Next
            Next


        Catch ex As Exception
        End Try
    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If SaveFileDialog1.ShowDialog <> DialogResult.Cancel Then
                Dim path As String = SaveFileDialog1.FileName
                Dim xlPackage As New ExcelPackage()
                Dim oBook As ExcelWorkbook = xlPackage.Workbook
                Dim ws = xlPackage.Workbook.Worksheets.Add("Plano de ações")
                Dim countactions As Integer = 0
                For Each x1 As User In Form1.database.users
                    For Each x2 As PlanoDeAção In x1.Planos
                        If x2.Numero.ToLower = NumeroPlano.ToLower Then
                            If Todas.Checked Then
                                countactions = x2.Ações.Count
                            Else
                                For Each ac As Ação In x2.Ações
                                    If Concluidas.Checked And ac.concluida Then
                                        countactions = countactions + 1
                                    End If
                                    If Previstas.Checked And ac.Previsto Then
                                        countactions = countactions + 1
                                    End If
                                    If Emexecucao.Checked And ac.EmExecução Then
                                        countactions = countactions + 1
                                    End If
                                    If Atrasadas.Checked And ac.Atrasada Then
                                        countactions = countactions + 1
                                    End If
                                Next
                            End If
                        End If
                    Next
                Next
                If countactions = 0 Then
                    MetroMessageBox.Show(Me, "Erro:nenhuma ação coletada,verifique se assinalou alguma das opções de relatório anteriores", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim range As ExcelRange = ws.Cells(1, 1, countactions + 1, 6)
                Dim table As ExcelTable = ws.Tables.Add(range, "table1")

                table.ShowTotal = True
                table.TableStyle = TableStyles.Light1
                table.Columns(0).Name = "Não conformidade/Falha"
                table.Columns(1).Name = "Ação corretiva"
                table.Columns(2).Name = "Responsáveis"
                table.Columns(3).Name = "Prazo"
                table.Columns(4).Name = "Status"
                table.Columns(5).Name = "Evidência"
                Dim column As Integer = 2
                For Each x1 As User In Form1.database.users
                    For Each x2 As PlanoDeAção In x1.Planos
                        If x2.Numero.ToLower = NumeroPlano.ToLower Then
                            For Each ac As Ação In x2.Ações
                                If Concluidas.Checked And ac.concluida Then
                                    ws.Cells(column, 1).Value = ac.NãoConformidadeFalha
                                    ws.Cells(column, 2).Value = ac.Ação
                                    ws.Cells(column, 3).Value = ac.Responsáveis
                                    ws.Cells(column, 4).Value = ac.Prazo
                                    ws.Cells(column, 5).Value = ac.Status
                                    ws.Cells(column, 6).Value = ac.Evidência
                                    ws.Cells(column, column + 1).Merge = True
                                    column = column + 1
                                End If
                                If Previstas.Checked And ac.Previsto Then
                                    ws.Cells(column, 1).Value = ac.NãoConformidadeFalha
                                    ws.Cells(column, 2).Value = ac.Ação
                                    ws.Cells(column, 3).Value = ac.Responsáveis
                                    ws.Cells(column, 4).Value = ac.Prazo
                                    ws.Cells(column, 5).Value = ac.Status
                                    ws.Cells(column, 6).Value = ac.Evidência
                                    ws.Cells(column, column + 1).Merge = True
                                    column = column + 1
                                End If
                                If Emexecucao.Checked And ac.EmExecução Then
                                    ws.Cells(column, 1).Value = ac.NãoConformidadeFalha
                                    ws.Cells(column, 2).Value = ac.Ação
                                    ws.Cells(column, 3).Value = ac.Responsáveis
                                    ws.Cells(column, 4).Value = ac.Prazo
                                    ws.Cells(column, 5).Value = ac.Status
                                    ws.Cells(column, 6).Value = ac.Evidência
                                    ws.Cells(column, column + 1).Merge = True
                                    column = column + 1
                                End If
                                If Atrasadas.Checked And ac.Atrasada Then
                                    ws.Cells(column, 1).Value = ac.NãoConformidadeFalha
                                    ws.Cells(column, 2).Value = ac.Ação
                                    ws.Cells(column, 3).Value = ac.Responsáveis
                                    ws.Cells(column, 4).Value = ac.Prazo
                                    ws.Cells(column, 5).Value = ac.Status
                                    ws.Cells(column, 6).Value = ac.Evidência
                                    ws.Cells(column, column + 1).Merge = True
                                    column = column + 1
                                End If
                                If Todas.Checked Then
                                    ws.Cells(column, 1).Value = ac.NãoConformidadeFalha
                                    ws.Cells(column, 2).Value = ac.Ação
                                    ws.Cells(column, 3).Value = ac.Responsáveis
                                    ws.Cells(column, 4).Value = ac.Prazo
                                    ws.Cells(column, 5).Value = ac.Status
                                    ws.Cells(column, 6).Value = ac.Evidência
                                    ws.Cells(column, column + 1).Merge = True
                                    column = column + 1
                                End If

                            Next
                        End If
                    Next
                Next
                ws.Cells().AutoFitColumns()
                Dim Stream As Stream = File.Create(path)
                    xlPackage.SaveAs(Stream)
                    Stream.Close()
                    Process.Start(path)
                End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.StackTrace)
        End Try
    End Sub

End Class