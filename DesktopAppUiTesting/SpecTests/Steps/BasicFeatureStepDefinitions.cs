using NUnit.Framework;

namespace SpecTests.Steps.Basic;

[Binding]
public class BasicFeatureStepDefinitions
{
    private readonly ScenarioContext _scenarioContext;

    public BasicFeatureStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given(@"the the basic module is opened")]
    public void GivenTheTheBasicModuleIsOpened()
    {
        // _scenarioContext.Pending();
        Assert.IsTrue(true);
    }

    [When(@"the ""(.*)"" text is entered")]
    public void WhenTheTextIsEntered(string text)
    {
        var textBox = App.AppSession.FindElementByAccessibilityId("StockNameTextBox");
        textBox.SendKeys(text);
    }

    [Then(@"the ""(.*)"" text should be displayed")]
    public void ThenTheTextShouldBeDisplayed(string expectedText)
    {
        var label = App.AppSession.FindElementByAccessibilityId("StockNameLabel");
        var actualText = label.Text;

        Assert.AreEqual(expectedText, actualText);
    }
}