namespace DIHelper;

public class MultiBootstraper
    : IMultiBootstraper
{
    private readonly IDictionary<SuiteFilter, IDependencySuite> suites;
    private IAppProgram? app;

    public IAppProgram? App => app;

    public MultiBootstraper(
        IDictionary<SuiteFilter, IDependencySuite> suites)
    {
        this.suites = suites;
        ArgumentNullException.ThrowIfNull(this.suites);
    }

    public void SetupLibs(SuiteFilter filter)
    {
        var componentSuites = suites.Where(s => s.Key.IsComponentSuite == filter.IsComponentSuite);
        ArgumentNullException.ThrowIfNull(componentSuites);
        foreach (var suite in componentSuites)
        {
            suite.Value.Register();
        }
    }

    public void SetupApp(SuiteFilter filter)
    {
        var mainSuite = suites.FirstOrDefault(
            s => s.Key.IsAppSuite).Value;
        ArgumentNullException.ThrowIfNull(mainSuite);
        mainSuite.Register();
        app = mainSuite.Resolve<IAppProgram>();
        app.Setup();
        ArgumentNullException.ThrowIfNull(app);
    }

    public void RunApp(string[] args)
    {
        ArgumentNullException.ThrowIfNull(args);
        ArgumentNullException.ThrowIfNull(app);
        app.Main(args);
    }
}