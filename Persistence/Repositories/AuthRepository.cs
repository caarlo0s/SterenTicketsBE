using SterenTicketsBE.Model.Requests;
using SterenTicketsBE.Model.Responses;
using SterenTicketsBE.Persistence.DapperConnection;
using SterenTicketsBE.Persistence.Interfaces;

namespace SterenTicketsBE.Persistence.Repositories
{
    public class AuthRepository : AuthInterface
    {
        private readonly IFactoryConnection _factoryConection;

        public AuthRepository(IFactoryConnection factoryConection)
        {
            _factoryConection = factoryConection;
        }

        public Task<Response<IEnumerable<AuthResponse>>> Login(AuthRequest authRequest)
        {
            var storedProcedure = "getLogin";

			var dynamicParameters = new
			{
			    usaurio		= authRequest.usuario,
                password	= authRequest.password,
             
			};
    
            var resultado = ExecProc<AuthResponse>.EjecutaSinTran(_factoryConection, storedProcedure, dynamicParameters);
            return resultado;
        }
    }
}


