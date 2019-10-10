using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PassagemAerea.PageObjects
{
    class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        #region PageObjects
        
        private IWebElement InputOrigem()
        {
            return driver.FindElement(By.PartialLinkText("origem"));
        }

        private IWebElement InputDestino()
        {
            return driver.FindElement(By.PartialLinkText("destino"));
        }


        private IWebElement LblViajarde()
        {
            return driver.FindElement(By.CssSelector("#header-chosen-origin"));
        }

        private IWebElement LblViajarPara()
        {
            return driver.FindElement(By.CssSelector("#header-chosen-destiny"));
        }

        private IWebElement InputAdultos()
        {
            return driver.FindElement(By.Id("number-adults"));
        }

        private IWebElement AdicionarAdulto()
        {
            return driver.FindElement(By.ClassName("icon-add"));
        }

        private IWebElement BtnCompreAqui()
        {
            return driver.FindElement(By.Id("btn-box-buy"));
        }

        private IWebElement CldDataIda()
        {
            return driver.FindElement(By.Id("datepickerGo"));
        }

        private IWebElement CldDataVolta()
        {
            return driver.FindElement(By.ClassName("calendar-back"));
        }
        private IWebElement DatepickerMes()
        {
            return driver.FindElement(By.XPath("//a[@class='ui-datepicker-next ui-corner-all'][@title='Próximo']"));
        }

        private IWebElement DatepickerIda()
        {
            return  driver.FindElement(By.XPath("//div[@class='ui-datepicker-group ui-datepicker-group-first']/table/tbody/tr/td/a[text()='11']"));
        }

        private IWebElement DatepickerVolta()
        {
            return driver.FindElement(By.XPath("//div[@class='ui-datepicker-group ui-datepicker-group-last']/table/tbody/tr/td/a[text()='11']"));
        }
        #endregion PageObjects

        #region Navigation

        public void PesquisarOrigem()
        {
            InputOrigem().Click();
            LblViajarde().SendKeys("SDU");
            LblViajarde().SendKeys(Keys.Tab);
        }

        public void PesquisarDestino()
        {
            InputDestino().Click();
            LblViajarPara().SendKeys("GRU");
            LblViajarPara().SendKeys(Keys.Tab);
        }

        public void SelecionarDatas()
        {
            CldDataIda().Click();
            DatepickerIda().Click();
            Thread.Sleep(2000);

            CldDataVolta().Click();
            DatepickerMes().Click(); 
            DatepickerVolta().Click();
            Thread.Sleep(2000);
        }

        public void AdicionarAdultos()
        {
            InputAdultos().Click();
            AdicionarAdulto().Click();
        }

        public void SelecionarBtnCompreAqui()
        {
            BtnCompreAqui().Click();
           
        }
        #endregion Navigation
    }
}
