using System.ComponentModel.DataAnnotations;

namespace AutoConfiguratorApp.Models.SonderAusstattungen
{
    public class SoundSystem : EntityBase
    {
        [Key]
        [Required]
        public int SoundSystemId { get; set; }

        [Required]
        public string Model { get; set; }
    }
}