namespace DIHelper.Tests.Helper;

public class DependencySetMock1 
	: DependencySet<IUnityContainerMock>
{
	public DependencySetMock1(
		IUnityContainerMock unityContainer)
		: base(unityContainer)
	{

	}

	public override void Register()
	{
		Container.Register("key1", "testValue1");
	}
}