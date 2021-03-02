Imports MetroFramework

Public Class Addaction
    Public Gridtoadd As Wisder.W3Common.WMetroControl.Controls.MetroGrid
    Public Selectrow1 As DataGridViewRow
    Public numeroplanodeacao As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub addacao_Click(sender As Object, e As EventArgs) Handles addacao.Click

        Try
            If Gridtoadd IsNot Nothing Then
                Dim Aprove As String = ""
                If Sim.Checked = True Then
                    Aprove = "Sim"
                Else
                    Aprove = "Não"
                End If
                Dim Responsavelemai As String = ""
                For Each x3 As TreeNode In TreeView1.Nodes
                    Responsavelemai = Responsavelemai & x3.Text & ";"
                Next
                If Selectrow1 IsNot Nothing Then
                    If Acao.Text <> "" And GerenteEmail.Text.Contains("@") Then
                        Dim newaction As New Ação
                        newaction.NãoConformidadeFalha = Falha.Text
                        newaction.Ação = Acao.Text
                        Form1.templist.Add(newaction)
                        Selectrow1.Cells(0).Value = Falha.Text
                        Selectrow1.Cells(1).Value = Acao.Text
                        Selectrow1.Cells(2).Value = Responsavelemai
                        Selectrow1.Cells(3).Value = GerenteEmail.Text
                        Selectrow1.Cells(4).Value = Evidencia.Text
                        Selectrow1.Cells(5).Value = Status.Text
                        Selectrow1.Cells(6).Value = Inicio.Text
                        Selectrow1.Cells(7).Value = Prazo.Text
                        Selectrow1.Cells(8).Value = Aprove
                        Selectrow1.Cells(9).Value = AvaliadoPor.Text
                        Selectrow1.Cells(10).Value = Pontuacao.Text
                        Selectrow1.Cells(11).Value = Obs.Text
                        Me.Close()
                    Else
                        MetroMessageBox.Show(Me, "Erro ao atualizar ação,Parece estar faltando alguma informação,ou alguma informação está errada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    If Acao.Text <> "" And GerenteEmail.Text.Contains("@") Then
                        Dim newaction As New Ação
                        newaction.NãoConformidadeFalha = Falha.Text
                        newaction.Ação = Acao.Text
                        Form1.templist.Add(newaction)
                        Gridtoadd.Rows.Add({Falha.Text, Acao.Text, Responsavelemai, GerenteEmail.Text, Evidencia.Text, Status.Text, Inicio.Text, Prazo.Text, Aprove, AvaliadoPor.Text, Pontuacao.Text, Obs.Text})
                        Me.Close()
                    Else
                        MetroMessageBox.Show(Me, "Erro ao adicionar nova ação ,Parece estar faltando alguma informação,ou alguma informação está errada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End If
                For i = 0 To Gridtoadd.Rows.Count - 1
                    If Gridtoadd.Rows(i).Cells(5).Value = "Previsto" Then
                        Gridtoadd.Rows(i).DefaultCellStyle.BackColor = Color.DodgerBlue
                        Gridtoadd.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                        Gridtoadd.Rows(i).DefaultCellStyle.SelectionBackColor = Color.DodgerBlue
                    End If
                    If Gridtoadd.Rows(i).Cells(5).Value = "Execução" Then
                        Gridtoadd.Rows(i).DefaultCellStyle.BackColor = Color.Gold
                        Gridtoadd.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                        Gridtoadd.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Gold
                    End If
                    If Gridtoadd.Rows(i).Cells(5).Value = "Atrasado" Then
                        Gridtoadd.Rows(i).DefaultCellStyle.BackColor = Color.Red
                        Gridtoadd.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                        Gridtoadd.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Red
                    End If
                    If Gridtoadd.Rows(i).Cells(5).Value = "Concluido" Then
                        Gridtoadd.Rows(i).DefaultCellStyle.BackColor = Color.Green
                        Gridtoadd.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                        Gridtoadd.Rows(i).DefaultCellStyle.SelectionBackColor = Color.Green
                    End If
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub AbrirEvidencia_Click(sender As Object, e As EventArgs) Handles AbrirEvidencia.Click
        Try
            If IO.File.Exists(Evidencia.Text) Then
                Process.Start(Evidencia.Text)
            Else
                MetroMessageBox.Show(Form1, "Arquivo Não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AnexarEvidencia_Click(sender As Object, e As EventArgs) Handles AnexarEvidencia.Click
        Try
            If OpenFileDialog1.ShowDialog <> DialogResult.Cancel Then
                Evidencia.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Status.SelectedIndexChanged
        Try
            If Status.Text.ToLower.Contains("Previsto".ToLower) Then
                Status.BackColor = Color.DodgerBlue
            End If
            If Status.Text.ToLower.Contains("Execução".ToLower) Then
                Status.BackColor = Color.Gold
            End If
            If Status.Text.ToLower.Contains("Atrasado".ToLower) Then
                Status.BackColor = Color.Red
            End If
            If Status.Text.ToLower.Contains("Concluido".ToLower) Then
                Status.BackColor = Color.Green
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            For Each x1 As User In Form1.database.users
                For Each x2 As PlanoDeAção In x1.Planos
                    If x2.Numero.ToLower = numeroplanodeacao.ToLower Then
                        For Each ac As Ação In x2.Ações
                            ChecarAvaliador(ac)
                            Dim responsaveis As String = ""
                            If ac.Responsáveis Is Nothing Then
                                ac.Responsáveis = New List(Of String)
                                Form1.save()
                            End If
                            For Each lt As String In ac.Responsáveis
                                responsaveis = responsaveis & Before(lt, "@") & ";"
                            Next
                            If ac.Ação.ToLower = Acao.Text.ToLower And ac.NãoConformidadeFalha.ToLower = Falha.Text.ToLower Then
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

                                If ac.Previsto Then
                                    html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano De Ação Previsto:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                    If ac.Ação <> "" Then
                                        html1 = html1 & "<tr  bgcolor=""DodgerBlue""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Aprovado & "</th><th>" & ac.Obs & "</th><th>" & ac.Pontuacao & "</th><th>" & ac.Evidência & "</th></tr></table><br>"
                                        html1 = Form1.Checarvaloresnulos(ac, html1)
                                    End If
                                End If
                                If ac.EmExecução Then
                                    html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano de ação em Andamento:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                    If ac.Ação <> "" Then
                                        html1 = html1 & "<tr  bgcolor=""Yellow""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Aprovado & "</th><th>" & ac.Obs & "</th><th>" & ac.Pontuacao & "</th><th>" & ac.Evidência & "</th></tr></table><br>"
                                        html1 = Form1.Checarvaloresnulos(ac, html1)
                                    End If
                                End If
                                If ac.Atrasada Then
                                    html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano de Ação Atrasado:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                    If ac.Ação <> "" Then
                                        html1 = html1 & "<tr  bgcolor=""red""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Aprovado & "</th><th>" & ac.Obs & "</th><th>" & ac.Pontuacao & "</th><th>" & ac.Evidência & "</th></tr></table><br>"
                                        html1 = Form1.Checarvaloresnulos(ac, html1)
                                    End If
                                End If
                                If ac.concluida Then
                                    html1 = "<html><meta http-equiv=""Content-type"" content=""text/html;charset=UTF-8""><body><p align=""center"" style = ""font-size:36px"">Plano de ação concluido:</p>" & teste1 & "<table style = ""width:100%""   border=""1"" cellspacing=""2""  >" & "<tr><th>Cliente</th><th>Origem</th><th>Nome Plano de ação</th><th>Não conformidade/Falha</th><th>Ação corretiva</th><th>Responsáveis</th><th>Coordenador/Gerente</th><th>Inicio/Data da Sugestão</th><th>Prazo</th><th>Status</th><th>Aprovado</th><th>Obs</th><th>Pontuação</th><th>Evidência</th></tr>"
                                    If ac.Ação <> "" Then
                                        html1 = html1 & "<tr  bgcolor=""Green""> <th>" & x2.Cliente & "</th>" & "<th>" & x2.Origem & "</th>" & "<th>" & x2.Numero & "</th>" & "<th>" & ac.NãoConformidadeFalha & "</th>" & "<th>" & ac.Ação & "<th>" & responsaveis & "</th>" & "<th>" & Before(ac.GerenteEmail, "@") & "</th><th>" & x2.Inicio & "</th><th>" & ac.Prazo & "</th><th>" & ac.Status & "</th><th>" & ac.Aprovado & "</th><th>" & ac.Obs & "</th><th>" & ac.Pontuacao & "</th><th>" & ac.Evidência & "</th></tr></table><br>"
                                        html1 = Form1.Checarvaloresnulos(ac, html1)
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
        Catch ex As Exception
            MsgBox(ex.Message)
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
    Public Sub ChecarAvaliador(ac As Ação)
        Try
            If ac.AvaliadorPor Is Nothing Then
                If ac.AvaliadorPor Is Nothing Then
                    ac.AvaliadorPor = New String("")
                End If
                If ac.AvaliadorPor = "" Then
                    ac.AvaliadorPor = Before(ac.GerenteEmail, "@")
                End If
                If ac.Pontuacao Is Nothing Then
                    ac.Pontuacao = New String("")
                End If
                If ac.Obs Is Nothing Then
                    ac.Obs = New String("")
                End If
                If ac.Aprovado Is Nothing Then
                    ac.Aprovado = New String("")
                End If
                Form1.save()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim Prompt As String = "Informe o nome do responsável"
            Dim Titulo As String = "Adicionar Responsável"
            Dim valorRetornado As String = ""

            valorRetornado = InputBox(Prompt, Titulo)
            If valorRetornado = "" Then
                MetroMessageBox.Show(Me, "Cliente não pode ser em branco", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim alreadyhave As Boolean = False
            For Each x1 As String In Form1.database.Clientes
                If x1 = valorRetornado Then
                    alreadyhave = True
                    Exit For
                End If
            Next
            If alreadyhave = False Then
                TreeView1.Nodes.Add(valorRetornado)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            TreeView1.Nodes.Remove(TreeView1.SelectedNode)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            TreeView1.Nodes.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Sim_CheckedChanged(sender As Object, e As EventArgs) Handles Sim.CheckedChanged
        Try
            If Sim.Checked = True Then
                Nao.Checked = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Nao_CheckedChanged(sender As Object, e As EventArgs) Handles Nao.CheckedChanged
        Try
            If Nao.Checked = True Then
                Sim.Checked = False
                Motivosabaixo.Visible = True
                Obs.Visible = True
            Else
                Motivosabaixo.Visible = False
                Obs.Visible = False
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Evidencia.ReadOnly = False
        Catch ex As Exception

        End Try
    End Sub
End Class