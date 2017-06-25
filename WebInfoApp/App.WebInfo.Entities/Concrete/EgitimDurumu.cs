using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using App.Core.Entites;

namespace App.WebInfo.Entities.Concrete
{
    public class EgitimDurumu : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EgitimDurumuId { get; set; }
        [Required]
        [MaxLength(100)]
        public string EgitimDurumuName { get; set; }
    }

}
