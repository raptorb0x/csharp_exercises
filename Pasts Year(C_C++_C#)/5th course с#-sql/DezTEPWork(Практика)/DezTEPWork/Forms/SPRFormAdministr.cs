using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace DezTEPWork
{
    public partial class SPRFormAdministr : Form
    {
        public SPRFormAdministr()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SPRFormAdministr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomOC.SPRWORKSVIEW1". При необходимости она может быть перемещена или удалена.
            this.sPRWORKSVIEW1TableAdapter.Fill(this.diplomOC.SPRWORKSVIEW1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomOC.SPRTARIFVIEW1". При необходимости она может быть перемещена или удалена.
            this.sPRTARIFVIEW1TableAdapter.Fill(this.diplomOC.SPRTARIFVIEW1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomOC.SPRPRORABVIEW1". При необходимости она может быть перемещена или удалена.
            this.sPRPRORABVIEW1TableAdapter.Fill(this.diplomOC.SPRPRORABVIEW1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomOC.SPRPOSLED1". При необходимости она может быть перемещена или удалена.
            this.sPRPOSLED1TableAdapter.Fill(this.diplomOC.SPRPOSLED1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomOC.SPRORABVIEW1". При необходимости она может быть перемещена или удалена.
            this.sPRORABVIEW1TableAdapter.Fill(this.diplomOC.SPRORABVIEW1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomOC.SPRKRITVIEW1". При необходимости она может быть перемещена или удалена.
            this.sPRKRITVIEW1TableAdapter.Fill(this.diplomOC.SPRKRITVIEW1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomOC.SPRFONDVIEW1". При необходимости она может быть перемещена или удалена.
            this.sPRFONDVIEW1TableAdapter.Fill(this.diplomOC.SPRFONDVIEW1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomOC.SPRFONDKVVIEW1". При необходимости она может быть перемещена или удалена.
            this.sPRFONDKVVIEW1TableAdapter.Fill(this.diplomOC.SPRFONDKVVIEW1);
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedIndex == 0)
            {
                EventButtonsDelete();

                Interface.SPRInter _SprInter = new Classes.SPRFondWork();
                EventButtons(_SprInter);
                
                dataGridView1.DataSource = sPRFONDVIEW1BindingSource;
                         

            }
            if (listBox1.SelectedIndex == 1)
            {
                EventButtonsDelete();
                
                Interface.SPRInter _SprInter = new Classes.SPRKriterWork();
                EventButtons(_SprInter);

                dataGridView1.DataSource = sPRKRITVIEW1BindingSource;
            

            }
            if (listBox1.SelectedIndex == 2)
            {
                EventButtonsDelete();

                Interface.SPRInter _SprInter = new Classes.SPRTarifWork();
                EventButtons(_SprInter);

                dataGridView1.DataSource = sPRTARIFVIEW1BindingSource;

             

            }
            if (listBox1.SelectedIndex == 3)
            {
                EventButtonsDelete();
                
                Interface.SPRInter _SprInter = new Classes.SPRSnipWork();
                EventButtons(_SprInter);
                
                dataGridView1.DataSource = sPRWORKSVIEW1BindingSource;

            

            }
            if (listBox1.SelectedIndex == 4)
            {
                EventButtonsDelete();
                
                Interface.SPRInter _SprInter = new Classes.SPROrabWork();
                EventButtons(_SprInter);

                dataGridView1.DataSource = sPRORABVIEW1BindingSource;

            }
            if (listBox1.SelectedIndex == 5)
            {
                EventButtonsDelete();
                
                Interface.SPRInter _SprInter = new Classes.SPRRabpoWork();
                EventButtons(_SprInter);

                dataGridView1.DataSource = sPRPOSLED1BindingSource;

         

            }
            if (listBox1.SelectedIndex == 6)
            {
                EventButtonsDelete();
                
                Interface.SPRInter _SprInter = new Classes.SPRRemproWork();
                EventButtons(_SprInter);

                dataGridView1.DataSource = sPRPRORABVIEW1BindingSource;

            

            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {     
        }

        private void EventButtons(Interface.SPRInter Spr)
        {
            button1.Click += Spr.InsertIntoTable;
            button2.Click += Spr.EditTable;
            button3.Click += Spr.DeleteIntoTable;
            
        }
        private void EventButtonsDelete()
        {            
            RemoveClickEvent(button1);
            RemoveClickEvent(button2);
            RemoveClickEvent(button3);
            
        }
        
        private void RemoveClickEvent(Button b)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick",
                BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(b);
            PropertyInfo pi = b.GetType().GetProperty("Events",
                BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(b, null);
            list.RemoveHandler(obj, list[obj]);
        }


        private void SPRFormAdministr_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomOC.SPRWORKSVIEW1". При необходимости она может быть перемещена или удалена.
            this.sPRWORKSVIEW1TableAdapter.Fill(this.diplomOC.SPRWORKSVIEW1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomOC.SPRTARIFVIEW1". При необходимости она может быть перемещена или удалена.
            this.sPRTARIFVIEW1TableAdapter.Fill(this.diplomOC.SPRTARIFVIEW1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomOC.SPRPRORABVIEW1". При необходимости она может быть перемещена или удалена.
            this.sPRPRORABVIEW1TableAdapter.Fill(this.diplomOC.SPRPRORABVIEW1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomOC.SPRPOSLED1". При необходимости она может быть перемещена или удалена.
            this.sPRPOSLED1TableAdapter.Fill(this.diplomOC.SPRPOSLED1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomOC.SPRORABVIEW1". При необходимости она может быть перемещена или удалена.
            this.sPRORABVIEW1TableAdapter.Fill(this.diplomOC.SPRORABVIEW1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomOC.SPRKRITVIEW1". При необходимости она может быть перемещена или удалена.
            this.sPRKRITVIEW1TableAdapter.Fill(this.diplomOC.SPRKRITVIEW1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomOC.SPRFONDVIEW1". При необходимости она может быть перемещена или удалена.
            this.sPRFONDVIEW1TableAdapter.Fill(this.diplomOC.SPRFONDVIEW1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diplomOC.SPRFONDKVVIEW1". При необходимости она может быть перемещена или удалена.
            this.sPRFONDKVVIEW1TableAdapter.Fill(this.diplomOC.SPRFONDKVVIEW1);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
