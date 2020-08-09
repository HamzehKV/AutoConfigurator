using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoConfiguratorApp.Models.SonderAusstattungen;

namespace AutoConfiguratorApp.Models.Auto
{
    public class AutoModel
    {
        [Key]
        [Required]
        private int Id { get; set; }

        [Required]
        [ForeignKey("IdRef_Hersteller")]
        private Hersteller Hersteller { get; set; }

        [Required]
        [ForeignKey("IdRef_Motor")]
        private Motor Motor { get; set; }

        [Required]
        [ForeignKey("IdRef_Lackierung")]
        private Lackierung Lackierung { get; set; }

        [Required]
        [ForeignKey("IdRef_Felge")]
        private Felge Felge { get; set; }

        [Required]
        [ForeignKey("IdRef_SA")]
        private SonderAusstattung SonderAusstattungen { get; set; }

        [Required]
        [MaxLength(30)]
        private string Name { get; set; }

        [Required]
        private DateTime CreatedAt { get; set; }

        [Required]
        private DateTime UpdateAt { get; set; }
    }
}