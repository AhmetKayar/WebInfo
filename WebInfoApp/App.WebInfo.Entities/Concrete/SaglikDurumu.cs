using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.WebInfo.Entities.Concrete
{
    public class SaglikDurumu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SaglikDurumuId { get; set; }
        [Required]
        [MaxLength(100)]
        public string SaglikDurumuName { get; set; }
    }
}