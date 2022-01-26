namespace DIHelper.Tests.Helper;

public class DependencySetMock2 
	: DependencySet<IUnityContainerMock>
{
	public DependencySetMock2(
		IUnityContainerMock unityContainer)
		: base(unityContainer)
	{

	}

	public override void Register()
	{
		Container.Register("key2", "testValue2");
	}
}