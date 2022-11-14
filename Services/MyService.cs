using Microsoft.Extensions.Logging;
namespace MyFunctions
{
    public class MyService : IMyService
    {
        private static ILogger<IMyService> _log;
        public MyService(ILogger<IMyService> log)
        {
            _log = log;
        }
        public void DoWork()
        {

            _log.LogInformation("Doing service work");
        }
    }
}
