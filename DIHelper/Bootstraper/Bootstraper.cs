namespace DIHelper;

public class Bootstraper 
    : BootstraperBase
{
	private readonly IDependencySuite suite;
    private IAppProgram? app;

    public override IAppProgram? App => app;

	public Bootstraper(
		IDependencySuite suite)
	{
		this.suite = suite;
		ArgumentNullException.ThrowIfNull(this.suite);
	}

    public override void CreateApp()
    {
        suite.Register();
		app = suite.Resolve<IAppProgram>();
    }

    public override void RunApp(params string[] args)
	{
		ArgumentNullException.ThrowIfNull(args);
		ArgumentNullException.ThrowIfNull(app);
        app.Main(args);
	}
}