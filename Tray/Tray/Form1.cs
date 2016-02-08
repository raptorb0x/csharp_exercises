﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            m_menu.MenuItems.Add(0, new MenuItem("В почту", new EventHandler(Mail_Click)));
            m_menu.MenuItems.Add(1, new MenuItem("Настройки", new EventHandler(Settings_Click)));
            m_menu.MenuItems.Add(2, new MenuItem("Выход", new EventHandler(Exit_Click)));
            notifyIcon1.ContextMenu = m_menu;
        }

        private void Open_gmail()
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "https://gmail.com";
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            p.Start();
        }

        private void Check_mail()
        {

            try
            {
                var imap = new ImapClient("imap.gmail.com", Properties.Settings.Default.Login, Properties.Settings.Default.Password, ImapClient.AuthMethods.Login, 993, true);
                imap.SelectMailbox("INBOX");
                var unseenList = imap.SearchMessages(SearchCondition.Unseen());
                if (unseenList.Count() != 0)
                {
                    notifyIcon1.ShowBalloonTip(1000, "Gmail", "Непрочтитанных сообщений - " + unseenList.Count().ToString(), ToolTipIcon.Info);
                }
            }

            catch (Exception)
            {
                timer.Stop();
                MessageBox.Show("Не могу зайти на почту, проверьте настройки.");
                Settings_form();
            }

        }

        private void Settings_form()
        {
            Form2 form = new Form2();
            form.Owner = this;
            form.ShowDialog();
        }

        private void Tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Open_gmail();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = true;
                this.Visible = false;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;


            if(Properties.Settings.Default.Login == "example@gmail.com")
            {
                Settings_form();
            }

            Check_mail();
            timer.Enabled = true;
            timer.Start();
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            Check_mail();
        }

        private void Exit_Click(Object sender, System.EventArgs e)
        {
            Close();
        }

        private void Settings_Click(Object sender, System.EventArgs e)
        {
            timer.Stop();
            Settings_form();
        }

        private void Mail_Click(object sender, EventArgs e)
        {
            Open_gmail();
        }

    }
}