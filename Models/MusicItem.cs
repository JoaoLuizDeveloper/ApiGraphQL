namespace ApiGraphQL.Models
{
    public class MusicItem: Base
    {
        public string? Music { get; set; }
        public string? Comment { get; set; }
        public List<Artist>? Artists { get; set; }
    }
}
