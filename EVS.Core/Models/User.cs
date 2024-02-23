using System.ComponentModel.DataAnnotations;

namespace EVS.Core.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string LastName { get; set; } = string.Empty;
        
        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? Pseudo { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public string? PhoneNumber { get; set; }

        [Required]
        public DateTime? Birthday { get; set; }

        [Required]
        public string? Photo { get; set; }

        [Required]
        public string? CarDescription { get; set; }

        [Required]
        public Boolean IsAdmin = false;

        [Required]
        public Boolean AcceptSmoker =false;

        [Required]
        public Boolean AcceptPet = false;

        [Required]
        public Boolean AcceptSmallTalk = false;

        [Required]
        public Boolean AcceptMusic = true;

        [Required]
        public Boolean AcceptFood = false;
        // Autres propriétés utilisateur comme nom, prénom, etc.

        public List<Ride> Rides { get; set; }
        public List<Reservation> Reservations { get; set; }
        public List<Feedback> Feedbacks { get; set; }
    }
}
