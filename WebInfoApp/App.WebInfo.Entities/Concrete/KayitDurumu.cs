using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.WebInfo.Entities.Concrete
{
    public class KayitDurumu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KayitDurumuId { get; set; }
        [Required]
        [MaxLength(100)]
        public string KayitDurumuName { get; set; }
    }

}
