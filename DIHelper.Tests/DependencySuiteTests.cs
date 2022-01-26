using DIHelper.Tests.Helper;
using Xunit;

namespace DIHelper.Tests;

public class DependencySuiteTests
{
	[Fact]
	public void Check_That_DependencySuite_Registers_Its_Sets_In_Container()
	{
		var containerMock = new UnityContainerMock();
		var dependencySuite = new DependencySuite(containerMock);

		dependencySuite.Register();

		Assert.Equal("testValue1", containerMock.GetInstance<string>("key1"));
		Assert.Equal("testValue2", containerMock.GetInstance<string>("key2"));
	}
}