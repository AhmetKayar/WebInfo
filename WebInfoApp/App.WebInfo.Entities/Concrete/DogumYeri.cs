using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.WebInfo.Entities.Concrete
{
    /// <summary>
    /// Ülkeler Olacak
    /// </summary>
    public class DogumYeri
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DogumYeriId { get; set; }

        [Required]
        [MaxLength(100)]
        public string DogumYeriName { get; set; }
    }

}
