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
        serviceProvider = BuildServiceProvider();
        ArgumentNullException.ThrowIfNull(serviceProvider);
        return serviceProvider.GetServices<IDependencySet>().ToList();
    }

    protected abstract IServiceProvider? BuildServiceProvider();

    public override TType Resolve<TType>()
    {
        ArgumentNullException.ThrowIfNull(serviceProvider);
        var obj = serviceProvider.GetService<TType>();
        ArgumentNullException.ThrowIfNull(obj);
        return obj;
    }

    public override void Register()
    {
        base.Register();
        serviceProvider = BuildServiceProvider();
    }
}