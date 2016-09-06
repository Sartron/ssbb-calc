<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OutputSettingsFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OutputSettingsFrm))
        Me.cb_id = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_shielddamage = New System.Windows.Forms.CheckBox()
        Me.cb_hitdamage = New System.Windows.Forms.CheckBox()
        Me.cb_angle = New System.Windows.Forms.CheckBox()
        Me.cb_kbunits = New System.Windows.Forms.CheckBox()
        Me.cb_bkb = New System.Windows.Forms.CheckBox()
        Me.cb_wdsk = New System.Windows.Forms.CheckBox()
        Me.cb_kbg = New System.Windows.Forms.CheckBox()
        Me.cb_sdimulti = New System.Windows.Forms.CheckBox()
        Me.cb_hitlagmulti = New System.Windows.Forms.CheckBox()
        Me.cb_hitstun = New System.Windows.Forms.CheckBox()
        Me.cb_shieldstun = New System.Windows.Forms.CheckBox()
        Me.cb_hitlag = New System.Windows.Forms.CheckBox()
        Me.cb_hitadvantage = New System.Windows.Forms.CheckBox()
        Me.cb_shieldadvantage = New System.Windows.Forms.CheckBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.panel_separate = New System.Windows.Forms.Panel()
        Me.cb_size = New System.Windows.Forms.CheckBox()
        Me.cb_Clang = New System.Windows.Forms.CheckBox()
        Me.cb_CanHit = New System.Windows.Forms.CheckBox()
        Me.cb_Effect = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_id
        '
        Me.cb_id.AutoSize = True
        Me.cb_id.Location = New System.Drawing.Point(12, 12)
        Me.cb_id.Name = "cb_id"
        Me.cb_id.Size = New System.Drawing.Size(67, 17)
        Me.cb_id.TabIndex = 1
        Me.cb_id.Text = "ID (Bit 1)"
        Me.cb_id.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_shielddamage)
        Me.GroupBox1.Controls.Add(Me.cb_hitdamage)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(92, 68)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Damage (Bit 3)"
        '
        'cb_shielddamage
        '
        Me.cb_shielddamage.AutoSize = True
        Me.cb_shielddamage.Location = New System.Drawing.Point(6, 42)
        Me.cb_shielddamage.Name = "cb_shielddamage"
        Me.cb_shielddamage.Size = New System.Drawing.Size(55, 17)
        Me.cb_shielddamage.TabIndex = 4
        Me.cb_shielddamage.Text = "Shield"
        Me.cb_shielddamage.UseVisualStyleBackColor = True
        '
        'cb_hitdamage
        '
        Me.cb_hitdamage.AutoSize = True
        Me.cb_hitdamage.Location = New System.Drawing.Point(6, 19)
        Me.cb_hitdamage.Name = "cb_hitdamage"
        Me.cb_hitdamage.Size = New System.Drawing.Size(39, 17)
        Me.cb_hitdamage.TabIndex = 3
        Me.cb_hitdamage.Text = "Hit"
        Me.cb_hitdamage.UseVisualStyleBackColor = True
        '
        'cb_angle
        '
        Me.cb_angle.AutoSize = True
        Me.cb_angle.Location = New System.Drawing.Point(12, 132)
        Me.cb_angle.Name = "cb_angle"
        Me.cb_angle.Size = New System.Drawing.Size(83, 17)
        Me.cb_angle.TabIndex = 4
        Me.cb_angle.Text = "Angle (Bit 4)"
        Me.cb_angle.UseVisualStyleBackColor = True
        '
        'cb_kbunits
        '
        Me.cb_kbunits.AutoSize = True
        Me.cb_kbunits.Location = New System.Drawing.Point(12, 155)
        Me.cb_kbunits.Name = "cb_kbunits"
        Me.cb_kbunits.Size = New System.Drawing.Size(138, 17)
        Me.cb_kbunits.TabIndex = 5
        Me.cb_kbunits.Text = "Knockback Units (Bit 5)"
        Me.cb_kbunits.UseVisualStyleBackColor = True
        '
        'cb_bkb
        '
        Me.cb_bkb.AutoSize = True
        Me.cb_bkb.Location = New System.Drawing.Point(12, 178)
        Me.cb_bkb.Name = "cb_bkb"
        Me.cb_bkb.Size = New System.Drawing.Size(138, 17)
        Me.cb_bkb.TabIndex = 6
        Me.cb_bkb.Text = "Base Knockback (Bit 6)"
        Me.cb_bkb.UseVisualStyleBackColor = True
        '
        'cb_wdsk
        '
        Me.cb_wdsk.AutoSize = True
        Me.cb_wdsk.Location = New System.Drawing.Point(12, 201)
        Me.cb_wdsk.Name = "cb_wdsk"
        Me.cb_wdsk.Size = New System.Drawing.Size(223, 17)
        Me.cb_wdsk.TabIndex = 7
        Me.cb_wdsk.Text = "Weight Dependent Set Knockback (Bit 7)"
        Me.cb_wdsk.UseVisualStyleBackColor = True
        '
        'cb_kbg
        '
        Me.cb_kbg.AutoSize = True
        Me.cb_kbg.Location = New System.Drawing.Point(12, 224)
        Me.cb_kbg.Name = "cb_kbg"
        Me.cb_kbg.Size = New System.Drawing.Size(148, 17)
        Me.cb_kbg.TabIndex = 8
        Me.cb_kbg.Text = "Knockback Growth (Bit 8)"
        Me.cb_kbg.UseVisualStyleBackColor = True
        '
        'cb_sdimulti
        '
        Me.cb_sdimulti.AutoSize = True
        Me.cb_sdimulti.Location = New System.Drawing.Point(12, 270)
        Me.cb_sdimulti.Name = "cb_sdimulti"
        Me.cb_sdimulti.Size = New System.Drawing.Size(124, 17)
        Me.cb_sdimulti.TabIndex = 9
        Me.cb_sdimulti.Text = "SDI Multiplier (Bit 10)"
        Me.cb_sdimulti.UseVisualStyleBackColor = True
        '
        'cb_hitlagmulti
        '
        Me.cb_hitlagmulti.AutoSize = True
        Me.cb_hitlagmulti.Location = New System.Drawing.Point(12, 247)
        Me.cb_hitlagmulti.Name = "cb_hitlagmulti"
        Me.cb_hitlagmulti.Size = New System.Drawing.Size(127, 17)
        Me.cb_hitlagmulti.TabIndex = 10
        Me.cb_hitlagmulti.Text = "Hitlag Multiplier (Bit 9)"
        Me.cb_hitlagmulti.UseVisualStyleBackColor = True
        '
        'cb_hitstun
        '
        Me.cb_hitstun.AutoSize = True
        Me.cb_hitstun.Location = New System.Drawing.Point(12, 362)
        Me.cb_hitstun.Name = "cb_hitstun"
        Me.cb_hitstun.Size = New System.Drawing.Size(95, 17)
        Me.cb_hitstun.TabIndex = 11
        Me.cb_hitstun.Text = "Hitstun (Bit 14)"
        Me.cb_hitstun.UseVisualStyleBackColor = True
        '
        'cb_shieldstun
        '
        Me.cb_shieldstun.AutoSize = True
        Me.cb_shieldstun.Location = New System.Drawing.Point(12, 385)
        Me.cb_shieldstun.Name = "cb_shieldstun"
        Me.cb_shieldstun.Size = New System.Drawing.Size(111, 17)
        Me.cb_shieldstun.TabIndex = 12
        Me.cb_shieldstun.Text = "Shieldstun (Bit 15)"
        Me.cb_shieldstun.UseVisualStyleBackColor = True
        '
        'cb_hitlag
        '
        Me.cb_hitlag.AutoSize = True
        Me.cb_hitlag.Location = New System.Drawing.Point(12, 408)
        Me.cb_hitlag.Name = "cb_hitlag"
        Me.cb_hitlag.Size = New System.Drawing.Size(89, 17)
        Me.cb_hitlag.TabIndex = 13
        Me.cb_hitlag.Text = "Hitlag (Bit 16)"
        Me.cb_hitlag.UseVisualStyleBackColor = True
        '
        'cb_hitadvantage
        '
        Me.cb_hitadvantage.AutoSize = True
        Me.cb_hitadvantage.Location = New System.Drawing.Point(12, 431)
        Me.cb_hitadvantage.Name = "cb_hitadvantage"
        Me.cb_hitadvantage.Size = New System.Drawing.Size(130, 17)
        Me.cb_hitadvantage.TabIndex = 14
        Me.cb_hitadvantage.Text = "Hit Advantage (Bit 17)"
        Me.cb_hitadvantage.UseVisualStyleBackColor = True
        '
        'cb_shieldadvantage
        '
        Me.cb_shieldadvantage.AutoSize = True
        Me.cb_shieldadvantage.Location = New System.Drawing.Point(12, 454)
        Me.cb_shieldadvantage.Name = "cb_shieldadvantage"
        Me.cb_shieldadvantage.Size = New System.Drawing.Size(146, 17)
        Me.cb_shieldadvantage.TabIndex = 15
        Me.cb_shieldadvantage.Text = "Shield Advantage (Bit 18)"
        Me.cb_shieldadvantage.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(93, 486)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(213, 23)
        Me.btn_cancel.TabIndex = 16
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(12, 486)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 17
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'panel_separate
        '
        Me.panel_separate.BackColor = System.Drawing.Color.Silver
        Me.panel_separate.Location = New System.Drawing.Point(12, 479)
        Me.panel_separate.Name = "panel_separate"
        Me.panel_separate.Size = New System.Drawing.Size(294, 1)
        Me.panel_separate.TabIndex = 18
        '
        'cb_size
        '
        Me.cb_size.AutoSize = True
        Me.cb_size.Location = New System.Drawing.Point(12, 35)
        Me.cb_size.Name = "cb_size"
        Me.cb_size.Size = New System.Drawing.Size(76, 17)
        Me.cb_size.TabIndex = 19
        Me.cb_size.Text = "Size (Bit 2)"
        Me.cb_size.UseVisualStyleBackColor = True
        '
        'cb_Clang
        '
        Me.cb_Clang.AutoSize = True
        Me.cb_Clang.Location = New System.Drawing.Point(12, 293)
        Me.cb_Clang.Name = "cb_Clang"
        Me.cb_Clang.Size = New System.Drawing.Size(89, 17)
        Me.cb_Clang.TabIndex = 20
        Me.cb_Clang.Text = "Clang (Bit 11)"
        Me.cb_Clang.UseVisualStyleBackColor = True
        '
        'cb_CanHit
        '
        Me.cb_CanHit.AutoSize = True
        Me.cb_CanHit.Location = New System.Drawing.Point(12, 316)
        Me.cb_CanHit.Name = "cb_CanHit"
        Me.cb_CanHit.Size = New System.Drawing.Size(97, 17)
        Me.cb_CanHit.TabIndex = 21
        Me.cb_CanHit.Text = "Can Hit (Bit 12)"
        Me.cb_CanHit.UseVisualStyleBackColor = True
        '
        'cb_Effect
        '
        Me.cb_Effect.AutoSize = True
        Me.cb_Effect.Location = New System.Drawing.Point(12, 339)
        Me.cb_Effect.Name = "cb_Effect"
        Me.cb_Effect.Size = New System.Drawing.Size(90, 17)
        Me.cb_Effect.TabIndex = 22
        Me.cb_Effect.Text = "Effect (Bit 13)"
        Me.cb_Effect.UseVisualStyleBackColor = True
        '
        'OutputSettingsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 519)
        Me.Controls.Add(Me.cb_Effect)
        Me.Controls.Add(Me.cb_CanHit)
        Me.Controls.Add(Me.cb_Clang)
        Me.Controls.Add(Me.cb_size)
        Me.Controls.Add(Me.panel_separate)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.cb_shieldadvantage)
        Me.Controls.Add(Me.cb_hitadvantage)
        Me.Controls.Add(Me.cb_hitlag)
        Me.Controls.Add(Me.cb_shieldstun)
        Me.Controls.Add(Me.cb_hitstun)
        Me.Controls.Add(Me.cb_hitlagmulti)
        Me.Controls.Add(Me.cb_sdimulti)
        Me.Controls.Add(Me.cb_kbg)
        Me.Controls.Add(Me.cb_wdsk)
        Me.Controls.Add(Me.cb_bkb)
        Me.Controls.Add(Me.cb_kbunits)
        Me.Controls.Add(Me.cb_angle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cb_id)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "OutputSettingsFrm"
        Me.Text = "Output Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cb_id As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_shielddamage As System.Windows.Forms.CheckBox
    Friend WithEvents cb_hitdamage As System.Windows.Forms.CheckBox
    Friend WithEvents cb_angle As System.Windows.Forms.CheckBox
    Friend WithEvents cb_kbunits As System.Windows.Forms.CheckBox
    Friend WithEvents cb_bkb As System.Windows.Forms.CheckBox
    Friend WithEvents cb_wdsk As System.Windows.Forms.CheckBox
    Friend WithEvents cb_kbg As System.Windows.Forms.CheckBox
    Friend WithEvents cb_sdimulti As System.Windows.Forms.CheckBox
    Friend WithEvents cb_hitlagmulti As System.Windows.Forms.CheckBox
    Friend WithEvents cb_hitstun As System.Windows.Forms.CheckBox
    Friend WithEvents cb_shieldstun As System.Windows.Forms.CheckBox
    Friend WithEvents cb_hitlag As System.Windows.Forms.CheckBox
    Friend WithEvents cb_hitadvantage As System.Windows.Forms.CheckBox
    Friend WithEvents cb_shieldadvantage As System.Windows.Forms.CheckBox
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents panel_separate As System.Windows.Forms.Panel
    Friend WithEvents cb_size As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Clang As System.Windows.Forms.CheckBox
    Friend WithEvents cb_CanHit As System.Windows.Forms.CheckBox
    Friend WithEvents cb_Effect As System.Windows.Forms.CheckBox
End Class
