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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.victimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tc_tabs = new System.Windows.Forms.TabControl();
            this.tp_psacode = new System.Windows.Forms.TabPage();
            this.lB_psa = new System.Windows.Forms.ListBox();
            this.ts_psacode = new System.Windows.Forms.ToolStrip();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.btnCut = new System.Windows.Forms.ToolStripButton();
            this.btnPaste = new System.Windows.Forms.ToolStripButton();
            this.btnCopyText = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConvert = new System.Windows.Forms.ToolStripButton();
            this.btnMiscCalc = new System.Windows.Forms.ToolStripButton();
            this.tp_data = new System.Windows.Forms.TabPage();
            this.lB_generatedData = new System.Windows.Forms.ListBox();
            this.ts_generatedStats = new System.Windows.Forms.ToolStrip();
            this._btnCopy = new System.Windows.Forms.ToolStripButton();
            this._btnCut = new System.Windows.Forms.ToolStripButton();
            this.btnRemove = new System.Windows.Forms.ToolStripButton();
            this.btnClearAll = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ms_main.SuspendLayout();
            this.tc_tabs.SuspendLayout();
            this.tp_psacode.SuspendLayout();
            this.ts_psacode.SuspendLayout();
            this.tp_data.SuspendLayout();
            this.ts_generatedStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_main
            // 
            this.ms_main.BackColor = System.Drawing.SystemColors.Control;
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // tc_tabs
            // 
            this.tc_tabs.Controls.Add(this.tp_psacode);
            this.tc_tabs.Controls.Add(this.tp_data);
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
            this.lB_psa.SelectedIndexChanged += new System.EventHandler(this.lB_psa_SelectedIndexChanged);
            this.lB_psa.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lB_psa_MouseUp);
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
            this.toolStripSeparator2,
            this.btnConvert,
            this.btnMiscCalc,
            this.toolStripSeparator3,
            this.btnDeleteAll});
            this.ts_psacode.Location = new System.Drawing.Point(3, 3);
            this.ts_psacode.Name = "ts_psacode";
            this.ts_psacode.Size = new System.Drawing.Size(772, 25);
            this.ts_psacode.TabIndex = 0;
            this.ts_psacode.Text = "ts_psacode";
            // 
            // btnCopy
            // 
            this.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCopy.Enabled = false;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(39, 22);
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCut
            // 
            this.btnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCut.Enabled = false;
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(30, 22);
            this.btnCut.Text = "Cut";
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(39, 22);
            this.btnPaste.Text = "Paste";
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopyText
            // 
            this.btnCopyText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCopyText.Enabled = false;
            this.btnCopyText.Name = "btnCopyText";
            this.btnCopyText.Size = new System.Drawing.Size(63, 22);
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
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 22);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEdit.Enabled = false;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(31, 22);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Enabled = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnConvert
            // 
            this.btnConvert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnConvert.Enabled = false;
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(85, 22);
            this.btnConvert.Text = "Generate Data";
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnMiscCalc
            // 
            this.btnMiscCalc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMiscCalc.Enabled = false;
            this.btnMiscCalc.Name = "btnMiscCalc";
            this.btnMiscCalc.Size = new System.Drawing.Size(86, 22);
            this.btnMiscCalc.Text = "Miscellaneous";
            this.btnMiscCalc.Click += new System.EventHandler(this.btnMiscCalc_Click);
            // 
            // tp_data
            // 
            this.tp_data.Controls.Add(this.lB_generatedData);
            this.tp_data.Controls.Add(this.ts_generatedStats);
            this.tp_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_data.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tp_data.Location = new System.Drawing.Point(4, 22);
            this.tp_data.Name = "tp_data";
            this.tp_data.Padding = new System.Windows.Forms.Padding(3);
            this.tp_data.Size = new System.Drawing.Size(778, 193);
            this.tp_data.TabIndex = 1;
            this.tp_data.Text = "Generated Data";
            this.tp_data.UseVisualStyleBackColor = true;
            // 
            // lB_generatedData
            // 
            this.lB_generatedData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lB_generatedData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lB_generatedData.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lB_generatedData.FormattingEnabled = true;
            this.lB_generatedData.HorizontalScrollbar = true;
            this.lB_generatedData.Location = new System.Drawing.Point(3, 28);
            this.lB_generatedData.Name = "lB_generatedData";
            this.lB_generatedData.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lB_generatedData.Size = new System.Drawing.Size(772, 162);
            this.lB_generatedData.TabIndex = 3;
            this.lB_generatedData.SelectedIndexChanged += new System.EventHandler(this.lB_generatedStats_SelectedIndexChanged);
            // 
            // ts_generatedStats
            // 
            this.ts_generatedStats.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_generatedStats.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._btnCopy,
            this._btnCut,
            this.btnRemove,
            this.btnClearAll});
            this.ts_generatedStats.Location = new System.Drawing.Point(3, 3);
            this.ts_generatedStats.Name = "ts_generatedStats";
            this.ts_generatedStats.Size = new System.Drawing.Size(772, 25);
            this.ts_generatedStats.TabIndex = 2;
            this.ts_generatedStats.Text = "toolStrip1";
            // 
            // _btnCopy
            // 
            this._btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._btnCopy.Enabled = false;
            this._btnCopy.Name = "_btnCopy";
            this._btnCopy.Size = new System.Drawing.Size(39, 22);
            this._btnCopy.Text = "Copy";
            this._btnCopy.Click += new System.EventHandler(this._btnCopy_Click);
            // 
            // _btnCut
            // 
            this._btnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._btnCut.Enabled = false;
            this._btnCut.Name = "_btnCut";
            this._btnCut.Size = new System.Drawing.Size(30, 22);
            this._btnCut.Text = "Cut";
            this._btnCut.Click += new System.EventHandler(this._btnCut_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRemove.Enabled = false;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(54, 22);
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClearAll.Enabled = false;
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(55, 22);
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteAll.Enabled = false;
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(61, 22);
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            this.tp_data.ResumeLayout(false);
            this.tp_data.PerformLayout();
            this.ts_generatedStats.ResumeLayout(false);
            this.ts_generatedStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TabControl tc_tabs;
        private System.Windows.Forms.TabPage tp_psacode;
        private System.Windows.Forms.TabPage tp_data;
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem victimToolStripMenuItem;
        private System.Windows.Forms.ListBox lB_psa;
        private System.Windows.Forms.ToolStrip ts_psacode;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ToolStripButton btnCut;
        private System.Windows.Forms.ToolStripButton btnPaste;
        private System.Windows.Forms.ToolStripButton btnCopyText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnConvert;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ListBox lB_generatedData;
        private System.Windows.Forms.ToolStrip ts_generatedStats;
        private System.Windows.Forms.ToolStripButton _btnCopy;
        private System.Windows.Forms.ToolStripButton _btnCut;
        private System.Windows.Forms.ToolStripButton btnRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnMiscCalc;
        private System.Windows.Forms.ToolStripButton btnClearAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnDeleteAll;
    }
}

