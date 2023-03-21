using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ILoggerManager
    {
        void LogInfo(string message);
        void Logwarn(string message);
        void LogDebug(string message);
        void LogError(string message);
    }
}