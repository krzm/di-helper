namespace DIHelper;

public interface IMultiBootstraper
{
    public IAppProgram? App { get; }

    void CreateApp(SuiteFilter filter);

    void RunApp(string[] args);
}