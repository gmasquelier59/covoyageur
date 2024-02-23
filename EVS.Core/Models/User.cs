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
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string Pseudo { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public DateTime? Birthday { get; set; }

        [Required]
        public string Photo { get; set; } = string.Empty;

        [Required]
        public string CarDescription { get; set; } = string.Empty;

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

        public List<Ride> Rides { get; set; } = new List<Ride>();
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
        public List<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    }
}
