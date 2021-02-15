<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AlertasControlvb
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlertasControlvb))
        Me.MetroGrid1 = New Wisder.W3Common.WMetroControl.Controls.MetroGrid()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroContextMenu1 = New Wisder.W3Common.WMetroControl.Controls.MetroContextMenu(Me.components)
        Me.VisualizarPlanoDeAçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirPlanoDeAçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarEmailManualmenteParaResponsávelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarEmailManualmenteParaGerenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarEmailManualmenteParaGerenteDiretorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirAlertaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimparAlertasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
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
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column4, Me.Column2, Me.Column3, Me.Column8, Me.Column1, Me.Column5, Me.Column6, Me.Column7, Me.Column10})
        Me.MetroGrid1.ContextMenuStrip = Me.MetroContextMenu1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(20, 104)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(1150, 519)
        Me.MetroGrid1.TabIndex = 3
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.FillWeight = 200.0!
        Me.Column9.HeaderText = "Mensagem"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 86
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.FillWeight = 200.0!
        Me.Column4.HeaderText = "Status"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 62
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.FillWeight = 200.0!
        Me.Column2.HeaderText = "Nome Plano de ação"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 102
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.FillWeight = 200.0!
        Me.Column3.HeaderText = "Responsáveis"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 99
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.FillWeight = 200.0!
        Me.Column8.HeaderText = "Gerente\Diretor"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 111
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.FillWeight = 200.0!
        Me.Column1.HeaderText = "Cliente"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 66
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.FillWeight = 200.0!
        Me.Column5.HeaderText = "Inicio"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 58
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.FillWeight = 200.0!
        Me.Column6.HeaderText = "Prazo"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 58
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Ação"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 55
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "Falha/não conformidade"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 143
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualizarPlanoDeAçãoToolStripMenuItem, Me.AbrirPlanoDeAçãoToolStripMenuItem, Me.EnviarEmailManualmenteParaResponsávelToolStripMenuItem, Me.EnviarEmailManualmenteParaGerenteToolStripMenuItem, Me.EnviarEmailManualmenteParaGerenteDiretorToolStripMenuItem, Me.ExcluirAlertaToolStripMenuItem, Me.LimparAlertasToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(411, 158)
        '
        'VisualizarPlanoDeAçãoToolStripMenuItem
        '
        Me.VisualizarPlanoDeAçãoToolStripMenuItem.Image = CType(resources.GetObject("VisualizarPlanoDeAçãoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VisualizarPlanoDeAçãoToolStripMenuItem.Name = "VisualizarPlanoDeAçãoToolStripMenuItem"
        Me.VisualizarPlanoDeAçãoToolStripMenuItem.Size = New System.Drawing.Size(410, 22)
        Me.VisualizarPlanoDeAçãoToolStripMenuItem.Text = "Visualizar Plano de ação"
        '
        'AbrirPlanoDeAçãoToolStripMenuItem
        '
        Me.AbrirPlanoDeAçãoToolStripMenuItem.Image = CType(resources.GetObject("AbrirPlanoDeAçãoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbrirPlanoDeAçãoToolStripMenuItem.Name = "AbrirPlanoDeAçãoToolStripMenuItem"
        Me.AbrirPlanoDeAçãoToolStripMenuItem.Size = New System.Drawing.Size(410, 22)
        Me.AbrirPlanoDeAçãoToolStripMenuItem.Text = "Alterar Plano de ação"
        '
        'EnviarEmailManualmenteParaResponsávelToolStripMenuItem
        '
        Me.EnviarEmailManualmenteParaResponsávelToolStripMenuItem.Image = CType(resources.GetObject("EnviarEmailManualmenteParaResponsávelToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EnviarEmailManualmenteParaResponsávelToolStripMenuItem.Name = "EnviarEmailManualmenteParaResponsávelToolStripMenuItem"
        Me.EnviarEmailManualmenteParaResponsávelToolStripMenuItem.Size = New System.Drawing.Size(410, 22)
        Me.EnviarEmailManualmenteParaResponsávelToolStripMenuItem.Text = "Enviar Email Manualmente para responsável"
        '
        'EnviarEmailManualmenteParaGerenteToolStripMenuItem
        '
        Me.EnviarEmailManualmenteParaGerenteToolStripMenuItem.Image = CType(resources.GetObject("EnviarEmailManualmenteParaGerenteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EnviarEmailManualmenteParaGerenteToolStripMenuItem.Name = "EnviarEmailManualmenteParaGerenteToolStripMenuItem"
        Me.EnviarEmailManualmenteParaGerenteToolStripMenuItem.Size = New System.Drawing.Size(410, 22)
        Me.EnviarEmailManualmenteParaGerenteToolStripMenuItem.Text = "Enviar Email Manualmente para Gerente\Diretor"
        '
        'EnviarEmailManualmenteParaGerenteDiretorToolStripMenuItem
        '
        Me.EnviarEmailManualmenteParaGerenteDiretorToolStripMenuItem.Image = CType(resources.GetObject("EnviarEmailManualmenteParaGerenteDiretorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EnviarEmailManualmenteParaGerenteDiretorToolStripMenuItem.Name = "EnviarEmailManualmenteParaGerenteDiretorToolStripMenuItem"
        Me.EnviarEmailManualmenteParaGerenteDiretorToolStripMenuItem.Size = New System.Drawing.Size(410, 22)
        Me.EnviarEmailManualmenteParaGerenteDiretorToolStripMenuItem.Text = "Enviar Email Manualmente para Gerente\Diretor e o responsável"
        '
        'ExcluirAlertaToolStripMenuItem
        '
        Me.ExcluirAlertaToolStripMenuItem.Image = CType(resources.GetObject("ExcluirAlertaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExcluirAlertaToolStripMenuItem.Name = "ExcluirAlertaToolStripMenuItem"
        Me.ExcluirAlertaToolStripMenuItem.Size = New System.Drawing.Size(410, 22)
        Me.ExcluirAlertaToolStripMenuItem.Text = "Excluir Alerta"
        '
        'LimparAlertasToolStripMenuItem
        '
        Me.LimparAlertasToolStripMenuItem.Image = CType(resources.GetObject("LimparAlertasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LimparAlertasToolStripMenuItem.Name = "LimparAlertasToolStripMenuItem"
        Me.LimparAlertasToolStripMenuItem.Size = New System.Drawing.Size(410, 22)
        Me.LimparAlertasToolStripMenuItem.Text = "Limpar Alertas"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SteelBlue
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(20, 60)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(1150, 44)
        Me.Button3.TabIndex = 87
        Me.Button3.Text = "Verificar Alertas"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'AlertasControlvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 643)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AlertasControlvb"
        Me.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow
        Me.Text = "Alertas"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents MetroGrid1 As Wisder.W3Common.WMetroControl.Controls.MetroGrid
    Friend WithEvents MetroContextMenu1 As Wisder.W3Common.WMetroControl.Controls.MetroContextMenu
    Friend WithEvents EnviarEmailManualmenteParaResponsávelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnviarEmailManualmenteParaGerenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnviarEmailManualmenteParaGerenteDiretorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirPlanoDeAçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcluirAlertaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisualizarPlanoDeAçãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents LimparAlertasToolStripMenuItem As ToolStripMenuItem
End Class
