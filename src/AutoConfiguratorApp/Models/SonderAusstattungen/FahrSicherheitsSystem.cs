using System.ComponentModel.DataAnnotations;

namespace AutoConfiguratorApp.Models.SonderAusstattungen
{
    public class FahrSicherheitsSystem : EntityBase
    {
        [Key]
        [Required]
        public int FahrSicherheitsSystemId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}