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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.logIn = New System.Windows.Forms.Button()
        Me.signOut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.telTextBox = New System.Windows.Forms.TextBox()
        Me.addTextBox = New System.Windows.Forms.TextBox()
        Me.aptTextBox = New System.Windows.Forms.TextBox()
        Me.zipTextBox = New System.Windows.Forms.TextBox()
        Me.cityTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cntryTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cnTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.monthTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.yearTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cvvTextBox = New System.Windows.Forms.TextBox()
        Me.sizeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.typeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.searchNameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.colorTextBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.checkoutStall = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(706, 67)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(1205, 815)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'logIn
        '
        Me.logIn.Location = New System.Drawing.Point(758, 533)
        Me.logIn.Name = "logIn"
        Me.logIn.Size = New System.Drawing.Size(202, 23)
        Me.logIn.TabIndex = 1
        Me.logIn.Text = "Set Size / Commit"
        Me.logIn.UseVisualStyleBackColor = True
        Me.logIn.Visible = False
        '
        'signOut
        '
        Me.signOut.Location = New System.Drawing.Point(758, 577)
        Me.signOut.Name = "signOut"
        Me.signOut.Size = New System.Drawing.Size(202, 23)
        Me.signOut.TabIndex = 2
        Me.signOut.Text = "Checkout / Enter info"
        Me.signOut.UseVisualStyleBackColor = True
        Me.signOut.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(36, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Full Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(70, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(36, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Telephone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(51, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(19, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "apt, unit, etc"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(89, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Zip"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(83, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "City"
        '
        'nameTextBox
        '
        Me.nameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTextBox.ForeColor = System.Drawing.Color.Black
        Me.nameTextBox.Location = New System.Drawing.Point(133, 19)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(125, 24)
        Me.nameTextBox.TabIndex = 11
        Me.nameTextBox.Text = "Owen Delisle"
        '
        'emailTextBox
        '
        Me.emailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailTextBox.Location = New System.Drawing.Point(133, 232)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(125, 24)
        Me.emailTextBox.TabIndex = 12
        Me.emailTextBox.Text = "Owen37164@gmail.com"
        '
        'telTextBox
        '
        Me.telTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telTextBox.Location = New System.Drawing.Point(135, 193)
        Me.telTextBox.Name = "telTextBox"
        Me.telTextBox.Size = New System.Drawing.Size(125, 24)
        Me.telTextBox.TabIndex = 13
        Me.telTextBox.Text = "2506404012"
        '
        'addTextBox
        '
        Me.addTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTextBox.Location = New System.Drawing.Point(133, 53)
        Me.addTextBox.Name = "addTextBox"
        Me.addTextBox.Size = New System.Drawing.Size(125, 24)
        Me.addTextBox.TabIndex = 14
        Me.addTextBox.Text = "9092 Hilltop rd"
        '
        'aptTextBox
        '
        Me.aptTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aptTextBox.Location = New System.Drawing.Point(133, 269)
        Me.aptTextBox.Name = "aptTextBox"
        Me.aptTextBox.Size = New System.Drawing.Size(125, 24)
        Me.aptTextBox.TabIndex = 15
        '
        'zipTextBox
        '
        Me.zipTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zipTextBox.Location = New System.Drawing.Point(133, 83)
        Me.zipTextBox.Name = "zipTextBox"
        Me.zipTextBox.Size = New System.Drawing.Size(125, 24)
        Me.zipTextBox.TabIndex = 16
        Me.zipTextBox.Text = "v2n6j8"
        '
        'cityTextBox
        '
        Me.cityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityTextBox.Location = New System.Drawing.Point(133, 120)
        Me.cityTextBox.Name = "cityTextBox"
        Me.cityTextBox.Size = New System.Drawing.Size(125, 24)
        Me.cityTextBox.TabIndex = 17
        Me.cityTextBox.Text = "Prince George"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(6, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 18)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Country(CAPS)"
        '
        'cntryTextBox
        '
        Me.cntryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cntryTextBox.Location = New System.Drawing.Point(135, 156)
        Me.cntryTextBox.Name = "cntryTextBox"
        Me.cntryTextBox.Size = New System.Drawing.Size(125, 24)
        Me.cntryTextBox.TabIndex = 19
        Me.cntryTextBox.Text = "CANADA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(475, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 18)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Number"
        '
        'cnTextBox
        '
        Me.cnTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnTextBox.Location = New System.Drawing.Point(555, 13)
        Me.cnTextBox.Name = "cnTextBox"
        Me.cnTextBox.Size = New System.Drawing.Size(125, 24)
        Me.cnTextBox.TabIndex = 21
        Me.cnTextBox.Text = "123456789"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(487, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 18)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Month"
        '
        'monthTextBox
        '
        Me.monthTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthTextBox.Location = New System.Drawing.Point(555, 47)
        Me.monthTextBox.Name = "monthTextBox"
        Me.monthTextBox.Size = New System.Drawing.Size(125, 24)
        Me.monthTextBox.TabIndex = 23
        Me.monthTextBox.Text = "04"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(500, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 18)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Year"
        '
        'yearTextBox
        '
        Me.yearTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearTextBox.Location = New System.Drawing.Point(555, 81)
        Me.yearTextBox.Name = "yearTextBox"
        Me.yearTextBox.Size = New System.Drawing.Size(125, 24)
        Me.yearTextBox.TabIndex = 25
        Me.yearTextBox.Text = "2020"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(502, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 18)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "CVV"
        '
        'cvvTextBox
        '
        Me.cvvTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cvvTextBox.Location = New System.Drawing.Point(555, 114)
        Me.cvvTextBox.Name = "cvvTextBox"
        Me.cvvTextBox.Size = New System.Drawing.Size(125, 24)
        Me.cvvTextBox.TabIndex = 27
        Me.cvvTextBox.Text = "420"
        '
        'sizeComboBox
        '
        Me.sizeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sizeComboBox.ForeColor = System.Drawing.SystemColors.InfoText
        Me.sizeComboBox.FormattingEnabled = True
        Me.sizeComboBox.Items.AddRange(New Object() {"Small", "Medium", "Large", "X-Large"})
        Me.sizeComboBox.Location = New System.Drawing.Point(326, 50)
        Me.sizeComboBox.Name = "sizeComboBox"
        Me.sizeComboBox.Size = New System.Drawing.Size(121, 26)
        Me.sizeComboBox.TabIndex = 29
        Me.sizeComboBox.Text = "Small"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(282, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 18)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Size"
        '
        'typeComboBox
        '
        Me.typeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeComboBox.FormattingEnabled = True
        Me.typeComboBox.Items.AddRange(New Object() {"All", "Jackets", "Shirts", "Shoes", "T-Shirts", "Tops_sweaters", "Sweatshirts", "Pants", "Shorts", "Hats", "Bags", "Accessories", "Skate"})
        Me.typeComboBox.Location = New System.Drawing.Point(326, 19)
        Me.typeComboBox.Name = "typeComboBox"
        Me.typeComboBox.Size = New System.Drawing.Size(121, 26)
        Me.typeComboBox.TabIndex = 31
        Me.typeComboBox.Text = "Pants"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(279, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 18)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Type"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(279, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 18)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Item"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(454, 350)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(155, 51)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Run"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'searchNameTextBox
        '
        Me.searchNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchNameTextBox.Location = New System.Drawing.Point(809, 330)
        Me.searchNameTextBox.Multiline = True
        Me.searchNameTextBox.Name = "searchNameTextBox"
        Me.searchNameTextBox.Size = New System.Drawing.Size(159, 71)
        Me.searchNameTextBox.TabIndex = 38
        Me.searchNameTextBox.Text = "Supreme®/Hanes® Realtree® Boxer Briefs (2 Pack)"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.colorTextBox)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.sizeComboBox)
        Me.GroupBox1.Controls.Add(Me.searchNameTextBox)
        Me.GroupBox1.Controls.Add(Me.nameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.typeComboBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cvvTextBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.emailTextBox)
        Me.GroupBox1.Controls.Add(Me.yearTextBox)
        Me.GroupBox1.Controls.Add(Me.telTextBox)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.addTextBox)
        Me.GroupBox1.Controls.Add(Me.monthTextBox)
        Me.GroupBox1.Controls.Add(Me.aptTextBox)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.zipTextBox)
        Me.GroupBox1.Controls.Add(Me.cnTextBox)
        Me.GroupBox1.Controls.Add(Me.cityTextBox)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cntryTextBox)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(12, 212)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 432)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(505, 255)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 44
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(313, 350)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 51)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(133, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 51)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Wait"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'colorTextBox
        '
        Me.colorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colorTextBox.Location = New System.Drawing.Point(326, 86)
        Me.colorTextBox.Name = "colorTextBox"
        Me.colorTextBox.Size = New System.Drawing.Size(121, 24)
        Me.colorTextBox.TabIndex = 41
        Me.colorTextBox.Text = "Black"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(269, 87)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 18)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Color"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(322, 123)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 130)
        Me.TextBox1.TabIndex = 39
        Me.TextBox1.Text = "Sacred Hearts Work Pant"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(116, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(466, 87)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'checkoutStall
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.QuickBuy.My.Resources.Resources.supremebuttox
        Me.PictureBox2.Location = New System.Drawing.Point(75, 650)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(603, 315)
        Me.PictureBox2.TabIndex = 43
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1800, 815)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.signOut)
        Me.Controls.Add(Me.logIn)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents logIn As Button
    Friend WithEvents signOut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents telTextBox As TextBox
    Friend WithEvents addTextBox As TextBox
    Friend WithEvents aptTextBox As TextBox
    Friend WithEvents zipTextBox As TextBox
    Friend WithEvents cityTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cntryTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cnTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents monthTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents yearTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cvvTextBox As TextBox
    Friend WithEvents sizeComboBox As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents typeComboBox As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents searchNameTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents colorTextBox As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents checkoutStall As Timer
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
