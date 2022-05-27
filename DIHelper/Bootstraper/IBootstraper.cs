namespace DIHelper;

public interface IBootstraper
{
    void CreateApp();

	void RunApp(params string[] args);
}