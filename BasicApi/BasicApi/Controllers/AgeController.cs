namespace BasicApi.Controllers;

using Constants;
using Dto;
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

    /// <summary>
    /// Checks if an age is legally an adult
    /// </summary>
    /// <param name="age"></param>
    /// <returns>If they are an adult</returns>
    /// <response code="200">If the age provided is legally an adult</response>
    [HttpGet("{age:int}")]
    [Produces("application/json")]
    [ProducesResponseType(typeof(AgeDto), StatusCodes.Status200OK)]
    public Task<IActionResult> Get([FromRoute]int age)
    {
        _logger.LogInformation("'IsAdult' running with age: {Age}", age);
        var result = _ageService.IsAdult(age);
        return Task.FromResult<IActionResult>(
            new OkObjectResult(new AgeDto
            {
                IsAdult = result
            }));
    }
}