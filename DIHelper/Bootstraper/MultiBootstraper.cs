namespace DIHelper;

public class MultiBootstraper
    : BootstraperBase, IMultiBootstraper
{
    private readonly IDictionary<SuiteFilter, IDependencySuite> suites;

    public MultiBootstraper(
        IDictionary<SuiteFilter, IDependencySuite> suites)
    {
        this.suites = suites;
        ArgumentNullException.ThrowIfNull(this.suites);
    }

    public void Boot(
        string[] args
        , SuiteFilter filter)
    {
        var componentSuites = suites.Where(s => s.Key.IsComponentSuite == filter.IsComponentSuite);
        foreach (var suite in componentSuites)
        {
            suite.Value.Register();
        }
    }

    public override void Boot(string[] args)
    {
        ArgumentNullException.ThrowIfNull(args);
        var mainSuite = suites.FirstOrDefault(
            s => s.Key.IsAppSuite).Value;
        mainSuite.Register();
        mainSuite.Resolve<IAppProgram>().Main(args);
    }
}