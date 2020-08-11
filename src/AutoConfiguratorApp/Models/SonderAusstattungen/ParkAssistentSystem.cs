using System.ComponentModel.DataAnnotations;

namespace AutoConfiguratorApp.Models.SonderAusstattungen
{
    public class ParkAssistentSystem : EntityBase
    {
        [Key]
        [Required]
        public int ParkAssistentSystemId { get; set; }

        [Required]
        public string Model { get; set; }
    }
}