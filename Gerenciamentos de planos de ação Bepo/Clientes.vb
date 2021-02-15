Imports MetroFramework

Public Class Clientes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Form1.currentuser.admin = False Then
            MetroMessageBox.Show(Me, "Você precisa ser administrador para adicionar um cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If Form1.database.Clientes Is Nothing Then
                Form1.database.Clientes = New List(Of String)
                Form1.save()
            End If
            Dim Prompt As String = "Informe o nome cliente"
            Dim Titulo As String = "Adicionar Cliente"
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
                    Form1.database.Clientes.Add(valorRetornado)
                Form1.save()
                TreeView1.Nodes.Add(valorRetornado)
                MetroMessageBox.Show(Me, "Cliente adicionado com sucesso", "Cliente adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MetroMessageBox.Show(Me, "Cliente ja cadastrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each x1 As String In Form1.database.Clientes
                TreeView1.Nodes.Add(x1)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoverClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoverClienteToolStripMenuItem.Click
        Try
            If Form1.currentuser.admin = False Then
                MetroMessageBox.Show(Me, "Você precisa ser administrador para adicionar um cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                For Each x1 As String In Form1.database.Clientes
                    If x1 = TreeView1.SelectedNode.Text Then
                        TreeView1.Nodes.Remove(TreeView1.SelectedNode)
                        Form1.database.Clientes.Remove(x1)
                        Form1.save()
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Contatar.Show()
            Contatar.User.Text = Form1.currentuser.Email
            Contatar.User.Enabled = False
            Contatar.addcl.Checked = True
            Contatar.Alteracaosenha.Enabled = False
            Contatar.Outros.Enabled = False
            Contatar.Enviar.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
End Class