using Microsoft.Extensions.DependencyInjection;

namespace DIHelper.MicrosoftDI;

public abstract class MDIDependencySuiteBase 
    : DependencySuite<IServiceCollection>
{
    private IServiceProvider? serviceProvider;

    protected MDIDependencySuiteBase(
        IServiceCollection container)
            : base(container)
    {
    }

    protected void RegisterSet<TProvider>()
        where TProvider : class, IDependencySet 
        => Container.AddSingleton<IDependencySet, TProvider>();

    protected override List<IDependencySet> GetSets()
    {
        serviceProvider = Container.BuildServiceProvider();
        ArgumentNullException.ThrowIfNull(serviceProvider);
        return serviceProvider.GetServices<IDependencySet>().ToList();
    }

    public override TType Resolve<TType>()
    {
        ArgumentNullException.ThrowIfNull(serviceProvider);
        return serviceProvider.GetService<TType>();
    }
}