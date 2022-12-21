namespace Movies.Models
{
    public class ActorModel
    {
        public int ActorId { get; set; }

        public string FullName { get; set; } = null!;

        public string Bio { get; set; } = null!;

        public string ProfilePictureUrl { get; set; } = null!;
    }
}
