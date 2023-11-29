using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abhibus.PageObjects
{
    internal class DisplayBusListsFilterPage
    {
        IWebDriver? driver;
        public DisplayBusListsFilterPage(IWebDriver? driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }

        //Arrange

        //[FindsBy(How = How.XPath, Using = "//*[@id=\"seat-filter-bus-type\"]/a[1]")]
        //public IWebElement? BusTypeCheckBox { get; set; }


        //Act

        //public void ClickBusTypeCheckBox()
        //{
          //  BusTypeCheckBox?.Click();
        //}
    }
}
