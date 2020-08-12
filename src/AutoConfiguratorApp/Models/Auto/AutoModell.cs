using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoConfiguratorApp.Models.Auto
{
    public class AutoModell : EntityBase
    {
        [Key]
        [Required]
        public int AutoModellId { get; set; }

        [Required]
        [MaxLength(30)]
        public string ModelName { get; set; }

        [Required]
        [ForeignKey("Hersteller")]
        public int Hersteller_RefId { get; set; }
        public Hersteller Hersteller { get; set; }
    }
}