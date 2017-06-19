using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.WebInfo.Entities.Concrete
{
    public class Uyruk
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UyrukId { get; set; }
        [Required]
        [MaxLength(100)]
        public string UyrukName { get; set; }
    }

}
