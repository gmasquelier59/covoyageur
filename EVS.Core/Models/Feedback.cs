using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EVS.Core.Models
{
    public class Feedback
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid RideId { get; set; }
        public Ride Ride { get; set; } = new Ride();

        public Guid UserId { get; set; }
        public User User { get; set; } = new User();

        [Required, Range(1, 5)]
        public int Note { get; set; }

        [Required, MaxLength(500)]
        public string Comment { get; set; } = string.Empty;


    }
}
