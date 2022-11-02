using OpenQA.Selenium;

//Comments describe known limitations and possible improvements
//Verification of the result was not added because it was not in the requirements

//it would be better to initialize objects elsewhere and then use dependency injection
var driver = WebDriverHelper.InitializeDriver();
WebDriverHelper.NavigateToPage(driver, new Uri("https://www.alza.cz/EN/"));

var categoryMenuComponent = new CategoryMenuComponent(driver);
categoryMenuComponent.SelectCategoryMenu("Computers and Laptops");

var categoryTileComponent = new CategoryTileComponent(driver);
categoryTileComponent.SelectCategoryTile("Laptops");

var categoryPage = new CategoryPage(driver);
categoryPage.SortItemsByPriceDesc();
categoryPage.AddFirstXItemsToBasket(2);

driver.Close();