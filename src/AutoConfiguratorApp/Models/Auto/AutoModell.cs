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

        //[Required]
        //[ForeignKey("AutoModell_Motors")]
        //public int AutoModell_MotorsRefId { get; set; }
        //public AutoModell_Motor AutoModell_Motors { get; set; }

        //[Required]
        //[ForeignKey("AutoModell_Felge")]
        //public int AutoModell_FelgeRefId { get; set; }
        //public AutoModell_Felge AutoModell_Felge { get; set; }

        //[Required]
        //[ForeignKey("AutoModell_Lackierung")]
        //public int AutoModell_LackierungRefId { get; set; }
        //public AutoModell_Lackierung AutoModell_Lackierung { get; set; }
        //public ICollection<AutoModell_Motor> AutoModell_Motors { get; set; }
        //public ICollection<AutoModell_Felge> AutoModell_Felges { get; set; }
        //public ICollection<AutoModell_Lackierung> AutoModell_Lackierungs { get; set; }

    }
}