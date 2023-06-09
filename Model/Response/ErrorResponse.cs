namespace SterenTicketsBE.Model.Responses
{
    public class ErrorResponse
    {
        public int id_error { get; set; }        
        public string ?paso_uno { get; set; }
        public string ?paso_dos { get; set; }
        public string ?paso_tres { get; set; }
        public string ?descripcion{ get; set; }
        
    }
}