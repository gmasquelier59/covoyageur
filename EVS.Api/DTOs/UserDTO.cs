using EVS.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace EVS.Api.DTOs
{
    public class UserDTO
    {
        [Required, MaxLength(50)]
        public string? LastName { get; set; }
        [Required, MaxLength(50)]
        public string? FirstName { get; set; }
        [Required, MaxLength(20)]
        [RegularExpression(@"^[\w-@]+$", ErrorMessage = "Utilisation d'un caractère non autorisé")]
        public string? Pseudo { get; set;}
        [Required, MaxLength(100)]
        [RegularExpression(@"^[\w-@.+]+@[\w-@.+]+\.[a-zA-Z]{2,4}$")]
        public string? Email { get; set; }
        [Required, MaxLength(100)]
        public string? Password { get; set; }
        [Required]
        [RegularExpression(@"^[0]+[1-9]+[0-9]{8}$", ErrorMessage = "Le numéro de téléphone est invalide")]
        public string? PhoneNumber { get; set; }
        [Required]
        public DateTime? Birthday { get; set;}
        [Required, MaxLength(200)]
        public string? Photo { get; set; }

        [MaxLength(200)]
        public string? CarDescription { get; set; }

        [Required]
        public Boolean IsAdmin = false;

        [Required]
        public Boolean AcceptSmoker = false;

        [Required]
        public Boolean AcceptPet = false;

        [Required]
        public Boolean AcceptSmallTalk = false;

        [Required]
        public Boolean AcceptMusic = true;

        [Required]
        public Boolean AcceptFood = false;
    }
}





