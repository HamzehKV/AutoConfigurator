using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoConfiguratorApp.Models.Auto
{
    public class AutoModell_Felge : EntityBase
    {
        [Key]
        [Required]
        public int AutoModell_FelgeId { get; set; }

        [Required]
        [ForeignKey("AutoModell")]
        public int AutoModellRefId { get; set; }
        public AutoModell AutoModell { get; set; }

        [Required]
        [ForeignKey("Felge")]
        public int FelgeRefId { get; set; }
        public Felge Felge { get; set; }
    }
}
