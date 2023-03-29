namespace SquidEyes.Arguments;

public class ArgSet
{
    private record Arg<T>(string Name, T data);
}