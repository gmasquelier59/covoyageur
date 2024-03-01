using System.ComponentModel.DataAnnotations;

namespace EVS.Core.Models
{
    public class User
    {
        public Guid Id { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; } = string.Empty;
        
        [Required, MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required, MaxLength(20)]
        public string Pseudo { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string Password { get; set; } = string.Empty;

        [Required, Length(10, 10)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public DateTime? Birthday { get; set; }

        [Required, MaxLength(200)]
        public string Photo { get; set; } = string.Empty;

        [Required, MaxLength(200)]
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

        public List<Ride> Rides { get; set; } = new List<Ride>();

        public List<Reservation> Reservations { get; set; } = new List<Reservation>();

        public List<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    }
}
