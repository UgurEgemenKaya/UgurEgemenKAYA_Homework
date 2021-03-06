// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
namespace DotNetTest
{
[TestFixture]
public class DealoftheDayTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver(@"C:\Users\egeme\Desktop\DotNetTest");
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void dealoftheDay() {
    driver.Navigate().GoToUrl("https://www.amazon.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(1050, 708);
    driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/header[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[3]/span[1]/span[1]/input[1]")).Click();
    driver.FindElement(By.LinkText("Today\'s Deals")).Click();
    Assert.That(driver.FindElement(By.XPath("//body/div[@id=\'a-page\']/div[10]/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/span[1]")).Text, Is.EqualTo("DEAL OF THE DAY"));
  }
  [Test]
  public void shipToTurkey() {
    driver.Navigate().GoToUrl("https://www.amazon.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(1366, 720);
    driver.FindElement(By.Id("twotabsearchtextbox")).Click();
    driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("laptop");
    driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys(Keys.Enter);
    {
      WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(1));
      wait.Until(driver => driver.FindElement(By.XPath("//body/div[@id=\'a-page\']/div[@id=\'search\']/div[1]/div[1]/div[1]/span[3]/div[2]/div[2]/div[1]/span[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/span[1]")).Displayed);
    }
  }
}
}