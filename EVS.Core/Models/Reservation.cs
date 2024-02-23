using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EVS.Core.Enums;

namespace EVS.Core.Models
{
    public class Reservation
    {
        [Key]
        public Guid ReservationId { get; set; }

        [ForeignKey("Ride")]
        public Ride IdRide { get; set; } = new Ride();

        [ForeignKey("User")]
        public User UserId { get; set; } = new User();

        [Required]
        public DateTime ReservationDate { get; set; }

        [Required]
        public ReservationStatus Status { get; set; } // Peut être "Pending", "Confirmed", etc.
    }
}
