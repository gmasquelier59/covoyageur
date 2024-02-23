using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace EVS.Core.Models
{
    public class Ride
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public User User { get; set; } = new User();

        [Required]
        public string StartCity { get; set; } = string.Empty;

        [Required]
        public Double StartLatitude { get; set; }

        [Required]
        public Double StartLongitude { get; set; }

        [Required]
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

        [Required]
        public int Seats { get; set; }

        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
        public List<Feedback> Feedbacks { get; set; } = new List<Feedback> { };

        public static Guid FirstOrDefault(Func<object, bool> value, object )
        {
            throw new NotImplementedException();
        }

        public Guid FirstOrDefaultIt(Ride ride, User user)
        {
            return ride.UserId;
        }

        
    }
}
