using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoConfiguratorApp.Models.SonderAusstattungen
{
    public class SonderAusstattung
    {
        [Key]
        [Required]
        private int Id { get; set; }

        [Required]
        [ForeignKey("IdRef_FSS")]
        private FahrSicherheitsSystem FahrSicherheitsSystem { get; set; }

        [Required]
        [ForeignKey("IdRef_KA")]
        private KlimaAnlage KlimaAnlage { get; set; }

        [Required]
        [ForeignKey("IdRef_NS")]
        private NavigationsSystem NavigationsSystem { get; set; }

        [Required]
        [ForeignKey("IdRef_PA")]
        private ParkAssistent ParkAssistent { get; set; }

        [Required]
        [ForeignKey("IdRef_SS")]
        private SoundSystem SoundSystem { get; set; }

        [Required]
        private DateTime CreatedAt { get; set; }

        [Required]
        private DateTime UpdateAt { get; set; }

    }
}