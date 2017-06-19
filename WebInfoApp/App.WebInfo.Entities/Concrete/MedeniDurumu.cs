using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.WebInfo.Entities.Concrete
{
    public class MedeniDurumu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MedeniDurumuId { get; set; }
        [Required]
        [MaxLength(100)]
        public string MedeniDurumuName { get; set; }
    }

}
