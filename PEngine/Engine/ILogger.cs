namespace PEngine.Engine;

public interface ILogger
{
    void LogInfo(object sender, string message);
    void LogWarning(object sender, string warning);
    void LogError(object sender, string error);
}