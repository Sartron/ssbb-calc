using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics; //Debug

namespace attackcalculator
{
    public partial class MainFrm : Form
    {
        List<Collision> psaEvents = new List<Collision>();

        #region Startup
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            if (!Settings.Exists)
            {
                Settings.Create();
            }
            Settings.Load();
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

        private void miscellaneousCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MiscCalcFrm = new MiscCalcFrm();
            MiscCalcFrm.Show();
        }
        #endregion
        #region PSA Code Menu
        private void btnCopy_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int i in lB_psa.SelectedIndices)
            {
                Collision curCollision = psaEvents[i];
                sb.Append(curCollision.ToBrawlBox() + '/');
                //sb.Append(curCollision.ToPSA() + '/');
            }
            Clipboard.SetData(DataFormats.Text, sb.ToString());
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int i in lB_psa.SelectedIndices)
            {
                Collision curCollision = psaEvents[i];
                sb.Append(curCollision.ToBrawlBox() + '/');
                //sb.Append(curCollision.ToPSA() + '/');
            }
            Clipboard.SetData(DataFormats.Text, sb.ToString());

            for (int i = lB_psa.SelectedIndices.Count - 1; i >= 0; i--)
            {
                psaEvents.RemoveAt(lB_psa.SelectedIndices[i]);
                lB_psa.Items.RemoveAt(lB_psa.SelectedIndices[i]);
            }
        }
        
        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsText(TextDataFormat.Text))
                return;

            string[] str_matches = new string[3];
            string str_clipboard = Clipboard.GetText(TextDataFormat.Text);

            Regex regex_brawlBox_offensive = new Regex(@"06000D00\|0\\\d+\|0\\\d+\|0\\\d+\|0\\\d+\|0\\\d+\|1\\(\d+|\-\d+)\|1\\(\d+|\-\d+)\|1\\(\d+|\-\d+)\|1\\(\d+|\-\d+)\|1\\(\d+|\-\d+)\|1\\(\d+|\-\d+)\|1\\(\d+|\-\d+)\|0\\\d+\|", RegexOptions.None);
            Regex regex_brawlBox_specialOffensive = new Regex(@"06150F00\|0\\\d+\|0\\\d+\|0\\\d+\|0\\\d+\|0\\\d+\|1\\(\d+|\-\d+)\|1\\(\d+|\-\d+)\|1\\(\d+|\-\d+)\|1\\(\d+|\-\d+)\|1\\(\d+|\-\d+)\|1\\(\d+|\-\d+)\|1\\(\d+|\-\d+)\|0\\\d+\|0\\\d+\|0\\\d+\|", RegexOptions.None);
            Regex regex_brawlBox_throw = new Regex(@"060E1100\|0\\\d+\|0\\\d+\|0\\\d+\|0\\\d+\|0\\\d+\|0\\\d+\|0\\\d+\|0\\\d+\|1\\(\d+|\-\d+)\|1\\(\d+|\-\d+)\|1\\(\d+|\-\d+)\|0\\\d+\|0\\\d+\|0\\\d+\|3\\(0|1)\|3\\(0|1)\|0\\\d+\|", RegexOptions.None);

            Regex regex_PSA_offensive = new Regex(@"06000D00\|0\\\w+\|0\\\w+\|0\\\w+\|0\\\w+\|0\\\w+\|1\\(\w+|\-\w+)\|1\\(\w+|\-\w+)\|1\\(\w+|\-\w+)\|1\\(\w+|\-\w+)\|1\\(\w+|\-\w+)\|1\\(\w+|\-\w+)\|1\\(\w+|\-\w+)\|0\\\w+\|", RegexOptions.None);
            Regex regex_PSA_specialOffensive = new Regex(@"06150F00\|0\\\w+\|0\\\w+\|0\\\w+\|0\\\w+\|0\\\w+\|1\\(\w+|\-\w+)\|1\\(\w+|\-\w+)\|1\\(\w+|\-\w+)\|1\\(\w+|\-\w+)\|1\\(\w+|\-\w+)\|1\\(\w+|\-\w+)\|1\\(\w+|\-\w+)\|0\\\w+\|0\\\w+\|0\\\w+\|", RegexOptions.None);
            Regex regex_PSA_throw = new Regex(@"060E1100\|0\\\w+\|0\\\w+\|0\\\w+\|0\\\w+\|0\\\w+\|0\\\w+\|0\\\w+\|0\\\w+\|1\\(\w+|\-\w+)\|1\\(\w+|\-\w+)\|1\\(\w+|\-\w+)\|0\\\w+\|0\\\w+\|0\\\w+\|3\\(0|1)\|3\\(0|1)\|0\\\w+\|", RegexOptions.None);

            Regex regex_plainText_offensive = new Regex(@"(?!.*Special)Offensive Collision: Id=\d+, Bone=\d+, Damage=\d+, ShieldDamage=\d+, Direction=\d+, BaseKnockback=\d+, WeightKnockback=\d+, KnockbackGrowth=\d+, Size=-?\d+(.\d+)?, Z Offset=-?\d+(.\d+)?, Y Offset=-?\d+(.\d+)?, X Offset=-?\d+(.\d+)?, TripRate=-?\d+(.\d+)?%, HitlagMultiplier=x-?\d+(.\d+)?, SDIMultiplier=x-?\d+(.\d+)?, Flags=\d+", RegexOptions.None);
            Regex regex_plainText_specialOffensive = new Regex(@"Special Offensive Collision: Id=\d+, Bone=\d+, Damage=\d+, ShieldDamage=\d+, Direction=\d+, BaseKnockback=\d+, WeightKnockback=\d+, KnockbackGrowth=\d+, Size=-?\d+(.\d+)?, Z Offset=-?\d+(.\d+)?, Y Offset=-?\d+(.\d+)?, X Offset=-?\d+(.\d+)?, TripRate=-?\d+(.\d+)?%, HitlagMultiplier=x-?\d+(.\d+)?, SDIMultiplier=x-?\d+(.\d+)?, Flags=\d+, RehitRate=\d+, SpecialFlags=\d+", RegexOptions.None);
            Regex regex_plainText_throw = new Regex(@"Throw Specifier:ID=\d+, Bone\?=\d+, Damage=\d+, Direction=\d+, KnockbackGrowth=\d+, WeightKnockback=\d+,BaseKnockback=\d+, Element=\d+, UnknownA=-?\d+(.\d+)?, UnknownB=-?\d+(.\d+)?, UnknownC=-?\d+(.\d+)?, UnknownD=\d+, SFX=\d+, Direction\?=\d+, UnknownE=(true|false), UnknownF=(true|false), UnknownG=\d+", RegexOptions.None);

            Match patternSearch;

            #region Serialized
            #region BrawlBox
            patternSearch = regex_brawlBox_offensive.Match(str_clipboard);
            while (patternSearch.Success)
            {
                str_matches[0] += String.Format("{0}-{1}|", patternSearch.Index, patternSearch.Index + patternSearch.Length);

                OffensiveCollision newEvent = CollisionParser.BrawlBox.deserializeOffensiveCollision(patternSearch.ToString());
                psaEvents.Add(newEvent);
                lB_psa.Items.Add(newEvent);

                patternSearch = patternSearch.NextMatch();
            }

            patternSearch = regex_brawlBox_specialOffensive.Match(str_clipboard);
            while (patternSearch.Success)
            {
                str_matches[1] += String.Format("{0}-{1}|", patternSearch.Index, patternSearch.Index + patternSearch.Length);

                SpecialOffensiveCollision newEvent = CollisionParser.BrawlBox.deserializeSpecialOffensiveCollision(patternSearch.ToString());
                psaEvents.Add(newEvent);
                lB_psa.Items.Add(newEvent);

                patternSearch = patternSearch.NextMatch();
            }

            patternSearch = regex_brawlBox_throw.Match(str_clipboard);
            while (patternSearch.Success)
            {
                str_matches[2] += String.Format("{0}-{1}|", patternSearch.Index, patternSearch.Index + patternSearch.Length);

                ThrowSpecifier newEvent = CollisionParser.BrawlBox.deserializeThrowSpecifier(patternSearch.ToString());
                psaEvents.Add(newEvent);
                lB_psa.Items.Add(newEvent);

                patternSearch = patternSearch.NextMatch();
            }
            #endregion
            #region PSA
            patternSearch = regex_PSA_offensive.Match(str_clipboard);
            while (patternSearch.Success)
            {
                bool isMatched = false;
                string str_curMatch = String.Format("{0}-{1}", patternSearch.Index, patternSearch.Index + patternSearch.Length);

                if (!String.IsNullOrEmpty(str_matches[0]))
                {
                    for (int i = 0; i < str_matches[0].Split('|').Length; i++)
                    {
                        string str_curSplit = str_matches[0].Split('|')[i];

                        if (String.IsNullOrWhiteSpace(str_curSplit))
                            continue;

                        if (str_curMatch.Equals(str_curSplit))
                            isMatched = true;
                    }
                }

                if (!isMatched)
                {
                    OffensiveCollision newEvent = CollisionParser.PSA.deserializeOffensiveCollision(patternSearch.ToString());
                    psaEvents.Add(newEvent);
                    lB_psa.Items.Add(newEvent);
                }

                patternSearch = patternSearch.NextMatch();
            }

            patternSearch = regex_PSA_specialOffensive.Match(str_clipboard);
            while (patternSearch.Success)
            {
                bool isMatched = false;
                string str_curMatch = String.Format("{0}-{1}", patternSearch.Index, patternSearch.Index + patternSearch.Length);

                if (!String.IsNullOrEmpty(str_matches[1]))
                {
                    for (int i = 0; i < str_matches[1].Split('|').Length; i++)
                    {
                        string str_curSplit = str_matches[1].Split('|')[i];

                        if (String.IsNullOrWhiteSpace(str_curSplit))
                            continue;

                        if (str_curMatch.Equals(str_curSplit))
                            isMatched = true;
                    }
                }

                if (!isMatched)
                {
                    OffensiveCollision newEvent = CollisionParser.PSA.deserializeSpecialOffensiveCollision(patternSearch.ToString());
                    psaEvents.Add(newEvent);
                    lB_psa.Items.Add(newEvent);
                }

                patternSearch = patternSearch.NextMatch();
            }

            patternSearch = regex_PSA_throw.Match(str_clipboard);
            while (patternSearch.Success)
            {
                bool isMatched = false;
                string str_curMatch = String.Format("{0}-{1}", patternSearch.Index, patternSearch.Index + patternSearch.Length);

                if (!String.IsNullOrEmpty(str_matches[2]))
                {
                    for (int i = 0; i < str_matches[2].Split('|').Length; i++)
                    {
                        string str_curSplit = str_matches[2].Split('|')[i];

                        if (String.IsNullOrWhiteSpace(str_curSplit))
                            continue;

                        if (str_curMatch.Equals(str_curSplit))
                            isMatched = true;
                    }
                }

                if (!isMatched)
                {
                    OffensiveCollision newEvent = CollisionParser.PSA.deserializeOffensiveCollision(patternSearch.ToString());
                    psaEvents.Add(newEvent);
                    lB_psa.Items.Add(newEvent);
                }

                patternSearch = patternSearch.NextMatch();
            }
            #endregion
            #endregion
            #region Deserialized
            patternSearch = regex_plainText_offensive.Match(str_clipboard);
            while (patternSearch.Success)
            {
                OffensiveCollision newEvent = CollisionParser.PlainText.plainToOffensiveCollision(patternSearch.ToString());
                psaEvents.Add(newEvent);
                lB_psa.Items.Add(newEvent);

                patternSearch = patternSearch.NextMatch();
            }

            patternSearch = regex_plainText_specialOffensive.Match(str_clipboard);
            while (patternSearch.Success)
            {
                OffensiveCollision newEvent = CollisionParser.PlainText.plainToSpecialOffensiveCollision(patternSearch.ToString());
                psaEvents.Add(newEvent);
                lB_psa.Items.Add(newEvent);

                patternSearch = patternSearch.NextMatch();
            }

            patternSearch = regex_plainText_throw.Match(str_clipboard);
            while (patternSearch.Success)
            {
                ThrowSpecifier newEvent = CollisionParser.PlainText.plainToThrowSpecifier(patternSearch.ToString());
                psaEvents.Add(newEvent);
                lB_psa.Items.Add(newEvent);

                patternSearch = patternSearch.NextMatch();
            }
            #endregion
        }

        private void btnCopyText_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (object row in lB_psa.SelectedItems)
            {
                sb.Append(row);
                sb.AppendLine();
            }
            sb.Remove(sb.Length - 1, 1);
            Clipboard.SetData(DataFormats.Text, sb.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Collision newEvent = new Collision(lB_psa.Items.Count + 1, 0, 0, 0, 0, 0, 0);
            psaEvents.Add(newEvent);
            lB_psa.Items.Add(newEvent);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Collision editEvent = psaEvents[lB_psa.SelectedIndex];

            Form editFrm = new EditFrm();
            editFrm.Show();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = lB_psa.SelectedIndices.Count - 1; i >= 0; i--)
            {
                psaEvents.RemoveAt(lB_psa.SelectedIndices[i]);
                lB_psa.Items.RemoveAt(lB_psa.SelectedIndices[i]);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            foreach (int i in lB_psa.SelectedIndices)
            {
                Collision curCollision = psaEvents[i];
                curCollision.Victim = Settings.Victim.Read();

                if (curCollision.GetType() == typeof(Collision))
                {
                    //Do nothing
                }
                else if (curCollision.GetType() == typeof(OffensiveCollision))
                {
                    string strStat = Settings.Output.miscRead(0);
                    if (String.IsNullOrWhiteSpace(strStat))
                        return;

                    OffensiveCollision convertedCollision = (OffensiveCollision)curCollision;
                    if (!String.IsNullOrWhiteSpace(fillEntries(strStat, convertedCollision)))
                        lB_generatedStats.Items.Add(fillEntries(strStat, convertedCollision));
                }
                else if (curCollision.GetType() == typeof(SpecialOffensiveCollision))
                {
                    string strStat = Settings.Output.miscRead(1);
                    if (String.IsNullOrWhiteSpace(strStat))
                        return;

                    SpecialOffensiveCollision convertedCollision = (SpecialOffensiveCollision)curCollision;
                    if (!String.IsNullOrWhiteSpace(fillEntries(strStat, convertedCollision)))
                        lB_generatedStats.Items.Add(fillEntries(strStat, convertedCollision));
                }
                else if (curCollision.GetType() == typeof(ThrowSpecifier))
                {
                    string strStat = Settings.Output.miscRead(0);
                    if (String.IsNullOrWhiteSpace(strStat))
                        return;

                    ThrowSpecifier convertedCollision = (ThrowSpecifier)curCollision;
                    if (!String.IsNullOrWhiteSpace(fillEntries(strStat, convertedCollision)))
                        lB_generatedStats.Items.Add(fillEntries(strStat, convertedCollision));
                }
            }
        }

        private string fillEntries(string line, OffensiveCollision collision)
        {
            string returnThis = line;

            for (int i = 0; i <= Settings.Output.varCount; i++)
            {
                Settings.Output.outputVar curVar = Settings.Output.Read(i);
                if (!curVar.Enabled)
                    continue;

                Regex namePattern = new Regex(curVar.Name);
                if (!namePattern.IsMatch(returnThis))
                    continue;

                OffensiveCollision tempCollision = collision;
                switch (i)
                {
                    case 0:
                        returnThis = namePattern.Replace(returnThis, tempCollision.ID.ToString());
                        break;
                    case 1:
                        returnThis = namePattern.Replace(returnThis, tempCollision.Size.ToString());
                        break;
                    case 2:
                        returnThis = namePattern.Replace(returnThis, tempCollision.Damage.ToString());
                        break;
                    case 3:
                        returnThis = namePattern.Replace(returnThis, tempCollision.ShieldDamage.ToString());
                        break;
                    case 4:
                        returnThis = namePattern.Replace(returnThis, tempCollision.Angle.ToString());
                        break;
                    case 5:
                        string knockback = String.Empty;
                        string[] victimPercents = Settings.Victim.returnPercent().Split('/');

                        if (tempCollision.WeightKnockback == 0)
                        {
                            foreach (string str in victimPercents)
                            {
                                tempCollision.Victim.Percent = Convert.ToInt16(str);
                                knockback += tempCollision.Knockback + "/";
                            }
                            returnThis = namePattern.Replace(returnThis, knockback.Substring(0, knockback.Length - 1));
                        }
                        else
                            returnThis = namePattern.Replace(returnThis, collision.Knockback.ToString());
                        break;
                    case 6:
                        returnThis = namePattern.Replace(returnThis, tempCollision.BaseKnockback.ToString());
                        break;
                    case 7:
                        returnThis = namePattern.Replace(returnThis, tempCollision.WeightKnockback.ToString());
                        break;
                    case 8:
                        returnThis = namePattern.Replace(returnThis, tempCollision.KnockbackGrowth.ToString());
                        break;
                    case 9:
                        returnThis = namePattern.Replace(returnThis, tempCollision.HitlagMultiplier.ToString());
                        break;
                    case 10:
                        returnThis = namePattern.Replace(returnThis, tempCollision.SdiMultiplier.ToString());
                        break;
                    case 11:
                        if (curVar.DataType == 0)
                            returnThis = namePattern.Replace(returnThis, tempCollision.Clang.ToString());
                        else if (curVar.DataType == 1)
                            returnThis = namePattern.Replace(returnThis, Convert.ToInt16(tempCollision.Clang).ToString());
                        break;
                    case 12:
                        if (curVar.PrintMode == 0) //Print All
                            returnThis = namePattern.Replace(returnThis, tempCollision.Target.ToString());
                        else if (curVar.PrintMode == 1) //Print only if NOT 'All' or 'None'
                        {
                            if (tempCollision.Target == OffensiveCollision.HitboxTarget.All ||
                                tempCollision.Target == OffensiveCollision.HitboxTarget.None)
                                returnThis = namePattern.Replace(returnThis, String.Empty);
                            else
                                returnThis = namePattern.Replace(returnThis, tempCollision.Target.ToString());
                        }
                        else if (curVar.PrintMode == 2) //End line writing if no target
                        {
                            if (tempCollision.Target == OffensiveCollision.HitboxTarget.None)
                                return String.Empty;
                        }
                        break;
                    case 13:
                        returnThis = namePattern.Replace(returnThis, tempCollision.Effect.ToString());
                        break;
                    case 14:
                        returnThis = namePattern.Replace(returnThis, tempCollision.Shieldstun.ToString());
                        break;
                    case 15:
                        string hitstun = String.Empty;
                        string[] _victimPercents = Settings.Victim.returnPercent().Split('/');

                        if (tempCollision.WeightKnockback == 0)
                        {
                            foreach (string str in _victimPercents)
                            {
                                tempCollision.Victim.Percent = Convert.ToInt16(str);
                                hitstun += tempCollision.Hitstun + "/";
                            }
                            returnThis = namePattern.Replace(returnThis, hitstun.Substring(0, hitstun.Length - 1));
                        }
                        else
                            returnThis = namePattern.Replace(returnThis, collision.Knockback.ToString());
                        break;
                    case 16:
                        string launch = String.Empty;
                        string[] __victimPercents = Settings.Victim.returnPercent().Split('/');

                        if (tempCollision.WeightKnockback == 0)
                        {
                            foreach (string str in __victimPercents)
                            {
                                tempCollision.Victim.Percent = Convert.ToInt16(str);
                                launch += tempCollision.Hitstun + "/";
                            }
                            returnThis = namePattern.Replace(returnThis, launch.Substring(0, launch.Length - 1));
                        }
                        else
                            returnThis = namePattern.Replace(returnThis, collision.Knockback.ToString());
                        break;
                    case 17:
                        returnThis = namePattern.Replace(returnThis, tempCollision.HitlagVictim.ToString());
                        break;
                    case 18:
                        int[] hitlag = new int[2];
                        hitlag[0] = tempCollision.HitlagAttacker;
                        tempCollision.HitlagMultiplier = 1.0f;
                        hitlag[1] = tempCollision.HitlagAttacker;

                        if (hitlag[0] < hitlag[1])
                            returnThis = namePattern.Replace(returnThis, String.Format("+{0}", hitlag[1] - hitlag[0]));
                        else if (hitlag[0] > hitlag[1])
                            returnThis = namePattern.Replace(returnThis, String.Format("{0}", hitlag[1] - hitlag[0]));
                        else
                        {
                            if (curVar.PrintMode == 0)
                            {
                                returnThis = namePattern.Replace(returnThis, "±0");
                            }
                            else if (curVar.PrintMode == 1)
                            {
                                returnThis = namePattern.Replace(returnThis, String.Empty);
                            }
                        }
                        break;
                }
            }

            return returnThis;
        }

        private string fillEntries(string line, SpecialOffensiveCollision collision)
        {
            string returnThis = line;

            for (int i = 0; i <= Settings.Output.varCount; i++)
            {
                Settings.Output.outputVar curVar = Settings.Output.Read(i);
                if (!curVar.Enabled)
                    continue;

                Regex namePattern = new Regex(curVar.Name);
                if (!namePattern.IsMatch(returnThis))
                    continue;

                SpecialOffensiveCollision tempCollision = collision;
                switch (i)
                {
                    case 0:
                        returnThis = namePattern.Replace(returnThis, tempCollision.ID.ToString());
                        break;
                    case 1:
                        returnThis = namePattern.Replace(returnThis, tempCollision.Size.ToString());
                        break;
                    case 2:
                        returnThis = namePattern.Replace(returnThis, tempCollision.Damage.ToString());
                        break;
                    case 3:
                        returnThis = namePattern.Replace(returnThis, tempCollision.ShieldDamage.ToString());
                        break;
                    case 4:
                        returnThis = namePattern.Replace(returnThis, tempCollision.Angle.ToString());
                        break;
                    case 5:
                        string knockback = String.Empty;
                        string[] victimPercents = Settings.Victim.returnPercent().Split('/');

                        if (tempCollision.WeightKnockback == 0)
                        {
                            foreach (string str in victimPercents)
                            {
                                tempCollision.Victim.Percent = Convert.ToInt16(str);
                                knockback += tempCollision.Knockback + "/";
                            }
                            returnThis = namePattern.Replace(returnThis, knockback.Substring(0, knockback.Length - 1));
                        }
                            returnThis = namePattern.Replace(returnThis, collision.Knockback.ToString());
                        break;
                    case 6:
                        returnThis = namePattern.Replace(returnThis, tempCollision.BaseKnockback.ToString());
                        break;
                    case 7:
                        returnThis = namePattern.Replace(returnThis, tempCollision.WeightKnockback.ToString());
                        break;
                    case 8:
                        returnThis = namePattern.Replace(returnThis, tempCollision.KnockbackGrowth.ToString());
                        break;
                    case 9:
                        returnThis = namePattern.Replace(returnThis, tempCollision.HitlagMultiplier.ToString());
                        break;
                    case 10:
                        returnThis = namePattern.Replace(returnThis, tempCollision.SdiMultiplier.ToString());
                        break;
                    case 11:
                        if (curVar.DataType == 0)
                            returnThis = namePattern.Replace(returnThis, tempCollision.Clang.ToString());
                        else if (curVar.DataType == 1)
                            returnThis = namePattern.Replace(returnThis, Convert.ToInt16(tempCollision.Clang).ToString());
                        break;
                    case 12:
                        if (curVar.PrintMode == 0) //Print All
                            returnThis = namePattern.Replace(returnThis, tempCollision.Target.ToString());
                        else if (curVar.PrintMode == 1) //Print only if NOT 'All' or 'None'
                        {
                            if (tempCollision.Target == SpecialOffensiveCollision.HitboxTarget.All ||
                                tempCollision.Target == SpecialOffensiveCollision.HitboxTarget.None ||
                                tempCollision.Target == SpecialOffensiveCollision.HitboxTarget.SSE)
                                returnThis = namePattern.Replace(returnThis, String.Empty);
                            else
                                returnThis = namePattern.Replace(returnThis, tempCollision.Target.ToString());
                        }
                        else if (curVar.PrintMode == 2) //End line writing if no target
                        {
                            if (tempCollision.Target == SpecialOffensiveCollision.HitboxTarget.None ||
                                tempCollision.Target == SpecialOffensiveCollision.HitboxTarget.SSE)
                                return String.Empty;
                        }
                        break;
                    case 13:
                        returnThis = namePattern.Replace(returnThis, tempCollision.Effect.ToString());
                        break;
                    case 14:
                        returnThis = namePattern.Replace(returnThis, tempCollision.Shieldstun.ToString());
                        break;
                    case 15:
                        string hitstun = String.Empty;
                        string[] _victimPercents = Settings.Victim.returnPercent().Split('/');

                        if (tempCollision.WeightKnockback == 0)
                        {
                            foreach (string str in _victimPercents)
                            {
                                tempCollision.Victim.Percent = Convert.ToInt16(str);
                                hitstun += tempCollision.Hitstun + "/";
                            }
                            returnThis = namePattern.Replace(returnThis, hitstun.Substring(0, hitstun.Length - 1));
                        }
                        else
                            returnThis = namePattern.Replace(returnThis, collision.Knockback.ToString());
                        break;
                    case 16:
                        string launch = String.Empty;
                        string[] __victimPercents = Settings.Victim.returnPercent().Split('/');

                        if (tempCollision.WeightKnockback == 0)
                        {
                            foreach (string str in __victimPercents)
                            {
                                tempCollision.Victim.Percent = Convert.ToInt16(str);
                                launch += tempCollision.Hitstun + "/";
                            }
                            returnThis = namePattern.Replace(returnThis, launch.Substring(0, launch.Length - 1));
                        }
                        else
                            returnThis = namePattern.Replace(returnThis, collision.Knockback.ToString());
                        break;
                    case 17:
                        if (!tempCollision.NoHitlag)
                            returnThis = namePattern.Replace(returnThis, tempCollision.HitlagVictim.ToString());
                        else
                            returnThis = namePattern.Replace(returnThis, "0");
                        break;
                    case 18:
                        int[] hitlag = new int[2];
                        hitlag[0] = tempCollision.HitlagAttacker;
                        tempCollision.HitlagMultiplier = 1.0f;
                        hitlag[1] = tempCollision.HitlagAttacker;

                        if (hitlag[0] < hitlag[1])
                            returnThis = namePattern.Replace(returnThis, String.Format("+{0}", hitlag[1] - hitlag[0]));
                        else if (hitlag[0] > hitlag[1])
                            returnThis = namePattern.Replace(returnThis, String.Format("{0}", hitlag[1] - hitlag[0]));
                        else
                        {
                            if (curVar.PrintMode == 0)
                                returnThis = namePattern.Replace(returnThis, "±0");
                            else if (curVar.PrintMode == 1)
                                returnThis = namePattern.Replace(returnThis, String.Empty);
                        }
                        break;
                    case 19:
                        if (curVar.PrintMode == 0)
                            returnThis = namePattern.Replace(returnThis, tempCollision.RehitRate.ToString());
                        else if (curVar.PrintMode == 1)
                            returnThis = namePattern.Replace(returnThis, String.Empty);
                        break;
                    case 20:
                        if (curVar.PrintMode == 0)
                        {
                            if (curVar.DataType == 0)
                                returnThis = namePattern.Replace(returnThis, tempCollision.Shieldable.ToString());
                            else
                                returnThis = namePattern.Replace(returnThis, Convert.ToInt16(tempCollision.Shieldable).ToString());
                        }
                        else if (curVar.PrintMode == 1)
                        {
                            if (tempCollision.Shieldable)
                            {
                                if (curVar.DataType == 0)
                                    returnThis = namePattern.Replace(returnThis, tempCollision.Shieldable.ToString());
                                else
                                    returnThis = namePattern.Replace(returnThis, Convert.ToInt16(tempCollision.Shieldable).ToString());
                            }
                            else
                                returnThis = namePattern.Replace(returnThis, String.Empty);
                        }
                        break;
                    case 21:
                        if (curVar.PrintMode == 0)
                        {
                            if (curVar.DataType == 0)
                                returnThis = namePattern.Replace(returnThis, tempCollision.Reflectable.ToString());
                            else
                                returnThis = namePattern.Replace(returnThis, Convert.ToInt16(tempCollision.Reflectable).ToString());
                        }
                        else if (curVar.PrintMode == 1)
                        {
                            if (tempCollision.Reflectable)
                            {
                                if (curVar.DataType == 0)
                                    returnThis = namePattern.Replace(returnThis, tempCollision.Reflectable.ToString());
                                else
                                    returnThis = namePattern.Replace(returnThis, Convert.ToInt16(tempCollision.Reflectable).ToString());
                            }
                            else
                                returnThis = namePattern.Replace(returnThis, String.Empty);
                        }
                        break;
                    case 22:
                        if (curVar.PrintMode == 0)
                        {
                            if (curVar.DataType == 0)
                                returnThis = namePattern.Replace(returnThis, tempCollision.Absorbable.ToString());
                            else
                                returnThis = namePattern.Replace(returnThis, Convert.ToInt16(tempCollision.Absorbable).ToString());
                        }
                        else if (curVar.PrintMode == 1)
                        {
                            if (tempCollision.Absorbable)
                            {
                                if (curVar.DataType == 0)
                                    returnThis = namePattern.Replace(returnThis, tempCollision.Absorbable.ToString());
                                else
                                    returnThis = namePattern.Replace(returnThis, Convert.ToInt16(tempCollision.Absorbable).ToString());
                            }
                            else
                                returnThis = namePattern.Replace(returnThis, String.Empty);
                        }
                        break;
                    case 23:
                        if (curVar.PrintMode == 0)
                        {
                            if (curVar.DataType == 0)
                                returnThis = namePattern.Replace(returnThis, tempCollision.IgnoreInvincibility.ToString());
                            else
                                returnThis = namePattern.Replace(returnThis, Convert.ToInt16(tempCollision.IgnoreInvincibility).ToString());
                        }
                        else if (curVar.PrintMode == 1)
                        {
                            if (tempCollision.IgnoreInvincibility)
                            {
                                if (curVar.DataType == 0)
                                    returnThis = namePattern.Replace(returnThis, tempCollision.IgnoreInvincibility.ToString());
                                else
                                    returnThis = namePattern.Replace(returnThis, Convert.ToInt16(tempCollision.IgnoreInvincibility).ToString());
                            }
                            else
                                returnThis = namePattern.Replace(returnThis, String.Empty);
                        }
                        break;
                    case 24:
                        if (curVar.PrintMode == 0)
                        {
                            if (curVar.DataType == 0)
                                returnThis = namePattern.Replace(returnThis, tempCollision.Flinchless.ToString());
                            else
                                returnThis = namePattern.Replace(returnThis, Convert.ToInt16(tempCollision.Flinchless).ToString());
                        }
                        else if (curVar.PrintMode == 1)
                        {
                            if (tempCollision.Flinchless)
                            {
                                if (curVar.DataType == 0)
                                    returnThis = namePattern.Replace(returnThis, tempCollision.Flinchless.ToString());
                                else
                                    returnThis = namePattern.Replace(returnThis, Convert.ToInt16(tempCollision.Flinchless).ToString());
                            }
                            else
                                returnThis = namePattern.Replace(returnThis, String.Empty);
                        }
                        break;
                }
            }

            return returnThis;
        }

        private string fillEntries(string line, ThrowSpecifier collision)
        {
            string returnThis = String.Empty;

            for (int i = 0; i < Settings.Output.varCount; i++)
            {
                Settings.Output.outputVar curVar = Settings.Output.Read(i);
                if (!curVar.Enabled)
                    continue;

            }

            return "ThrowSpecifier not implemented!";
            //return returnThis;
        }

        private void lB_psa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lB_psa.SelectedIndices.Count == 0)
            {
                btnCopy.Enabled = false;
                btnCut.Enabled = false;
                btnCopyText.Enabled = false;
                btnDelete.Enabled = false;
                btnConvert.Enabled = false;
            }
            else
            {
                btnCopy.Enabled = true;
                btnCut.Enabled = true;
                btnCopyText.Enabled = true;
                btnDelete.Enabled = true;
                btnConvert.Enabled = true;

                foreach (int i in lB_psa.SelectedIndices)
                {
                    Collision curCollision = psaEvents[i];
                    if (curCollision.GetType().Equals(typeof(Collision)))
                    {
                        btnCopy.Enabled = false;
                        btnCut.Enabled = false;
                        btnConvert.Enabled = false;
                    }
                }
            }

            if (lB_psa.SelectedIndices.Count == 1)
            {
                btnEdit.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
            }
        }

        private void lB_psa_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                lB_psa.SelectedIndex = -1;
            }
        }
        #endregion
    }
}