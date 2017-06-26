using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using App.Core.Entites;

namespace App.WebInfo.Entities.Concrete
{
    public class Ilce : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IlceId { get; set; }
       
        [MaxLength(100)]
        public string IlceName { get; set; }

        public virtual Il Il { get; set; }
    }

}
