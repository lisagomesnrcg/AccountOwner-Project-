using Contracts;
using NLog;

namespace LoggerSevice;

    public class LoggerManager : ILoggerManager
    {
        private static ILoggerManager logger =LoggerManager.GetCurrentClassLogger();
        public void LogDebug(string message)=> logger.Debug(message);
        public void LogError(string message)=> logger.Error(message);
        public void LogInfo(string message)=> logger.Info(message);
        public void Logwarn(string message)=> logger.Warn(message);

    }
