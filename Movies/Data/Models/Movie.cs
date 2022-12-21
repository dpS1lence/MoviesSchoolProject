using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Movies.Data.Models.Enums;

namespace Movies.Data.Models
{
    public class Movie
    {
        public Movie()
        {
            MovieActors = new HashSet<MovieActor>();
        }

        [Key]
        public int MovieId { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string Price { get; set; } = null!;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }

        [ForeignKey("CinemaId")]
        public int CinemaId { get; set; }

        public Cinema Cinema { get; set; } = null!;

        [ForeignKey("ProducerId")]
        public int ProducerID { get; set; }

        public Producer Producer { get; set; } = null!;

        //Relations
        public ICollection<MovieActor> MovieActors { get; set; } = null!;
    }
}
