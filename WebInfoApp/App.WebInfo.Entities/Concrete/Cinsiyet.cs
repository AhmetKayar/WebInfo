using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.WebInfo.Entities.Concrete
{
    public class Cinsiyet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CinsiyeId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CinsiyetName { get; set; }

    }

}
