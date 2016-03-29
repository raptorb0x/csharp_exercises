using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Google_zerg_rush
{
    class Program
    {
        static void Main(string[] args)
        {
            FirefoxDriver driver = new FirefoxDriver();
            //напрямую в гугл не пробиться - осядем на вводе капчи изза подозрительной деятельности
            //потому пойдем через яндекс
            driver.Url = "https://ya.ru";
            
            //ищем гугл
            driver.FindElementByXPath("//*[@id='text']").SendKeys("Google" + Keys.Enter);

            //теперь переходим по ссылке от яндекса
            driver.Url = driver.FindElementByPartialLinkText("google.ru").Text.ToString();

            driver.Url = "https://www.google.ru/#newwindow=1&q=zerg+rush";

            do
            {

                try
                {
                    driver.FindElementByXPath(".//*[@class='zr_zergling_container']").Click();
                }
                catch
                {
                    //если зерглинга еще нет
                }
            } while (true); //TODO: заменить на число из статистики

            Console.ReadKey();
            driver.Quit();
        }
    }
}
