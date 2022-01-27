using Unity;
using Unity.Injection;

namespace DIHelper.Unity;

public abstract class UnityDependencySuiteBase 
    : DependencySuite<IUnityContainer>
{
    protected UnityDependencySuiteBase(
        IUnityContainer container)
            : base(container)
    {
    }

    protected void RegisterSet<TProvider>(
        InjectionConstructor injectionConstructor)
            where TProvider : IDependencySet 
        => Container
            .RegisterSingleton<IDependencySet, TProvider>(
                typeof(TProvider).Name
                , injectionConstructor);

    protected void RegisterSet<TProvider>()
        where TProvider : IDependencySet 
        => Container
            .RegisterSingleton<IDependencySet, TProvider>(
                typeof(TProvider).Name);

    protected override List<IDependencySet> GetSets() 
        => Container.Resolve<List<IDependencySet>>();

    public override TType Resolve<TType>()
        => Container.Resolve<TType>();
}