using System;
using System.ComponentModel.DataAnnotations;

namespace AutoConfiguratorApp.Models.Auto
{
    public class Motor
    {
        [Key]
        [Required]
        private int Id { get; set; }

        [Required]
        private string name { get; set; }

        [Required]
        private int Motorleistung { get; set; }

        [Required]
        private DateTime CreatedAt { get; set; }

        [Required]
        private DateTime UpdateAt { get; set; }
    }

}