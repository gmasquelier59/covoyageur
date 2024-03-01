using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EVS.Api.DTOs
{
    public class FeedbackDTO
    {
        [Required, Range(1, 5)]
        public int Note { get; set; }

        [Required, MaxLength(500)]
        public string Comments { get; set; }
    }
}
