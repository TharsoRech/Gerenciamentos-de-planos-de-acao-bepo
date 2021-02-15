<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Usertext = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.SenhaText = New Wisder.W3Common.WMetroControl.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(430, 362)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Entrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(223, 362)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 33)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Sair"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Usertext
        '
        Me.Usertext.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usertext.FontSize = Wisder.W3Common.WMetroControl.MetroTextBoxSize.Tall
        Me.Usertext.Lines = New String(-1) {}
        Me.Usertext.Location = New System.Drawing.Point(201, 226)
        Me.Usertext.MaxLength = 32767
        Me.Usertext.Name = "Usertext"
        Me.Usertext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Usertext.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Usertext.SelectedText = ""
        Me.Usertext.Size = New System.Drawing.Size(375, 35)
        Me.Usertext.TabIndex = 2
        Me.Usertext.UseSelectable = True
        '
        'SenhaText
        '
        Me.SenhaText.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SenhaText.FontSize = Wisder.W3Common.WMetroControl.MetroTextBoxSize.Tall
        Me.SenhaText.Lines = New String(-1) {}
        Me.SenhaText.Location = New System.Drawing.Point(201, 277)
        Me.SenhaText.MaxLength = 32767
        Me.SenhaText.Name = "SenhaText"
        Me.SenhaText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.SenhaText.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SenhaText.SelectedText = ""
        Me.SenhaText.Size = New System.Drawing.Size(375, 37)
        Me.SenhaText.TabIndex = 3
        Me.SenhaText.UseSelectable = True
        Me.SenhaText.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuário:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Senha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(195, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(398, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Bem vindo ao Plano de ações Bepo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gentium Basic", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(753, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Faça login abaixo com seu usuário e sua senha,caso não tenha ou tenha esquecido c" &
    "ontate ao administrador"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SteelBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Century", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(578, 388)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(194, 32)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Contatar Administrador"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(23, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 86)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 434)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SenhaText)
        Me.Controls.Add(Me.Usertext)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.DisplayHeader = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.ShadowType = Wisder.W3Common.WMetroControl.Forms.MetroFormShadowType.SystemShadow
        Me.Style = Wisder.W3Common.WMetroControl.MetroColorStyle.Black
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Usertext As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents SenhaText As Wisder.W3Common.WMetroControl.Controls.MetroTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
