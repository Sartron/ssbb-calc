<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SmashChargeFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SmashChargeFrm))
        Me.lbl_damage = New System.Windows.Forms.Label()
        Me.txt_damage = New System.Windows.Forms.TextBox()
        Me.txt_chargeddamage = New System.Windows.Forms.TextBox()
        Me.lbl_chargeddamage = New System.Windows.Forms.Label()
        Me.btn_calculate = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_damage
        '
        Me.lbl_damage.AutoSize = True
        Me.lbl_damage.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_damage.Location = New System.Drawing.Point(13, 11)
        Me.lbl_damage.Name = "lbl_damage"
        Me.lbl_damage.Size = New System.Drawing.Size(47, 11)
        Me.lbl_damage.TabIndex = 0
        Me.lbl_damage.Text = "Damage"
        '
        'txt_damage
        '
        Me.txt_damage.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_damage.Location = New System.Drawing.Point(15, 25)
        Me.txt_damage.MaxLength = 3
        Me.txt_damage.Name = "txt_damage"
        Me.txt_damage.Size = New System.Drawing.Size(257, 18)
        Me.txt_damage.TabIndex = 1
        Me.txt_damage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_chargeddamage
        '
        Me.txt_chargeddamage.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_chargeddamage.Location = New System.Drawing.Point(15, 64)
        Me.txt_chargeddamage.MaxLength = 3
        Me.txt_chargeddamage.Name = "txt_chargeddamage"
        Me.txt_chargeddamage.ReadOnly = True
        Me.txt_chargeddamage.Size = New System.Drawing.Size(257, 18)
        Me.txt_chargeddamage.TabIndex = 3
        Me.txt_chargeddamage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_chargeddamage
        '
        Me.lbl_chargeddamage.AutoSize = True
        Me.lbl_chargeddamage.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_chargeddamage.Location = New System.Drawing.Point(13, 50)
        Me.lbl_chargeddamage.Name = "lbl_chargeddamage"
        Me.lbl_chargeddamage.Size = New System.Drawing.Size(103, 11)
        Me.lbl_chargeddamage.TabIndex = 2
        Me.lbl_chargeddamage.Text = "Charged Damage"
        '
        'btn_calculate
        '
        Me.btn_calculate.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calculate.Location = New System.Drawing.Point(15, 90)
        Me.btn_calculate.Name = "btn_calculate"
        Me.btn_calculate.Size = New System.Drawing.Size(191, 23)
        Me.btn_calculate.TabIndex = 4
        Me.btn_calculate.Text = "Calculate"
        Me.btn_calculate.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(212, 90)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(60, 23)
        Me.btn_close.TabIndex = 5
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'SmashChargeFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 124)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_calculate)
        Me.Controls.Add(Me.txt_chargeddamage)
        Me.Controls.Add(Me.lbl_chargeddamage)
        Me.Controls.Add(Me.txt_damage)
        Me.Controls.Add(Me.lbl_damage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SmashChargeFrm"
        Me.Text = "Charged Smash Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_damage As System.Windows.Forms.Label
    Friend WithEvents txt_damage As System.Windows.Forms.TextBox
    Friend WithEvents txt_chargeddamage As System.Windows.Forms.TextBox
    Friend WithEvents lbl_chargeddamage As System.Windows.Forms.Label
    Friend WithEvents btn_calculate As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
End Class
