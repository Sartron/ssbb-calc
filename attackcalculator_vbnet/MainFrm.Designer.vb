<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.lbl_moveset = New System.Windows.Forms.Label()
        Me.txt_movesetcode = New System.Windows.Forms.TextBox()
        Me.lbl_forumcode = New System.Windows.Forms.Label()
        Me.txt_generatedcode = New System.Windows.Forms.TextBox()
        Me.btn_calculate = New System.Windows.Forms.Button()
        Me.ms_main = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VictimToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OutputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.combobox_game = New System.Windows.Forms.ToolStripComboBox()
        Me.OtherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlockCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KnockbackCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChargedSmashCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FlagAnalyzerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThrowCalculationDumpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.sfd_gencode = New System.Windows.Forms.SaveFileDialog()
        Me.combobox_format = New System.Windows.Forms.ToolStripComboBox()
        Me.ms_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_moveset
        '
        Me.lbl_moveset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_moveset.AutoSize = True
        Me.lbl_moveset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbl_moveset.Location = New System.Drawing.Point(12, 24)
        Me.lbl_moveset.Name = "lbl_moveset"
        Me.lbl_moveset.Size = New System.Drawing.Size(76, 13)
        Me.lbl_moveset.TabIndex = 7
        Me.lbl_moveset.Text = "Moveset Code"
        '
        'txt_movesetcode
        '
        Me.txt_movesetcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_movesetcode.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_movesetcode.Location = New System.Drawing.Point(14, 38)
        Me.txt_movesetcode.Multiline = True
        Me.txt_movesetcode.Name = "txt_movesetcode"
        Me.txt_movesetcode.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_movesetcode.Size = New System.Drawing.Size(760, 166)
        Me.txt_movesetcode.TabIndex = 4
        Me.txt_movesetcode.WordWrap = False
        '
        'lbl_forumcode
        '
        Me.lbl_forumcode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_forumcode.AutoSize = True
        Me.lbl_forumcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lbl_forumcode.Location = New System.Drawing.Point(12, 207)
        Me.lbl_forumcode.Name = "lbl_forumcode"
        Me.lbl_forumcode.Size = New System.Drawing.Size(85, 13)
        Me.lbl_forumcode.TabIndex = 5
        Me.lbl_forumcode.Text = "Generated Code"
        '
        'txt_generatedcode
        '
        Me.txt_generatedcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_generatedcode.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_generatedcode.Location = New System.Drawing.Point(14, 221)
        Me.txt_generatedcode.Multiline = True
        Me.txt_generatedcode.Name = "txt_generatedcode"
        Me.txt_generatedcode.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_generatedcode.Size = New System.Drawing.Size(760, 166)
        Me.txt_generatedcode.TabIndex = 6
        Me.txt_generatedcode.WordWrap = False
        '
        'btn_calculate
        '
        Me.btn_calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_calculate.Location = New System.Drawing.Point(14, 393)
        Me.btn_calculate.Name = "btn_calculate"
        Me.btn_calculate.Size = New System.Drawing.Size(634, 23)
        Me.btn_calculate.TabIndex = 8
        Me.btn_calculate.Text = "Process"
        Me.btn_calculate.UseVisualStyleBackColor = True
        '
        'ms_main
        '
        Me.ms_main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.OtherToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.ms_main.Location = New System.Drawing.Point(0, 0)
        Me.ms_main.Name = "ms_main"
        Me.ms_main.Size = New System.Drawing.Size(784, 24)
        Me.ms_main.TabIndex = 12
        Me.ms_main.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Enabled = False
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(120, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VictimToolStripMenuItem, Me.ToolStripSeparator2, Me.OutputToolStripMenuItem, Me.ToolStripSeparator6, Me.combobox_game, Me.combobox_format})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'VictimToolStripMenuItem
        '
        Me.VictimToolStripMenuItem.Name = "VictimToolStripMenuItem"
        Me.VictimToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.VictimToolStripMenuItem.Text = "Victim"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(178, 6)
        '
        'OutputToolStripMenuItem
        '
        Me.OutputToolStripMenuItem.Name = "OutputToolStripMenuItem"
        Me.OutputToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.OutputToolStripMenuItem.Text = "Output"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(178, 6)
        '
        'combobox_game
        '
        Me.combobox_game.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_game.Enabled = False
        Me.combobox_game.Items.AddRange(New Object() {"Project M"})
        Me.combobox_game.Name = "combobox_game"
        Me.combobox_game.Size = New System.Drawing.Size(121, 23)
        '
        'OtherToolStripMenuItem
        '
        Me.OtherToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlockCalculatorToolStripMenuItem, Me.KnockbackCalculatorToolStripMenuItem, Me.ChargedSmashCalculatorToolStripMenuItem, Me.ToolStripSeparator3, Me.FlagAnalyzerToolStripMenuItem, Me.ThrowCalculationDumpToolStripMenuItem, Me.ToolStripSeparator5, Me.DebugToolStripMenuItem})
        Me.OtherToolStripMenuItem.Name = "OtherToolStripMenuItem"
        Me.OtherToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.OtherToolStripMenuItem.Text = "Other"
        '
        'BlockCalculatorToolStripMenuItem
        '
        Me.BlockCalculatorToolStripMenuItem.Name = "BlockCalculatorToolStripMenuItem"
        Me.BlockCalculatorToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.BlockCalculatorToolStripMenuItem.Text = "Advantage Calculator"
        '
        'KnockbackCalculatorToolStripMenuItem
        '
        Me.KnockbackCalculatorToolStripMenuItem.Name = "KnockbackCalculatorToolStripMenuItem"
        Me.KnockbackCalculatorToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.KnockbackCalculatorToolStripMenuItem.Text = "Knockback Calculator"
        '
        'ChargedSmashCalculatorToolStripMenuItem
        '
        Me.ChargedSmashCalculatorToolStripMenuItem.Name = "ChargedSmashCalculatorToolStripMenuItem"
        Me.ChargedSmashCalculatorToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ChargedSmashCalculatorToolStripMenuItem.Text = "Charged Smash Calculator"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(211, 6)
        '
        'FlagAnalyzerToolStripMenuItem
        '
        Me.FlagAnalyzerToolStripMenuItem.Name = "FlagAnalyzerToolStripMenuItem"
        Me.FlagAnalyzerToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.FlagAnalyzerToolStripMenuItem.Text = "Flag Analyzer"
        '
        'ThrowCalculationDumpToolStripMenuItem
        '
        Me.ThrowCalculationDumpToolStripMenuItem.Name = "ThrowCalculationDumpToolStripMenuItem"
        Me.ThrowCalculationDumpToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.ThrowCalculationDumpToolStripMenuItem.Text = "Calculation Dump"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(211, 6)
        '
        'DebugToolStripMenuItem
        '
        Me.DebugToolStripMenuItem.Name = "DebugToolStripMenuItem"
        Me.DebugToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.DebugToolStripMenuItem.Text = "Debug"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsageToolStripMenuItem, Me.ToolStripSeparator4, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'UsageToolStripMenuItem
        '
        Me.UsageToolStripMenuItem.Name = "UsageToolStripMenuItem"
        Me.UsageToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UsageToolStripMenuItem.Text = "Usage"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(149, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_clear.Location = New System.Drawing.Point(654, 393)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(120, 23)
        Me.btn_clear.TabIndex = 13
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'sfd_gencode
        '
        '
        'combobox_format
        '
        Me.combobox_format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_format.Items.AddRange(New Object() {"BB Code", "Table"})
        Me.combobox_format.Name = "combobox_format"
        Me.combobox_format.Size = New System.Drawing.Size(121, 23)
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 427)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_calculate)
        Me.Controls.Add(Me.lbl_moveset)
        Me.Controls.Add(Me.txt_movesetcode)
        Me.Controls.Add(Me.lbl_forumcode)
        Me.Controls.Add(Me.txt_generatedcode)
        Me.Controls.Add(Me.ms_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.ms_main
        Me.MaximizeBox = False
        Me.Name = "MainFrm"
        Me.Text = "Attack Calculator"
        Me.ms_main.ResumeLayout(False)
        Me.ms_main.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_moveset As System.Windows.Forms.Label
    Friend WithEvents txt_movesetcode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_forumcode As System.Windows.Forms.Label
    Friend WithEvents txt_generatedcode As System.Windows.Forms.TextBox
    Friend WithEvents btn_calculate As System.Windows.Forms.Button
    Friend WithEvents ms_main As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VictimToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents OtherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlockCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sfd_gencode As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ChargedSmashCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FlagAnalyzerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KnockbackCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThrowCalculationDumpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OutputToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DebugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents combobox_game As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents combobox_format As System.Windows.Forms.ToolStripComboBox

End Class
