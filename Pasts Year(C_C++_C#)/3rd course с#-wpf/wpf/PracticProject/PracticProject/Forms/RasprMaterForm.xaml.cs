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
    /// Логика взаимодействия для RasprMaterForm.xaml
    /// </summary>
    public partial class RasprMaterForm : Window
    {
        //переменная для установки режима формы
        private WorkСlass.FormMode _formMode;
        //переменная для записи изменяемой строки(в режиме изменения)
        private string changeRowId = string.Empty;
        

        public RasprMaterForm(Dictionary<string,string> currentValue)
        {
            InitializeComponent();
            // записываем во временный DataTable содержание таблицы Spr_mater
            DataTable dt1 = WorkСlass.ReadRequest("Select * from Spr_Mater");
            // создаем динамический массив (list) переменных типа ComboBoxContent
            List<WorkСlass.ComboboxContent> ts1 = new List<WorkСlass.ComboboxContent>();
            // создаем цикл в котором будем прокручивать строки нашей таблицы
            foreach (DataRow drow in dt1.Rows)
            {
                // создаем временный указатель на класса ComboBoxContent
                WorkСlass.ComboboxContent t = new WorkСlass.ComboboxContent();
                // записываем в него данные из текущей строки
                t.Id = drow.ItemArray[0].ToString();
                t.Value = drow.ItemArray[1].ToString();
                // добавляем данных указатель в массив
                ts1.Add(t);
            }
            // присваеваем наш заполненный массив даннх к источнику данных в комбо боксе
            ComboBoxMater.ItemsSource = ts1;

            // то же самое для 2-го комбо бокса
            DataTable dt2 = WorkСlass.ReadRequest("Select * from SPR_rab");
            List<WorkСlass.ComboboxContent> ts2 = new List<WorkСlass.ComboboxContent>();
            foreach (DataRow drow in dt2.Rows)
            {
                WorkСlass.ComboboxContent t = new WorkСlass.ComboboxContent();
                t.Id = drow.ItemArray[0].ToString();
                t.Value = drow.ItemArray[1].ToString();
                ts2.Add(t);
            }
            ComboBoxRab.ItemsSource = ts2;
            // если есть значения для вставки, то..
            if (currentValue != null)
            {
                // Устанавливаем режим формы на изменение
                _formMode = WorkСlass.FormMode.ChangeMode;
                // Указываем, что будем изменять именно эту строку
                changeRowId = currentValue["id"];
                // ищем в нашем массиве значений для данного комбо бокса нужную строку
                foreach (WorkClasses.WorkСlass.ComboboxContent cbc in ts1)
                    // извлекаем из словаря значение под ключем "NaimMater"
                    if (cbc.Value.Equals(currentValue["NaimMater"]))
                        // указываем найденное значение как "Выделенный элемент"
                        ComboBoxMater.SelectedItem = cbc;
                // для 2го комбо бокса
                foreach (WorkClasses.WorkСlass.ComboboxContent cbc in ts2)
                    if (cbc.Value.Equals(currentValue["NaimRab"]))
                        ComboBoxRab.SelectedItem = cbc;
            }
            else
            {
                // иначе устанавливаем режим на добавление
                _formMode = WorkСlass.FormMode.AddMode;
            }

        }
        //нажатие кнопки Ok
        private void buttonOk_Click(object sender, RoutedEventArgs e)
        {
            //проверяем, все ли поля заполнены
            if (ComboBoxMater.SelectedValue == null || ComboBoxRab.SelectedValue == null)
            {
                new Forms.Window1(MessageBoxButton.OK, "Не все поля заполнены..");
                return;
            }
            // WorkClass.ExecuteRequest("INSERT INTO SPR_rab ([Наименование работы]) Values ('"+TextBoxName.Text+"')");
            switch (_formMode)
            {
                case WorkСlass.FormMode.AddMode:
                    {


                        // через созданную функцию записываем данные из выбраннх комбо боксов, используя конструкцию INSERT
                        WorkСlass.ExecuteRequest("INSERT INTO Raspr_mat ([Наименование работы], [Наименование материала]) Values(" +
                            ComboBoxRab.SelectedValue + " , " + ComboBoxMater.SelectedValue + ")");
                    } break;
                case WorkСlass.FormMode.ChangeMode:
                    {
                        // обновляем значение строки через оператор SQL запроса UPDATE
                        WorkСlass.ExecuteRequest("Update Raspr_mat SET [Наименование работы] = " + ComboBoxRab.SelectedValue +
                            " , [Наименование Материала] = " + ComboBoxMater.SelectedValue + " WHERE id = " + changeRowId);
                    } break;
            }
            // закрываем окно
            this.Close();
        }
        // Нажатие кнопки Отмена
        

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }




    }
}
