using System.ComponentModel.DataAnnotations;

namespace AutoConfiguratorApp.Models.Auto
{
    public class AutoModell_Lackierung : EntityBase
    {
        [Key]
        [Required]
        public int AutoModell_LackierungId { get; set; }

        [Required]
        //[ForeignKey("IdRefAutoModell")]
        public int AutoModellId { get; set; }
        public AutoModell AutoModell { get; set; }

        [Required]
        //[ForeignKey("IdRefLackierung")]
        public int LackierungId { get; set; }
        public Lackierung Lackierung { get; set; }
    }
}
