<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim ListViewGroup1 As ListViewGroup = New ListViewGroup("TIER S (Pick or Ban)", HorizontalAlignment.Left)
        Dim ListViewGroup2 As ListViewGroup = New ListViewGroup("TIER A (Priority)", HorizontalAlignment.Left)
        Dim ListViewGroup3 As ListViewGroup = New ListViewGroup("TIER B (Situational)", HorizontalAlignment.Left)
        Dim ListViewGroup4 As ListViewGroup = New ListViewGroup("TIER C (Non Meta)", HorizontalAlignment.Left)
        Dim ListViewGroup5 As ListViewGroup = New ListViewGroup("TIER S (Pick or Ban)", HorizontalAlignment.Left)
        Dim ListViewGroup6 As ListViewGroup = New ListViewGroup("TIER A (Priority)", HorizontalAlignment.Left)
        Dim ListViewGroup7 As ListViewGroup = New ListViewGroup("TIER B (Situational)", HorizontalAlignment.Left)
        Dim ListViewGroup8 As ListViewGroup = New ListViewGroup("TIER C (Non Meta)", HorizontalAlignment.Left)
        Dim ListViewGroup9 As ListViewGroup = New ListViewGroup("TIER S (Pick or Ban)", HorizontalAlignment.Left)
        Dim ListViewGroup10 As ListViewGroup = New ListViewGroup("TIER A (Priority)", HorizontalAlignment.Left)
        Dim ListViewGroup11 As ListViewGroup = New ListViewGroup("TIER B (Situational)", HorizontalAlignment.Left)
        Dim ListViewGroup12 As ListViewGroup = New ListViewGroup("TIER C (Non Meta)", HorizontalAlignment.Left)
        Dim ListViewGroup13 As ListViewGroup = New ListViewGroup("TIER S (Pick or Ban)", HorizontalAlignment.Left)
        Dim ListViewGroup14 As ListViewGroup = New ListViewGroup("TIER A (Priority)", HorizontalAlignment.Left)
        Dim ListViewGroup15 As ListViewGroup = New ListViewGroup("TIER B (Situational)", HorizontalAlignment.Left)
        Dim ListViewGroup16 As ListViewGroup = New ListViewGroup("TIER C (Non Meta)", HorizontalAlignment.Left)
        Dim ListViewGroup17 As ListViewGroup = New ListViewGroup("TIER S (Pick or Ban)", HorizontalAlignment.Left)
        Dim ListViewGroup18 As ListViewGroup = New ListViewGroup("TIER A (Priority)", HorizontalAlignment.Left)
        Dim ListViewGroup19 As ListViewGroup = New ListViewGroup("TIER B (Situational)", HorizontalAlignment.Left)
        Dim ListViewGroup20 As ListViewGroup = New ListViewGroup("TIER C (Non Meta)", HorizontalAlignment.Left)
        ImageList1 = New ImageList(components)
        ListJung = New ListView()
        TabControl1 = New TabControl()
        tbJung = New TabPage()
        TabPage2 = New TabPage()
        ListRoam = New ListView()
        TabPage1 = New TabPage()
        ListExp = New ListView()
        TabPage3 = New TabPage()
        ListGold = New ListView()
        TabPage4 = New TabPage()
        ListMid = New ListView()
        btnBrowse = New Button()
        cbTier = New ComboBox()
        btnTambah = New Button()
        btnHapus = New Button()
        btnUpdate = New Button()
        gambar = New PictureBox()
        txtNama = New TextBox()
        OpenFileDialog1 = New OpenFileDialog()
        gbRole = New GroupBox()
        cbMage = New CheckBox()
        cbSupport = New CheckBox()
        cbTank = New CheckBox()
        cbFighter = New CheckBox()
        cbMarksman = New CheckBox()
        cbAssasin = New CheckBox()
        cbLane = New ComboBox()
        clbCounter = New CheckedListBox()
        gbCounter = New GroupBox()
        txtCariCounter = New TextBox()
        txtCariSinergis = New TextBox()
        clbSinergis = New CheckedListBox()
        GroupBox3 = New GroupBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TabControl1.SuspendLayout()
        tbJung.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        CType(gambar, ComponentModel.ISupportInitialize).BeginInit()
        gbRole.SuspendLayout()
        gbCounter.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(80, 80)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' ListJung
        ' 
        ListJung.BackColor = SystemColors.InactiveCaption
        ListJung.Dock = DockStyle.Top
        ListJung.ForeColor = SystemColors.ButtonHighlight
        ListViewGroup1.Header = "TIER S (Pick or Ban)"
        ListViewGroup1.Name = "grpS"
        ListViewGroup2.Header = "TIER A (Priority)"
        ListViewGroup2.Name = "grpA"
        ListViewGroup3.Header = "TIER B (Situational)"
        ListViewGroup3.Name = "grpB"
        ListViewGroup4.Header = "TIER C (Non Meta)"
        ListViewGroup4.Name = "grpC"
        ListJung.Groups.AddRange(New ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3, ListViewGroup4})
        ListJung.LargeImageList = ImageList1
        ListJung.Location = New Point(3, 3)
        ListJung.MultiSelect = False
        ListJung.Name = "ListJung"
        ListJung.Size = New Size(1389, 332)
        ListJung.TabIndex = 0
        ListJung.UseCompatibleStateImageBehavior = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tbJung)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1403, 368)
        TabControl1.TabIndex = 1
        ' 
        ' tbJung
        ' 
        tbJung.Controls.Add(ListJung)
        tbJung.Location = New Point(4, 29)
        tbJung.Name = "tbJung"
        tbJung.Padding = New Padding(3)
        tbJung.Size = New Size(1395, 335)
        tbJung.TabIndex = 0
        tbJung.Text = "Jungle"
        tbJung.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(ListRoam)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1395, 335)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Roam"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' ListRoam
        ' 
        ListRoam.BackColor = SystemColors.InactiveCaption
        ListRoam.Dock = DockStyle.Top
        ListRoam.ForeColor = Color.Silver
        ListViewGroup5.Header = "TIER S (Pick or Ban)"
        ListViewGroup5.Name = "grpS"
        ListViewGroup6.Header = "TIER A (Priority)"
        ListViewGroup6.Name = "grpA"
        ListViewGroup7.Header = "TIER B (Situational)"
        ListViewGroup7.Name = "grpB"
        ListViewGroup8.Header = "TIER C (Non Meta)"
        ListViewGroup8.Name = "grpC"
        ListRoam.Groups.AddRange(New ListViewGroup() {ListViewGroup5, ListViewGroup6, ListViewGroup7, ListViewGroup8})
        ListRoam.LargeImageList = ImageList1
        ListRoam.Location = New Point(3, 3)
        ListRoam.MultiSelect = False
        ListRoam.Name = "ListRoam"
        ListRoam.Size = New Size(1389, 332)
        ListRoam.TabIndex = 1
        ListRoam.UseCompatibleStateImageBehavior = False
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(ListExp)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1395, 335)
        TabPage1.TabIndex = 2
        TabPage1.Text = "ExpLane"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' ListExp
        ' 
        ListExp.BackColor = SystemColors.InactiveCaption
        ListExp.Dock = DockStyle.Top
        ListViewGroup9.Header = "TIER S (Pick or Ban)"
        ListViewGroup9.Name = "grpS"
        ListViewGroup10.Header = "TIER A (Priority)"
        ListViewGroup10.Name = "grpA"
        ListViewGroup11.Header = "TIER B (Situational)"
        ListViewGroup11.Name = "grpB"
        ListViewGroup12.Header = "TIER C (Non Meta)"
        ListViewGroup12.Name = "grpC"
        ListExp.Groups.AddRange(New ListViewGroup() {ListViewGroup9, ListViewGroup10, ListViewGroup11, ListViewGroup12})
        ListExp.LargeImageList = ImageList1
        ListExp.Location = New Point(3, 3)
        ListExp.MultiSelect = False
        ListExp.Name = "ListExp"
        ListExp.Size = New Size(1389, 332)
        ListExp.TabIndex = 1
        ListExp.UseCompatibleStateImageBehavior = False
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(ListGold)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1395, 335)
        TabPage3.TabIndex = 3
        TabPage3.Text = "GoldLane"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' ListGold
        ' 
        ListGold.BackColor = SystemColors.InactiveCaption
        ListGold.Dock = DockStyle.Top
        ListViewGroup13.Header = "TIER S (Pick or Ban)"
        ListViewGroup13.Name = "grpS"
        ListViewGroup14.Header = "TIER A (Priority)"
        ListViewGroup14.Name = "grpA"
        ListViewGroup15.Header = "TIER B (Situational)"
        ListViewGroup15.Name = "grpB"
        ListViewGroup16.Header = "TIER C (Non Meta)"
        ListViewGroup16.Name = "grpC"
        ListGold.Groups.AddRange(New ListViewGroup() {ListViewGroup13, ListViewGroup14, ListViewGroup15, ListViewGroup16})
        ListGold.LargeImageList = ImageList1
        ListGold.Location = New Point(3, 3)
        ListGold.MultiSelect = False
        ListGold.Name = "ListGold"
        ListGold.Size = New Size(1389, 332)
        ListGold.TabIndex = 2
        ListGold.UseCompatibleStateImageBehavior = False
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(ListMid)
        TabPage4.Location = New Point(4, 29)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(1395, 335)
        TabPage4.TabIndex = 4
        TabPage4.Text = "MidLane"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' ListMid
        ' 
        ListMid.BackColor = SystemColors.InactiveCaption
        ListMid.Dock = DockStyle.Top
        ListViewGroup17.Header = "TIER S (Pick or Ban)"
        ListViewGroup17.Name = "grpS"
        ListViewGroup18.Header = "TIER A (Priority)"
        ListViewGroup18.Name = "grpA"
        ListViewGroup19.Header = "TIER B (Situational)"
        ListViewGroup19.Name = "grpB"
        ListViewGroup20.Header = "TIER C (Non Meta)"
        ListViewGroup20.Name = "grpC"
        ListMid.Groups.AddRange(New ListViewGroup() {ListViewGroup17, ListViewGroup18, ListViewGroup19, ListViewGroup20})
        ListMid.LargeImageList = ImageList1
        ListMid.Location = New Point(3, 3)
        ListMid.MultiSelect = False
        ListMid.Name = "ListMid"
        ListMid.Size = New Size(1389, 332)
        ListMid.TabIndex = 2
        ListMid.UseCompatibleStateImageBehavior = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(125, 631)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 12
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' cbTier
        ' 
        cbTier.FormattingEnabled = True
        cbTier.Items.AddRange(New Object() {"S", "A", "B", "C"})
        cbTier.Location = New Point(656, 521)
        cbTier.Name = "cbTier"
        cbTier.Size = New Size(151, 28)
        cbTier.TabIndex = 11
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(24, 693)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 10
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(279, 693)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(150, 693)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 7
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' gambar
        ' 
        gambar.Location = New Point(114, 479)
        gambar.Name = "gambar"
        gambar.Size = New Size(130, 130)
        gambar.TabIndex = 5
        gambar.TabStop = False
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(431, 443)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama Hero"
        txtNama.Size = New Size(376, 27)
        txtNama.TabIndex = 1
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' gbRole
        ' 
        gbRole.Controls.Add(cbMage)
        gbRole.Controls.Add(cbSupport)
        gbRole.Controls.Add(cbTank)
        gbRole.Controls.Add(cbFighter)
        gbRole.Controls.Add(cbMarksman)
        gbRole.Controls.Add(cbAssasin)
        gbRole.Location = New Point(431, 568)
        gbRole.Name = "gbRole"
        gbRole.Size = New Size(376, 154)
        gbRole.TabIndex = 14
        gbRole.TabStop = False
        gbRole.Text = "Role"
        ' 
        ' cbMage
        ' 
        cbMage.AutoSize = True
        cbMage.Location = New Point(211, 112)
        cbMage.Name = "cbMage"
        cbMage.Size = New Size(69, 24)
        cbMage.TabIndex = 5
        cbMage.Text = "Mage"
        cbMage.UseVisualStyleBackColor = True
        ' 
        ' cbSupport
        ' 
        cbSupport.AutoSize = True
        cbSupport.Location = New Point(211, 68)
        cbSupport.Name = "cbSupport"
        cbSupport.Size = New Size(84, 24)
        cbSupport.TabIndex = 4
        cbSupport.Text = "Support"
        cbSupport.UseVisualStyleBackColor = True
        ' 
        ' cbTank
        ' 
        cbTank.AutoSize = True
        cbTank.Location = New Point(211, 26)
        cbTank.Name = "cbTank"
        cbTank.Size = New Size(60, 24)
        cbTank.TabIndex = 3
        cbTank.Text = "Tank"
        cbTank.UseVisualStyleBackColor = True
        ' 
        ' cbFighter
        ' 
        cbFighter.AutoSize = True
        cbFighter.Location = New Point(53, 109)
        cbFighter.Name = "cbFighter"
        cbFighter.Size = New Size(77, 24)
        cbFighter.TabIndex = 2
        cbFighter.Text = "Fighter"
        cbFighter.UseVisualStyleBackColor = True
        ' 
        ' cbMarksman
        ' 
        cbMarksman.AutoSize = True
        cbMarksman.Location = New Point(53, 68)
        cbMarksman.Name = "cbMarksman"
        cbMarksman.Size = New Size(99, 24)
        cbMarksman.TabIndex = 1
        cbMarksman.Text = "Marksman"
        cbMarksman.UseVisualStyleBackColor = True
        ' 
        ' cbAssasin
        ' 
        cbAssasin.AutoSize = True
        cbAssasin.Location = New Point(53, 26)
        cbAssasin.Name = "cbAssasin"
        cbAssasin.Size = New Size(79, 24)
        cbAssasin.TabIndex = 0
        cbAssasin.Text = "Assasin"
        cbAssasin.UseVisualStyleBackColor = True
        ' 
        ' cbLane
        ' 
        cbLane.FormattingEnabled = True
        cbLane.Items.AddRange(New Object() {"Jungle", "Roam", "ExpLane", "GoldLane", "Midlane"})
        cbLane.Location = New Point(431, 521)
        cbLane.Name = "cbLane"
        cbLane.Size = New Size(151, 28)
        cbLane.TabIndex = 15
        ' 
        ' clbCounter
        ' 
        clbCounter.FormattingEnabled = True
        clbCounter.Items.AddRange(New Object() {"Aamon", "Akai", "Aldous", "Alice", "Alpha", "Alucard", "Angela", "Argus", "Arlott", "Atlas", "Aurora", "Badang", "Balmond", "Bane", "Barats", "Baxia", "Beatrix", "Belerick", "Benedetta", "Brody", "Bruno", "Carmilla", "Cecilion", "Chang'e", "Chip", "Chou", "Cici", "Claude", "Clint", "Cyclops", "Diggie", "Dyroth", "Esmeralda", "Estes", "Eudora", "Faramis", "Fanny", "Franco", "Fredrinn", "Freya", "Gatotkaca", "Gloo", "Gord", "Granger", "Grock", "Guinevere", "Gusion", "Hanabi", "Hanzo", "Harley", "Harith", "Hayabusa", "Helcurt", "Hilda", "Hylos", "Irithel", "Ixia", "Jawhead", "Johnson", "Joy", "Julian", "Kadita", "Kagura", "Kaja", "Karrie", "Karina", "Khaleed", "Khufra", "Kimmy", "Lancelot", "Lapu-Lapu", "Layla", "Leomord", "Lesley", "Ling", "Lolita", "Lunox", "Luo Yi", "Lylia", "Martis", "Masha", "Mathilda", "Melissa", "Minotaur", "Minsitthar", "Miya", "Moskov", "Nana", "Natalia", "Nathan", "Nolan", "Novaria", "Odette", "Paquito", "Pharsa", "Phoveus", "Popol & Kupa", "Rafaela", "Roger", "Ruby", "Saber", "Selena", "Silvanna", "Sun", "Terizla", "Thamuz", "Tigreal", "Uranus", "Vale", "Valentina", "Valir", "Vexana", "Wanwan", "Xavier", "X.Borg", "Yi Sun-shin", "Yin", "Yu Zhong", "Yve", "Zhask", "Zhuxin"})
        clbCounter.Location = New Point(16, 79)
        clbCounter.Name = "clbCounter"
        clbCounter.Size = New Size(218, 224)
        clbCounter.TabIndex = 16
        ' 
        ' gbCounter
        ' 
        gbCounter.Controls.Add(txtCariCounter)
        gbCounter.Controls.Add(clbCounter)
        gbCounter.Location = New Point(856, 410)
        gbCounter.Name = "gbCounter"
        gbCounter.Size = New Size(250, 312)
        gbCounter.TabIndex = 17
        gbCounter.TabStop = False
        gbCounter.Text = "Counter"
        ' 
        ' txtCariCounter
        ' 
        txtCariCounter.Location = New Point(57, 23)
        txtCariCounter.Name = "txtCariCounter"
        txtCariCounter.PlaceholderText = "Cari..."
        txtCariCounter.Size = New Size(125, 27)
        txtCariCounter.TabIndex = 17
        ' 
        ' txtCariSinergis
        ' 
        txtCariSinergis.Location = New Point(57, 23)
        txtCariSinergis.Name = "txtCariSinergis"
        txtCariSinergis.PlaceholderText = "Cari..."
        txtCariSinergis.Size = New Size(125, 27)
        txtCariSinergis.TabIndex = 17
        ' 
        ' clbSinergis
        ' 
        clbSinergis.FormattingEnabled = True
        clbSinergis.Items.AddRange(New Object() {"Aamon", "Akai", "Aldous", "Alice", "Alpha", "Alucard", "Angela", "Argus", "Arlott", "Atlas", "Aurora", "Badang", "Balmond", "Bane", "Barats", "Baxia", "Beatrix", "Belerick", "Benedetta", "Brody", "Bruno", "Carmilla", "Cecilion", "Chang'e", "Chip", "Chou", "Cici", "Claude", "Clint", "Cyclops", "Diggie", "Dyroth", "Esmeralda", "Estes", "Eudora", "Faramis", "Fanny", "Franco", "Fredrinn", "Freya", "Gatotkaca", "Gloo", "Gord", "Granger", "Grock", "Guinevere", "Gusion", "Hanabi", "Hanzo", "Harley", "Harith", "Hayabusa", "Helcurt", "Hilda", "Hylos", "Irithel", "Ixia", "Jawhead", "Johnson", "Joy", "Julian", "Kadita", "Kagura", "Kaja", "Karrie", "Karina", "Khaleed", "Khufra", "Kimmy", "Lancelot", "Lapu-Lapu", "Layla", "Leomord", "Lesley", "Ling", "Lolita", "Lunox", "Luo Yi", "Lylia", "Martis", "Masha", "Mathilda", "Melissa", "Minotaur", "Minsitthar", "Miya", "Moskov", "Nana", "Natalia", "Nathan", "Nolan", "Novaria", "Odette", "Paquito", "Pharsa", "Phoveus", "Popol & Kupa", "Rafaela", "Roger", "Ruby", "Saber", "Selena", "Silvanna", "Sun", "Terizla", "Thamuz", "Tigreal", "Uranus", "Vale", "Valentina", "Valir", "Vexana", "Wanwan", "Xavier", "X.Borg", "Yi Sun-shin", "Yin", "Yu Zhong", "Yve", "Zhask", "Zhuxin"})
        clbSinergis.Location = New Point(16, 79)
        clbSinergis.Name = "clbSinergis"
        clbSinergis.Size = New Size(218, 224)
        clbSinergis.TabIndex = 16
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtCariSinergis)
        GroupBox3.Controls.Add(clbSinergis)
        GroupBox3.Location = New Point(1141, 410)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(250, 312)
        GroupBox3.TabIndex = 18
        GroupBox3.TabStop = False
        GroupBox3.Text = "Sinergis"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(431, 498)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 20)
        Label1.TabIndex = 19
        Label1.Text = "Lane"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(656, 498)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 20)
        Label2.TabIndex = 20
        Label2.Text = "Tier"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(431, 410)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 21
        Label3.Text = "Nama"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(138, 433)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 20)
        Label4.TabIndex = 22
        Label4.Text = "Profil Hero"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1394, 747)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(GroupBox3)
        Controls.Add(gbCounter)
        Controls.Add(cbLane)
        Controls.Add(gbRole)
        Controls.Add(TabControl1)
        Controls.Add(btnBrowse)
        Controls.Add(txtNama)
        Controls.Add(cbTier)
        Controls.Add(btnTambah)
        Controls.Add(btnHapus)
        Controls.Add(gambar)
        Controls.Add(btnUpdate)
        Name = "Form1"
        Text = "Tier List Hero ML"
        TabControl1.ResumeLayout(False)
        tbJung.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        TabPage4.ResumeLayout(False)
        CType(gambar, ComponentModel.ISupportInitialize).EndInit()
        gbRole.ResumeLayout(False)
        gbRole.PerformLayout()
        gbCounter.ResumeLayout(False)
        gbCounter.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ListJung As ListView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbJung As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtNama As TextBox
    Friend WithEvents gambar As PictureBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents cbTier As ComboBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents gbRole As GroupBox
    Friend WithEvents cbSupport As CheckBox
    Friend WithEvents cbTank As CheckBox
    Friend WithEvents cbFighter As CheckBox
    Friend WithEvents cbMarksman As CheckBox
    Friend WithEvents cbAssasin As CheckBox
    Friend WithEvents cbMage As CheckBox
    Friend WithEvents cbLane As ComboBox
    Friend WithEvents clbCounter As CheckedListBox
    Friend WithEvents gbCounter As GroupBox
    Friend WithEvents txtCariCounter As TextBox
    Friend WithEvents txtCariSinergis As TextBox
    Friend WithEvents clbSinergis As CheckedListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ListRoam As ListView
    Friend WithEvents ListExp As ListView
    Friend WithEvents ListGold As ListView
    Friend WithEvents ListMid As ListView
    Friend WithEvents Label4 As Label

End Class
