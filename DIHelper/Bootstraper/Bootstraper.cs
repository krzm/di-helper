namespace DIHelper;

public class Bootstraper 
    : BootstraperBase
{
	private readonly IDependencySuite suite;

	public Bootstraper(
		IDependencySuite suite)
	{
		this.suite = suite;
		ArgumentNullException.ThrowIfNull(this.suite);
	}

	public override void Boot(string[] args)
	{
		ArgumentNullException.ThrowIfNull(args);
		suite.Register();
		suite.Resolve<IAppProgram>().Main(args);
	}
}