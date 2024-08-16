using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ResultsJournalApi.Controllers;

[ApiController]
[Route("api/case-reports")]
[Authorize(AuthenticationSchemes=JwtBearerDefaults.AuthenticationScheme)]
public class CaseReportsController : ControllerBase
{
    private readonly ILogger<CaseReportsController> _logger;

    public CaseReportsController(ILogger<CaseReportsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("This is a protected endpoint.");
    }
}
