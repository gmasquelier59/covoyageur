﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EVS.Core.Models
{
    [Table("feedback")]
    public class Feedback
    {
        [Column("id", TypeName = "char(36)")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("ride_id", TypeName = "char(36)")]
        public Guid RideId { get; set; }
        public Ride Ride { get; set; } = null!;

        [Column("user_id", TypeName = "char(36)")]
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        [Required, Range(1, 5), Column("note")]
        public int Note { get; set; }

        [Required, MaxLength(500), Column("comments")]
        public string Comments { get; set; } = string.Empty;


    }
}
