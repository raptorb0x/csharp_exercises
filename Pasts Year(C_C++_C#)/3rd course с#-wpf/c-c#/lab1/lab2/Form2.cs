using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace lab2
{
    public partial class Form2 : Form
    {
        private MasterAnswers answers = new MasterAnswers();
        public MasterAnswers Answers
        {
            get { return answers; }
            set { if (value is MasterAnswers) answers = value; }
        }
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            foreach (Control c in tabPage1.Controls)
            {
                if (c is RadioButton)
                {
                    if(((RadioButton) c).Text == "Мужчины" && ((RadioButton) c).Checked) 
                    {
                        answers._gender = 0;
                    }
                    else if (((RadioButton)c).Text == "Женщины" && ((RadioButton)c).Checked)
                    {
                        answers._gender = 1;
                    }
                }
            }

            foreach (Control c in tabPage2.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                    {
                        switch (((CheckBox)c).Text)
                        {
                            case "от 20 до 30": answers._age_groups.Add(0); break;
                            case "от 30 до 40": answers._age_groups.Add(1); break;
                            case "от 40 до 50": answers._age_groups.Add(2); break;
                            case "старше 50": answers._age_groups.Add(3); break;
                        }
                    }
                }
            }

            foreach (Control c in tabPage3.Controls)
            {
                if (c is RadioButton)
                {
                    if (((RadioButton)c).Text == "Да" && ((RadioButton)c).Checked)
                    {
                        answers._need_company_name = 0;
                    }
                    else if (((RadioButton)c).Text == "Нет" && ((RadioButton)c).Checked)
                    {
                        answers._need_company_name = 1;
                    }
                }
            }

            Close();

        }
        private void tab_index_changed(object sender, EventArgs e)
        {
            {
                if (tabControl1.SelectedIndex == 2)
                {
                    button1.Enabled = false;
                    button3.Enabled = true;
                    button2.Enabled = true;
                }
                else
                {
                    if (tabControl1.SelectedIndex == 0)
                        button2.Enabled = false;
                    else
                        button2.Enabled = true;
                    button3.Enabled = false;
                    button1.Enabled = true;
                }
            }

        }





    }
}
