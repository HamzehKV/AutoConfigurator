using System;
using System.ComponentModel.DataAnnotations;

namespace AutoConfiguratorApp.Models.Auto
{
    public class Motor
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Model{ get; set; }

        [Required]
        public int Leistung { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }
    }

}