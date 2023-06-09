using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SterenTicketsBE.Model.Requests;
using SterenTicketsBE.Model.Responses;
using SterenTicketsBE.Persistence.DapperConnection;
using SterenTicketsBE.Persistence.Interfaces;
using SterenTicketsBE.Security.token;

namespace SterenTicketsBE.Controllers
{    
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class ErrorController : ControllerBase
    {
        private readonly ErrorInterface _errorInterface;
        private readonly JwtGenerateInterface _jwtGenerator;

        public ErrorController(ErrorInterface errorInterface,
                              JwtGenerateInterface jwtGenerator
                            )
        {
            _errorInterface = errorInterface;
            _jwtGenerator = jwtGenerator;
        }
        
        [HttpGet("GetErrors")]
        public async Task<Response<IEnumerable<ErrorResponse>>> GetErrors()
        {
            Response<IEnumerable<ErrorResponse>> result;
            result = await _errorInterface.GetError();

            return result;
        }
    }

}

