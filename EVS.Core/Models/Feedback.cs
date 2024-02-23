using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EVS.Core.Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }

        [ForeignKey("Driver")]
        public int RideId { get; set; }
        public Ride Ride { get; set; } = new Ride();

        [ForeignKey("Passenger")]
        public int UserId { get; set; }
        public User User { get; set; } = new User();

        [Required]
        public int Note { get; set; } // Peut être une valeur entre 1 et 5

        [Required]
        public string? Comment { get; set; }

        
    }
}
