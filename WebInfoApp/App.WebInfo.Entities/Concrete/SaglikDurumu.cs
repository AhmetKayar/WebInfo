using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using App.Core.Entites;

namespace App.WebInfo.Entities.Concrete
{
    public class SaglikDurumu : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SaglikDurumuId { get; set; }

        [MaxLength(100)]
        public string SaglikDurumuName { get; set; }
    }
}