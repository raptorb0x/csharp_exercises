using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace computer_ver_1
{   
    public partial class PassForm : Form
    { 
        public PassForm(string pmode)
        {
            InitializeComponent();
            modif = pmode;
            if (modif == "change")
            {
                labelPass.Text = "Enter new password:";
            }
        }

        private string modif;

        private void buttonОК_Click(object sender, EventArgs e)
        {
            if (modif == "change")
            {
                Properties.Settings.Default.password = textBoxPass.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
            if (modif == "enter")
            {
                if (textBoxPass.Text == Properties.Settings.Default.password)
                {
                    add addf = new add();
                    addf.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                    textBoxPass.Focus();
                    textBoxPass.Text = "";
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                buttonOK.Focus();
        }
    }
}
