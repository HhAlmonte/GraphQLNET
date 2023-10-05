namespace GraphQLNET.Models
{
    public class Streamer
    {
        public int Id { get; set; }
        public string? Url { get; set; }
        public string? Name { get; set; }
        public ICollection<Video>? Videos { get; set; }
    }
}
