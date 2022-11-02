using OpenQA.Selenium;

public class CategoryTileComponent
{
    private IWebDriver _driver;

    public CategoryTileComponent(IWebDriver driver)
    {
        _driver = driver;
    }

    public void SelectCategoryTile(string categoryName){
        //using explicit wait (in some method) would make it more stable
        var element1 = _driver.FindElement(By.XPath($"//div[contains(@class,'category-tiles')]//div[@data-testid='category-tile']//*[text()='{categoryName}']"));
        element1.Click();
    }
}