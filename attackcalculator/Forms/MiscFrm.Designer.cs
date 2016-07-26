namespace attackcalculator
{
    partial class MiscFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiscFrm));
            this.comboMode = new System.Windows.Forms.ComboBox();
            this.lblValue1 = new System.Windows.Forms.Label();
            this.panelSeparator = new System.Windows.Forms.Panel();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.txtValue3 = new System.Windows.Forms.TextBox();
            this.lblValue3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboMode
            // 
            this.comboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMode.FormattingEnabled = true;
            this.comboMode.Items.AddRange(new object[] {
            "Advantage Calculator",
            "Aerial Advantage Calculator",
            "Aerial Auto-cancel Advantage Calculator",
            "Charged Smash Attack Calculator"});
            this.comboMode.Location = new System.Drawing.Point(12, 12);
            this.comboMode.Name = "comboMode";
            this.comboMode.Size = new System.Drawing.Size(373, 21);
            this.comboMode.TabIndex = 0;
            this.comboMode.SelectedIndexChanged += new System.EventHandler(this.comboMode_SelectedIndexChanged);
            // 
            // lblValue1
            // 
            this.lblValue1.AutoSize = true;
            this.lblValue1.Location = new System.Drawing.Point(12, 43);
            this.lblValue1.Name = "lblValue1";
            this.lblValue1.Size = new System.Drawing.Size(40, 13);
            this.lblValue1.TabIndex = 6;
            this.lblValue1.Text = "Value1";
            // 
            // panelSeparator
            // 
            this.panelSeparator.BackColor = System.Drawing.Color.DarkGray;
            this.panelSeparator.Location = new System.Drawing.Point(12, 38);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(373, 1);
            this.panelSeparator.TabIndex = 5;
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(12, 59);
            this.txtValue1.MaxLength = 8;
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(84, 20);
            this.txtValue1.TabIndex = 1;
            this.txtValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValue1.TextChanged += new System.EventHandler(this.txtValue1_TextChanged);
            this.txtValue1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue1_KeyPress);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(285, 59);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(100, 20);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(282, 43);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 9;
            this.lblOutput.Text = "Output";
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(105, 59);
            this.txtValue2.MaxLength = 8;
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(84, 20);
            this.txtValue2.TabIndex = 2;
            this.txtValue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValue2.TextChanged += new System.EventHandler(this.txtValue2_TextChanged);
            this.txtValue2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue2_KeyPress);
            // 
            // lblValue2
            // 
            this.lblValue2.AutoSize = true;
            this.lblValue2.Location = new System.Drawing.Point(102, 43);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(40, 13);
            this.lblValue2.TabIndex = 7;
            this.lblValue2.Text = "Value2";
            // 
            // txtValue3
            // 
            this.txtValue3.Location = new System.Drawing.Point(195, 59);
            this.txtValue3.MaxLength = 8;
            this.txtValue3.Name = "txtValue3";
            this.txtValue3.Size = new System.Drawing.Size(84, 20);
            this.txtValue3.TabIndex = 3;
            this.txtValue3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValue3.TextChanged += new System.EventHandler(this.txtValue3_TextChanged);
            this.txtValue3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue3_KeyPress);
            // 
            // lblValue3
            // 
            this.lblValue3.AutoSize = true;
            this.lblValue3.Location = new System.Drawing.Point(192, 43);
            this.lblValue3.Name = "lblValue3";
            this.lblValue3.Size = new System.Drawing.Size(40, 13);
            this.lblValue3.TabIndex = 8;
            this.lblValue3.Text = "Value3";
            // 
            // MiscFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 93);
            this.Controls.Add(this.txtValue3);
            this.Controls.Add(this.lblValue3);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.panelSeparator);
            this.Controls.Add(this.lblValue1);
            this.Controls.Add(this.comboMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MiscFrm";
            this.Text = "Viewing index {0}";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMode;
        private System.Windows.Forms.Label lblValue1;
        private System.Windows.Forms.Panel panelSeparator;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.TextBox txtValue3;
        private System.Windows.Forms.Label lblValue3;
    }
}