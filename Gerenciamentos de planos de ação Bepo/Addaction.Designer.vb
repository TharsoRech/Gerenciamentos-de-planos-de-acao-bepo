<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Addaction
    Inherits Wisder.W3Common.WMetroControl.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Addaction))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Acao = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GerenteEmail = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.addacao = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AnexarEvidencia = New System.Windows.Forms.Button()
        Me.AbrirEvidencia = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Evidencia = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Prazo = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Status = New Wisder.W3Common.WMetroControl.Controls.MetroComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Falha = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AvaliadoPor = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Obs = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Sim = New Wisder.W3Common.WMetroControl.Controls.MetroToggle()
        Me.Nao = New Wisder.W3Common.WMetroControl.Controls.MetroToggle()
        Me.Pontuacao2 = New System.Windows.Forms.Label()
        Me.Motivosabaixo = New System.Windows.Forms.Label()
        Me.Pontuacao = New Wisder.W3Common.WMetroControl.Controls.MetroComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Inicio = New System.Windows.Forms.DateTimePicker()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 24)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Ação Corretiva:"
        '
        'Acao
        '
        Me.Acao.Lines = New String(-1) {}
        Me.Acao.Location = New System.Drawing.Point(19, 97)
        Me.Acao.MaxLength = 32767
        Me.Acao.Multiline = True
        Me.Acao.Name = "Acao"
        Me.Acao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Acao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Acao.SelectedText = ""
        Me.Acao.Size = New System.Drawing.Size(929, 76)
        Me.Acao.TabIndex = 33
        Me.Acao.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 429)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 24)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Emails Responsáveis:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 501)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 24)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Email Coodenador/Gerente:"
        '
        'GerenteEmail
        '
        Me.GerenteEmail.Lines = New String(-1) {}
        Me.GerenteEmail.Location = New System.Drawing.Point(644, 501)
        Me.GerenteEmail.MaxLength = 32767
        Me.GerenteEmail.Name = "GerenteEmail"
        Me.GerenteEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GerenteEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.GerenteEmail.SelectedText = ""
        Me.GerenteEmail.Size = New System.Drawing.Size(304, 24)
        Me.GerenteEmail.TabIndex = 37
        Me.GerenteEmail.UseSelectable = True
        '
        'addacao
        '
        Me.addacao.BackColor = System.Drawing.Color.DodgerBlue
        Me.addacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addacao.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addacao.Location = New System.Drawing.Point(781, 727)
        Me.addacao.Name = "addacao"
        Me.addacao.Size = New System.Drawing.Size(133, 31)
        Me.addacao.TabIndex = 72
        Me.addacao.Text = "Adicionar Ação"
        Me.addacao.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(638, 727)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 31)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AnexarEvidencia
        '
        Me.AnexarEvidencia.BackColor = System.Drawing.Color.DodgerBlue
        Me.AnexarEvidencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AnexarEvidencia.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnexarEvidencia.Location = New System.Drawing.Point(831, 551)
        Me.AnexarEvidencia.Name = "AnexarEvidencia"
        Me.AnexarEvidencia.Size = New System.Drawing.Size(125, 23)
        Me.AnexarEvidencia.TabIndex = 77
        Me.AnexarEvidencia.Text = "Anexar Evidência"
        Me.AnexarEvidencia.UseVisualStyleBackColor = False
        '
        'AbrirEvidencia
        '
        Me.AbrirEvidencia.BackColor = System.Drawing.Color.DodgerBlue
        Me.AbrirEvidencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AbrirEvidencia.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbrirEvidencia.Location = New System.Drawing.Point(831, 580)
        Me.AbrirEvidencia.Name = "AbrirEvidencia"
        Me.AbrirEvidencia.Size = New System.Drawing.Size(125, 23)
        Me.AbrirEvidencia.TabIndex = 76
        Me.AbrirEvidencia.Text = "Abrir Evidência"
        Me.AbrirEvidencia.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(392, 551)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 24)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Evidência:"
        '
        'Evidencia
        '
        Me.Evidencia.Lines = New String(-1) {}
        Me.Evidencia.Location = New System.Drawing.Point(503, 551)
        Me.Evidencia.MaxLength = 32767
        Me.Evidencia.Name = "Evidencia"
        Me.Evidencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Evidencia.ReadOnly = True
        Me.Evidencia.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Evidencia.SelectedText = ""
        Me.Evidencia.Size = New System.Drawing.Size(322, 23)
        Me.Evidencia.TabIndex = 74
        Me.Evidencia.UseSelectable = True
        '
        'Prazo
        '
        Me.Prazo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Prazo.Location = New System.Drawing.Point(755, 684)
        Me.Prazo.Name = "Prazo"
        Me.Prazo.Size = New System.Drawing.Size(140, 20)
        Me.Prazo.TabIndex = 79
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(686, 682)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 24)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Prazo:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Status
        '
        Me.Status.BackColor = System.Drawing.Color.DodgerBlue
        Me.Status.DropDownHeight = 50
        Me.Status.ForeColor = System.Drawing.Color.Black
        Me.Status.FormattingEnabled = True
        Me.Status.IntegralHeight = False
        Me.Status.ItemHeight = 23
        Me.Status.Items.AddRange(New Object() {"Previsto", "Execução", "Atrasado", "Concluido"})
        Me.Status.Location = New System.Drawing.Point(91, 682)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(364, 29)
        Me.Status.TabIndex = 81
        Me.Status.UseCustomBackColor = True
        Me.Status.UseCustomForeColor = True
        Me.Status.UseSelectable = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 677)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 24)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Status:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 24)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Não Conformidade/Falha:"
        '
        'Falha
        '
        Me.Falha.Lines = New String(-1) {}
        Me.Falha.Location = New System.Drawing.Point(19, 205)
        Me.Falha.MaxLength = 32767
        Me.Falha.Multiline = True
        Me.Falha.Name = "Falha"
        Me.Falha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Falha.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Falha.SelectedText = ""
        Me.Falha.Size = New System.Drawing.Size(927, 79)
        Me.Falha.TabIndex = 82
        Me.Falha.UseSelectable = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Location = New System.Drawing.Point(873, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 58)
        Me.Button2.TabIndex = 84
        Me.Button2.Text = "Imprimir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TreeView1
        '
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(24, 491)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(352, 124)
        Me.TreeView1.TabIndex = 85
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(24, 462)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(190, 23)
        Me.Button3.TabIndex = 86
        Me.Button3.Text = "Adicionar Email Responsável"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(220, 621)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(156, 23)
        Me.Button4.TabIndex = 87
        Me.Button4.Text = "Remover Responsável Selecionado"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(19, 621)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(190, 23)
        Me.Button5.TabIndex = 88
        Me.Button5.Text = "Remover Todos Responsáveis"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(392, 618)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 24)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Avaliado Por:"
        '
        'AvaliadoPor
        '
        Me.AvaliadoPor.Lines = New String(-1) {}
        Me.AvaliadoPor.Location = New System.Drawing.Point(519, 624)
        Me.AvaliadoPor.MaxLength = 32767
        Me.AvaliadoPor.Name = "AvaliadoPor"
        Me.AvaliadoPor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AvaliadoPor.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.AvaliadoPor.SelectedText = ""
        Me.AvaliadoPor.Size = New System.Drawing.Size(306, 20)
        Me.AvaliadoPor.TabIndex = 90
        Me.AvaliadoPor.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(169, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 24)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Aprovado:"
        '
        'Obs
        '
        Me.Obs.Lines = New String(-1) {}
        Me.Obs.Location = New System.Drawing.Point(396, 352)
        Me.Obs.MaxLength = 32767
        Me.Obs.Multiline = True
        Me.Obs.Name = "Obs"
        Me.Obs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Obs.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Obs.SelectedText = ""
        Me.Obs.Size = New System.Drawing.Size(550, 101)
        Me.Obs.TabIndex = 91
        Me.Obs.UseSelectable = True
        Me.Obs.Visible = False
        '
        'Sim
        '
        Me.Sim.AutoSize = True
        Me.Sim.Location = New System.Drawing.Point(33, 335)
        Me.Sim.Name = "Sim"
        Me.Sim.Size = New System.Drawing.Size(80, 17)
        Me.Sim.TabIndex = 94
        Me.Sim.Text = "Sim"
        Me.Sim.UseSelectable = True
        Me.Sim.UseVisualStyleBackColor = True
        '
        'Nao
        '
        Me.Nao.AutoSize = True
        Me.Nao.Location = New System.Drawing.Point(296, 335)
        Me.Nao.Name = "Nao"
        Me.Nao.Size = New System.Drawing.Size(80, 17)
        Me.Nao.TabIndex = 95
        Me.Nao.Text = "Não"
        Me.Nao.UseSelectable = True
        Me.Nao.UseVisualStyleBackColor = True
        '
        'Pontuacao2
        '
        Me.Pontuacao2.AutoSize = True
        Me.Pontuacao2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pontuacao2.Location = New System.Drawing.Point(22, 381)
        Me.Pontuacao2.Name = "Pontuacao2"
        Me.Pontuacao2.Size = New System.Drawing.Size(105, 24)
        Me.Pontuacao2.TabIndex = 96
        Me.Pontuacao2.Text = "Pontuação:"
        '
        'Motivosabaixo
        '
        Me.Motivosabaixo.AutoSize = True
        Me.Motivosabaixo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Motivosabaixo.Location = New System.Drawing.Point(392, 325)
        Me.Motivosabaixo.Name = "Motivosabaixo"
        Me.Motivosabaixo.Size = New System.Drawing.Size(315, 24)
        Me.Motivosabaixo.TabIndex = 97
        Me.Motivosabaixo.Text = "Não aprovado pelos motivos abaixo:"
        Me.Motivosabaixo.Visible = False
        '
        'Pontuacao
        '
        Me.Pontuacao.BackColor = System.Drawing.Color.White
        Me.Pontuacao.DropDownHeight = 50
        Me.Pontuacao.ForeColor = System.Drawing.Color.Black
        Me.Pontuacao.FormattingEnabled = True
        Me.Pontuacao.IntegralHeight = False
        Me.Pontuacao.ItemHeight = 23
        Me.Pontuacao.Items.AddRange(New Object() {"5", "7", "10"})
        Me.Pontuacao.Location = New System.Drawing.Point(134, 381)
        Me.Pontuacao.Name = "Pontuacao"
        Me.Pontuacao.Size = New System.Drawing.Size(132, 29)
        Me.Pontuacao.TabIndex = 98
        Me.Pontuacao.UseCustomBackColor = True
        Me.Pontuacao.UseCustomForeColor = True
        Me.Pontuacao.UseSelectable = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(471, 682)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 24)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "Inicio:"
        '
        'Inicio
        '
        Me.Inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Inicio.Location = New System.Drawing.Point(530, 686)
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Size = New System.Drawing.Size(130, 20)
        Me.Inicio.TabIndex = 100
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(618, 580)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(207, 23)
        Me.Button6.TabIndex = 101
        Me.Button6.Text = "Alterar Caminho Manualmente"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Addaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 765)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Inicio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Pontuacao)
        Me.Controls.Add(Me.Motivosabaixo)
        Me.Controls.Add(Me.Pontuacao2)
        Me.Controls.Add(Me.Nao)
        Me.Controls.Add(Me.Sim)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Obs)
        Me.Controls.Add(Me.AvaliadoPor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Falha)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Prazo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.AnexarEvidencia)
        Me.Controls.Add(Me.AbrirEvidencia)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Evidencia)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.addacao)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GerenteEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Acao)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Addaction"
        Me.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow
        Me.Text = "Adicionar ação"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Public WithEvents addacao As Button
    Public WithEvents Button1 As Button
    Public WithEvents Acao As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Public WithEvents GerenteEmail As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Public WithEvents AnexarEvidencia As Button
    Friend WithEvents AbrirEvidencia As Button
    Friend WithEvents Label10 As Label
    Public WithEvents Evidencia As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Public WithEvents Prazo As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Public WithEvents Status As Wisder.W3Common.WMetroControl.Controls.MetroComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Public WithEvents Falha As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Public WithEvents TreeView1 As TreeView
    Friend WithEvents Label3 As Label
    Public WithEvents AvaliadoPor As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Label5 As Label
    Public WithEvents Obs As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Sim As Wisder.W3Common.WMetroControl.Controls.MetroToggle
    Friend WithEvents Nao As Wisder.W3Common.WMetroControl.Controls.MetroToggle
    Friend WithEvents Pontuacao2 As Label
    Friend WithEvents Motivosabaixo As Label
    Public WithEvents Pontuacao As Wisder.W3Common.WMetroControl.Controls.MetroComboBox
    Friend WithEvents Label8 As Label
    Public WithEvents Inicio As DateTimePicker
    Friend WithEvents Button6 As Button
End Class
