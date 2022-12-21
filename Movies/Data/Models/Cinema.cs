using System.ComponentModel.DataAnnotations;

namespace Movies.Data.Models
{
    public class Cinema
    {
        public Cinema()
        {
            Movies = new HashSet<Movie>();
        }

        [Key]
        public int CinemaId { get; set; }

        public string Logo { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        //Relations
        public ICollection<Movie> Movies { get; set; } = null!;
    }
}
