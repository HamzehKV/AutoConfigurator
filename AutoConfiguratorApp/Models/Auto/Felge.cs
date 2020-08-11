using System;
using System.ComponentModel.DataAnnotations;

namespace AutoConfiguratorApp.Models.Auto
{
    public class Felge
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int Size { get; set; }


        public string Material { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }
    }
}
