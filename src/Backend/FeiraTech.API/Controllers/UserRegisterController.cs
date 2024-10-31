using FeiraTech.Communication.Response;
using FeiraTech.Communication.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FeiraTech.API.Controllers
{
    [Route("[controller]")]
    [ApiController]

    [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
    public class UserRegisterController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Register (RequestRegisterUserJson request)
        {
            ResponseRegisterUserJson response = null;
            return Created(string.Empty, response)
;        }

    }
}
