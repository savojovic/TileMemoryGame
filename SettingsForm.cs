using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Slagalica
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RadioButton checkedButton = gbBrojParova.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if (checkedButton.Text == "6")
            {
                Settings.numOfQuestions = 6;
            }else if(checkedButton.Text == "8")
            {
                Settings.numOfQuestions = 8;
            }else
            {
                Settings.numOfQuestions = 10;
            }
            Settings.username = tbUsername.Text;
            Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            int numOfQuestions = Settings.numOfQuestions;
            if(numOfQuestions == 6)
            {
                rbSix.Checked = true;
            }
            else if(numOfQuestions == 8)
            {
                rbEight.Checked = true;
            }
            else
            {
                rbTen.Checked = true;
            }
            tbUsername.Text = Settings.username;
        }
    }
}
