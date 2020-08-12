using AutoConfiguratorApp.Models.Auto;
using AutoConfiguratorApp.Models.SonderAusstattungen;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoConfiguratorApp.Models
{
    public class AutoKonfiguration : EntityBase
    {
        [Key]
        [Required]
        public int AutoKonfigurationId { get; set; }

        [Required]
        [ForeignKey("AutoModell_Felge")]
        public int AM_F_RefId { get; set; }
        public AutoModell_Felge AutoModell_Felge { get; set; }

        [Required]
        [ForeignKey("AutoModell_Lackierung")]
        public int AM_L_RefId { get; set; }
        public AutoModell_Lackierung AutoModell_Lackierung { get; set; }

        [Required]
        [ForeignKey("AutoModell_Motor")]
        public int AM_M_RefId { get; set; }
        public AutoModell_Motor AutoModell_Motor { get; set; }

        // As the Following Attributes are optional we can let them be null
#nullable enable
        // SonderAusstattungen navigation property
        [ForeignKey("FahrSicherheitsSystem")]
        public int? FSS_RefId { get; set; }
        public FahrSicherheitsSystem? FahrSicherheitsSystem { get; set; }

        // KlimaAnlage navigation property
        [ForeignKey("KlimaAnlage")]
        public int? KA_RefId { get; set; }
        public KlimaAnlage? KlimaAnlage { get; set; }

        // NavigationsSystem navigation property
        [ForeignKey("NavigationsSystem")]
        public int? NS_RefId { get; set; }
        public NavigationsSystem? NavigationsSystem { get; set; }

        // ParkAssistentSystem navigation property
        [ForeignKey("ParkAssistentSystem")]
        public int? PAS_RefId { get; set; }
        public ParkAssistentSystem? ParkAssistentSystem { get; set; }

        // NavigationsSystem navigation property
        [ForeignKey("SoundSystem")]
        public int? SS_RefId { get; set; }
        public SoundSystem? SoundSystem { get; set; }
    }
}