namespace DIHelper;

public abstract class DependencySet<TContainer> : IDependencySet
{
	protected readonly TContainer Container;

	protected DependencySet(
		TContainer container)
	{
		Container = container;
		ArgumentNullException.ThrowIfNull(Container);
	}

	public abstract void Register();
}