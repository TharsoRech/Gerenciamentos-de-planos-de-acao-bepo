<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NovoPlano
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NovoPlano))
        Me.Origem = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumeroPlano = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Inicio = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.removeracao = New System.Windows.Forms.Button()
        Me.addacao = New System.Windows.Forms.Button()
        Me.MetroGrid1 = New Wisder.W3Common.WMetroControl.Controls.MetroGrid()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditarAcao = New System.Windows.Forms.Button()
        Me.abrirevidencia = New System.Windows.Forms.Button()
        Me.Cliente = New Wisder.W3Common.WMetroControl.Controls.MetroComboBox()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Origem
        '
        Me.Origem.Lines = New String(-1) {}
        Me.Origem.Location = New System.Drawing.Point(209, 128)
        Me.Origem.MaxLength = 32767
        Me.Origem.Name = "Origem"
        Me.Origem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Origem.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Origem.SelectedText = ""
        Me.Origem.Size = New System.Drawing.Size(628, 23)
        Me.Origem.TabIndex = 26
        Me.Origem.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 22)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Origem N.C:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 22)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 22)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Nome plano de ação:"
        '
        'NumeroPlano
        '
        Me.NumeroPlano.Lines = New String(-1) {}
        Me.NumeroPlano.Location = New System.Drawing.Point(209, 177)
        Me.NumeroPlano.MaxLength = 32767
        Me.NumeroPlano.Name = "NumeroPlano"
        Me.NumeroPlano.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NumeroPlano.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.NumeroPlano.SelectedText = ""
        Me.NumeroPlano.Size = New System.Drawing.Size(628, 23)
        Me.NumeroPlano.TabIndex = 27
        Me.NumeroPlano.UseSelectable = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 471)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 22)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Inicio:"
        '
        'Inicio
        '
        Me.Inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Inicio.Location = New System.Drawing.Point(87, 471)
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Size = New System.Drawing.Size(750, 20)
        Me.Inicio.TabIndex = 40
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(226, 514)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 27)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(388, 514)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 27)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Criar Novo Plano"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 22)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Ações Corretiva:"
        '
        'removeracao
        '
        Me.removeracao.BackColor = System.Drawing.Color.DodgerBlue
        Me.removeracao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.removeracao.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeracao.Location = New System.Drawing.Point(691, 427)
        Me.removeracao.Name = "removeracao"
        Me.removeracao.Size = New System.Drawing.Size(157, 38)
        Me.removeracao.TabIndex = 72
        Me.removeracao.Text = "Remover ação "
        Me.removeracao.UseVisualStyleBackColor = False
        '
        'addacao
        '
        Me.addacao.BackColor = System.Drawing.Color.DodgerBlue
        Me.addacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addacao.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addacao.Location = New System.Drawing.Point(691, 247)
        Me.addacao.Name = "addacao"
        Me.addacao.Size = New System.Drawing.Size(155, 34)
        Me.addacao.TabIndex = 71
        Me.addacao.Text = "Adicionar Ação"
        Me.addacao.UseVisualStyleBackColor = False
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
        Me.MetroGrid1.Location = New System.Drawing.Point(6, 247)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(679, 218)
        Me.MetroGrid1.TabIndex = 70
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Não conformidade/ação corretiva"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 183
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
        'EditarAcao
        '
        Me.EditarAcao.BackColor = System.Drawing.Color.DodgerBlue
        Me.EditarAcao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EditarAcao.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarAcao.Location = New System.Drawing.Point(689, 307)
        Me.EditarAcao.Name = "EditarAcao"
        Me.EditarAcao.Size = New System.Drawing.Size(157, 35)
        Me.EditarAcao.TabIndex = 73
        Me.EditarAcao.Text = "Editar ação selecionada"
        Me.EditarAcao.UseVisualStyleBackColor = False
        '
        'abrirevidencia
        '
        Me.abrirevidencia.BackColor = System.Drawing.Color.DodgerBlue
        Me.abrirevidencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.abrirevidencia.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abrirevidencia.Location = New System.Drawing.Point(691, 369)
        Me.abrirevidencia.Name = "abrirevidencia"
        Me.abrirevidencia.Size = New System.Drawing.Size(157, 35)
        Me.abrirevidencia.TabIndex = 74
        Me.abrirevidencia.Text = "Abrir Evidência "
        Me.abrirevidencia.UseVisualStyleBackColor = False
        '
        'Cliente
        '
        Me.Cliente.FormattingEnabled = True
        Me.Cliente.ItemHeight = 23
        Me.Cliente.Location = New System.Drawing.Point(209, 83)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(628, 29)
        Me.Cliente.TabIndex = 75
        Me.Cliente.UseSelectable = True
        '
        'NovoPlano
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 564)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.abrirevidencia)
        Me.Controls.Add(Me.EditarAcao)
        Me.Controls.Add(Me.removeracao)
        Me.Controls.Add(Me.addacao)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Inicio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumeroPlano)
        Me.Controls.Add(Me.Origem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NovoPlano"
        Me.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow
        Me.Text = "Novo Plano"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Origem As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumeroPlano As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Inicio As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents removeracao As Button
    Public WithEvents addacao As Button
    Public WithEvents MetroGrid1 As Wisder.W3Common.WMetroControl.Controls.MetroGrid
    Public WithEvents EditarAcao As Button
    Public WithEvents abrirevidencia As Button
    Friend WithEvents Cliente As Wisder.W3Common.WMetroControl.Controls.MetroComboBox
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
