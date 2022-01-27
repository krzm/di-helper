using Microsoft.Extensions.DependencyInjection;

namespace DIHelper.MicrosoftDI;

public abstract class MDIDependencySet 
    : DependencySet<IServiceCollection>
{
    public MDIDependencySet(
        IServiceCollection container)
        : base(container)
    {
    }
}