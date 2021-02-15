<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MetroContextMenu1 = New Wisder.W3Common.WMetroControl.Controls.MetroContextMenu(Me.components)
        Me.RemoverClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MetroContextMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(23, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 36)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Adicionar Cliente"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoverClienteToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(162, 26)
        '
        'RemoverClienteToolStripMenuItem
        '
        Me.RemoverClienteToolStripMenuItem.Image = CType(resources.GetObject("RemoverClienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemoverClienteToolStripMenuItem.Name = "RemoverClienteToolStripMenuItem"
        Me.RemoverClienteToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.RemoverClienteToolStripMenuItem.Text = "Remover Cliente"
        '
        'TreeView1
        '
        Me.TreeView1.ContextMenuStrip = Me.MetroContextMenu1
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(23, 118)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(421, 307)
        Me.TreeView1.TabIndex = 35
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(180, 76)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(264, 36)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Requisitar adição ou remoção de cliente"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 457)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Clientes"
        Me.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow
        Me.Text = "Clientes"
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents MetroContextMenu1 As Wisder.W3Common.WMetroControl.Controls.MetroContextMenu
    Friend WithEvents RemoverClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Button2 As Button
End Class
