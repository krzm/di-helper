using System.Collections.Generic;

namespace DIHelper.Tests.Helper;

public class DependencySuite 
    : DependencySuite<IUnityContainerMock>
{

    public DependencySuite(
        IUnityContainerMock container) 
        : base(container)
    {
    }

    protected override void RegisterSets()
    {
        Container.Register("provider1", new DependencySetMock1(Container));
        Container.Register("provider2", new DependencySetMock2(Container));
    }

    protected override List<IDependencySet> GetSets()
    {
        return new List<IDependencySet>
        {
            Container.GetInstance<IDependencySet>("provider1")
            , Container.GetInstance<IDependencySet>("provider2")
        };
    }

    public override TType Resolve<TType>()
    {
        throw new System.NotImplementedException();
    }
}