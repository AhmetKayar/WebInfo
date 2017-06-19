using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.WebInfo.Entities.Concrete
{
    public class KanGrubu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KanGrubuId { get; set; }
        [Required]
        [MaxLength(100)]
        public string KanGrubuName { get; set; }
    }

}
