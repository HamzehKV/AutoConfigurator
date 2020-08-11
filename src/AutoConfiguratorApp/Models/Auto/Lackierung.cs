using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoConfiguratorApp.Models.Auto
{
    public class Lackierung : EntityBase
    {
        [Key]
        [Required]
        public int LackierungId { get; set; }

        [Required]
        public string Name { get; set; }

        public int Code { get; set; }

        public ICollection<AutoModell_Lackierung> AutoModell_Lackierungs { get; set; }
    }
}