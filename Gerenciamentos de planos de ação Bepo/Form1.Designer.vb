<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint9 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(25.0R, 100.0R)
        Dim DataPoint10 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(25.0R, 100.0R)
        Dim DataPoint11 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(25.0R, 100.0R)
        Dim DataPoint12 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(20.0R, 100.0R)
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.RibbonOrbMenuItem1 = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonOrbMenuItem2 = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonOrbMenuItem3 = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonOrbMenuItem4 = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonTab1 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.NewActionButton = New System.Windows.Forms.RibbonButton()
        Me.AddCliente = New System.Windows.Forms.RibbonPanel()
        Me.addcbutton = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel2 = New System.Windows.Forms.RibbonPanel()
        Me.CheckActionButton = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel3 = New System.Windows.Forms.RibbonPanel()
        Me.AgendaButton = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel6 = New System.Windows.Forms.RibbonPanel()
        Me.ListaExcluidos = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab2 = New System.Windows.Forms.RibbonTab()
        Me.NovoCadastro = New System.Windows.Forms.RibbonPanel()
        Me.NewRegButton = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel4 = New System.Windows.Forms.RibbonPanel()
        Me.UserConfigurantionButton = New System.Windows.Forms.RibbonButton()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.MetroTabControl1 = New Wisder.W3Common.WMetroControl.Controls.MetroTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.RibbonPanel5 = New System.Windows.Forms.RibbonPanel()
        Me.MetroTabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ribbon1
        '
        Me.Ribbon1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Ribbon1.Location = New System.Drawing.Point(20, 60)
        Me.Ribbon1.Minimized = False
        Me.Ribbon1.Name = "Ribbon1"
        '
        '
        '
        Me.Ribbon1.OrbDropDown.BorderRoundness = 8
        Me.Ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonOrbMenuItem1)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonOrbMenuItem2)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonOrbMenuItem3)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonOrbMenuItem4)
        Me.Ribbon1.OrbDropDown.Name = ""
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(527, 248)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.OrbDropDown.Text = "Opções"
        Me.Ribbon1.OrbImage = Nothing
        Me.Ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013
        Me.Ribbon1.OrbText = "Arquivo"
        '
        '
        '
        Me.Ribbon1.QuickAcessToolbar.Enabled = False
        Me.Ribbon1.QuickAcessToolbar.Visible = False
        Me.Ribbon1.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Ribbon1.Size = New System.Drawing.Size(1071, 115)
        Me.Ribbon1.TabIndex = 0
        Me.Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab2)
        Me.Ribbon1.TabsMargin = New System.Windows.Forms.Padding(12, 26, 20, 0)
        Me.Ribbon1.Text = "Ribbon1"
        Me.Ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue
        '
        'RibbonOrbMenuItem1
        '
        Me.RibbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.RibbonOrbMenuItem1.Image = CType(resources.GetObject("RibbonOrbMenuItem1.Image"), System.Drawing.Image)
        Me.RibbonOrbMenuItem1.SmallImage = CType(resources.GetObject("RibbonOrbMenuItem1.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItem1.Text = "Novo Plano"
        '
        'RibbonOrbMenuItem2
        '
        Me.RibbonOrbMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.RibbonOrbMenuItem2.Image = CType(resources.GetObject("RibbonOrbMenuItem2.Image"), System.Drawing.Image)
        Me.RibbonOrbMenuItem2.SmallImage = CType(resources.GetObject("RibbonOrbMenuItem2.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItem2.Text = "Configurações da conta"
        '
        'RibbonOrbMenuItem3
        '
        Me.RibbonOrbMenuItem3.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.RibbonOrbMenuItem3.Image = CType(resources.GetObject("RibbonOrbMenuItem3.Image"), System.Drawing.Image)
        Me.RibbonOrbMenuItem3.SmallImage = CType(resources.GetObject("RibbonOrbMenuItem3.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItem3.Text = "Configurações"
        '
        'RibbonOrbMenuItem4
        '
        Me.RibbonOrbMenuItem4.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.RibbonOrbMenuItem4.Image = CType(resources.GetObject("RibbonOrbMenuItem4.Image"), System.Drawing.Image)
        Me.RibbonOrbMenuItem4.SmallImage = CType(resources.GetObject("RibbonOrbMenuItem4.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItem4.Text = "Sair"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel1)
        Me.RibbonTab1.Panels.Add(Me.AddCliente)
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel2)
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel3)
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel6)
        Me.RibbonTab1.Text = "Ações"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.Items.Add(Me.NewActionButton)
        Me.RibbonPanel1.Text = "Novo Plano de Ação"
        '
        'NewActionButton
        '
        Me.NewActionButton.Image = CType(resources.GetObject("NewActionButton.Image"), System.Drawing.Image)
        Me.NewActionButton.SmallImage = CType(resources.GetObject("NewActionButton.SmallImage"), System.Drawing.Image)
        '
        'AddCliente
        '
        Me.AddCliente.Items.Add(Me.addcbutton)
        Me.AddCliente.Text = "Clientes"
        '
        'addcbutton
        '
        Me.addcbutton.Image = CType(resources.GetObject("addcbutton.Image"), System.Drawing.Image)
        Me.addcbutton.SmallImage = CType(resources.GetObject("addcbutton.SmallImage"), System.Drawing.Image)
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.Items.Add(Me.CheckActionButton)
        Me.RibbonPanel2.Text = "Alertas"
        '
        'CheckActionButton
        '
        Me.CheckActionButton.Image = CType(resources.GetObject("CheckActionButton.Image"), System.Drawing.Image)
        Me.CheckActionButton.SmallImage = CType(resources.GetObject("CheckActionButton.SmallImage"), System.Drawing.Image)
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.Items.Add(Me.AgendaButton)
        Me.RibbonPanel3.Text = "Histórico de Planos"
        '
        'AgendaButton
        '
        Me.AgendaButton.Image = CType(resources.GetObject("AgendaButton.Image"), System.Drawing.Image)
        Me.AgendaButton.SmallImage = CType(resources.GetObject("AgendaButton.SmallImage"), System.Drawing.Image)
        '
        'RibbonPanel6
        '
        Me.RibbonPanel6.Items.Add(Me.ListaExcluidos)
        Me.RibbonPanel6.Text = "Lista de excluidos"
        '
        'ListaExcluidos
        '
        Me.ListaExcluidos.Image = CType(resources.GetObject("ListaExcluidos.Image"), System.Drawing.Image)
        Me.ListaExcluidos.SmallImage = CType(resources.GetObject("ListaExcluidos.SmallImage"), System.Drawing.Image)
        '
        'RibbonTab2
        '
        Me.RibbonTab2.Panels.Add(Me.NovoCadastro)
        Me.RibbonTab2.Panels.Add(Me.RibbonPanel4)
        Me.RibbonTab2.Text = "Opções"
        '
        'NovoCadastro
        '
        Me.NovoCadastro.Items.Add(Me.NewRegButton)
        Me.NovoCadastro.Text = "Novo Cadastro"
        '
        'NewRegButton
        '
        Me.NewRegButton.Image = CType(resources.GetObject("NewRegButton.Image"), System.Drawing.Image)
        Me.NewRegButton.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large
        Me.NewRegButton.SmallImage = CType(resources.GetObject("NewRegButton.SmallImage"), System.Drawing.Image)
        '
        'RibbonPanel4
        '
        Me.RibbonPanel4.Items.Add(Me.UserConfigurantionButton)
        Me.RibbonPanel4.Text = "Configurações da Conta"
        '
        'UserConfigurantionButton
        '
        Me.UserConfigurantionButton.Image = CType(resources.GetObject("UserConfigurantionButton.Image"), System.Drawing.Image)
        Me.UserConfigurantionButton.SmallImage = CType(resources.GetObject("UserConfigurantionButton.SmallImage"), System.Drawing.Image)
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeView1.Font = New System.Drawing.Font("Caladea", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(20, 175)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(298, 629)
        Me.TreeView1.TabIndex = 1
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.TabPage1)
        Me.MetroTabControl1.Controls.Add(Me.TabPage2)
        Me.MetroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTabControl1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroTabControl1.Location = New System.Drawing.Point(318, 175)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.Padding = New System.Drawing.Point(6, 8)
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(773, 629)
        Me.MetroTabControl1.TabIndex = 2
        Me.MetroTabControl1.UseSelectable = True
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(765, 587)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista de planos"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Chart1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(765, 587)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Gráfico"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        Me.Chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkVertical
        Me.Chart1.BorderSkin.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Chart1.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter
        Me.Chart1.BorderSkin.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DashedUpwardDiagonal
        Me.Chart1.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        Me.Chart1.BorderSkin.BorderWidth = 3
        Me.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Sunken
        ChartArea3.BackColor = System.Drawing.Color.Transparent
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Top
        Legend3.Name = "Legend1"
        Legend3.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(3, 3)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series3.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series3.Legend = "Legend1"
        Series3.Name = "Series3"
        DataPoint9.Color = System.Drawing.Color.Green
        DataPoint9.LegendText = "Concluido"
        DataPoint10.Color = System.Drawing.SystemColors.Highlight
        DataPoint10.LegendText = "Previsto"
        DataPoint11.Color = System.Drawing.Color.Yellow
        DataPoint11.LegendText = "Em execução"
        DataPoint12.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataPoint12.LegendText = "Atrasado"
        Series3.Points.Add(DataPoint9)
        Series3.Points.Add(DataPoint10)
        Series3.Points.Add(DataPoint11)
        Series3.Points.Add(DataPoint12)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(759, 491)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        Title3.Alignment = System.Drawing.ContentAlignment.BottomLeft
        Title3.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.Name = "Title1"
        Title3.Text = "Planos de ações(Todos)"
        Me.Chart1.Titles.Add(Title3)
        '
        'RibbonPanel5
        '
        Me.RibbonPanel5.Text = "RibbonPanel5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 824)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.Ribbon1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow
        Me.Style = Wisder.W3Common.WMetroControl.MetroColorStyle.Black
        Me.Text = "Plano de Ações Bepo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MetroTabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonOrbMenuItem1 As RibbonOrbMenuItem
    Friend WithEvents RibbonOrbMenuItem2 As RibbonOrbMenuItem
    Friend WithEvents RibbonTab1 As RibbonTab
    Friend WithEvents RibbonTab2 As RibbonTab
    Friend WithEvents RibbonPanel1 As RibbonPanel
    Friend WithEvents RibbonPanel2 As RibbonPanel
    Friend WithEvents RibbonPanel4 As RibbonPanel
    Public WithEvents Ribbon1 As Ribbon
    Public WithEvents NovoCadastro As RibbonPanel
    Public WithEvents NewRegButton As RibbonButton
    Friend WithEvents UserConfigurantionButton As RibbonButton
    Friend WithEvents NewActionButton As RibbonButton
    Friend WithEvents CheckActionButton As RibbonButton
    Friend WithEvents RibbonPanel3 As RibbonPanel
    Friend WithEvents AgendaButton As RibbonButton
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents MetroTabControl1 As Wisder.W3Common.WMetroControl.Controls.MetroTabControl
    Friend WithEvents TabPage1 As TabPage
    Public WithEvents RibbonOrbMenuItem4 As RibbonOrbMenuItem
    Public WithEvents RibbonOrbMenuItem3 As RibbonOrbMenuItem
    Friend WithEvents RibbonPanel5 As RibbonPanel
    Friend WithEvents RibbonPanel6 As RibbonPanel
    Friend WithEvents ListaExcluidos As RibbonButton
    Friend WithEvents AddCliente As RibbonPanel
    Friend WithEvents addcbutton As RibbonButton
    Friend WithEvents TabPage2 As TabPage
    Public WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
