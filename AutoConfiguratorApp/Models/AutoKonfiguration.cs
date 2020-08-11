using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoConfiguratorApp.Models.Auto;

namespace AutoConfiguratorApp.Models
{
    public class AutoKonfiguration
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [ForeignKey("IdRef_AM_M")]
        public AutoModell AutoModel { get; set; }

        //[Required]
        //[ForeignKey("IdRef_AM_F")]
        //public 

        [Required]
        private DateTime CreatedAt { get; set; }

        [Required]
        private DateTime UpdateAt { get; set; }

    }
}