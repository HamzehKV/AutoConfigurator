using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoConfiguratorApp.Models.Auto
{
    public class AutoModell_Lackierung : EntityBase
    {
        [Key]
        [Required]
        public int AutoModell_LackierungId { get; set; }

        [Required]
        [ForeignKey("AutoModell")]
        public int AutoModellRefId { get; set; }
        public AutoModell AutoModell { get; set; }

        [Required]
        [ForeignKey("Lackierung")]
        public int LackierungRefId { get; set; }
        public Lackierung Lackierung { get; set; }
    }
}
