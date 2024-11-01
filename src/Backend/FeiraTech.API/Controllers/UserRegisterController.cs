using FeiraTech.Communication.Response;
using FeiraTech.Communication.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FeiraTech.Application.UseCase.User.Register;

namespace FeiraTech.API.Controllers
{
    [Route("[controller]")]
    [ApiController]

    [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
    public class UserRegisterController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Register([FromServices] IUserRegisterUseCase services, [FromBody] RequestRegisterUserJson request)
        {
            ResponseRegisterUserJson response = await services.Execute(request);
            return Created(string.Empty, response)
;        }

    }
}
