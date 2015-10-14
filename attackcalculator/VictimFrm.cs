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
            StringReader strReader = new StringReader(Properties.Resources.characters);
            while (!String.IsNullOrEmpty(strReader.ReadLine()))
            {
                cb_characters.Items.Add(strReader.ReadLine());
                MessageBox.Show(strReader.ReadLine());
            }

            //Set up values from settings.xml
            txt_damage.Text = Calculator.Settings.Victim.readsetting(0);
            cb_characters.SelectedIndex = Convert.ToInt16(Calculator.Settings.Victim.readsetting(1));
            cb_crouchcancel.Checked = Convert.ToBoolean(Calculator.Settings.Victim.readsetting(2));
            cb_charging.Checked = Convert.ToBoolean(Calculator.Settings.Victim.readsetting(3));
        }
    }
}
