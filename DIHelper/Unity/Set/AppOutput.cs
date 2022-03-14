using CLIHelper;
using Unity;

namespace DIHelper.Unity;

public class AppOutput 
    : UnityDependencySet
{
    public AppOutput(
        IUnityContainer container)
        : base(container)
    {
    }

    public override void Register()
    {
        Container.RegisterSingleton<IOutput, ConsoleOut>();
        RegisterColumnCalculators();
        RegisterTableProviders();
    }

    protected virtual void RegisterColumnCalculators() { }

    protected virtual void RegisterTableProviders() { }
}