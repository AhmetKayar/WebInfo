using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.WebInfo.Entities.Concrete
{
    public class EgitimDurumu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EgitimDurumuId { get; set; }
        [Required]
        [MaxLength(100)]
        public string EgitimDurumuName { get; set; }
    }

}
