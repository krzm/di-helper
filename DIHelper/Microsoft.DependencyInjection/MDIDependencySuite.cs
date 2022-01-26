using Microsoft.Extensions.DependencyInjection;

namespace DIHelper.Microsoft.DI;

public abstract class MDIDependencySuite : DependencySuite<IServiceCollection>
{
    private IServiceProvider? serviceProvider;

    protected MDIDependencySuite(
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