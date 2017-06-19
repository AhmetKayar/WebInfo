using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.WebInfo.Entities.Concrete
{
    public class IslemYapan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IslemYapanId { get; set; }
        [Required]
        [MaxLength(100)]
        public string IslemYapanName { get; set; }
    }

}
