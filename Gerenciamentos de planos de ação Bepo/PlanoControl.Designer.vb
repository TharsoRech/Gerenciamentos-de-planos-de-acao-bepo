<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlanoControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlanoControl))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumeroPlano = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Origem = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SalvarAlteracoes = New System.Windows.Forms.Button()
        Me.Inicio = New System.Windows.Forms.DateTimePicker()
        Me.seila = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ATualizado = New System.Windows.Forms.Label()
        Me.MetroGrid1 = New Wisder.W3Common.WMetroControl.Controls.MetroGrid()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroContextMenu1 = New Wisder.W3Common.WMetroControl.Controls.MetroContextMenu(Me.components)
        Me.DuplicarAçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoverAcimaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoverAbaixoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.addacao = New System.Windows.Forms.Button()
        Me.EditarAcao = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Cliente = New Wisder.W3Common.WMetroControl.Controls.MetroComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 22)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Ações Corretiva:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 22)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Nome plano de ação:"
        '
        'NumeroPlano
        '
        Me.NumeroPlano.Lines = New String(-1) {}
        Me.NumeroPlano.Location = New System.Drawing.Point(199, 123)
        Me.NumeroPlano.MaxLength = 32767
        Me.NumeroPlano.Name = "NumeroPlano"
        Me.NumeroPlano.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NumeroPlano.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.NumeroPlano.SelectedText = ""
        Me.NumeroPlano.Size = New System.Drawing.Size(669, 23)
        Me.NumeroPlano.TabIndex = 44
        Me.NumeroPlano.UseSelectable = True
        '
        'Origem
        '
        Me.Origem.Lines = New String(-1) {}
        Me.Origem.Location = New System.Drawing.Point(199, 94)
        Me.Origem.MaxLength = 32767
        Me.Origem.Name = "Origem"
        Me.Origem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Origem.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Origem.SelectedText = ""
        Me.Origem.Size = New System.Drawing.Size(669, 23)
        Me.Origem.TabIndex = 43
        Me.Origem.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 22)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Origem N.C:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 22)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Cliente:"
        '
        'SalvarAlteracoes
        '
        Me.SalvarAlteracoes.BackColor = System.Drawing.Color.DodgerBlue
        Me.SalvarAlteracoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SalvarAlteracoes.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalvarAlteracoes.Location = New System.Drawing.Point(6, 467)
        Me.SalvarAlteracoes.Name = "SalvarAlteracoes"
        Me.SalvarAlteracoes.Size = New System.Drawing.Size(897, 45)
        Me.SalvarAlteracoes.TabIndex = 59
        Me.SalvarAlteracoes.Text = "Salvar alterações"
        Me.SalvarAlteracoes.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.Inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Inicio.Location = New System.Drawing.Point(78, 434)
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Size = New System.Drawing.Size(790, 20)
        Me.Inicio.TabIndex = 63
        '
        'seila
        '
        Me.seila.AutoSize = True
        Me.seila.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seila.Location = New System.Drawing.Point(4, 434)
        Me.seila.Name = "seila"
        Me.seila.Size = New System.Drawing.Size(49, 22)
        Me.seila.TabIndex = 62
        Me.seila.Text = "Inicio:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ATualizado
        '
        Me.ATualizado.AutoSize = True
        Me.ATualizado.Font = New System.Drawing.Font("Caladea", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ATualizado.Location = New System.Drawing.Point(23, 21)
        Me.ATualizado.Name = "ATualizado"
        Me.ATualizado.Size = New System.Drawing.Size(212, 22)
        Me.ATualizado.TabIndex = 66
        Me.ATualizado.Text = "Plano de ação Atualizado"
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.MetroGrid1.ContextMenuStrip = Me.MetroContextMenu1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(6, 211)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(677, 217)
        Me.MetroGrid1.TabIndex = 67
        '
        'Column7
        '
        Me.Column7.HeaderText = "Não conformidade/ Falha"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Ação"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 55
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Responsáveis"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 99
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Email Gerente/Diretor"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 129
        '
        'Column4
        '
        Me.Column4.HeaderText = "Evidência"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 78
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Prazo"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 58
        '
        'Column6
        '
        Me.Column6.HeaderText = "Status"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DuplicarAçãoToolStripMenuItem, Me.MoverAcimaToolStripMenuItem, Me.MoverAbaixoToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(149, 70)
        '
        'DuplicarAçãoToolStripMenuItem
        '
        Me.DuplicarAçãoToolStripMenuItem.Image = CType(resources.GetObject("DuplicarAçãoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DuplicarAçãoToolStripMenuItem.Name = "DuplicarAçãoToolStripMenuItem"
        Me.DuplicarAçãoToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.DuplicarAçãoToolStripMenuItem.Text = "Duplicar Ação"
        '
        'MoverAcimaToolStripMenuItem
        '
        Me.MoverAcimaToolStripMenuItem.Image = CType(resources.GetObject("MoverAcimaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MoverAcimaToolStripMenuItem.Name = "MoverAcimaToolStripMenuItem"
        Me.MoverAcimaToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.MoverAcimaToolStripMenuItem.Text = "Mover Acima"
        '
        'MoverAbaixoToolStripMenuItem
        '
        Me.MoverAbaixoToolStripMenuItem.Image = CType(resources.GetObject("MoverAbaixoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MoverAbaixoToolStripMenuItem.Name = "MoverAbaixoToolStripMenuItem"
        Me.MoverAbaixoToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.MoverAbaixoToolStripMenuItem.Text = "Mover abaixo"
        '
        'addacao
        '
        Me.addacao.BackColor = System.Drawing.Color.DodgerBlue
        Me.addacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addacao.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addacao.Location = New System.Drawing.Point(689, 284)
        Me.addacao.Name = "addacao"
        Me.addacao.Size = New System.Drawing.Size(190, 33)
        Me.addacao.TabIndex = 68
        Me.addacao.Text = "Adicionar Ação"
        Me.addacao.UseVisualStyleBackColor = False
        '
        'EditarAcao
        '
        Me.EditarAcao.BackColor = System.Drawing.Color.DodgerBlue
        Me.EditarAcao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditarAcao.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarAcao.Location = New System.Drawing.Point(692, 336)
        Me.EditarAcao.Name = "EditarAcao"
        Me.EditarAcao.Size = New System.Drawing.Size(190, 32)
        Me.EditarAcao.TabIndex = 74
        Me.EditarAcao.Text = "Editar ação selecionada"
        Me.EditarAcao.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(689, 384)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(190, 32)
        Me.Button3.TabIndex = 75
        Me.Button3.Text = "Abrir Evidência "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(692, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(190, 56)
        Me.Button2.TabIndex = 85
        Me.Button2.Text = "Gerar Relatório dos planos"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Cliente
        '
        Me.Cliente.FormattingEnabled = True
        Me.Cliente.ItemHeight = 23
        Me.Cliente.Location = New System.Drawing.Point(199, 51)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(669, 29)
        Me.Cliente.TabIndex = 86
        Me.Cliente.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Caladea", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(629, 19)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Para remover uma ação é necessário ir ate histórico de planos e mover para lista " &
    "de excluidos"
        '
        'PlanoControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.EditarAcao)
        Me.Controls.Add(Me.addacao)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.ATualizado)
        Me.Controls.Add(Me.Inicio)
        Me.Controls.Add(Me.seila)
        Me.Controls.Add(Me.SalvarAlteracoes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumeroPlano)
        Me.Controls.Add(Me.Origem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PlanoControl"
        Me.Size = New System.Drawing.Size(903, 513)
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Public WithEvents SalvarAlteracoes As Button
    Public WithEvents NumeroPlano As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Public WithEvents Origem As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Public WithEvents Inicio As DateTimePicker
    Friend WithEvents seila As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Public WithEvents ATualizado As Label
    Public WithEvents MetroGrid1 As Wisder.W3Common.WMetroControl.Controls.MetroGrid
    Public WithEvents addacao As Button
    Public WithEvents EditarAcao As Button
    Public WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Cliente As Wisder.W3Common.WMetroControl.Controls.MetroComboBox
    Public WithEvents Label3 As Label
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents MetroContextMenu1 As Wisder.W3Common.WMetroControl.Controls.MetroContextMenu
    Friend WithEvents DuplicarAçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoverAcimaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoverAbaixoToolStripMenuItem As ToolStripMenuItem
End Class
