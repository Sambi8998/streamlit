using Abhibus.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Abhibus.PageObjects
{
    internal class AbhibusHomePage
    {
        IWebDriver? driver;
        public AbhibusHomePage(IWebDriver? driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }

        //Arrange
        [FindsBy(How = How.XPath, Using = (""))]
        private IWebElement? Login { get; }

        
        
        [FindsBy(How = How.XPath, Using = ("//*[@id=\"abhibus-logo\"]"))]
        private IWebElement? LogoCheck { get; set; }

        [FindsBy(How = How.XPath, Using = ("//input[@placeholder='From Station']"))]
        private IWebElement? FromInput { get; set; }

        [FindsBy(How = How.XPath, Using = ("//input[@placeholder='To Station']"))]
        private IWebElement? ToInput { get; set; }

        [FindsBy(How = How.XPath, Using = ("//*[@id=\"jaurney-date\"]/div/div/div/div[3]/a[2]"))]
        public IWebElement? Date { get; set; }
        
        [FindsBy(How = How.Id, Using = ("search-button"))]
        private IWebElement? SearchButton { get; set; }


        [FindsBy(How = How.Id, Using = "price-drop")]
        private IWebElement? PriceDrop { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"seat-filter-bus-type\"]/a[1]/span[2]")]
        public IWebElement? BusType { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"seat-filter-departure-list\"]/a[3]")]
        public IWebElement? Departure { get; set; }

        //[FindsBy(How = How.XPath, Using = "//div[div[div[text()='Bus Partner']]]")]
        //public IWebElement? BusPartner { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'fare-info col')]//following::button)[2]")]
        public IWebElement? ShowSeats { get; set; }

        

        [FindsBy(How = How.XPath, Using = "//*[@id=\"seat-layout-details\"]/tbody/tr[1]/td[1]/div/button")]
        public IWebElement? Select { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"place-container\"]/div[1]/input")]
        public IWebElement? BP {  get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"place-container\"]/div[2]/input")]
        public IWebElement? DP { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"seating-container\"]/div[3]/div[2]/div/div/button")]
        public IWebElement? Continue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"login-heading\"]/div[1]/span")]
        public IWebElement? Close { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"passenger-detail-name\"]/div/div/div/div/div/input")]
        public IWebElement? Name { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"passenger-detail-age\"]/div/div/div[2]/input")]
        public IWebElement? Age { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"passenger-detail-gender\"]/div/button[2]")]
        public IWebElement? Gender { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"passenger-details-mob-input\"]/div/div/div[2]/input")]
        public IWebElement? Contact { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"passenger-details-email\"]/div/div/div[2]/input")]
        public IWebElement? Email { get; set; }

       

        [FindsBy(How = How.XPath, Using = "//*[@id=\"travel-insurance-content\"]/div/div/div[1]/a")]
        public IWebElement? TravelIns { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"billing-add-text-input\"]/div/div")]
        public IWebElement? Address { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"billing-add-num-input\"]/div/div/div[2]/input")]
        public IWebElement? Pin { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"billing-add-select-input\"]/div/div/div/div/div/input")]
        public IWebElement? State { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"billing-add-city-input\"]/div/div/div/input")]
        public IWebElement? City {  get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id=\"billing-add-save-button\"]/a")]
        public IWebElement? Save { get; set; }

        











        //Act
        public void ClickLogin()
        {
            Login?.Click();
            Thread.Sleep(2000);
        }
        
        
        public void ClickLogoCheck()
        {
            LogoCheck?.Click();
            Thread.Sleep(2000);
        }

        
        
        
        
        
        
        public void ClickFromInput(string? fromStation)
        {
            FromInput?.Click();
            Thread.Sleep(2000);
            FromInput?.SendKeys(fromStation);
            FromInput?.SendKeys(Keys.Enter);
        }

        public void ClickToInput(string? toStation)
        {
            ToInput?.Click();
            Thread.Sleep(2000);
            ToInput?.SendKeys(toStation);
            ToInput?.SendKeys(Keys.Enter);
        }
        public void DateClick()
        {
            Date?.Click();
            

        }
        public void ClickSearchButton()
        {
            SearchButton?.Click();
        }

        public void ClickPriceDrop()
        {

            PriceDrop?.Click();
            Console.WriteLine("PD clicked");
            Thread.Sleep(3000);
            
        }
        
        public void ClickBusType(string? bustype)
        {
            Thread.Sleep(3000);

            BusType?.Click();
            
        }
       
        public void ClickDeparture(string? departure)
        {
            Departure?.Click();

        }
        //public void ClickBusPartner(string? buspartner)
        //{
          //  CoreCodes.ScrollIntoView(driver, BusPartner);
            //Thread.Sleep(3000);
            //BusPartner?.Click();

        //}
        public void ClickShowSeats(string? seats)
        {
            Thread.Sleep(3000);
            ShowSeats?.Click();
        }
        
        public void ClickSelect(string? select)
        {
            Thread.Sleep(3000);
            Select?.Click();
        }
        public void ClickBP(string? bp)
        {
            Thread.Sleep(3000);
            BP?.Click();
        }
        public void ClickDP(string? dp)
        {
            Thread.Sleep(3000);
            DP?.Click();
        }
        public void ClickContinue()
        {
          Thread.Sleep(3000);
          Continue?.Click();
        }
        public void ClickClose()
        {
            Thread.Sleep(3000);
            Close?.Click();
        }
        public void ClickName(string? name)
        {
            Name?.SendKeys(name);
            Name?.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            Name?.Click();
        }
        public void ClickAge(string? age)
        {
            Age?.SendKeys(age);
            Age?.SendKeys(Keys.Enter);
            Thread.Sleep(3000);
            Name?.Click();
        }
        public void ClickGender()
        {
            Gender?.Click();
            Thread.Sleep(2000);
        }
        public void ClickContact(string? contact)
        {
            Contact?.SendKeys(contact);
            Contact?.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
        }
        public void ClickEmail(string? email)
        {
            Email?.SendKeys(email);
            Email?.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
        }
       
        public void ClickTravelIns()
        {
            TravelIns?.Click();
            Thread.Sleep(2000);
        }
        public void ClickAddress()
        {
            Address?.Click();
            Thread.Sleep(2000);
        }
        public void ClickPin(string? pin)
        {
            Pin?.SendKeys(pin);
            Pin?.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
        }
        public void ClickState(string? state)
        {
            State?.SendKeys(state);
            State?.SendKeys(Keys.Enter);
            Thread.Sleep(2000);

        }
        public void ClickCity(string? city)
        {
            City?.SendKeys(city);
            City?.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
        }
        public void ClickSave()
        {
            Save?.Click();
            Thread.Sleep(2000);
        }

    

    
    










    }
}
