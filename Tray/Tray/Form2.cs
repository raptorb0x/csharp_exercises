using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AE.Net.Mail;
namespace Tray
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LoadSettings()
        {
            this.textBox1.Text = Properties.Settings.Default.Login;
            this.textBox2.Text = Properties.Settings.Default.Password;
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            this.LoadSettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Login = this.textBox1.Text;
            Properties.Settings.Default.Password = this.textBox2.Text;
            Properties.Settings.Default.Save();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(Properties.Settings.Default.Login + Properties.Settings.Default.Password);
                var imap = new ImapClient("imap.gmail.com", this.textBox1.Text, this.textBox2.Text, ImapClient.AuthMethods.Login, 993, true);
            }
            catch (Exception)
            {

                MessageBox.Show("Не подходит");
            }

            MessageBox.Show("Подходит");

        }
    }
}
