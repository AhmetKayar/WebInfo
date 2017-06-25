using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using App.Core.Entites;

namespace App.WebInfo.Entities.Concrete
{
    /// <summary>
    /// Ülkeler Olacak
    /// </summary>
    public class DogumYeri:IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DogumYeriId { get; set; }

        [Required]
        [MaxLength(100)]
        public string DogumYeriName { get; set; }
    }

}
