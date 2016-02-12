using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace computer_ver_1
{
    public partial class Master : Form
    {
        public string p;
        public Master()
        {
            InitializeComponent();
            tabControl1.SelectedIndexChanged += new System.EventHandler(this.tab_index_changed);
            buttonPrevious.Enabled = false;
            buttonOK.Enabled = false;
        }
        #region Dictionary
        public Dictionary<string, Expoints> _quest1 = new Dictionary<string, Expoints>();
        public Dictionary<string, Expoints> _quest2 = new Dictionary<string, Expoints>();
        public Dictionary<string, Expoints> _quest3 = new Dictionary<string, Expoints>();
        public Dictionary<string, Expoints> _quest4 = new Dictionary<string, Expoints>();
        public Dictionary<string, Expoints> _quest5 = new Dictionary<string, Expoints>();
        public Dictionary<string, Expoints> _quest6 = new Dictionary<string, Expoints>();
        public Dictionary<string, Expoints> _quest7 = new Dictionary<string, Expoints>();
        public Dictionary<string, Expoints> _quest8 = new Dictionary<string, Expoints>();
        #endregion
        #region comments
        /*Expoints ex = new Expoints(0, 0, 0, 0, 0, 0);
        public MasterAnswers Answers
        {
            get { return answers; }
            set { if (value is MasterAnswers) answers = value; }
        }

        public Expoints Exp 
        {
            get { return ex; }
            set { if (value is Expoints) ex = value; }
        }*/
        #endregion
        private void tab_index_changed(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 7)
            {
                buttonOK.Enabled = true;
                buttonNext.Enabled = false;
                buttonPrevious.Enabled = true;
            }
            else
            {
                if (tabControl1.SelectedIndex == 0)
                    buttonPrevious.Enabled = false;
                else
                    buttonPrevious.Enabled = true;
                    buttonOK.Enabled = false;
                    buttonNext.Enabled = true;
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if ((tabControl1.SelectedIndex == 6) & (checkBox1.Checked))
            {
                tabControl1.SelectedIndex = 2;
            }
            if ((tabControl1.SelectedIndex == 6) & (checkBox2.Checked))
            {
                tabControl1.SelectedIndex = 4;
            }
            if ((tabControl1.SelectedIndex == 4) & (checkBox3.Checked))
            {
                tabControl1.SelectedIndex = 2;
            }
            if ((tabControl1.SelectedIndex == 6) & (checkBox3.Checked))
            {
                tabControl1.SelectedIndex = 5;
            }
            if ((tabControl1.SelectedIndex == 5) & (checkBox4.Checked))
            {
                tabControl1.SelectedIndex = 2;
            }
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }
        
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if ( (tabControl1.SelectedIndex == 1) & (checkBox1.Checked) )
            {
                tabControl1.SelectedIndex = 5; 
            }
            if ((tabControl1.SelectedIndex == 3) & (checkBox2.Checked))
            {
                tabControl1.SelectedIndex = 5;
            }
            if ((tabControl1.SelectedIndex == 1) & (checkBox3.Checked))
            {
                tabControl1.SelectedIndex = 3;
            }
            if ((tabControl1.SelectedIndex == 4) & (checkBox3.Checked))
            {
                tabControl1.SelectedIndex = 5;
            }
            if ((tabControl1.SelectedIndex == 1) & (checkBox4.Checked))
            {
                tabControl1.SelectedIndex = 4;
            }
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBoxQuest1.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                    {
                        switch (((CheckBox)c).Text)
                        {
                            case "Эконом":
                                _quest1.Add("Monitor", new Expoints(0, 0, 2, 0));
                                _quest1.Add("RAM", new Expoints(0, 0, 2, 0));
                                _quest1.Add("CPU", new Expoints(0, 0, 2, 0));
                                _quest1.Add("VideoCard", new Expoints(0, 0, 2, 0));
                                _quest1.Add("Audio", new Expoints(0, 0, 2, 0));
                                _quest1.Add("HDD", new Expoints(0, 0, 2, 0));
                                _quest1.Add("MotherBoard", new Expoints(0, 0, 2, 0));
                                _quest1.Add("PowerBox", new Expoints(0, 0, 2, 0));
                                _quest1.Add("Box", new Expoints(0, 0, 2, 0));
                                _quest1.Add("Mouse", new Expoints(0, 0, 2, 0));
                                _quest1.Add("Keyboard", new Expoints(0, 0, 2, 0));
                                _quest1.Add("Microphone", new Expoints(0, 0, 2, 0));
                                _quest1.Add("kolonki", new Expoints(0, 0, 2, 0));
                                _quest1.Add("Hearphone", new Expoints(0, 0, 2, 0));
                                _quest1.Add("Webcam", new Expoints(0, 0, 2, 0));
                                _quest1.Add("Printer", new Expoints(0, 0, 2, 0));
                                _quest1.Add("Scaner", new Expoints(0, 0, 2, 0));
                                _quest1.Add("TV", new Expoints(0, 0, 2, 0));
                                _quest1.Add("CDDVD", new Expoints(0, 0, 2, 0));
                                break;
                            case "Стандарт": 
                                _quest1.Add("Monitor", new Expoints(0, 0, 4, 0));
                                _quest1.Add("RAM", new Expoints(0, 0, 4, 0));
                                _quest1.Add("CPU", new Expoints(0, 0, 4, 0));
                                _quest1.Add("VideoCard", new Expoints(0, 0, 4, 0));
                                _quest1.Add("Audio", new Expoints(0, 0, 4, 0));
                                _quest1.Add("HDD", new Expoints(0, 0, 4, 0));
                                _quest1.Add("MotherBoard", new Expoints(0, 0, 4, 0));
                                _quest1.Add("PowerBox", new Expoints(0, 0, 4, 0));
                                _quest1.Add("Box", new Expoints(0, 0, 4, 0));
                                _quest1.Add("Mouse", new Expoints(0, 0, 4, 0));
                                _quest1.Add("Keyboard", new Expoints(0, 0, 4, 0));
                                _quest1.Add("Microphone", new Expoints(0, 0, 4, 0));
                                _quest1.Add("kolonki", new Expoints(0, 0, 4, 0));
                                _quest1.Add("Hearphone", new Expoints(0, 0, 4, 0));
                                _quest1.Add("Webcam", new Expoints(0, 0, 4, 0));
                                _quest1.Add("Printer", new Expoints(0, 0, 4, 0));
                                _quest1.Add("Scaner", new Expoints(0, 0, 4, 0));
                                _quest1.Add("TV", new Expoints(0, 0, 4, 0));
                                _quest1.Add("CDDVD", new Expoints(0, 0, 4, 0)); 
                                break;
                            case "Все по максимуму":
                                _quest1.Add("Monitor", new Expoints(0, 0, 5, 0));
                                _quest1.Add("RAM", new Expoints(0, 0, 5, 0));
                                _quest1.Add("CPU", new Expoints(0, 0, 5, 0));
                                _quest1.Add("VideoCard", new Expoints(0, 0, 5, 0));
                                _quest1.Add("Audio", new Expoints(0, 0, 5, 0));
                                _quest1.Add("HDD", new Expoints(0, 0, 5, 0));
                                _quest1.Add("MotherBoard", new Expoints(0, 0, 5, 0));
                                _quest1.Add("PowerBox", new Expoints(0, 0, 5, 0));
                                _quest1.Add("Box", new Expoints(0, 0, 5, 0));
                                _quest1.Add("Mouse", new Expoints(0, 0, 5, 0));
                                _quest1.Add("Keyboard", new Expoints(0, 0, 5, 0));
                                _quest1.Add("Microphone", new Expoints(0, 0, 5, 0));
                                _quest1.Add("kolonki", new Expoints(0, 0, 5, 0));
                                _quest1.Add("Hearphone", new Expoints(0, 0, 5, 0));
                                _quest1.Add("Webcam", new Expoints(0, 0, 5, 0));
                                _quest1.Add("Printer", new Expoints(0, 0, 5, 0));
                                _quest1.Add("Scaner", new Expoints(0, 0, 5, 0));
                                _quest1.Add("TV", new Expoints(0, 0, 5, 0));
                                _quest1.Add("CDDVD", new Expoints(0, 0, 5, 0)); 
                                break;   
                        }
                    }
                }
            }
            foreach (Control c in groupBoxQuest2.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                        switch (((CheckBox)c).Text)
                        {
                            case "Для офисной работы":
                                _quest2.Add("CPU", new Expoints(2, 0, 0, 2));
                                _quest2.Add("RAM", new Expoints(2, 0, 0, 2));
                                _quest2.Add("VideoCard", new Expoints(2, 0, 0, 2));
                                _quest2.Add("MotherBoard", new Expoints(2, 0, 0, 2));
                                _quest2.Add("Monitor", new Expoints(2, 0, 0, 2));
                                _quest2.Add("Audio", new Expoints(2, 0, 0, 2));
                                break;
                            case "Для игр": break;
                            case "В качестве мультимедийной станции": break;
                            case "Для работы с выкотребовательным ПО": break;
                        }
                }
            }
            foreach (Control c in groupBoxQuest3.Controls)
            {
                if (c is RadioButton)
                {
                    if (((RadioButton)c).Text == "Да" && ((RadioButton)c).Checked)
                    {
                            _quest3.Add("CPU", new Expoints(4, 0, 0, 4));
                            _quest3.Add("RAM", new Expoints(4, 0, 0, 4));
                            _quest3.Add("VideoCard", new Expoints(4, 0, 0, 4));
                            _quest3.Add("MotherBoard", new Expoints(4, 0, 0, 4));
                    }
                    else if (((RadioButton)c).Text == "Нет" && ((RadioButton)c).Checked)
                    {
                            _quest3.Add("CPU", new Expoints(3, 0, 0, 3));
                            _quest3.Add("RAM", new Expoints(3, 0, 0, 3));
                            _quest3.Add("VideoCard", new Expoints(3, 0, 0, 3));
                            _quest3.Add("MotherBoard", new Expoints(3, 0, 0, 3));
                    }
                }
            }
            foreach (Control c in groupBoxQuest4.Controls)
            {
                if (c is RadioButton)
                {
                    if (((RadioButton)c).Text == "Да" && ((RadioButton)c).Checked)
                    {
                            _quest4.Add("Monitor", new Expoints(5, 0, 0, 5));
                            _quest4.Add("Audio", new Expoints(4, 0, 0, 4));
                    }
                    else if (((RadioButton)c).Text == "Нет" && ((RadioButton)c).Checked)
                    {
                            _quest4.Add("Monitor", new Expoints(4, 0, 0, 4));
                            _quest4.Add("Audio", new Expoints(3, 0, 0, 3));
                    }
                }
            }
            foreach (Control c in groupBoxQuest5.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                        switch (((CheckBox)c).Text)
                        {
                            case "Музыка":
                                _quest5.Add("CPU", new Expoints(3, 0, 0, 3));
                                _quest5.Add("RAM", new Expoints(3, 0, 0, 3));
                                _quest5.Add("VideoCard", new Expoints(2, 0, 0, 2));
                                _quest5.Add("MotherBoard", new Expoints(3, 0, 0, 3));
                                _quest5.Add("Monitor", new Expoints(2, 0, 0, 2));
                                _quest5.Add("Audio", new Expoints(4, 0, 0, 4)); 
                                break;
                            case "Видео":
                                _quest5.Add("CPU", new Expoints(3, 0, 0, 3));
                                _quest5.Add("RAM", new Expoints(4, 0, 0, 4));
                                _quest5.Add("VideoCard", new Expoints(3, 0, 0, 3));
                                _quest5.Add("MotherBoard", new Expoints(3, 0, 0, 3));
                                _quest5.Add("Monitor", new Expoints(3, 0, 0, 3));
                                _quest5.Add("Audio", new Expoints(2, 0, 0, 2)); 
                                break;
                            case "Фото":
                                _quest5.Add("CPU", new Expoints(3, 0, 0, 3));
                                _quest5.Add("RAM", new Expoints(3, 0, 0, 3));
                                _quest5.Add("VideoCard", new Expoints(3, 0, 0, 3));
                                _quest5.Add("MotherBoard", new Expoints(3, 0, 0, 3));
                                _quest5.Add("Monitor", new Expoints(3, 0, 0, 3));
                                _quest5.Add("Audio", new Expoints(2, 0, 0, 2)); 
                                break;
                        }
                }
            }
            foreach (Control c in groupBoxQuest6.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                        switch (((CheckBox)c).Text)
                        {
                            case "Программирование": 
                                _quest6.Add("CPU", new Expoints(4, 0, 0, 4));
                                _quest6.Add("RAM", new Expoints(3, 0, 0, 3));
                                _quest6.Add("VideoCard", new Expoints(2, 0, 0, 2));
                                _quest6.Add("MotherBoard", new Expoints(4, 0, 0, 4));
                                _quest6.Add("Monitor", new Expoints(2, 0, 0, 2));
                                _quest6.Add("Audio", new Expoints(2, 0, 0, 2)); 
                                break;
                            case "3D-моделирование": 
                                _quest6.Add("CPU", new Expoints(5, 0, 0, 5));
                                _quest6.Add("RAM", new Expoints(4, 0, 0, 4));
                                _quest6.Add("VideoCard", new Expoints(4, 0, 0, 4));
                                _quest6.Add("MotherBoard", new Expoints(4, 0, 0, 4));
                                _quest6.Add("Monitor", new Expoints(3, 0, 0, 3));
                                _quest6.Add("Audio", new Expoints(2, 0, 0, 2)); 
                                break;
                            case "Работа с музыкой": 
                                _quest6.Add("CPU", new Expoints(4, 0, 0, 4));
                                _quest6.Add("RAM", new Expoints(4, 0, 0, 4));
                                _quest6.Add("VideoCard", new Expoints(2, 0, 0, 2));
                                _quest6.Add("MotherBoard", new Expoints(4, 0, 0, 4));
                                _quest6.Add("Monitor", new Expoints(3, 0, 0, 3));
                                _quest6.Add("Audio", new Expoints(5, 0, 0, 5)); 
                                break;
                            case "Редактирование изображений": 
                                _quest6.Add("CPU", new Expoints(4, 0, 0, 4));
                                _quest6.Add("RAM", new Expoints(3, 0, 0, 3));
                                _quest6.Add("VideoCard", new Expoints(4, 0, 0, 4));
                                _quest6.Add("MotherBoard", new Expoints(4, 0, 0, 4));
                                _quest6.Add("Monitor", new Expoints(3, 0, 0, 3));
                                _quest6.Add("Audio", new Expoints(2, 0, 0, 2)); 
                                break;
                        }
                }
            }
            foreach (Control c in groupBoxQuest7.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                        switch (((CheckBox)c).Text)
                        {
                            case "С маленькими": 
                                _quest7.Add("HDD", new Expoints(2, 0, 0, 2));
                                break;
                            case "С большими": 
                                _quest7.Add("HDD", new Expoints(3, 0, 0, 3));
                                break;
                            case "С очень большими": 
                                _quest7.Add("HDD", new Expoints(5, 0, 0, 5));
                                break;
                        }
                }
            }
            foreach (Control c in groupBoxMouse.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                        switch (((CheckBox)c).Text)
                        {
                            case "Игровая": 
                                _quest8.Add("Mouse", new Expoints(2, 0, 0, 2));
                                break;
                            case "Профессиональная":
                                _quest8.Add("Mouse", new Expoints(1, 0, 0, 1));
                                break;
                            case "Простая":
                                _quest8.Add("Mouse", new Expoints(0, 0, 0, 0));
                                break;

                        }
                }
            }
            foreach (Control c in groupBoxKey.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                        switch (((CheckBox)c).Text)
                        {
                            case "Игровая":
                                _quest8.Add("Keyboard", new Expoints(2, 0, 0, 2));
                                break;
                            case "Профессиональная":
                                _quest8.Add("Keyboard", new Expoints(1, 0, 0, 1));
                                break;
                            case "Простая":
                                _quest8.Add("Keyboard", new Expoints(0, 0, 0, 0));
                                break;

                        }
                }
            }
            foreach (Control c in groupBoxMic.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                        switch (((CheckBox)c).Text)
                        {
                            case "Простой":
                                _quest8.Add("Microphone", new Expoints(0, 0, 0, 0));
                                break;
                            case "Профессиональный":
                                _quest8.Add("Microphone", new Expoints(1, 0, 0, 1));
                                break;
                        }
                }
            }
            foreach (Control c in groupBoxKol.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                        switch (((CheckBox)c).Text)
                        {
                            case "Простые":
                                _quest8.Add("kolonki", new Expoints(0, 0, 0, 0));
                                break;
                            case "Простые с высоким качеством звучания":
                                _quest8.Add("kolonki", new Expoints(1, 0, 0, 1));
                                break;
                            case "С эффектом объемного звучания":
                                _quest8.Add("kolonki", new Expoints(2, 0, 0, 2));
                                break;
                            case "Домашний кинотеатр":
                                _quest8.Add("kolonki", new Expoints(3, 0, 0, 3));
                                break;
                        }
                }
            }
            foreach (Control c in groupBoxNaush.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                        switch (((CheckBox)c).Text)
                        {
                            case "Простые":
                                _quest8.Add("Hearphone", new Expoints(0, 0, 0, 0));
                                break;
                            case "C микрофоном":
                                _quest8.Add("Hearphone", new Expoints(1, 0, 0, 1));
                                break;
                            case "Полу-профессиональные":
                                _quest8.Add("Hearphone", new Expoints(2, 0, 0, 2));
                                break;
                            case "Профессиональные":
                                _quest8.Add("Hearphone", new Expoints(3, 0, 0, 3));
                                break;
                        }
                }
            }
            foreach (Control c in groupBoxWebCam.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                        switch (((CheckBox)c).Text)
                        {
                            case "Простая":
                                _quest8.Add("Webcam", new Expoints(0, 0, 0, 0));
                                break;
                            case "Качественная":
                                _quest8.Add("Webcam", new Expoints(1, 0, 0, 1));
                                break;
                            case "Качественная с подсветкой":
                                _quest8.Add("Webcam", new Expoints(2, 0, 0, 2));
                                break;
                        }
                }
            }
            foreach (Control c in groupBoxPrint.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                        switch (((CheckBox)c).Text)
                        {
                            case "Для фото":
                                _quest8.Add("Printer", new Expoints(0, 0, 0, 0));
                                break;
                            case "Для текста":
                                _quest8.Add("Printer", new Expoints(1, 0, 0, 1));
                                break;
                        }
                }
            }
            foreach (Control c in groupBoxScan.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                        switch (((CheckBox)c).Text)
                        {
                            case "Среднего качества":
                                _quest8.Add("Scaner", new Expoints(0, 0, 0, 0));
                                break;
                            case "Высокого качества":
                                _quest8.Add("Scaner", new Expoints(1, 0, 0, 1));
                                break;
                        }
                }
            }
            foreach (Control c in groupBoxCDDVD.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                        switch (((CheckBox)c).Text)
                        {
                            case "Чтение CDDVD":
                                _quest8.Add("CDDVD", new Expoints(0, 0, 0, 0));
                                break;
                            case "Чтение_запись CDDVD":
                                _quest8.Add("CDDVD", new Expoints(1, 0, 0, 1));
                                break;
                        }
                }
            }
            foreach (Control c in groupBoxQuest8.Controls)
            {
                if (c is CheckBox)
                {
                    if (((CheckBox)c).Checked)
                        switch (((CheckBox)c).Text)
                        {
                            case "Просмотр ТВ на ПК":
                                _quest8.Add("TV", new Expoints(0, 0, 0, 0));
                                break;
                        }
                }
            }
            p = "ok";
            Close();

        }
    }
}
