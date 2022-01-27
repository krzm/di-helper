using Unity;

namespace DIHelper.Unity;

public class AppValidators 
    : UnityDependencySet
{
    public AppValidators(
        IUnityContainer container)
        : base(container)
    {
    }

    public override void Register()
    {
        RegisterArgumentModelValidators();
    }

    protected virtual void RegisterArgumentModelValidators() { }
}