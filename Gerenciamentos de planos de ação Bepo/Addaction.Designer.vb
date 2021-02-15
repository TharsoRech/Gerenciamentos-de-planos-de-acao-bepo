<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addaction
    Inherits Wisder.W3Common.WMetroControl.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 22)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Ação Corretiva:"
        '
        'Acao
        '
        Me.Acao.Lines = New String(-1) {}
        Me.Acao.Location = New System.Drawing.Point(19, 94)
        Me.Acao.MaxLength = 32767
        Me.Acao.Multiline = True
        Me.Acao.Name = "Acao"
        Me.Acao.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Acao.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Acao.SelectedText = ""
        Me.Acao.Size = New System.Drawing.Size(720, 76)
        Me.Acao.TabIndex = 33
        Me.Acao.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 22)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Emails Responsáveis:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 445)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 22)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Email Coodenador/Gerente:"
        '
        'GerenteEmail
        '
        Me.GerenteEmail.Lines = New String(-1) {}
        Me.GerenteEmail.Location = New System.Drawing.Point(225, 445)
        Me.GerenteEmail.MaxLength = 32767
        Me.GerenteEmail.Name = "GerenteEmail"
        Me.GerenteEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GerenteEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.GerenteEmail.SelectedText = ""
        Me.GerenteEmail.Size = New System.Drawing.Size(498, 23)
        Me.GerenteEmail.TabIndex = 37
        Me.GerenteEmail.UseSelectable = True
        '
        'addacao
        '
        Me.addacao.BackColor = System.Drawing.Color.DodgerBlue
        Me.addacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addacao.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addacao.Location = New System.Drawing.Point(576, 614)
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
        Me.Button1.Location = New System.Drawing.Point(428, 614)
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
        Me.AnexarEvidencia.Location = New System.Drawing.Point(445, 489)
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
        Me.AbrirEvidencia.Location = New System.Drawing.Point(576, 489)
        Me.AbrirEvidencia.Name = "AbrirEvidencia"
        Me.AbrirEvidencia.Size = New System.Drawing.Size(111, 23)
        Me.AbrirEvidencia.TabIndex = 76
        Me.AbrirEvidencia.Text = "Abrir Evidência"
        Me.AbrirEvidencia.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 490)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 22)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Evidência:"
        '
        'Evidencia
        '
        Me.Evidencia.Lines = New String(-1) {}
        Me.Evidencia.Location = New System.Drawing.Point(101, 490)
        Me.Evidencia.MaxLength = 32767
        Me.Evidencia.Name = "Evidencia"
        Me.Evidencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Evidencia.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Evidencia.SelectedText = ""
        Me.Evidencia.Size = New System.Drawing.Size(322, 23)
        Me.Evidencia.TabIndex = 74
        Me.Evidencia.UseSelectable = True
        '
        'Prazo
        '
        Me.Prazo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Prazo.Location = New System.Drawing.Point(75, 588)
        Me.Prazo.Name = "Prazo"
        Me.Prazo.Size = New System.Drawing.Size(655, 20)
        Me.Prazo.TabIndex = 79
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 586)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 22)
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
        Me.Status.Location = New System.Drawing.Point(68, 533)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(655, 29)
        Me.Status.TabIndex = 81
        Me.Status.UseCustomBackColor = True
        Me.Status.UseCustomForeColor = True
        Me.Status.UseSelectable = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 540)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 22)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Status:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 22)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Não Conformidade/Falha:"
        '
        'Falha
        '
        Me.Falha.Lines = New String(-1) {}
        Me.Falha.Location = New System.Drawing.Point(19, 198)
        Me.Falha.MaxLength = 32767
        Me.Falha.Multiline = True
        Me.Falha.Name = "Falha"
        Me.Falha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Falha.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Falha.SelectedText = ""
        Me.Falha.Size = New System.Drawing.Size(720, 73)
        Me.Falha.TabIndex = 82
        Me.Falha.UseSelectable = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Location = New System.Drawing.Point(650, 30)
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
        Me.TreeView1.Location = New System.Drawing.Point(225, 277)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(505, 149)
        Me.TreeView1.TabIndex = 85
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(19, 313)
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
        Me.Button4.Location = New System.Drawing.Point(19, 357)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(190, 23)
        Me.Button4.TabIndex = 87
        Me.Button4.Text = "Remover Responsável Selecionado"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(19, 403)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(190, 23)
        Me.Button5.TabIndex = 88
        Me.Button5.Text = "Remover Todos Responsáveis"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Addaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 651)
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
End Class
