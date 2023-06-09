using SterenTicketsBE.Model.Requests;
using SterenTicketsBE.Model.Responses;
using SterenTicketsBE.Persistence.DapperConnection;
using SterenTicketsBE.Persistence.Interfaces;

namespace SterenTicketsBE.Persistence.Repositories
{
    public class ErrorRepository : ErrorInterface
    {
        private readonly IFactoryConnection _factoryConection;

        public ErrorRepository(IFactoryConnection factoryConection)
        {
            _factoryConection = factoryConection;
        }

        public Task<Response<IEnumerable<ErrorResponse>>> GetError()
        {
              var storedProcedure = "getErrors";

			var dynamicParameters = new{};
    
            var resultado = ExecProc<ErrorResponse>.EjecutaConTran(_factoryConection, storedProcedure, dynamicParameters);
            return resultado;
        }
    }
}


