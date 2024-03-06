using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace EVS.Core.Models
{
    [Table("ride")]
    public class Ride
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("user_id")]
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        [Required, MaxLength(50), Column("start_city")]
        public string StartCity { get; set; } = string.Empty;

        [Required, Column("start_latitude")]
        public Double StartLatitude { get; set; }

        [Required, Column("start_longitude")]
        public Double StartLongitude { get; set; }

        [Required, MaxLength(50), Column("end_city")]
        public string EndCity { get; set; } = string.Empty;

        [Required, Column("end_latitude")]
        public Double EndLatitude { get; set; }

        [Required, Column("end_longitude")]
        public Double EndLongitude { get; set; }

        [Required, Column("distance")]
        public int Distance { get; set; }

        [Required, Column("departure")]
        public DateTime Departure { get; set; }

        [Required, Column("price")]
        public Double Price { get; set; }

        [Required, Range(1, 10), Column("seats")]
        public int Seats { get; set; }

        public List<Reservation> Reservations { get; set; } = new List<Reservation>();

        public List<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    

        public static object Find(Guid rideId)
        {
            throw new NotImplementedException();
        }
    }
}
