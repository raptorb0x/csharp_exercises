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
using PracticProject.Forms;


namespace PracticProject.Forms
{
    /// <summary>
    /// Логика взаимодействия для SearchForm.xaml
    /// </summary>
    public partial class SearchForm : Window
    {
        //переменная для хранения выбранного столбца
        private string _resultColumn;
        //переменная для хранения введеного значения в TextBoxSearch
        private string _searchText;
        //переменная для записи результата формы (Ок и отмена)
        private MessageBoxResult _msgResult;
        public SearchForm(DataTable inputDT)
        {
            InitializeComponent();
            //создаем пустой массив _ComboContent для дальнейшего наполнения его данными для Combo Box'a
            List<WorkСlass.ComboboxContent> _comboContent = new List<WorkСlass.ComboboxContent>();
            //Счетчик для индексации столбцов
            int incCol = 0;
            // в массиве прокручиваем столбцы нашей таблицы и
                                // заполняем наш массив Наименование столбца и его индексом
            foreach (DataColumn dCol in inputDT.Columns)
            {
                // создаем пустой объект-контейнер для нашего комбо бокса
                WorkСlass.ComboboxContent cbc = new WorkСlass.ComboboxContent();
                // в свойство id записываем индекс столбца и прибавляем к нему +1 (incCol++)
                cbc.Id = incCol++.ToString();
                // в свойство Value записываем наименование столбца
                cbc.Value = dCol.Caption;
                // добавляем объект-контейнер в наш массив
                _comboContent.Add(cbc);
            }
            // заполняем наш ComboBox данными из нашего массива
            ComboBoxChCol.ItemsSource = _comboContent;
        }
        
        //через это свойство будем возвращать результат переменной _msgResult
        public MessageBoxResult FormResult
        {

            get { return _msgResult; }
        }
        //через это свойство будем возвращать результат переменно ResultColumn
                          // в главный класс (предварительно его преобразовывая в int)
        public int ResultColumn
        {
            get
            {
                try
                {
                    return Convert.ToInt32(_resultColumn);
                }
                //если в преобразовании типо произошла ошибка, то выводим сообщение
                catch (Exception ex)
                {
                    new Forms.Window1(MessageBoxButton.OK, "Произошла ошибка при изменении типа индекса столбца");
                    return -1;
                }
            }
        }
        //через это свойство будем возвращать результат переменной _searchText в главный класс
        public string SearchText
        {
            get { return _searchText; }
        }


        private void buttonOk_Click(object sender, RoutedEventArgs e)
        {
            // проверяем, все ли поля заполнены
            if (String.IsNullOrEmpty(TextBoxSearch.Text) || ComboBoxChCol.SelectedValue == null)
            {
                new Forms.Window1(MessageBoxButton.OK, "Заполните все элементы для поиска");
                return;
            }
            // в раннее подготовленные нами переменные записываем значение
            _searchText = TextBoxSearch.Text;
            _resultColumn = ComboBoxChCol.SelectedValue.ToString();
            // результат формы ОК
            _msgResult = MessageBoxResult.OK;
            // закрываем нашу форму
            this.Close();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            // результат формы - отмена
            _msgResult = MessageBoxResult.Cancel;
            // закрываем форму
            this.Close();
        }
    }
}
