using AE.Net.Mail;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Tray
{
    /// <summary>
    /// Основная форма, которую и не видно
    /// </summary>
    public partial class Form1 : Form
    {
        //Контекстное меню сделано не через дизайнер, потому что там я не нашел именно того меню что надо
        private System.Windows.Forms.ContextMenu m_menu;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public Form1()
        {
            //Инициализация компонента
            InitializeComponent();

            //Создаем меню
            this.m_menu = new System.Windows.Forms.ContextMenu();
            //Формируем поля контекстного меню
            m_menu.MenuItems.Add(0, new MenuItem("В почту", new EventHandler(Mail_Click)));
            m_menu.MenuItems.Add(1, new MenuItem("Настройки", new EventHandler(Settings_Click)));
            m_menu.MenuItems.Add(2, new MenuItem("Выход", new EventHandler(Exit_Click)));

            //Привязываем контекстное меню к иконке
            notifyIcon1.ContextMenu = m_menu;
        }

        /// <summary>
        /// Открытие почты
        /// </summary>
        private void Open_gmail()
        {
            //Работаем через класс process
            //создаем новый процесс
            System.Diagnostics.Process open_url = new System.Diagnostics.Process();
           
            //Передаем ему url ссылку
            open_url.StartInfo.FileName = "https://gmail.com";
            
            //Запускаем процесс -> url ссылка будет открыта в браузере по умолчанию
            open_url.Start();
        }

        /// <summary>
        /// Проверка почты 
        /// </summary>
        private void Check_mail()
        {
            //Проверяем доступность почты как таковой
            try
            {
                //Используем методы из библиотеки AE.Net.Mail
                //Создаем коннект на почту
                var imap = new ImapClient("imap.gmail.com", Properties.Settings.Default.Login, Properties.Settings.Default.Password, ImapClient.AuthMethods.Login, 993, true);
                
                //Идем во входящие
                imap.SelectMailbox("INBOX");
                
                //Ищем во входящих все сообщения, которые еще не прочитаны
                var unseenList = imap.SearchMessages(SearchCondition.Unseen());

                //Если такие есть
                if (unseenList.Count() != 0)
                {
                    //Выводим всплывающее окошко в трее о их наличии
                    notifyIcon1.ShowBalloonTip(1000, "Gmail", "Непрочтитанных сообщений - " + unseenList.Count().ToString(), ToolTipIcon.Info);
                }
            }

            //ловим исключение 
            catch (Exception)
            {
                //останавливаем таймер
                timer.Stop();
                
                //Сообщение о недоступности почты
                MessageBox.Show("Не могу зайти на почту, проверьте настройки.");
                
                //Запускаем метод создания формы настроек
                Settings_form();
            }

        }

        /// <summary>
        /// Создание формы настроек 
        /// </summary>
        private void Settings_form()
        {
            //Создаем новую форму
            Form2 form = new Form2();
            
            //Указываем ей её хозяина - основную форму
            form.Owner = this;

            //Запускаем её
            form.ShowDialog();
        }

        /// <summary>
        /// Обработчик события двойного щелчка по иконке в трее
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Открываем почту
            Open_gmail();
        }

        /// <summary>
        /// Обработчик события показа формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Shown(object sender, EventArgs e)
        {
            //Сворачиваем окно
            WindowState = FormWindowState.Minimized;
            //делаем окно невидимым
            Visible = false;

            //Если настроки по дефолту
            if (Properties.Settings.Default.Login == "example@gmail.com")
            {
                //Запускаем форму настроек
                Settings_form();
            }
            
            //Проверяем почту
            Check_mail();

            //Активируем и запускаем таймер
            timer.Interval = Properties.Settings.Default.TimerTime * 1000;
            timer.Enabled = true;
            timer.Start();
        }

        /// <summary>
        /// Обработчик срабатывания таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick_1(object sender, EventArgs e)
        {
            //проверяем почту
            Check_mail();
        }

        /// <summary>
        /// Обработчик выбора из меню - выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(Object sender, System.EventArgs e)
        {
            //Выходим из приложения
            Application.Exit();
        }

        /// <summary>
        /// Обработчик выбора из меню - настройки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Settings_Click(Object sender, System.EventArgs e)
        {
            //Останавливаем таймер
            timer.Stop();

            //Создаем форму настроек
            Settings_form();
        }

        /// <summary>
        /// Обработчик выбора из меню - Почта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mail_Click(object sender, EventArgs e)
        {
            //Открываем почту
            Open_gmail();
        }

    }
}
