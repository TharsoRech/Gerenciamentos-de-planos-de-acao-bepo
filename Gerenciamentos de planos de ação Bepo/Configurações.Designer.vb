<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configurações
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configurações))
        Me.MetroTabControl1 = New Wisder.W3Common.WMetroControl.Controls.MetroTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CurrentVersion = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SenhaWindows = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.UsuarioWindows = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.HorarioFinal = New System.Windows.Forms.DateTimePicker()
        Me.HorarioInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Veragendamentos = New System.Windows.Forms.Button()
        Me.TornarServidor = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Servidor = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Senha = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Email = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AposUltimoDiretor = New Wisder.W3Common.WMetroControl.Controls.MetroCheckBox()
        Me.AposDiretor = New Wisder.W3Common.WMetroControl.Controls.MetroCheckBox()
        Me.AntesDiretor = New Wisder.W3Common.WMetroControl.Controls.MetroCheckBox()
        Me.Aposutlimoresponsavel = New Wisder.W3Common.WMetroControl.Controls.MetroCheckBox()
        Me.AposResponsavel = New Wisder.W3Common.WMetroControl.Controls.MetroCheckBox()
        Me.Antesresponsavel = New Wisder.W3Common.WMetroControl.Controls.MetroCheckBox()
        Me.DiasAposUltimo = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DiasApos = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DiasAntes = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DatabaseLocationtext = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.MetroGrid1 = New Wisder.W3Common.WMetroControl.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroContextMenu1 = New Wisder.W3Common.WMetroControl.Controls.MetroContextMenu(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.MetroTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DiasAposUltimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiasApos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiasAntes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.TabPage1)
        Me.MetroTabControl1.Controls.Add(Me.TabPage3)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Location = New System.Drawing.Point(20, 60)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.Padding = New System.Drawing.Point(6, 8)
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(948, 618)
        Me.MetroTabControl1.TabIndex = 1
        Me.MetroTabControl1.UseSelectable = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CurrentVersion)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.SenhaWindows)
        Me.TabPage1.Controls.Add(Me.UsuarioWindows)
        Me.TabPage1.Controls.Add(Me.HorarioFinal)
        Me.TabPage1.Controls.Add(Me.HorarioInicial)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Veragendamentos)
        Me.TabPage1.Controls.Add(Me.TornarServidor)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Servidor)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Senha)
        Me.TabPage1.Controls.Add(Me.Email)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.AposUltimoDiretor)
        Me.TabPage1.Controls.Add(Me.AposDiretor)
        Me.TabPage1.Controls.Add(Me.AntesDiretor)
        Me.TabPage1.Controls.Add(Me.Aposutlimoresponsavel)
        Me.TabPage1.Controls.Add(Me.AposResponsavel)
        Me.TabPage1.Controls.Add(Me.Antesresponsavel)
        Me.TabPage1.Controls.Add(Me.DiasAposUltimo)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.DiasApos)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.DiasAntes)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.DatabaseLocationtext)
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(940, 576)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Geral"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CurrentVersion
        '
        Me.CurrentVersion.AutoSize = True
        Me.CurrentVersion.Font = New System.Drawing.Font("Carlito", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentVersion.Location = New System.Drawing.Point(75, 35)
        Me.CurrentVersion.Name = "CurrentVersion"
        Me.CurrentVersion.Size = New System.Drawing.Size(0, 23)
        Me.CurrentVersion.TabIndex = 79
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 22)
        Me.Label17.TabIndex = 78
        Me.Label17.Text = "Versão:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(473, 430)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 22)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "Senha(Windows):"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(461, 392)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(143, 22)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "Usuário(Windows):"
        '
        'SenhaWindows
        '
        Me.SenhaWindows.Lines = New String(-1) {}
        Me.SenhaWindows.Location = New System.Drawing.Point(630, 430)
        Me.SenhaWindows.MaxLength = 32767
        Me.SenhaWindows.Name = "SenhaWindows"
        Me.SenhaWindows.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.SenhaWindows.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SenhaWindows.SelectedText = ""
        Me.SenhaWindows.Size = New System.Drawing.Size(271, 23)
        Me.SenhaWindows.TabIndex = 75
        Me.SenhaWindows.UseSelectable = True
        Me.SenhaWindows.UseSystemPasswordChar = True
        '
        'UsuarioWindows
        '
        Me.UsuarioWindows.Lines = New String(-1) {}
        Me.UsuarioWindows.Location = New System.Drawing.Point(629, 392)
        Me.UsuarioWindows.MaxLength = 32767
        Me.UsuarioWindows.Name = "UsuarioWindows"
        Me.UsuarioWindows.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsuarioWindows.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UsuarioWindows.SelectedText = ""
        Me.UsuarioWindows.Size = New System.Drawing.Size(272, 23)
        Me.UsuarioWindows.TabIndex = 74
        Me.UsuarioWindows.UseSelectable = True
        '
        'HorarioFinal
        '
        Me.HorarioFinal.CustomFormat = """hh:mm tt"""
        Me.HorarioFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.HorarioFinal.Location = New System.Drawing.Point(724, 495)
        Me.HorarioFinal.Name = "HorarioFinal"
        Me.HorarioFinal.ShowUpDown = True
        Me.HorarioFinal.Size = New System.Drawing.Size(130, 20)
        Me.HorarioFinal.TabIndex = 73
        '
        'HorarioInicial
        '
        Me.HorarioInicial.CustomFormat = """hh:mm tt"""
        Me.HorarioInicial.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.HorarioInicial.Location = New System.Drawing.Point(725, 462)
        Me.HorarioInicial.Name = "HorarioInicial"
        Me.HorarioInicial.ShowUpDown = True
        Me.HorarioInicial.Size = New System.Drawing.Size(129, 20)
        Me.HorarioInicial.TabIndex = 72
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(473, 495)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(231, 19)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Horário Final para checar alertas:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(473, 462)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(237, 19)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Horário Inicial para checar alertas:"
        '
        'Veragendamentos
        '
        Me.Veragendamentos.BackColor = System.Drawing.Color.DodgerBlue
        Me.Veragendamentos.Enabled = False
        Me.Veragendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Veragendamentos.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Veragendamentos.Location = New System.Drawing.Point(475, 533)
        Me.Veragendamentos.Name = "Veragendamentos"
        Me.Veragendamentos.Size = New System.Drawing.Size(162, 23)
        Me.Veragendamentos.TabIndex = 66
        Me.Veragendamentos.Text = "Ver agendamentos"
        Me.Veragendamentos.UseVisualStyleBackColor = False
        '
        'TornarServidor
        '
        Me.TornarServidor.BackColor = System.Drawing.Color.DodgerBlue
        Me.TornarServidor.Enabled = False
        Me.TornarServidor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TornarServidor.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TornarServidor.Location = New System.Drawing.Point(667, 533)
        Me.TornarServidor.Name = "TornarServidor"
        Me.TornarServidor.Size = New System.Drawing.Size(222, 23)
        Me.TornarServidor.TabIndex = 65
        Me.TornarServidor.Text = "Adicionar agendamento de alerta"
        Me.TornarServidor.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Carlito", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(461, 325)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(318, 23)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Configurações  do  do servidor de alerta:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 354)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(319, 32)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Caso não seja configurado o email remente não será " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "possivel enviar nenhum email" &
    " de alerta."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Carlito", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 325)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(364, 23)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Configurações  do  Email remetente dos alerta:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 491)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 22)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Servidor:"
        '
        'Servidor
        '
        Me.Servidor.Enabled = False
        Me.Servidor.Lines = New String(-1) {}
        Me.Servidor.Location = New System.Drawing.Point(93, 491)
        Me.Servidor.MaxLength = 32767
        Me.Servidor.Name = "Servidor"
        Me.Servidor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Servidor.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Servidor.SelectedText = ""
        Me.Servidor.Size = New System.Drawing.Size(330, 23)
        Me.Servidor.TabIndex = 60
        Me.Servidor.UseSelectable = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(52, 533)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(222, 23)
        Me.Button3.TabIndex = 59
        Me.Button3.Text = "Remover Configurações do email"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(348, 290)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(180, 22)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Configurações  de alerta:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 449)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 22)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Senha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 408)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 22)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Email:"
        '
        'Senha
        '
        Me.Senha.Enabled = False
        Me.Senha.Lines = New String(-1) {}
        Me.Senha.Location = New System.Drawing.Point(94, 448)
        Me.Senha.MaxLength = 32767
        Me.Senha.Name = "Senha"
        Me.Senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Senha.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Senha.SelectedText = ""
        Me.Senha.Size = New System.Drawing.Size(329, 23)
        Me.Senha.TabIndex = 55
        Me.Senha.UseSelectable = True
        Me.Senha.UseSystemPasswordChar = True
        '
        'Email
        '
        Me.Email.Enabled = False
        Me.Email.Lines = New String(-1) {}
        Me.Email.Location = New System.Drawing.Point(93, 405)
        Me.Email.MaxLength = 32767
        Me.Email.Name = "Email"
        Me.Email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Email.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Email.SelectedText = ""
        Me.Email.Size = New System.Drawing.Size(330, 23)
        Me.Email.TabIndex = 54
        Me.Email.UseSelectable = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(292, 533)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 23)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "Configurar Email"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'AposUltimoDiretor
        '
        Me.AposUltimoDiretor.AutoSize = True
        Me.AposUltimoDiretor.Location = New System.Drawing.Point(700, 255)
        Me.AposUltimoDiretor.Name = "AposUltimoDiretor"
        Me.AposUltimoDiretor.Size = New System.Drawing.Size(234, 15)
        Me.AposUltimoDiretor.TabIndex = 52
        Me.AposUltimoDiretor.Text = "Enviar Alerta para Coordenador/Gerente"
        Me.AposUltimoDiretor.UseSelectable = True
        Me.AposUltimoDiretor.UseVisualStyleBackColor = True
        '
        'AposDiretor
        '
        Me.AposDiretor.AutoSize = True
        Me.AposDiretor.Location = New System.Drawing.Point(662, 215)
        Me.AposDiretor.Name = "AposDiretor"
        Me.AposDiretor.Size = New System.Drawing.Size(234, 15)
        Me.AposDiretor.TabIndex = 51
        Me.AposDiretor.Text = "Enviar Alerta para Coordenador/Gerente"
        Me.AposDiretor.UseSelectable = True
        Me.AposDiretor.UseVisualStyleBackColor = True
        '
        'AntesDiretor
        '
        Me.AntesDiretor.AutoSize = True
        Me.AntesDiretor.Location = New System.Drawing.Point(680, 180)
        Me.AntesDiretor.Name = "AntesDiretor"
        Me.AntesDiretor.Size = New System.Drawing.Size(234, 15)
        Me.AntesDiretor.TabIndex = 50
        Me.AntesDiretor.Text = "Enviar Alerta para Coordenador/Gerente"
        Me.AntesDiretor.UseSelectable = True
        Me.AntesDiretor.UseVisualStyleBackColor = True
        '
        'Aposutlimoresponsavel
        '
        Me.Aposutlimoresponsavel.AutoSize = True
        Me.Aposutlimoresponsavel.Location = New System.Drawing.Point(472, 257)
        Me.Aposutlimoresponsavel.Name = "Aposutlimoresponsavel"
        Me.Aposutlimoresponsavel.Size = New System.Drawing.Size(224, 15)
        Me.Aposutlimoresponsavel.TabIndex = 49
        Me.Aposutlimoresponsavel.Text = "Enviar Alerta para responsável da ação"
        Me.Aposutlimoresponsavel.UseSelectable = True
        Me.Aposutlimoresponsavel.UseVisualStyleBackColor = True
        '
        'AposResponsavel
        '
        Me.AposResponsavel.AutoSize = True
        Me.AposResponsavel.Location = New System.Drawing.Point(432, 215)
        Me.AposResponsavel.Name = "AposResponsavel"
        Me.AposResponsavel.Size = New System.Drawing.Size(224, 15)
        Me.AposResponsavel.TabIndex = 48
        Me.AposResponsavel.Text = "Enviar Alerta para responsável da ação"
        Me.AposResponsavel.UseSelectable = True
        Me.AposResponsavel.UseVisualStyleBackColor = True
        '
        'Antesresponsavel
        '
        Me.Antesresponsavel.AutoSize = True
        Me.Antesresponsavel.Location = New System.Drawing.Point(450, 180)
        Me.Antesresponsavel.Name = "Antesresponsavel"
        Me.Antesresponsavel.Size = New System.Drawing.Size(224, 15)
        Me.Antesresponsavel.TabIndex = 47
        Me.Antesresponsavel.Text = "Enviar Alerta para responsável da ação"
        Me.Antesresponsavel.UseSelectable = True
        Me.Antesresponsavel.UseVisualStyleBackColor = True
        '
        'DiasAposUltimo
        '
        Me.DiasAposUltimo.Location = New System.Drawing.Point(346, 255)
        Me.DiasAposUltimo.Name = "DiasAposUltimo"
        Me.DiasAposUltimo.Size = New System.Drawing.Size(120, 20)
        Me.DiasAposUltimo.TabIndex = 46
        Me.DiasAposUltimo.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(337, 23)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Dias após o prazo para emitir ultimo alerta:"
        '
        'DiasApos
        '
        Me.DiasApos.Location = New System.Drawing.Point(303, 215)
        Me.DiasApos.Name = "DiasApos"
        Me.DiasApos.Size = New System.Drawing.Size(120, 20)
        Me.DiasApos.TabIndex = 44
        Me.DiasApos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(285, 23)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Dias após o prazo para emitir alerta:"
        '
        'DiasAntes
        '
        Me.DiasAntes.Location = New System.Drawing.Point(324, 178)
        Me.DiasAntes.Name = "DiasAntes"
        Me.DiasAntes.Size = New System.Drawing.Size(120, 20)
        Me.DiasAntes.TabIndex = 42
        Me.DiasAntes.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(306, 23)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Dias antes do prazo para emitir alerta :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(299, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 22)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Configurações de Alerta de Email:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(781, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 24)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Abrir Local do Arquivo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 22)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Localização Database:"
        '
        'DatabaseLocationtext
        '
        Me.DatabaseLocationtext.Lines = New String(-1) {}
        Me.DatabaseLocationtext.Location = New System.Drawing.Point(176, 81)
        Me.DatabaseLocationtext.MaxLength = 32767
        Me.DatabaseLocationtext.Name = "DatabaseLocationtext"
        Me.DatabaseLocationtext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DatabaseLocationtext.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DatabaseLocationtext.SelectedText = ""
        Me.DatabaseLocationtext.Size = New System.Drawing.Size(599, 23)
        Me.DatabaseLocationtext.TabIndex = 35
        Me.DatabaseLocationtext.UseSelectable = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.MetroGrid1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 38)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(940, 576)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Usuários"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column4})
        Me.MetroGrid1.ContextMenuStrip = Me.MetroContextMenu1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(3, 3)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(934, 570)
        Me.MetroGrid1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Usuário"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 70
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Email"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 57
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Email Gerente"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 93
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Data de Criação"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 102
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Administrador"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 103
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.RemoverToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(122, 48)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = CType(resources.GetObject("EditarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'RemoverToolStripMenuItem
        '
        Me.RemoverToolStripMenuItem.Image = CType(resources.GetObject("RemoverToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemoverToolStripMenuItem.Name = "RemoverToolStripMenuItem"
        Me.RemoverToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.RemoverToolStripMenuItem.Text = "Remover"
        '
        'Configurações
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 698)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Configurações"
        Me.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow
        Me.Text = "Configurações"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DiasAposUltimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiasApos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiasAntes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTabControl1 As Wisder.W3Common.WMetroControl.Controls.MetroTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label1 As Label
    Public WithEvents DatabaseLocationtext As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents MetroGrid1 As Wisder.W3Common.WMetroControl.Controls.MetroGrid
    Friend WithEvents MetroContextMenu1 As Wisder.W3Common.WMetroControl.Controls.MetroContextMenu
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents DiasAntes As NumericUpDown
    Friend WithEvents DiasAposUltimo As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents DiasApos As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Senha As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Email As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Button2 As Button
    Public WithEvents AposUltimoDiretor As Wisder.W3Common.WMetroControl.Controls.MetroCheckBox
    Public WithEvents AposDiretor As Wisder.W3Common.WMetroControl.Controls.MetroCheckBox
    Public WithEvents AntesDiretor As Wisder.W3Common.WMetroControl.Controls.MetroCheckBox
    Public WithEvents Aposutlimoresponsavel As Wisder.W3Common.WMetroControl.Controls.MetroCheckBox
    Public WithEvents AposResponsavel As Wisder.W3Common.WMetroControl.Controls.MetroCheckBox
    Public WithEvents Antesresponsavel As Wisder.W3Common.WMetroControl.Controls.MetroCheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Servidor As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Veragendamentos As Button
    Friend WithEvents TornarServidor As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents HorarioFinal As DateTimePicker
    Friend WithEvents HorarioInicial As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents SenhaWindows As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents UsuarioWindows As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents CurrentVersion As Label
End Class
