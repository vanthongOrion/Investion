<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.User = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.userBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PasswordBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ClearBtn = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LoginBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 103)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(45, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MyInvestoryProgram"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'User
        '
        Me.User.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.User.ForeColor = System.Drawing.Color.LimeGreen
        Me.User.Location = New System.Drawing.Point(22, 193)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(132, 52)
        Me.User.TabIndex = 2
        Me.User.Text = "UId"
        Me.User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Password.ForeColor = System.Drawing.Color.LimeGreen
        Me.Password.Location = New System.Drawing.Point(22, 279)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(132, 52)
        Me.Password.TabIndex = 3
        Me.Password.Text = "Password"
        Me.Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'userBox
        '
        Me.userBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.userBox.DefaultText = ""
        Me.userBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.userBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.userBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.userBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.userBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.userBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.userBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.userBox.Location = New System.Drawing.Point(215, 209)
        Me.userBox.Name = "userBox"
        Me.userBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.userBox.PlaceholderText = ""
        Me.userBox.SelectedText = ""
        Me.userBox.Size = New System.Drawing.Size(200, 36)
        Me.userBox.TabIndex = 4
        '
        'PasswordBox
        '
        Me.PasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordBox.DefaultText = ""
        Me.PasswordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PasswordBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordBox.Location = New System.Drawing.Point(215, 295)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordBox.PlaceholderText = ""
        Me.PasswordBox.SelectedText = ""
        Me.PasswordBox.Size = New System.Drawing.Size(200, 36)
        Me.PasswordBox.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 463)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(436, 20)
        Me.Panel2.TabIndex = 7
        '
        'ClearBtn
        '
        Me.ClearBtn.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ClearBtn.ForeColor = System.Drawing.Color.LimeGreen
        Me.ClearBtn.Location = New System.Drawing.Point(150, 410)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(132, 41)
        Me.ClearBtn.TabIndex = 8
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2PictureBox1.Image = Global.InvestorManager.My.Resources.Resources.icons8_home_100
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(164, 109)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(105, 80)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 9
        Me.Guna2PictureBox1.TabStop = False
        '
        'LoginBtn
        '
        Me.LoginBtn.AccessibleName = ""
        Me.LoginBtn.ActiveBorderThickness = 1
        Me.LoginBtn.ActiveCornerRadius = 20
        Me.LoginBtn.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.LoginBtn.ActiveForecolor = System.Drawing.Color.White
        Me.LoginBtn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.LoginBtn.BackColor = System.Drawing.Color.White
        Me.LoginBtn.BackgroundImage = CType(resources.GetObject("LoginBtn.BackgroundImage"), System.Drawing.Image)
        Me.LoginBtn.ButtonText = "Login"
        Me.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoginBtn.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.LoginBtn.IdleBorderThickness = 1
        Me.LoginBtn.IdleCornerRadius = 20
        Me.LoginBtn.IdleFillColor = System.Drawing.Color.LimeGreen
        Me.LoginBtn.IdleForecolor = System.Drawing.Color.White
        Me.LoginBtn.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.LoginBtn.Location = New System.Drawing.Point(94, 356)
        Me.LoginBtn.Margin = New System.Windows.Forms.Padding(9)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(251, 54)
        Me.LoginBtn.TabIndex = 6
        Me.LoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(436, 483)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.userBox)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents User As Label
    Friend WithEvents Password As Label
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents userBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PasswordBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LoginBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ClearBtn As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
