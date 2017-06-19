using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.WebInfo.Entities.Concrete
{
    public class Ilce
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IlceId { get; set; }
        [Required]
        [MaxLength(100)]
        public string IlceName { get; set; }

        public virtual Il Il { get; set; }
    }

}
