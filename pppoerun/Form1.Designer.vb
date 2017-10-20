<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_PPPOE_Name = New System.Windows.Forms.TextBox()
        Me.TextBox_Ethernet_Name = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox_PPPOE_Password = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_Dict_File = New System.Windows.Forms.TextBox()
        Me.TextBox_Prefix = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Suffix = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox_ping_check = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button_run = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label_view = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox_PPPOE_Name)
        Me.GroupBox1.Controls.Add(Me.TextBox_Ethernet_Name)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(684, 122)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "系统设置"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(138, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "宽带连接名称"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 12)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "网卡连接名称"
        '
        'TextBox_PPPOE_Name
        '
        Me.TextBox_PPPOE_Name.Location = New System.Drawing.Point(124, 44)
        Me.TextBox_PPPOE_Name.Name = "TextBox_PPPOE_Name"
        Me.TextBox_PPPOE_Name.Size = New System.Drawing.Size(100, 21)
        Me.TextBox_PPPOE_Name.TabIndex = 6
        Me.TextBox_PPPOE_Name.Text = "宽带连接"
        '
        'TextBox_Ethernet_Name
        '
        Me.TextBox_Ethernet_Name.Location = New System.Drawing.Point(12, 44)
        Me.TextBox_Ethernet_Name.Name = "TextBox_Ethernet_Name"
        Me.TextBox_Ethernet_Name.Size = New System.Drawing.Size(100, 21)
        Me.TextBox_Ethernet_Name.TabIndex = 5
        Me.TextBox_Ethernet_Name.Text = "本地连接"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox_PPPOE_Password)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox_Dict_File)
        Me.GroupBox2.Controls.Add(Me.TextBox_Prefix)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox_Suffix)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(683, 100)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "帐号设置"
        '
        'TextBox_PPPOE_Password
        '
        Me.TextBox_PPPOE_Password.Location = New System.Drawing.Point(380, 33)
        Me.TextBox_PPPOE_Password.Name = "TextBox_PPPOE_Password"
        Me.TextBox_PPPOE_Password.Size = New System.Drawing.Size(100, 21)
        Me.TextBox_PPPOE_Password.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(408, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 12)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "密码"
        '
        'TextBox_Dict_File
        '
        Me.TextBox_Dict_File.Location = New System.Drawing.Point(139, 32)
        Me.TextBox_Dict_File.Name = "TextBox_Dict_File"
        Me.TextBox_Dict_File.Size = New System.Drawing.Size(100, 21)
        Me.TextBox_Dict_File.TabIndex = 1
        Me.TextBox_Dict_File.Text = "dict.txt"
        '
        'TextBox_Prefix
        '
        Me.TextBox_Prefix.Location = New System.Drawing.Point(23, 32)
        Me.TextBox_Prefix.Name = "TextBox_Prefix"
        Me.TextBox_Prefix.Size = New System.Drawing.Size(100, 21)
        Me.TextBox_Prefix.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(308, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "帐号后缀"
        '
        'TextBox_Suffix
        '
        Me.TextBox_Suffix.Location = New System.Drawing.Point(268, 32)
        Me.TextBox_Suffix.Name = "TextBox_Suffix"
        Me.TextBox_Suffix.Size = New System.Drawing.Size(100, 21)
        Me.TextBox_Suffix.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "帐号字典文件"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "帐号前缀"
        '
        'CheckBox_ping_check
        '
        Me.CheckBox_ping_check.AutoSize = True
        Me.CheckBox_ping_check.Location = New System.Drawing.Point(11, 20)
        Me.CheckBox_ping_check.Name = "CheckBox_ping_check"
        Me.CheckBox_ping_check.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox_ping_check.TabIndex = 8
        Me.CheckBox_ping_check.Text = "ping检测"
        Me.CheckBox_ping_check.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox_ping_check)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 247)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(683, 55)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "选项"
        '
        'Button_run
        '
        Me.Button_run.Location = New System.Drawing.Point(142, 463)
        Me.Button_run.Name = "Button_run"
        Me.Button_run.Size = New System.Drawing.Size(75, 23)
        Me.Button_run.TabIndex = 10
        Me.Button_run.Text = "开始"
        Me.Button_run.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label_view)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 309)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(683, 100)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "当前状态"
        '
        'Label_view
        '
        Me.Label_view.AutoSize = True
        Me.Label_view.Location = New System.Drawing.Point(27, 51)
        Me.Label_view.Name = "Label_view"
        Me.Label_view.Size = New System.Drawing.Size(41, 12)
        Me.Label_view.TabIndex = 0
        Me.Label_view.Text = "Label7"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 555)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button_run)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_PPPOE_Name As TextBox
    Friend WithEvents TextBox_Ethernet_Name As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox_PPPOE_Password As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_Dict_File As TextBox
    Friend WithEvents TextBox_Prefix As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_Suffix As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox_ping_check As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button_run As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label_view As Label
End Class
