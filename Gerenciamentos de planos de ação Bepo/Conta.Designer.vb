<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Conta))
        Me.EmailText = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EmailGerenteText = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SenhaText = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Usertext = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Useradmin = New Wisder.W3Common.WMetroControl.Controls.MetroCheckBox()
        Me.SuspendLayout()
        '
        'EmailText
        '
        Me.EmailText.Lines = New String(-1) {}
        Me.EmailText.Location = New System.Drawing.Point(113, 113)
        Me.EmailText.MaxLength = 32767
        Me.EmailText.Name = "EmailText"
        Me.EmailText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmailText.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.EmailText.SelectedText = ""
        Me.EmailText.Size = New System.Drawing.Size(459, 23)
        Me.EmailText.TabIndex = 31
        Me.EmailText.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 22)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(215, 22)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Email Coordenador /Gerente :"
        '
        'EmailGerenteText
        '
        Me.EmailGerenteText.Lines = New String(-1) {}
        Me.EmailGerenteText.Location = New System.Drawing.Point(281, 158)
        Me.EmailGerenteText.MaxLength = 32767
        Me.EmailGerenteText.Name = "EmailGerenteText"
        Me.EmailGerenteText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmailGerenteText.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.EmailGerenteText.SelectedText = ""
        Me.EmailGerenteText.Size = New System.Drawing.Size(292, 23)
        Me.EmailGerenteText.TabIndex = 27
        Me.EmailGerenteText.UseSelectable = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 22)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Senha:"
        '
        'SenhaText
        '
        Me.SenhaText.Lines = New String(-1) {}
        Me.SenhaText.Location = New System.Drawing.Point(113, 201)
        Me.SenhaText.MaxLength = 32767
        Me.SenhaText.Name = "SenhaText"
        Me.SenhaText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.SenhaText.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SenhaText.SelectedText = ""
        Me.SenhaText.Size = New System.Drawing.Size(459, 23)
        Me.SenhaText.TabIndex = 25
        Me.SenhaText.UseSelectable = True
        Me.SenhaText.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 22)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Usuário:"
        '
        'Usertext
        '
        Me.Usertext.Lines = New String(-1) {}
        Me.Usertext.Location = New System.Drawing.Point(113, 73)
        Me.Usertext.MaxLength = 32767
        Me.Usertext.Name = "Usertext"
        Me.Usertext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Usertext.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Usertext.SelectedText = ""
        Me.Usertext.Size = New System.Drawing.Size(460, 23)
        Me.Usertext.TabIndex = 23
        Me.Usertext.UseSelectable = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(298, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 34)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Salvar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(162, 275)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 34)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Fechar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Useradmin
        '
        Me.Useradmin.AutoSize = True
        Me.Useradmin.Enabled = False
        Me.Useradmin.Location = New System.Drawing.Point(10, 244)
        Me.Useradmin.Name = "Useradmin"
        Me.Useradmin.Size = New System.Drawing.Size(419, 15)
        Me.Useradmin.TabIndex = 30
        Me.Useradmin.Text = "Usuário administrador(Altera documentos de todos usuários,controle total)"
        Me.Useradmin.UseSelectable = True
        Me.Useradmin.UseVisualStyleBackColor = True
        '
        'Conta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 321)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.EmailText)
        Me.Controls.Add(Me.Useradmin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.EmailGerenteText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SenhaText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Usertext)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Conta"
        Me.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow
        Me.Text = "Conta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Public WithEvents EmailText As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Public WithEvents EmailGerenteText As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Public WithEvents SenhaText As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Public WithEvents Usertext As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Public WithEvents Useradmin As Wisder.W3Common.WMetroControl.Controls.MetroCheckBox
End Class
