using System.Data;

namespace SterenTicketsBE.Persistence.DapperConnection
{
    public interface IFactoryConnection
    {
        void CloseConnection();
        IDbConnection GetConnection();
            
    }
};