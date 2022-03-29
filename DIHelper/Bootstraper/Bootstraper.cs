namespace DIHelper;

public class Bootstraper : IBootstraper
{
	private readonly IDependencySuite dependencySuite;

	public Bootstraper(
		IDependencySuite dependencySuite)
	{
		this.dependencySuite = dependencySuite;
		ArgumentNullException.ThrowIfNull(this.dependencySuite);
	}

	public void Boot(string[] args)
	{
		ArgumentNullException.ThrowIfNull(args);
		dependencySuite.Register();
		dependencySuite.Resolve<IAppProgram>().Main(args);
	}
}