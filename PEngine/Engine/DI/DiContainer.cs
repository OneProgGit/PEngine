using PEngine.Engine.Log;

namespace PEngine.Engine.DI;

public class DiContainer : IDiContainer
{
    private Dictionary<(string, Type), DiRegistration> _registrations = new();
    private ILogger _logger;
    
    public void Initialize(ref ILogger logger)
    {
        _logger = logger;
        _logger.LogInfo(this, "Default DI container has just initialized.");
    }
    
    public void Register<T>(T instance, string tag = "")
    {
        if (instance == null)
        {
            _logger.LogError(this, "Trying to register a null instance");
            return;
        }
        
        _registrations[(tag, typeof(T))] = new DiRegistration()
        {
            Instance = instance 
        };
    }

    public T Get<T>(string tag = "")
    {
        return (T)_registrations[(tag, typeof(T))].Instance;
    }
}