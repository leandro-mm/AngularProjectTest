namespace NovoProjeto.API.Models
{
    public class Evento
    {
        public int EventoId { get; set; } 
        public string Local { get; set; }   
        public string Data { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string ImgURL { get; set; }
    }
}