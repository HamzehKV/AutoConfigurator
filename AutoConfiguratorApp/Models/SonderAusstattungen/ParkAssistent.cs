using System;
using System.ComponentModel.DataAnnotations;

namespace AutoConfiguratorApp.Models.SonderAusstattungen
{
    public class ParkAssistent
    {
        [Key]
        [Required]
        private int Id { get; set; }

        [Required]
        private string Model { get; set; }

        [Required]
        private DateTime CreatedAt { get; set; }

        [Required]
        private DateTime UpdateAt { get; set; }

    }
}