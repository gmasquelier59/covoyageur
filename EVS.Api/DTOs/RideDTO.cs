using EVS.Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EVS.Api.DTOs
{
    public class RideDTO
    {
        [Required, MaxLength(50)]
        public string? StartCity { get; set; }
        [Required]
        public Double StartLatitude { get; set; }
        [Required]
        public Double StartLongitude { get; set; }
        [Required, MaxLength(50)]
        public string? EndCity { get; set; }
        [Required]
        public Double EndLatitude { get; set; }
        [Required]
        public Double EndLongitude { get; set; }
        [Required]
        public int Distance { get; set; }
        [Required]
        public DateTime Departure {  get; set; }
        [Required]
        public Double Price { get; set; }
        [Required, Range (1, 10)]
        public int Seats {  get; set; }

        [Required]
        public Guid UserId { get; set; }
    }
}
