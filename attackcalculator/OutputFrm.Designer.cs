namespace attackcalculator
{
    partial class OutputFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutputFrm));
            this.cb_output = new System.Windows.Forms.ComboBox();
            this.lbl_output = new System.Windows.Forms.Label();
            this.lbl_outputvariable = new System.Windows.Forms.Label();
            this.txt_outputvariable = new System.Windows.Forms.TextBox();
            this.btn_savevariable = new System.Windows.Forms.Button();
            this.cb_enabled = new System.Windows.Forms.CheckBox();
            this.txt_outputformat = new System.Windows.Forms.TextBox();
            this.lbl_outputformat = new System.Windows.Forms.Label();
            this.panel_separator = new System.Windows.Forms.Panel();
            this.btn_saveoutputformat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_output
            // 
            this.cb_output.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_output.FormattingEnabled = true;
            this.cb_output.Items.AddRange(new object[] {
            "ID",
            "Size",
            "Damage",
            "Shield Damage",
            "Angle",
            "Knockback Units",
            "Base Knockback",
            "Weight Dependent Set Knockback",
            "Knockback Growth",
            "Hitlag Multiplier",
            "SDI Multiplier",
            "Clang",
            "Target",
            "Effect",
            "Hitstun",
            "Shieldstun",
            "Hitlag",
            "Hitlag Advantage",
            "Absorbability",
            "Reflectability",
            "Launch Speed"});
            this.cb_output.Location = new System.Drawing.Point(15, 25);
            this.cb_output.Name = "cb_output";
            this.cb_output.Size = new System.Drawing.Size(327, 21);
            this.cb_output.TabIndex = 0;
            this.cb_output.SelectedIndexChanged += new System.EventHandler(this.cb_output_SelectedIndexChanged);
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(12, 9);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(39, 13);
            this.lbl_output.TabIndex = 1;
            this.lbl_output.Text = "Output";
            // 
            // lbl_outputvariable
            // 
            this.lbl_outputvariable.AutoSize = true;
            this.lbl_outputvariable.Location = new System.Drawing.Point(12, 49);
            this.lbl_outputvariable.Name = "lbl_outputvariable";
            this.lbl_outputvariable.Size = new System.Drawing.Size(45, 13);
            this.lbl_outputvariable.TabIndex = 2;
            this.lbl_outputvariable.Text = "Variable";
            // 
            // txt_outputvariable
            // 
            this.txt_outputvariable.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_outputvariable.Location = new System.Drawing.Point(15, 65);
            this.txt_outputvariable.Name = "txt_outputvariable";
            this.txt_outputvariable.Size = new System.Drawing.Size(327, 19);
            this.txt_outputvariable.TabIndex = 3;
            this.txt_outputvariable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_outputvariable.TextChanged += new System.EventHandler(this.txt_outputvariable_TextChanged);
            // 
            // btn_savevariable
            // 
            this.btn_savevariable.Location = new System.Drawing.Point(15, 91);
            this.btn_savevariable.Name = "btn_savevariable";
            this.btn_savevariable.Size = new System.Drawing.Size(327, 23);
            this.btn_savevariable.TabIndex = 4;
            this.btn_savevariable.Text = "Save Variable";
            this.btn_savevariable.UseVisualStyleBackColor = true;
            this.btn_savevariable.Click += new System.EventHandler(this.btn_savevariable_Click);
            // 
            // cb_enabled
            // 
            this.cb_enabled.AutoSize = true;
            this.cb_enabled.Location = new System.Drawing.Point(348, 29);
            this.cb_enabled.Name = "cb_enabled";
            this.cb_enabled.Size = new System.Drawing.Size(15, 14);
            this.cb_enabled.TabIndex = 5;
            this.cb_enabled.UseVisualStyleBackColor = true;
            this.cb_enabled.CheckedChanged += new System.EventHandler(this.cb_enabled_CheckedChanged);
            // 
            // txt_outputformat
            // 
            this.txt_outputformat.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_outputformat.Location = new System.Drawing.Point(15, 140);
            this.txt_outputformat.Name = "txt_outputformat";
            this.txt_outputformat.Size = new System.Drawing.Size(327, 19);
            this.txt_outputformat.TabIndex = 6;
            this.txt_outputformat.Text = "id|dmg|angle|bkb/wdsk/kbg";
            // 
            // lbl_outputformat
            // 
            this.lbl_outputformat.AutoSize = true;
            this.lbl_outputformat.Location = new System.Drawing.Point(12, 124);
            this.lbl_outputformat.Name = "lbl_outputformat";
            this.lbl_outputformat.Size = new System.Drawing.Size(74, 13);
            this.lbl_outputformat.TabIndex = 7;
            this.lbl_outputformat.Text = "Output Format";
            // 
            // panel_separator
            // 
            this.panel_separator.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_separator.Location = new System.Drawing.Point(15, 120);
            this.panel_separator.Name = "panel_separator";
            this.panel_separator.Size = new System.Drawing.Size(328, 1);
            this.panel_separator.TabIndex = 8;
            // 
            // btn_saveoutputformat
            // 
            this.btn_saveoutputformat.Location = new System.Drawing.Point(15, 166);
            this.btn_saveoutputformat.Name = "btn_saveoutputformat";
            this.btn_saveoutputformat.Size = new System.Drawing.Size(327, 23);
            this.btn_saveoutputformat.TabIndex = 9;
            this.btn_saveoutputformat.Text = "Save Output Formatting";
            this.btn_saveoutputformat.UseVisualStyleBackColor = true;
            this.btn_saveoutputformat.Click += new System.EventHandler(this.btn_saveoutputformat_Click);
            // 
            // OutputFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 200);
            this.Controls.Add(this.btn_saveoutputformat);
            this.Controls.Add(this.panel_separator);
            this.Controls.Add(this.lbl_outputformat);
            this.Controls.Add(this.txt_outputformat);
            this.Controls.Add(this.cb_enabled);
            this.Controls.Add(this.btn_savevariable);
            this.Controls.Add(this.txt_outputvariable);
            this.Controls.Add(this.lbl_outputvariable);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.cb_output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OutputFrm";
            this.Text = "Settings - Output";
            this.Load += new System.EventHandler(this.OutputFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_output;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Label lbl_outputvariable;
        private System.Windows.Forms.TextBox txt_outputvariable;
        private System.Windows.Forms.Button btn_savevariable;
        private System.Windows.Forms.CheckBox cb_enabled;
        private System.Windows.Forms.TextBox txt_outputformat;
        private System.Windows.Forms.Label lbl_outputformat;
        private System.Windows.Forms.Panel panel_separator;
        private System.Windows.Forms.Button btn_saveoutputformat;
    }
}