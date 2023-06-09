using SterenTicketsBE.Model.Requests;
using SterenTicketsBE.Model.Responses;
using SterenTicketsBE.Persistence.DapperConnection;
using SterenTicketsBE.Persistence.Interfaces;

namespace SterenTicketsBE.Persistence.Repositories
{
    public class TicketRepository : TicketInterface
    {
        private readonly IFactoryConnection _factoryConection;

        public TicketRepository(IFactoryConnection factoryConection)
        {
            _factoryConection = factoryConection;
        }

        public Task<Response<IEnumerable<TicketResponse>>> AddTicket(TicketRequest ticketRequest)
        {
            var storedProcedure = "AddTicket";

            var dynamicParameters = new
            {   comentarios = ticketRequest.comentarios,
                id_departamento = ticketRequest.id_departamento,
                id_error = ticketRequest.id_error,
                creado_por = ticketRequest.creado_por,
            };


            var resultado = ExecProc<TicketResponse>.EjecutaConTran(_factoryConection, storedProcedure, dynamicParameters);
            return resultado;
        }
    }
}


