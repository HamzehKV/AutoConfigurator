using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoConfiguratorApp.Models.Auto
{
    public class Felge : EntityBase
    {
        [Key]
        [Required]
        [Column(Order = 0)]
        public int FelgeId { get; set; }

        [Required]
        [Column(Order = 1)]
        public int Size { get; set; }

        [Column(Order = 2)]
        public string Material { get; set; }
    }
}
