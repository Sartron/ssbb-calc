<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThrowFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ThrowFrm))
        Me.lbl_throw = New System.Windows.Forms.Label()
        Me.txt_movesetcode = New System.Windows.Forms.TextBox()
        Me.lbl_dump = New System.Windows.Forms.Label()
        Me.txt_generatedcode = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_calculate = New System.Windows.Forms.Button()
        Me.txt_max = New System.Windows.Forms.TextBox()
        Me.pb_calculate = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'lbl_throw
        '
        Me.lbl_throw.AutoSize = True
        Me.lbl_throw.Location = New System.Drawing.Point(12, 9)
        Me.lbl_throw.Name = "lbl_throw"
        Me.lbl_throw.Size = New System.Drawing.Size(76, 13)
        Me.lbl_throw.TabIndex = 0
        Me.lbl_throw.Text = "Moveset Code"
        '
        'txt_movesetcode
        '
        Me.txt_movesetcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_movesetcode.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_movesetcode.Location = New System.Drawing.Point(15, 25)
        Me.txt_movesetcode.Multiline = True
        Me.txt_movesetcode.Name = "txt_movesetcode"
        Me.txt_movesetcode.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_movesetcode.Size = New System.Drawing.Size(849, 150)
        Me.txt_movesetcode.TabIndex = 1
        Me.txt_movesetcode.WordWrap = False
        '
        'lbl_dump
        '
        Me.lbl_dump.AutoSize = True
        Me.lbl_dump.Location = New System.Drawing.Point(12, 178)
        Me.lbl_dump.Name = "lbl_dump"
        Me.lbl_dump.Size = New System.Drawing.Size(35, 13)
        Me.lbl_dump.TabIndex = 6
        Me.lbl_dump.Text = "Dump"
        '
        'txt_generatedcode
        '
        Me.txt_generatedcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_generatedcode.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_generatedcode.Location = New System.Drawing.Point(15, 194)
        Me.txt_generatedcode.Multiline = True
        Me.txt_generatedcode.Name = "txt_generatedcode"
        Me.txt_generatedcode.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_generatedcode.Size = New System.Drawing.Size(849, 150)
        Me.txt_generatedcode.TabIndex = 2
        Me.txt_generatedcode.WordWrap = False
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_clear.Location = New System.Drawing.Point(763, 350)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(101, 23)
        Me.btn_clear.TabIndex = 5
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_calculate
        '
        Me.btn_calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_calculate.Location = New System.Drawing.Point(51, 350)
        Me.btn_calculate.Name = "btn_calculate"
        Me.btn_calculate.Size = New System.Drawing.Size(706, 23)
        Me.btn_calculate.TabIndex = 4
        Me.btn_calculate.Text = "Process"
        Me.btn_calculate.UseVisualStyleBackColor = True
        '
        'txt_max
        '
        Me.txt_max.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_max.Location = New System.Drawing.Point(15, 353)
        Me.txt_max.MaxLength = 3
        Me.txt_max.Name = "txt_max"
        Me.txt_max.Size = New System.Drawing.Size(30, 18)
        Me.txt_max.TabIndex = 3
        Me.txt_max.Text = "100"
        Me.txt_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pb_calculate
        '
        Me.pb_calculate.Location = New System.Drawing.Point(51, 350)
        Me.pb_calculate.Name = "pb_calculate"
        Me.pb_calculate.Size = New System.Drawing.Size(706, 23)
        Me.pb_calculate.TabIndex = 7
        '
        'ThrowFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 387)
        Me.Controls.Add(Me.txt_max)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_calculate)
        Me.Controls.Add(Me.txt_generatedcode)
        Me.Controls.Add(Me.lbl_dump)
        Me.Controls.Add(Me.txt_movesetcode)
        Me.Controls.Add(Me.lbl_throw)
        Me.Controls.Add(Me.pb_calculate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ThrowFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculation Dump"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_throw As System.Windows.Forms.Label
    Friend WithEvents txt_movesetcode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_dump As System.Windows.Forms.Label
    Friend WithEvents txt_generatedcode As System.Windows.Forms.TextBox
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_calculate As System.Windows.Forms.Button
    Friend WithEvents txt_max As System.Windows.Forms.TextBox
    Friend WithEvents pb_calculate As System.Windows.Forms.ProgressBar
End Class
