namespace UsuarioAPI.Entities
{
    public class Feed
    {
        public Guid Id { get; set; }
        public string Name{ get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Removed { get; set; }
    }
}
