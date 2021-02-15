<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contatar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contatar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.admins = New Wisder.W3Common.WMetroControl.Controls.MetroComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Mensagem = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.User = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Alteracaosenha = New Wisder.W3Common.WMetroControl.Controls.MetroCheckBox()
        Me.addcl = New Wisder.W3Common.WMetroControl.Controls.MetroCheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Enviar = New System.Windows.Forms.Button()
        Me.Outros = New Wisder.W3Common.WMetroControl.Controls.MetroCheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 22)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Solicitar:"
        '
        'admins
        '
        Me.admins.FormattingEnabled = True
        Me.admins.ItemHeight = 23
        Me.admins.Location = New System.Drawing.Point(306, 266)
        Me.admins.Name = "admins"
        Me.admins.Size = New System.Drawing.Size(355, 29)
        Me.admins.TabIndex = 87
        Me.admins.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 22)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Administrador á enviar solicitação:"
        '
        'Mensagem
        '
        Me.Mensagem.Lines = New String(-1) {}
        Me.Mensagem.Location = New System.Drawing.Point(42, 342)
        Me.Mensagem.MaxLength = 32767
        Me.Mensagem.Multiline = True
        Me.Mensagem.Name = "Mensagem"
        Me.Mensagem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Mensagem.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Mensagem.SelectedText = ""
        Me.Mensagem.Size = New System.Drawing.Size(619, 65)
        Me.Mensagem.TabIndex = 89
        Me.Mensagem.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 22)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Mensagem:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 22)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Email ou usuário solicitante:"
        '
        'User
        '
        Me.User.Lines = New String(-1) {}
        Me.User.Location = New System.Drawing.Point(42, 228)
        Me.User.MaxLength = 32767
        Me.User.Name = "User"
        Me.User.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.User.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.User.SelectedText = ""
        Me.User.Size = New System.Drawing.Size(619, 23)
        Me.User.TabIndex = 92
        Me.User.UseSelectable = True
        '
        'Alteracaosenha
        '
        Me.Alteracaosenha.AutoSize = True
        Me.Alteracaosenha.Location = New System.Drawing.Point(117, 82)
        Me.Alteracaosenha.Name = "Alteracaosenha"
        Me.Alteracaosenha.Size = New System.Drawing.Size(123, 15)
        Me.Alteracaosenha.TabIndex = 93
        Me.Alteracaosenha.Text = "Alteração de senha"
        Me.Alteracaosenha.UseSelectable = True
        Me.Alteracaosenha.UseVisualStyleBackColor = True
        '
        'addcl
        '
        Me.addcl.AutoSize = True
        Me.addcl.Location = New System.Drawing.Point(117, 123)
        Me.addcl.Name = "addcl"
        Me.addcl.Size = New System.Drawing.Size(544, 15)
        Me.addcl.TabIndex = 94
        Me.addcl.Text = "Adição ou remoçaõ de cliente(Incluir nome do cliente na mensagem e se deseja remo" &
    "ver ou inclui)"
        Me.addcl.UseSelectable = True
        Me.addcl.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(254, 423)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 24)
        Me.Button2.TabIndex = 96
        Me.Button2.Text = "Sair"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Enviar
        '
        Me.Enviar.BackColor = System.Drawing.Color.DodgerBlue
        Me.Enviar.Enabled = False
        Me.Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Enviar.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enviar.Location = New System.Drawing.Point(448, 423)
        Me.Enviar.Name = "Enviar"
        Me.Enviar.Size = New System.Drawing.Size(131, 24)
        Me.Enviar.TabIndex = 95
        Me.Enviar.Text = "Enviar solicitação"
        Me.Enviar.UseVisualStyleBackColor = False
        '
        'Outros
        '
        Me.Outros.AutoSize = True
        Me.Outros.Location = New System.Drawing.Point(117, 160)
        Me.Outros.Name = "Outros"
        Me.Outros.Size = New System.Drawing.Size(129, 15)
        Me.Outros.TabIndex = 97
        Me.Outros.Text = "Assistência e Outros"
        Me.Outros.UseSelectable = True
        Me.Outros.UseVisualStyleBackColor = True
        '
        'Contatar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 458)
        Me.Controls.Add(Me.Outros)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Enviar)
        Me.Controls.Add(Me.addcl)
        Me.Controls.Add(Me.Alteracaosenha)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Mensagem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.admins)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Contatar"
        Me.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow
        Me.Style = Wisder.W3Common.WMetroControl.MetroColorStyle.Black
        Me.Text = "Contatar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents admins As Wisder.W3Common.WMetroControl.Controls.MetroComboBox
    Friend WithEvents Label2 As Label
    Public WithEvents Mensagem As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Public WithEvents User As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Button2 As Button
    Public WithEvents Alteracaosenha As Wisder.W3Common.WMetroControl.Controls.MetroCheckBox
    Public WithEvents addcl As Wisder.W3Common.WMetroControl.Controls.MetroCheckBox
    Public WithEvents Outros As Wisder.W3Common.WMetroControl.Controls.MetroCheckBox
    Public WithEvents Enviar As Button
End Class
