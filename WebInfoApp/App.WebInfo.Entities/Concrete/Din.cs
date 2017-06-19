using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.WebInfo.Entities.Concrete
{
    public class Din
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DinId { get; set; }
        [Required]
        [MaxLength(100)]
        public string DinName { get; set; }
    }

}
