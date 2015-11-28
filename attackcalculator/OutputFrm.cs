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
        #region Buttons
        private void btn_savevariable_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_outputvariable.Text))
            {
                Calculator.Settings.Output.writevariable(cb_output.SelectedIndex, false, txt_outputvariable.Text, cb_datatype.SelectedIndex, cb_print.SelectedIndex);
            }
            else
            {
                Console.WriteLine(cb_print.SelectedIndex);
                Calculator.Settings.Output.writevariable(cb_output.SelectedIndex, cb_enabled.Checked, txt_outputvariable.Text, cb_datatype.SelectedIndex, cb_print.SelectedIndex);
            }
        }

        private void btn_saveoutputformat_Click(object sender, EventArgs e)
        {
            Calculator.Settings.Output.writeformat(txt_outputformat.Text);
        }
        #endregion
        #region Textboxes
        private void txt_outputvariable_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_outputvariable.Text))
            {
                cb_enabled.Checked = false;
            }
        }

        private void txt_outputvariable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
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

            if (cb_output.SelectedIndex == 21 || cb_output.SelectedIndex == 20 || cb_output.SelectedIndex == 19)
            {
                cb_datatype.Enabled = true;
                cb_print.Enabled = true;
            }
            else if (cb_output.SelectedIndex == 18 || cb_output.SelectedIndex == 17 || cb_output.SelectedIndex == 12)
            {
                cb_datatype.Enabled = false;
                cb_print.Enabled = true;
                if (cb_output.SelectedIndex == 12 && cb_print.Items.Count == 2)
                {
                    cb_print.Items.Add("Wipe Hitbox Statement");
                }
                else if (cb_output.SelectedIndex == 17 && cb_print.Items.Count == 3)
                {
                    cb_print.Items.Remove("Wipe Hitbox Statement");
                }
            }
            else if (cb_output.SelectedIndex == 11)
            {
                cb_datatype.Enabled = true;
                cb_print.Enabled = false;
            }
            else
            {
                cb_datatype.Enabled = false;
                cb_print.Enabled = false;
            }

            cb_enabled.Checked = Convert.ToBoolean(str_array_data[0]);
            txt_outputvariable.Text = str_array_data[1];
            cb_datatype.SelectedIndex = Convert.ToInt16(str_array_data[2]);
            cb_print.SelectedIndex = Convert.ToInt16(str_array_data[3]);
        }
    }
}
