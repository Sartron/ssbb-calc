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
            this.miscellaneousCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tc_tabs = new System.Windows.Forms.TabControl();
            this.tp_psacode = new System.Windows.Forms.TabPage();
            this.lB_psa = new System.Windows.Forms.ListBox();
            this.ts_psacode = new System.Windows.Forms.ToolStrip();
            this.btnCopy = new System.Windows.Forms.ToolStripLabel();
            this.btnCut = new System.Windows.Forms.ToolStripLabel();
            this.btnPaste = new System.Windows.Forms.ToolStripLabel();
            this.btnCopyText = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripLabel();
            this.btnEdit = new System.Windows.Forms.ToolStripLabel();
            this.btnDelete = new System.Windows.Forms.ToolStripLabel();
            this.btnConvert = new System.Windows.Forms.ToolStripLabel();
            this.tp_stats = new System.Windows.Forms.TabPage();
            this.txt_generatedstats = new System.Windows.Forms.RichTextBox();
            this.cms_generated = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cleanUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_main.SuspendLayout();
            this.tc_tabs.SuspendLayout();
            this.tp_psacode.SuspendLayout();
            this.ts_psacode.SuspendLayout();
            this.tp_stats.SuspendLayout();
            this.cms_generated.SuspendLayout();
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
            this.miscellaneousCalculatorToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // miscellaneousCalculatorToolStripMenuItem
            // 
            this.miscellaneousCalculatorToolStripMenuItem.Name = "miscellaneousCalculatorToolStripMenuItem";
            this.miscellaneousCalculatorToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.miscellaneousCalculatorToolStripMenuItem.Text = "Miscellaneous Calculator";
            this.miscellaneousCalculatorToolStripMenuItem.Click += new System.EventHandler(this.miscellaneousCalculatorToolStripMenuItem_Click);
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
            this.tp_psacode.Controls.Add(this.lB_psa);
            this.tp_psacode.Controls.Add(this.ts_psacode);
            this.tp_psacode.Location = new System.Drawing.Point(4, 22);
            this.tp_psacode.Name = "tp_psacode";
            this.tp_psacode.Padding = new System.Windows.Forms.Padding(3);
            this.tp_psacode.Size = new System.Drawing.Size(778, 193);
            this.tp_psacode.TabIndex = 0;
            this.tp_psacode.Text = "PSA Code";
            this.tp_psacode.UseVisualStyleBackColor = true;
            // 
            // lB_psa
            // 
            this.lB_psa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lB_psa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lB_psa.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lB_psa.FormattingEnabled = true;
            this.lB_psa.HorizontalScrollbar = true;
            this.lB_psa.Location = new System.Drawing.Point(3, 28);
            this.lB_psa.Name = "lB_psa";
            this.lB_psa.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lB_psa.Size = new System.Drawing.Size(772, 162);
            this.lB_psa.TabIndex = 1;
            // 
            // ts_psacode
            // 
            this.ts_psacode.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_psacode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCopy,
            this.btnCut,
            this.btnPaste,
            this.btnCopyText,
            this.toolStripSeparator1,
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.btnConvert});
            this.ts_psacode.Location = new System.Drawing.Point(3, 3);
            this.ts_psacode.Name = "ts_psacode";
            this.ts_psacode.Size = new System.Drawing.Size(772, 25);
            this.ts_psacode.TabIndex = 0;
            this.ts_psacode.Text = "ts_psacode";
            // 
            // btnCopy
            // 
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(35, 22);
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCut
            // 
            this.btnCut.Enabled = false;
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(26, 22);
            this.btnCut.Text = "Cut";
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(35, 22);
            this.btnPaste.Text = "Paste";
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopyText
            // 
            this.btnCopyText.Name = "btnCopyText";
            this.btnCopyText.Size = new System.Drawing.Size(59, 22);
            this.btnCopyText.Text = "Copy Text";
            this.btnCopyText.Click += new System.EventHandler(this.btnCopyText_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(29, 22);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(27, 22);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(81, 22);
            this.btnConvert.Text = "Generate Data";
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
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
            this.txt_generatedstats.ContextMenuStrip = this.cms_generated;
            this.txt_generatedstats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_generatedstats.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_generatedstats.Location = new System.Drawing.Point(3, 3);
            this.txt_generatedstats.Name = "txt_generatedstats";
            this.txt_generatedstats.Size = new System.Drawing.Size(772, 187);
            this.txt_generatedstats.TabIndex = 4;
            this.txt_generatedstats.Text = "";
            this.txt_generatedstats.WordWrap = false;
            // 
            // cms_generated
            // 
            this.cms_generated.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cleanUpToolStripMenuItem});
            this.cms_generated.Name = "cms_generated";
            this.cms_generated.Size = new System.Drawing.Size(165, 26);
            // 
            // cleanUpToolStripMenuItem
            // 
            this.cleanUpToolStripMenuItem.Name = "cleanUpToolStripMenuItem";
            this.cleanUpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.cleanUpToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cleanUpToolStripMenuItem.Text = "Clean Up";
            this.cleanUpToolStripMenuItem.Click += new System.EventHandler(this.cleanUpToolStripMenuItem_Click);
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
            this.tc_tabs.ResumeLayout(false);
            this.tp_psacode.ResumeLayout(false);
            this.tp_psacode.PerformLayout();
            this.ts_psacode.ResumeLayout(false);
            this.ts_psacode.PerformLayout();
            this.tp_stats.ResumeLayout(false);
            this.cms_generated.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.TabControl tc_tabs;
        private System.Windows.Forms.TabPage tp_psacode;
        private System.Windows.Forms.TabPage tp_stats;
        private System.Windows.Forms.RichTextBox txt_generatedstats;
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem victimToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cms_generated;
        private System.Windows.Forms.ToolStripMenuItem cleanUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miscellaneousCalculatorToolStripMenuItem;
        private System.Windows.Forms.ListBox lB_psa;
        private System.Windows.Forms.ToolStrip ts_psacode;
        private System.Windows.Forms.ToolStripLabel btnCopy;
        private System.Windows.Forms.ToolStripLabel btnCut;
        private System.Windows.Forms.ToolStripLabel btnPaste;
        private System.Windows.Forms.ToolStripLabel btnCopyText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel btnEdit;
        private System.Windows.Forms.ToolStripLabel btnConvert;
        private System.Windows.Forms.ToolStripLabel btnAdd;
        private System.Windows.Forms.ToolStripLabel btnDelete;
    }
}

