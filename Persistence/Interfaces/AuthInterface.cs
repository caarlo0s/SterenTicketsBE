using SterenTicketsBE.Model.Requests;
using SterenTicketsBE.Model.Responses;
using SterenTicketsBE.Persistence.DapperConnection;

namespace SterenTicketsBE.Persistence.Interfaces
{
    public interface AuthInterface
    {
        public Task<Response<IEnumerable<AuthResponse>>> Login(AuthRequest authRequest);
    }
}