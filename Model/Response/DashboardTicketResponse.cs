namespace SterenTicketsBE.Model.Responses
{
    public class DashboardTicketResponse
    {
        public int id_ticket { get; set; }     
        public string ?comentarios{get;set;}      
        public DateTime fecha_asignacion{get;set;}      
        public DateTime fecha_cierre{get;set;}      
        public string ?creado_por{get;set;}      
        public int status{get;set;} 
        public string? departamento{get;set;}  
        public string ?error{get;set;}    
        public string ?nombre{get;set;}      
       
        
    }
}