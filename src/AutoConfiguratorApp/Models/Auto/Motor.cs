using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoConfiguratorApp.Models.Auto
{
    public class Motor : EntityBase
    {
        [Key]
        [Required]
        public int MotorId { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public int Leistung { get; set; }

        public ICollection<AutoModell_Motor> AutoModell_Motors { get; set; }
    }

}