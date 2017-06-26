using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using App.Core.Entites;

namespace App.WebInfo.Entities.Concrete
{
    public class IkametDurumu : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IkametDurumuId { get; set; }

        [MaxLength(100)]
        public string IkametDurumuName { get; set; }
    }

}
