namespace repro;

public class UnitTest1
{
    [Fact]
    public async Task SecondAsyncSleep()
    {
        Console.WriteLine($"Starting second async sleep test at {DateTime.Now}...");
        await Task.Delay(TimeSpan.FromSeconds(3));
        Console.WriteLine($"After 3-second delay, time is {DateTime.Now}");
    }

    [Fact]
    public async Task AsyncSleep5Seconds()
    {
        Console.WriteLine($"Starting async sleep test at {DateTime.Now}...");
        await Task.Delay(TimeSpan.FromSeconds(7));
        Console.WriteLine($"After 7-second delay, time is {DateTime.Now}");
    }
}