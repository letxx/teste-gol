using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagemAerea.PageObjects
{
    class EscolhadeVooPage : BasePage
    {
        public EscolhadeVooPage(IWebDriver driver) : base(driver)
        {
        }



        #region PageObjects

        private IWebElement LessPriceBoxIda()
        {
            return driver.FindElement(By.CssSelector("#ControlGroupSelect2View_AvailabilityInputSelect2View_RadioButtonMkt1Fare1"));
        }

        private IWebElement lessPriceBoxVolta;
        private IWebElement LessPriceBoxVolta()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,2950);");
            //js.ExecuteScript("arguments[0].scrollIntoView(true);", lessPriceBox);
            return lessPriceBoxVolta = driver.FindElement(By.CssSelector("#ControlGroupSelect2View_AvailabilityInputSelect2View_RadioButtonMkt2Fare10"));

        }



        #endregion PageObjects


        #region Navigation

        public void MenorPreco()
        {
            LessPriceBoxIda().Click();
            LessPriceBoxVolta().Click();

        }

        #endregion Navigation
    }
}
