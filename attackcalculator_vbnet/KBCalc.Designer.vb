<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KBCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KBCalc))
        Me.txt_knockback = New System.Windows.Forms.TextBox()
        Me.lbl_knockback = New System.Windows.Forms.Label()
        Me.btn_calculate = New System.Windows.Forms.Button()
        Me.cb_character = New System.Windows.Forms.ComboBox()
        Me.lbl_gravity = New System.Windows.Forms.Label()
        Me.txt_gravity = New System.Windows.Forms.TextBox()
        Me.lbl_terminalvelocity = New System.Windows.Forms.Label()
        Me.txt_terminalvelocity = New System.Windows.Forms.TextBox()
        Me.txt_calc = New System.Windows.Forms.TextBox()
        Me.lbl_height = New System.Windows.Forms.Label()
        Me.txt_height = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_knockback
        '
        Me.txt_knockback.Location = New System.Drawing.Point(15, 25)
        Me.txt_knockback.Name = "txt_knockback"
        Me.txt_knockback.Size = New System.Drawing.Size(151, 20)
        Me.txt_knockback.TabIndex = 0
        Me.txt_knockback.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_knockback
        '
        Me.lbl_knockback.AutoSize = True
        Me.lbl_knockback.Location = New System.Drawing.Point(62, 9)
        Me.lbl_knockback.Name = "lbl_knockback"
        Me.lbl_knockback.Size = New System.Drawing.Size(62, 13)
        Me.lbl_knockback.TabIndex = 1
        Me.lbl_knockback.Text = "Knockback"
        '
        'btn_calculate
        '
        Me.btn_calculate.Location = New System.Drawing.Point(15, 156)
        Me.btn_calculate.Name = "btn_calculate"
        Me.btn_calculate.Size = New System.Drawing.Size(300, 23)
        Me.btn_calculate.TabIndex = 3
        Me.btn_calculate.Text = "Calculate"
        Me.btn_calculate.UseVisualStyleBackColor = True
        '
        'cb_character
        '
        Me.cb_character.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_character.FormattingEnabled = True
        Me.cb_character.Items.AddRange(New Object() {"Mario", "Donkey Kong", "Link", "Samus", "Zero Suit Samus", "Yoshi", "Kirby", "Fox", "Pikachu", "Luigi", "Ice Climbers", "Captain Falcon", "Ness", "Bowser", "Peach", "Zelda", "Sheik", "Marth", "Mr. Game & Watch", "Falco", "Ganondorf", "Wario", "Meta Knight", "Pit", "Olimar", "Lucas", "Diddy Kong", "King Dedede", "Lucario", "Ike", "R.O.B.", "Jigglypuff", "Toon Link", "Wolf", "Snake", "Sonic", "Charizard", "Squirtle", "Ivysaur", "Roy", "Mewtwo"})
        Me.cb_character.Location = New System.Drawing.Point(15, 129)
        Me.cb_character.Name = "cb_character"
        Me.cb_character.Size = New System.Drawing.Size(300, 21)
        Me.cb_character.TabIndex = 2
        '
        'lbl_gravity
        '
        Me.lbl_gravity.AutoSize = True
        Me.lbl_gravity.Location = New System.Drawing.Point(145, 48)
        Me.lbl_gravity.Name = "lbl_gravity"
        Me.lbl_gravity.Size = New System.Drawing.Size(40, 13)
        Me.lbl_gravity.TabIndex = 5
        Me.lbl_gravity.Text = "Gravity"
        '
        'txt_gravity
        '
        Me.txt_gravity.Location = New System.Drawing.Point(15, 64)
        Me.txt_gravity.Name = "txt_gravity"
        Me.txt_gravity.ReadOnly = True
        Me.txt_gravity.Size = New System.Drawing.Size(300, 20)
        Me.txt_gravity.TabIndex = 4
        Me.txt_gravity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_terminalvelocity
        '
        Me.lbl_terminalvelocity.AutoSize = True
        Me.lbl_terminalvelocity.Location = New System.Drawing.Point(123, 87)
        Me.lbl_terminalvelocity.Name = "lbl_terminalvelocity"
        Me.lbl_terminalvelocity.Size = New System.Drawing.Size(87, 13)
        Me.lbl_terminalvelocity.TabIndex = 7
        Me.lbl_terminalvelocity.Text = "Terminal Velocity"
        '
        'txt_terminalvelocity
        '
        Me.txt_terminalvelocity.Location = New System.Drawing.Point(15, 103)
        Me.txt_terminalvelocity.Name = "txt_terminalvelocity"
        Me.txt_terminalvelocity.ReadOnly = True
        Me.txt_terminalvelocity.Size = New System.Drawing.Size(300, 20)
        Me.txt_terminalvelocity.TabIndex = 6
        Me.txt_terminalvelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_calc
        '
        Me.txt_calc.Location = New System.Drawing.Point(15, 185)
        Me.txt_calc.Name = "txt_calc"
        Me.txt_calc.Size = New System.Drawing.Size(300, 20)
        Me.txt_calc.TabIndex = 8
        Me.txt_calc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_height
        '
        Me.lbl_height.AutoSize = True
        Me.lbl_height.Location = New System.Drawing.Point(209, 9)
        Me.lbl_height.Name = "lbl_height"
        Me.lbl_height.Size = New System.Drawing.Size(77, 13)
        Me.lbl_height.TabIndex = 10
        Me.lbl_height.Text = "Starting Height"
        '
        'txt_height
        '
        Me.txt_height.Location = New System.Drawing.Point(172, 25)
        Me.txt_height.Name = "txt_height"
        Me.txt_height.Size = New System.Drawing.Size(143, 20)
        Me.txt_height.TabIndex = 9
        Me.txt_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KBCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 216)
        Me.Controls.Add(Me.lbl_height)
        Me.Controls.Add(Me.txt_height)
        Me.Controls.Add(Me.txt_calc)
        Me.Controls.Add(Me.lbl_terminalvelocity)
        Me.Controls.Add(Me.txt_terminalvelocity)
        Me.Controls.Add(Me.lbl_gravity)
        Me.Controls.Add(Me.txt_gravity)
        Me.Controls.Add(Me.cb_character)
        Me.Controls.Add(Me.btn_calculate)
        Me.Controls.Add(Me.lbl_knockback)
        Me.Controls.Add(Me.txt_knockback)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "KBCalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Knockback Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_knockback As System.Windows.Forms.TextBox
    Friend WithEvents lbl_knockback As System.Windows.Forms.Label
    Friend WithEvents btn_calculate As System.Windows.Forms.Button
    Friend WithEvents cb_character As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_gravity As System.Windows.Forms.Label
    Friend WithEvents txt_gravity As System.Windows.Forms.TextBox
    Friend WithEvents lbl_terminalvelocity As System.Windows.Forms.Label
    Friend WithEvents txt_terminalvelocity As System.Windows.Forms.TextBox
    Friend WithEvents txt_calc As System.Windows.Forms.TextBox
    Friend WithEvents lbl_height As System.Windows.Forms.Label
    Friend WithEvents txt_height As System.Windows.Forms.TextBox
End Class
