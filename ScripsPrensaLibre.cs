namespace NoticiasApp.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<Noticia> Noticias { get; set; }
        public ICollection<Comentario> Comentarios { get; set; }
    }
}
