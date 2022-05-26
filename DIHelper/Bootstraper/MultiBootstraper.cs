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

    public void CreateApp(SuiteFilter filter)
    {
        var componentSuites = suites.Where(s => s.Key.IsComponentSuite == filter.IsComponentSuite);
        foreach (var suite in componentSuites)
        {
            suite.Value.Register();
        }
        var mainSuite = suites.FirstOrDefault(
            s => s.Key.IsAppSuite).Value;
        mainSuite.Register();
        app = mainSuite.Resolve<IAppProgram>();
    }

    public void RunApp(string[] args)
    {
        ArgumentNullException.ThrowIfNull(args);
        ArgumentNullException.ThrowIfNull(app);
        app.Main(args);
    }
}