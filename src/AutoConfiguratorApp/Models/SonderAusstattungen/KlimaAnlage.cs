using System.ComponentModel.DataAnnotations;

namespace AutoConfiguratorApp.Models.SonderAusstattungen
{
    public class KlimaAnlage : EntityBase
    {
        [Key]
        [Required]
        public int KlimaAnlageId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}