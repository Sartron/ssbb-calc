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
            if (!(String.IsNullOrEmpty(Calculator.Settings.Output.readformat())))
            {
                txt_outputformat.Text = Calculator.Settings.Output.readformat();
            }
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
            string str_vardata = Calculator.Settings.Output.readvariable(cb_output.SelectedIndex);
            string[] str_array_data = str_vardata.Split('/');
            bool bool_enabled = Convert.ToBoolean(str_array_data[0]);
            string str_name = str_array_data[1];

            //Assign settings
            cb_enabled.Checked = bool_enabled;
            txt_outputvariable.Text = str_name;
        }

        private void btn_savevariable_Click(object sender, EventArgs e)
        {
            Calculator.Settings.Output.writevariable(cb_output.SelectedIndex, cb_enabled.Checked, txt_outputvariable.Text);
        }

        private void btn_saveoutputformat_Click(object sender, EventArgs e)
        {
            Calculator.Settings.Output.writeformat(txt_outputformat.Text);
        }
    }
}
