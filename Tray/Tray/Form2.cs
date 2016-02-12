using AE.Net.Mail;
using System;
using System.Windows.Forms;
namespace Tray
{
    /// <summary>
    /// Класс формы настроек
    /// </summary>
    public partial class Form2 : Form
    {
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка сохраненный настроек в textbox'ы
        /// </summary>
        private void LoadSettings()
        {
            //Загружаем логин, пароль  время таймера в соотвествующие textbox'ы
            this.textBox1.Text = Properties.Settings.Default.Login;
            this.textBox2.Text = Properties.Settings.Default.Password;
            this.textBox3.Text = Properties.Settings.Default.TimerTime.ToString();
        }

        /// <summary>
        /// Сохранения настроек
        /// </summary>
        private void SaveSetting()
        {
            //Берем значения настроек из соотвествующих textbox'ов 
            Properties.Settings.Default.Login = this.textBox1.Text;
            Properties.Settings.Default.Password = this.textBox2.Text;
            Properties.Settings.Default.TimerTime = Int32.Parse(this.textBox3.Text);
            
            //Сохраняем настройки в файле что по адресу
            //C:\Users\[USER]\AppData\Local\Tray\Tray.*\1.0.0.0\user.config
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Обработчик события показа формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Shown(object sender, EventArgs e)
        {
            //Подгружаем настройки
            this.LoadSettings();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Сохраняем настройки
            SaveSetting();
            
            //Обращаемся к хозяину 
            Form1 main = (Form1)Owner;

            //Настраиваем и запускаем его таймер
            main.timer.Interval = Properties.Settings.Default.TimerTime * 1000;
            main.timer.Start();
            
            //Закрываем форму настроек
            Close();
        }
        /// <summary>
        /// Обработчик события нажатия на кнопку "Проверить" 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //проверяем соединение
            try
            {
                //Создаем соединение - если оно не установится то ловим его исключение
                var imap = new ImapClient("imap.gmail.com", this.textBox1.Text, this.textBox2.Text, ImapClient.AuthMethods.Login, 993, true);

                //Когда установилось, сохраняем эти настройки
                SaveSetting();

                //Делаем метку видимой и меняем ей текст
                label3.Visible = true;
                label3.Text = "Вход выполнен";
            }
            //ловим исключение
            catch (Exception)
            {
                //Делаем метку видимой и меняем ей текст
                label3.Visible = true;
                label3.Text = "Ошибка входа";
            }
        }

        /// <summary>
        /// Проявка и сокрытие пароля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //Пароль скрыт проявляем его, если нет, скрываем
            textBox2.UseSystemPasswordChar = (textBox2.UseSystemPasswordChar) ? false : true;
        }
    }
}
