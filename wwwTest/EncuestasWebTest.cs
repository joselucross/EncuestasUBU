﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using LibClases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
/**
namespace SeleniumTests
{
    [TestClass]
    public class EncuestasWebTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        private void acceder()
        {
            driver.Navigate().GoToUrl(baseURL + "/Login.aspx");
            driver.FindElement(By.Id("TB_Cuenta")).Clear();
            driver.FindElement(By.Id("TB_Cuenta")).SendKeys("Dios");
            driver.FindElement(By.Id("TB_Pass")).Clear();
            driver.FindElement(By.Id("TB_Pass")).SendKeys("QuienComoDios");
            driver.FindElement(By.Id("B_Acceder")).Click();

            driver.FindElement(By.Id("BE")).Click();
        }

        [TestInitialize]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost:49433/";
            verificationErrors = new StringBuilder();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [TestMethod]
        public void TheCambiarVisibilidadTest()
        {
            acceder();
            IWebElement vB = driver.FindElement(By.Id("BTN_V_1"));
            string val = vB.GetAttribute("value");
            bool visibilidadB = false;
            if (val == "👁")
            {
                visibilidadB = true;
            }
            vB.Click();
            vB = driver.FindElement(By.Id("BTN_V_1"));
            val = vB.GetAttribute("value");
            bool visibilidadA = false;
            if (val == "👁")
            {
                visibilidadA = true;
            }
            Assert.AreNotEqual(visibilidadA, visibilidadB);

            driver.FindElement(By.Id("BCS")).Click();

        }

        [TestMethod]
        public void TheCambiarVisibilidadLimiteTest()
        {
            acceder();

            int i = 0;
            while (IsElementPresent(By.Id("BTN_V_" + i.ToString())) &&
                IsElementPresent(By.Id("LBL_Error")))
            {
                IWebElement vb = driver.FindElement(By.Id("BTN_V_" + i.ToString()));
                if (vb.GetAttribute("value") != "👁")
                {
                    vb.Click();
                }
                i++;
            }
            Assert.IsTrue(IsElementPresent(By.Id("LBL_Error")));
            driver.FindElement(By.Id("BCS")).Click();

        }

        private string getEncAtt(By by, string field = "TT")
        {
            driver.FindElement(by).Click();
            string title = driver.FindElement(By.Id(field)).GetAttribute("value");
            driver.FindElement(By.Id("BC")).Click();
            return title;
        }

        [TestMethod]
        public void TheBorradoConfirmadoTest()
        {
            acceder();

            string titleB = getEncAtt(By.Id("BTN_ED_1"));

            driver.FindElement(By.Id("BTN_B_1")).Click();
            driver.FindElement(By.Id("BTN_CONFIRMAR")).Click();

            string titleA = getEncAtt(By.Id("BTN_ED_1"));

            Assert.AreNotEqual(titleA, titleB);

            driver.FindElement(By.Id("BCS")).Click();
        }

        [TestMethod]
        public void TheBorradoCanceladoTest()
        {
            acceder();

            string titleB = getEncAtt(By.Id("BTN_ED_1"));

            driver.FindElement(By.Id("BTN_B_1")).Click();
            driver.FindElement(By.Id("BTN_CANCELAR")).Click();

            string titleA = getEncAtt(By.Id("BTN_ED_1"));

            Assert.AreEqual(titleA, titleB);

            driver.FindElement(By.Id("BCS")).Click();
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
    */
