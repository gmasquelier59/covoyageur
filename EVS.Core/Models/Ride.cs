using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace EVS.Core.Models
{
    public class Ride
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; } = new User();

        [Required, MaxLength(50)]
        public string StartCity { get; set; } = string.Empty;

        [Required]
        public Double StartLatitude { get; set; }

        [Required]
        public Double StartLongitude { get; set; }

        [Required, MaxLength(50)]
        public string EndCity { get; set; } = string.Empty;

        [Required]
        public Double EndLatitude { get; set; }

        [Required]
        public Double EndtLongitude { get; set; }

        [Required]
        public int Distance { get; set; }

        [Required]
        public DateTime Departure { get; set; }

        [Required]
        public Double Price { get; set; }

        [Required, Range(1, 10)]
        public int Seats { get; set; }

        public List<Reservation> Reservations { get; set; } = new List<Reservation>();

        public List<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    }
}
