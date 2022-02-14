using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class DifficultyLevelSelecting : Form
    {
        public String LevelConfirmation = "";

        public DifficultyLevelSelecting()
        {
            InitializeComponent();
        }

        private void Confirmation_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectHardLevel_CheckedChanged_1(object sender, EventArgs e)
        {
            Confirmation_Button.Enabled = true;
            Confirmation_Button.Text = "HARD level selected";
            LevelConfirmation = "HARD";
            SelectEasyLevel.Checked = false;
            SelectEasyLevel.CheckState = CheckState.Unchecked;
        }

        private void SelectEasyLevel_CheckedChanged_1(object sender, EventArgs e)
        {
            Confirmation_Button.Enabled = true;
            Confirmation_Button.Text = "EASY level selected";
            LevelConfirmation = "EASY";
            SelectHardLevel.Checked = false;
            SelectHardLevel.CheckState = CheckState.Unchecked;
        }
    }
}
