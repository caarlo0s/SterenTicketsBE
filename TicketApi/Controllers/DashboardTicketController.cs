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
    public class DashboardTicketController : ControllerBase
    {
        private readonly DashboardTicketInterface _TicketInterface;


        public DashboardTicketController(DashboardTicketInterface ticketInterface
                            )
        {
            _TicketInterface = ticketInterface;

        }

        [HttpGet("GetTicketByStatus")]
        public async Task<Response<IEnumerable<DashboardTicketResponse>>> GetTicketByStatus(int status)
        {
            Response<IEnumerable<DashboardTicketResponse>> result;
            result = await _TicketInterface.GetTickesByStatus(status);

            return result;
        }
        [HttpGet("GetTickesByDepartament")]
        public async Task<Response<IEnumerable<DashboardTicketResponse>>> GetTickesByDepartament(int id_departamento)
        {
            Response<IEnumerable<DashboardTicketResponse>> result;
            result = await _TicketInterface.GetTickesByDepartament(id_departamento);

            return result;
        }
        [HttpPost("AllotTicket")]
        public async Task<Response<IEnumerable<DashboardTicketResponse>>> AllotTicket(DashboardTicketRequest requestTicket)
        {
            Response<IEnumerable<DashboardTicketResponse>> result;
            result = await _TicketInterface.AllotTicket(requestTicket);

            return result;
        }
    }

}

