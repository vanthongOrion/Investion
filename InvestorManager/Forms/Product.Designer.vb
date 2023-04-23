<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Product
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProdIdBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ProdId = New System.Windows.Forms.Label()
        Me.ProdNameBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ProdName = New System.Windows.Forms.Label()
        Me.QuantityBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Quantity = New System.Windows.Forms.Label()
        Me.PriceBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Price = New System.Windows.Forms.Label()
        Me.DescBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Desc = New System.Windows.Forms.Label()
        Me.Category = New System.Windows.Forms.Label()
        Me.CategoryBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CompMatchBtn = New System.Windows.Forms.RadioButton()
        Me.LastMatchBtn = New System.Windows.Forms.RadioButton()
        Me.FrontMatchBtn = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SearchBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton25 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.RecordBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(568, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(688, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "My Investory Program"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label2.Location = New System.Drawing.Point(568, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(688, 55)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Manage Product"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProdIdBox
        '
        Me.ProdIdBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProdIdBox.DefaultText = ""
        Me.ProdIdBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ProdIdBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ProdIdBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProdIdBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProdIdBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProdIdBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ProdIdBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProdIdBox.Location = New System.Drawing.Point(279, 201)
        Me.ProdIdBox.Name = "ProdIdBox"
        Me.ProdIdBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProdIdBox.PlaceholderText = ""
        Me.ProdIdBox.SelectedText = ""
        Me.ProdIdBox.Size = New System.Drawing.Size(219, 36)
        Me.ProdIdBox.TabIndex = 7
        '
        'ProdId
        '
        Me.ProdId.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ProdId.ForeColor = System.Drawing.Color.LimeGreen
        Me.ProdId.Location = New System.Drawing.Point(130, 185)
        Me.ProdId.Name = "ProdId"
        Me.ProdId.Size = New System.Drawing.Size(132, 52)
        Me.ProdId.TabIndex = 6
        Me.ProdId.Text = "ProdID"
        Me.ProdId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProdNameBox
        '
        Me.ProdNameBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ProdNameBox.DefaultText = ""
        Me.ProdNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ProdNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ProdNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProdNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ProdNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProdNameBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ProdNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProdNameBox.Location = New System.Drawing.Point(690, 201)
        Me.ProdNameBox.Name = "ProdNameBox"
        Me.ProdNameBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ProdNameBox.PlaceholderText = ""
        Me.ProdNameBox.SelectedText = ""
        Me.ProdNameBox.Size = New System.Drawing.Size(219, 36)
        Me.ProdNameBox.TabIndex = 9
        '
        'ProdName
        '
        Me.ProdName.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ProdName.ForeColor = System.Drawing.Color.LimeGreen
        Me.ProdName.Location = New System.Drawing.Point(538, 185)
        Me.ProdName.Name = "ProdName"
        Me.ProdName.Size = New System.Drawing.Size(132, 52)
        Me.ProdName.TabIndex = 8
        Me.ProdName.Text = "ProdName"
        Me.ProdName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QuantityBox
        '
        Me.QuantityBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.QuantityBox.DefaultText = ""
        Me.QuantityBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.QuantityBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.QuantityBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QuantityBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.QuantityBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuantityBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.QuantityBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuantityBox.Location = New System.Drawing.Point(1128, 201)
        Me.QuantityBox.Name = "QuantityBox"
        Me.QuantityBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.QuantityBox.PlaceholderText = ""
        Me.QuantityBox.SelectedText = ""
        Me.QuantityBox.Size = New System.Drawing.Size(219, 36)
        Me.QuantityBox.TabIndex = 11
        '
        'Quantity
        '
        Me.Quantity.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Quantity.ForeColor = System.Drawing.Color.LimeGreen
        Me.Quantity.Location = New System.Drawing.Point(976, 185)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(132, 52)
        Me.Quantity.TabIndex = 10
        Me.Quantity.Text = "Quantity"
        Me.Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PriceBox
        '
        Me.PriceBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PriceBox.DefaultText = ""
        Me.PriceBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PriceBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PriceBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PriceBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PriceBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PriceBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PriceBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PriceBox.Location = New System.Drawing.Point(1573, 201)
        Me.PriceBox.Name = "PriceBox"
        Me.PriceBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PriceBox.PlaceholderText = ""
        Me.PriceBox.SelectedText = ""
        Me.PriceBox.Size = New System.Drawing.Size(219, 36)
        Me.PriceBox.TabIndex = 13
        '
        'Price
        '
        Me.Price.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Price.ForeColor = System.Drawing.Color.LimeGreen
        Me.Price.Location = New System.Drawing.Point(1421, 185)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(132, 52)
        Me.Price.TabIndex = 12
        Me.Price.Text = "Price"
        Me.Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DescBox
        '
        Me.DescBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DescBox.DefaultText = ""
        Me.DescBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DescBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DescBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DescBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DescBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DescBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DescBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DescBox.Location = New System.Drawing.Point(687, 305)
        Me.DescBox.Name = "DescBox"
        Me.DescBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DescBox.PlaceholderText = ""
        Me.DescBox.SelectedText = ""
        Me.DescBox.Size = New System.Drawing.Size(219, 36)
        Me.DescBox.TabIndex = 15
        '
        'Desc
        '
        Me.Desc.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Desc.ForeColor = System.Drawing.Color.LimeGreen
        Me.Desc.Location = New System.Drawing.Point(538, 289)
        Me.Desc.Name = "Desc"
        Me.Desc.Size = New System.Drawing.Size(132, 52)
        Me.Desc.TabIndex = 14
        Me.Desc.Text = "Description"
        Me.Desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Category
        '
        Me.Category.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Category.ForeColor = System.Drawing.Color.LimeGreen
        Me.Category.Location = New System.Drawing.Point(976, 289)
        Me.Category.Name = "Category"
        Me.Category.Size = New System.Drawing.Size(132, 52)
        Me.Category.TabIndex = 16
        Me.Category.Text = "Category"
        Me.Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CategoryBox
        '
        Me.CategoryBox.BackColor = System.Drawing.Color.Transparent
        Me.CategoryBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CategoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CategoryBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CategoryBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CategoryBox.ItemHeight = 30
        Me.CategoryBox.Location = New System.Drawing.Point(1128, 305)
        Me.CategoryBox.Name = "CategoryBox"
        Me.CategoryBox.Size = New System.Drawing.Size(219, 36)
        Me.CategoryBox.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 928)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1952, 20)
        Me.Panel2.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.LimeGreen
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(793, 463)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(315, 35)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Product List"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CompMatchBtn)
        Me.Panel1.Controls.Add(Me.LastMatchBtn)
        Me.Panel1.Controls.Add(Me.FrontMatchBtn)
        Me.Panel1.Location = New System.Drawing.Point(187, 463)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 44)
        Me.Panel1.TabIndex = 28
        '
        'CompMatchBtn
        '
        Me.CompMatchBtn.AutoSize = True
        Me.CompMatchBtn.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CompMatchBtn.ForeColor = System.Drawing.Color.LimeGreen
        Me.CompMatchBtn.Location = New System.Drawing.Point(356, 12)
        Me.CompMatchBtn.Name = "CompMatchBtn"
        Me.CompMatchBtn.Size = New System.Drawing.Size(113, 19)
        Me.CompMatchBtn.TabIndex = 2
        Me.CompMatchBtn.Text = "Complete Match"
        Me.CompMatchBtn.UseVisualStyleBackColor = True
        '
        'LastMatchBtn
        '
        Me.LastMatchBtn.AutoSize = True
        Me.LastMatchBtn.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LastMatchBtn.ForeColor = System.Drawing.Color.LimeGreen
        Me.LastMatchBtn.Location = New System.Drawing.Point(202, 12)
        Me.LastMatchBtn.Name = "LastMatchBtn"
        Me.LastMatchBtn.Size = New System.Drawing.Size(83, 19)
        Me.LastMatchBtn.TabIndex = 1
        Me.LastMatchBtn.Text = "Last Match"
        Me.LastMatchBtn.UseVisualStyleBackColor = True
        '
        'FrontMatchBtn
        '
        Me.FrontMatchBtn.AutoSize = True
        Me.FrontMatchBtn.Checked = True
        Me.FrontMatchBtn.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FrontMatchBtn.ForeColor = System.Drawing.Color.LimeGreen
        Me.FrontMatchBtn.Location = New System.Drawing.Point(33, 12)
        Me.FrontMatchBtn.Name = "FrontMatchBtn"
        Me.FrontMatchBtn.Size = New System.Drawing.Size(89, 19)
        Me.FrontMatchBtn.TabIndex = 0
        Me.FrontMatchBtn.TabStop = True
        Me.FrontMatchBtn.Text = "Front Match"
        Me.FrontMatchBtn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(175, 543)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1636, 309)
        Me.Panel3.TabIndex = 29
        '
        'SearchBtn
        '
        Me.SearchBtn.AccessibleName = ""
        Me.SearchBtn.ActiveBorderThickness = 1
        Me.SearchBtn.ActiveCornerRadius = 20
        Me.SearchBtn.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.SearchBtn.ActiveForecolor = System.Drawing.Color.White
        Me.SearchBtn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.SearchBtn.BackColor = System.Drawing.SystemColors.Control
        Me.SearchBtn.BackgroundImage = CType(resources.GetObject("SearchBtn.BackgroundImage"), System.Drawing.Image)
        Me.SearchBtn.ButtonText = "Search"
        Me.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SearchBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.SearchBtn.IdleBorderThickness = 1
        Me.SearchBtn.IdleCornerRadius = 20
        Me.SearchBtn.IdleFillColor = System.Drawing.Color.LimeGreen
        Me.SearchBtn.IdleForecolor = System.Drawing.Color.White
        Me.SearchBtn.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.SearchBtn.Location = New System.Drawing.Point(346, 399)
        Me.SearchBtn.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(188, 42)
        Me.SearchBtn.TabIndex = 27
        Me.SearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton25
        '
        Me.BunifuThinButton25.AccessibleName = ""
        Me.BunifuThinButton25.ActiveBorderThickness = 1
        Me.BunifuThinButton25.ActiveCornerRadius = 20
        Me.BunifuThinButton25.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton25.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton25.BackgroundImage = CType(resources.GetObject("BunifuThinButton25.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton25.ButtonText = "Home"
        Me.BunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton25.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BunifuThinButton25.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.IdleBorderThickness = 1
        Me.BunifuThinButton25.IdleCornerRadius = 20
        Me.BunifuThinButton25.IdleFillColor = System.Drawing.Color.LimeGreen
        Me.BunifuThinButton25.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton25.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton25.Location = New System.Drawing.Point(860, 861)
        Me.BunifuThinButton25.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton25.Name = "BunifuThinButton25"
        Me.BunifuThinButton25.Size = New System.Drawing.Size(188, 42)
        Me.BunifuThinButton25.TabIndex = 23
        Me.BunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton24
        '
        Me.BunifuThinButton24.AccessibleName = ""
        Me.BunifuThinButton24.ActiveBorderThickness = 1
        Me.BunifuThinButton24.ActiveCornerRadius = 20
        Me.BunifuThinButton24.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton24.BackgroundImage = CType(resources.GetObject("BunifuThinButton24.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton24.ButtonText = "Clear"
        Me.BunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton24.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.IdleBorderThickness = 1
        Me.BunifuThinButton24.IdleCornerRadius = 20
        Me.BunifuThinButton24.IdleFillColor = System.Drawing.Color.LimeGreen
        Me.BunifuThinButton24.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton24.Location = New System.Drawing.Point(1372, 399)
        Me.BunifuThinButton24.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton24.Name = "BunifuThinButton24"
        Me.BunifuThinButton24.Size = New System.Drawing.Size(188, 42)
        Me.BunifuThinButton24.TabIndex = 22
        Me.BunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.AccessibleName = ""
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "Delete"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.LimeGreen
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.Location = New System.Drawing.Point(1120, 399)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(188, 42)
        Me.BunifuThinButton23.TabIndex = 21
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.AccessibleName = ""
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Edit"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.LimeGreen
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Location = New System.Drawing.Point(857, 399)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(188, 42)
        Me.BunifuThinButton22.TabIndex = 20
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RecordBtn
        '
        Me.RecordBtn.AccessibleName = ""
        Me.RecordBtn.ActiveBorderThickness = 1
        Me.RecordBtn.ActiveCornerRadius = 20
        Me.RecordBtn.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.RecordBtn.ActiveForecolor = System.Drawing.Color.White
        Me.RecordBtn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.RecordBtn.BackColor = System.Drawing.SystemColors.Control
        Me.RecordBtn.BackgroundImage = CType(resources.GetObject("RecordBtn.BackgroundImage"), System.Drawing.Image)
        Me.RecordBtn.ButtonText = "Add"
        Me.RecordBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RecordBtn.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RecordBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.RecordBtn.IdleBorderThickness = 1
        Me.RecordBtn.IdleCornerRadius = 20
        Me.RecordBtn.IdleFillColor = System.Drawing.Color.LimeGreen
        Me.RecordBtn.IdleForecolor = System.Drawing.Color.White
        Me.RecordBtn.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.RecordBtn.Location = New System.Drawing.Point(595, 399)
        Me.RecordBtn.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.RecordBtn.Name = "RecordBtn"
        Me.RecordBtn.Size = New System.Drawing.Size(188, 42)
        Me.RecordBtn.TabIndex = 19
        Me.RecordBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1952, 948)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BunifuThinButton25)
        Me.Controls.Add(Me.BunifuThinButton24)
        Me.Controls.Add(Me.BunifuThinButton23)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.RecordBtn)
        Me.Controls.Add(Me.CategoryBox)
        Me.Controls.Add(Me.Category)
        Me.Controls.Add(Me.DescBox)
        Me.Controls.Add(Me.Desc)
        Me.Controls.Add(Me.PriceBox)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.QuantityBox)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.ProdNameBox)
        Me.Controls.Add(Me.ProdName)
        Me.Controls.Add(Me.ProdIdBox)
        Me.Controls.Add(Me.ProdId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Product"
        Me.Text = "Product"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProdIdBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ProdId As Label
    Friend WithEvents ProdNameBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ProdName As Label
    Friend WithEvents QuantityBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Quantity As Label
    Friend WithEvents PriceBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Price As Label
    Friend WithEvents DescBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Desc As Label
    Friend WithEvents Category As Label
    Friend WithEvents CategoryBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents RecordBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton25 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents SearchBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CompMatchBtn As RadioButton
    Friend WithEvents LastMatchBtn As RadioButton
    Friend WithEvents FrontMatchBtn As RadioButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FpSpread1_Sheet1 As FarPoint.Win.Spread.SheetView
End Class
