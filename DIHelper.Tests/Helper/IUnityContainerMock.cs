namespace DIHelper.Tests.Helper;

public interface IUnityContainerMock
{
	void Register<TType>(
		string key
		, TType instance);

	TType GetInstance<TType>(string key);
}