using SterenTicketsBE.Model.Requests;
using SterenTicketsBE.Model.Responses;
using SterenTicketsBE.Persistence.DapperConnection;

namespace SterenTicketsBE.Persistence.Interfaces
{
    public interface TicketInterface
    {
        public Task<Response<IEnumerable<TicketResponse>>> AddTicket(TicketRequest requestTicket);
    }
}