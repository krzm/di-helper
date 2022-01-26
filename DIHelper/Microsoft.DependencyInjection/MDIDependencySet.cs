using Microsoft.Extensions.DependencyInjection;

namespace DIHelper.Microsoft.DI;

public abstract class MDIDependencySet 
    : DependencySet<IServiceCollection>
{
    public MDIDependencySet(
        IServiceCollection container)
        : base(container)
    {
    }
}