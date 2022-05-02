namespace DIHelper;

public abstract class BootstraperBase
    : IBootstraper
{
    public abstract void Boot(string[] args);
}