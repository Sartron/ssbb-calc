namespace attackcalculator
{
    partial class MainFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.victimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advantageCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargeSmashAttackCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.generateDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tc_tabs = new System.Windows.Forms.TabControl();
            this.tp_psacode = new System.Windows.Forms.TabPage();
            this.txt_psa = new System.Windows.Forms.RichTextBox();
            this.tp_stats = new System.Windows.Forms.TabPage();
            this.txt_generatedstats = new System.Windows.Forms.RichTextBox();
            this.ms_main.SuspendLayout();
            this.cms_main.SuspendLayout();
            this.tc_tabs.SuspendLayout();
            this.tp_psacode.SuspendLayout();
            this.tp_stats.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_main
            // 
            this.ms_main.BackColor = System.Drawing.SystemColors.Control;
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(784, 24);
            this.ms_main.TabIndex = 0;
            this.ms_main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputToolStripMenuItem,
            this.victimToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // outputToolStripMenuItem
            // 
            this.outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            this.outputToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.outputToolStripMenuItem.Text = "Output";
            this.outputToolStripMenuItem.Click += new System.EventHandler(this.outputToolStripMenuItem_Click);
            // 
            // victimToolStripMenuItem
            // 
            this.victimToolStripMenuItem.Name = "victimToolStripMenuItem";
            this.victimToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.victimToolStripMenuItem.Text = "Victim";
            this.victimToolStripMenuItem.Click += new System.EventHandler(this.victimToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advantageCalculatorToolStripMenuItem,
            this.chargeSmashAttackCalculatorToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // advantageCalculatorToolStripMenuItem
            // 
            this.advantageCalculatorToolStripMenuItem.Name = "advantageCalculatorToolStripMenuItem";
            this.advantageCalculatorToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.advantageCalculatorToolStripMenuItem.Text = "Advantage Calculator";
            this.advantageCalculatorToolStripMenuItem.Click += new System.EventHandler(this.advantageCalculatorToolStripMenuItem_Click);
            // 
            // chargeSmashAttackCalculatorToolStripMenuItem
            // 
            this.chargeSmashAttackCalculatorToolStripMenuItem.Name = "chargeSmashAttackCalculatorToolStripMenuItem";
            this.chargeSmashAttackCalculatorToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.chargeSmashAttackCalculatorToolStripMenuItem.Text = "Charge Smash Attack Calculator";
            this.chargeSmashAttackCalculatorToolStripMenuItem.Click += new System.EventHandler(this.chargeSmashAttackCalculatorToolStripMenuItem_Click);
            // 
            // cms_main
            // 
            this.cms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.toolStripSeparator1,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator2,
            this.selectAllToolStripMenuItem,
            this.toolStripSeparator3,
            this.generateDataToolStripMenuItem});
            this.cms_main.Name = "cms_main";
            this.cms_main.Size = new System.Drawing.Size(149, 154);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(145, 6);
            // 
            // generateDataToolStripMenuItem
            // 
            this.generateDataToolStripMenuItem.Name = "generateDataToolStripMenuItem";
            this.generateDataToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.generateDataToolStripMenuItem.Text = "Generate Data";
            this.generateDataToolStripMenuItem.Click += new System.EventHandler(this.generateDataToolStripMenuItem_Click);
            // 
            // tc_tabs
            // 
            this.tc_tabs.Controls.Add(this.tp_psacode);
            this.tc_tabs.Controls.Add(this.tp_stats);
            this.tc_tabs.Location = new System.Drawing.Point(0, 24);
            this.tc_tabs.Name = "tc_tabs";
            this.tc_tabs.SelectedIndex = 0;
            this.tc_tabs.Size = new System.Drawing.Size(786, 219);
            this.tc_tabs.TabIndex = 2;
            // 
            // tp_psacode
            // 
            this.tp_psacode.Controls.Add(this.txt_psa);
            this.tp_psacode.Location = new System.Drawing.Point(4, 22);
            this.tp_psacode.Name = "tp_psacode";
            this.tp_psacode.Padding = new System.Windows.Forms.Padding(3);
            this.tp_psacode.Size = new System.Drawing.Size(778, 193);
            this.tp_psacode.TabIndex = 0;
            this.tp_psacode.Text = "PSA Code";
            this.tp_psacode.UseVisualStyleBackColor = true;
            // 
            // txt_psa
            // 
            this.txt_psa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_psa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_psa.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_psa.Location = new System.Drawing.Point(3, 3);
            this.txt_psa.Name = "txt_psa";
            this.txt_psa.Size = new System.Drawing.Size(772, 187);
            this.txt_psa.TabIndex = 3;
            this.txt_psa.Text = "";
            this.txt_psa.WordWrap = false;
            this.txt_psa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_psa_KeyDown);
            this.txt_psa.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txt_psa_MouseUp);
            // 
            // tp_stats
            // 
            this.tp_stats.Controls.Add(this.txt_generatedstats);
            this.tp_stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_stats.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tp_stats.Location = new System.Drawing.Point(4, 22);
            this.tp_stats.Name = "tp_stats";
            this.tp_stats.Padding = new System.Windows.Forms.Padding(3);
            this.tp_stats.Size = new System.Drawing.Size(778, 193);
            this.tp_stats.TabIndex = 1;
            this.tp_stats.Text = "Generated Stats";
            this.tp_stats.UseVisualStyleBackColor = true;
            // 
            // txt_generatedstats
            // 
            this.txt_generatedstats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_generatedstats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_generatedstats.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_generatedstats.Location = new System.Drawing.Point(3, 3);
            this.txt_generatedstats.Name = "txt_generatedstats";
            this.txt_generatedstats.Size = new System.Drawing.Size(772, 187);
            this.txt_generatedstats.TabIndex = 4;
            this.txt_generatedstats.Text = "";
            this.txt_generatedstats.WordWrap = false;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 242);
            this.Controls.Add(this.tc_tabs);
            this.Controls.Add(this.ms_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_main;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Text = "Attack Calculator";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            this.cms_main.ResumeLayout(false);
            this.tc_tabs.ResumeLayout(false);
            this.tp_psacode.ResumeLayout(false);
            this.tp_stats.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advantageCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargeSmashAttackCalculatorToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cms_main;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem generateDataToolStripMenuItem;
        private System.Windows.Forms.TabControl tc_tabs;
        private System.Windows.Forms.TabPage tp_psacode;
        private System.Windows.Forms.RichTextBox txt_psa;
        private System.Windows.Forms.TabPage tp_stats;
        private System.Windows.Forms.RichTextBox txt_generatedstats;
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem victimToolStripMenuItem;
    }
}

