using System;
using System.Windows.Forms;

namespace attackcalculator
{
    public partial class EditFrm : Form //Abandon all hope ye who enter
    {
        private static EditFrm openForm = null;
        public static EditFrm GetInstance(Collision collision, int index)
        {
            if (openForm == null)
            {
                openForm = new EditFrm(collision, index);
                openForm.FormClosed += delegate { openForm = null; };
            }
            return openForm;
        }

        private Collision curCollision;
        private int mainIndex;

        public EditFrm(Collision collision, int index)
        {
            InitializeComponent();
            curCollision = collision;
            mainIndex = index;

            this.Text = $"Editing index {mainIndex}";

            //Fill listParameters
            string[] paramsOC =
            {
                "ID", "Bone", "Damage", "Shield Damage", "Angle", "Base Knockback", "Knockback Growth",
                "Weight Knockback", "Size", "X Offset", "Y Offset", "Z Offset",
                "Z Offset", "Tripping Rate", "Hitlag Multiplier", "SDI Multiplier", "Flags"
            };
            string[] paramsSOC =
{
                "ID", "Bone", "Damage", "Shield Damage", "Angle", "Base Knockback", "Knockback Growth",
                "Weight Knockback", "Size", "X Offset", "Y Offset", "Z Offset",
                "Z Offset", "Tripping Rate", "Hitlag Multiplier", "SDI Multiplier", "Flags", "Rehit Rate", "Special Flags"
            };
            string[] paramsTS =
            {
                "ID", "Bone?", "Damage", "Angle", "Base Knockback", "Knockback Growth",
                "Weight Knockback", "Effect", "UnknownA", "UnknownB", "UnknownC", "UnknownD", "SFX", "Air/Ground",
                "UnknownE", "UnknownF", "Invincibility Frames"
            };

            if (curCollision.GetType() == typeof(OffensiveCollision))
            {
                foreach (string str in paramsOC)
                    listParameters.Items.Add(str);
            }
            else if (curCollision.GetType() == typeof(SpecialOffensiveCollision))
            {
                foreach (string str in paramsSOC)
                    listParameters.Items.Add(str);
            }
            else if (curCollision.GetType() == typeof(ThrowSpecifier))
            {
                foreach (string str in paramsTS)
                    listParameters.Items.Add(str);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
