using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoConfiguratorApp.Models.SonderAusstattungen
{
    public class SonderAusstattung
    {
        [Key]
        [Required]
        public int Id { get; set; }

        
        [ForeignKey("IdRef_FSS")]
        public FahrSicherheitsSystem FahrSicherheitsSystem { get; set; }

        
        [ForeignKey("IdRef_KA")]
        public KlimaAnlage KlimaAnlage { get; set; }

        
        [ForeignKey("IdRef_NS")]
        public NavigationsSystem NavigationsSystem { get; set; }

        
        [ForeignKey("IdRef_PA")]
        public ParkAssistentSystem ParkAssistent { get; set; }

        [ForeignKey("IdRef_SS")]
        public SoundSystem SoundSystem { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

    }
}