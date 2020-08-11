using System.ComponentModel.DataAnnotations;

namespace AutoConfiguratorApp.Models.SonderAusstattungen
{
    public class NavigationsSystem : EntityBase
    {
        [Key]
        [Required]
        public int NavigationsSystemId { get; set; }

        [Required]
        public string Model { get; set; }
    }
}