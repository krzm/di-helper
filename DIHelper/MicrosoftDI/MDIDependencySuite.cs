using Microsoft.Extensions.DependencyInjection;

namespace DIHelper.MicrosoftDI;

public abstract class MDIDependencySuite 
	: MDIDependencySuiteBase
{
	protected MDIDependencySuite(
		IServiceCollection container) :
			base(container)
	{
	}

	protected override void RegisterSets()
	{
		RegisterContainer();
		RegisterDatabase();
		RegisterAppData();
		RegisterConsoleOutput();
		RegisterConsoleInput();
		RegisterUtils();
		RegisterDataMappings();
		RegisterCommands();
		RegisterProgram();
	}

	private void RegisterContainer() 
		=> Container.AddSingleton(Container);

	protected virtual void RegisterDatabase() { }

	protected virtual void RegisterAppData() { }

	protected virtual void RegisterConsoleOutput() { }

	protected virtual void RegisterConsoleInput() { }

	protected virtual void RegisterUtils() { }

	protected virtual void RegisterDataMappings() { }

	protected virtual void RegisterCommands() { }

	protected virtual void RegisterProgram() { }
}