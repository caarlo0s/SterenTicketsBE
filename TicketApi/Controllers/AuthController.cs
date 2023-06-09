using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SterenTicketsBE.Model.Requests;
using SterenTicketsBE.Model.Responses;
using SterenTicketsBE.Persistence.DapperConnection;
using SterenTicketsBE.Persistence.Interfaces;
using SterenTicketsBE.Security.token;

namespace middlewareShopifyBk.Controllers
{    
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        private readonly AuthInterface _authInterface;
        private readonly JwtGenerateInterface _jwtGenerator;

        public AuthController(AuthInterface authInterface,
                              JwtGenerateInterface jwtGenerator
                            )
        {
            _authInterface = authInterface;
            _jwtGenerator = jwtGenerator;
        }
        
        [HttpPost("login")]
        public async Task<Response<IEnumerable<AuthResponse>>> Login(AuthRequest authRequest)
        {
            Response<IEnumerable<AuthResponse>> result;
            result = await _authInterface.Login(authRequest);
            if (result.Error == 0 && result.Data.ToList().Count!=0)
                result.Data.First().token = _jwtGenerator.CreateToken(result.Data.First().id_empleado, result.Data.First().usuario, result.Data.First().nombre);
            return result;
        }
    }

}

