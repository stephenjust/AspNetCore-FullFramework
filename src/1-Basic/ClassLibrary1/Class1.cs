using Microsoft.Extensions.Logging;

namespace ClassLibrary.Basic
{  
    public class Class1
    {
        readonly ILogger _logger;

        public Class1(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Class1>();
            _logger.LogInformation("Class1 constructor - Message.");
        }
    }
}
