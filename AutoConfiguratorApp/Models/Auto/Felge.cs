using System;
using System.ComponentModel.DataAnnotations;

namespace AutoConfiguratorApp.Models.Auto
{
    public class Felge
    {
        [Key]
        [Required]
        private int Id { get; set; }

        [Required]
        private int Size { get; set; }

        [Required]
        private string material { get; set; }

        [Required]
        private DateTime CreatedAt { get; set; }

        [Required]
        private DateTime UpdateAt { get; set; }
    }
}
