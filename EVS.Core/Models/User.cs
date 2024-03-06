using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EVS.Core.Models
{
    [Table("user")]
    [Index(nameof(Pseudo), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        [Column("id")]
        public Guid Id { get; set; }

        [Required, MaxLength(50), Column("lastname")]
        public string LastName { get; set; } = string.Empty;
        
        [Required, MaxLength(50), Column("firstname")]
        public string FirstName { get; set; } = string.Empty;

        [Required, MaxLength(20), Column("pseudo")]
        public string Pseudo { get; set; } = string.Empty;

        [Required, MaxLength(100), Column("email")]
        public string Email { get; set; } = string.Empty;

        [Required, MaxLength(100), Column("password")]
        public string Password { get; set; } = string.Empty;

        [Required, Length(10, 10), MaxLength(10), Column("phone_number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required, Column("birthday")]
        public DateTime? Birthday { get; set; }

        [Required, MaxLength(200), Column("photo")]
        public string Photo { get; set; } = string.Empty;

        [MaxLength(200), Column("car_description")]
        public string CarDescription { get; set; } = string.Empty;

        [Required, Column("is_admin")]
        public Boolean IsAdmin = false;

        [Required, Column("accept_smoker")]
        public Boolean AcceptSmoker =false;

        [Required, Column("accept_pet")]
        public Boolean AcceptPet = false;

        [Required, Column("accept_talk")]
        public Boolean AcceptSmallTalk = false;

        [Required, Column("accept_music")]
        public Boolean AcceptMusic = true;

        [Required, Column("accept_food")]
        public Boolean AcceptFood = false;

        public List<Ride> Rides { get; } = new List<Ride>();

        public List<Reservation> Reservations { get; } = new List<Reservation>();

        public List<Feedback> Feedbacks { get; } = new List<Feedback>();
    }
}
