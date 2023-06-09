using SterenTicketsBE.Model.Requests;
using SterenTicketsBE.Model.Responses;
using SterenTicketsBE.Persistence.DapperConnection;

namespace SterenTicketsBE.Persistence.Interfaces
{
    public interface DashboardTicketInterface
    {
        public Task<Response<IEnumerable<DashboardTicketResponse>>> AllotTicket(DashboardTicketRequest requestTicket);
        public Task<Response<IEnumerable<DashboardTicketResponse>>> GetTickesByStatus(int status);
        public Task<Response<IEnumerable<DashboardTicketResponse>>> GetTickesByDepartament(int id_departamento);
    }
}