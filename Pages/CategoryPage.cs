using OpenQA.Selenium;

public class CategoryPage
{
    private IWebDriver _driver;

    public CategoryPage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void SortItemsByPriceDesc(){
        var element = _driver.FindElement(By.XPath($"//div[@id='tabsc']//li[@aria-controls='cenadesc']"));
        element.Click();
    }

    public void AddItemToBasket(){
        var element = _driver.FindElement(By.XPath($"//div[@id='boxc']//div[contains(@class,'browsingitem')]"));
        element.Click();
    }

    private void AddItemToBasket(IWebElement item){
        //requires scrolling to work, not stable
        var element = item.FindElement(By.XPath($".//a[@class='btnk1']"));
        element.Click();
    }

    public void AddFirstXItemsToBasket(int numberOfItems)
    {
        for (int i = 1; i < 3; i++)
        {
            var element = _driver.FindElement(By.XPath($"//div[@id='boxes']/div[{i}]"));
            AddItemToBasket(element);

            _driver.Navigate().Back();
        }
    }
}