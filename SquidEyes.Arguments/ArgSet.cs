namespace SquidEyes.Arguments;

public class ArgSet
{
    private readonly Dictionary<string, object> args = new();

    public void Add<T>(string name, T value)
        where T : IParsable<T>
    {
        args[name] = value;
    }
}