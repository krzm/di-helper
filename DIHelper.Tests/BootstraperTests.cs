using System;
using Moq;
using Xunit;

namespace DIHelper.Tests;

public class BootstraperTests
{
	[Fact]
	public void Dependency_Should_Throw_When_Null()
	{
		Assert.Throws<ArgumentNullException>(
			()=> 
			{
				IBootstraper sut = 
				#pragma warning disable CS8625
					new Bootstraper(null);
				#pragma warning restore CS8625
			});
	}

	[Fact]
	public void Param_Should_Throw_When_Null()
	{
		Assert.Throws<ArgumentNullException>(
			"args"
			, ()=> 
			{ 
				new Bootstraper(
					new Mock<IDependencySuite>().Object)
				#pragma warning disable CS8625
						.RunApp(null);
				#pragma warning restore CS8625
			});
	}

	[Fact]
	public void Should_Invoke_Methods()
	{
		var suiteMock = new Mock<IDependencySuite>();
		var programMock = new Mock<IAppProgram>();
		programMock.Setup(m => m.Main(It.IsAny<string[]>()));
		suiteMock.Setup(m => m.Register());
		suiteMock.Setup(m => m.Resolve<IAppProgram>()).Returns(programMock.Object);
		IBootstraper sut = new Bootstraper(suiteMock.Object); 
		
        sut.CreateApp();
		sut.RunApp(Array.Empty<string>());

		suiteMock.Verify(m => m.Register(), Times.Once());
		suiteMock.Verify(m => m.Resolve<IAppProgram>(), Times.Once());
		programMock.Verify(m => m.Main(It.IsAny<string[]>()), Times.Once());
	}
}