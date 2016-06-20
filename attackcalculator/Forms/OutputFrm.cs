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
        Settings.Output.outputVar curVar;

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
        #region Buttons
        private void btn_savevariable_Click(object sender, EventArgs e)
        {
            curVar.Enabled = cb_enabled.Checked;
            curVar.Name = txt_outputvariable.Text;
            curVar.DataType = cb_datatype.SelectedIndex;
            curVar.PrintMode = cb_print.SelectedIndex;
            Settings.Output.Write(curVar);
        }

        private void btn_saveoutputformat_Click(object sender, EventArgs e)
        {
            Settings.Output.miscWrite(0, txt_outputformat.Text);
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
            curVar = Settings.Output.Read(cb_output.SelectedIndex);
            cb_enabled.Checked = curVar.Enabled;
            txt_outputvariable.Text = curVar.Name;
            if (curVar.DataType == -1)
            {
                cb_datatype.Enabled = false;
            }
            else
            {
                cb_datatype.Enabled = true;
            }
            cb_datatype.SelectedIndex = curVar.DataType;
            if (curVar.PrintMode == -1)
            {
                cb_print.Enabled = false;
            }
            else
            {
                cb_print.Enabled = true;
            }
            cb_print.SelectedIndex = curVar.PrintMode;
        }
    }
}
