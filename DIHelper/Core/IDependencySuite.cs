namespace DIHelper;

public interface IDependencySuite : IDependencySet
{
	TType Resolve<TType>();
}