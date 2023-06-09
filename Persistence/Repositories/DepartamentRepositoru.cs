using SterenTicketsBE.Model.Requests;
using SterenTicketsBE.Model.Responses;
using SterenTicketsBE.Persistence.DapperConnection;
using SterenTicketsBE.Persistence.Interfaces;

namespace SterenTicketsBE.Persistence.Repositories
{
    public class DepartamentRepository : DepartamentInterface
    {
        private readonly IFactoryConnection _factoryConection;

        public DepartamentRepository(IFactoryConnection factoryConection)
        {
            _factoryConection = factoryConection;
        }

        public Task<Response<IEnumerable<DepartamentResponse>>> GetDepartaments()
        {
             var storedProcedure = "getDepartamentos";

			var dynamicParameters = new{};
    
            var resultado = ExecProc<DepartamentResponse>.EjecutaConTran(_factoryConection, storedProcedure, dynamicParameters);
            return resultado;
        }
    }
}


