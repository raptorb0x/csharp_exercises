#region Annotation
/*
     Тесты написаны по упражнениям с сайта http://toolsqa.com - 
     из серии учебных статей о Java и Webdriver 
     но т.к. пишу C#, то старался найти адекватные замены
     возможно, некоторые коментарии излишни, так писал для лучшего запоминания
*/
#endregion

//подключаем пространства имен

//Системные  по дефолту
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//подключаем фреймворк Nunit'a
using NUnit.Framework;

//подключаем селениум вебдрайвер основной
using OpenQA.Selenium;

//селениум вебдрайвер файфокс
using OpenQA.Selenium.Firefox;

//И расширеную поддержку работы с интерфейсом
using OpenQA.Selenium.Support.UI;

//пространство имен проэкта
namespace Selenium_with_Nunit

{

    [TestFixture]  // атрибуты NUinit

    //Тестовый класс
    public class Exercises
    {
        //Обзовем файрфокс драйвер
        FirefoxDriver driver;

        //подготовка перед каждым тестом
        [SetUp]
        public void Setup()
        {
            // инициализируем драйвер
            driver = new FirefoxDriver();

            //указываем ожидание появления элементов в 5 секунд (0 по умолчанию)
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        //завершение после каждого теста
        [TearDown]
        public void Teardown()
        {
            //закрываем драйвер
            driver.Quit();
        }

        //далее идут методы тестового класса - фактически, сами тесты

        #region Basic_Test
        /*
            Practice Exercise – 1

            Launch a new Firefox browser.
            Open Store.DemoQA.com
            Get Page Title name and Title length
            Print Page Title and Title length on the Eclipse Console.
            Get Page URL and verify if the it is a correct page opened
            Get Page Source (HTML Source code) and Page Source length
            Print Page Length on Eclipse Console.
            Close the Browser.
        */


        [Test]
        public void _00_Basic_Test()
        {
            // url сайта
            string url = "http://store.demoqa.com/";

            //идем на сайт
            driver.Navigate().GoToUrl(url);

            // выводим его заголовок в консоль
            Console.WriteLine("ЗАголовок - " + driver.Title);

            // выводим длину заголовка
            Console.WriteLine("Длина заголовка - " + driver.Title.Length);

            // проверяем соотвествие нашего url и действительного
            Assert.AreEqual(url, driver.Url);

            // выводим количество символов в исходном коде страницы
            Console.WriteLine("Количесво символов в исходнок коде страницы - " + driver.PageSource.Length);

        }

        #endregion

        #region Click_Test

        /*
            Practice Exercise – 2

            Launch a new Firefox browser.
            Open http://demoqa.com/frames-and-windows/
            Use this statement to click on a New Window button “driver.findElement(By.xpath(“.//*[@id=’tabs-1′]/div/p/a”)).click();”
            Close the browser using close() command 
        */

        [Test]
        public void _01_Click_Test()
        {
            // адрес сайта 
            string url = "http://demoqa.com/frames-and-windows/";

            //идем на сайт
            driver.Navigate().GoToUrl(url);

            // Нажимаем на элемент на сайте, котрый находим через  Xpath
            driver.FindElement(By.XPath("//*[@id='tabs-1']/div/p/a")).Click();

            //закрываем драйвер
            driver.Close();
        }

        #endregion

        #region Navigation_Test

        /*
            Practice Exercise

            Launch new Browser
            Open DemoQA.com website
            Click on Registration link using “driver.findElement(By.xpath(“.//*[@id=’menu-item-374′]/a”)).click();“
            Come back to Home page (Use ‘Back’ command)
            Again go back to Registration page (This time use ‘Forward’ command)
            Again come back to Home page (This time use ‘To’ command)
            Refresh the Browser (Use ‘Refresh’ command)
            Close the Browser
        */

        [Test]
        public void _02_Navigation_Test()
        {
            // адрес сайта 
            string url = "http://www.DemoQA.com";

            //идем на сайт
            driver.Navigate().GoToUrl(url);

            // нажимаем на  элемент на сайте, котрый находим через Xpath
            driver.FindElement(By.XPath("//*[@id='menu-item-374']/a")).Click();

            //навигация  назад
            driver.Navigate().Back();

            //навигация вперед  
            driver.Navigate().Forward();

            // открываем страницу через set метод 
            driver.Url = url;

            //обновляем страницу 
            driver.Navigate().Refresh();
        }

        #endregion

        #region Find_Element_Test_1
        
        /*
            Practice Exercise 1

            Launch new Browser
            Open URL http://toolsqa.com/automation-practice-form/
            Type Name & Last Name (Use Name locator)
            Click on Submit button (Use ID locator)
        */

        [Test]
        public void _03_Find_Element_Test_1()
        {
            // адрес сайта 
            string url = "http://toolsqa.com/automation-practice-form/";

            //идем на сайт 
            driver.Navigate().GoToUrl(url);

            //Находим элемент по его имени и вводлим туда "Ivan"
            driver.FindElement(By.Name("firstname")).SendKeys("Ivan");

            //Находим элемент по его имени и вводлим туда "Shishin"
            driver.FindElement(By.Name("lastname")).SendKeys("Shishin");

            //Находим элемент по его id и щелкаем на него
            driver.FindElement(By.Id("submit")).Click();
        }

        #endregion

        #region Find_Element_Test_2
        
        /*
            Practice Exercise 2

            Launch new Browser
            Open URL http://toolsqa.com/automation-practice-form/
            Click on the Link “Partial Link Test” (Use ‘patialLinkTest’ locator and search by ‘Partial’ word)
            Identify Submit button with ‘tagName’, convert it in to string and print it on the console
            Click on the Link “Link Test” (Use ‘linkTest’ locator)
        */

        [Test]
        public void _04_Find_Element_Test_2()
        {
            // адрес сайта 
            string url = "http://toolsqa.com/automation-practice-form/";

            //идем на сайт 
            driver.Navigate().GoToUrl(url);

            //находим элемент по части теста линка и щелкаем на него
            driver.FindElement(By.PartialLinkText("Partial")).Click();


            //Создаем строку куда передаем преобразованный в строку элемент найденный через имя тега
            string button = driver.FindElement(By.TagName("button")).ToString();

            //выводим строку в консоль
            Console.WriteLine(button);

            //находим элемент по тексту линка и щелкаем на него
            driver.FindElement(By.LinkText("Link Test")).Click();

        }

        #endregion

        #region Radio_Check_button_Test

        /*
            Practice Exercise

            Launch new Browser
            Open “http://toolsqa.com/automation-practice-form/“
            Challenge One – Select the deselected Radio button (female) for category Sex (Use IsSelected method)
            Challenge Two – Select the Third radio button for category ‘Years of Exp’ (Use Id attribute to select Radio button)
            Challenge Three – Check the Check Box ‘Automation Tester’ for category ‘Profession'( Use Value attribute to match the selection)
            Challenge Four – Check the Check Box ‘Selenium IDE’ for category ‘Automation Tool’ (Use cssSelector)
        */

        [Test]
        public void _05_Radio_Check_button_Test()
        {
            // адрес сайта
            string url = "http://toolsqa.com/automation-practice-form/";

            //идем на сайт 
            driver.Navigate().GoToUrl(url);

            //находим вебэлемент c id "sex-1" и присваеваем его вебэлементу check
            IWebElement check = driver.FindElement(By.Id("sex-1"));

            //проверяем что элемент check не выбран
            if (check.Selected == false)
            {
                // и в таком случае выбираем его
                check.Click();
            }
            
            //далее находим элементы по id, через Xpath и CssSelector и кликаем на них
            driver.FindElement(By.Id("exp-2")).Click();
            driver.FindElement(By.XPath("//input[@value='Automation Tester']")).Click();
            driver.FindElement(By.CssSelector("input[value='Selenium IDE']")).Click();

        }

        #endregion

        #region Drop_Down_Test
        
        /*
            Practice Exercise -1 (Drop Down Box/List)

            Launch new Browser
            Open “http://toolsqa.com/automation-practice-form/”
            Select ‘Continents’ Drop down ( Use Id to identify the element )
            Select option ‘Europe’ (Use selectByIndex)
            Select option ‘Africa’ now (Use selectByVisibleText)
            Print all the options for the selected drop down and select one option of your choice
            Close the browser
        */


        [Test]
        public void _06_Drop_Down_Test()
        {
            // адрес сайта 
            string url = "http://toolsqa.com/automation-practice-form/";

            //идем на сайт 
            driver.Navigate().GoToUrl(url);

            // Находим выпадающий список по id и присваеваем его в oselect
            SelectElement oselect = new SelectElement(driver.FindElement(By.Id("continents")));

            //выбираем элемент списка по его индексу (нумерация с 0)
            oselect.SelectByIndex(1);

            //2000 мс просто чтобы увидеть результат
            System.Threading.Thread.Sleep(2000);

            //выбираем элемент списка по его тексту
            oselect.SelectByText("Africa");

            //2000 мс просто чтобы увидеть результат
            System.Threading.Thread.Sleep(2000);

            //создаем колекцию всех опций списка
            IList<IWebElement> Options = oselect.Options;

            //для каждого вебэлемента в колеции
            foreach (IWebElement item in Options)
            {
                //выводим его текст
                Console.WriteLine(item.Text);
            }

            //выбираем Европу
            oselect.SelectByText("Europe");
        }

        #endregion

        #region Multyselection_Box_List_Test

        /*
            Practice Exercise -2 (Multiple Selection Box/List)

            Launch new Browser
            Open “http://toolsqa.com/automation-practice-form/”
            Select ‘Selenium Commands’ Multiple selection box ( Use Name locator to identify the element )
            Select option ‘Browser Commands’  and then deselect it (Use selectByIndex and deselectByIndex)
            Select option ‘Navigation Commands’  and then deselect it (Use selectByVisibleText and deselectByVisibleText)
            Print and select all the options for the selected Multiple selection list.
            Deselect all options
            Close the browser
        */


        [Test]
        public void _07_Multyselection_Box_List_Test()
        {

            //идем на сайт 
            driver.Url= "http://toolsqa.com/automation-practice-form/";

            //Находим список c выбором по имени и присваеваем его в oSelect
            SelectElement oSelect = new SelectElement(driver.FindElement(By.Name("selenium_commands")));

            //выбираем первый элемет, 2-х секундная пауза
            oSelect.SelectByIndex(0);
            System.Threading.Thread.Sleep(2000);
            
            //отменяем выбор, 2-х секундная пауза
            oSelect.DeselectByIndex(0); 
            System.Threading.Thread.Sleep(2000);

            //выбираем по содежанию, 2-х секундная пауза
            oSelect.SelectByText("Navigation Commands");
            System.Threading.Thread.Sleep(2000);

            //отменяем выбор, 2-х секундная пауза
            oSelect.DeselectByText("Navigation Commands");
            System.Threading.Thread.Sleep(2000);

            //создаем колекцию всех опций списка
            IList<IWebElement> Options = oSelect.Options;

            //для каждого вебэлемента в колеции
            foreach (IWebElement item in Options)
            {
                //выводим его текст
                Console.WriteLine(item.Text);

                //Выбираем его и 1 сек. пауза
                item.Click();
                System.Threading.Thread.Sleep(1000);

            }

            //отменяем выбор всех опций 2 сек. пауза
            oSelect.DeselectAll();
            System.Threading.Thread.Sleep(2000);
        }

        #endregion

        #region Practice_Tables_1_Test

        /*
            Practice Exercise 1

            Launch new Browser
            Open URL “http://toolsqa.com/automation-practice-table/”
            Get the value from cell ‘Dubai’ and print it on the console
            Click on the link ‘Detail’ of the first row and last column
        */

        [Test]
        public void _08_Practice_Tables_1_Test()
        {

            //идем на сайт 
            driver.Url = "http://toolsqa.com/automation-practice-table";

            //сохроняем в строку найденный элемент и выводи его в консоль
            string CellValue = driver.FindElement(By.XPath("//*[@id='content']/table/tbody/tr[1]/td[2]")).Text;
            Console.WriteLine(CellValue);

            //Нажимаем на details первой строки
            driver.FindElement(By.XPath("//*[@id='content']/table/tbody/tr[1]/td[6]/a")).Click();
            Console.WriteLine("Link has been pressed");
        }

        #endregion

        #region Practice_Tables_2_Test
        
        /*
            Practice Exercise 2

            Launch new Browser
            Open URL “http://toolsqa.com/automation-practice-table/”
            Get the value from cell ‘Dubai’ with using dynamic xpath
            Print all the column values of row ‘Clock Tower Hotel’
        */
        
        [Test]
        public void _09_Practice_Tables_2_Test()
        {

            //идем на сайт 
            driver.Url = "http://toolsqa.com/automation-practice-table";

            //Первая строка второй столбец 
            string sRow = "1";
            string sCol = "2";

            //сохроняем в строку найденный элемент и выводи его в консоль
            string CellValue = driver.FindElement(By.XPath("//*[@id='content']/table/tbody/tr[" + sRow + "]/td[" +sCol + "]")).Text;
            Console.WriteLine(CellValue);

            // собираем строку Xpath по которой ищем 
            //название строки
            string sRowValue = "Clock Tower Hotel";
            //находим табличку по её классу, в ней находим строку по названию заголовка, берем её ячейки кроме той что с ссылкой
            string sXpath = "//table[@class='tsc_table_s13']/tbody/tr[th//text()[contains(.,'" + sRowValue +  "')]]/td[not(a)]"; 

            //созаем колекцию из найденных элементов
            IList<IWebElement> Columns =  driver.FindElements(By.XPath(sXpath));

            //для каждого элемента коллекции Columns
            foreach(IWebElement item in Columns)
            {

                //выведем его текст
                Console.WriteLine(item.Text);
            }

        }

        #endregion

    }
}


