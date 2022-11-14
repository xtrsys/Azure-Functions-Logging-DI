using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace MyFunctions
{
    public class LoggerFunction
    {
        private readonly IMyService _myService;
        public LoggerFunction(IMyService myService)
        {
            _myService = myService;
        }
        [FunctionName(nameof(LoggerFunction)]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Doing function work");

            _myService.DoWork();

            return new OkObjectResult(true); 
        }
    }
}
