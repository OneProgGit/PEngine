namespace PEngine.Engine.Log;

public interface ILogger
{
    void Initialize();
    void LogInfo(object sender, string message);
    void LogWarning(object sender, string warning);
    void LogError(object sender, string error);
}