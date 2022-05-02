namespace DIHelper;

public class SuiteFilter
{
    private const string Error = "Bools {0} and {1} must be mutually exclusive";

    public SuiteFilter(
        bool isComponentSuite
        , bool isAppSuite = false
    )
    {
        IsComponentSuite = isComponentSuite;
        IsAppSuite = isAppSuite;
        if(IsComponentSuite && IsAppSuite
            || (IsComponentSuite == false && IsAppSuite == false))
        {
            throw new ArgumentException(
                string.Format(
                    Error
                    , nameof(IsComponentSuite)
                    , nameof(IsAppSuite)));
        }
    }

    public bool IsComponentSuite { get; init; }

    public bool IsAppSuite { get; init; }
}