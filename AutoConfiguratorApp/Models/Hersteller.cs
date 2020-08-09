using System;
using System.ComponentModel.DataAnnotations;

namespace AutoConfiguratorApp.Models
{
    public class Hersteller
    {
        [Key]
        [Required]
        private int id { get; set; }

        [Required]
        private string Name { get; set; }

        [Required]
        private DateTime CreatedAt { get; set; }

        [Required]
        private DateTime UpdateAt { get; set; }


    }
}