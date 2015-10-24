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

        static public string ReplaceWholeWord(string input, string wordToFind, string replacement, RegexOptions regexOptions = RegexOptions.None)
        {
            //Code by Ahmad Mageed and Michael Freidgeim
            string pattern = String.Format(@"\b{0}\b", wordToFind);
            string newstring = Regex.Replace(input, pattern, replacement, regexOptions);
            return newstring;
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
                    Calculator.Hitbox.int_id = Convert.ToInt16(EventToStat(str_txtpsalines[int_line], 0));
                    Calculator.Hitbox.int_damage = Convert.ToInt16(EventToStat(str_txtpsalines[int_line], 1));
                    Calculator.Hitbox.int_shielddamage = Convert.ToInt16(EventToStat(str_txtpsalines[int_line], 2));
                    Calculator.Hitbox.int_angle = Convert.ToInt16(EventToStat(str_txtpsalines[int_line], 3));
                    Calculator.Hitbox.int_bkb = Convert.ToInt16(EventToStat(str_txtpsalines[int_line], 4));
                    Calculator.Hitbox.int_wdsk = Convert.ToInt16(EventToStat(str_txtpsalines[int_line], 5));
                    Calculator.Hitbox.int_kbg = Convert.ToInt16(EventToStat(str_txtpsalines[int_line], 6));
                    Calculator.Hitbox.double_size = Convert.ToDouble(EventToStat(str_txtpsalines[int_line], 7));
                    Calculator.Hitbox.double_hitlagmultiplier = Convert.ToDouble(EventToStat(str_txtpsalines[int_line], 8));
                    Calculator.Hitbox.double_sdimultiplier = Convert.ToDouble(EventToStat(str_txtpsalines[int_line], 9));
                    Calculator.Hitbox.int_flags = Convert.ToInt32(EventToStat(str_txtpsalines[int_line], 10));
                    if (str_txtpsalines[int_line].Contains("Rehit Rate") && str_txtpsalines[int_line].Contains("Special Flags"))
                    {
                        Calculator.Hitbox.int_rehitrate = Convert.ToInt16(EventToStat(str_txtpsalines[int_line], 11));
                        Calculator.Hitbox.int_specialflags = Convert.ToInt32(EventToStat(str_txtpsalines[int_line], 12));
                    }
                    else
                    {
                        //Reset
                        Calculator.Hitbox.int_rehitrate = 0;
                        Calculator.Hitbox.int_specialflags = 0;
                    }

                    //Damage variable bullshit
                    if (Calculator.Settings.Victim.readsetting(0).Contains('/'))
                    {
                        //Multiple damage variables
                        String[] str_splitdamage = Calculator.Settings.Victim.readsetting(0).Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                        Calculator.Character.initvictim(Convert.ToInt16(str_splitdamage[0]), Convert.ToInt16(Calculator.Settings.Victim.readsetting(1)), Convert.ToBoolean(Calculator.Settings.Victim.readsetting(2)), Convert.ToBoolean(Calculator.Settings.Victim.readsetting(3)));
                    }
                    else
                    {
                        Calculator.Character.initvictim(Convert.ToInt16(Calculator.Settings.Victim.readsetting(0)), Convert.ToInt16(Calculator.Settings.Victim.readsetting(1)), Convert.ToBoolean(Calculator.Settings.Victim.readsetting(2)), Convert.ToBoolean(Calculator.Settings.Victim.readsetting(3)));
                    }

                    //Dump Data
                    txt_generatedstats.AppendText(Calculator.Settings.Output.readformat() + "\n");

                    int int_index = 0;
                    string str_vardata, str_name;
                    string[] str_array_data;
                    bool bool_enabled;

                    while (int_index <= 20)
                    {
                        str_vardata = Calculator.Settings.Output.readvariable(int_index);
                        str_array_data = str_vardata.Split('/');
                        bool_enabled = Convert.ToBoolean(str_array_data[0]);
                        str_name = str_array_data[1];

                        //Data exporting
                        //Array matches up with the numbers in settings.xml
                        if (bool_enabled == true && txt_generatedstats.Text.Contains(str_name))
                        {
                            switch (int_index)
                            {
                                case 0:
                                    //ID
                                    txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, Calculator.Hitbox.int_id.ToString());
                                    break;
                                case 1:
                                    //Size
                                    txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, Calculator.Hitbox.double_size.ToString());
                                    break;
                                case 2:
                                    //Damage
                                    txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, Calculator.Hitbox.int_damage.ToString());
                                    break;
                                case 3:
                                    //Shield Damage
                                    txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, (Calculator.Hitbox.int_damage * 0.7 + Calculator.Hitbox.int_shielddamage * 0.7).ToString());
                                    break;
                                case 4:
                                    //Angle
                                    txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, Calculator.Hitbox.int_angle.ToString());
                                    break;
                                case 5:
                                    //Knockback Units

                                    break;
                                case 6:
                                    //Base Knockback
                                    txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, Calculator.Hitbox.int_bkb.ToString());
                                    break;
                                case 7:
                                    //Weight Dependent Set Knockback
                                    txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, Calculator.Hitbox.int_wdsk.ToString());
                                    break;
                                case 8:
                                    //Knockback Growth
                                    txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, Calculator.Hitbox.int_kbg.ToString());
                                    break;
                                case 9:
                                    //Hitlag Multiplier
                                    txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, Calculator.Hitbox.double_hitlagmultiplier.ToString() + "x");
                                    break;
                                case 10:
                                    //SDI Multiplier
                                    txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, Calculator.Hitbox.double_sdimultiplier.ToString() + "x");
                                    break;
                                case 11:
                                    //Clang
                                    txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, Calculator.Hitbox.bool_clank(Calculator.Hitbox.int_flags).ToString());
                                    break;
                                case 12:
                                    //Target
                                    //First, check if special hitbox flags dictate if it can even hit players
                                    if (Calculator.Hitbox.int_specialflags != 0)
                                    {
                                        if (Calculator.Hitbox.bool_hitplayer(Calculator.Hitbox.int_specialflags) == false)
                                        {
                                            txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, "None");
                                        }
                                    }
                                    else
                                    {
                                        //Special hitbox flags don't exist, so just run normal checks
                                        switch (Calculator.Hitbox.int_aerialgrounded(Calculator.Hitbox.int_flags))
                                        {
                                            case "11":
                                                //All
                                                txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, "All");
                                                break;
                                            case "10":
                                                //Only Aerial
                                                txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, "Aerial");
                                                break;
                                            case "01":
                                                //Only Grounded
                                                txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, "Grounded");
                                                break;
                                            case "00":
                                                //None
                                                txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, "None");
                                                break;
                                        }
                                    }
                                    break;
                                case 13:
                                    //Effect
                                    string str_element;
                                    switch (Calculator.Hitbox.int_element(Calculator.Hitbox.int_flags))
                                    {
                                        case 0:
                                            //Normal
                                            str_element = "Normal";
                                            break;
                                        case 1:
                                            //None
                                            str_element = "None";
                                            break;
                                        case 2:
                                            //Slash
                                            str_element = "Slash";
                                            break;
                                        case 3:
                                            //Electric
                                            str_element = "Electric";
                                            break;
                                        case 4:
                                            //Freezing
                                            str_element = "Freezing";
                                            break;
                                        case 5:
                                            //Flame
                                            str_element = "Flame";
                                            break;
                                        case 6:
                                            //Coin
                                            str_element = "Coin";
                                            break;
                                        case 7:
                                            //Reverse
                                            str_element = "Reverse";
                                            break;
                                        case 8:
                                            //Slip
                                            str_element = "Slip";
                                            break;
                                        case 9:
                                            //Sleep
                                            str_element = "Sleep";
                                            break;
                                        case 11:
                                            //Bury
                                            str_element = "Bury";
                                            break;
                                        case 12:
                                            //Stun
                                            str_element = "Stun";
                                            break;
                                        case 13:
                                            //Light
                                            //Project M Exclusive
                                            str_element = "Light";
                                            break;
                                        case 14:
                                            //Flower
                                            str_element = "Flower";
                                            break;
                                        case 15:
                                            //Green Fire
                                            //Project M Exclusive
                                            str_element = "Green Flame";
                                            break;
                                        case 17:
                                            //Grass
                                            str_element = "Grass";
                                            break;
                                        case 18:
                                            //Water
                                            str_element = "Water";
                                            break;
                                        case 19:
                                            //Darkness
                                            str_element = "Darkness";
                                            break;
                                        case 20:
                                            //Paralyze
                                            str_element = "Paralyze";
                                            break;
                                        case 21:
                                            //Aura
                                            str_element = "Aura";
                                            break;
                                        case 22:
                                            //Plunge
                                            str_element = "Plunge";
                                            break;
                                        case 23:
                                            //Down
                                            str_element = "Down";
                                            break;
                                        case 24:
                                            //Flinchless
                                            str_element = "Flinchless";
                                            break;
                                        default:
                                            str_element = "N/A";
                                            break;
                                    }
                                    txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, str_element);
                                    break;
                                case 14:
                                    //Hitstun
                                    break;
                                case 15:
                                    //Shieldstun
                                    txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, Calculator.Calculations.shieldstun().ToString());
                                    break;
                                case 16:
                                    //Hitlag
                                    if (Calculator.Hitbox.int_element(Calculator.Hitbox.int_flags) == 3)
                                    {
                                        txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, Calculator.Calculations.hitlag_attacker() + "/" + Calculator.Calculations.hitlag_victim());
                                    }
                                    else
                                    {
                                        txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, Calculator.Calculations.hitlag_victim().ToString());
                                    }
                                    break;
                                case 17:
                                    //Hitlag Advantage
                                    double double_hitlagmultiplier = Calculator.Hitbox.double_hitlagmultiplier;
                                    int int_hitlag_custom = Calculator.Calculations.hitlag_attacker(), int_hitlag_1x;
                                    Calculator.Hitbox.double_hitlagmultiplier = 1;
                                    int_hitlag_1x = Calculator.Calculations.hitlag_attacker();

                                    if (int_hitlag_custom < int_hitlag_1x)
                                    {
                                        txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, "+" + (int_hitlag_1x - int_hitlag_custom).ToString());
                                    }
                                    else if(int_hitlag_custom > int_hitlag_1x)
                                    {
                                        txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, (int_hitlag_1x - int_hitlag_custom).ToString());
                                    }
                                    else if(int_hitlag_custom == int_hitlag_1x)
                                    {
                                        txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, "±0");
                                    }

                                    Calculator.Hitbox.double_hitlagmultiplier = int_hitlag_custom;
                                    break;
                                case 18:
                                    //Absorbability
                                    txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, Calculator.Hitbox.bool_absorb(Calculator.Hitbox.int_specialflags).ToString());
                                    break;
                                case 19:
                                    //Reflectability
                                    txt_generatedstats.Text = ReplaceWholeWord(txt_generatedstats.Text, str_name, Calculator.Hitbox.bool_reflect(Calculator.Hitbox.int_specialflags).ToString());
                                    break;
                                case 20:
                                    //Launch Speed
                                    break;
                            }
                        }
                        int_index++;
                    }
                }
            }
        }
    }
}