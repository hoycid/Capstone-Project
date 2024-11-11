<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exit_Gate_Loginvb
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

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
        Me.KryptonButton_Login = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonTextBox_Password = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.KryptonTextBox_Username = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox1.Panel.SuspendLayout()
        Me.KryptonGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonButton_Login
        '
        Me.KryptonButton_Login.Location = New System.Drawing.Point(609, 309)
        Me.KryptonButton_Login.Name = "KryptonButton_Login"
        Me.KryptonButton_Login.Size = New System.Drawing.Size(175, 53)
        Me.KryptonButton_Login.StateCommon.Back.Color1 = System.Drawing.SystemColors.AppWorkspace
        Me.KryptonButton_Login.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonButton_Login.StateDisabled.Back.Color1 = System.Drawing.SystemColors.ActiveBorder
        Me.KryptonButton_Login.StateNormal.Back.Color1 = System.Drawing.SystemColors.ActiveBorder
        Me.KryptonButton_Login.StateNormal.Border.Color1 = System.Drawing.SystemColors.ActiveBorder
        Me.KryptonButton_Login.StateNormal.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonButton_Login.StatePressed.Border.Color1 = System.Drawing.SystemColors.ActiveBorder
        Me.KryptonButton_Login.StatePressed.Border.Color2 = System.Drawing.SystemColors.GradientActiveCaption
        Me.KryptonButton_Login.StatePressed.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonButton_Login.TabIndex = 4
        Me.KryptonButton_Login.Values.Text = "Login"
        '
        'KryptonTextBox_Password
        '
        Me.KryptonTextBox_Password.Location = New System.Drawing.Point(421, 215)
        Me.KryptonTextBox_Password.Name = "KryptonTextBox_Password"
        Me.KryptonTextBox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.KryptonTextBox_Password.Size = New System.Drawing.Size(363, 35)
        Me.KryptonTextBox_Password.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonTextBox_Password.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.KryptonGroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(62, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1800, 957)
        Me.Panel1.TabIndex = 2
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(372, 178)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonButton_Login)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonTextBox_Password)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonTextBox_Username)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(1094, 551)
        Me.KryptonGroupBox1.TabIndex = 0
        '
        'KryptonTextBox_Username
        '
        Me.KryptonTextBox_Username.Location = New System.Drawing.Point(421, 117)
        Me.KryptonTextBox_Username.Name = "KryptonTextBox_Username"
        Me.KryptonTextBox_Username.Size = New System.Drawing.Size(363, 35)
        Me.KryptonTextBox_Username.StateCommon.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonTextBox_Username.TabIndex = 2
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(224, 215)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(145, 36)
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 1
        Me.KryptonLabel2.Values.Text = "Password:"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(218, 117)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(151, 36)
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Username:"
        '
        'Exit_Gate_Loginvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Exit_Gate_Loginvb"
        Me.Text = "Exit_Gate_Loginvb"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.Panel.ResumeLayout(False)
        Me.KryptonGroupBox1.Panel.PerformLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonButton_Login As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonTextBox_Password As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents KryptonTextBox_Username As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
