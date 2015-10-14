namespace attackcalculator
{
    partial class VictimFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VictimFrm));
            this.cb_charging = new System.Windows.Forms.CheckBox();
            this.cb_crouchcancel = new System.Windows.Forms.CheckBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.cb_characters = new System.Windows.Forms.ComboBox();
            this.txt_damage = new System.Windows.Forms.TextBox();
            this.lbl_damage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_charging
            // 
            this.cb_charging.AutoSize = true;
            this.cb_charging.Location = new System.Drawing.Point(134, 93);
            this.cb_charging.Name = "cb_charging";
            this.cb_charging.Size = new System.Drawing.Size(137, 17);
            this.cb_charging.TabIndex = 10;
            this.cb_charging.Text = "Charging Smash Attack";
            this.cb_charging.UseVisualStyleBackColor = true;
            // 
            // cb_crouchcancel
            // 
            this.cb_crouchcancel.AutoSize = true;
            this.cb_crouchcancel.Location = new System.Drawing.Point(14, 93);
            this.cb_crouchcancel.Name = "cb_crouchcancel";
            this.cb_crouchcancel.Size = new System.Drawing.Size(110, 17);
            this.cb_crouchcancel.TabIndex = 9;
            this.cb_crouchcancel.Text = "Crouch Canceling";
            this.cb_crouchcancel.UseVisualStyleBackColor = true;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(14, 116);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(257, 23);
            this.btn_confirm.TabIndex = 11;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(115, 50);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 13);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Character";
            // 
            // cb_characters
            // 
            this.cb_characters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_characters.FormattingEnabled = true;
            this.cb_characters.Location = new System.Drawing.Point(14, 66);
            this.cb_characters.Name = "cb_characters";
            this.cb_characters.Size = new System.Drawing.Size(257, 21);
            this.cb_characters.TabIndex = 8;
            // 
            // txt_damage
            // 
            this.txt_damage.Location = new System.Drawing.Point(14, 27);
            this.txt_damage.MaxLength = 3;
            this.txt_damage.Name = "txt_damage";
            this.txt_damage.Size = new System.Drawing.Size(257, 20);
            this.txt_damage.TabIndex = 7;
            this.txt_damage.Text = "0";
            this.txt_damage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_damage
            // 
            this.lbl_damage.AutoSize = true;
            this.lbl_damage.Location = new System.Drawing.Point(118, 11);
            this.lbl_damage.Name = "lbl_damage";
            this.lbl_damage.Size = new System.Drawing.Size(47, 13);
            this.lbl_damage.TabIndex = 12;
            this.lbl_damage.Text = "Damage";
            // 
            // VictimFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.Controls.Add(this.cb_charging);
            this.Controls.Add(this.cb_crouchcancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cb_characters);
            this.Controls.Add(this.txt_damage);
            this.Controls.Add(this.lbl_damage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VictimFrm";
            this.Text = "Settings - Victim";
            this.Load += new System.EventHandler(this.VictimFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox cb_charging;
        internal System.Windows.Forms.CheckBox cb_crouchcancel;
        internal System.Windows.Forms.Button btn_confirm;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cb_characters;
        internal System.Windows.Forms.TextBox txt_damage;
        internal System.Windows.Forms.Label lbl_damage;
    }
}