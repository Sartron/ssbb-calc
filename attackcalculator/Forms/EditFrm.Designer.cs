namespace attackcalculator
{
    partial class EditFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFrm));
            this.listParameters = new System.Windows.Forms.ListBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.comboValue = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listParameters
            // 
            this.listParameters.FormattingEnabled = true;
            this.listParameters.Location = new System.Drawing.Point(12, 12);
            this.listParameters.Name = "listParameters";
            this.listParameters.Size = new System.Drawing.Size(126, 238);
            this.listParameters.TabIndex = 64;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(144, 12);
            this.txtValue.MaxLength = 2147483647;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(142, 20);
            this.txtValue.TabIndex = 65;
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboValue
            // 
            this.comboValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboValue.FormattingEnabled = true;
            this.comboValue.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboValue.Location = new System.Drawing.Point(144, 38);
            this.comboValue.Name = "comboValue";
            this.comboValue.Size = new System.Drawing.Size(142, 21);
            this.comboValue.TabIndex = 66;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(144, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 23);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 262);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboValue);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.listParameters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditFrm";
            this.Text = "Editing index {0}";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listParameters;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox comboValue;
        private System.Windows.Forms.Button btnSave;
    }
}