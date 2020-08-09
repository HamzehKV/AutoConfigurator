using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoConfiguratorApp.Models.Auto;

namespace AutoConfiguratorApp.Models
{
    public class AutoConfiguration
    {
        [Key]
        [Required]
        private int Id { get; set; }

        [Required]
        [ForeignKey("IdRef_AM_M")]
        private AutoModel AutoModel { get; set; }

        [Required]
        private string ConfigUri { get; set; }

        [Required]
        private DateTime CreatedAt { get; set; }

        [Required]
        private DateTime UpdateAt { get; set; }

    }
}