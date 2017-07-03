using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.Office.Interop.Excel;

//подключаем селениум вебдрайвер основной
using OpenQA.Selenium;

//селениум вебдрайвер файфокс
using OpenQA.Selenium.Firefox;

//И расширеную поддержку работы с интерфейсом
using OpenQA.Selenium.Support.UI;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            int End = 2700;

            if (xlApp == null)
            {
                Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
                return;
            }
            xlApp.Visible = true;

            Workbook wb = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = (Worksheet)wb.Worksheets[1];

            if (ws == null)
            {
                Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
            }

            // Select the Excel cells, in the range c1 to c7 in the worksheet.
            Range aRange = ws.get_Range("A1", "A1");

            if (aRange == null)
            {
                Console.WriteLine("Could not get a range. Check to be sure you have the correct versions of the office DLLs.");
            }
    
            FirefoxOptions options = new FirefoxOptions(); // создаем объект с настройками для ФФ
            options.SetPreference("permissions.default.stylesheet", 2); //Отключаем CSS
            options.SetPreference("permissions.default.image", 2); //отключаем картинки
            options.SetPreference("javascript.enabled", false);   //отключаем джаваскрипт
           // options.SetPreference("dom.ipc.plugins.enabled.libflashplayer.so", "false");

            FirefoxDriver driver = new FirefoxDriver(options); //создаем драйвер файрфокса с нашими настройками

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); //Добавляем ожидание
            for (int page = 2; page < End; page++)
            {
                driver.Url = "http://old.reactor.cc/all/" + page.ToString(); //страница
                Console.Clear();
                Console.WriteLine("PAGE №  " + page.ToString() +" from " + End.ToString());
                //созаем колекцию из найденных элементов

                IList<IWebElement> p_link = driver.FindElements(By.XPath(".//*[@title='ссылка на пост']"));
                IList<IWebElement> p_rating = driver.FindElements(By.XPath(".//*[@class='post_rating']"));
                IList<IWebElement> p_comment = driver.FindElements(By.XPath(".//*[@class='commentnum toggleComments']"));
                for (int i = 0; i<10; i++)
                {


                    var temp = (page - 2) * 10 + i + 1;
                    aRange = ws.get_Range("A" + temp.ToString(), "A" + temp.ToString());
                    ws.Hyperlinks.Add(aRange, p_link[i].GetAttribute("href"),Type.Missing,Type.Missing,"пост № " + p_link[i].GetAttribute("href").ToString().Remove(0, 27));
                    aRange = aRange.get_Offset(0, 1);
                    aRange.Value2 = Single.Parse(p_rating[i].Text.Remove(0, 9).Replace('.', ','));
                    aRange = aRange.get_Offset(0, 1);
                    aRange.Value2 = p_comment[i].Text;

                }
                
            }
            Console.WriteLine("ALL DONE!!!!");
            Console.ReadKey();
            driver.Quit();

        }
    }
}
