using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.WebInfo.Entities.Concrete
{
    public class IkametDurumu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IkametDurumuId { get; set; }
        [Required]
        [MaxLength(100)]
        public string IkametDurumuName { get; set; }
    }

}
