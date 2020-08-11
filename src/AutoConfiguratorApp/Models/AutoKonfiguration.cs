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
        [ForeignKey("IdRef_AM_F")]
        //public int AutoModell_FelgeId { get; set; }
        public AutoModell_Felge AutoModell_Felge { get; set; }

        [Required]
        [ForeignKey("IdRef_AM_L")]
        //public int AutoModell_LackierungId { get; set; }
        public AutoModell_Lackierung AutoModell_Lackierung { get; set; }

        [Required]
        [ForeignKey("IdRef_AM_M")]
        //public int AutoModell_MotorId { get; set; }
        public AutoModell_Motor AutoModell_Motor { get; set; }


        // As the Following Attributes are optional we can let them be null
#nullable enable
        // SonderAusstattungen navigation property
        [ForeignKey("IdRefFSS")]
        public FahrSicherheitsSystem? FahrSicherheitsSystem { get; set; }

        // KlimaAnlage navigation property
        [ForeignKey("IdRefKA")]
        public KlimaAnlage? KlimaAnlage { get; set; }

        // NavigationsSystem navigation property
        [ForeignKey("IdRefNS")]
        public NavigationsSystem? NavigationsSystem { get; set; }

        // ParkAssistentSystem navigation property
        [ForeignKey("IdRefPAS")]
        public ParkAssistentSystem? ParkAssistentSystem { get; set; }

        // NavigationsSystem navigation property
        [ForeignKey("IdRefSS")]
        public SoundSystem? SoundSystem { get; set; }
    }
}