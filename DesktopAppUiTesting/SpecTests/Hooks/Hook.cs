namespace SpecTests.Hooks;

[Binding]
public class Hooks
{
    private readonly ScenarioContext _scenarioContext;

    public Hooks(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [BeforeTestRun]
    public static void BeforeTestRun()
    {
        App.Initialize();
    }

    [AfterTestRun]
    public static void AfterTestRun()
    {
        App.Cleanup();
        App.StopWinappDriver();
    }
}