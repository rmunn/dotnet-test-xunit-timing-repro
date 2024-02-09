namespace repro;

public class UnitTest1
{
    public string FileId100MB = "0B1MVW1mFO2zmdGhyaUJESWROQkE";
    public string GoogleDriveUrl(string fileId)
    {
        return $"https://drive.usercontent.google.com/download?export=download&confirm=t&id={fileId}";
    }

    [Fact]
    public void SynchronousSleep5Seconds()
    {
        Console.WriteLine($"Starting sync sleep test at {DateTime.Now}...");
        Thread.Sleep(5*1000);
        Console.WriteLine($"After 5-second delay, time is {DateTime.Now}");
    }

    [Fact]
    public async Task Download100MegabyteFileFromGoogle()
    {
        Console.WriteLine($"Starting download test at {DateTime.Now}...");
        var http = new HttpClient();
        var result = await http.GetAsync(GoogleDriveUrl(FileId100MB));
        Console.WriteLine($"Download completed at {DateTime.Now} with status {result.StatusCode} and length {result.Content.Headers.ContentLength}");
    }

    [Fact]
    public async Task AsyncSleep5Seconds()
    {
        Console.WriteLine($"Starting async sleep test at {DateTime.Now}...");
        await Task.Delay(TimeSpan.FromSeconds(5));
        Console.WriteLine($"After 5-second delay, time is {DateTime.Now}");
    }
}