using AutoMapper;
using Unity;

namespace DIHelper.Unity;

public abstract class AppMappings 
    : UnityDependencySet
{
    public AppMappings(
        IUnityContainer container)
        : base(container)
    {
    }

    public override void Register() =>
        Container.RegisterInstance(CreateMap().CreateMapper());

    protected abstract MapperConfiguration CreateMap();
}