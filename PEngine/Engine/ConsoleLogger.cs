namespace PEngine.Engine;

public class ConsoleLogger : ILogger
{
    public void LogInfo(object sender, string message)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"✅ [{sender}] : {message}");
        Console.ResetColor();
    }

    public void LogWarning(object sender, string warning)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"️[{sender}] : {warning}");
        Console.ResetColor();
    }

    public void LogError(object sender, string error)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Error.WriteLine($"⛔ [{sender}] : {error}");
        Console.ResetColor();
    }
}