[TestFixture]
public class CyberforumTests
{
    private IWebDriver driver;
    private string baseUrl;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        baseUrl = "https://www.cyberforum.ru/";
    }

    [TearDown]
    public void Teardown()
    {
        driver.Quit();
    }

    [Test]
    public void CanNavigateToForum()
    {
        // Открыть главную страницу
        driver.Navigate().GoToUrl(baseUrl);

        // Найти ссылку на форум и перейти на страницу форума
        IWebElement forumLink = driver.FindElement(By.XPath("//a[text()='Форум']"));
        forumLink.Click();

        // Проверить, что заголовок страницы содержит "Форум"
        Assert.IsTrue(driver.Title.Contains("Форум"));
    }

    [Test]
    public void CanSearchForum()
    {
        // Открыть страницу поиска на форуме
        driver.Navigate().GoToUrl(baseUrl + "search.php");

        // Ввести текст для поиска и нажать кнопку поиска
        IWebElement searchInput = driver.FindElement(By.Name("q"));
        searchInput.SendKeys("Selenium");
        searchInput.Submit();

        // Проверить, что заголовок страницы содержит текст для поиска
        Assert.IsTrue(driver.Title.Contains("Selenium"));
    }
}
