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
    public class TicketController : ControllerBase
    {
        private readonly TicketInterface _TicketInterface;
        private readonly JwtGenerateInterface _jwtGenerator;

        public TicketController(TicketInterface ticketInterface,
                              JwtGenerateInterface jwtGenerator
                            )
        {
            _TicketInterface = ticketInterface;
            _jwtGenerator = jwtGenerator;
        }
        
        [HttpPost("AddTicket")]
        public async Task<Response<IEnumerable<TicketResponse>>> GetErrors(TicketRequest ticket)
        {
            Response<IEnumerable<TicketResponse>> result;
            result = await _TicketInterface.AddTicket(ticket);

            return result;
        }
    }

}

