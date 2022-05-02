namespace DIHelper;

public interface IMultiBootstraper
    : IBootstraper
{
    void Boot(string[] args, SuiteFilter filter);
}
