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

namespace PracticProject.Forms
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            _formResult = MessageBoxResult.OK;
            this.Close();
        }

        private void ButtonYes_Click(object sender, RoutedEventArgs e)
        {
            _formResult = MessageBoxResult.Yes;
            this.Close();
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            _formResult = MessageBoxResult.Cancel;
            this.Close();
        }
        private MessageBoxResult _formResult;
        public MessageBoxResult FormResult
        {
            get
            {
                return _formResult;
            }
        }
        public Window1(MessageBoxButton buttonMode, string message)
        {
            InitializeComponent();
            switch (buttonMode)
            {
                case MessageBoxButton.YesNo:
                    {
                        ButtonYes.Visibility = Visibility.Visible;
                        ButtonCancel.Visibility = Visibility.Visible;
                    }
                    break;
                case MessageBoxButton.OK:
                    {
                        ButtonOk.Visibility = Visibility.Visible;
                    } break;
                default:
                    {
                        throw new Exception("Указан не верный buttonMode Для класса Message");
                    }
            }
            if (String.IsNullOrEmpty(message)) throw new Exception("Не указан контент для сообщения");
            else TextMessage.Text = message;
            this.ShowDialog();
        }
    }
    
}
