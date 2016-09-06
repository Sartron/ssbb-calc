<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlagFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FlagFrm))
        Me.lbl_flags = New System.Windows.Forms.Label()
        Me.txt_flags = New System.Windows.Forms.TextBox()
        Me.lbl_hexflags = New System.Windows.Forms.Label()
        Me.txt_hexflags = New System.Windows.Forms.TextBox()
        Me.lbl_binflags = New System.Windows.Forms.Label()
        Me.txt_binflags = New System.Windows.Forms.TextBox()
        Me.btn_convert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_flags
        '
        Me.lbl_flags.AutoSize = True
        Me.lbl_flags.Location = New System.Drawing.Point(112, 9)
        Me.lbl_flags.Name = "lbl_flags"
        Me.lbl_flags.Size = New System.Drawing.Size(88, 13)
        Me.lbl_flags.TabIndex = 1
        Me.lbl_flags.Text = "Decimal Flags - 0"
        '
        'txt_flags
        '
        Me.txt_flags.Location = New System.Drawing.Point(15, 25)
        Me.txt_flags.MaxLength = 36
        Me.txt_flags.Name = "txt_flags"
        Me.txt_flags.Size = New System.Drawing.Size(275, 20)
        Me.txt_flags.TabIndex = 2
        Me.txt_flags.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_hexflags
        '
        Me.lbl_hexflags.AutoSize = True
        Me.lbl_hexflags.Location = New System.Drawing.Point(102, 48)
        Me.lbl_hexflags.Name = "lbl_hexflags"
        Me.lbl_hexflags.Size = New System.Drawing.Size(107, 13)
        Me.lbl_hexflags.TabIndex = 3
        Me.lbl_hexflags.Text = "Hexidecimal Flags - 0"
        '
        'txt_hexflags
        '
        Me.txt_hexflags.Location = New System.Drawing.Point(15, 64)
        Me.txt_hexflags.MaxLength = 36
        Me.txt_hexflags.Name = "txt_hexflags"
        Me.txt_hexflags.ReadOnly = True
        Me.txt_hexflags.Size = New System.Drawing.Size(275, 20)
        Me.txt_hexflags.TabIndex = 4
        Me.txt_hexflags.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_binflags
        '
        Me.lbl_binflags.AutoSize = True
        Me.lbl_binflags.Location = New System.Drawing.Point(112, 87)
        Me.lbl_binflags.Name = "lbl_binflags"
        Me.lbl_binflags.Size = New System.Drawing.Size(79, 13)
        Me.lbl_binflags.TabIndex = 5
        Me.lbl_binflags.Text = "Binary Flags - 0"
        '
        'txt_binflags
        '
        Me.txt_binflags.Location = New System.Drawing.Point(15, 103)
        Me.txt_binflags.MaxLength = 36
        Me.txt_binflags.Name = "txt_binflags"
        Me.txt_binflags.ReadOnly = True
        Me.txt_binflags.Size = New System.Drawing.Size(275, 20)
        Me.txt_binflags.TabIndex = 6
        Me.txt_binflags.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_convert
        '
        Me.btn_convert.Enabled = False
        Me.btn_convert.Location = New System.Drawing.Point(15, 129)
        Me.btn_convert.Name = "btn_convert"
        Me.btn_convert.Size = New System.Drawing.Size(275, 23)
        Me.btn_convert.TabIndex = 7
        Me.btn_convert.Text = "Convert"
        Me.btn_convert.UseVisualStyleBackColor = True
        '
        'FlagFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 166)
        Me.Controls.Add(Me.btn_convert)
        Me.Controls.Add(Me.txt_binflags)
        Me.Controls.Add(Me.lbl_binflags)
        Me.Controls.Add(Me.txt_hexflags)
        Me.Controls.Add(Me.lbl_hexflags)
        Me.Controls.Add(Me.txt_flags)
        Me.Controls.Add(Me.lbl_flags)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FlagFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flag Analyzer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_flags As System.Windows.Forms.Label
    Friend WithEvents txt_flags As System.Windows.Forms.TextBox
    Friend WithEvents lbl_hexflags As System.Windows.Forms.Label
    Friend WithEvents txt_hexflags As System.Windows.Forms.TextBox
    Friend WithEvents lbl_binflags As System.Windows.Forms.Label
    Friend WithEvents txt_binflags As System.Windows.Forms.TextBox
    Friend WithEvents btn_convert As System.Windows.Forms.Button
End Class
