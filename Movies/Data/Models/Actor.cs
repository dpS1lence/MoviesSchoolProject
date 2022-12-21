using System.ComponentModel.DataAnnotations;

namespace Movies.Data.Models
{
    public class Actor
    {
        public Actor()
        {
            MovieActors = new HashSet<MovieActor>();
        }

        [Key]
        public int ActorId { get; set; }

        public string FullName { get; set; } = null!;

        public string Bio { get; set; } = null!;

        public string ProfilePictureUrl { get; set; } = null!;

        //Relations
        public ICollection<MovieActor> MovieActors { get; set; } = null!;
    }
}
