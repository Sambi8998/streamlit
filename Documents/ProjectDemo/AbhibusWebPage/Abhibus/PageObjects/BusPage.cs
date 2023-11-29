using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abhibus.PageObjects
{
    internal class BusPage
    {
        IWebDriver? driver;
        public BusPage(IWebDriver? driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }

        //Arrange


        
        
        
        //[FindsBy(How = How.XPath, Using = ("//*[@id=\"root\"]/div/div[2]/div/div/div/div[2]/div[1]/div[3]/label"))]
        //private IWebElement? Departure { get; set; }

       

        //[FindsBy(How = How.XPath, Using = ("//*[@id=\"root\"]/div/div[2]/div/div/div/div[2]/div[1]/div[5]/div[2]/div[1]/div"))]
        //private IWebElement? TravelClass { get; set; }

        //[FindsBy(How = How.XPath, Using = ("//*[@id=\"root\"]/div/div[2]/div/div/div/div[2]/div[1]/div[5]/div[2]/div[2]"))]
        //private IWebElement? ApplyButton { get; set; }

        //[FindsBy(How = How.XPath, Using = ("//*[@id=\"root\"]/div/div[2]/div/div/div/div[2]/div[2]/div[1]"))]
        //private IWebElement? RegularFare { get; set; }





        
       
        
        /*
        public void ClickDeparture(string date)
        {
            Departure?.SendKeys(date);
            Departure?.SendKeys(Keys.Enter);
        }
        
        public void ClickTravellers(string adult, string travelClass)
        {
            Travellers?.SendKeys(adult);
            Travellers?.SendKeys(Keys.Enter);
            Travellers?.SendKeys(travelClass);

        }
        
        public void ClickTravelClass(string travelClass)
        {
            TravelClass?.SendKeys(travelClass);
            TravelClass?.SendKeys(Keys.Enter);
        }
        /*
        public void ClickApplyButton()
        {
            ApplyButton?.Click();
        }
        */
        //public void ClickRegularFare(string regularfare)
        //{
        //    RegularFare?.SendKeys(regularfare);
        //    RegularFare?.SendKeys(Keys.Enter);
        //}
        
       // public DisplayBusListsFilterPage ClickSearchButton()
        //{
          //  SearchButton?.Click();
            //return new DisplayBusListsFilterPage(driver);
        //}
        
    }
}

