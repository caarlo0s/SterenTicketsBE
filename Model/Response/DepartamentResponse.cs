namespace SterenTicketsBE.Model.Responses
{
    public class DepartamentResponse
    {
        public int id_departamento { get; set; }        
        public string ?nombre { get; set; }
        public string ?descripcion { get; set; }
        public string ?area { get; set; } 
    }
}