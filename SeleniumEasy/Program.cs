using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumEasy
{
    class Program
    {
        static IWebDriver driver;

        async static void PreencherDados()
        {
            #region dados pessoais
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(10));
            By nome = By.XPath("//input[@id='txtNome']");
            By telefone = By.XPath("//input[@id='txtTelefone']");
            By skype = By.XPath("//input[@id='txtSkype']");
            By linkedin = By.XPath("//input[@id='txtLinkedin']");
            By cidade = By.XPath("//input[@id='txtCidade']");
            By estado = By.XPath("//input[@id='txtEstado']");
            By portifolio = By.XPath("//input[@id='txtPortifolio']");
            By btnAvancar2 = By.XPath("//button[@id='btnContinuar2']");

            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementExists(nome));
            //Preenche Form
            driver.FindElement(nome).SendKeys("Nome Teste");

            driver.FindElement(telefone).SendKeys("(45) 9999-9999");

            driver.FindElement(skype).SendKeys("skypeUser");

            driver.FindElement(linkedin).SendKeys("linkedin.com/linkedinUser");

            driver.FindElement(cidade).SendKeys("Cidade Teste");

            driver.FindElement(estado).SendKeys("Estado Teste");

            driver.FindElement(portifolio).SendKeys("www.portifolio.com.br");

            Thread.Sleep(200);

            driver.FindElement(btnAvancar2).Click();
            #endregion

            #region disponibilidade
            By disponibilidade = By.XPath("//input[@id='chkDisponibilidade3']");
            By horario = By.XPath("//input[@id='chkHorario5']");
            By salario = By.XPath("//input[@id='txtSalario']");
            By btnContinuar3 = By.XPath("//button[@id='btnContinuar3']");

            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementExists(disponibilidade));

            driver.FindElement(disponibilidade).SendKeys(Keys.Space);

            driver.FindElement(horario).SendKeys(Keys.Space);

            driver.FindElement(salario).SendKeys("25,00");

            Thread.Sleep(200);

            driver.FindElement(btnContinuar3).Click();
            #endregion

            #region Banco
            //aguarda tela

            By txtxNomeTalentoBanco = By.XPath("//input[@id='txtxNomeTalentoBanco']");
            By txtCpf = By.XPath("//input[@id='txtCpf']");
            By txtBanco = By.XPath("//input[@id='txtBanco']");
            By txtAgencia = By.XPath("//input[@id='txtAgencia']");
            By txtConta = By.XPath("//input[@id='txtConta']");
            By chkContaCorrente = By.XPath("//input[@id='chkContaCorrente']");
            By btnContinuar4 = By.XPath("//button[@id='btnContinuar4']");

            wait.Until(ExpectedConditions.ElementExists(By.Id("txtxNomeTalentoBanco")));

            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementExists(disponibilidade));

            driver.FindElement(txtxNomeTalentoBanco).SendKeys("Nome Teste Completo");

            driver.FindElement(txtCpf).SendKeys("000.000.000 00");

            driver.FindElement(txtBanco).SendKeys("Banco Teste");

            driver.FindElement(txtAgencia).SendKeys("0000");

            driver.FindElement(txtConta).SendKeys("12345 6");

            driver.FindElement(chkContaCorrente).SendKeys(Keys.Space);

            Thread.Sleep(200);
            driver.FindElement(btnContinuar4).Click();

            #endregion

            #region Conhecimentos
            //aguarda tela
            Thread.Sleep(1000);
            wait.Until(ExpectedConditions.ElementExists(By.Id("btnContinuar5")));
            IWebElement element;
            element = driver.FindElement(By.Name("Ionic0"));
            element.Click();

            element = driver.FindElement(By.Name("Android1"));
            element.Click();

            element = driver.FindElement(By.Name("IOS2"));
            element.Click();

            element = driver.FindElement(By.Name("HTML3"));
            element.Click();

            element = driver.FindElement(By.Name("CSS4"));
            element.Click();

            element = driver.FindElement(By.Name("Bootstrap5"));
            element.Click();

            element = driver.FindElement(By.Name("Jquery4"));
            element.Click();

            element = driver.FindElement(By.Name("AngularJs3"));
            element.Click();

            //driver.Window();
            element = driver.FindElement(By.Name("Java2"));
            element.Click();

            element = driver.FindElement(By.Name("Asp.Net5"));
            element.Click();

            element = driver.FindElement(By.Name("C4"));
            element.Click();

            element = driver.FindElement(By.Name("C++3"));
            element.Click();

            element = driver.FindElement(By.Name("Cake2"));
            element.Click();

            element = driver.FindElement(By.Name("Django1"));
            element.Click();

            element = driver.FindElement(By.Name("Majento0"));
            element.Click();

            element = driver.FindElement(By.Name("PHP1"));
            element.Click();

            element = driver.FindElement(By.Name("Wordpress2"));
            element.Click();

            element = driver.FindElement(By.Name("Phyton3"));
            element.Click();
            
            element = driver.FindElement(By.Name("Ruby0"));
            element.Click();

            element = driver.FindElement(By.Name("MySQLServer1"));
            element.Click();

            element = driver.FindElement(By.Name("MySQL2"));
            element.Click();

            element = driver.FindElement(By.Name("Salesforce3"));
            element.Click();

            element = driver.FindElement(By.Name("Photoshop4"));
            element.Click();

            element = driver.FindElement(By.Name("SEO5"));
            element.Click();

            element = driver.FindElement(By.Id("txtConhecimento"));
            element.SendKeys("Outro Conhecimento 5");

            Thread.Sleep(200);

            element = driver.FindElement(By.Id("btnContinuar5"));
            element.Click();

            #endregion

            #region Crud
            Thread.Sleep(1000);
            By txtCrud = By.XPath("//input[@id='txtCrud']");
            By btnFinalizar = By.XPath("//button[@id='btnFinalizar']");

            wait.Until(ExpectedConditions.ElementExists(txtCrud));

            //wait.Until(ExpectedConditions.ElementExists(By.Id("txtCrud")));
            driver.FindElement(txtCrud).SendKeys("https://github.com/user/crud");

            Thread.Sleep(200);
            driver.FindElement(btnFinalizar).Click();
            #endregion

            Thread.Sleep(1000);
            element = driver.FindElement(By.Name("tableTalentos"));
            if (element.Text.Contains("email@teste.com"))
            {
                Console.WriteLine("Teste realizado com sucesso!");
                driver.Close();
            }
        }

        static void Main(string[] args)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:53936/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(10000);


            IWebElement element;

            #region Pagina inicial
            //Digita email
            element = driver.FindElement(By.Id("txtEmail"));
            element.SendKeys("email@teste.com");


            Thread.Sleep(200);
            //avanca pagina
            element = driver.FindElement(By.Id("btnContinuar"));
            element.Click();
            #endregion

            Thread newThread = new Thread(Program.PreencherDados);
            newThread.Start();



            /*
             */
        }
    }
}
