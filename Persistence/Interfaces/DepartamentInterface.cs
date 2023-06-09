using SterenTicketsBE.Model.Requests;
using SterenTicketsBE.Model.Responses;
using SterenTicketsBE.Persistence.DapperConnection;

namespace SterenTicketsBE.Persistence.Interfaces
{
    public interface DepartamentInterface
    {
        public Task<Response<IEnumerable<DepartamentResponse>>> GetDepartaments();
    }
}