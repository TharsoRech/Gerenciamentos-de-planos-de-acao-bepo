<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewRegistry
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SenhaText = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EmailGerenteText = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Useradmin = New Wisder.W3Common.WMetroControl.Controls.MetroCheckBox()
        Me.Usertext = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.EmailText = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuário:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Senha:"
        '
        'SenhaText
        '
        Me.SenhaText.Lines = New String(-1) {}
        Me.SenhaText.Location = New System.Drawing.Point(92, 209)
        Me.SenhaText.MaxLength = 32767
        Me.SenhaText.Name = "SenhaText"
        Me.SenhaText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.SenhaText.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SenhaText.SelectedText = ""
        Me.SenhaText.Size = New System.Drawing.Size(526, 23)
        Me.SenhaText.TabIndex = 10
        Me.SenhaText.UseSelectable = True
        Me.SenhaText.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(260, 22)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Email Gerente/Diretor responasável:"
        '
        'EmailGerenteText
        '
        Me.EmailGerenteText.Lines = New String(-1) {}
        Me.EmailGerenteText.Location = New System.Drawing.Point(329, 166)
        Me.EmailGerenteText.MaxLength = 32767
        Me.EmailGerenteText.Name = "EmailGerenteText"
        Me.EmailGerenteText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmailGerenteText.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.EmailGerenteText.SelectedText = ""
        Me.EmailGerenteText.Size = New System.Drawing.Size(289, 23)
        Me.EmailGerenteText.TabIndex = 14
        Me.EmailGerenteText.UseSelectable = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(329, 270)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 30)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(477, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 30)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 22)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Email:"
        '
        'Useradmin
        '
        Me.Useradmin.AutoSize = True
        Me.Useradmin.Location = New System.Drawing.Point(14, 246)
        Me.Useradmin.Name = "Useradmin"
        Me.Useradmin.Size = New System.Drawing.Size(419, 15)
        Me.Useradmin.TabIndex = 21
        Me.Useradmin.Text = "Usuário administrador(Altera documentos de todos usuários,controle total)"
        Me.Useradmin.UseSelectable = True
        Me.Useradmin.UseVisualStyleBackColor = True
        '
        'Usertext
        '
        Me.Usertext.Lines = New String(-1) {}
        Me.Usertext.Location = New System.Drawing.Point(130, 81)
        Me.Usertext.MaxLength = 32767
        Me.Usertext.Name = "Usertext"
        Me.Usertext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Usertext.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Usertext.SelectedText = ""
        Me.Usertext.Size = New System.Drawing.Size(488, 23)
        Me.Usertext.TabIndex = 6
        Me.Usertext.UseSelectable = True
        '
        'EmailText
        '
        Me.EmailText.Lines = New String(-1) {}
        Me.EmailText.Location = New System.Drawing.Point(130, 122)
        Me.EmailText.MaxLength = 32767
        Me.EmailText.Name = "EmailText"
        Me.EmailText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmailText.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.EmailText.SelectedText = ""
        Me.EmailText.Size = New System.Drawing.Size(488, 23)
        Me.EmailText.TabIndex = 22
        Me.EmailText.UseSelectable = True
        '
        'NewRegistry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 307)
        Me.Controls.Add(Me.EmailText)
        Me.Controls.Add(Me.Useradmin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.EmailGerenteText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SenhaText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Usertext)
        Me.Name = "NewRegistry"
        Me.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow
        Me.Text = "Novo Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SenhaText As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents EmailGerenteText As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Useradmin As Wisder.W3Common.WMetroControl.Controls.MetroCheckBox
    Friend WithEvents Usertext As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents EmailText As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
End Class
