using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ResultsJournalApi.Controllers;

[ApiController]
[Route("api/risk-group-notification")]
[Authorize(AuthenticationSchemes=JwtBearerDefaults.AuthenticationScheme)]
public class RiskGroupNotificationControler : ControllerBase
{
  [HttpPost]
  public IActionResult PostNotifications()
  {
    return Ok("This is a protected endpoint.");
  }

}