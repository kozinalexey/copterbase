<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ComboSelectPort = New System.Windows.Forms.ComboBox()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BCA = New System.Windows.Forms.TextBox()
        Me.FCA = New System.Windows.Forms.TextBox()
        Me.LCA = New System.Windows.Forms.TextBox()
        Me.RCA = New System.Windows.Forms.TextBox()
        Me.LLBA = New System.Windows.Forms.TextBox()
        Me.LLFA = New System.Windows.Forms.TextBox()
        Me.LRBA = New System.Windows.Forms.TextBox()
        Me.LRFA = New System.Windows.Forms.TextBox()
        Me.DBA = New System.Windows.Forms.TextBox()
        Me.DFA = New System.Windows.Forms.TextBox()
        Me.BaseStateTxt = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonOpen = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonCenter = New System.Windows.Forms.Button()
        Me.ButtonUncenter = New System.Windows.Forms.Button()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.Term = New System.Windows.Forms.TextBox()
        Me.Temp = New System.Windows.Forms.TextBox()
        Me.HUM = New System.Windows.Forms.TextBox()
        Me.FCC = New CopterBase.PictureboxT()
        Me.BCC = New CopterBase.PictureboxT()
        Me.LCC = New CopterBase.PictureboxT()
        Me.RCC = New CopterBase.PictureboxT()
        Me.LLBD = New CopterBase.PictureboxT()
        Me.LLFD = New CopterBase.PictureboxT()
        Me.LRBD = New CopterBase.PictureboxT()
        Me.LRFD = New CopterBase.PictureboxT()
        Me.DBC = New CopterBase.PictureboxT()
        Me.DFC = New CopterBase.PictureboxT()
        Me.FCO = New CopterBase.PictureboxT()
        Me.BCO = New CopterBase.PictureboxT()
        Me.LCO = New CopterBase.PictureboxT()
        Me.RCO = New CopterBase.PictureboxT()
        Me.LLBU = New CopterBase.PictureboxT()
        Me.LLFU = New CopterBase.PictureboxT()
        Me.LRBU = New CopterBase.PictureboxT()
        Me.LRFU = New CopterBase.PictureboxT()
        Me.DBO = New CopterBase.PictureboxT()
        Me.DFO = New CopterBase.PictureboxT()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.FCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LLBD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LLFD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LRBD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LRFD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DFC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FCO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BCO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RCO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LLBU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LLFU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LRBU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LRFU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DFO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'ComboSelectPort
        '
        Me.ComboSelectPort.FormattingEnabled = True
        Me.ComboSelectPort.Location = New System.Drawing.Point(243, 22)
        Me.ComboSelectPort.Name = "ComboSelectPort"
        Me.ComboSelectPort.Size = New System.Drawing.Size(121, 21)
        Me.ComboSelectPort.TabIndex = 0
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(244, 50)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(121, 23)
        Me.ButtonConnect.TabIndex = 1
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.CopterBase.My.Resources.Resources.L3
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 379)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 142)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.HUM)
        Me.Panel1.Controls.Add(Me.Temp)
        Me.Panel1.Controls.Add(Me.BCA)
        Me.Panel1.Controls.Add(Me.FCA)
        Me.Panel1.Controls.Add(Me.LCA)
        Me.Panel1.Controls.Add(Me.RCA)
        Me.Panel1.Controls.Add(Me.LLBA)
        Me.Panel1.Controls.Add(Me.LLFA)
        Me.Panel1.Controls.Add(Me.LRBA)
        Me.Panel1.Controls.Add(Me.LRFA)
        Me.Panel1.Controls.Add(Me.DBA)
        Me.Panel1.Controls.Add(Me.DFA)
        Me.Panel1.Controls.Add(Me.BaseStateTxt)
        Me.Panel1.Controls.Add(Me.TextBox10)
        Me.Panel1.Controls.Add(Me.TextBox11)
        Me.Panel1.Controls.Add(Me.TextBox12)
        Me.Panel1.Controls.Add(Me.TextBox13)
        Me.Panel1.Controls.Add(Me.TextBox8)
        Me.Panel1.Controls.Add(Me.TextBox9)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.TextBox7)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.FCC)
        Me.Panel1.Controls.Add(Me.BCC)
        Me.Panel1.Controls.Add(Me.LCC)
        Me.Panel1.Controls.Add(Me.RCC)
        Me.Panel1.Controls.Add(Me.LLBD)
        Me.Panel1.Controls.Add(Me.LLFD)
        Me.Panel1.Controls.Add(Me.LRBD)
        Me.Panel1.Controls.Add(Me.LRFD)
        Me.Panel1.Controls.Add(Me.DBC)
        Me.Panel1.Controls.Add(Me.DFC)
        Me.Panel1.Controls.Add(Me.FCO)
        Me.Panel1.Controls.Add(Me.BCO)
        Me.Panel1.Controls.Add(Me.LCO)
        Me.Panel1.Controls.Add(Me.RCO)
        Me.Panel1.Controls.Add(Me.LLBU)
        Me.Panel1.Controls.Add(Me.LLFU)
        Me.Panel1.Controls.Add(Me.LRBU)
        Me.Panel1.Controls.Add(Me.LRFU)
        Me.Panel1.Controls.Add(Me.DBO)
        Me.Panel1.Controls.Add(Me.DFO)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(222, 482)
        Me.Panel1.TabIndex = 5
        '
        'BCA
        '
        Me.BCA.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BCA.ForeColor = System.Drawing.Color.Red
        Me.BCA.Location = New System.Drawing.Point(41, 345)
        Me.BCA.Margin = New System.Windows.Forms.Padding(0)
        Me.BCA.Name = "BCA"
        Me.BCA.Size = New System.Drawing.Size(62, 13)
        Me.BCA.TabIndex = 51
        Me.BCA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FCA
        '
        Me.FCA.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FCA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FCA.ForeColor = System.Drawing.Color.Red
        Me.FCA.Location = New System.Drawing.Point(41, 323)
        Me.FCA.Margin = New System.Windows.Forms.Padding(0)
        Me.FCA.Name = "FCA"
        Me.FCA.Size = New System.Drawing.Size(62, 13)
        Me.FCA.TabIndex = 50
        Me.FCA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LCA
        '
        Me.LCA.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LCA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LCA.ForeColor = System.Drawing.Color.Red
        Me.LCA.Location = New System.Drawing.Point(41, 301)
        Me.LCA.Margin = New System.Windows.Forms.Padding(0)
        Me.LCA.Name = "LCA"
        Me.LCA.Size = New System.Drawing.Size(62, 13)
        Me.LCA.TabIndex = 49
        Me.LCA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RCA
        '
        Me.RCA.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RCA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RCA.ForeColor = System.Drawing.Color.Red
        Me.RCA.Location = New System.Drawing.Point(41, 279)
        Me.RCA.Margin = New System.Windows.Forms.Padding(0)
        Me.RCA.Name = "RCA"
        Me.RCA.Size = New System.Drawing.Size(62, 13)
        Me.RCA.TabIndex = 48
        Me.RCA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LLBA
        '
        Me.LLBA.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LLBA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LLBA.ForeColor = System.Drawing.Color.Red
        Me.LLBA.Location = New System.Drawing.Point(41, 229)
        Me.LLBA.Margin = New System.Windows.Forms.Padding(0)
        Me.LLBA.Name = "LLBA"
        Me.LLBA.Size = New System.Drawing.Size(62, 13)
        Me.LLBA.TabIndex = 47
        Me.LLBA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LLFA
        '
        Me.LLFA.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LLFA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LLFA.ForeColor = System.Drawing.Color.Red
        Me.LLFA.Location = New System.Drawing.Point(41, 207)
        Me.LLFA.Margin = New System.Windows.Forms.Padding(0)
        Me.LLFA.Name = "LLFA"
        Me.LLFA.Size = New System.Drawing.Size(62, 13)
        Me.LLFA.TabIndex = 46
        Me.LLFA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LRBA
        '
        Me.LRBA.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LRBA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LRBA.ForeColor = System.Drawing.Color.Red
        Me.LRBA.Location = New System.Drawing.Point(41, 185)
        Me.LRBA.Margin = New System.Windows.Forms.Padding(0)
        Me.LRBA.Name = "LRBA"
        Me.LRBA.Size = New System.Drawing.Size(62, 13)
        Me.LRBA.TabIndex = 45
        Me.LRBA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LRFA
        '
        Me.LRFA.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LRFA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LRFA.ForeColor = System.Drawing.Color.Red
        Me.LRFA.Location = New System.Drawing.Point(41, 163)
        Me.LRFA.Margin = New System.Windows.Forms.Padding(0)
        Me.LRFA.Name = "LRFA"
        Me.LRFA.Size = New System.Drawing.Size(62, 13)
        Me.LRFA.TabIndex = 44
        Me.LRFA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DBA
        '
        Me.DBA.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DBA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DBA.ForeColor = System.Drawing.Color.Red
        Me.DBA.Location = New System.Drawing.Point(41, 108)
        Me.DBA.Margin = New System.Windows.Forms.Padding(0)
        Me.DBA.Name = "DBA"
        Me.DBA.Size = New System.Drawing.Size(62, 13)
        Me.DBA.TabIndex = 43
        Me.DBA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DFA
        '
        Me.DFA.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DFA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DFA.ForeColor = System.Drawing.Color.Red
        Me.DFA.Location = New System.Drawing.Point(41, 86)
        Me.DFA.Margin = New System.Windows.Forms.Padding(0)
        Me.DFA.Name = "DFA"
        Me.DFA.Size = New System.Drawing.Size(62, 13)
        Me.DFA.TabIndex = 42
        Me.DFA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BaseStateTxt
        '
        Me.BaseStateTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BaseStateTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BaseStateTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BaseStateTxt.ForeColor = System.Drawing.Color.Green
        Me.BaseStateTxt.Location = New System.Drawing.Point(13, 46)
        Me.BaseStateTxt.Name = "BaseStateTxt"
        Me.BaseStateTxt.Size = New System.Drawing.Size(193, 13)
        Me.BaseStateTxt.TabIndex = 41
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox10.Location = New System.Drawing.Point(132, 348)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(74, 13)
        Me.TextBox10.TabIndex = 40
        Me.TextBox10.Text = "Back"
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox11.Location = New System.Drawing.Point(132, 326)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(74, 13)
        Me.TextBox11.TabIndex = 39
        Me.TextBox11.Text = "Front"
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox12.Location = New System.Drawing.Point(132, 303)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(74, 13)
        Me.TextBox12.TabIndex = 38
        Me.TextBox12.Text = "Left"
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox13.Location = New System.Drawing.Point(132, 280)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(74, 13)
        Me.TextBox13.TabIndex = 37
        Me.TextBox13.Text = "Right"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox8.Location = New System.Drawing.Point(132, 230)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(74, 13)
        Me.TextBox8.TabIndex = 36
        Me.TextBox8.Text = "Left back"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox9.Location = New System.Drawing.Point(132, 208)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(74, 13)
        Me.TextBox9.TabIndex = 35
        Me.TextBox9.Text = "Left front"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox6.Location = New System.Drawing.Point(132, 185)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(74, 13)
        Me.TextBox6.TabIndex = 34
        Me.TextBox6.Text = "Right back"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox7.Location = New System.Drawing.Point(132, 162)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(74, 13)
        Me.TextBox7.TabIndex = 33
        Me.TextBox7.Text = "Right front"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox5.Location = New System.Drawing.Point(132, 109)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(74, 13)
        Me.TextBox5.TabIndex = 32
        Me.TextBox5.Text = "Back"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox4.Location = New System.Drawing.Point(132, 86)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(74, 13)
        Me.TextBox4.TabIndex = 31
        Me.TextBox4.Text = "Front"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox3.Location = New System.Drawing.Point(18, 259)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(131, 13)
        Me.TextBox3.TabIndex = 30
        Me.TextBox3.Text = "Claws:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(18, 143)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(131, 13)
        Me.TextBox2.TabIndex = 29
        Me.TextBox2.Text = "Lift:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(18, 66)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(131, 13)
        Me.TextBox1.TabIndex = 28
        Me.TextBox1.Text = "Doors:"
        '
        'ButtonOpen
        '
        Me.ButtonOpen.Location = New System.Drawing.Point(244, 187)
        Me.ButtonOpen.Name = "ButtonOpen"
        Me.ButtonOpen.Size = New System.Drawing.Size(121, 23)
        Me.ButtonOpen.TabIndex = 6
        Me.ButtonOpen.Text = "Open"
        Me.ButtonOpen.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(244, 216)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(121, 23)
        Me.ButtonClose.TabIndex = 7
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(243, 341)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(121, 23)
        Me.ButtonReset.TabIndex = 8
        Me.ButtonReset.Text = "Reset errors"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5
        '
        'ButtonCenter
        '
        Me.ButtonCenter.Location = New System.Drawing.Point(244, 266)
        Me.ButtonCenter.Name = "ButtonCenter"
        Me.ButtonCenter.Size = New System.Drawing.Size(121, 23)
        Me.ButtonCenter.TabIndex = 9
        Me.ButtonCenter.Text = "Center"
        Me.ButtonCenter.UseVisualStyleBackColor = True
        '
        'ButtonUncenter
        '
        Me.ButtonUncenter.Location = New System.Drawing.Point(244, 303)
        Me.ButtonUncenter.Name = "ButtonUncenter"
        Me.ButtonUncenter.Size = New System.Drawing.Size(121, 23)
        Me.ButtonUncenter.TabIndex = 10
        Me.ButtonUncenter.Text = "Uncenter"
        Me.ButtonUncenter.UseVisualStyleBackColor = True
        '
        'ButtonStop
        '
        Me.ButtonStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonStop.ForeColor = System.Drawing.Color.DarkRed
        Me.ButtonStop.Location = New System.Drawing.Point(244, 386)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(121, 60)
        Me.ButtonStop.TabIndex = 11
        Me.ButtonStop.Text = "Stop"
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'Term
        '
        Me.Term.Location = New System.Drawing.Point(395, 22)
        Me.Term.Multiline = True
        Me.Term.Name = "Term"
        Me.Term.Size = New System.Drawing.Size(785, 424)
        Me.Term.TabIndex = 12
        Me.Term.Visible = False
        '
        'Temp
        '
        Me.Temp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Temp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Temp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Temp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Temp.Location = New System.Drawing.Point(15, 4)
        Me.Temp.Name = "Temp"
        Me.Temp.Size = New System.Drawing.Size(131, 13)
        Me.Temp.TabIndex = 52
        Me.Temp.Text = "Temperature: N/A"
        '
        'HUM
        '
        Me.HUM.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HUM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HUM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.HUM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.HUM.Location = New System.Drawing.Point(15, 23)
        Me.HUM.Name = "HUM"
        Me.HUM.Size = New System.Drawing.Size(131, 13)
        Me.HUM.TabIndex = 53
        Me.HUM.Text = "Humidity: N/A"
        '
        'FCC
        '
        Me.FCC.Image = CType(resources.GetObject("FCC.Image"), System.Drawing.Image)
        Me.FCC.LedColor = "red"
        Me.FCC.LedState = 0
        Me.FCC.Location = New System.Drawing.Point(110, 344)
        Me.FCC.Name = "FCC"
        Me.FCC.Size = New System.Drawing.Size(16, 16)
        Me.FCC.TabIndex = 25
        Me.FCC.TabStop = False
        '
        'BCC
        '
        Me.BCC.Image = CType(resources.GetObject("BCC.Image"), System.Drawing.Image)
        Me.BCC.LedColor = "red"
        Me.BCC.LedState = 0
        Me.BCC.Location = New System.Drawing.Point(110, 322)
        Me.BCC.Name = "BCC"
        Me.BCC.Size = New System.Drawing.Size(16, 16)
        Me.BCC.TabIndex = 24
        Me.BCC.TabStop = False
        '
        'LCC
        '
        Me.LCC.Image = CType(resources.GetObject("LCC.Image"), System.Drawing.Image)
        Me.LCC.LedColor = "red"
        Me.LCC.LedState = 0
        Me.LCC.Location = New System.Drawing.Point(110, 300)
        Me.LCC.Name = "LCC"
        Me.LCC.Size = New System.Drawing.Size(16, 16)
        Me.LCC.TabIndex = 23
        Me.LCC.TabStop = False
        '
        'RCC
        '
        Me.RCC.Image = CType(resources.GetObject("RCC.Image"), System.Drawing.Image)
        Me.RCC.LedColor = "red"
        Me.RCC.LedState = 0
        Me.RCC.Location = New System.Drawing.Point(110, 278)
        Me.RCC.Name = "RCC"
        Me.RCC.Size = New System.Drawing.Size(16, 16)
        Me.RCC.TabIndex = 22
        Me.RCC.TabStop = False
        '
        'LLBD
        '
        Me.LLBD.Image = CType(resources.GetObject("LLBD.Image"), System.Drawing.Image)
        Me.LLBD.LedColor = "red"
        Me.LLBD.LedState = 0
        Me.LLBD.Location = New System.Drawing.Point(110, 228)
        Me.LLBD.Name = "LLBD"
        Me.LLBD.Size = New System.Drawing.Size(16, 16)
        Me.LLBD.TabIndex = 21
        Me.LLBD.TabStop = False
        '
        'LLFD
        '
        Me.LLFD.Image = CType(resources.GetObject("LLFD.Image"), System.Drawing.Image)
        Me.LLFD.LedColor = "red"
        Me.LLFD.LedState = 0
        Me.LLFD.Location = New System.Drawing.Point(110, 206)
        Me.LLFD.Name = "LLFD"
        Me.LLFD.Size = New System.Drawing.Size(16, 16)
        Me.LLFD.TabIndex = 20
        Me.LLFD.TabStop = False
        '
        'LRBD
        '
        Me.LRBD.Image = CType(resources.GetObject("LRBD.Image"), System.Drawing.Image)
        Me.LRBD.LedColor = "red"
        Me.LRBD.LedState = 0
        Me.LRBD.Location = New System.Drawing.Point(110, 184)
        Me.LRBD.Name = "LRBD"
        Me.LRBD.Size = New System.Drawing.Size(16, 16)
        Me.LRBD.TabIndex = 19
        Me.LRBD.TabStop = False
        '
        'LRFD
        '
        Me.LRFD.Image = CType(resources.GetObject("LRFD.Image"), System.Drawing.Image)
        Me.LRFD.LedColor = "red"
        Me.LRFD.LedState = 0
        Me.LRFD.Location = New System.Drawing.Point(110, 162)
        Me.LRFD.Name = "LRFD"
        Me.LRFD.Size = New System.Drawing.Size(16, 16)
        Me.LRFD.TabIndex = 18
        Me.LRFD.TabStop = False
        '
        'DBC
        '
        Me.DBC.Image = CType(resources.GetObject("DBC.Image"), System.Drawing.Image)
        Me.DBC.LedColor = "red"
        Me.DBC.LedState = 0
        Me.DBC.Location = New System.Drawing.Point(110, 107)
        Me.DBC.Name = "DBC"
        Me.DBC.Size = New System.Drawing.Size(16, 16)
        Me.DBC.TabIndex = 17
        Me.DBC.TabStop = False
        '
        'DFC
        '
        Me.DFC.Image = CType(resources.GetObject("DFC.Image"), System.Drawing.Image)
        Me.DFC.LedColor = "red"
        Me.DFC.LedState = 0
        Me.DFC.Location = New System.Drawing.Point(110, 85)
        Me.DFC.Name = "DFC"
        Me.DFC.Size = New System.Drawing.Size(16, 16)
        Me.DFC.TabIndex = 16
        Me.DFC.TabStop = False
        '
        'FCO
        '
        Me.FCO.Image = CType(resources.GetObject("FCO.Image"), System.Drawing.Image)
        Me.FCO.LedColor = "green"
        Me.FCO.LedState = 0
        Me.FCO.Location = New System.Drawing.Point(18, 344)
        Me.FCO.Name = "FCO"
        Me.FCO.Size = New System.Drawing.Size(16, 16)
        Me.FCO.TabIndex = 13
        Me.FCO.TabStop = False
        '
        'BCO
        '
        Me.BCO.Image = CType(resources.GetObject("BCO.Image"), System.Drawing.Image)
        Me.BCO.LedColor = "green"
        Me.BCO.LedState = 0
        Me.BCO.Location = New System.Drawing.Point(18, 322)
        Me.BCO.Name = "BCO"
        Me.BCO.Size = New System.Drawing.Size(16, 16)
        Me.BCO.TabIndex = 12
        Me.BCO.TabStop = False
        '
        'LCO
        '
        Me.LCO.Image = CType(resources.GetObject("LCO.Image"), System.Drawing.Image)
        Me.LCO.LedColor = "green"
        Me.LCO.LedState = 0
        Me.LCO.Location = New System.Drawing.Point(18, 300)
        Me.LCO.Name = "LCO"
        Me.LCO.Size = New System.Drawing.Size(16, 16)
        Me.LCO.TabIndex = 11
        Me.LCO.TabStop = False
        '
        'RCO
        '
        Me.RCO.Image = CType(resources.GetObject("RCO.Image"), System.Drawing.Image)
        Me.RCO.LedColor = "green"
        Me.RCO.LedState = 0
        Me.RCO.Location = New System.Drawing.Point(18, 278)
        Me.RCO.Name = "RCO"
        Me.RCO.Size = New System.Drawing.Size(16, 16)
        Me.RCO.TabIndex = 10
        Me.RCO.TabStop = False
        '
        'LLBU
        '
        Me.LLBU.Image = CType(resources.GetObject("LLBU.Image"), System.Drawing.Image)
        Me.LLBU.LedColor = "green"
        Me.LLBU.LedState = 0
        Me.LLBU.Location = New System.Drawing.Point(18, 228)
        Me.LLBU.Name = "LLBU"
        Me.LLBU.Size = New System.Drawing.Size(16, 16)
        Me.LLBU.TabIndex = 9
        Me.LLBU.TabStop = False
        '
        'LLFU
        '
        Me.LLFU.Image = CType(resources.GetObject("LLFU.Image"), System.Drawing.Image)
        Me.LLFU.LedColor = "green"
        Me.LLFU.LedState = 0
        Me.LLFU.Location = New System.Drawing.Point(18, 206)
        Me.LLFU.Name = "LLFU"
        Me.LLFU.Size = New System.Drawing.Size(16, 16)
        Me.LLFU.TabIndex = 8
        Me.LLFU.TabStop = False
        '
        'LRBU
        '
        Me.LRBU.Image = CType(resources.GetObject("LRBU.Image"), System.Drawing.Image)
        Me.LRBU.LedColor = "green"
        Me.LRBU.LedState = 0
        Me.LRBU.Location = New System.Drawing.Point(18, 184)
        Me.LRBU.Name = "LRBU"
        Me.LRBU.Size = New System.Drawing.Size(16, 16)
        Me.LRBU.TabIndex = 7
        Me.LRBU.TabStop = False
        '
        'LRFU
        '
        Me.LRFU.Image = CType(resources.GetObject("LRFU.Image"), System.Drawing.Image)
        Me.LRFU.LedColor = "green"
        Me.LRFU.LedState = 0
        Me.LRFU.Location = New System.Drawing.Point(18, 162)
        Me.LRFU.Name = "LRFU"
        Me.LRFU.Size = New System.Drawing.Size(16, 16)
        Me.LRFU.TabIndex = 6
        Me.LRFU.TabStop = False
        '
        'DBO
        '
        Me.DBO.Image = CType(resources.GetObject("DBO.Image"), System.Drawing.Image)
        Me.DBO.LedColor = "green"
        Me.DBO.LedState = 0
        Me.DBO.Location = New System.Drawing.Point(18, 107)
        Me.DBO.Name = "DBO"
        Me.DBO.Size = New System.Drawing.Size(16, 16)
        Me.DBO.TabIndex = 5
        Me.DBO.TabStop = False
        '
        'DFO
        '
        Me.DFO.Image = CType(resources.GetObject("DFO.Image"), System.Drawing.Image)
        Me.DFO.LedColor = "green"
        Me.DFO.LedState = 0
        Me.DFO.Location = New System.Drawing.Point(18, 85)
        Me.DFO.Name = "DFO"
        Me.DFO.Size = New System.Drawing.Size(16, 16)
        Me.DFO.TabIndex = 4
        Me.DFO.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1374, 478)
        Me.Controls.Add(Me.Term)
        Me.Controls.Add(Me.ButtonStop)
        Me.Controls.Add(Me.ButtonUncenter)
        Me.Controls.Add(Me.ButtonCenter)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonOpen)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Controls.Add(Me.ComboSelectPort)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "COPTER BASE control center "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LLBD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LLFD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LRBD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LRFD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DFC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FCO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BCO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RCO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LLBU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LLFU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LRBU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LRFU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DFO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ComboSelectPort As ComboBox
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DFO As PictureboxT
    Friend WithEvents ButtonOpen As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ButtonReset As Button
    Friend WithEvents FCC As PictureboxT
    Friend WithEvents BCC As PictureboxT
    Friend WithEvents LCC As PictureboxT
    Friend WithEvents RCC As PictureboxT
    Friend WithEvents LLBD As PictureboxT
    Friend WithEvents LLFD As PictureboxT
    Friend WithEvents LRBD As PictureboxT
    Friend WithEvents LRFD As PictureboxT
    Friend WithEvents DBC As PictureboxT
    Friend WithEvents DFC As PictureboxT
    Friend WithEvents FCO As PictureboxT
    Friend WithEvents BCO As PictureboxT
    Friend WithEvents LCO As PictureboxT
    Friend WithEvents RCO As PictureboxT
    Friend WithEvents LLBU As PictureboxT
    Friend WithEvents LLFU As PictureboxT
    Friend WithEvents LRBU As PictureboxT
    Friend WithEvents LRFU As PictureboxT
    Friend WithEvents DBO As PictureboxT
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ButtonCenter As Button
    Friend WithEvents ButtonUncenter As Button
    Friend WithEvents ButtonStop As Button
    Friend WithEvents Term As TextBox
    Friend WithEvents BaseStateTxt As TextBox
    Friend WithEvents BCA As TextBox
    Friend WithEvents FCA As TextBox
    Friend WithEvents LCA As TextBox
    Friend WithEvents RCA As TextBox
    Friend WithEvents LLBA As TextBox
    Friend WithEvents LLFA As TextBox
    Friend WithEvents LRBA As TextBox
    Friend WithEvents LRFA As TextBox
    Friend WithEvents DBA As TextBox
    Friend WithEvents DFA As TextBox
    Friend WithEvents HUM As TextBox
    Friend WithEvents Temp As TextBox
End Class
