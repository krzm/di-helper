using Unity;

namespace DIHelper.Unity;

public class UnityDependencySuite 
	: UnityDependencySuiteBase
{
	public UnityDependencySuite(
		IUnityContainer container)
			: base(container)
	{
	}

	protected override void RegisterSets()
	{
		RegisterDatabase();
		RegisterAppData();
		RegisterConsoleOutput();
		RegisterConsoleInput();
		RegisterUtils();
		RegisterDataMappings();
		RegisterValidators();
		RegisterCommands();
		RegisterCommandSystem();
		RegisterProgram();
	}

	protected virtual void RegisterDatabase() { }

	protected virtual void RegisterAppData() { }

	protected virtual void RegisterConsoleOutput() { }

	protected virtual void RegisterConsoleInput() { }

	protected virtual void RegisterUtils() { }

	protected virtual void RegisterDataMappings() { }

	protected virtual void RegisterValidators() { }

	protected virtual void RegisterCommands() { }

	protected virtual void RegisterCommandSystem() { }

	protected virtual void RegisterProgram() { }
}