namespace BasicApi.Controllers;

using Constants;
using Microsoft.AspNetCore.Mvc;
using Services;

[ApiController]
[Route(PagePath.Age)]
public class AgeController : Controller
{
    private readonly IAgeService _ageService;
    private readonly ILogger<AgeController> _logger;

    public AgeController(IAgeService ageService, ILogger<AgeController> logger)
    {
        _ageService = ageService;
        _logger = logger;
    }

    [HttpGet("{age}")]
    public async Task<IActionResult> Get(int age)
    {
        _logger.LogInformation("'IsAdult' running with age: {Age}", age);
        var result = _ageService.IsAdult(age);
        return new OkObjectResult(result);
    }
}