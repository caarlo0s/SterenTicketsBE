using SterenTicketsBE.Model.Requests;
using SterenTicketsBE.Model.Responses;
using SterenTicketsBE.Persistence.DapperConnection;
using SterenTicketsBE.Persistence.Interfaces;

namespace SterenTicketsBE.Persistence.Repositories
{
    public class DashboardTicketRepository : DashboardTicketInterface
    {
        private readonly IFactoryConnection _factoryConection;

        public DashboardTicketRepository(IFactoryConnection factoryConection)
        {
            _factoryConection = factoryConection;
        }

        public Task<Response<IEnumerable<DashboardTicketResponse>>> AllotTicket(DashboardTicketRequest requestTicket)
        {
                 var storedProcedure = "AllotTicket";

            var dynamicParameters = new
            {   id_ticket = requestTicket.id_ticket,
                asignado_a = requestTicket.asignado_a,          
            };


            var resultado = ExecProc<DashboardTicketResponse>.EjecutaConTran(_factoryConection, storedProcedure, dynamicParameters);
            return resultado;
        }

        public Task<Response<IEnumerable<DashboardTicketResponse>>> GetTickesByDepartament(int id_departamento)
        {
              var storedProcedure = "GetTicketsByDepart";

            var dynamicParameters = new
            {   id_departamento = id_departamento          
            };


            var resultado = ExecProc<DashboardTicketResponse>.EjecutaConTran(_factoryConection, storedProcedure, dynamicParameters);
            return resultado;
        }

        public Task<Response<IEnumerable<DashboardTicketResponse>>> GetTickesByStatus(int status)
        {
                var storedProcedure = "GetTicketsByStatus";

            var dynamicParameters = new
            {   status = status
          
            };


            var resultado = ExecProc<DashboardTicketResponse>.EjecutaConTran(_factoryConection, storedProcedure, dynamicParameters);
            return resultado;
        }
    }
}


