using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using PracticProject.WorkClasses;

namespace PracticProject.Forms
{
    /// <summary>
    /// Логика взаимодействия для RabForm.xaml
    /// </summary>
    public partial class RabForm : Window
    {
        public RabForm()
        {
            InitializeComponent();
        }

       

        private void button_Cancel_1_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }

        private void button_Ok_1_Click(object sender, RoutedEventArgs e)
        {
            WorkСlass.ExecuteRequest("INSERT INTO SPR_rab ([Наименование работы])  VALUES ('" + TextBoxRab.Text + "')");
            this.Close();
        }
    }
}
