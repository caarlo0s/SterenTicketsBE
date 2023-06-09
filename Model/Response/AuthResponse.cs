namespace SterenTicketsBE.Model.Responses
{
    public class AuthResponse
    {
        public int id_empleado { get; set; }        
        public string ?nombre { get; set; }
        public string ?usuario { get; set; }
        public string ?token { get; set; } 
    }
}