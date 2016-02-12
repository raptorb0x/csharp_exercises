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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.OleDb;
using System.Configuration;
using System.Data;
using PracticProject.WorkClasses;




namespace PracticProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public string CurrentTableName
        {
            get;
            set;
        }

        public string RequestForUpdate
        {
            get;
            set;
        }
       

     private void Spr_Mater_MouseDoubleClick(object sender, MouseButtonEventArgs e)
     {
         DocumentTitle.Text = (sender as TreeViewItem).Header.ToString();
         CurrentTableName = "Spr_Mater";
         RequestForUpdate = "Select * From " + CurrentTableName;
         DataGridOne.DataContext = WorkСlass.ReadRequest(RequestForUpdate);
         
     }

     private void SPR_Rab_MouseDoubleClick(object sender, MouseButtonEventArgs e)
     {
         DocumentTitle.Text = (sender as TreeViewItem).Header.ToString();
         CurrentTableName = "SPR_rab";
         RequestForUpdate = "Select * From " + CurrentTableName;
         DataGridOne.DataContext = WorkСlass.ReadRequest(RequestForUpdate);
     }

     private void Raspr_mat_MouseDoubleClick(object sender, MouseButtonEventArgs e)
     {
         DocumentTitle.Text = (sender as TreeViewItem).Header.ToString();
         CurrentTableName = "Raspr_mat";
         RequestForUpdate = "SELECT Raspr_mat.Id, Spr_Rab.[Наименование работы]," +
             "Spr_Mater.[Наименование материала] FROM Spr_Mater INNER JOIN" +
    "(Spr_Rab INNER JOIN Raspr_mat ON Spr_Rab.id = Raspr_mat.[Наименование работы])" +
    "ON Spr_Mater.Id = Raspr_mat.[Наименование материала]";
         DataGridOne.DataContext = WorkСlass.ReadRequest(RequestForUpdate);
     }

     private void MenuItem_Click(object sender, RoutedEventArgs e)
     {
         this.Close();
     }

     private void MenuItemAddRow_Click(object sender, RoutedEventArgs e)
     {
         AddRowsTable(WorkСlass.FormMode.AddMode);
     }
        private void AddRowsTable(WorkСlass.FormMode mode)
        {
            if (String.IsNullOrEmpty(CurrentTableName))
            {
                new Forms.Window1(MessageBoxButton.OK, "Нет активной таблицы");
                return;
            }
            switch (CurrentTableName)
            {
                case "Raspr_mat":
                    {
                        switch (mode)
                        {
                            case WorkСlass.FormMode.AddMode:
                                {
                                    Forms.RasprMaterForm s = new PracticProject.Forms.RasprMaterForm(null);
                                    s.ShowDialog();
                                } break;
                            case WorkСlass.FormMode.ChangeMode:
                                {
                                    //если нет выделенной строки, то выдаем сообщение об ошибке
                                    if (DataGridOne.SelectedValue == null)
                                    {
                                        new Forms.Window1(MessageBoxButton.OK, "Для начала необходимо указать строку..");
                                        return;
                                    }
                                    // создаем пустую строку и записываем в нее значение выделенной строки
                                    DataRow currentDatarow = (DataGridOne.SelectedItem as DataRowView).Row;
                                    // создаем пустой словарь для записи значений
                                    Dictionary<string, string> values = new Dictionary<string, string>();
                                    // Записываем значение "Наименование материала" под ключем NaimMater
                                    values.Add("NaimMater", currentDatarow.ItemArray[2].ToString());
                                    //Записываем значение "Наименование работы" под ключем NaimRab
                                    values.Add("NaimRab", currentDatarow.ItemArray[1].ToString());
                                    //Записываем идентификатор строки под ключем id (он нужен для того
                                    //            чтобы в запросе указать какую именно строку изменять)
                                    values.Add("id", currentDatarow.ItemArray[0].ToString());
                                    // передаем в конструктор значения..
                                    Forms.RasprMaterForm s = new PracticProject.Forms.RasprMaterForm(values);
                                    s.ShowDialog();
                                } break;
                        }
                    } break;
                default:
                    {
                        new Forms.Window1(MessageBoxButton.OK, "Действие на таблицу" + CurrentTableName +" не указано.");
                    } break;
                case "Spr_Mater":
                    {
                        switch (mode)
                        {
                            case WorkСlass.FormMode.AddMode:

                    {
                        Forms.MaterForm s = new PracticProject.Forms.MaterForm();
                        s.ShowDialog();
                    } break;
                            case WorkСlass.FormMode.ChangeMode:
                                {
                                    //если нет выделенной строки, то выдаем сообщение об ошибке
                                    if (DataGridOne.SelectedValue == null)
                                    {
                                        new Forms.Window1(MessageBoxButton.OK, "Для начала необходимо указать строку..");
                                        return;
                                    }
                                    // создаем пустую строку и записываем в нее значение выделенной строки
                                    DataRow currentDataRow = (DataGridOne.SelectedItem as DataRowView).Row;
                                    //переменная для записи выделенного значения и ID
                                    string value, ID;
                                    ID = currentDataRow.ItemArray[0].ToString();
                                    value = currentDataRow.ItemArray[1].ToString();
                                    Forms.EditMaterForm s = new PracticProject.Forms.EditMaterForm(ID, value);
                                    s.ShowDialog();
                                } break;
                        }
                    } break;
                case "SPR_rab":
                    {
                     switch (mode)
                        {
                            case WorkСlass.FormMode.AddMode:
                                {
                                    Forms.RabForm s = new PracticProject.Forms.RabForm();
                                    s.ShowDialog();
                                } break;
                            case WorkСlass.FormMode.ChangeMode:
                                {
                                    //если нет выделенной строки, то выдаем сообщение об ошибке
                                    if (DataGridOne.SelectedValue == null)
                                    {
                                        new Forms.Window1(MessageBoxButton.OK, "Для начала необходимо указать строку...");
                                        return;
                                    }
                                    DataRow currentDataRow = (DataGridOne.SelectedItem as DataRowView).Row;
                                    //переменная для записи выделенного значения и ID
                                    string value, ID;
                                    ID = currentDataRow.ItemArray[0].ToString();
                                    value = currentDataRow.ItemArray[1].ToString();
                                    Forms.EditRabForm s = new PracticProject.Forms.EditRabForm(ID, value);
                                    s.ShowDialog();
                                } break;
                        }
                    }break;


            }
        }

     private void MenuItemUpdate_Click(object sender, RoutedEventArgs e)
     {
         DataGridOne.DataContext = WorkСlass.ReadRequest(RequestForUpdate);
     }

     private void MenuItemEditRow_Click(object sender, RoutedEventArgs e)
     {
         // вызываем метод добавления с режимом "Изменить"
         AddRowsTable(WorkСlass.FormMode.ChangeMode);
     }

     private void MenuItemDeleteRow_Click(object sender, RoutedEventArgs e)
     {
         // если нет выделенной строки, то выдаем сообщения об ошибке
         if (DataGridOne.SelectedValue == null)
         {
             new Forms.Window1(MessageBoxButton.OK, "Для начала необходимо выделить строку..");
             return;
         }
         // создаем пустую строку и записываем в нее значение выделенной строки
         DataRow currentDataRow = (DataGridOne.SelectedItem as DataRowView).Row;
         // в массиве данной строки выбираем нулевоую колонку (это id строки в базе)
         string deleteId = currentDataRow.ItemArray[0].ToString();
         // удаляем с помощью оператора Delete
         WorkСlass.ExecuteRequest("Delete from " + CurrentTableName + " where id=" + deleteId);
         //вызываем функцию обновления
         DataGridOne.DataContext = WorkСlass.ReadRequest(RequestForUpdate);

     }

     private void MenuItemSearchRow_Click(object sender, RoutedEventArgs e)
     {
         //создаем пустую DataTable
         DataTable dt = new DataTable();
         // и записываем в нее таблицу базы данных
         dt = WorkСlass.ReadRequest(RequestForUpdate);
         // если таблица пустая, то выходим
         if (dt == null) return;
         // создаем указатель на класс - в качестве аргумента передаем нашу таблицу
         Forms.SearchForm sf = new Forms.SearchForm(dt);
         // показываем окно
         sf.ShowDialog();
         // если пользователь нажал отмена, то выходим
         if (sf.FormResult == MessageBoxResult.Cancel) return;
         // создаем временную таблицу - в нее будут записываться строки нашей таблицы прошедшие поиск
         DataTable sortingDataTable = new DataTable();

         // в цикле прокручиваем столбцы нашей таблицы
         foreach (DataColumn dCol in dt.Columns)
         {
             // создаем во временной таблице столбцы с таким же наименованием
             sortingDataTable.Columns.Add(dCol.Caption);
         }
         // в цикле прокручиваем строки нашей таблицы
         foreach (DataRow dRow in dt.Rows)
         
             // если в текущей строке в ячуйке под номером sf.ResultColumn встречается sf.SearchText
             if (dRow.ItemArray[sf.ResultColumn].ToString().Contains(sf.SearchText))
                 //, то записываем данную строку в нашу временную таблицу
                 sortingDataTable.Rows.Add(dRow.ItemArray);
             // присваеваем временную таблицу в качестве контекста данных для нашего Data Grid
             DataGridOne.DataContext = sortingDataTable;
     }

    

    
  
   }
 
}
