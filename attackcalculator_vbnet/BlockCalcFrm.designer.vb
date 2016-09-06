<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlockCalcFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BlockCalcFrm))
        Me.lb_blocks = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_hitframe2 = New System.Windows.Forms.TextBox()
        Me.txt_formula2 = New System.Windows.Forms.TextBox()
        Me.txt_shieldstun2 = New System.Windows.Forms.TextBox()
        Me.txt_advantage2 = New System.Windows.Forms.TextBox()
        Me.txt_acwindow = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_aclag = New System.Windows.Forms.TextBox()
        Me.btn_calculate = New System.Windows.Forms.Button()
        Me.btn_switch = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_lag1 = New System.Windows.Forms.TextBox()
        Me.txt_advantage1 = New System.Windows.Forms.TextBox()
        Me.txt_formula1 = New System.Windows.Forms.TextBox()
        Me.txt_shieldstun1 = New System.Windows.Forms.TextBox()
        Me.Panel0 = New System.Windows.Forms.Panel()
        Me.txt_attackerhitlag0 = New System.Windows.Forms.TextBox()
        Me.txt_shieldhitlag0 = New System.Windows.Forms.TextBox()
        Me.txt_lag0 = New System.Windows.Forms.TextBox()
        Me.txt_shieldstun0 = New System.Windows.Forms.TextBox()
        Me.txt_advantage0 = New System.Windows.Forms.TextBox()
        Me.txt_formula0 = New System.Windows.Forms.TextBox()
        Me.txt_hitframe0 = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel0.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_blocks
        '
        Me.lb_blocks.FormattingEnabled = True
        Me.lb_blocks.Location = New System.Drawing.Point(12, 127)
        Me.lb_blocks.Name = "lb_blocks"
        Me.lb_blocks.Size = New System.Drawing.Size(469, 147)
        Me.lb_blocks.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'txt_hitframe2
        '
        Me.txt_hitframe2.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hitframe2.Location = New System.Drawing.Point(12, 12)
        Me.txt_hitframe2.MaxLength = 10
        Me.txt_hitframe2.Name = "txt_hitframe2"
        Me.txt_hitframe2.Size = New System.Drawing.Size(104, 18)
        Me.txt_hitframe2.TabIndex = 14
        Me.txt_hitframe2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_formula2
        '
        Me.txt_formula2.Enabled = False
        Me.txt_formula2.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_formula2.Location = New System.Drawing.Point(12, 38)
        Me.txt_formula2.Name = "txt_formula2"
        Me.txt_formula2.Size = New System.Drawing.Size(623, 18)
        Me.txt_formula2.TabIndex = 20
        Me.txt_formula2.Text = "Last Hit Frame + Shieldstun - (First Auto-cancel Window Frame - 1) - Auto-cancel " & _
    "Landing Lag"
        '
        'txt_shieldstun2
        '
        Me.txt_shieldstun2.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_shieldstun2.Location = New System.Drawing.Point(129, 12)
        Me.txt_shieldstun2.MaxLength = 10
        Me.txt_shieldstun2.Name = "txt_shieldstun2"
        Me.txt_shieldstun2.Size = New System.Drawing.Size(80, 18)
        Me.txt_shieldstun2.TabIndex = 15
        Me.txt_shieldstun2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_advantage2
        '
        Me.txt_advantage2.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_advantage2.Location = New System.Drawing.Point(12, 62)
        Me.txt_advantage2.MaxLength = 78
        Me.txt_advantage2.Name = "txt_advantage2"
        Me.txt_advantage2.Size = New System.Drawing.Size(623, 18)
        Me.txt_advantage2.TabIndex = 18
        Me.txt_advantage2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_acwindow
        '
        Me.txt_acwindow.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_acwindow.Location = New System.Drawing.Point(223, 12)
        Me.txt_acwindow.MaxLength = 13
        Me.txt_acwindow.Name = "txt_acwindow"
        Me.txt_acwindow.Size = New System.Drawing.Size(258, 18)
        Me.txt_acwindow.TabIndex = 16
        Me.txt_acwindow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txt_aclag)
        Me.Panel2.Controls.Add(Me.txt_acwindow)
        Me.Panel2.Controls.Add(Me.txt_advantage2)
        Me.Panel2.Controls.Add(Me.txt_shieldstun2)
        Me.Panel2.Controls.Add(Me.txt_formula2)
        Me.Panel2.Controls.Add(Me.txt_hitframe2)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(646, 92)
        Me.Panel2.TabIndex = 14
        Me.Panel2.Visible = False
        '
        'txt_aclag
        '
        Me.txt_aclag.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_aclag.Location = New System.Drawing.Point(502, 12)
        Me.txt_aclag.MaxLength = 13
        Me.txt_aclag.Name = "txt_aclag"
        Me.txt_aclag.Size = New System.Drawing.Size(133, 18)
        Me.txt_aclag.TabIndex = 23
        Me.txt_aclag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_calculate
        '
        Me.btn_calculate.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calculate.Location = New System.Drawing.Point(12, 98)
        Me.btn_calculate.Name = "btn_calculate"
        Me.btn_calculate.Size = New System.Drawing.Size(399, 23)
        Me.btn_calculate.TabIndex = 27
        Me.btn_calculate.Text = "Calculate"
        Me.btn_calculate.UseVisualStyleBackColor = True
        '
        'btn_switch
        '
        Me.btn_switch.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_switch.Location = New System.Drawing.Point(417, 98)
        Me.btn_switch.Name = "btn_switch"
        Me.btn_switch.Size = New System.Drawing.Size(64, 23)
        Me.btn_switch.TabIndex = 26
        Me.btn_switch.Text = "Switch"
        Me.btn_switch.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_lag1)
        Me.Panel1.Controls.Add(Me.txt_advantage1)
        Me.Panel1.Controls.Add(Me.txt_formula1)
        Me.Panel1.Controls.Add(Me.txt_shieldstun1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(311, 92)
        Me.Panel1.TabIndex = 25
        Me.Panel1.Visible = False
        '
        'txt_lag1
        '
        Me.txt_lag1.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lag1.Location = New System.Drawing.Point(122, 12)
        Me.txt_lag1.MaxLength = 13
        Me.txt_lag1.Name = "txt_lag1"
        Me.txt_lag1.Size = New System.Drawing.Size(93, 18)
        Me.txt_lag1.TabIndex = 23
        Me.txt_lag1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_advantage1
        '
        Me.txt_advantage1.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_advantage1.Location = New System.Drawing.Point(12, 62)
        Me.txt_advantage1.MaxLength = 78
        Me.txt_advantage1.Name = "txt_advantage1"
        Me.txt_advantage1.Size = New System.Drawing.Size(203, 18)
        Me.txt_advantage1.TabIndex = 18
        Me.txt_advantage1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_formula1
        '
        Me.txt_formula1.Enabled = False
        Me.txt_formula1.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_formula1.Location = New System.Drawing.Point(12, 38)
        Me.txt_formula1.Name = "txt_formula1"
        Me.txt_formula1.Size = New System.Drawing.Size(203, 18)
        Me.txt_formula1.TabIndex = 20
        Me.txt_formula1.Text = "(Shieldstun) - (Landing Lag)"
        '
        'txt_shieldstun1
        '
        Me.txt_shieldstun1.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_shieldstun1.Location = New System.Drawing.Point(12, 12)
        Me.txt_shieldstun1.MaxLength = 10
        Me.txt_shieldstun1.Name = "txt_shieldstun1"
        Me.txt_shieldstun1.Size = New System.Drawing.Size(86, 18)
        Me.txt_shieldstun1.TabIndex = 14
        Me.txt_shieldstun1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel0
        '
        Me.Panel0.Controls.Add(Me.txt_attackerhitlag0)
        Me.Panel0.Controls.Add(Me.txt_shieldhitlag0)
        Me.Panel0.Controls.Add(Me.txt_lag0)
        Me.Panel0.Controls.Add(Me.txt_shieldstun0)
        Me.Panel0.Controls.Add(Me.txt_advantage0)
        Me.Panel0.Controls.Add(Me.txt_formula0)
        Me.Panel0.Controls.Add(Me.txt_hitframe0)
        Me.Panel0.Location = New System.Drawing.Point(0, 0)
        Me.Panel0.Name = "Panel0"
        Me.Panel0.Size = New System.Drawing.Size(646, 92)
        Me.Panel0.TabIndex = 28
        '
        'txt_attackerhitlag0
        '
        Me.txt_attackerhitlag0.Enabled = False
        Me.txt_attackerhitlag0.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_attackerhitlag0.Location = New System.Drawing.Point(317, 12)
        Me.txt_attackerhitlag0.MaxLength = 13
        Me.txt_attackerhitlag0.Name = "txt_attackerhitlag0"
        Me.txt_attackerhitlag0.Size = New System.Drawing.Size(111, 18)
        Me.txt_attackerhitlag0.TabIndex = 25
        Me.txt_attackerhitlag0.Text = "0"
        Me.txt_attackerhitlag0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_shieldhitlag0
        '
        Me.txt_shieldhitlag0.Enabled = False
        Me.txt_shieldhitlag0.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_shieldhitlag0.Location = New System.Drawing.Point(196, 12)
        Me.txt_shieldhitlag0.MaxLength = 13
        Me.txt_shieldhitlag0.Name = "txt_shieldhitlag0"
        Me.txt_shieldhitlag0.Size = New System.Drawing.Size(104, 18)
        Me.txt_shieldhitlag0.TabIndex = 24
        Me.txt_shieldhitlag0.Text = "0"
        Me.txt_shieldhitlag0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_lag0
        '
        Me.txt_lag0.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lag0.Location = New System.Drawing.Point(449, 12)
        Me.txt_lag0.MaxLength = 13
        Me.txt_lag0.Name = "txt_lag0"
        Me.txt_lag0.Size = New System.Drawing.Size(186, 18)
        Me.txt_lag0.TabIndex = 23
        Me.txt_lag0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_shieldstun0
        '
        Me.txt_shieldstun0.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_shieldstun0.Location = New System.Drawing.Point(113, 12)
        Me.txt_shieldstun0.MaxLength = 7
        Me.txt_shieldstun0.Name = "txt_shieldstun0"
        Me.txt_shieldstun0.Size = New System.Drawing.Size(58, 18)
        Me.txt_shieldstun0.TabIndex = 16
        Me.txt_shieldstun0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_advantage0
        '
        Me.txt_advantage0.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_advantage0.Location = New System.Drawing.Point(12, 62)
        Me.txt_advantage0.MaxLength = 78
        Me.txt_advantage0.Name = "txt_advantage0"
        Me.txt_advantage0.Size = New System.Drawing.Size(623, 18)
        Me.txt_advantage0.TabIndex = 18
        Me.txt_advantage0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_formula0
        '
        Me.txt_formula0.Enabled = False
        Me.txt_formula0.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_formula0.Location = New System.Drawing.Point(12, 38)
        Me.txt_formula0.Name = "txt_formula0"
        Me.txt_formula0.Size = New System.Drawing.Size(623, 18)
        Me.txt_formula0.TabIndex = 20
        Me.txt_formula0.Text = "(Hit Frame) + (Stun(s)) + (Shield Hitlag - Attacker Hitlag) - (Move Duration/[IAS" & _
    "A - 1])"
        '
        'txt_hitframe0
        '
        Me.txt_hitframe0.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hitframe0.Location = New System.Drawing.Point(12, 12)
        Me.txt_hitframe0.MaxLength = 10
        Me.txt_hitframe0.Name = "txt_hitframe0"
        Me.txt_hitframe0.Size = New System.Drawing.Size(82, 18)
        Me.txt_hitframe0.TabIndex = 14
        Me.txt_hitframe0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BlockCalcFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 127)
        Me.Controls.Add(Me.Panel0)
        Me.Controls.Add(Me.btn_calculate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_switch)
        Me.Controls.Add(Me.lb_blocks)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "BlockCalcFrm"
        Me.Text = "Advantage Calculator"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel0.ResumeLayout(False)
        Me.Panel0.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_blocks As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_hitframe2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_formula2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_shieldstun2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_advantage2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_acwindow As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_aclag As System.Windows.Forms.TextBox
    Friend WithEvents btn_calculate As System.Windows.Forms.Button
    Friend WithEvents btn_switch As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_lag1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_advantage1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_formula1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_shieldstun1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel0 As System.Windows.Forms.Panel
    Friend WithEvents txt_lag0 As System.Windows.Forms.TextBox
    Friend WithEvents txt_shieldstun0 As System.Windows.Forms.TextBox
    Friend WithEvents txt_advantage0 As System.Windows.Forms.TextBox
    Friend WithEvents txt_formula0 As System.Windows.Forms.TextBox
    Friend WithEvents txt_hitframe0 As System.Windows.Forms.TextBox
    Friend WithEvents txt_attackerhitlag0 As System.Windows.Forms.TextBox
    Friend WithEvents txt_shieldhitlag0 As System.Windows.Forms.TextBox
End Class
