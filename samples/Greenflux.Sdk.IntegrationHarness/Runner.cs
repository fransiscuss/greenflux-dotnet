namespace Greenflux.Sdk.IntegrationHarness;

/// <summary>Minimal pass/fail reporter so the harness needs no test framework.</summary>
internal sealed class Runner
{
    public int Passed { get; private set; }

    public int Failed { get; private set; }

    public async Task RunAsync(string name, Func<Task> scenario)
    {
        try
        {
            await scenario().ConfigureAwait(false);
            Passed++;
            Console.WriteLine($"  PASS  {name}");
        }
        catch (Exception ex)
        {
            Failed++;
            Console.WriteLine($"  FAIL  {name}");
            Console.WriteLine($"        {ex.Message}");
        }
    }

    public static async Task<Exception?> CaptureAsync(Func<Task> action)
    {
        try
        {
            await action().ConfigureAwait(false);
            return null;
        }
        catch (Exception ex)
        {
            return ex;
        }
    }

    public static void AssertEqual<T>(T expected, T actual, string what)
    {
        if (!EqualityComparer<T>.Default.Equals(expected, actual))
            throw new InvalidOperationException($"{what}: expected <{expected}> but was <{actual}>");
    }

    public static void AssertContains(string? haystack, string needle, string what)
    {
        if (haystack is null || !haystack.Contains(needle, StringComparison.Ordinal))
            throw new InvalidOperationException($"{what}: expected to find <{needle}> in <{haystack}>");
    }

    public static void AssertTrue(bool condition, string what)
    {
        if (!condition) throw new InvalidOperationException(what);
    }
}
