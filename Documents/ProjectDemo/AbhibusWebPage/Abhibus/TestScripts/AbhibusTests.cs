using Abhibus.Utilities;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abhibus.PageObjects;
using static System.Runtime.InteropServices.JavaScript.JSType;
using OpenQA.Selenium.Interactions;

namespace Abhibus.TestScripts
{
    internal class AbhibusTests : CoreCodes
    {
        
        List<BookBusData>? excelDataList;

        [Test, Category("End to End Testing")]
        public void UserBookingBusTest()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(10);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element not found";


            AbhibusHomePage abhibusHomePage = new AbhibusHomePage(driver);
            //abhibusHomePage.ClickLogin();
            //Thread.Sleep(5000);

            //abhibusHomePage.ClickLogoCheck();
            //Assert.That(driver.Url.Contains("abhibus"));



            var homePage = new AbhibusHomePage(driver);
            if (!driver.Url.Contains("https://www.abhibus.com/"))
            {
                driver.Navigate().GoToUrl("https://www.abhibus.com/");
            }
            Thread.Sleep(4000);


             
            //Assert.That(driver.Url.Contains("Buses"));

            
            

            string? currDir = Directory.GetParent(@"../../../")?.FullName;
            string? excelFilePath = currDir + "/TestData/InputData.xlsx";
            string? sheetName = "SearchBus";

            excelDataList = ExcelUtils.ReadExcelData(excelFilePath, sheetName);

            foreach (var excelData in excelDataList)
            {
                

                string? fromInput = excelData?.FromInput;
                Console.WriteLine($"From Input: {fromInput}");
                abhibusHomePage.ClickFromInput(fromInput);

                string? toInput = excelData?.ToInput;
                Console.WriteLine($"To Input: {toInput}");
                abhibusHomePage.ClickToInput(toInput);

                string? date = excelData?.Date;
                Console.WriteLine($"Date: {date}");
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].innerText = arguments[1];", abhibusHomePage.Date, excelData?.Date);
                abhibusHomePage.DateClick();
                Thread.Sleep(2000);

                //string? pricedrop = excelData?.PriceDrop;
                //Console.WriteLine($"Price Drop : {pricedrop}");
                abhibusHomePage.ClickPriceDrop();
                Thread.Sleep(3000);

               

                string? busType = excelData?.BusType;
                Console.WriteLine($"Bus Type: {busType}");

                abhibusHomePage.ClickBusType(busType);

                string? departure = excelData?.Departure;
                Console.WriteLine($"Departure : {departure}");
                abhibusHomePage.ClickDeparture(departure);
                Thread.Sleep(3000);


                //string? busPartner = excelData?.BusPartner;
                //Console.WriteLine($"Departure : {departure}");
                //abhibusHomePage.ClickBusPartner(busPartner);

                string? showseats = excelData?.ShowSeats;
                Console.WriteLine($"Show Seats : {showseats}");
                abhibusHomePage.ClickShowSeats(showseats);
                Thread.Sleep(3000);

                //string? continue = excelData?.Continue;
                //Console.WriteLine($"Continue : {continue}");
                //abhibusHomePage.ClickContinue();
                //Thread.Sleep(3000);

                string? select = excelData?.Select;
                Console.WriteLine($"Select : {select}");
                abhibusHomePage.ClickSelect(select);
                Thread.Sleep(3000);

                string? bp = excelData?.BP;
                Console.WriteLine($"BP : {bp}");
                abhibusHomePage.ClickBP(bp);
                Thread.Sleep(3000);


                string? dp = excelData?.DP;
                Console.WriteLine($"DP : {dp}");
                abhibusHomePage.ClickDP(dp);
                Thread.Sleep(3000);

                //string? continue = excelData?.Continue;
                //Console.WriteLine($"Continue : {continue}");
                abhibusHomePage.ClickContinue();
                Thread.Sleep(3000);

                abhibusHomePage.ClickClose();
                Thread.Sleep(3000);

                string? name = excelData?.Name;
                Console.WriteLine($"Name: {name}");
                abhibusHomePage.ClickName(name);

                string? age = excelData?.Age;
                Console.WriteLine($"Age: {age}");
                abhibusHomePage.ClickAge(age);

                abhibusHomePage.ClickGender();
                Thread.Sleep(2000);

                string? contact = excelData?.Contact;
                Console.WriteLine($"Contact: {contact}");
                abhibusHomePage.ClickContact(contact);

                string? email = excelData?.Email;
                Console.WriteLine($"Email: {email}");
                abhibusHomePage.ClickEmail(email);

                

                abhibusHomePage.ClickTravelIns();
                Thread.Sleep(2000);

                abhibusHomePage.ClickAddress();
                Thread.Sleep(2000);

                string? pin = excelData?.Pin;
                Console.WriteLine($"Pin: {pin}");
                abhibusHomePage.ClickPin(pin);

                string? state = excelData?.State;
                Console.WriteLine($"State: {state}");
                abhibusHomePage.ClickState(state);

                string? city = excelData?.City;
                Console.WriteLine($"City: {city}");
                abhibusHomePage.ClickCity(city);

                abhibusHomePage.ClickSave();
                Thread.Sleep(2000);





                //WebElement slider = driver.FindElement(By.XPath("//div[@id='slider']/span"));
                //Actions move = new Actions(driver);
                //Action action = (Action)move.DragAndDrop(slider, 30, 0).build();
                //action.perform();


                //var displayBusListsFilterPage = abhibusHomePage.ClickSearchButton;

                //displayBusListsFilterPage.ClickBusTypeCheckBox();










                //Console.WriteLine(driver.FindElement(By.XPath("//input[@id='departure']//following::span[1]")).Text);

                //Thread.Sleep(8000);
                //string? date = excelData?.Date;
                //Console.WriteLine($"Date: {date}");
                //searchBusPage.ClickDeparture(excelData.Date);

                //string? adult = excelData?.Adult;
                //Console.WriteLine($"Adult: {adult}");
                //string? travelclass = excelData?.TravelClass;
                //Console.WriteLine($"Travel class: {travelclass}");
                //searchBusPage.ClickTravellers(excelData.Adult, excelData.TravelClass);
                //Thread.Sleep(5000);



                //string? travelclass = excelData?.TravelClass;
                //Console.WriteLine($"Travel class: {travelclass}");
                //searchBusPage.ClickTravelClass(excelData.TravelClass);

                //searchBusPage.ClickApplyButton();
                //Thread.Sleep(3000);

                //string? regularfare = excelData?.RegularFare;
                //Console.WriteLine($"Regular fare: {regularfare}");
                //searchBusPage.ClickRegularFare(excelData.RegularFare);




                //Thread.Sleep(3000);


            }







        }
        
    
        
    }
}
