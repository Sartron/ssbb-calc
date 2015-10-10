using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace attackcalculator
{
    public partial class MainFrm : Form
    {
        #region Menus
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void outputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form OutputFrm = new OutputFrm();
            OutputFrm.Show();
        }
        #endregion
        #region Startup
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            if (!(File.Exists(Application.StartupPath + "calc.dll")))
            {
                //MessageBox.Show("calc.dll does not exist!");
                //Application.Exit();
            }
        }
        #endregion
        #region Text Editor
        private void txt_psa_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cms_main.Show(new Point(MousePosition.X, MousePosition.Y));
                //Can Copy or Cut
                if (string.IsNullOrEmpty(txt_psa.SelectedText))
                {
                    cutToolStripMenuItem.Enabled = false;
                    copyToolStripMenuItem.Enabled = false;
                }
                else
                {
                    cutToolStripMenuItem.Enabled = true;
                    copyToolStripMenuItem.Enabled = true;
                }
                //Can Undo
                if (txt_psa.CanUndo)
                {
                    undoToolStripMenuItem.Enabled = true;
                }
                else
                {
                    undoToolStripMenuItem.Enabled = false;
                }
                //Can Paste
                if (Clipboard.ContainsText(TextDataFormat.Text))
                {
                    pasteToolStripMenuItem.Enabled = true;
                }
                else
                {
                    pasteToolStripMenuItem.Enabled = false;
                }
                //Can Generate Data
                if (String.IsNullOrEmpty(txt_psa.Text.Trim()))
                {
                    generateDataToolStripMenuItem.Enabled = false;
                }
                else
                {
                    generateDataToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_psa.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_psa.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_psa.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                //Contains text
                //Check is PSA code/lines are being pasted
                if (Clipboard.GetText(TextDataFormat.Text).Contains('/') && Clipboard.GetText(TextDataFormat.Text).Contains('\\'))
                {
                    //Split codes
                    String[] codes = Clipboard.GetText(TextDataFormat.Text).Split('/');
                    //Convert code to text and new format
                    foreach (String code in codes)
                    {
                        txt_psa.AppendText(CodetoEvent(code) + "\n");
                    }
                }
                else if (Clipboard.GetText(TextDataFormat.Text).Contains(':') && Clipboard.GetText(TextDataFormat.Text).Contains(',') && Clipboard.GetText(TextDataFormat.Text).Contains("Offensive Collision"))
                {
                    //Split lines
                    string[] lines = Clipboard.GetText(TextDataFormat.Text).Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    //Convert to new format
                    foreach (String line in lines)
                    {
                        txt_psa.AppendText(CodetoEvent(line) + "\n");
                    }
                }
                else
                {
                    //Just paste whatever was there to begin with
                    txt_psa.Paste();
                }
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_psa.SelectAll();
        }

        private void txt_psa_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.V)
            {
                //Paste
                if (Clipboard.ContainsText(TextDataFormat.Text))
                {
                    //Contains text
                    if (Clipboard.GetText(TextDataFormat.Text).Contains('/') && Clipboard.GetText(TextDataFormat.Text).Contains('\\'))
                    {
                        //Split codes
                        String[] codes = Clipboard.GetText(TextDataFormat.Text).Split('/');
                        //Convert code to text and new format
                        foreach (String code in codes)
                        {
                            e.Handled = true;
                            txt_psa.AppendText(CodetoEvent(code) + "\n");
                        }
                    }
                    else if (Clipboard.GetText(TextDataFormat.Text).Contains(':') && Clipboard.GetText(TextDataFormat.Text).Contains(',') && Clipboard.GetText(TextDataFormat.Text).Contains("Offensive Collision"))
                    {
                        //Split codes
                        string[] lines = Clipboard.GetText(TextDataFormat.Text).Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                        //Convert to new format
                        foreach (String line in lines)
                        {
                            e.Handled = true;
                            txt_psa.AppendText(CodetoEvent(line) + "\n");
                        }
                    }
                    else
                    {
                        //Just paste whatever was there to begin with
                        e.Handled = false;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        #endregion
        private string CodetoEvent(String clipboardtext)
        {
            String str_event = String.Empty;
            if (clipboardtext.Contains(':') && clipboardtext.Contains(',') && clipboardtext.Contains("Offensive Collision"))
            {
                //Processed, return what was given
                Boolean bool_special = false;
                if (clipboardtext.Contains("Special Offensive Collision: ") && (clipboardtext.Contains("Rehit Rate") && clipboardtext.Contains("Special Flags")))
                {
                    clipboardtext = clipboardtext.Replace("Special Offensive Collision: ", string.Empty);
                    bool_special = true;
                }
                else if (clipboardtext.Contains("Offensive Collision: "))
                {
                    clipboardtext = clipboardtext.Replace("Offensive Collision: ", string.Empty);
                }
                String[] str_stats = clipboardtext.Split(',');
                if (bool_special)
                {
                    //Special Offensive Collision
                    str_event = "Hitbox: " + str_stats[0] + "," + str_stats[2] + "," + str_stats[3] + "," + str_stats[4] + "," + str_stats[5] + "," + str_stats[6] + "," + str_stats[7] + "," + str_stats[8] + "," + str_stats[13] + "," + str_stats[14] + "," + str_stats[15] + "," + str_stats[16] + "," + str_stats[17];
                }
                else
                {
                    //Offensive Collision
                    str_event = "Hitbox: " + str_stats[0] + "," + str_stats[2] + "," + str_stats[3] + "," + str_stats[4] + "," + str_stats[5] + "," + str_stats[6] + "," + str_stats[7] + "," + str_stats[8] + "," + str_stats[13] + "," + str_stats[14] + "," + str_stats[15];
                }
                return str_event;
            }
            else if (clipboardtext.Contains('|') && clipboardtext.Contains('\\'))
            {
                //Not processed
                String[] str_stats = clipboardtext.Split('|');
                switch (str_stats[0])
                {
                    case "06000D00":
                        //Offensive Collision
                        str_stats[0] = "Hitbox:";
                        break;
                    case "06150F00":
                        //Special Offensive Collision
                        str_stats[0] = "Hitbox:";
                        break;
                }
                //Not functional yet.
                str_event = String.Empty;
            }
            else if (String.IsNullOrEmpty(clipboardtext))
            {
                //Empty string, return nothing
                str_event = String.Empty;
            }
            return str_event;
        }
    }
}
