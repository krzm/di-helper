namespace DIHelper;

public interface IBootstraper
{
    public IAppProgram? App { get; }

    void CreateApp();

	void RunApp(params string[] args);
}