namespace DIHelper;

public abstract class BootstraperBase
    : IBootstraper
{
    public abstract IAppProgram? App { get; }

    public abstract void CreateApp();

    public abstract void RunApp(params string[] args);
}