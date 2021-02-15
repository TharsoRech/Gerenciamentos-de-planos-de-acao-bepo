<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelecionarRelatorio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelecionarRelatorio))
        Me.addacao = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Previstas = New Wisder.W3Common.WMetroControl.Controls.MetroCheckBox()
        Me.Emexecucao = New Wisder.W3Common.WMetroControl.Controls.MetroCheckBox()
        Me.Atrasadas = New Wisder.W3Common.WMetroControl.Controls.MetroCheckBox()
        Me.Concluidas = New Wisder.W3Common.WMetroControl.Controls.MetroCheckBox()
        Me.Todas = New Wisder.W3Common.WMetroControl.Controls.MetroCheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'addacao
        '
        Me.addacao.BackColor = System.Drawing.Color.DodgerBlue
        Me.addacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addacao.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addacao.Location = New System.Drawing.Point(144, 311)
        Me.addacao.Name = "addacao"
        Me.addacao.Size = New System.Drawing.Size(131, 22)
        Me.addacao.TabIndex = 69
        Me.addacao.Text = "Gerar Relatório"
        Me.addacao.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(23, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 22)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Previstas
        '
        Me.Previstas.AutoSize = True
        Me.Previstas.FontSize = Wisder.W3Common.WMetroControl.MetroCheckBoxSize.Medium
        Me.Previstas.Location = New System.Drawing.Point(30, 73)
        Me.Previstas.Name = "Previstas"
        Me.Previstas.Size = New System.Drawing.Size(280, 19)
        Me.Previstas.TabIndex = 71
        Me.Previstas.Text = "Gerar apenas ações dadas como Previstas"
        Me.Previstas.UseSelectable = True
        Me.Previstas.UseVisualStyleBackColor = True
        '
        'Emexecucao
        '
        Me.Emexecucao.AutoSize = True
        Me.Emexecucao.FontSize = Wisder.W3Common.WMetroControl.MetroCheckBoxSize.Medium
        Me.Emexecucao.Location = New System.Drawing.Point(30, 116)
        Me.Emexecucao.Name = "Emexecucao"
        Me.Emexecucao.Size = New System.Drawing.Size(304, 19)
        Me.Emexecucao.TabIndex = 72
        Me.Emexecucao.Text = "Gerar apenas ações dadas como em execução"
        Me.Emexecucao.UseSelectable = True
        Me.Emexecucao.UseVisualStyleBackColor = True
        '
        'Atrasadas
        '
        Me.Atrasadas.AutoSize = True
        Me.Atrasadas.FontSize = Wisder.W3Common.WMetroControl.MetroCheckBoxSize.Medium
        Me.Atrasadas.Location = New System.Drawing.Point(30, 163)
        Me.Atrasadas.Name = "Atrasadas"
        Me.Atrasadas.Size = New System.Drawing.Size(286, 19)
        Me.Atrasadas.TabIndex = 73
        Me.Atrasadas.Text = "Gerar apenas ações dadas como Atrasadas"
        Me.Atrasadas.UseSelectable = True
        Me.Atrasadas.UseVisualStyleBackColor = True
        '
        'Concluidas
        '
        Me.Concluidas.AutoSize = True
        Me.Concluidas.FontSize = Wisder.W3Common.WMetroControl.MetroCheckBoxSize.Medium
        Me.Concluidas.Location = New System.Drawing.Point(30, 210)
        Me.Concluidas.Name = "Concluidas"
        Me.Concluidas.Size = New System.Drawing.Size(289, 19)
        Me.Concluidas.TabIndex = 74
        Me.Concluidas.Text = "Gerar apenas ações dadas como concluidas"
        Me.Concluidas.UseSelectable = True
        Me.Concluidas.UseVisualStyleBackColor = True
        '
        'Todas
        '
        Me.Todas.AutoSize = True
        Me.Todas.FontSize = Wisder.W3Common.WMetroControl.MetroCheckBoxSize.Medium
        Me.Todas.Location = New System.Drawing.Point(30, 251)
        Me.Todas.Name = "Todas"
        Me.Todas.Size = New System.Drawing.Size(163, 19)
        Me.Todas.TabIndex = 75
        Me.Todas.Text = "Gerar de Todas  ações "
        Me.Todas.UseSelectable = True
        Me.Todas.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(438, 312)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 21)
        Me.Button2.TabIndex = 78
        Me.Button2.Text = "Exportar Para Gráfico"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(281, 311)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(151, 22)
        Me.Button3.TabIndex = 79
        Me.Button3.Text = "Gerar para excel"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'SelecionarRelatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 348)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Todas)
        Me.Controls.Add(Me.Concluidas)
        Me.Controls.Add(Me.Atrasadas)
        Me.Controls.Add(Me.Emexecucao)
        Me.Controls.Add(Me.Previstas)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.addacao)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SelecionarRelatorio"
        Me.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow
        Me.Text = "Gerar Relatório :"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents addacao As Button
    Public WithEvents Button1 As Button
    Friend WithEvents Previstas As Wisder.W3Common.WMetroControl.Controls.MetroCheckBox
    Friend WithEvents Emexecucao As Wisder.W3Common.WMetroControl.Controls.MetroCheckBox
    Friend WithEvents Atrasadas As Wisder.W3Common.WMetroControl.Controls.MetroCheckBox
    Friend WithEvents Concluidas As Wisder.W3Common.WMetroControl.Controls.MetroCheckBox
    Friend WithEvents Todas As Wisder.W3Common.WMetroControl.Controls.MetroCheckBox
    Public WithEvents Button2 As Button
    Public WithEvents Button3 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
