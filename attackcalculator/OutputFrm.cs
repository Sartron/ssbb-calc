using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attackcalculator
{
    public partial class OutputFrm : Form
    {
        #region Startup
        public OutputFrm()
        {
            InitializeComponent();
        }

        private void OutputFrm_Load(object sender, EventArgs e)
        {
            cb_output.SelectedIndex = 0;
        }
        #endregion
        private void cb_enabled_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_enabled.Checked)
            {
                txt_outputvariable.Enabled = true;
            }
            else
            {
                txt_outputvariable.Enabled = false;
            }
        }

        private void cb_output_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cb_output.SelectedIndex)
            {
                case 0:
                    break;
                default:
                    //Nothing
                    break;
            }
        }
    }
}
