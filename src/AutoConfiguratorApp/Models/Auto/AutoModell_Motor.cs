using System.ComponentModel.DataAnnotations;

namespace AutoConfiguratorApp.Models.Auto
{
    //CLR Class for Join Table
    public class AutoModell_Motor : EntityBase
    {
        [Key]
        [Required]
        public int AutoModell_MotorId { get; set; }

        [Required]
        public int AutoModellId { get; set; }
        public AutoModell AutoModell { get; set; }

        [Required]
        public int MotorId { get; set; }
        public Motor Motor { get; set; }
    }
}
