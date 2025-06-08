namespace PEngine.Engine.Log;

public class ConsoleLogger : ILogger
{
    public void Initialize()
    {
        LogInfo(this, "Console logger has just initialized.");
    }
    
    public void LogInfo(object sender, string message)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Info [{sender}]: {message}");
        Console.ResetColor();
    }

    public void LogWarning(object sender, string warning)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Warning [{sender}]: {warning}");
        Console.ResetColor();
    }

    public void LogError(object sender, string error)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Error.WriteLine($"Error [{sender}]: {error}");
        Console.ResetColor();
    }
}