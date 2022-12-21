using System.ComponentModel.DataAnnotations;

namespace Movies.Data.Models
{
    public class Producer
    {
        public Producer()
        {
            Movies = new HashSet<Movie>();
        }

        [Key]
        public int ProducerId { get; set; }

        public string FullName { get; set; } = null!;

        public string Bio { get; set; } = null!;

        public string ProfilePictureUrl { get; set; } = null!;

        //Relations
        public ICollection<Movie> Movies { get; set; } = null!;
    }
}
