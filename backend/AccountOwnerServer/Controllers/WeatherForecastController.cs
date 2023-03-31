using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AccountOwnerServer.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILoggerManager _logger;
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public WeatherForecastController(ILoggerManager logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<string> Get()
    {
        _logger.LogInfo("Testado um log de informação a partir de um Contoller.");
        _logger.LogDebug("Testado um log de debug a partir de um Controller.");
        _logger.LogWarn("Testado um log de aviso a partir de um Controller.");
        _logger.LogError("Testado um log de erro a partir de um Controller.");
        return new string[] { "value1", "value2" };
    }
}
