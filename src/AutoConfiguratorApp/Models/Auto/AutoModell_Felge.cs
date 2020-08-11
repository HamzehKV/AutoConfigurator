using System.ComponentModel.DataAnnotations;

namespace AutoConfiguratorApp.Models.Auto
{
    public class AutoModell_Felge : EntityBase
    {
        [Key]
        [Required]
        public int AutoModell_FelgeId { get; set; }

        [Required]
        public int AutoModellId { get; set; }
        public AutoModell AutoModell { get; set; }

        [Required]
        public int FelgeId { get; set; }
        public Felge Felge { get; set; }
    }
}
