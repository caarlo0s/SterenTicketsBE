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
    public class DepartamentController : ControllerBase
    {
        private readonly DepartamentInterface _departamentInterface;
        private readonly JwtGenerateInterface _jwtGenerator;

        public DepartamentController(DepartamentInterface departamentInterface,
                              JwtGenerateInterface jwtGenerator
                            )
        {
            _departamentInterface = departamentInterface;
            _jwtGenerator = jwtGenerator;
        }
        
        [HttpGet("GetDepartaments")]
        public async Task<Response<IEnumerable<DepartamentResponse>>> GetDepartaments()
        {
            Response<IEnumerable<DepartamentResponse>> result;
            result = await _departamentInterface.GetDepartaments();

            return result;
        }
    }

}

