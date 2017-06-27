using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.WebInfo.Entities.Concrete
{
    public class SosyalYardimDurumu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SosyalYardimDurumuId { get; set; }

        [MaxLength(100)]
        public string SosyalYardimDurumuName { get; set; }

    }

}
