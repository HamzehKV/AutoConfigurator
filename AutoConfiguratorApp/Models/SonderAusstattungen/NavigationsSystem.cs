using System;
using System.ComponentModel.DataAnnotations;

namespace AutoConfiguratorApp.Models.SonderAusstattungen
{
    public class NavigationsSystem
    {
        [Key]
        [Required]
        private int Id { get; set; }

        [Required]
        private string Name { get; set; }

        [Required]
        private DateTime CreatedAt { get; set; }

        [Required]
        private DateTime UpdateAt { get; set; }

    }
}