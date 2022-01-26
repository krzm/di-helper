using Unity;

namespace DIHelper.Unity;

public abstract class UnityDependencySet 
    : DependencySet<IUnityContainer>
{
    public UnityDependencySet(
        IUnityContainer container)
        : base(container)
    {
    }
}