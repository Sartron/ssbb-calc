using attackcalculator.Properties;
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

namespace attackcalculator
{
    public partial class VictimFrm : Form
    {
        public VictimFrm()
        {
            InitializeComponent();
        }

        private void VictimFrm_Load(object sender, EventArgs e)
        {
            //Populate cb_characters with characters.txt and weights.txt
            StringReader strReader_characters = new StringReader(Properties.Resources.characters);
            StringReader strReader_weights = new StringReader(Properties.Resources.weights);
            while (cb_characters.Items.Count != 41)
            {
                cb_characters.Items.Add(strReader_characters.ReadLine() + " - " + strReader_weights.ReadLine());
            }
            cb_characters.Items.Add("Custom");

            //Set up values from settings.xml
            txt_damage.Text = Calculator.Settings.Victim.readsetting(0);
            cb_characters.SelectedIndex = Convert.ToInt16(Calculator.Settings.Victim.readsetting(1));
            cb_charging.Checked = Convert.ToBoolean(Calculator.Settings.Victim.readsetting(2));
            cb_crouchcancel.Checked = Convert.ToBoolean(Calculator.Settings.Victim.readsetting(3));
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            Calculator.Settings.Victim.writesetting(0, txt_damage.Text);
            Calculator.Settings.Victim.writesetting(1, cb_characters.SelectedIndex.ToString());
            Calculator.Settings.Victim.writesetting(2, cb_charging.Checked.ToString());
            Calculator.Settings.Victim.writesetting(3, cb_crouchcancel.Checked.ToString());
            Close();
        }
    }
}
