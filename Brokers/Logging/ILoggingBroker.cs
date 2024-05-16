
namespace Register.Brokers.Logging
{
    internal interface ILoggingBroker
    {
        void LogInformation(string message);
        void LogError(string userMessage);
    }
}
