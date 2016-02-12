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
    /// Логика взаимодействия для EditMaterForm.xaml
    /// </summary>
    public partial class EditMaterForm : Window
    {

        private string changeRowId = string.Empty;
        private string changeRowValue = string.Empty;


        public EditMaterForm(string ID, string value)
        {
            InitializeComponent();
            TextBoxMat.Text = value;
            changeRowId = ID;
                       
       }

        private void button_Ok_Click(object sender, RoutedEventArgs e)
        {
            WorkСlass.ExecuteRequest("UPDATE Spr_Mater SET [Наименование материала] = '" + TextBoxMat.Text + "' WHERE id = " + changeRowId);
            this.Close();
        }

        private void button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
        
    }
}
