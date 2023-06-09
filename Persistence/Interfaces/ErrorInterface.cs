using SterenTicketsBE.Model.Requests;
using SterenTicketsBE.Model.Responses;
using SterenTicketsBE.Persistence.DapperConnection;

namespace SterenTicketsBE.Persistence.Interfaces
{
    public interface ErrorInterface
    {
        public Task<Response<IEnumerable<ErrorResponse>>> GetError();
    }
}