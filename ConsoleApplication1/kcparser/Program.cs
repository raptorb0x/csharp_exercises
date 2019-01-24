using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


//подключаем селениум вебдрайвер основной
using OpenQA.Selenium;

//селениум вебдрайвер файфокс
using OpenQA.Selenium.Firefox;

//И расширеную поддержку работы с интерфейсом
using OpenQA.Selenium.Support.UI;
using ClosedXML.Excel;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
 
            var workbook = new XLWorkbook();
            
            var worksheet = workbook.Worksheets.Add("Creeper world 2");
                worksheet.Cell("A1").Value = "map index";
                worksheet.Cell("B1").Value = "pro";
                worksheet.Cell("C1").Value = "contra";
            worksheet.Cell("D1").Value = "downloads";

            FirefoxOptions options = new FirefoxOptions(); // создаем объект с настройками для ФФ
            options.SetPreference("permissions.default.stylesheet", 2); //Отключаем CSS
            options.SetPreference("permissions.default.image", 2); //отключаем картинки
            options.SetPreference("javascript.enabled", false);   //отключаем джаваскрипт
            // options.SetPreference("dom.ipc.plugins.enabled.libflashplayer.so", "false");
            int End = 2956;//2956
            FirefoxDriver driver = new FirefoxDriver(options); //создаем драйвер файрфокса с нашими настройками
            IWebElement m_plus;
            IWebElement m_minus;
            IWebElement m_downloads;
            int Row = 2; //первая строка для заголовков
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); //Добавляем ожидание ИСКЛЮЧЕНИЕ
            for (int map = 1; map <= End; map++) //2956
            {
                driver.Url = "http://knucklecracker.com/creeperworld2/viewmaps.php?embedded=false&gameVer=&mapid=" + map.ToString(); //страница
                Console.Clear();
                Console.WriteLine("MAP №  " + map.ToString() + " from " + End.ToString() +"  add  " + Row.ToString() + "map");
           
                //Console.ReadKey();
                try
                {
                    m_plus = driver.FindElement(By.XPath("./html/body/center/center/div[4]/span/table/tbody/tr/td[1]/span/span/span[1]"));
                }
                catch (Exception)
                { continue;}
                
                m_minus = driver.FindElement(By.XPath("./html/body/center/center/div[4]/span/table/tbody/tr/td[1]/span/span/span[2]"));

                m_downloads = driver.FindElement(By.XPath("./html/body/center/center/div[4]/span/table/tbody/tr/td[2]/table/tbody/tr[6]/td[2]"));
                Console.WriteLine("m_plus " + m_plus.Text+"/"+m_minus.Text);
                worksheet.Cell("A" + Row).Value = map;
                worksheet.Cell("B" + Row).Value = m_plus.Text;
                worksheet.Cell("C" + Row).Value = m_minus.Text;
                worksheet.Cell("D" + Row).Value = m_downloads.Text;
                Row++;



            }
            driver.Quit();
            workbook.SaveAs("C:/HelloWorld.xlsx");
            Console.WriteLine("ALL DONE!!!!");
            Console.ReadKey();
            

        }
    }
}
