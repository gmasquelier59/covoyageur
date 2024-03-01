using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EVS.Core.Enums;

namespace EVS.Core.Models
{
    [Table("reservation")]
    public class Reservation
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Column("ride_id")]
        public Guid RideId { get; set; }
        public Ride Ride { get; set; } = new Ride();

        [Column("user_id")]
        public Guid UserId { get; set; }
        public User User { get; set; } = new User();

        [Required, Column("reservation_date")]
        public DateTime ReservationDate { get; set; }

        [Required, Column("status")]
        public ReservationStatus Status { get; set; }
    }
}
