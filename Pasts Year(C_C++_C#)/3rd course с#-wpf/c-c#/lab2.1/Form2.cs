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
        public Form2()
        {
            InitializeComponent();

        }
        private MasterAnswers answers = new MasterAnswers();
        public MasterAnswers Answers
        {
            get { return answers; }
            set { if (value is MasterAnswers) answers = value; }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            
                if (radioButton1.Checked)
                {
                    answers._sock.Add(0);
                    answers._sock.Add(1);
                    answers._sock.Add(4);
                }
                if (radioButton2.Checked)
                {
                    answers._sock.Add(2);
                    answers._sock.Add(3);
                    answers._sock.Add(5);
                }
                if (radioButton18.Checked)
                {
                    answers._sock.Add(0);
                    answers._sock.Add(1);
                    answers._sock.Add(4);
                    answers._sock.Add(2);
                    answers._sock.Add(3);
                    answers._sock.Add(5);
                }
            /* */
            
                if (radioButton3.Checked)
                {
                    answers._graph.Add(1);
                }
                if (radioButton4.Checked)
                {
                    answers._graph.Add(0);
                }
                if (radioButton19.Checked)
                {
                    answers._graph.Add(0);
                    answers._graph.Add(1);
                }
            /**/
                if (radioButton5.Checked)
                {
                    answers._graphpu.Add(1);
                }
                if (radioButton6.Checked)
                {
                    answers._graphpu.Add(0);
                }
                if (radioButton20.Checked)
                {
                    answers._graphpu.Add(0);
                    answers._graphpu.Add(1);
                }
            /**/
                if (radioButton7.Checked)
                {
                    answers._pci.Add(0);
                }
                if (radioButton8.Checked)
                {
                    answers._pci.Add(1);
                }
                if (radioButton9.Checked)
                {
                    answers._pci.Add(2);
                }
                if (radioButton21.Checked)
                {
                    answers._pci.Add(0);
                    answers._pci.Add(1);
                    answers._pci.Add(2);
                }
            /**/
                if (radioButton10.Checked)
                {
                    answers._ddr.Add(0);
                }
                if (radioButton11.Checked)
                {
                    answers._ddr.Add(1);
                }
                if (radioButton22.Checked)
                {
                    answers._ddr.Add(1);
                    answers._ddr.Add(0);
                }
            /**/
                if (radioButton12.Checked)
                {
                    answers._sata.Add(0);
                }
                if (radioButton13.Checked)
                {
                    answers._sata.Add(1);
                }
                if (radioButton14.Checked)
                {
                    answers._sata.Add(2);
                }
                if (radioButton23.Checked)
                {
                    answers._sata.Add(0);
                    answers._sata.Add(1);
                    answers._sata.Add(2);
                }
            /**/
                if (radioButton15.Checked)
                {
                    answers._price.Add(0);
                }
                if (radioButton16.Checked)
                {
                    answers._price.Add(1);
                }
                if (radioButton17.Checked)
                {
                    answers._price.Add(2);
                }
                if (radioButton24.Checked)
                {
                    answers._price.Add(0);
                    answers._price.Add(1);
                    answers._price.Add(2);
                }
            Close();
        }




    }
}
