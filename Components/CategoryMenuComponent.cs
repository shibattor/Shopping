using OpenQA.Selenium;

public class CategoryMenuComponent
{
    private readonly IWebDriver _driver;

    public CategoryMenuComponent(IWebDriver driver)
    {
        _driver = driver;
    }

    public void SelectCategoryMenu(string categoryName)
    {
        var element = _driver.FindElement(By.XPath($"//ul[@class='fmenu']/li/a[text()='{categoryName}']"));
        element.Click();
    }
}