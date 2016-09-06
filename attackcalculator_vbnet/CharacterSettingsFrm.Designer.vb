<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CharacterSettingsFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CharacterSettingsFrm))
        Me.lbl_damage = New System.Windows.Forms.Label()
        Me.txt_damage = New System.Windows.Forms.TextBox()
        Me.cb_characters = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.cb_crouchcancel = New System.Windows.Forms.CheckBox()
        Me.cb_charging = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lbl_damage
        '
        Me.lbl_damage.AutoSize = True
        Me.lbl_damage.Location = New System.Drawing.Point(119, 9)
        Me.lbl_damage.Name = "lbl_damage"
        Me.lbl_damage.Size = New System.Drawing.Size(47, 13)
        Me.lbl_damage.TabIndex = 5
        Me.lbl_damage.Text = "Damage"
        '
        'txt_damage
        '
        Me.txt_damage.Location = New System.Drawing.Point(15, 25)
        Me.txt_damage.MaxLength = 3
        Me.txt_damage.Name = "txt_damage"
        Me.txt_damage.Size = New System.Drawing.Size(257, 20)
        Me.txt_damage.TabIndex = 0
        Me.txt_damage.Text = "0"
        Me.txt_damage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cb_characters
        '
        Me.cb_characters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_characters.FormattingEnabled = True
        Me.cb_characters.Items.AddRange(New Object() {"Mario (100)", "Donkey Kong (114)", "Link (104)", "Samus (110)", "Zero Suit Samus (85)", "Yoshi (111)", "Kirby (74)", "Fox (75)", "Pikachu (80)", "Luigi (100)", "Ice Climbers (88)", "Captain Falcon (104)", "Ness (94)", "Bowser (118)", "Peach (90)", "Zelda (90)", "Sheik (90)", "Marth (87)", "Mr. Game & Watch (75)", "Falco (80)", "Ganondorf (109)", "Wario (107)", "Meta Knight (70)", "Pit (80)", "Olimar (90)", "Lucas (80)", "Diddy Kong (85)", "King Dedede (112)", "Lucario (100)", "Ike (105)", "R.O.B. (106)", "Jigglypuff (60)", "Toon Link (85)", "Wolf (85)", "Snake (105)", "Sonic (82)", "Charizard (110)", "Squirtle (82)", "Ivysaur (85)", "Roy (85)", "Mewtwo (97)"})
        Me.cb_characters.Location = New System.Drawing.Point(15, 64)
        Me.cb_characters.Name = "cb_characters"
        Me.cb_characters.Size = New System.Drawing.Size(257, 21)
        Me.cb_characters.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Character"
        '
        'btn_confirm
        '
        Me.btn_confirm.Location = New System.Drawing.Point(15, 114)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(257, 23)
        Me.btn_confirm.TabIndex = 4
        Me.btn_confirm.Text = "Confirm"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'cb_crouchcancel
        '
        Me.cb_crouchcancel.AutoSize = True
        Me.cb_crouchcancel.Location = New System.Drawing.Point(15, 91)
        Me.cb_crouchcancel.Name = "cb_crouchcancel"
        Me.cb_crouchcancel.Size = New System.Drawing.Size(110, 17)
        Me.cb_crouchcancel.TabIndex = 2
        Me.cb_crouchcancel.Text = "Crouch Canceling"
        Me.cb_crouchcancel.UseVisualStyleBackColor = True
        '
        'cb_charging
        '
        Me.cb_charging.AutoSize = True
        Me.cb_charging.Location = New System.Drawing.Point(135, 91)
        Me.cb_charging.Name = "cb_charging"
        Me.cb_charging.Size = New System.Drawing.Size(137, 17)
        Me.cb_charging.TabIndex = 3
        Me.cb_charging.Text = "Charging Smash Attack"
        Me.cb_charging.UseVisualStyleBackColor = True
        '
        'CharacterSettingsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 150)
        Me.Controls.Add(Me.cb_charging)
        Me.Controls.Add(Me.cb_crouchcancel)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_characters)
        Me.Controls.Add(Me.txt_damage)
        Me.Controls.Add(Me.lbl_damage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CharacterSettingsFrm"
        Me.Text = "Victim Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_damage As System.Windows.Forms.Label
    Friend WithEvents txt_damage As System.Windows.Forms.TextBox
    Friend WithEvents cb_characters As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_confirm As System.Windows.Forms.Button
    Friend WithEvents cb_crouchcancel As System.Windows.Forms.CheckBox
    Friend WithEvents cb_charging As System.Windows.Forms.CheckBox
End Class
