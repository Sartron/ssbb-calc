using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace attackcalculator
{
    public partial class MiscFrm : Form
    {
        private static MiscFrm openForm;
        public static MiscFrm GetInstance(OffensiveCollision collision, int index)
        {
            if (openForm == null)
            {
                openForm = new MiscFrm(collision, index);
                openForm.FormClosed += delegate { openForm = null; };
            }

            return openForm;
        }

        private OffensiveCollision curCollision;
        private int mainIndex;

        public MiscFrm(OffensiveCollision collision, int index)
        {
            InitializeComponent();
            curCollision = collision;
            mainIndex = index;

            Text = $"Viewing index {mainIndex}";
            comboMode.SelectedIndex = 0;
        }

        private void resetFields()
        {
            lblValue1.Text = "Value1";
            lblValue2.Text = "Value2";
            lblValue3.Text = "Value3";
            lblOutput.Text = "Output";
            txtValue1.Text = String.Empty;
            txtValue2.Text = String.Empty;
            txtValue3.Text = String.Empty;
            txtOutput.Text = String.Empty;

            txtValue1.Enabled = false;
            txtValue2.Enabled = false;
            txtValue3.Enabled = false;
        }
        private void comboMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetFields();
            switch (comboMode.SelectedIndex)
            {
                case 0:
                    lblValue1.Text = "Hit Frame";
                    lblValue2.Text = "Duration/IASA - 1";
                    lblOutput.Text = "Advantage";

                    txtValue1.Enabled = true;
                    txtValue2.Enabled = true;
                    break;
                case 1:
                    lblValue1.Text = "Landing Lag";
                    lblOutput.Text = "Advantage";

                    txtValue1.Enabled = true;
                    break;
                case 2:
                    lblValue1.Text = "Last Hit Frame";
                    lblValue2.Text = "Window Frame"; //First Window Frame preferably
                    lblValue3.Text = "Landing Lag";
                    lblOutput.Text = "Advantage";

                    txtValue1.Enabled = true;
                    txtValue2.Enabled = true;
                    txtValue3.Enabled = true;
                    break;
                case 3:
                    lblOutput.Text = "Damage";

                    calculateChargeDamage();
                    break;
            }
        }

        private void txtValue1_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        private void txtValue1_TextChanged(object sender, EventArgs e)
        {
            switch (comboMode.SelectedIndex)
            {
                case 0:
                    calculateAdvantage();
                    break;
                case 1:
                    calculateAerialAdvantage();
                    break;
                case 2:
                    calculateAerialACAdvantage();
                    break;
            }
        }

        private void txtValue2_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        private void txtValue2_TextChanged(object sender, EventArgs e)
        {
            switch (comboMode.SelectedIndex)
            {
                case 0:
                    calculateAdvantage();
                    break;
                case 2:
                    calculateAerialACAdvantage();
                    break;
            }
        }

        private void txtValue3_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        private void txtValue3_TextChanged(object sender, EventArgs e)
        {
            calculateAerialACAdvantage();
        }

        private void calculateAdvantage()
        {
            if ((!String.IsNullOrEmpty(txtValue1.Text) && !Regex.IsMatch(txtValue1.Text, @"[^\d]")) && (!String.IsNullOrEmpty(txtValue2.Text) && !Regex.IsMatch(txtValue2.Text, @"[^\d]")))
            {
                int hitlagAdvantage = 0;

                if (curCollision.HitlagMultiplier != 1.0f)
                {
                    int Hitlag_default, Hitlag_1x;
                    float storeMultiplier = curCollision.HitlagMultiplier;

                    Hitlag_default = curCollision.HitlagAttacker;
                    curCollision.HitlagMultiplier = 1.0f;
                    Hitlag_1x = curCollision.HitlagAttacker;
                    curCollision.HitlagMultiplier = storeMultiplier;

                    hitlagAdvantage = Hitlag_1x - Hitlag_default;
                }

                txtOutput.Text = (Convert.ToInt32(txtValue1.Text) + curCollision.Shieldstun - Convert.ToInt32(txtValue2.Text) + hitlagAdvantage).ToString();
            }
        }

        private void calculateAerialAdvantage()
        {
            if (!String.IsNullOrEmpty(txtValue1.Text) && !Regex.IsMatch(txtValue1.Text, @"[^\d]"))
            {
                int hitlagAdvantage = 0;

                if (curCollision.HitlagMultiplier != 1.0f)
                {
                    int Hitlag_default, Hitlag_1x;
                    float storeMultiplier = curCollision.HitlagMultiplier;

                    Hitlag_default = curCollision.HitlagAttacker;
                    curCollision.HitlagMultiplier = 1.0f;
                    Hitlag_1x = curCollision.HitlagAttacker;
                    curCollision.HitlagMultiplier = storeMultiplier;

                    hitlagAdvantage = Hitlag_1x - Hitlag_default;
                }

                txtOutput.Text = String.Format("{0}/{1}", (curCollision.Shieldstun + hitlagAdvantage) - Convert.ToInt32(txtValue1.Text),
                    (curCollision.Shieldstun + hitlagAdvantage) - Math.Floor(Convert.ToDouble(txtValue1.Text) / 2));
            }
        }

        private void calculateAerialACAdvantage()
        {
            if ((!String.IsNullOrEmpty(txtValue1.Text) && !Regex.IsMatch(txtValue1.Text, @"[^\d]")) && (!String.IsNullOrEmpty(txtValue2.Text) && !Regex.IsMatch(txtValue2.Text, @"[^\d]")) &&
                (!String.IsNullOrEmpty(txtValue3.Text) && !Regex.IsMatch(txtValue3.Text, @"[^\d]")))
            {
                int hitlagAdvantage = 0;

                if (curCollision.HitlagMultiplier != 1.0f)
                {
                    int Hitlag_default, Hitlag_1x;
                    float storeMultiplier = curCollision.HitlagMultiplier;

                    Hitlag_default = curCollision.HitlagAttacker;
                    curCollision.HitlagMultiplier = 1.0f;
                    Hitlag_1x = curCollision.HitlagAttacker;
                    curCollision.HitlagMultiplier = storeMultiplier;

                    hitlagAdvantage = Hitlag_1x - Hitlag_default;
                }

                //Last Hit Frame + Stun - (First Auto-cancel Window Frame - 1) - Auto-cancel Landing Lag

                txtOutput.Text = (Convert.ToInt32(txtValue1.Text) + (curCollision.Shieldstun + hitlagAdvantage) -
                     (Convert.ToInt32(txtValue2.Text) - 1) - Convert.ToInt32(txtValue3.Text)).ToString();
            }
        }

        private void calculateChargeDamage()
        {
            txtOutput.Text = Math.Floor(curCollision.Damage * 1.3667).ToString();
        }
    }
}