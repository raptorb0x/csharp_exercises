using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//подключаем селениум вебдрайвер основной
using OpenQA.Selenium;

//селениум вебдрайвер файфокс
using OpenQA.Selenium.Firefox;

//И расширеную поддержку работы с интерфейсом
using OpenQA.Selenium.Support.UI;

namespace fastfingers
{
    class Program
    {
        static void Main(string[] args)
        {
            FirefoxDriver driver = new FirefoxDriver(); //создаем драйвер файрфокса

            driver.Url = "http://10fastfingers.com/typing-test/russian"; //идем на сайт с клавиатурным вводом

            IWebElement InTextbox = driver.FindElementByXPath(".//*[@id='inputfield']"); // создаем экз интерфейса Iwebelement привязываем его к окошку ввода 

            string sInString = ""; //переменная для хранения слова для ввода (чтобы не создавать и разрушать её в цикле, нагружая бедный GC)

            for (int i = 0; i < 180; i++) // С-way хочешь 50 слов в минуту - пиши 50, 100 - 100 (всего похоже 185-190 слов)
            {
                sInString = driver.FindElementByXPath(".//*[@id='row1']/span[@class = 'highlight']").Text.ToString(); //пихаем в строку текст подсвеченного слова
                InTextbox.SendKeys(sInString); //посылаем его на ввод (выглядит как вставка из буфера)
                InTextbox.SendKeys(Keys.Space); // пробел для перехода на новое слово
            }

            Console.ReadKey(); // держим окно при дебаге

            driver.Quit(); //закрываем драйвер
        }
    }
}
