namespace DIHelper;

public abstract class BootstraperBase
    : IBootstraper
{
    public abstract void CreateApp();

    public abstract void RunApp(params string[] args);
}