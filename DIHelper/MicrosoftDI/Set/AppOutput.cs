using CLIHelper;
using Microsoft.Extensions.DependencyInjection;

namespace DIHelper.MicrosoftDI;

public class AppOutput 
	: MDIDependencySet
{
	public AppOutput(
		IServiceCollection container)
		: base(container)
	{
	}

	public override void Register()
	{
		RegisterOutput();
		RegisterColumnCalculators();
		RegisterTableProviders();
	}

	private void RegisterOutput()
	{
		Container
			.AddSingleton<IOutput, Output>();
	}

	protected virtual void RegisterColumnCalculators() { }

	protected virtual void RegisterTableProviders() { }
}