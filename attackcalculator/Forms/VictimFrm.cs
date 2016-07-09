using System;
using System.IO;
using System.Windows.Forms;

namespace attackcalculator
{
    public partial class VictimFrm : Form
    {
        Victim victim;

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
            victim = Settings.Victim.Read();
            txt_damage.Text = Settings.Victim.returnPercent();
            cb_characters.SelectedIndex = victim.CharacterID;
            cb_crouchcancel.Checked = victim.Crouching;
            cb_charging.Checked = victim.Charging;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            victim.CharacterID = cb_characters.SelectedIndex;
            victim.Crouching = cb_crouchcancel.Checked;
            victim.Charging = cb_charging.Checked;
            Settings.Victim.Write(victim, txt_damage.Text);

            Close();
        }

        private void txt_damage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }
    }
}
