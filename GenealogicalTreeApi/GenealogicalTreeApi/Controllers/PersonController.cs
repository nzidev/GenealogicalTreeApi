using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GenealogicalTreeApi.Controllers
{
    /// <summary>
    /// Персона
    /// </summary>
    [Route("/person")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> CreatePerson([FromBody] string surname)
        {
            _logger.LogDebug($"### CreatePerson Controller. [surname:{surname}]");
            return Ok();
        }
    }
}
