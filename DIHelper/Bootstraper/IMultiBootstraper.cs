namespace DIHelper;

public interface IMultiBootstraper
{
    public IAppProgram? App { get; }

    void SetupLibs(SuiteFilter filter);
    void SetupApp(SuiteFilter filter);
    void RunApp(string[] args);
}