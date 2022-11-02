using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public static class WebDriverHelper
{
    public static IWebDriver InitializeDriver(){
        return new ChromeDriver();
    }

    public static void NavigateToPage(IWebDriver driver, Uri uri){
        driver.Navigate().GoToUrl(uri);
    }
}