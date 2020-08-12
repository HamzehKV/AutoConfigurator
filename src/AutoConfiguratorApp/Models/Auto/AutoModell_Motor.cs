using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoConfiguratorApp.Models.Auto
{
    //CLR Class for Join Table
    public class AutoModell_Motor : EntityBase
    {
        [Key]
        [Required]
        public int AutoModell_MotorId { get; set; }

        [Required]
        [ForeignKey("AutoModell")]
        public int AutoModellRefId { get; set; }
        public AutoModell AutoModell { get; set; }

        [Required]
        [ForeignKey("Motor")]
        public int MotorRefId { get; set; }
        public Motor Motor { get; set; }
    }
}
