using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EVS.Core.Enums;

namespace EVS.Core.Models
{
    public class Reservation
    {
        public Guid Id { get; set; }

        public Guid RideId { get; set; }
        public Ride Ride { get; set; } = new Ride();

        public Guid UserId { get; set; }
        public User User { get; set; } = new User();

        [Required]
        public DateTime ReservationDate { get; set; }

        [Required]
        public ReservationStatus Status { get; set; }
    }
}
