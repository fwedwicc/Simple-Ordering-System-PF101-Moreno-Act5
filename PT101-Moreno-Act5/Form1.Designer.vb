<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ProgressBar = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BackgroundImage = CType(resources.GetObject("Guna2Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel5)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel1.Location = New System.Drawing.Point(96, 88)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(978, 617)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackgroundImage = CType(resources.GetObject("Guna2Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel2.Location = New System.Drawing.Point(41, 32)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(37, 37)
        Me.Guna2Panel2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(105, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Burger and Fries"
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel5.BackgroundImage = CType(resources.GetObject("Guna2Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel5.Controls.Add(Me.ProgressBar)
        Me.Guna2Panel5.Controls.Add(Me.Button2)
        Me.Guna2Panel5.Controls.Add(Me.Button1)
        Me.Guna2Panel5.Controls.Add(Me.Guna2Panel7)
        Me.Guna2Panel5.Controls.Add(Me.Label4)
        Me.Guna2Panel5.Controls.Add(Me.Guna2Panel6)
        Me.Guna2Panel5.Controls.Add(Me.TextBox2)
        Me.Guna2Panel5.Controls.Add(Me.Label3)
        Me.Guna2Panel5.Controls.Add(Me.TextBox1)
        Me.Guna2Panel5.Controls.Add(Me.Label2)
        Me.Guna2Panel5.Location = New System.Drawing.Point(482, 1)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(496, 617)
        Me.Guna2Panel5.TabIndex = 1
        '
        'ProgressBar
        '
        Me.ProgressBar.BorderRadius = 7
        Me.ProgressBar.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ProgressBar.Location = New System.Drawing.Point(45, 549)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.ProgressBar.Size = New System.Drawing.Size(412, 28)
        Me.ProgressBar.TabIndex = 14
        Me.ProgressBar.Text = "Guna2ProgressBar1"
        Me.ProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Button2
        '
        Me.Button2.BorderRadius = 8
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(282, 445)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 44)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Clear"
        '
        'Button1
        '
        Me.Button1.BorderRadius = 8
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(112, 445)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 44)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Submit"
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BackgroundImage = CType(resources.GetObject("Guna2Panel7.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel7.Location = New System.Drawing.Point(143, 304)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Size = New System.Drawing.Size(20, 20)
        Me.Guna2Panel7.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(170, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Password:"
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackgroundImage = CType(resources.GetObject("Guna2Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel6.Location = New System.Drawing.Point(143, 215)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(20, 20)
        Me.Guna2Panel6.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.BorderRadius = 5
        Me.TextBox2.BorderThickness = 0
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox2.DefaultText = ""
        Me.TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(141, 332)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox2.PlaceholderText = ""
        Me.TextBox2.SelectedText = ""
        Me.TextBox2.Size = New System.Drawing.Size(215, 34)
        Me.TextBox2.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(170, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Username:"
        '
        'TextBox1
        '
        Me.TextBox1.BorderRadius = 5
        Me.TextBox1.BorderThickness = 0
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.DefaultText = ""
        Me.TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(141, 243)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.PlaceholderText = ""
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.Size = New System.Drawing.Size(215, 34)
        Me.TextBox1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(215, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Login"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.BackgroundImage = CType(resources.GetObject("Guna2Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel4.Location = New System.Drawing.Point(-48, 77)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(616, 606)
        Me.Guna2Panel4.TabIndex = 2
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BackgroundImage = CType(resources.GetObject("Guna2Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel3.Location = New System.Drawing.Point(50, 166)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(611, 605)
        Me.Guna2Panel3.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 120
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1166, 798)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar As Guna.UI2.WinForms.Guna2ProgressBar
End Class
