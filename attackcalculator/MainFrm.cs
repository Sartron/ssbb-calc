using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace attackcalculator
{
    public partial class MainFrm : Form
    {
        #region Startup
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            if (!(Calculator.Settings.bool_xmlexists()))
            {
                Calculator.Settings.createxml();
            }
        }
        #endregion
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


        private void victimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form VictimFrm = new VictimFrm();
            VictimFrm.Show();
        }

        private void advantageCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chargeSmashAttackCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                    //Split codes, remove empty array entries
                    String[] codes = Clipboard.GetText(TextDataFormat.Text).Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                    //Convert code to text and new format
                    foreach (String code in codes)
                    {
                        txt_psa.AppendText(CodetoEvent(code) + "\n");
                    }
                }
                else if (Clipboard.GetText(TextDataFormat.Text).Contains(':') && Clipboard.GetText(TextDataFormat.Text).Contains(',') && Clipboard.GetText(TextDataFormat.Text).Contains("Offensive Collision"))
                {
                    //Split lines, remove empty array entries
                    string[] lines = Clipboard.GetText(TextDataFormat.Text).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
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
                        //Split codes, remove empty array entries
                        String[] codes = Clipboard.GetText(TextDataFormat.Text).Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                        //Convert code to text and new format
                        foreach (String code in codes)
                        {
                            e.Handled = true;
                            txt_psa.AppendText(CodetoEvent(code) + "\n");
                        }
                    }
                    else if (Clipboard.GetText(TextDataFormat.Text).Contains(':') && Clipboard.GetText(TextDataFormat.Text).Contains(',') && Clipboard.GetText(TextDataFormat.Text).Contains("Offensive Collision"))
                    {
                        //Split lines, remove empty array entries
                        string[] lines = Clipboard.GetText(TextDataFormat.Text).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
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
        #region Functions
        private string CodetoEvent(string clipboardtext)
        {
            string str_event = String.Empty;
            if (clipboardtext.Contains(':') && clipboardtext.Contains(',') && clipboardtext.Contains("Offensive Collision"))
            {
                //Processed, return what was given
                Boolean bool_special = false;
                if (clipboardtext.Contains("Special Offensive Collision: ") && (clipboardtext.Contains("Rehit Rate") && clipboardtext.Contains("Special Flags")))
                {
                    clipboardtext = clipboardtext.Replace("Special Offensive Collision: ", String.Empty);
                    bool_special = true;
                }
                else if (clipboardtext.Contains("Offensive Collision: "))
                {
                    clipboardtext = clipboardtext.Replace("Offensive Collision: ", String.Empty);
                }
                if (clipboardtext.Contains('\t'))
                {
                    clipboardtext = Regex.Replace(clipboardtext, @"\t", String.Empty);
                }
                string[] str_stats = clipboardtext.Split(',');
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
                string[] str_stats = clipboardtext.Split('|');
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

        private string EventToStat(string line, int stat)
        {
            //Check if line is a hitbox
            if (!(line.Contains(':') && line.Contains(',') && line.Contains("Hitbox:")))
            {
                //Line isn't hitbox, exit function
                return String.Empty;
            }
            string[] str_stat = line.Split(',');
            str_stat[stat] = str_stat[stat].Trim();
            str_stat[stat] = Regex.Replace(str_stat[stat], "[^0-9.]", String.Empty);
            return str_stat[stat];
        }
        #endregion

        private void generateDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Split lines
            string[] str_txtpsalines = txt_psa.Lines;
            //Loop output
            for (int int_line = 0; int_line < str_txtpsalines.Length; int_line++)
            {
                if (!(String.IsNullOrEmpty(str_txtpsalines[int_line])) && ((str_txtpsalines[int_line].Contains(':') && str_txtpsalines[int_line].Contains(',') && str_txtpsalines[int_line].Contains("Hitbox:"))))
                {
                    //Set up Hitbox Variables
                    Calculator.Hitbox.int_damage = Convert.ToInt32(EventToStat(str_txtpsalines[int_line], 1));
                    Calculator.Hitbox.int_shielddamage = Convert.ToInt32(EventToStat(str_txtpsalines[int_line], 2));
                    Calculator.Hitbox.int_angle = Convert.ToInt32(EventToStat(str_txtpsalines[int_line], 3));
                    Calculator.Hitbox.int_bkb = Convert.ToInt32(EventToStat(str_txtpsalines[int_line], 4));
                    Calculator.Hitbox.int_wdsk = Convert.ToInt32(EventToStat(str_txtpsalines[int_line], 5));
                    Calculator.Hitbox.int_kbg = Convert.ToInt32(EventToStat(str_txtpsalines[int_line], 6));
                    Calculator.Hitbox.double_size = Convert.ToDouble(EventToStat(str_txtpsalines[int_line], 7));
                    Calculator.Hitbox.int_hitlagmultiplier = Convert.ToInt32(EventToStat(str_txtpsalines[int_line], 8));
                    Calculator.Hitbox.int_sdimultiplier = Convert.ToInt32(EventToStat(str_txtpsalines[int_line], 9));
                    Calculator.Hitbox.int_flags = Convert.ToInt32(EventToStat(str_txtpsalines[int_line], 10));
                    if (str_txtpsalines[int_line].Contains("Rehit Rate") && str_txtpsalines[int_line].Contains("Special Flags"))
                    {
                        Calculator.Hitbox.int_rehitrate = Convert.ToInt32(EventToStat(str_txtpsalines[int_line], 11));
                        Calculator.Hitbox.int_specialflags = Convert.ToInt32(EventToStat(str_txtpsalines[int_line], 12));
                    }
                    //Set up Victim Variables
                    if (Calculator.Settings.Victim.readsetting(0).Contains('/'))
                    {
                        String[] str_splitdamage = Calculator.Settings.Victim.readsetting(0).Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (String dmg in str_splitdamage)
                        {
                            Calculator.Character.initvictim(Convert.ToInt16(dmg), Convert.ToInt16(Calculator.Settings.Victim.readsetting(1)), Convert.ToBoolean(Calculator.Settings.Victim.readsetting(2)), Convert.ToBoolean(Calculator.Settings.Victim.readsetting(3)));
                            //Dump Data
                        }
                    }
                    else
                    {
                        Calculator.Character.initvictim(Convert.ToInt16(Calculator.Settings.Victim.readsetting(0)), Convert.ToInt16(Calculator.Settings.Victim.readsetting(1)), Convert.ToBoolean(Calculator.Settings.Victim.readsetting(2)), Convert.ToBoolean(Calculator.Settings.Victim.readsetting(3)));
                        //Dump Data

                    }
                }
            }
        }
    }
}
