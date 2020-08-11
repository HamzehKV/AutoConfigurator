using System.ComponentModel.DataAnnotations;

namespace AutoConfiguratorApp.Models.Auto
{
    public class Hersteller : EntityBase
    {
        [Key]
        [Required]
        public int HerstellerId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}