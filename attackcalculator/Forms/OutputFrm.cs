using System;
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
            cB_outputType.SelectedIndex = 0;
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
            Settings.Output.miscWrite(cB_outputType.SelectedIndex, txt_outputformat.Text);
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
            if (curVar.ID == 12)
            {
                cb_print.Items.Add("No Output");
            }
            else
            {
                if (cb_print.Items.Count == 3)
                    cb_print.Items.RemoveAt(2);
            }
            cb_print.SelectedIndex = curVar.PrintMode;
        }

        private void cB_outputType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_outputformat.Text = Settings.Output.miscRead(cB_outputType.SelectedIndex);
        }
    }
}