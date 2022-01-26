namespace DIHelper;

public abstract class DependencySuite<TContainer> 
    : DependencySet<TContainer>
        , IDependencySuite
{
    public DependencySuite(TContainer container) :
        base(container)
    {
    }

    public abstract TType Resolve<TType>();

    public override void Register()
    {
        RegisterSets();
        var dependencySets = GetSets();
        Register(dependencySets);
    }

    protected abstract void RegisterSets();

    protected abstract List<IDependencySet> GetSets();

    private static void Register(List<IDependencySet> dependencySets)
    {
        foreach (var dependencySet in dependencySets)
        {
            dependencySet.Register();
        }
    }
}