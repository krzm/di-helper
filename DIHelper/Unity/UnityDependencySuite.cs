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
		RegisterContainer();
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

	protected virtual void RegisterContainer() =>
		Container.RegisterInstance<IUnityContainer>(
			Container
			, InstanceLifetime.Singleton);

	protected virtual void RegisterDatabase() { }

	protected virtual void RegisterAppData() { }

	protected virtual void RegisterConsoleOutput() =>
		RegisterSet<AppOutput>();

	protected virtual void RegisterConsoleInput() =>
		RegisterSet<AppInput>();

	protected virtual void RegisterUtils() { }

	protected virtual void RegisterDataMappings() { }

	protected virtual void RegisterValidators() { }

	protected virtual void RegisterCommands() { }

	protected virtual void RegisterCommandSystem() { }

	protected virtual void RegisterProgram() { }
}