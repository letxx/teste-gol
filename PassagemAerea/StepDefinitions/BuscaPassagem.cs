using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PassagemAerea.PageObjects;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace PassagemAerea.StepDefinitions
{
    [Binding]
    public class BuscaPassagem
    {
        private IWebDriver driver;

        [Given(@"que acessei a aplicação")]
        public void DadoQueAcesseiAAplicacao()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.voegol.com.br/pt");
            driver.Manage().Window.Maximize();
        }

        [When(@"faço uma pesquisa de compra de passagem")]
        public void QuandoFacoUmaPesquisaDeCompraDePassagem()
        {
            HomePage homePage = new HomePage(driver);

            homePage.PesquisarOrigem();
            homePage.PesquisarDestino();
            homePage.SelecionarDatas();            
            homePage.AdicionarAdultos();

        }

        [When(@"seleciono a opção compre aqui")]
        public void QuandoSelecionoAOpcaoCompreAqui()
        {
            HomePage homePage = new HomePage(driver);
            homePage.SelecionarBtnCompreAqui();
        }

        [Then(@"devo visualizar a tela Escolha seu Voo")]
        public void EntaoDevoVisualizarATelaEscolhaSeuVoo()
        {
            Thread.Sleep(2000);
            Assert.IsNotNull(driver.FindElement(By.ClassName("breadcrumb1")));
        }

        [Then(@"seleciono a menor tarifa do dia")]
        public void EntaoSelecionoAMenorTarifaDoDia()
        {
            EscolhadeVooPage escolhadeVoo = new EscolhadeVooPage(driver);
            escolhadeVoo.MenorPreco();
        }

    }
}
